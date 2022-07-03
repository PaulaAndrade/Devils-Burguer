Public Class form_mesas
    Private mesas_cores As List(Of Panel) ' Para mudar o status (cor) da mesa no form
    Private mesas_disponibilidade As List(Of String) = New List(Of String)

    Private Sub cliqueMesas(sender As Object, e As EventArgs) Handles cntr_mesa_1.Click, cntr_mesa_2.Click, cntr_mesa_3.Click, cntr_mesa_4.Click, _
        cntr_mesa_5.Click, cntr_mesa_6.Click, cntr_mesa_7.Click, cntr_mesa_8.Click, cntr_mesa_9.Click, cntr_mesa_10.Click, cntr_mesa_11.Click, _
        cntr_mesa_12.Click, cntr_mesa_13.Click, cntr_mesa_14.Click

        Dim frm_pedido As Form

        Dim disponibilidade = mesas_disponibilidade(sender.tag - 1)
        If disponibilidade = "S" Then
            frm_pedido = New form_pedido(CInt(sender.tag))
        Else
            frm_pedido = New form_pedido_info(CInt(sender.tag))
        End If
        frm_pedido.Show()
    End Sub

    Private Sub form_mesas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        form_login.Close()
        mesas_cores = New List(Of Panel)({cor_mesa_1, cor_mesa_2, cor_mesa_3, cor_mesa_4, cor_mesa_5, cor_mesa_6, _
                                                                cor_mesa_7, cor_mesa_8, cor_mesa_9, cor_mesa_10, cor_mesa_11, cor_mesa_12, _
                                                                cor_mesa_13, cor_mesa_14})
        conectar_banco()
        atualizarMesas()

        lbl_operador_nome.Text = sessao_nome
        If sessao_foto <> "" Then
            img_operador.Load(sessao_foto)
        End If
    End Sub

    Public Sub atualizarMesas()
        mesas_disponibilidade.Clear()
        Dim i = 0
        Dim indicador_cor As Panel
        sql = "SELECT * FROM tb_mesas"
        rs = db.Execute(sql)
        Do Until rs.EOF
            mesas_disponibilidade.Add(rs.Fields("disponivel").Value)

            indicador_cor = mesas_cores.Item(i)
            If rs.Fields("disponivel").Value = "S" Then
                indicador_cor.BackColor = Color.FromArgb(39, 174, 96)
            Else
                indicador_cor.BackColor = Color.FromArgb(43, 45, 66)
            End If
            rs.MoveNext()
            i += 1
        Loop
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        resp = MsgBox("Deseja realmente realizar logout?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Sair")
        If resp = vbYes Then
            Me.Hide()
            form_login.Show()
        End If
    End Sub

    Private Sub cliqueNovoCliente(sender As Object, e As EventArgs) Handles btn_novo_cliente.Click, btn_novo_cliente_icon.Click, btn_novo_cliente_lbl.Click
        form_clientes.TopMost = True
        form_clientes.Show()
    End Sub
End Class