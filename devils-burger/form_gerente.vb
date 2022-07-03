Public Class form_gerente
    Private Sub form_gerente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        form_login.Close()
        Call atualizar()
    End Sub

    Public Sub atualizar()
        Call carregarFuncionarios()
        Call carregarDadosCardapio()
        Call carregarDadosPedidos()
        Call carregarDadosClientes()
        Call carregarLevantamentoPedidos()
        lbl_gerente_nome.Text = sessao_nome
        If sessao_foto <> "" Then
            img_gerente.Load(sessao_foto)
        End If
    End Sub

    Private Sub logout(sender As Object, e As EventArgs) Handles btn_logout.Click
        If MsgBox("Deseja mesmo sair?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Aviso") = vbYes Then
            form_aberto = Me
            Me.Hide()
            form_login.Show()
        End If
    End Sub

    Private Sub carregarFuncionarios()
        Dim painel As PainelFuncionario
        container_funcionarios.Controls.Clear()
        sql = "SELECT idfuncionario, nome, diretorio_foto, cpf, cargo FROM tb_funcionarios"
        rs = db.Execute(sql)
        Do Until rs.EOF
            Dim id = rs.Fields("idfuncionario").Value
            Dim nome = rs.Fields("nome").Value
            Dim diretorio_foto = rs.Fields("diretorio_foto").Value.ToString
            If id = sessao_id Then
                sessao_nome = nome
                sessao_foto = diretorio_foto
            End If
            painel = New PainelFuncionario(nome, rs.Fields("cpf").Value, id, diretorio_foto, rs.Fields("cargo").Value)
            rs.MoveNext()
        Loop
    End Sub

    Private Sub carregarDadosClientes()
        sql = "SELECT COUNT(*) as total FROM tb_clientes"
        rs = db.Execute(sql)
        txt_clientes_total.Text = rs.Fields("total").Value
        sql = "SELECT COUNT(*) as diarios FROM tb_pedidos WHERE CAST(adicionado AS date) ='" & Now.Date & "' AND cpf_cliente IS NOT NULL"
        rs = db.Execute(sql)
        txt_clientes_dia.Text = rs.Fields("diarios").Value
    End Sub

    Private Sub carregarDadosPedidos()
        sql = "SELECT COUNT(*) as total FROM tb_pedidos"
        rs = db.Execute(sql)
        txt_pedidos_total.Text = rs.Fields("total").Value
        sql = "SELECT COUNT(*) as diarios FROM tb_pedidos WHERE CAST(adicionado AS date) ='" & Now.Date & "'"
        rs = db.Execute(sql)
        txt_pedidos_dia.Text = rs.Fields("diarios").Value
    End Sub

    Private Sub carregarDadosCardapio()
        'Pegar as infos de tb_itens_pedido
        sql = "SELECT TOP 1 sum(i.quantidade) as quantia, c.nomeproduto FROM tb_cardapio c INNER Join tb_itens_pedido i " & _
            "ON i.idproduto = c.idproduto WHERE c.tipo in ('Principal', 'Combo') GROUP BY c.nomeproduto ORDER BY quantia desc"
        rs = db.Execute(sql)
        cardapio_lanche.Text = rs.Fields("nomeproduto").Value
        sql = "SELECT TOP 1 sum(i.quantidade) as quantia, c.nomeproduto FROM tb_cardapio c INNER Join tb_itens_pedido i " & _
            "ON i.idproduto = c.idproduto WHERE c.tipo='bebida' GROUP BY c.nomeproduto ORDER BY quantia desc"
        rs = db.Execute(sql)
        cardapio_bebida.Text = rs.Fields("nomeproduto").Value
    End Sub

    Private Sub carregarLevantamentoPedidos()
        sql = "select s.situacao_possivel as situacao, count(p.situacao) as quantia from tb_status_possiveis s " &
            "left join tb_pedidos p on s.situacao_possivel = p.situacao group by s.situacao_possivel"
        rs = db.Execute(sql)
        Do Until rs.EOF
            Dim situacao = rs.Fields("situacao").Value
            Dim quantia = rs.Fields("quantia").Value.ToString
            Select Case situacao
                Case "A Fazer"
                    lbl_p_fazer.Text = quantia
                Case "Fazendo"
                    lbl_p_fazendo.Text = quantia
                Case "Entregue"
                    lbl_p_entregues.Text = quantia
                Case "Finalizado"
                    lbl_p_finalizados.Text = quantia
                Case "Cancelado"
                    lbl_p_cancelados.Text = quantia
            End Select
            rs.MoveNext()
        Loop
    End Sub

    Private Sub btn_add_funcionario_Click(sender As Object, e As EventArgs) Handles btn_add_funcionario.Click
        Dim ficha = New ficha_funcionario("")
        ficha.Show()
    End Sub

    Private Sub btn_novo_cliente_Click(sender As Object, e As EventArgs) Handles btn_novo_cliente.Click
        form_clientes.TopMost = True
        form_clientes.Show()
    End Sub

    Private Sub abrirRelatorioCardapio(sender As Object, e As EventArgs) Handles cardapio_box.Click,
        lbl_lanche.Click, lbl_bebida.Click, cardapio_img.Click, cardapio_bebida.Click, cardapio_lanche.Click
        form_relat_cardapio.TopMost = True
        form_relat_cardapio.Show()
    End Sub

    Private Sub abrirRelatorioClientes(sender As Object, e As EventArgs) Handles txt_clientes_total.Click, clientes_box.Click,
        lbl_clientes_dia.Click, lbl_clientes_total.Click, txt_clientes_dia.Click, clientes_img.Click
        form_relat_clientes.TopMost = True
        form_relat_clientes.Show()
    End Sub

    Private Sub abrirRelatorioPedidos(sender As Object, e As EventArgs) Handles txt_pedidos_total.Click, pedidos_box.Click,
        lbl_pedidos_dia.Click, lbl_pedidos_total.Click, txt_pedidos_dia.Click, pedidos_img.Click
        form_relat_pedidos.TopMost = True
        form_relat_pedidos.Show()
    End Sub
