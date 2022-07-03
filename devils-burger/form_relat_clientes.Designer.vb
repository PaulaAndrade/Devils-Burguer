<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_relat_clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_relat_clientes))
        Me.clientes_adapterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.devils_burger_ds = New devils_burger.devils_burger_ds()
        Me.report_cliente = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.clientes_adapterTableAdapter = New devils_burger.devils_burger_dsTableAdapters.clientes_adapterTableAdapter()
        Me.btn_novo_cliente = New System.Windows.Forms.Panel()
        Me.btn_novo_cliente_icon = New System.Windows.Forms.PictureBox()
        Me.btn_novo_cliente_lbl = New System.Windows.Forms.Label()
        CType(Me.clientes_adapterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.devils_burger_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.btn_novo_cliente.SuspendLayout()
        CType(Me.btn_novo_cliente_icon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'clientes_adapterBindingSource
        '
        Me.clientes_adapterBindingSource.DataMember = "clientes_adapter"
        Me.clientes_adapterBindingSource.DataSource = Me.devils_burger_ds
        '
        'devils_burger_ds
        '
        Me.devils_burger_ds.DataSetName = "devils_burger_ds"
        Me.devils_burger_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'report_cliente
        '
        Me.report_cliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        ReportDataSource1.Name = "clientes_ds"
        ReportDataSource1.Value = Me.clientes_adapterBindingSource
        Me.report_cliente.LocalReport.DataSources.Add(ReportDataSource1)
        Me.report_cliente.LocalReport.ReportEmbeddedResource = "devils_burger.report_clientes.rdlc"
        Me.report_cliente.Location = New System.Drawing.Point(0, 55)
        Me.report_cliente.Name = "report_cliente"
        Me.report_cliente.Size = New System.Drawing.Size(1125, 648)
        Me.report_cliente.TabIndex = 0
        '
        'clientes_adapterTableAdapter
        '
        Me.clientes_adapterTableAdapter.ClearBeforeFill = True
        '
        'btn_novo_cliente
        '
        Me.btn_novo_cliente.BackColor = System.Drawing.Color.Transparent
        Me.btn_novo_cliente.Controls.Add(Me.btn_novo_cliente_icon)
        Me.btn_novo_cliente.Controls.Add(Me.btn_novo_cliente_lbl)
        Me.btn_novo_cliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_novo_cliente.Location = New System.Drawing.Point(981, 9)
        Me.btn_novo_cliente.Name = "btn_novo_cliente"
        Me.btn_novo_cliente.Size = New System.Drawing.Size(132, 40)
        Me.btn_novo_cliente.TabIndex = 23
        '
        'btn_novo_cliente_icon
        '
        Me.btn_novo_cliente_icon.Image = CType(resources.GetObject("btn_novo_cliente_icon.Image"), System.Drawing.Image)
        Me.btn_novo_cliente_icon.Location = New System.Drawing.Point(0, 0)
        Me.btn_novo_cliente_icon.Name = "btn_novo_cliente_icon"
        Me.btn_novo_cliente_icon.Size = New System.Drawing.Size(40, 40)
        Me.btn_novo_cliente_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_novo_cliente_icon.TabIndex = 19
        Me.btn_novo_cliente_icon.TabStop = False
        '
        'btn_novo_cliente_lbl
        '
        Me.btn_novo_cliente_lbl.AutoSize = True
        Me.btn_novo_cliente_lbl.Font = New System.Drawing.Font("Leelawadee", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_novo_cliente_lbl.ForeColor = System.Drawing.Color.Black
        Me.btn_novo_cliente_lbl.Location = New System.Drawing.Point(46, 10)
        Me.btn_novo_cliente_lbl.Name = "btn_novo_cliente_lbl"
        Me.btn_novo_cliente_lbl.Size = New System.Drawing.Size(84, 23)
        Me.btn_novo_cliente_lbl.TabIndex = 20
        Me.btn_novo_cliente_lbl.Text = "CLIENTE"
        Me.btn_novo_cliente_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'form_relat_clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1125, 703)
        Me.Controls.Add(Me.btn_novo_cliente)
        Me.Controls.Add(Me.report_cliente)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_relat_clientes"
        Me.Text = "Relatório de Clientes"
        CType(Me.clientes_adapterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.devils_burger_ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.btn_novo_cliente.ResumeLayout(False)
        Me.btn_novo_cliente.PerformLayout()
        CType(Me.btn_novo_cliente_icon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents report_cliente As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents clientes_adapterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents devils_burger_ds As devils_burger.devils_burger_ds
    Friend WithEvents clientes_adapterTableAdapter As devils_burger.devils_burger_dsTableAdapters.clientes_adapterTableAdapter
    Friend WithEvents btn_novo_cliente As System.Windows.Forms.Panel
    Friend WithEvents btn_novo_cliente_icon As System.Windows.Forms.PictureBox
    Friend WithEvents btn_novo_cliente_lbl As System.Windows.Forms.Label
End Class
