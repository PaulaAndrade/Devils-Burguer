Public Class form_relat_clientes

    Private Sub form_relat_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'devils_burger_ds.clientes_adapter' table. You can move, or remove it, as needed.
        Me.clientes_adapterTableAdapter.query_clientes(Me.devils_burger_ds.clientes_adapter)

        Me.report_cliente.RefreshReport()
    End Sub

    Private Sub cliqueNovoCliente(sender As Object, e As EventArgs) Handles btn_novo_cliente.Click, btn_novo_cliente_lbl.Click, btn_novo_cliente_icon.Click
        form_clientes.TopMost = True
        form_clientes.Show()
        Me.report_cliente.RefreshReport()
    End Sub
End Class