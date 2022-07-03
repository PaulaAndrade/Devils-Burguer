Public Class form_pedido_info
    Private mesa_id As Integer = 4
    Private status As String
    Private id_pedido As Integer
    Private permitir_finalizar As Boolean = True

    Public Sub New(id As Integer)
        mesa_id = id
        InitializeComponent()
    End Sub

    Private Sub form_pedido_info_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        rs = db.Execute("SELECT idpedido FROM tb_mesas WHERE id=" & mesa_id)
        id_pedido = rs.Fields("idpedido").Value
        carregarInfos()
        carregarItensPedido()
    End Sub

    Private Sub carregarInfos()
        rs = db.Execute("SELECT valor_total, situacao, nome_pedido, adicionado FROM tb_pedidos WHERE id=" & id_pedido)
        lbl_preco_total.Text = "R$ " & Format(rs.Fields("valor_total").Value, "0.00")
        lbl_situacao.Text = rs.Fields("situacao").Value
        lbl_nome_cliente.Text = rs.Fields("nome_pedido").Value
        lbl_horario.Text = rs.Fields("adicionado").Value.ToString.Substring(11, 5)
        lbl_mesa.Text = "Mesa " & mesa_id
        If rs.Fields("situacao").Value <> "Entregue" Then
            permitir_finalizar = False
            btn_finalizar_box.BackColor = Color.FromArgb(115, 39, 62)
        End If
    End Sub

    Private Sub carregarItensPedido()
        rs = db.Execute("select i.id, c.nomeproduto, i.valor_total, i.quantidade " & _
                        "FROM tb_itens_pedido i INNER JOIN tb_cardapio c ON c.idproduto = i.idproduto WHERE i.idpedido=" & id_pedido)
        Do Until rs.EOF
            Dim id As Integer = rs.Fields("id").Value
            Dim nomeProduto As String = rs.Fields("nomeproduto").Value.ToString
            Dim precoTotal As Double = rs.Fields("valor_total").Value
            Dim quantia As Integer = rs.Fields("quantidade").Value

            Dim item As ItemPedido = New ItemPedido(id, nomeProduto, precoTotal, quantia, container_itens)
            rs.MoveNext()
        Loop
    End Sub

    Private Sub finalizarPedido(sender As Object, e As EventArgs) Handles btn_finalizar_box.Click, btn_finalizar_lbl.Click
        If permitir_finalizar = False Then
            MsgBox("O pedido ainda não foi entregue para ser finalizado", MsgBoxStyle.Information, "Aviso")
            Exit Sub
        End If
        editarPedido("finalizar", "Finalizado")
    End Sub
    Private Sub cancelarPedido(sender As Object, e As EventArgs) Handles btn_cancelar_box.Click, btn_cancelar_lbl.Click
        editarPedido("cancelar", "Cancelado")
    End Sub

    Private Sub editarPedido(palavraMsg As String, situacao As String)
        Try
            resp = MsgBox("Deseja realmente " & palavraMsg & " o pedido da mesa " & mesa_id & "?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Aviso")
            If resp = vbNo Then
                Exit Sub
            End If
            db.Execute("UPDATE tb_pedidos SET situacao='" & situacao & "' WHERE id=" & id_pedido)
            db.Execute("UPDATE tb_mesas SET idpedido=NULL, disponivel='S' WHERE id=" & mesa_id)
            form_mesas.atualizarMesas()
            Me.Close()
        Catch
            MsgBox("Algum erro ocorreu ao cancelar o pedido", MsgBoxStyle.Exclamation, "Erro")
        End Try
    End Sub
End Class


Public Class ItemPedido
    Private _id, _quantia As Integer
    Private _nome As String
    Private _preco As Double
    Private _escopo As FlowLayoutPanel
    Private _container As Panel
    Public Sub New(id_i As Integer, nome_i As String, preco_i As Double, quantia_i As Integer, escopo As FlowLayoutPanel)
        _id = id_i
        _nome = nome_i
        _preco = preco_i
        _quantia = quantia_i
        _escopo = escopo
        gerar()
    End Sub
    Private Sub gerar()
        gerarContainer()
        gerarTexto(_nome, New Point(10, 18), 250, ContentAlignment.MiddleLeft)
        gerarTexto("x" & _quantia, New Point(265, 18), 50, ContentAlignment.MiddleRight)
        gerarTexto("R$ " & Format(_preco, "0.00"), New Point(335, 18), 100, ContentAlignment.MiddleRight)
    End Sub

    Private Sub gerarTexto(texto As String, pos As Point, largura As Integer, alinhamento As ContentAlignment)
        Dim label = New Label
        With label
            .Text = texto
            .Font = New Font("Leelawadee", 14)
            .Location = pos
            .Size = New Size(largura, 26)
            .MaximumSize = New Size(largura, 26)
            .AutoEllipsis = True
            .TextAlign = alinhamento
        End With
        _container.Controls.Add(label)
    End Sub

    Private Sub gerarContainer()
        _container = New Panel
        With _container
            .BackColor = Color.FromArgb(221, 221, 221)
            .Size = New Size(445, 60)
        End With
        _escopo.Controls.Add(_container)
    End Sub
End Class