Public Class form_relat_pedidos

    Private Sub form_relat_pedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'devils_burger_ds.tb_pedidos' table. You can move, or remove it, as needed.
        Me.tb_pedidosTableAdapter.query_pedidos(Me.devils_burger_ds.tb_pedidos)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class