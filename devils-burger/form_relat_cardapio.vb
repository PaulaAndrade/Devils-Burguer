Public Class form_relat_cardapio

    Private Sub form_relat_cardapio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'devils_burger_ds.cardapio_adapter' table. You can move, or remove it, as needed.
        Me.cardapio_adapterTableAdapter.query_cardapio(Me.devils_burger_ds.cardapio_adapter)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class