Public Class form_cozinheiro
    Private pedido_selecionado As Integer = 0
    Private situacao_pedido As String

    Private Sub form_cozinheiro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        form_login.Close()
        conectar_banco()
        lbl_cozinheiro.Text = sessao_nome
        If sessao_foto <> "" Then
            img_cozinheiro.Load(sessao_foto)
        End If
        atualizar()
    End Sub

    Private Sub atualizar()
        carregarMesas()
        If pedido_selecionado = 0 Then 'Carregar items do pedido ao atualizar pedidos se algum estiver selecionado
            container_infos.Visible = False
        Else
            carregarPedido(pedido_selecionado, False)
        End If
    End Sub

    Private Sub carregarMesas()
        container_pedidos.Controls.Clear()
        Dim item As ItemMesa

        rs = db.Execute("SELECT m.id, p.alterado, m.idpedido, p.situacao FROM tb_mesas m INNER JOIN tb_pedidos p ON m.idpedido = p.id WHERE p.situacao IN ('A Fazer', 'Fazendo')")
        Do Until rs.EOF
            Dim mesa_id = rs.Fields("id").Value
            Dim data_alteracao = rs.Fields("alterado").Value
            Dim pedido_id = rs.Fields("idpedido").Value
            Dim situacao = rs.Fields("situacao").Value
            item = New ItemMesa(mesa_id, data_alteracao, pedido_id, situacao, container_pedidos)
            rs.MoveNext()
        Loop
    End Sub

    Public Sub carregarPedido(id As Integer, clique As Boolean)
        If pedido_selecionado = id And clique = True Then
            Exit Sub
        End If
        container_infos.Visible = True
        pedido_selecionado = id
        container_items_pedido.Controls.Clear()
        rs = db.Execute("SELECT * FROM tb_pedidos WHERE id=" & id)

        lbl_cliente.Text = rs.Fields("nome_pedido").Value.ToString
        lbl_horario.Text = rs.Fields("alterado").Value.ToString.Substring(11, 5)
        lbl_mesa.Text = "MESA " & rs.Fields("id_mesa").Value
        lbl_mesa.Tag = rs.Fields("id_mesa").Value
        txt_obs.Text = rs.Fields("observacoes").Value
        situacao_pedido = rs.Fields("situacao").Value

        rs = db.Execute("SELECT c.nomeproduto, i.quantidade FROM tb_itens_pedido i INNER JOIN tb_cardapio c ON c.idproduto = i.idproduto WHERE i.idpedido=" & id)

        Dim itemPedido As ItemPedidoCozinheiro
        Do Until rs.EOF
            itemPedido = New ItemPedidoCozinheiro(rs.Fields("nomeproduto").Value, rs.Fields("quantidade").Value, container_items_pedido)
            rs.MoveNext()
        Loop

        If situacao_pedido = "A Fazer" Then
            btn_acao_lbl.Text = "COMEÇAR"
        Else
            btn_acao_lbl.Text = "CONCLUIR"
        End If
    End Sub

    Private Sub alterarStatusPedido(sender As Object, e As EventArgs) Handles btn_acao_box.Click, btn_acao_lbl.Click
        Dim nova_situacao As String
        If situacao_pedido = "A Fazer" Then
            nova_situacao = "Fazendo"
        Else
            nova_situacao = "Entregue"
        End If
        db.Execute("UPDATE tb_pedidos SET situacao='" & nova_situacao & "', alterado='" & Date.Now & "' WHERE id=" & pedido_selecionado)
        MsgBox("Pedido" & pedido_selecionado & " da mesa " & lbl_mesa.Tag & " atualizado")
        If nova_situacao = "Entregue" Then
            pedido_selecionado = 0
        End If
        atualizar()
    End Sub

    Private Sub logout(sender As Object, e As EventArgs) Handles btn_logout.Click
        resp = MsgBox("Deseja realmente realizar logout?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Sair")
        If resp = vbYes Then
            Me.Hide()
            form_login.Show()
        End If
    End Sub
End Class