End Class


Public Class PainelFuncionario
    Shared _index As Integer = 0
    Private _nomeFuncionario, _painelNome, _funcCPF, _diretorioFoto, _cargo, _funcID As String
    Private _container As Panel

    Public Sub New(nome_f As String, cpf_f As String, id_f As String, diretorio_img_f As String, cargo_f As String)
        _nomeFuncionario = nome_f
        _funcCPF = cpf_f
        _funcID = id_f
        _diretorioFoto = diretorio_img_f
        _cargo = cargo_f
        gerar()
    End Sub

    Private Sub gerar()
        _painelNome = "pnl_funcionario" & CStr(_index)
        _index += 1
        Call gerarContainer()
        Call gerarFoto()
        Call gerarLabelNome()
        Call gerarIcone("editar", 395)
        Call gerarIcone("fechar", 420)
        If {"Gerente", "Operador", "Cozinheiro"}.Contains(_cargo) Then
            Call gerarIcone("acesso", 365)
        End If
    End Sub

    Private Sub cliqueAcesso()
        rs = db.Execute("SELECT usuario FROM tb_acesso WHERE idfuncionario=" & _funcID)
        Dim usuario = rs.Fields("usuario").Value
        Dim form_acesso = New form_alterar_acesso(usuario, _funcID)
        form_acesso.show()
    End Sub

    Private Sub cliqueDeletar()
        Dim resp = MsgBox("Deseja realmente excluir o cadastro de '" & _nomeFuncionario & "'?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Aviso")
        If resp = vbYes Then
            deletarRegistro()
            form_gerente.container_funcionarios.Controls.Remove(_container)
            Me.Finalize()
        End If
    End Sub

    Private Sub cliqueEditar()
        Dim ficha = New ficha_funcionario(_funcCPF)
        ficha.Show()
    End Sub

    Private Sub gerarIcone(iconeNome As String, x As Integer)
        Dim icone = New PictureBox
        With icone
            .Size = New Size(20, 20)
            .Location = New Point(x, 15)
            .SizeMode = PictureBoxSizeMode.StretchImage
            .Load(Application.StartupPath & "\img\icons\" & iconeNome & ".png")
        End With
        Select Case iconeNome
            Case "acesso"
                AddHandler icone.Click, AddressOf cliqueAcesso
            Case "fechar"
                AddHandler icone.Click, AddressOf cliqueDeletar
            Case "editar"
                AddHandler icone.Click, AddressOf cliqueEditar
        End Select
        _container.Controls.Add(icone)
    End Sub

    Private Sub gerarFoto()
        Dim foto = New PictureBox
        With foto
            .Size = New Size(30, 30)
            .Location = New Point(10, 10)
            .BackColor = Color.FromArgb(255, 255, 255)
            .SizeMode = PictureBoxSizeMode.StretchImage
            If _diretorioFoto.Length > 0 Then
                .Load(_diretorioFoto)
            End If
        End With
        AddHandler foto.Click, AddressOf cliqueEditar
        _container.Controls.Add(foto)
    End Sub
    Private Sub gerarLabelNome()
        Dim label = New Label
        With label
            .Text = _nomeFuncionario
            .Location = New Point(50, 12)
            .Font = New Font("Leelawadee", 16)
            .MinimumSize = New Size(300, 30)
            .MaximumSize = New Size(300, 0)
            .AutoEllipsis = True
            If sessao_id = _funcID Then
                .ForeColor = Color.FromArgb(224, 30, 55)
            End If
        End With
        AddHandler label.Click, AddressOf cliqueEditar
        _container.Controls.Add(label)
    End Sub

    Private Sub gerarContainer()
        _container = New Panel()
        With _container
            .BackColor = Color.FromArgb(221, 221, 221)
            .Size = New Size(450, 50)
            .Name = _painelNome
            .Cursor = Cursors.Hand
        End With
        form_gerente.container_funcionarios.Controls.Add(_container)
        AddHandler _container.Click, AddressOf cliqueEditar
    End Sub

    Private Sub deletarRegistro()
        sql = "DELETE FROM tb_funcionarios WHERE cpf='" & _funcCPF & "'"
        rs = db.Execute(sql)
        If {"Gerente", "Operador", "Cozinheiro"}.Contains(_cargo) Then
            sql = "DELETE FROM tb_acesso WHERE idfuncionario='" & _funcID & "'"
            rs = db.Execute(sql)
        End If
    End Sub
End Class