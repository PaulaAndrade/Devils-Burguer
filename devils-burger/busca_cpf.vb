Public Class form_pesquisa

    Private Sub buscarCPF(sender As Object, e As EventArgs) Handles btn_buscar.Click
        sql = "select * from tb_clientes where cpf = '" & txt_busca_cpf.Text & "'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            form_clientes.btn_excluir.Visible = True
            form_clientes.preencherCampos()
        Else
            MsgBox("CPF não encontrado", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
        End If
        Me.Close()
    End Sub
End Class