Public Class ItemPedidoCozinheiro
    Private _nome As String
    Private _quantia As Integer
    Private _escopo As FlowLayoutPanel
    Private _container As Panel
    Private toolTip As ToolTip = New ToolTip()
    Public Sub New(nome_i As String, quantia_i As Integer, escopo_i As FlowLayoutPanel)
        _nome = nome_i
        _quantia = quantia_i
        _escopo = escopo_i
        toolTip.InitialDelay = 300
        renderizar()
    End Sub

    Private Sub renderizar()
        renderizarContainer()
        renderizarTexto(_nome, 370, ContentAlignment.MiddleLeft, 15, FontStyle.Bold)
        renderizarTexto("x" & _quantia, 70, ContentAlignment.MiddleRight, 390, FontStyle.Regular)
    End Sub

    Private Sub renderizarTexto(texto As String, largura As Integer, alinhamento As ContentAlignment, x As Integer, estilo As FontStyle)
        Dim label = New Label
        With label
            .Text = texto
            .TextAlign = alinhamento
            .Location = New Point(x, 16)
            .Font = New Font("Leelawadee", 16, estilo)
            .Size = New Size(largura, 30)
            .AutoEllipsis = True
        End With
        toolTip.SetToolTip(label, _nome)
        _container.Controls.Add(label)
    End Sub

    Private Sub renderizarContainer()
        _container = New Panel
        With _container
            .BackColor = Color.White
            .Size = New Size(475, 60)
            .Margin = New Padding(0, 0, 0, 10)
        End With
        toolTip.SetToolTip(_container, _nome)
        _escopo.Controls.Add(_container)
    End Sub

End Class


Public Class ItemMesa
    Private _mesa_id, _horario, _situacao As String
    Private _pedido_id As Integer
    Private _container As Panel
    Private _escopo As FlowLayoutPanel

    Public Sub New(id_i As Integer, horario_i As String, pedido_id_i As Integer, situacao_i As String, escopo_i As FlowLayoutPanel)
        _mesa_id = id_i
        _horario = horario_i.ToString.Substring(11, 5)
        _pedido_id = pedido_id_i
        _situacao = situacao_i
        _escopo = escopo_i
        renderizar()
    End Sub

    Private Sub clique()
        form_cozinheiro.carregarPedido(_pedido_id, True)
    End Sub

    Private Sub renderizar()
        renderizarContainer()
        renderizarIndicador()
        renderizarTexto(_horario, Color.FromArgb(170, 170, 170), ContentAlignment.MiddleRight, New Point(140, 16), FontStyle.Regular, 16)
        renderizarTexto("MESA " & _mesa_id, Color.Black, ContentAlignment.MiddleLeft, New Point(15, 15), FontStyle.Bold, 20)
    End Sub

    Private Sub renderizarIndicador()
        Dim indicador = New Panel
        With indicador
            .Size = New Size(5, 60)
            .Location = New Point(0, 0)
            If _situacao = "Fazendo" Then
                .BackColor = Color.FromArgb(43, 45, 66)
            Else
                .BackColor = Color.FromArgb(224, 30, 55)
            End If
        End With
        _container.Controls.Add(indicador)
    End Sub

    Private Sub renderizarTexto(texto As String, cor As Color, alinhamento As ContentAlignment, pos As Point, estilo As FontStyle, tamanho As Integer)
        Dim label = New Label
        With label
            .Text = texto
            .TextAlign = alinhamento
            .ForeColor = cor
            .Location = pos
            .Font = New Font("Leelawadee", tamanho, estilo)
            .Size = New Size(150, 30)
        End With
        AddHandler label.Click, AddressOf clique
        _container.Controls.Add(label)
    End Sub

    Private Sub renderizarContainer()
        _container = New Panel
        With _container
            .BackColor = Color.FromArgb(236, 240, 241)
            .Size = New Size(300, 60)
            .Margin = New Padding(0, 0, 0, 10)
            .Cursor = Cursors.Hand
        End With
        AddHandler _container.Click, AddressOf clique
        _escopo.Controls.Add(_container)
    End Sub
End Class