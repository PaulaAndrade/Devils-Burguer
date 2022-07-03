Public Class form_pedido
    Private mesa_id As Integer
    Private quantia_produto_i As Integer = 0
    Private cliente_cpf As String = "" ' Padrão
    Private selecionados_precos As List(Of Double) = New List(Of Double)
    Private selecionados_ids As List(Of Integer) = New List(Of Integer)
    Private garcons_ids As List(Of Integer) = New List(Of Integer)
    Private nao_repetidos_ids As List(Of Integer) = New List(Of Integer)
    Private preco_total As Double = 0

    Public Sub New(id As Integer)
        mesa_id = id
        InitializeComponent()
    End Sub

    Private Sub form_pedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        popularComboGarcons()
        popularCardapio()
        lbl_mesa_id.Text = "Mesa " & CStr(mesa_id)
    End Sub

    Private Sub popularCardapio()
        Dim item As ItemCardapio
        rs = db.Execute("SELECT nomeproduto, preco, tipo, idproduto FROM tb_cardapio")
        Do Until rs.EOF
            Dim classificacao = rs.Fields("tipo").Value
            If classificacao = "bebida" Then
                item = New ItemCardapio(rs.Fields("nomeproduto").Value, rs.Fields("preco").Value, classificacao, rs.Fields("idproduto").Value, cardapio_bebidas, Me)
            Else
                item = New ItemCardapio(rs.Fields("nomeproduto").Value, rs.Fields("preco").Value, classificacao, rs.Fields("idproduto").Value, cardapio_alimentos, Me)
            End If
            rs.MoveNext()
        Loop
    End Sub

    Private Sub popularComboGarcons()
        rs = db.Execute("SELECT idfuncionario, nome FROM tb_funcionarios where cargo='Garçom'")
        Do Until rs.EOF
            Dim nome As String = rs.Fields("nome").Value
            If nome.IndexOf(" ") <> -1 Then 'Adicionar à combo apenas o primeiro nome
                nome = nome.Substring(0, nome.IndexOf(" "))
            End If
            combo_garcom.Items.Add(nome)
            garcons_ids.Add(rs.Fields("idfuncionario").Value)
            rs.MoveNext()
        Loop
    End Sub

    Public Sub adicionarItemPedido(produto As String, precoProduto As Double, idProduto As Integer)
        box_selecionados.Items.Add(produto)
        selecionados_precos.Add(precoProduto)
        selecionados_ids.Add(idProduto)
        preco_total = preco_total + precoProduto
        txt_preco_total.Text = "R$" & Format(preco_total, "0.00").ToString.Replace(".", ",")
        painel_pedido.Focus()
    End Sub
    Private Sub removerItemPedido(sender As Object, e As EventArgs) Handles box_selecionados.DoubleClick
        'As listas box_selecionados, selecionados_ids e selecionados_precos possuem os mesmos detalhes do item no mesmo index
        Dim indexListas = box_selecionados.SelectedIndex
        If indexListas = -1 Then
            Exit Sub
        End If
        Dim precoProduto As Double = selecionados_precos(indexListas)

        selecionados_ids.RemoveAt(indexListas)
        selecionados_precos.RemoveAt(indexListas)
        box_selecionados.Items.RemoveAt(indexListas)

        preco_total = preco_total - precoProduto
        txt_preco_total.Text = "R$" & Format(preco_total, "0.00").ToString.Replace(".", ",")
    End Sub


    Private Sub efetuarPedido(sender As Object, e As EventArgs) Handles btn_finalizar_box.Click, btn_finalizar_lbl.Click
        ' Para o pedido em si
        Try
            nao_repetidos_ids.Clear() 'Efetuar nova verificacao de quantia de produtos
            Dim garcom_selecionado = combo_garcom.SelectedIndex
            If garcom_selecionado = -1 Then
                MsgBox("Selecione o garçom que realizou o pedido", MsgBoxStyle.Exclamation, "Aviso")
                Exit Sub
            ElseIf txt_cliente_nome.Text = "" Then
                MsgBox("Forneça o nome do cliente do pedido", MsgBoxStyle.Exclamation, "Aviso")
                Exit Sub
            ElseIf preco_total = 0.0 Then
                MsgBox("Escolha ao menos um produto do cardápio", MsgBoxStyle.Exclamation, "Aviso")
                Exit Sub
            End If
            Dim garcom_id As Integer = garcons_ids(garcom_selecionado)
            If cliente_cpf = "" Then 'Deixar a coluna da tabela como null caso não tenha fornecido código válido
                sql = "INSERT INTO tb_pedidos (id_garcom, id_mesa, valor_total, situacao, nome_pedido, observacoes) VALUES" & _
                    "(" & garcom_id & ", " & mesa_id & ", " & preco_total.ToString.Replace(",", ".") & ", 'A Fazer', '" & _
                    txt_cliente_nome.Text & "', '" & txt_observacoes.Text & "')"
            Else
                sql = "INSERT INTO tb_pedidos (id_garcom, id_mesa, valor_total, situacao, nome_pedido, observacoes, cpf_cliente) VALUES" & _
                    "(" & garcom_id & ", " & mesa_id & ", " & preco_total.ToString.Replace(",", ".") & ", 'A Fazer', '" & _
                    txt_cliente_nome.Text & "', '" & txt_observacoes.Text & "', '" & cliente_cpf & "')"
            End If
            db.Execute(sql)
            rs = db.Execute("select TOP 1 id from tb_pedidos where id_mesa=" & mesa_id & " order by adicionado desc")
            Dim id_pedido = rs.Fields("id").Value
            For i As Integer = 0 To selecionados_ids.Count - 1
                registrarItensPedidos(i, id_pedido)
            Next
            sql = "UPDATE tb_mesas SET disponivel='N', idpedido=" & id_pedido & " WHERE id=" & mesa_id
            db.Execute(sql)
            MsgBox("Pedido realizado com sucesso", MsgBoxStyle.Information, "Sucesso")
            form_mesas.atualizarMesas()
            Me.Close()
        Catch
            MsgBox("Algum erro ao registrar o pedido ocorreu", MsgBoxStyle.Critical, "Aviso")
        End Try
    End Sub

    Private Sub registrarItensPedidos(i As Integer, id_pedido As Integer)
        'Para cada item do pedido
        Dim id As Integer = selecionados_ids(i)
        If nao_repetidos_ids.Contains(id) = True Then 'Evita adicionar novamente o mesmo item de pedido
            Exit Sub
        End If
        Dim preco_unitario As Double = selecionados_precos(i)
        Dim nome As String = box_selecionados.Items(i)
        pegarQuantiaProduto(id)
        Dim preco_quantidade As String = CStr(quantia_produto_i * preco_unitario).Replace(",", ".")
        Dim preco_u As String = preco_unitario.ToString.Replace(",", ".")

        sql = "INSERT INTO tb_itens_pedido VALUES (" & id_pedido & ", " & id & ", " & quantia_produto_i & ", " & preco_u & ", " & preco_quantidade & ")"
        db.Execute(sql)
    End Sub

    Private Sub pegarQuantiaProduto(id As Integer)
        quantia_produto_i = 0
        For Each id_atual In selecionados_ids
            If id_atual = id Then
                quantia_produto_i += 1
            End If
        Next
        nao_repetidos_ids.Add(id)
    End Sub

    Private Sub verificarCPFCliente(sender As Object, e As EventArgs) Handles btn_verificar_cpf.Click
        sql = "SELECT nome FROM tb_clientes where cpf='" & txt_cliente_cpf.Text & "'"
        rs = db.Execute(sql)
        If rs.EOF Then
            MsgBox("Este CPF de cliente cadastrado não é válido", MsgBoxStyle.Exclamation, "Aviso")
            Exit Sub
        End If
        lbl_cliente.Text = "DEVIL CLIENT"
        lbl_cliente.ForeColor = Color.FromArgb(224, 30, 55)
        lbl_cliente.Font = New Font("Leelawadee", lbl_cliente.Font.Size, CType(3, FontStyle)) 'Itálico e negrito
        txt_cliente_nome.Text = rs.Fields("nome").Value
        txt_cliente_nome.Enabled = False
        txt_cliente_cpf.Enabled = False
        cliente_cpf = txt_cliente_cpf.Text
    End Sub

    Private Sub btn_novo_cliente_Click(sender As Object, e As EventArgs) Handles btn_novo_cliente.Click, btn_novo_cliente_icon.Click, btn_novo_cliente_lbl.Click
        form_clientes.TopMost = True
        form_clientes.Show()
    End Sub
