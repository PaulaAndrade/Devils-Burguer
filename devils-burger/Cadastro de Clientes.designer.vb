<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_clientes))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_procurar = New System.Windows.Forms.PictureBox()
        Me.btn_limpar = New System.Windows.Forms.PictureBox()
        Me.txt_cep = New System.Windows.Forms.MaskedTextBox()
        Me.txt_complemento = New System.Windows.Forms.TextBox()
        Me.txt_endereco = New System.Windows.Forms.TextBox()
        Me.txt_cidade = New System.Windows.Forms.TextBox()
        Me.txt_bairro = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_telefone = New System.Windows.Forms.MaskedTextBox()
        Me.txt_celular = New System.Windows.Forms.MaskedTextBox()
        Me.txt_data_nascimento = New System.Windows.Forms.DateTimePicker()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_excluir = New System.Windows.Forms.Panel()
        Me.btn_excluir_lbl = New System.Windows.Forms.Label()
        Me.btn_gravar = New System.Windows.Forms.Panel()
        Me.btn_gravar_lbl = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.btn_procurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_limpar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.btn_excluir.SuspendLayout()
        Me.btn_gravar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btn_procurar)
        Me.Panel1.Controls.Add(Me.btn_limpar)
        Me.Panel1.Controls.Add(Me.txt_cep)
        Me.Panel1.Controls.Add(Me.txt_complemento)
        Me.Panel1.Controls.Add(Me.txt_endereco)
        Me.Panel1.Controls.Add(Me.txt_cidade)
        Me.Panel1.Controls.Add(Me.txt_bairro)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txt_telefone)
        Me.Panel1.Controls.Add(Me.txt_celular)
        Me.Panel1.Controls.Add(Me.txt_data_nascimento)
        Me.Panel1.Controls.Add(Me.txt_email)
        Me.Panel1.Controls.Add(Me.txt_cpf)
        Me.Panel1.Controls.Add(Me.txt_nome)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(20, 17)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(884, 436)
        Me.Panel1.TabIndex = 0
        '
        'btn_procurar
        '
        Me.btn_procurar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btn_procurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_procurar.Image = CType(resources.GetObject("btn_procurar.Image"), System.Drawing.Image)
        Me.btn_procurar.Location = New System.Drawing.Point(705, 17)
        Me.btn_procurar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_procurar.Name = "btn_procurar"
        Me.btn_procurar.Size = New System.Drawing.Size(69, 55)
        Me.btn_procurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_procurar.TabIndex = 24
        Me.btn_procurar.TabStop = False
        '
        'btn_limpar
        '
        Me.btn_limpar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btn_limpar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_limpar.Image = CType(resources.GetObject("btn_limpar.Image"), System.Drawing.Image)
        Me.btn_limpar.Location = New System.Drawing.Point(783, 16)
        Me.btn_limpar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_limpar.Name = "btn_limpar"
        Me.btn_limpar.Size = New System.Drawing.Size(69, 55)
        Me.btn_limpar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_limpar.TabIndex = 23
        Me.btn_limpar.TabStop = False
        '
        'txt_cep
        '
        Me.txt_cep.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cep.Location = New System.Drawing.Point(56, 294)
        Me.txt_cep.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_cep.Mask = "99999-999"
        Me.txt_cep.Name = "txt_cep"
        Me.txt_cep.Size = New System.Drawing.Size(115, 30)
        Me.txt_cep.TabIndex = 7
        '
        'txt_complemento
        '
        Me.txt_complemento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_complemento.Location = New System.Drawing.Point(637, 364)
        Me.txt_complemento.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_complemento.Name = "txt_complemento"
        Me.txt_complemento.Size = New System.Drawing.Size(215, 30)
        Me.txt_complemento.TabIndex = 11
        '
        'txt_endereco
        '
        Me.txt_endereco.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_endereco.Location = New System.Drawing.Point(56, 364)
        Me.txt_endereco.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_endereco.Name = "txt_endereco"
        Me.txt_endereco.Size = New System.Drawing.Size(572, 30)
        Me.txt_endereco.TabIndex = 10
        '
        'txt_cidade
        '
        Me.txt_cidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cidade.Location = New System.Drawing.Point(465, 294)
        Me.txt_cidade.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_cidade.Name = "txt_cidade"
        Me.txt_cidade.Size = New System.Drawing.Size(385, 30)
        Me.txt_cidade.TabIndex = 9
        '
        'txt_bairro
        '
        Me.txt_bairro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bairro.Location = New System.Drawing.Point(184, 294)
        Me.txt_bairro.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_bairro.Name = "txt_bairro"
        Me.txt_bairro.Size = New System.Drawing.Size(272, 30)
        Me.txt_bairro.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(633, 341)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(129, 20)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Complemento "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(464, 271)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 20)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Cidade "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(180, 271)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 20)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Bairro"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(52, 341)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 20)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Endereço"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(52, 271)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 20)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "CEP"
        '
        'txt_telefone
        '
        Me.txt_telefone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_telefone.Location = New System.Drawing.Point(692, 150)
        Me.txt_telefone.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_telefone.Mask = "0000-9999"
        Me.txt_telefone.Name = "txt_telefone"
        Me.txt_telefone.Size = New System.Drawing.Size(160, 30)
        Me.txt_telefone.TabIndex = 5
        '
        'txt_celular
        '
        Me.txt_celular.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_celular.Location = New System.Drawing.Point(497, 150)
        Me.txt_celular.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_celular.Mask = "(11)00000-9999"
        Me.txt_celular.Name = "txt_celular"
        Me.txt_celular.Size = New System.Drawing.Size(163, 30)
        Me.txt_celular.TabIndex = 4
        '
        'txt_data_nascimento
        '
        Me.txt_data_nascimento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_data_nascimento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_data_nascimento.Location = New System.Drawing.Point(260, 151)
        Me.txt_data_nascimento.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_data_nascimento.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.txt_data_nascimento.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.txt_data_nascimento.Name = "txt_data_nascimento"
        Me.txt_data_nascimento.Size = New System.Drawing.Size(203, 30)
        Me.txt_data_nascimento.TabIndex = 3
        '
        'txt_email
        '
        Me.txt_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.Location = New System.Drawing.Point(51, 226)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(800, 30)
        Me.txt_email.TabIndex = 6
        '
        'txt_cpf
        '
        Me.txt_cpf.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpf.Location = New System.Drawing.Point(49, 151)
        Me.txt_cpf.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_cpf.Mask = "999,999,999-99"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(167, 30)
        Me.txt_cpf.TabIndex = 2
        '
        'txt_nome
        '
        Me.txt_nome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome.Location = New System.Drawing.Point(51, 80)
        Me.txt_nome.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(800, 30)
        Me.txt_nome.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(256, 128)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(180, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Data de Nascimento"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(495, 127)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Celular "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(688, 127)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Telefone "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(47, 203)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Email"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(44, 128)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "CPF do Cliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 52)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome do Cliente"
        '
        'btn_excluir
        '
        Me.btn_excluir.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btn_excluir.Controls.Add(Me.btn_excluir_lbl)
        Me.btn_excluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_excluir.Location = New System.Drawing.Point(20, 526)
        Me.btn_excluir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_excluir.Name = "btn_excluir"
        Me.btn_excluir.Size = New System.Drawing.Size(884, 44)
        Me.btn_excluir.TabIndex = 14
        Me.btn_excluir.Visible = False
        '
        'btn_excluir_lbl
        '
        Me.btn_excluir_lbl.AutoSize = True
        Me.btn_excluir_lbl.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_excluir_lbl.ForeColor = System.Drawing.Color.White
        Me.btn_excluir_lbl.Location = New System.Drawing.Point(0, 5)
        Me.btn_excluir_lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.btn_excluir_lbl.MinimumSize = New System.Drawing.Size(884, 0)
        Me.btn_excluir_lbl.Name = "btn_excluir_lbl"
        Me.btn_excluir_lbl.Size = New System.Drawing.Size(884, 35)
        Me.btn_excluir_lbl.TabIndex = 0
        Me.btn_excluir_lbl.Text = "EXCLUIR"
        Me.btn_excluir_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_excluir_lbl.UseCompatibleTextRendering = True
        '
        'btn_gravar
        '
        Me.btn_gravar.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btn_gravar.Controls.Add(Me.btn_gravar_lbl)
        Me.btn_gravar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_gravar.Location = New System.Drawing.Point(20, 475)
        Me.btn_gravar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_gravar.Name = "btn_gravar"
        Me.btn_gravar.Size = New System.Drawing.Size(884, 43)
        Me.btn_gravar.TabIndex = 12
        '
        'btn_gravar_lbl
        '
        Me.btn_gravar_lbl.AutoSize = True
        Me.btn_gravar_lbl.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gravar_lbl.ForeColor = System.Drawing.Color.White
        Me.btn_gravar_lbl.Location = New System.Drawing.Point(0, 5)
        Me.btn_gravar_lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.btn_gravar_lbl.MinimumSize = New System.Drawing.Size(884, 0)
        Me.btn_gravar_lbl.Name = "btn_gravar_lbl"
        Me.btn_gravar_lbl.Size = New System.Drawing.Size(884, 35)
        Me.btn_gravar_lbl.TabIndex = 0
        Me.btn_gravar_lbl.Text = "SALVAR"
        Me.btn_gravar_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_gravar_lbl.UseCompatibleTextRendering = True
        '
        'form_clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(921, 601)
        Me.Controls.Add(Me.btn_excluir)
        Me.Controls.Add(Me.btn_gravar)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_clientes"
        Me.Text = "CADASTRO DE CLIENTES"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btn_procurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_limpar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.btn_excluir.ResumeLayout(False)
        Me.btn_excluir.PerformLayout()
        Me.btn_gravar.ResumeLayout(False)
        Me.btn_gravar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_nome As System.Windows.Forms.TextBox
    Friend WithEvents txt_cpf As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents txt_data_nascimento As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_celular As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_telefone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_cep As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_complemento As System.Windows.Forms.TextBox
    Friend WithEvents txt_endereco As System.Windows.Forms.TextBox
    Friend WithEvents txt_cidade As System.Windows.Forms.TextBox
    Friend WithEvents txt_bairro As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btn_excluir As System.Windows.Forms.Panel
    Friend WithEvents btn_excluir_lbl As System.Windows.Forms.Label
    Friend WithEvents btn_gravar As System.Windows.Forms.Panel
    Friend WithEvents btn_gravar_lbl As System.Windows.Forms.Label
    Friend WithEvents btn_limpar As System.Windows.Forms.PictureBox
    Friend WithEvents btn_procurar As System.Windows.Forms.PictureBox
End Class
