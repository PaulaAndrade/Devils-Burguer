<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_gerente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_gerente))
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.container_funcionarios = New System.Windows.Forms.FlowLayoutPanel()
        Me.btn_add_funcionario = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tab_pedidos = New System.Windows.Forms.TabPage()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.lbl_p_cancelados = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbl_p_finalizados = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbl_p_entregues = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_p_fazendo = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_p_fazer = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tab_clientes = New System.Windows.Forms.TabPage()
        Me.btn_novo_cliente = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.pedidos_box = New System.Windows.Forms.Panel()
        Me.lbl_pedidos_total = New System.Windows.Forms.Label()
        Me.txt_pedidos_total = New System.Windows.Forms.Label()
        Me.pedidos_img = New System.Windows.Forms.PictureBox()
        Me.lbl_pedidos_dia = New System.Windows.Forms.Label()
        Me.txt_pedidos_dia = New System.Windows.Forms.Label()
        Me.clientes_box = New System.Windows.Forms.Panel()
        Me.lbl_clientes_total = New System.Windows.Forms.Label()
        Me.txt_clientes_total = New System.Windows.Forms.Label()
        Me.clientes_img = New System.Windows.Forms.PictureBox()
        Me.lbl_clientes_dia = New System.Windows.Forms.Label()
        Me.txt_clientes_dia = New System.Windows.Forms.Label()
        Me.cardapio_box = New System.Windows.Forms.Panel()
        Me.lbl_bebida = New System.Windows.Forms.Label()
        Me.cardapio_bebida = New System.Windows.Forms.Label()
        Me.cardapio_img = New System.Windows.Forms.PictureBox()
        Me.lbl_lanche = New System.Windows.Forms.Label()
        Me.cardapio_lanche = New System.Windows.Forms.Label()
        Me.btn_logout = New System.Windows.Forms.PictureBox()
        Me.img_gerente = New System.Windows.Forms.PictureBox()
        Me.lbl_gerente_nome = New System.Windows.Forms.Label()
        Me.Panel4.SuspendLayout()
        CType(Me.btn_add_funcionario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.tab_pedidos.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.tab_clientes.SuspendLayout()
        CType(Me.btn_novo_cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pedidos_box.SuspendLayout()
        CType(Me.pedidos_img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.clientes_box.SuspendLayout()
        CType(Me.clientes_img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cardapio_box.SuspendLayout()
        CType(Me.cardapio_img, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_logout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_gerente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Panel4.Controls.Add(Me.container_funcionarios)
        Me.Panel4.Controls.Add(Me.btn_add_funcionario)
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Controls.Add(Me.Panel6)
        Me.Panel4.Location = New System.Drawing.Point(720, 84)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(665, 366)
        Me.Panel4.TabIndex = 7
        '
        'container_funcionarios
        '
        Me.container_funcionarios.AutoScroll = True
        Me.container_funcionarios.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.container_funcionarios.Location = New System.Drawing.Point(0, 76)
        Me.container_funcionarios.Name = "container_funcionarios"
        Me.container_funcionarios.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.container_funcionarios.Size = New System.Drawing.Size(665, 274)
        Me.container_funcionarios.TabIndex = 7
        Me.container_funcionarios.WrapContents = False
        '
        'btn_add_funcionario
        '
        Me.btn_add_funcionario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_add_funcionario.Image = CType(resources.GetObject("btn_add_funcionario.Image"), System.Drawing.Image)
        Me.btn_add_funcionario.Location = New System.Drawing.Point(602, 11)
        Me.btn_add_funcionario.Name = "btn_add_funcionario"
        Me.btn_add_funcionario.Size = New System.Drawing.Size(48, 48)
        Me.btn_add_funcionario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_add_funcionario.TabIndex = 5
        Me.btn_add_funcionario.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Leelawadee", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(246, 21)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(180, 32)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Funcionários"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel6.Location = New System.Drawing.Point(20, 67)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(630, 2)
        Me.Panel6.TabIndex = 4
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tab_pedidos)
        Me.TabControl1.Controls.Add(Me.tab_clientes)
        Me.TabControl1.Location = New System.Drawing.Point(29, 57)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(667, 391)
        Me.TabControl1.TabIndex = 8
        '
        'tab_pedidos
        '
        Me.tab_pedidos.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.tab_pedidos.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.tab_pedidos.Controls.Add(Me.Panel7)
        Me.tab_pedidos.Controls.Add(Me.Panel5)
        Me.tab_pedidos.Controls.Add(Me.Panel3)
        Me.tab_pedidos.Controls.Add(Me.Panel2)
        Me.tab_pedidos.Controls.Add(Me.Panel1)
        Me.tab_pedidos.Location = New System.Drawing.Point(4, 25)
        Me.tab_pedidos.Name = "tab_pedidos"
        Me.tab_pedidos.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_pedidos.Size = New System.Drawing.Size(659, 362)
        Me.tab_pedidos.TabIndex = 0
        Me.tab_pedidos.Text = "Pedidos"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.White
        Me.Panel7.Controls.Add(Me.lbl_p_cancelados)
        Me.Panel7.Controls.Add(Me.Label10)
        Me.Panel7.Location = New System.Drawing.Point(81, 279)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(464, 55)
        Me.Panel7.TabIndex = 2
        '
        'lbl_p_cancelados
        '
        Me.lbl_p_cancelados.AutoSize = True
        Me.lbl_p_cancelados.Font = New System.Drawing.Font("Leelawadee", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p_cancelados.Location = New System.Drawing.Point(321, 14)
        Me.lbl_p_cancelados.MinimumSize = New System.Drawing.Size(130, 0)
        Me.lbl_p_cancelados.Name = "lbl_p_cancelados"
        Me.lbl_p_cancelados.Size = New System.Drawing.Size(130, 29)
        Me.lbl_p_cancelados.TabIndex = 1
        Me.lbl_p_cancelados.Text = "NA"
        Me.lbl_p_cancelados.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Leelawadee", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(15, 13)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(134, 29)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Cancelados"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.lbl_p_finalizados)
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Location = New System.Drawing.Point(81, 216)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(464, 55)
        Me.Panel5.TabIndex = 2
        '
        'lbl_p_finalizados
        '
        Me.lbl_p_finalizados.AutoSize = True
        Me.lbl_p_finalizados.Font = New System.Drawing.Font("Leelawadee", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p_finalizados.Location = New System.Drawing.Point(321, 14)
        Me.lbl_p_finalizados.MinimumSize = New System.Drawing.Size(130, 0)
        Me.lbl_p_finalizados.Name = "lbl_p_finalizados"
        Me.lbl_p_finalizados.Size = New System.Drawing.Size(130, 29)
        Me.lbl_p_finalizados.TabIndex = 1
        Me.lbl_p_finalizados.Text = "NA"
        Me.lbl_p_finalizados.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Leelawadee", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(15, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(130, 29)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Finalizados"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.lbl_p_entregues)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Location = New System.Drawing.Point(81, 153)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(464, 55)
        Me.Panel3.TabIndex = 2
        '
        'lbl_p_entregues
        '
        Me.lbl_p_entregues.AutoSize = True
        Me.lbl_p_entregues.Font = New System.Drawing.Font("Leelawadee", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p_entregues.Location = New System.Drawing.Point(321, 14)
        Me.lbl_p_entregues.MinimumSize = New System.Drawing.Size(130, 0)
        Me.lbl_p_entregues.Name = "lbl_p_entregues"
        Me.lbl_p_entregues.Size = New System.Drawing.Size(130, 29)
        Me.lbl_p_entregues.TabIndex = 1
        Me.lbl_p_entregues.Text = "NA"
        Me.lbl_p_entregues.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Leelawadee", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 29)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Entregues"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.lbl_p_fazendo)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(81, 90)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(464, 55)
        Me.Panel2.TabIndex = 2
        '
        'lbl_p_fazendo
        '
        Me.lbl_p_fazendo.AutoSize = True
        Me.lbl_p_fazendo.Font = New System.Drawing.Font("Leelawadee", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p_fazendo.Location = New System.Drawing.Point(321, 14)
        Me.lbl_p_fazendo.MinimumSize = New System.Drawing.Size(130, 0)
        Me.lbl_p_fazendo.Name = "lbl_p_fazendo"
        Me.lbl_p_fazendo.Size = New System.Drawing.Size(130, 29)
        Me.lbl_p_fazendo.TabIndex = 1
        Me.lbl_p_fazendo.Text = "NA"
        Me.lbl_p_fazendo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Leelawadee", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 29)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Sendo feitos"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lbl_p_fazer)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(81, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(464, 55)
        Me.Panel1.TabIndex = 0
        '
        'lbl_p_fazer
        '
        Me.lbl_p_fazer.AutoSize = True
        Me.lbl_p_fazer.Font = New System.Drawing.Font("Leelawadee", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p_fazer.Location = New System.Drawing.Point(321, 14)
        Me.lbl_p_fazer.MinimumSize = New System.Drawing.Size(130, 0)
        Me.lbl_p_fazer.Name = "lbl_p_fazer"
        Me.lbl_p_fazer.Size = New System.Drawing.Size(130, 29)
        Me.lbl_p_fazer.TabIndex = 1
        Me.lbl_p_fazer.Text = "NA"
        Me.lbl_p_fazer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Leelawadee", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "A Fazer"
        '
        'tab_clientes
        '
        Me.tab_clientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.tab_clientes.Controls.Add(Me.btn_novo_cliente)
        Me.tab_clientes.Controls.Add(Me.Label2)
        Me.tab_clientes.Controls.Add(Me.Panel8)
        Me.tab_clientes.Location = New System.Drawing.Point(4, 25)
        Me.tab_clientes.Name = "tab_clientes"
        Me.tab_clientes.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_clientes.Size = New System.Drawing.Size(659, 362)
        Me.tab_clientes.TabIndex = 1
        Me.tab_clientes.Text = "Clientes"
        '
        'btn_novo_cliente
        '
        Me.btn_novo_cliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_novo_cliente.Image = CType(resources.GetObject("btn_novo_cliente.Image"), System.Drawing.Image)
        Me.btn_novo_cliente.Location = New System.Drawing.Point(596, 10)
        Me.btn_novo_cliente.Name = "btn_novo_cliente"
        Me.btn_novo_cliente.Size = New System.Drawing.Size(48, 48)
        Me.btn_novo_cliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_novo_cliente.TabIndex = 10
        Me.btn_novo_cliente.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Leelawadee", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 20)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.MinimumSize = New System.Drawing.Size(659, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(659, 32)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Clientes"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel8.Location = New System.Drawing.Point(14, 66)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(630, 2)
        Me.Panel8.TabIndex = 9
        '
        'pedidos_box
        '
        Me.pedidos_box.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pedidos_box.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.pedidos_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pedidos_box.Controls.Add(Me.lbl_pedidos_total)
        Me.pedidos_box.Controls.Add(Me.txt_pedidos_total)
        Me.pedidos_box.Controls.Add(Me.pedidos_img)
        Me.pedidos_box.Controls.Add(Me.lbl_pedidos_dia)
        Me.pedidos_box.Controls.Add(Me.txt_pedidos_dia)
        Me.pedidos_box.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pedidos_box.Location = New System.Drawing.Point(29, 477)
        Me.pedidos_box.Margin = New System.Windows.Forms.Padding(0)
        Me.pedidos_box.Name = "pedidos_box"
        Me.pedidos_box.Size = New System.Drawing.Size(440, 250)
        Me.pedidos_box.TabIndex = 11
        '
        'lbl_pedidos_total
        '
        Me.lbl_pedidos_total.AutoSize = True
        Me.lbl_pedidos_total.Font = New System.Drawing.Font("Leelawadee", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pedidos_total.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_pedidos_total.Location = New System.Drawing.Point(139, 88)
        Me.lbl_pedidos_total.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_pedidos_total.Name = "lbl_pedidos_total"
        Me.lbl_pedidos_total.Size = New System.Drawing.Size(274, 34)
        Me.lbl_pedidos_total.TabIndex = 9
        Me.lbl_pedidos_total.Text = "TOTAL DE PEDIDOS"
        Me.lbl_pedidos_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_pedidos_total
        '
        Me.txt_pedidos_total.AutoSize = True
        Me.txt_pedidos_total.Font = New System.Drawing.Font("Leelawadee", 31.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pedidos_total.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txt_pedidos_total.Location = New System.Drawing.Point(213, 23)
        Me.txt_pedidos_total.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txt_pedidos_total.MinimumSize = New System.Drawing.Size(200, 0)
        Me.txt_pedidos_total.Name = "txt_pedidos_total"
        Me.txt_pedidos_total.Size = New System.Drawing.Size(200, 64)
        Me.txt_pedidos_total.TabIndex = 10
        Me.txt_pedidos_total.Text = "NA"
        Me.txt_pedidos_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pedidos_img
        '
        Me.pedidos_img.Image = CType(resources.GetObject("pedidos_img.Image"), System.Drawing.Image)
        Me.pedidos_img.Location = New System.Drawing.Point(26, 24)
        Me.pedidos_img.Margin = New System.Windows.Forms.Padding(4)
        Me.pedidos_img.Name = "pedidos_img"
        Me.pedidos_img.Size = New System.Drawing.Size(90, 90)
        Me.pedidos_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pedidos_img.TabIndex = 8
        Me.pedidos_img.TabStop = False
        '
        'lbl_pedidos_dia
        '
        Me.lbl_pedidos_dia.AutoSize = True
        Me.lbl_pedidos_dia.Font = New System.Drawing.Font("Leelawadee", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pedidos_dia.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_pedidos_dia.Location = New System.Drawing.Point(170, 195)
        Me.lbl_pedidos_dia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_pedidos_dia.Name = "lbl_pedidos_dia"
        Me.lbl_pedidos_dia.Size = New System.Drawing.Size(243, 34)
        Me.lbl_pedidos_dia.TabIndex = 5
        Me.lbl_pedidos_dia.Text = "PEDIDOS DO DIA"
        Me.lbl_pedidos_dia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_pedidos_dia
        '
        Me.txt_pedidos_dia.AutoSize = True
        Me.txt_pedidos_dia.Font = New System.Drawing.Font("Leelawadee", 31.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pedidos_dia.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txt_pedidos_dia.Location = New System.Drawing.Point(213, 130)
        Me.txt_pedidos_dia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txt_pedidos_dia.MinimumSize = New System.Drawing.Size(200, 0)
        Me.txt_pedidos_dia.Name = "txt_pedidos_dia"
        Me.txt_pedidos_dia.Size = New System.Drawing.Size(200, 64)
        Me.txt_pedidos_dia.TabIndex = 6
        Me.txt_pedidos_dia.Text = "NA"
        Me.txt_pedidos_dia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'clientes_box
        '
        Me.clientes_box.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.clientes_box.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.clientes_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.clientes_box.Controls.Add(Me.lbl_clientes_total)
        Me.clientes_box.Controls.Add(Me.txt_clientes_total)
        Me.clientes_box.Controls.Add(Me.clientes_img)
        Me.clientes_box.Controls.Add(Me.lbl_clientes_dia)
        Me.clientes_box.Controls.Add(Me.txt_clientes_dia)
        Me.clientes_box.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clientes_box.Location = New System.Drawing.Point(487, 477)
        Me.clientes_box.Margin = New System.Windows.Forms.Padding(0)
        Me.clientes_box.Name = "clientes_box"
        Me.clientes_box.Size = New System.Drawing.Size(440, 250)
        Me.clientes_box.TabIndex = 12
        '
        'lbl_clientes_total
        '
        Me.lbl_clientes_total.AutoSize = True
        Me.lbl_clientes_total.Font = New System.Drawing.Font("Leelawadee", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_clientes_total.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_clientes_total.Location = New System.Drawing.Point(135, 88)
        Me.lbl_clientes_total.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_clientes_total.Name = "lbl_clientes_total"
        Me.lbl_clientes_total.Size = New System.Drawing.Size(278, 34)
        Me.lbl_clientes_total.TabIndex = 9
        Me.lbl_clientes_total.Text = "TOTAL DE CLIENTES"
        Me.lbl_clientes_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_clientes_total
        '
        Me.txt_clientes_total.AutoSize = True
        Me.txt_clientes_total.Font = New System.Drawing.Font("Leelawadee", 31.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_clientes_total.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txt_clientes_total.Location = New System.Drawing.Point(213, 23)
        Me.txt_clientes_total.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txt_clientes_total.MinimumSize = New System.Drawing.Size(200, 0)
        Me.txt_clientes_total.Name = "txt_clientes_total"
        Me.txt_clientes_total.Size = New System.Drawing.Size(200, 64)
        Me.txt_clientes_total.TabIndex = 10
        Me.txt_clientes_total.Text = "NA"
        Me.txt_clientes_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'clientes_img
        '
        Me.clientes_img.Image = CType(resources.GetObject("clientes_img.Image"), System.Drawing.Image)
        Me.clientes_img.Location = New System.Drawing.Point(26, 24)
        Me.clientes_img.Margin = New System.Windows.Forms.Padding(4)
        Me.clientes_img.Name = "clientes_img"
        Me.clientes_img.Size = New System.Drawing.Size(90, 90)
        Me.clientes_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.clientes_img.TabIndex = 8
        Me.clientes_img.TabStop = False
        '
        'lbl_clientes_dia
        '
        Me.lbl_clientes_dia.AutoSize = True
        Me.lbl_clientes_dia.Font = New System.Drawing.Font("Leelawadee", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_clientes_dia.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_clientes_dia.Location = New System.Drawing.Point(166, 195)
        Me.lbl_clientes_dia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_clientes_dia.Name = "lbl_clientes_dia"
        Me.lbl_clientes_dia.Size = New System.Drawing.Size(247, 34)
        Me.lbl_clientes_dia.TabIndex = 5
        Me.lbl_clientes_dia.Text = "CLIENTES DO DIA"
        Me.lbl_clientes_dia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_clientes_dia
        '
        Me.txt_clientes_dia.AutoSize = True
        Me.txt_clientes_dia.Font = New System.Drawing.Font("Leelawadee", 31.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_clientes_dia.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txt_clientes_dia.Location = New System.Drawing.Point(213, 130)
        Me.txt_clientes_dia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txt_clientes_dia.MinimumSize = New System.Drawing.Size(200, 0)
        Me.txt_clientes_dia.Name = "txt_clientes_dia"
        Me.txt_clientes_dia.Size = New System.Drawing.Size(200, 64)
        Me.txt_clientes_dia.TabIndex = 6
        Me.txt_clientes_dia.Text = "NA"
        Me.txt_clientes_dia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cardapio_box
        '
        Me.cardapio_box.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cardapio_box.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cardapio_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cardapio_box.Controls.Add(Me.lbl_bebida)
        Me.cardapio_box.Controls.Add(Me.cardapio_bebida)
        Me.cardapio_box.Controls.Add(Me.cardapio_img)
        Me.cardapio_box.Controls.Add(Me.lbl_lanche)
        Me.cardapio_box.Controls.Add(Me.cardapio_lanche)
        Me.cardapio_box.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cardapio_box.Location = New System.Drawing.Point(945, 477)
        Me.cardapio_box.Margin = New System.Windows.Forms.Padding(0)
        Me.cardapio_box.Name = "cardapio_box"
        Me.cardapio_box.Size = New System.Drawing.Size(440, 250)
        Me.cardapio_box.TabIndex = 12
        '
        'lbl_bebida
        '
        Me.lbl_bebida.AutoSize = True
        Me.lbl_bebida.Font = New System.Drawing.Font("Leelawadee", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bebida.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_bebida.Location = New System.Drawing.Point(189, 88)
        Me.lbl_bebida.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_bebida.Name = "lbl_bebida"
        Me.lbl_bebida.Size = New System.Drawing.Size(224, 34)
        Me.lbl_bebida.TabIndex = 9
        Me.lbl_bebida.Text = "BEBIDA DO DIA"
        Me.lbl_bebida.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cardapio_bebida
        '
        Me.cardapio_bebida.AutoSize = True
        Me.cardapio_bebida.Font = New System.Drawing.Font("Leelawadee", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.cardapio_bebida.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cardapio_bebida.Location = New System.Drawing.Point(129, 59)
        Me.cardapio_bebida.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.cardapio_bebida.MaximumSize = New System.Drawing.Size(280, 0)
        Me.cardapio_bebida.MinimumSize = New System.Drawing.Size(280, 0)
        Me.cardapio_bebida.Name = "cardapio_bebida"
        Me.cardapio_bebida.Size = New System.Drawing.Size(280, 29)
        Me.cardapio_bebida.TabIndex = 10
        Me.cardapio_bebida.Text = "[Produto]"
        Me.cardapio_bebida.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cardapio_img
        '
        Me.cardapio_img.Image = CType(resources.GetObject("cardapio_img.Image"), System.Drawing.Image)
        Me.cardapio_img.Location = New System.Drawing.Point(26, 24)
        Me.cardapio_img.Margin = New System.Windows.Forms.Padding(4)
        Me.cardapio_img.Name = "cardapio_img"
        Me.cardapio_img.Size = New System.Drawing.Size(90, 90)
        Me.cardapio_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cardapio_img.TabIndex = 8
        Me.cardapio_img.TabStop = False
        '
        'lbl_lanche
        '
        Me.lbl_lanche.AutoSize = True
        Me.lbl_lanche.Font = New System.Drawing.Font("Leelawadee", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_lanche.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_lanche.Location = New System.Drawing.Point(181, 195)
        Me.lbl_lanche.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_lanche.Name = "lbl_lanche"
        Me.lbl_lanche.Size = New System.Drawing.Size(232, 34)
        Me.lbl_lanche.TabIndex = 5
        Me.lbl_lanche.Text = "LANCHE DO DIA"
        Me.lbl_lanche.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cardapio_lanche
        '
        Me.cardapio_lanche.AutoSize = True
        Me.cardapio_lanche.Font = New System.Drawing.Font("Leelawadee", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cardapio_lanche.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cardapio_lanche.Location = New System.Drawing.Point(28, 166)
        Me.cardapio_lanche.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.cardapio_lanche.MinimumSize = New System.Drawing.Size(385, 0)
        Me.cardapio_lanche.Name = "cardapio_lanche"
        Me.cardapio_lanche.Size = New System.Drawing.Size(385, 29)
        Me.cardapio_lanche.TabIndex = 6
        Me.cardapio_lanche.Text = "[Produto]"
        Me.cardapio_lanche.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_logout
        '
        Me.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_logout.Image = CType(resources.GetObject("btn_logout.Image"), System.Drawing.Image)
        Me.btn_logout.Location = New System.Drawing.Point(1337, 19)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(48, 48)
        Me.btn_logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_logout.TabIndex = 13
        Me.btn_logout.TabStop = False
        '
        'img_gerente
        '
        Me.img_gerente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.img_gerente.Location = New System.Drawing.Point(1251, 12)
        Me.img_gerente.Name = "img_gerente"
        Me.img_gerente.Size = New System.Drawing.Size(60, 60)
        Me.img_gerente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_gerente.TabIndex = 14
        Me.img_gerente.TabStop = False
        '
        'lbl_gerente_nome
        '
        Me.lbl_gerente_nome.AutoSize = True
        Me.lbl_gerente_nome.Font = New System.Drawing.Font("Leelawadee", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_gerente_nome.ForeColor = System.Drawing.Color.White
        Me.lbl_gerente_nome.Location = New System.Drawing.Point(845, 33)
        Me.lbl_gerente_nome.MaximumSize = New System.Drawing.Size(400, 0)
        Me.lbl_gerente_nome.MinimumSize = New System.Drawing.Size(400, 0)
        Me.lbl_gerente_nome.Name = "lbl_gerente_nome"
        Me.lbl_gerente_nome.Size = New System.Drawing.Size(400, 23)
        Me.lbl_gerente_nome.TabIndex = 15
        Me.lbl_gerente_nome.Text = "[Nome]"
        Me.lbl_gerente_nome.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'form_gerente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1410, 753)
        Me.Controls.Add(Me.lbl_gerente_nome)
        Me.Controls.Add(Me.img_gerente)
        Me.Controls.Add(Me.btn_logout)
        Me.Controls.Add(Me.cardapio_box)
        Me.Controls.Add(Me.clientes_box)
        Me.Controls.Add(Me.pedidos_box)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_gerente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gerir"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.btn_add_funcionario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.tab_pedidos.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.tab_clientes.ResumeLayout(False)
        Me.tab_clientes.PerformLayout()
        CType(Me.btn_novo_cliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pedidos_box.ResumeLayout(False)
        Me.pedidos_box.PerformLayout()
        CType(Me.pedidos_img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.clientes_box.ResumeLayout(False)
        Me.clientes_box.PerformLayout()
        CType(Me.clientes_img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cardapio_box.ResumeLayout(False)
        Me.cardapio_box.PerformLayout()
        CType(Me.cardapio_img, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_logout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_gerente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tab_pedidos As System.Windows.Forms.TabPage
    Friend WithEvents tab_clientes As System.Windows.Forms.TabPage
    Friend WithEvents pedidos_box As System.Windows.Forms.Panel
    Friend WithEvents pedidos_img As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_pedidos_dia As System.Windows.Forms.Label
    Friend WithEvents txt_pedidos_dia As System.Windows.Forms.Label
    Friend WithEvents btn_add_funcionario As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_pedidos_total As System.Windows.Forms.Label
    Friend WithEvents txt_pedidos_total As System.Windows.Forms.Label
    Friend WithEvents clientes_box As System.Windows.Forms.Panel
    Friend WithEvents lbl_clientes_total As System.Windows.Forms.Label
    Friend WithEvents txt_clientes_total As System.Windows.Forms.Label
    Friend WithEvents clientes_img As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_clientes_dia As System.Windows.Forms.Label
    Friend WithEvents txt_clientes_dia As System.Windows.Forms.Label
    Friend WithEvents cardapio_box As System.Windows.Forms.Panel
    Friend WithEvents lbl_bebida As System.Windows.Forms.Label
    Friend WithEvents cardapio_bebida As System.Windows.Forms.Label
    Friend WithEvents cardapio_img As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_lanche As System.Windows.Forms.Label
    Friend WithEvents cardapio_lanche As System.Windows.Forms.Label
    Friend WithEvents btn_logout As System.Windows.Forms.PictureBox
    Friend WithEvents img_gerente As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_gerente_nome As System.Windows.Forms.Label
    Friend WithEvents container_funcionarios As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbl_p_fazer As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents lbl_p_cancelados As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents lbl_p_finalizados As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lbl_p_entregues As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lbl_p_fazendo As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_novo_cliente As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
End Class
