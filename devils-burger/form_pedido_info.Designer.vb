<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_pedido_info
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_pedido_info))
        Me.btn_finalizar_box = New System.Windows.Forms.Panel()
        Me.btn_finalizar_lbl = New System.Windows.Forms.Label()
        Me.btn_cancelar_box = New System.Windows.Forms.Panel()
        Me.btn_cancelar_lbl = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbl_nome_cliente = New System.Windows.Forms.Label()
        Me.container_itens = New System.Windows.Forms.FlowLayoutPanel()
        Me.lbl_preco_total = New System.Windows.Forms.Label()
        Me.lbl_mesa = New System.Windows.Forms.Label()
        Me.lbl_horario = New System.Windows.Forms.Label()
        Me.lbl_situacao = New System.Windows.Forms.Label()
        Me.btn_finalizar_box.SuspendLayout()
        Me.btn_cancelar_box.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_finalizar_box
        '
        Me.btn_finalizar_box.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btn_finalizar_box.Controls.Add(Me.btn_finalizar_lbl)
        Me.btn_finalizar_box.Location = New System.Drawing.Point(36, 655)
        Me.btn_finalizar_box.Name = "btn_finalizar_box"
        Me.btn_finalizar_box.Size = New System.Drawing.Size(315, 71)
        Me.btn_finalizar_box.TabIndex = 0
        '
        'btn_finalizar_lbl
        '
        Me.btn_finalizar_lbl.AutoSize = True
        Me.btn_finalizar_lbl.Font = New System.Drawing.Font("Leelawadee", 20.0!, System.Drawing.FontStyle.Bold)
        Me.btn_finalizar_lbl.ForeColor = System.Drawing.Color.White
        Me.btn_finalizar_lbl.Location = New System.Drawing.Point(0, 15)
        Me.btn_finalizar_lbl.MaximumSize = New System.Drawing.Size(315, 0)
        Me.btn_finalizar_lbl.MinimumSize = New System.Drawing.Size(315, 0)
        Me.btn_finalizar_lbl.Name = "btn_finalizar_lbl"
        Me.btn_finalizar_lbl.Size = New System.Drawing.Size(315, 41)
        Me.btn_finalizar_lbl.TabIndex = 0
        Me.btn_finalizar_lbl.Text = "FINALIZAR"
        Me.btn_finalizar_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_cancelar_box
        '
        Me.btn_cancelar_box.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btn_cancelar_box.Controls.Add(Me.btn_cancelar_lbl)
        Me.btn_cancelar_box.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancelar_box.Location = New System.Drawing.Point(381, 655)
        Me.btn_cancelar_box.Name = "btn_cancelar_box"
        Me.btn_cancelar_box.Size = New System.Drawing.Size(315, 71)
        Me.btn_cancelar_box.TabIndex = 1
        '
        'btn_cancelar_lbl
        '
        Me.btn_cancelar_lbl.AutoSize = True
        Me.btn_cancelar_lbl.Font = New System.Drawing.Font("Leelawadee", 20.0!, System.Drawing.FontStyle.Bold)
        Me.btn_cancelar_lbl.ForeColor = System.Drawing.Color.White
        Me.btn_cancelar_lbl.Location = New System.Drawing.Point(0, 15)
        Me.btn_cancelar_lbl.MaximumSize = New System.Drawing.Size(315, 0)
        Me.btn_cancelar_lbl.MinimumSize = New System.Drawing.Size(315, 0)
        Me.btn_cancelar_lbl.Name = "btn_cancelar_lbl"
        Me.btn_cancelar_lbl.Size = New System.Drawing.Size(315, 41)
        Me.btn_cancelar_lbl.TabIndex = 0
        Me.btn_cancelar_lbl.Text = "CANCELAR"
        Me.btn_cancelar_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.lbl_nome_cliente)
        Me.Panel3.Controls.Add(Me.container_itens)
        Me.Panel3.Controls.Add(Me.lbl_preco_total)
        Me.Panel3.Location = New System.Drawing.Point(36, 83)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(660, 541)
        Me.Panel3.TabIndex = 2
        '
        'lbl_nome_cliente
        '
        Me.lbl_nome_cliente.AutoSize = True
        Me.lbl_nome_cliente.Font = New System.Drawing.Font("Leelawadee", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nome_cliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lbl_nome_cliente.Location = New System.Drawing.Point(15, 20)
        Me.lbl_nome_cliente.MaximumSize = New System.Drawing.Size(630, 0)
        Me.lbl_nome_cliente.MinimumSize = New System.Drawing.Size(630, 0)
        Me.lbl_nome_cliente.Name = "lbl_nome_cliente"
        Me.lbl_nome_cliente.Size = New System.Drawing.Size(630, 36)
        Me.lbl_nome_cliente.TabIndex = 4
        Me.lbl_nome_cliente.Text = "[Nome Cliente]"
        '
        'container_itens
        '
        Me.container_itens.AutoScroll = True
        Me.container_itens.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.container_itens.Location = New System.Drawing.Point(0, 73)
        Me.container_itens.Name = "container_itens"
        Me.container_itens.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.container_itens.Size = New System.Drawing.Size(660, 370)
        Me.container_itens.TabIndex = 5
        Me.container_itens.WrapContents = False
        '
        'lbl_preco_total
        '
        Me.lbl_preco_total.AutoSize = True
        Me.lbl_preco_total.Font = New System.Drawing.Font("Leelawadee", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_preco_total.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lbl_preco_total.Location = New System.Drawing.Point(307, 456)
        Me.lbl_preco_total.MaximumSize = New System.Drawing.Size(350, 0)
        Me.lbl_preco_total.MinimumSize = New System.Drawing.Size(350, 0)
        Me.lbl_preco_total.Name = "lbl_preco_total"
        Me.lbl_preco_total.Size = New System.Drawing.Size(350, 71)
        Me.lbl_preco_total.TabIndex = 4
        Me.lbl_preco_total.Text = "R$ 000,00"
        Me.lbl_preco_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_mesa
        '
        Me.lbl_mesa.AutoSize = True
        Me.lbl_mesa.Font = New System.Drawing.Font("Leelawadee", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mesa.ForeColor = System.Drawing.Color.White
        Me.lbl_mesa.Location = New System.Drawing.Point(24, 9)
        Me.lbl_mesa.Name = "lbl_mesa"
        Me.lbl_mesa.Size = New System.Drawing.Size(313, 71)
        Me.lbl_mesa.TabIndex = 3
        Me.lbl_mesa.Text = "MESA [ID]"
        '
        'lbl_horario
        '
        Me.lbl_horario.AutoSize = True
        Me.lbl_horario.Font = New System.Drawing.Font("Leelawadee", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_horario.ForeColor = System.Drawing.Color.White
        Me.lbl_horario.Location = New System.Drawing.Point(620, 12)
        Me.lbl_horario.Name = "lbl_horario"
        Me.lbl_horario.Size = New System.Drawing.Size(76, 30)
        Me.lbl_horario.TabIndex = 6
        Me.lbl_horario.Text = "00:00"
        Me.lbl_horario.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_situacao
        '
        Me.lbl_situacao.AutoSize = True
        Me.lbl_situacao.Font = New System.Drawing.Font("Leelawadee", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_situacao.ForeColor = System.Drawing.Color.White
        Me.lbl_situacao.Location = New System.Drawing.Point(498, 37)
        Me.lbl_situacao.MaximumSize = New System.Drawing.Size(200, 0)
        Me.lbl_situacao.MinimumSize = New System.Drawing.Size(200, 0)
        Me.lbl_situacao.Name = "lbl_situacao"
        Me.lbl_situacao.Size = New System.Drawing.Size(200, 36)
        Me.lbl_situacao.TabIndex = 7
        Me.lbl_situacao.Text = "[Status]"
        Me.lbl_situacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'form_pedido_info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(732, 753)
        Me.Controls.Add(Me.lbl_situacao)
        Me.Controls.Add(Me.lbl_horario)
        Me.Controls.Add(Me.lbl_mesa)
        Me.Controls.Add(Me.btn_cancelar_box)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btn_finalizar_box)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_pedido_info"
        Me.Text = "Mesa 3 - Pedido"
        Me.TopMost = True
        Me.btn_finalizar_box.ResumeLayout(False)
        Me.btn_finalizar_box.PerformLayout()
        Me.btn_cancelar_box.ResumeLayout(False)
        Me.btn_cancelar_box.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_finalizar_box As System.Windows.Forms.Panel
    Friend WithEvents btn_finalizar_lbl As System.Windows.Forms.Label
    Friend WithEvents btn_cancelar_box As System.Windows.Forms.Panel
    Friend WithEvents btn_cancelar_lbl As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lbl_mesa As System.Windows.Forms.Label
    Friend WithEvents lbl_preco_total As System.Windows.Forms.Label
    Friend WithEvents lbl_nome_cliente As System.Windows.Forms.Label
    Friend WithEvents container_itens As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents lbl_horario As System.Windows.Forms.Label
    Friend WithEvents lbl_situacao As System.Windows.Forms.Label
End Class
