<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_cozinheiro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_cozinheiro))
        Me.lbl_cozinheiro = New System.Windows.Forms.Label()
        Me.img_cozinheiro = New System.Windows.Forms.PictureBox()
        Me.btn_logout = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.container_infos = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tab_items = New System.Windows.Forms.TabPage()
        Me.container_items_pedido = New System.Windows.Forms.FlowLayoutPanel()
        Me.tab_obs = New System.Windows.Forms.TabPage()
        Me.txt_obs = New System.Windows.Forms.TextBox()
        Me.btn_acao_box = New System.Windows.Forms.Panel()
        Me.btn_acao_lbl = New System.Windows.Forms.Label()
        Me.lbl_cliente = New System.Windows.Forms.Label()
        Me.lbl_horario = New System.Windows.Forms.Label()
        Me.lbl_mesa = New System.Windows.Forms.Label()
        Me.lbl_infos = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.container_pedidos = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        CType(Me.img_cozinheiro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_logout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.container_infos.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tab_items.SuspendLayout()
        Me.tab_obs.SuspendLayout()
        Me.btn_acao_box.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_cozinheiro
        '
        Me.lbl_cozinheiro.AutoSize = True
        Me.lbl_cozinheiro.Font = New System.Drawing.Font("Leelawadee", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cozinheiro.ForeColor = System.Drawing.Color.White
        Me.lbl_cozinheiro.Location = New System.Drawing.Point(815, 31)
        Me.lbl_cozinheiro.MaximumSize = New System.Drawing.Size(400, 0)
        Me.lbl_cozinheiro.MinimumSize = New System.Drawing.Size(400, 0)
        Me.lbl_cozinheiro.Name = "lbl_cozinheiro"
        Me.lbl_cozinheiro.Size = New System.Drawing.Size(400, 23)
        Me.lbl_cozinheiro.TabIndex = 18
        Me.lbl_cozinheiro.Text = "[Nome]"
        Me.lbl_cozinheiro.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'img_cozinheiro
        '
        Me.img_cozinheiro.Image = CType(resources.GetObject("img_cozinheiro.Image"), System.Drawing.Image)
        Me.img_cozinheiro.Location = New System.Drawing.Point(1221, 10)
        Me.img_cozinheiro.Name = "img_cozinheiro"
        Me.img_cozinheiro.Size = New System.Drawing.Size(60, 60)
        Me.img_cozinheiro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_cozinheiro.TabIndex = 17
        Me.img_cozinheiro.TabStop = False
        '
        'btn_logout
        '
        Me.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_logout.Image = CType(resources.GetObject("btn_logout.Image"), System.Drawing.Image)
        Me.btn_logout.Location = New System.Drawing.Point(1302, 17)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(48, 48)
        Me.btn_logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_logout.TabIndex = 16
        Me.btn_logout.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.container_infos)
        Me.Panel1.Controls.Add(Me.lbl_infos)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Location = New System.Drawing.Point(553, 80)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 593)
        Me.Panel1.TabIndex = 19
        '
        'container_infos
        '
        Me.container_infos.Controls.Add(Me.TabControl1)
        Me.container_infos.Controls.Add(Me.btn_acao_box)
        Me.container_infos.Controls.Add(Me.lbl_cliente)
        Me.container_infos.Controls.Add(Me.lbl_horario)
        Me.container_infos.Controls.Add(Me.lbl_mesa)
        Me.container_infos.Location = New System.Drawing.Point(10, 70)
        Me.container_infos.Name = "container_infos"
        Me.container_infos.Size = New System.Drawing.Size(775, 511)
        Me.container_infos.TabIndex = 31
        Me.container_infos.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tab_items)
        Me.TabControl1.Controls.Add(Me.tab_obs)
        Me.TabControl1.Location = New System.Drawing.Point(27, 103)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(725, 300)
        Me.TabControl1.TabIndex = 30
        '
        'tab_items
        '
        Me.tab_items.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.tab_items.Controls.Add(Me.container_items_pedido)
        Me.tab_items.Location = New System.Drawing.Point(4, 25)
        Me.tab_items.Name = "tab_items"
        Me.tab_items.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_items.Size = New System.Drawing.Size(717, 271)
        Me.tab_items.TabIndex = 0
        Me.tab_items.Text = "Items"
        '
        'container_items_pedido
        '
        Me.container_items_pedido.AutoScroll = True
        Me.container_items_pedido.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.container_items_pedido.Location = New System.Drawing.Point(0, 0)
        Me.container_items_pedido.Name = "container_items_pedido"
        Me.container_items_pedido.Padding = New System.Windows.Forms.Padding(40, 20, 0, 0)
        Me.container_items_pedido.Size = New System.Drawing.Size(717, 271)
        Me.container_items_pedido.TabIndex = 0
        '
        'tab_obs
        '
        Me.tab_obs.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.tab_obs.Controls.Add(Me.txt_obs)
        Me.tab_obs.Location = New System.Drawing.Point(4, 25)
        Me.tab_obs.Name = "tab_obs"
        Me.tab_obs.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_obs.Size = New System.Drawing.Size(717, 271)
        Me.tab_obs.TabIndex = 1
        Me.tab_obs.Text = "Observações"
        '
        'txt_obs
        '
        Me.txt_obs.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txt_obs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_obs.Location = New System.Drawing.Point(20, 20)
        Me.txt_obs.MaximumSize = New System.Drawing.Size(697, 231)
        Me.txt_obs.Multiline = True
        Me.txt_obs.Name = "txt_obs"
        Me.txt_obs.ReadOnly = True
        Me.txt_obs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_obs.Size = New System.Drawing.Size(697, 231)
        Me.txt_obs.TabIndex = 0
        Me.txt_obs.Text = "eaweaweaw"
        '
        'btn_acao_box
        '
        Me.btn_acao_box.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btn_acao_box.Controls.Add(Me.btn_acao_lbl)
        Me.btn_acao_box.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_acao_box.Location = New System.Drawing.Point(558, 434)
        Me.btn_acao_box.Name = "btn_acao_box"
        Me.btn_acao_box.Size = New System.Drawing.Size(190, 65)
        Me.btn_acao_box.TabIndex = 28
        '
        'btn_acao_lbl
        '
        Me.btn_acao_lbl.AutoSize = True
        Me.btn_acao_lbl.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_acao_lbl.ForeColor = System.Drawing.Color.White
        Me.btn_acao_lbl.Location = New System.Drawing.Point(0, 18)
        Me.btn_acao_lbl.MaximumSize = New System.Drawing.Size(190, 0)
        Me.btn_acao_lbl.MinimumSize = New System.Drawing.Size(190, 0)
        Me.btn_acao_lbl.Name = "btn_acao_lbl"
        Me.btn_acao_lbl.Size = New System.Drawing.Size(190, 28)
        Me.btn_acao_lbl.TabIndex = 0
        Me.btn_acao_lbl.Text = "CONCLUIR"
        Me.btn_acao_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_acao_lbl.UseCompatibleTextRendering = True
        '
        'lbl_cliente
        '
        Me.lbl_cliente.AutoSize = True
        Me.lbl_cliente.Font = New System.Drawing.Font("Leelawadee", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cliente.Location = New System.Drawing.Point(83, 61)
        Me.lbl_cliente.Name = "lbl_cliente"
        Me.lbl_cliente.Size = New System.Drawing.Size(253, 24)
        Me.lbl_cliente.TabIndex = 25
        Me.lbl_cliente.Text = "Paula dos Santos Andrade"
        '
        'lbl_horario
        '
        Me.lbl_horario.AutoSize = True
        Me.lbl_horario.Font = New System.Drawing.Font("Leelawadee", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_horario.Location = New System.Drawing.Point(476, 19)
        Me.lbl_horario.MaximumSize = New System.Drawing.Size(276, 0)
        Me.lbl_horario.MinimumSize = New System.Drawing.Size(276, 0)
        Me.lbl_horario.Name = "lbl_horario"
        Me.lbl_horario.Size = New System.Drawing.Size(276, 48)
        Me.lbl_horario.TabIndex = 24
        Me.lbl_horario.Text = "07:59"
        Me.lbl_horario.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_mesa
        '
        Me.lbl_mesa.AutoSize = True
        Me.lbl_mesa.Font = New System.Drawing.Font("Leelawadee", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mesa.Location = New System.Drawing.Point(15, 0)
        Me.lbl_mesa.Name = "lbl_mesa"
        Me.lbl_mesa.Size = New System.Drawing.Size(276, 71)
        Me.lbl_mesa.TabIndex = 23
        Me.lbl_mesa.Text = "MESA 10"
        '
        'lbl_infos
        '
        Me.lbl_infos.AutoSize = True
        Me.lbl_infos.Font = New System.Drawing.Font("Leelawadee", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_infos.Location = New System.Drawing.Point(0, 14)
        Me.lbl_infos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_infos.MaximumSize = New System.Drawing.Size(750, 0)
        Me.lbl_infos.MinimumSize = New System.Drawing.Size(800, 0)
        Me.lbl_infos.Name = "lbl_infos"
        Me.lbl_infos.Size = New System.Drawing.Size(800, 32)
        Me.lbl_infos.TabIndex = 21
        Me.lbl_infos.Text = "Informações do Pedido"
        Me.lbl_infos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel6.Location = New System.Drawing.Point(0, 60)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(800, 2)
        Me.Panel6.TabIndex = 22
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.container_pedidos)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(44, 31)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(480, 642)
        Me.Panel2.TabIndex = 20
        '
        'container_pedidos
        '
        Me.container_pedidos.AutoScroll = True
        Me.container_pedidos.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.container_pedidos.Location = New System.Drawing.Point(0, 70)
        Me.container_pedidos.Name = "container_pedidos"
        Me.container_pedidos.Padding = New System.Windows.Forms.Padding(40, 5, 0, 0)
        Me.container_pedidos.Size = New System.Drawing.Size(480, 548)
        Me.container_pedidos.TabIndex = 25
        Me.container_pedidos.WrapContents = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Leelawadee", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.MaximumSize = New System.Drawing.Size(480, 0)
        Me.Label1.MinimumSize = New System.Drawing.Size(480, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(480, 32)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Lista de Pedidos"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(0, 60)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(480, 2)
        Me.Panel3.TabIndex = 24
        '
        'form_cozinheiro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1392, 706)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbl_cozinheiro)
        Me.Controls.Add(Me.img_cozinheiro)
        Me.Controls.Add(Me.btn_logout)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_cozinheiro"
        Me.Text = "Lista de Pedidos"
        CType(Me.img_cozinheiro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_logout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.container_infos.ResumeLayout(False)
        Me.container_infos.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tab_items.ResumeLayout(False)
        Me.tab_obs.ResumeLayout(False)
        Me.tab_obs.PerformLayout()
        Me.btn_acao_box.ResumeLayout(False)
        Me.btn_acao_box.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_cozinheiro As System.Windows.Forms.Label
    Friend WithEvents img_cozinheiro As System.Windows.Forms.PictureBox
    Friend WithEvents btn_logout As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lbl_infos As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lbl_cliente As System.Windows.Forms.Label
    Friend WithEvents lbl_horario As System.Windows.Forms.Label
    Friend WithEvents lbl_mesa As System.Windows.Forms.Label
    Friend WithEvents btn_acao_box As System.Windows.Forms.Panel
    Friend WithEvents btn_acao_lbl As System.Windows.Forms.Label
    Friend WithEvents container_pedidos As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tab_items As System.Windows.Forms.TabPage
    Friend WithEvents tab_obs As System.Windows.Forms.TabPage
    Friend WithEvents txt_obs As System.Windows.Forms.TextBox
    Friend WithEvents container_items_pedido As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents container_infos As System.Windows.Forms.Panel
End Class
