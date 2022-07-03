<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_relat_cardapio
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_relat_cardapio))
        Me.cardapio_adapterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.devils_burger_ds = New devils_burger.devils_burger_ds()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.cardapio_adapterTableAdapter = New devils_burger.devils_burger_dsTableAdapters.cardapio_adapterTableAdapter()
        CType(Me.cardapio_adapterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.devils_burger_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cardapio_adapterBindingSource
        '
        Me.cardapio_adapterBindingSource.DataMember = "cardapio_adapter"
        Me.cardapio_adapterBindingSource.DataSource = Me.devils_burger_ds
        '
        'devils_burger_ds
        '
        Me.devils_burger_ds.DataSetName = "devils_burger_ds"
        Me.devils_burger_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "cardapio_ds"
        ReportDataSource1.Value = Me.cardapio_adapterBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "devils_burger.report_cardapio.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ShowBackButton = False
        Me.ReportViewer1.ShowContextMenu = False
        Me.ReportViewer1.ShowCredentialPrompts = False
        Me.ReportViewer1.ShowDocumentMapButton = False
        Me.ReportViewer1.ShowFindControls = False
        Me.ReportViewer1.ShowPageNavigationControls = False
        Me.ReportViewer1.ShowParameterPrompts = False
        Me.ReportViewer1.ShowProgress = False
        Me.ReportViewer1.ShowPromptAreaButton = False
        Me.ReportViewer1.ShowStopButton = False
        Me.ReportViewer1.ShowZoomControl = False
        Me.ReportViewer1.Size = New System.Drawing.Size(862, 703)
        Me.ReportViewer1.TabIndex = 0
        '
        'cardapio_adapterTableAdapter
        '
        Me.cardapio_adapterTableAdapter.ClearBeforeFill = True
        '
        'form_relat_cardapio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 703)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_relat_cardapio"
        Me.Text = "Relatório de Produtos"
        CType(Me.cardapio_adapterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.devils_burger_ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents cardapio_adapterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents devils_burger_ds As devils_burger.devils_burger_ds
    Friend WithEvents cardapio_adapterTableAdapter As devils_burger.devils_burger_dsTableAdapters.cardapio_adapterTableAdapter
End Class