End Class


Class ItemCardapio
    Private _nome, _icone, _preco_display As String
    Private _id As Integer
    Private _preco As Double
    Private _container As Panel
    Private _escopo As FlowLayoutPanel
    Private _form_ref As Object
    Private toolTip As ToolTip = New ToolTip() 'Mostrar nome inteiro do produto com mouse em cima
    Public Sub New(nome_i As String, preco_i As Double, icone_i As String, id_i As Integer, escopo_i As FlowLayoutPanel, form_ref As Object)
        _nome = nome_i
        _preco = preco_i
        _preco_display = "R$" & Format(preco_i, "0.00").ToString.Replace(".", ",")
        _icone = icone_i
        _id = id_i
        _form_ref = form_ref
        toolTip.InitialDelay = 300
        _escopo = escopo_i
        gerar()
    End Sub

    Public Sub clique()
        _form_ref.adicionarItemPedido(_nome, _preco, _id)
    End Sub

    Private Sub gerar()
        gerarContainer()
        gerarIcone()
        gerarLabel(_nome, 35, 170, ContentAlignment.MiddleLeft)
        gerarLabel(_preco_display, 200, 80, ContentAlignment.MiddleRight)
    End Sub

    Private Sub gerarIcone()
        Dim foto = New PictureBox
        With foto
            .Load(Application.StartupPath & "\img\icons\p-" & _icone & ".png")
            .Size = New Size(20, 20)
            .Location = New Point(10, 15)
            .SizeMode = PictureBoxSizeMode.StretchImage
        End With
        toolTip.SetToolTip(foto, _nome)
        AddHandler foto.Click, AddressOf clique
        _container.Controls.Add(foto)
    End Sub

    Private Sub gerarLabel(texto As String, x As Integer, largura As Integer, alinhamento As ContentAlignment)
        Dim label = New Label
        With label
            .Text = texto
            .Font = New Font("Leelawadee", 12)
            .Location = New Point(x, 16)
            .AutoEllipsis = True
            .TextAlign = alinhamento
            .MinimumSize = New Size(largura, 23)
            .MaximumSize = New Size(largura, 23)
        End With
        toolTip.SetToolTip(label, _nome)
        AddHandler label.Click, AddressOf clique
        _container.Controls.Add(label)
    End Sub

    Private Sub gerarContainer()
        _container = New Panel()
        With _container
            .Cursor = Cursors.Hand
            .BackColor = Color.FromArgb(255, 255, 255)
            .Size = New Size(280, 50)
            .Margin = New Padding(0, 0, 0, 10)
        End With
        toolTip.SetToolTip(_container, _nome)
        AddHandler _container.Click, AddressOf clique
        _escopo.Controls.Add(_container)
    End Sub
End Class