<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_pedido
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_pedido))
        Me.painel_pedido = New System.Windows.Forms.Panel()
        Me.txt_cliente_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.combo_garcom = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.box_selecionados = New System.Windows.Forms.ListBox()
        Me.txt_observacoes = New System.Windows.Forms.TextBox()
        Me.btn_finalizar_box = New System.Windows.Forms.Panel()
        Me.btn_finalizar_lbl = New System.Windows.Forms.Label()
        Me.txt_preco_total = New System.Windows.Forms.Label()
        Me.btn_verificar_cpf = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_cliente_nome = New System.Windows.Forms.TextBox()
        Me.lbl_cliente = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cardapio_alimentos = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cardapio_bebidas = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_mesa_id = New System.Windows.Forms.Label()
        Me.btn_novo_cliente_icon = New System.Windows.Forms.PictureBox()
        Me.btn_novo_cliente_lbl = New System.Windows.Forms.Label()
        Me.btn_novo_cliente = New System.Windows.Forms.Panel()
        Me.painel_pedido.SuspendLayout()
        Me.btn_finalizar_box.SuspendLayout()
        CType(Me.btn_verificar_cpf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.btn_novo_cliente_icon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.btn_novo_cliente.SuspendLayout()
        Me.SuspendLayout()
        '
        'painel_pedido
        '
        Me.painel_pedido.BackColor = System.Drawing.Color.White
        Me.painel_pedido.Controls.Add(Me.txt_cliente_cpf)
        Me.painel_pedido.Controls.Add(Me.combo_garcom)
        Me.painel_pedido.Controls.Add(Me.Label5)
        Me.painel_pedido.Controls.Add(Me.box_selecionados)
        Me.painel_pedido.Controls.Add(Me.txt_observacoes)
        Me.painel_pedido.Controls.Add(Me.btn_finalizar_box)
        Me.painel_pedido.Controls.Add(Me.txt_preco_total)
        Me.painel_pedido.Controls.Add(Me.btn_verificar_cpf)
        Me.painel_pedido.Controls.Add(Me.Label4)
        Me.painel_pedido.Controls.Add(Me.txt_cliente_nome)
        Me.painel_pedido.Controls.Add(Me.lbl_cliente)
        Me.painel_pedido.Location = New System.Drawing.Point(889, 34)
        Me.painel_pedido.Name = "painel_pedido"
        Me.painel_pedido.Size = New System.Drawing.Size(470, 640)
        Me.painel_pedido.TabIndex = 0
        '
        'txt_cliente_cpf
        '
        Me.txt_cliente_cpf.Font = New System.Drawing.Font("Leelawadee", 10.8!)
        Me.txt_cliente_cpf.Location = New System.Drawing.Point(29, 138)
        Me.txt_cliente_cpf.Mask = "000,000,000-00"
        Me.txt_cliente_cpf.Name = "txt_cliente_cpf"
        Me.txt_cliente_cpf.Size = New System.Drawing.Size(155, 29)
        Me.txt_cliente_cpf.TabIndex = 32
        '
        'combo_garcom
        '
        Me.combo_garcom.Font = New System.Drawing.Font("Leelawadee", 10.8!)
        Me.combo_garcom.FormattingEnabled = True
        Me.combo_garcom.Location = New System.Drawing.Point(251, 56)
        Me.combo_garcom.Name = "combo_garcom"
        Me.combo_garcom.Size = New System.Drawing.Size(192, 29)
        Me.combo_garcom.TabIndex = 31
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Leelawadee", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(246, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 29)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "GARÇOM"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'box_selecionados
        '
        Me.box_selecionados.Font = New System.Drawing.Font("Leelawadee", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.box_selecionados.FormattingEnabled = True
        Me.box_selecionados.ItemHeight = 24
        Me.box_selecionados.Location = New System.Drawing.Point(30, 197)
        Me.box_selecionados.Name = "box_selecionados"
        Me.box_selecionados.Size = New System.Drawing.Size(413, 196)
        Me.box_selecionados.TabIndex = 24
        '
        'txt_observacoes
        '
        Me.txt_observacoes.Location = New System.Drawing.Point(30, 435)
        Me.txt_observacoes.Multiline = True
        Me.txt_observacoes.Name = "txt_observacoes"
        Me.txt_observacoes.Size = New System.Drawing.Size(413, 85)
        Me.txt_observacoes.TabIndex = 28
        '
        'btn_finalizar_box
        '
        Me.btn_finalizar_box.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btn_finalizar_box.Controls.Add(Me.btn_finalizar_lbl)
        Me.btn_finalizar_box.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_finalizar_box.Location = New System.Drawing.Point(128, 536)
        Me.btn_finalizar_box.Name = "btn_finalizar_box"
        Me.btn_finalizar_box.Size = New System.Drawing.Size(225, 75)
        Me.btn_finalizar_box.TabIndex = 27
        '
        'btn_finalizar_lbl
        '
        Me.btn_finalizar_lbl.AutoSize = True
        Me.btn_finalizar_lbl.Font = New System.Drawing.Font("Leelawadee", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_finalizar_lbl.ForeColor = System.Drawing.Color.White
        Me.btn_finalizar_lbl.Location = New System.Drawing.Point(0, 24)
        Me.btn_finalizar_lbl.MinimumSize = New System.Drawing.Size(225, 0)
        Me.btn_finalizar_lbl.Name = "btn_finalizar_lbl"
        Me.btn_finalizar_lbl.Size = New System.Drawing.Size(225, 29)
        Me.btn_finalizar_lbl.TabIndex = 28
        Me.btn_finalizar_lbl.Text = "FINALIZAR"
        Me.btn_finalizar_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_preco_total
        '
        Me.txt_preco_total.AutoSize = True
        Me.txt_preco_total.Font = New System.Drawing.Font("Leelawadee", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_preco_total.ForeColor = System.Drawing.Color.Black
        Me.txt_preco_total.Location = New System.Drawing.Point(243, 122)
        Me.txt_preco_total.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_preco_total.MinimumSize = New System.Drawing.Size(200, 0)
        Me.txt_preco_total.Name = "txt_preco_total"
        Me.txt_preco_total.Size = New System.Drawing.Size(200, 48)
        Me.txt_preco_total.TabIndex = 26
        Me.txt_preco_total.Text = "R$0,00"
        Me.txt_preco_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_verificar_cpf
        '
        Me.btn_verificar_cpf.Image = CType(resources.GetObject("btn_verificar_cpf.Image"), System.Drawing.Image)
        Me.btn_verificar_cpf.Location = New System.Drawing.Point(190, 133)
        Me.btn_verificar_cpf.Name = "btn_verificar_cpf"
        Me.btn_verificar_cpf.Size = New System.Drawing.Size(40, 40)
        Me.btn_verificar_cpf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_verificar_cpf.TabIndex = 21
        Me.btn_verificar_cpf.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Leelawadee", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(24, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 29)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "CPF CLIENTE"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_cliente_nome
        '
        Me.txt_cliente_nome.Font = New System.Drawing.Font("Leelawadee", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cliente_nome.Location = New System.Drawing.Point(29, 56)
        Me.txt_cliente_nome.Name = "txt_cliente_nome"
        Me.txt_cliente_nome.Size = New System.Drawing.Size(201, 29)
        Me.txt_cliente_nome.TabIndex = 22
        '
        'lbl_cliente
        '
        Me.lbl_cliente.AutoSize = True
        Me.lbl_cliente.Font = New System.Drawing.Font("Leelawadee", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cliente.ForeColor = System.Drawing.Color.Black
        Me.lbl_cliente.Location = New System.Drawing.Point(24, 24)
        Me.lbl_cliente.Name = "lbl_cliente"
        Me.lbl_cliente.Size = New System.Drawing.Size(107, 29)
        Me.lbl_cliente.TabIndex = 21
        Me.lbl_cliente.Text = "CLIENTE"
        Me.lbl_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel3.Controls.Add(Me.cardapio_alimentos)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(34, 104)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(410, 570)
        Me.Panel3.TabIndex = 2
        '
        'cardapio_alimentos
        '
        Me.cardapio_alimentos.AutoScroll = True
        Me.cardapio_alimentos.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.cardapio_alimentos.Location = New System.Drawing.Point(0, 70)
        Me.cardapio_alimentos.Name = "cardapio_alimentos"
        Me.cardapio_alimentos.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.cardapio_alimentos.Size = New System.Drawing.Size(410, 480)
        Me.cardapio_alimentos.TabIndex = 22
        Me.cardapio_alimentos.WrapContents = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Location = New System.Drawing.Point(16, 52)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(380, 1)
        Me.Panel4.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Leelawadee", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(133, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 34)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Alimentos"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel2.Controls.Add(Me.cardapio_bebidas)
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Location = New System.Drawing.Point(461, 104)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(410, 570)
        Me.Panel2.TabIndex = 3
        '
        'cardapio_bebidas
        '
        Me.cardapio_bebidas.AutoScroll = True
        Me.cardapio_bebidas.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.cardapio_bebidas.Location = New System.Drawing.Point(0, 70)
        Me.cardapio_bebidas.Name = "cardapio_bebidas"
        Me.cardapio_bebidas.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.cardapio_bebidas.Size = New System.Drawing.Size(410, 480)
        Me.cardapio_bebidas.TabIndex = 23
        Me.cardapio_bebidas.WrapContents = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.White
        Me.Panel7.Location = New System.Drawing.Point(15, 52)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(380, 1)
        Me.Panel7.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Leelawadee", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(144, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 34)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Bebidas"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_mesa_id
        '
        Me.lbl_mesa_id.AutoSize = True
        Me.lbl_mesa_id.Font = New System.Drawing.Font("Leelawadee", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mesa_id.ForeColor = System.Drawing.Color.White
        Me.lbl_mesa_id.Location = New System.Drawing.Point(37, 33)
        Me.lbl_mesa_id.Name = "lbl_mesa_id"
        Me.lbl_mesa_id.Size = New System.Drawing.Size(210, 48)
        Me.lbl_mesa_id.TabIndex = 18
        Me.lbl_mesa_id.Tag = ""
        Me.lbl_mesa_id.Text = "MESA [ID]"
        Me.lbl_mesa_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.btn_novo_cliente_lbl.ForeColor = System.Drawing.Color.White
        Me.btn_novo_cliente_lbl.Location = New System.Drawing.Point(46, 10)
        Me.btn_novo_cliente_lbl.Name = "btn_novo_cliente_lbl"
        Me.btn_novo_cliente_lbl.Size = New System.Drawing.Size(84, 23)
        Me.btn_novo_cliente_lbl.TabIndex = 20
        Me.btn_novo_cliente_lbl.Text = "CLIENTE"
        Me.btn_novo_cliente_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_novo_cliente
        '
        Me.btn_novo_cliente.Controls.Add(Me.btn_novo_cliente_icon)
        Me.btn_novo_cliente.Controls.Add(Me.btn_novo_cliente_lbl)
        Me.btn_novo_cliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_novo_cliente.Location = New System.Drawing.Point(739, 41)
        Me.btn_novo_cliente.Name = "btn_novo_cliente"
        Me.btn_novo_cliente.Size = New System.Drawing.Size(132, 40)
        Me.btn_novo_cliente.TabIndex = 21
        '
        'form_pedido
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1392, 706)
        Me.Controls.Add(Me.btn_novo_cliente)
        Me.Controls.Add(Me.lbl_mesa_id)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.painel_pedido)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_pedido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fazer um pedido"
        Me.painel_pedido.ResumeLayout(False)
        Me.painel_pedido.PerformLayout()
        Me.btn_finalizar_box.ResumeLayout(False)
        Me.btn_finalizar_box.PerformLayout()
        CType(Me.btn_verificar_cpf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.btn_novo_cliente_icon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.btn_novo_cliente.ResumeLayout(False)
        Me.btn_novo_cliente.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents painel_pedido As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lbl_mesa_id As System.Windows.Forms.Label
    Friend WithEvents btn_novo_cliente_icon As System.Windows.Forms.PictureBox
    Friend WithEvents btn_novo_cliente_lbl As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_cliente_nome As System.Windows.Forms.TextBox
    Friend WithEvents lbl_cliente As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_verificar_cpf As System.Windows.Forms.PictureBox
    Friend WithEvents txt_preco_total As System.Windows.Forms.Label
    Friend WithEvents btn_finalizar_box As System.Windows.Forms.Panel
    Friend WithEvents btn_finalizar_lbl As System.Windows.Forms.Label
    Friend WithEvents txt_observacoes As System.Windows.Forms.TextBox
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents box_selecionados As System.Windows.Forms.ListBox
    Friend WithEvents cardapio_alimentos As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents cardapio_bebidas As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents combo_garcom As System.Windows.Forms.ComboBox
    Friend WithEvents txt_cliente_cpf As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btn_novo_cliente As System.Windows.Forms.Panel
End Class
