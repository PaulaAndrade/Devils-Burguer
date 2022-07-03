<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_relat_pedidos
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_relat_pedidos))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tb_pedidosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.devils_burger_ds = New devils_burger.devils_burger_ds()
        Me.tb_pedidosTableAdapter = New devils_burger.devils_burger_dsTableAdapters.tb_pedidosTableAdapter()
        CType(Me.tb_pedidosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.devils_burger_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "pedidos_ds"
        ReportDataSource2.Value = Me.tb_pedidosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "devils_burger.report_pedidos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(952, 703)
        Me.ReportViewer1.TabIndex = 0
        '
        'tb_pedidosBindingSource
        '
        Me.tb_pedidosBindingSource.DataMember = "tb_pedidos"
        Me.tb_pedidosBindingSource.DataSource = Me.devils_burger_ds
        '
        'devils_burger_ds
        '
        Me.devils_burger_ds.DataSetName = "devils_burger_ds"
        Me.devils_burger_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tb_pedidosTableAdapter
        '
        Me.tb_pedidosTableAdapter.ClearBeforeFill = True
        '
        'form_relat_pedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 703)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_relat_pedidos"
        Me.Text = "Relatório de Pedidos"
        Me.TopMost = True
        CType(Me.tb_pedidosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.devils_burger_ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tb_pedidosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents devils_burger_ds As devils_burger.devils_burger_ds
    Friend WithEvents tb_pedidosTableAdapter As devils_burger.devils_burger_dsTableAdapters.tb_pedidosTableAdapter
End Class
