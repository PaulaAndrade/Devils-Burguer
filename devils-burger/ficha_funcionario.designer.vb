<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ficha_funcionario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ficha_funcionario))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.combo_sexo = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btn_procurar_cpf = New System.Windows.Forms.PictureBox()
        Me.combo_cargo = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_tel = New System.Windows.Forms.MaskedTextBox()
        Me.txt_cel = New System.Windows.Forms.MaskedTextBox()
        Me.txt_cep = New System.Windows.Forms.MaskedTextBox()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.txt_data = New System.Windows.Forms.DateTimePicker()
        Me.txt_comp = New System.Windows.Forms.TextBox()
        Me.txt_endereco = New System.Windows.Forms.TextBox()
        Me.txt_cidade = New System.Windows.Forms.TextBox()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_bairro = New System.Windows.Forms.TextBox()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.img_funcionario = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_salvar_box = New System.Windows.Forms.Panel()
        Me.btn_salvar_lbl = New System.Windows.Forms.Label()
        Me.btn_excluir_box = New System.Windows.Forms.Panel()
        Me.btn_excluir_lbl = New System.Windows.Forms.Label()
        Me.btn_editar_box = New System.Windows.Forms.Panel()
        Me.btn_editar_lbl = New System.Windows.Forms.Label()
        Me.img_dialog = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1.SuspendLayout()
        CType(Me.btn_procurar_cpf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_funcionario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.btn_salvar_box.SuspendLayout()
        Me.btn_excluir_box.SuspendLayout()
        Me.btn_editar_box.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.combo_sexo)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.btn_procurar_cpf)
        Me.Panel1.Controls.Add(Me.combo_cargo)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.txt_tel)
        Me.Panel1.Controls.Add(Me.txt_cel)
        Me.Panel1.Controls.Add(Me.txt_cep)
        Me.Panel1.Controls.Add(Me.txt_cpf)
        Me.Panel1.Controls.Add(Me.txt_data)
        Me.Panel1.Controls.Add(Me.txt_comp)
        Me.Panel1.Controls.Add(Me.txt_endereco)
        Me.Panel1.Controls.Add(Me.txt_cidade)
        Me.Panel1.Controls.Add(Me.txt_email)
        Me.Panel1.Controls.Add(Me.txt_bairro)
        Me.Panel1.Controls.Add(Me.txt_nome)
        Me.Panel1.Controls.Add(Me.img_funcionario)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(16, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(736, 411)
        Me.Panel1.TabIndex = 0
        '
        'combo_sexo
        '
        Me.combo_sexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_sexo.FormattingEnabled = True
        Me.combo_sexo.Items.AddRange(New Object() {"Feminino ", "Masculino"})
        Me.combo_sexo.Location = New System.Drawing.Point(381, 100)
        Me.combo_sexo.Name = "combo_sexo"
        Me.combo_sexo.Size = New System.Drawing.Size(133, 33)
        Me.combo_sexo.TabIndex = 34
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(378, 81)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 20)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = "Sexo"
        '
        'btn_procurar_cpf
        '
        Me.btn_procurar_cpf.Image = CType(resources.GetObject("btn_procurar_cpf.Image"), System.Drawing.Image)
        Me.btn_procurar_cpf.Location = New System.Drawing.Point(338, 100)
        Me.btn_procurar_cpf.Name = "btn_procurar_cpf"
        Me.btn_procurar_cpf.Size = New System.Drawing.Size(26, 26)
        Me.btn_procurar_cpf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_procurar_cpf.TabIndex = 32
        Me.btn_procurar_cpf.TabStop = False
        '
        'combo_cargo
        '
        Me.combo_cargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_cargo.FormattingEnabled = True
        Me.combo_cargo.Items.AddRange(New Object() {"Operador", "Cozinheiro", "Gerente", "Garçom", "Faxineiro"})
        Me.combo_cargo.Location = New System.Drawing.Point(327, 357)
        Me.combo_cargo.Name = "combo_cargo"
        Me.combo_cargo.Size = New System.Drawing.Size(163, 33)
        Me.combo_cargo.TabIndex = 12
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(325, 338)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 20)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Cargo*"
        '
        'txt_tel
        '
        Me.txt_tel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tel.Location = New System.Drawing.Point(173, 357)
        Me.txt_tel.Mask = "0000-9999"
        Me.txt_tel.Name = "txt_tel"
        Me.txt_tel.Size = New System.Drawing.Size(121, 30)
        Me.txt_tel.TabIndex = 11
        '
        'txt_cel
        '
        Me.txt_cel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cel.Location = New System.Drawing.Point(27, 357)
        Me.txt_cel.Mask = "(11)00000-9999"
        Me.txt_cel.Name = "txt_cel"
        Me.txt_cel.Size = New System.Drawing.Size(123, 30)
        Me.txt_cel.TabIndex = 10
        '
        'txt_cep
        '
        Me.txt_cep.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cep.Location = New System.Drawing.Point(33, 221)
        Me.txt_cep.Mask = "99999-999"
        Me.txt_cep.Name = "txt_cep"
        Me.txt_cep.Size = New System.Drawing.Size(87, 30)
        Me.txt_cep.TabIndex = 5
        '
        'txt_cpf
        '
        Me.txt_cpf.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpf.Location = New System.Drawing.Point(206, 100)
        Me.txt_cpf.Mask = "999,999,999-99"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(126, 30)
        Me.txt_cpf.TabIndex = 2
        '
        'txt_data
        '
        Me.txt_data.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_data.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_data.Location = New System.Drawing.Point(33, 100)
        Me.txt_data.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.txt_data.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.txt_data.Name = "txt_data"
        Me.txt_data.Size = New System.Drawing.Size(153, 30)
        Me.txt_data.TabIndex = 3
        '
        'txt_comp
        '
        Me.txt_comp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_comp.Location = New System.Drawing.Point(480, 294)
        Me.txt_comp.Name = "txt_comp"
        Me.txt_comp.Size = New System.Drawing.Size(205, 30)
        Me.txt_comp.TabIndex = 9
        '
        'txt_endereco
        '
        Me.txt_endereco.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_endereco.Location = New System.Drawing.Point(27, 294)
        Me.txt_endereco.Name = "txt_endereco"
        Me.txt_endereco.Size = New System.Drawing.Size(430, 30)
        Me.txt_endereco.TabIndex = 8
        '
        'txt_cidade
        '
        Me.txt_cidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cidade.Location = New System.Drawing.Point(396, 221)
        Me.txt_cidade.Name = "txt_cidade"
        Me.txt_cidade.Size = New System.Drawing.Size(290, 30)
        Me.txt_cidade.TabIndex = 7
        '
        'txt_email
        '
        Me.txt_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.Location = New System.Drawing.Point(33, 159)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(481, 30)
        Me.txt_email.TabIndex = 4
        '
        'txt_bairro
        '
        Me.txt_bairro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bairro.Location = New System.Drawing.Point(155, 221)
        Me.txt_bairro.Name = "txt_bairro"
        Me.txt_bairro.Size = New System.Drawing.Size(205, 30)
        Me.txt_bairro.TabIndex = 6
        '
        'txt_nome
        '
        Me.txt_nome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome.Location = New System.Drawing.Point(30, 35)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(484, 30)
        Me.txt_nome.TabIndex = 1
        '
        'img_funcionario
        '
        Me.img_funcionario.BackgroundImage = CType(resources.GetObject("img_funcionario.BackgroundImage"), System.Drawing.Image)
        Me.img_funcionario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.img_funcionario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.img_funcionario.Location = New System.Drawing.Point(536, 20)
        Me.img_funcionario.Name = "img_funcionario"
        Me.img_funcionario.Size = New System.Drawing.Size(184, 181)
        Me.img_funcionario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_funcionario.TabIndex = 11
        Me.img_funcionario.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(477, 275)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(129, 20)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Complemento "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(24, 338)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 20)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Celular"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(170, 338)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 20)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Telefone"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(395, 202)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 20)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Cidade "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(152, 202)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Bairro"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 275)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Endereço"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(30, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "CEP*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Email*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(187, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Data de Nascimento*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(203, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "CPF*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome Completo*"
        '
        'btn_salvar_box
        '
        Me.btn_salvar_box.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btn_salvar_box.Controls.Add(Me.btn_salvar_lbl)
        Me.btn_salvar_box.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_salvar_box.Location = New System.Drawing.Point(294, 446)
        Me.btn_salvar_box.Name = "btn_salvar_box"
        Me.btn_salvar_box.Size = New System.Drawing.Size(180, 62)
        Me.btn_salvar_box.TabIndex = 26
        '
        'btn_salvar_lbl
        '
        Me.btn_salvar_lbl.AutoSize = True
        Me.btn_salvar_lbl.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salvar_lbl.ForeColor = System.Drawing.Color.White
        Me.btn_salvar_lbl.Location = New System.Drawing.Point(43, 19)
        Me.btn_salvar_lbl.Name = "btn_salvar_lbl"
        Me.btn_salvar_lbl.Size = New System.Drawing.Size(117, 35)
        Me.btn_salvar_lbl.TabIndex = 0
        Me.btn_salvar_lbl.Text = "SALVAR"
        Me.btn_salvar_lbl.UseCompatibleTextRendering = True
        '
        'btn_excluir_box
        '
        Me.btn_excluir_box.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btn_excluir_box.Controls.Add(Me.btn_excluir_lbl)
        Me.btn_excluir_box.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_excluir_box.Location = New System.Drawing.Point(74, 446)
        Me.btn_excluir_box.Name = "btn_excluir_box"
        Me.btn_excluir_box.Size = New System.Drawing.Size(180, 62)
        Me.btn_excluir_box.TabIndex = 27
        Me.btn_excluir_box.Visible = False
        '
        'btn_excluir_lbl
        '
        Me.btn_excluir_lbl.AutoSize = True
        Me.btn_excluir_lbl.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_excluir_lbl.ForeColor = System.Drawing.Color.White
        Me.btn_excluir_lbl.Location = New System.Drawing.Point(43, 19)
        Me.btn_excluir_lbl.Name = "btn_excluir_lbl"
        Me.btn_excluir_lbl.Size = New System.Drawing.Size(129, 35)
        Me.btn_excluir_lbl.TabIndex = 0
        Me.btn_excluir_lbl.Text = "EXCLUIR"
        Me.btn_excluir_lbl.UseCompatibleTextRendering = True
        '
        'btn_editar_box
        '
        Me.btn_editar_box.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btn_editar_box.Controls.Add(Me.btn_editar_lbl)
        Me.btn_editar_box.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_editar_box.Location = New System.Drawing.Point(510, 446)
        Me.btn_editar_box.Name = "btn_editar_box"
        Me.btn_editar_box.Size = New System.Drawing.Size(180, 62)
        Me.btn_editar_box.TabIndex = 27
        Me.btn_editar_box.Visible = False
        '
        'btn_editar_lbl
        '
        Me.btn_editar_lbl.AutoSize = True
        Me.btn_editar_lbl.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_editar_lbl.ForeColor = System.Drawing.Color.White
        Me.btn_editar_lbl.Location = New System.Drawing.Point(43, 19)
        Me.btn_editar_lbl.Name = "btn_editar_lbl"
        Me.btn_editar_lbl.Size = New System.Drawing.Size(114, 35)
        Me.btn_editar_lbl.TabIndex = 0
        Me.btn_editar_lbl.Text = "EDITAR"
        Me.btn_editar_lbl.UseCompatibleTextRendering = True
        '
        'ficha_funcionario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(769, 528)
        Me.Controls.Add(Me.btn_editar_box)
        Me.Controls.Add(Me.btn_excluir_box)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_salvar_box)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "ficha_funcionario"
        Me.Padding = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ficha de Funcionário"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btn_procurar_cpf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_funcionario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.btn_salvar_box.ResumeLayout(False)
        Me.btn_salvar_box.PerformLayout()
        Me.btn_excluir_box.ResumeLayout(False)
        Me.btn_excluir_box.PerformLayout()
        Me.btn_editar_box.ResumeLayout(False)
        Me.btn_editar_box.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_comp As System.Windows.Forms.TextBox
    Friend WithEvents txt_endereco As System.Windows.Forms.TextBox
    Friend WithEvents txt_cidade As System.Windows.Forms.TextBox
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents txt_bairro As System.Windows.Forms.TextBox
    Friend WithEvents txt_nome As System.Windows.Forms.TextBox
    Friend WithEvents img_funcionario As System.Windows.Forms.PictureBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_data As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_cpf As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_cep As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_tel As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_cel As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btn_salvar_box As System.Windows.Forms.Panel
    Friend WithEvents btn_salvar_lbl As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents combo_cargo As System.Windows.Forms.ComboBox
    Friend WithEvents btn_excluir_box As System.Windows.Forms.Panel
    Friend WithEvents btn_excluir_lbl As System.Windows.Forms.Label
    Friend WithEvents btn_editar_box As System.Windows.Forms.Panel
    Friend WithEvents btn_editar_lbl As System.Windows.Forms.Label
    Friend WithEvents btn_procurar_cpf As System.Windows.Forms.PictureBox
    Friend WithEvents combo_sexo As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents img_dialog As System.Windows.Forms.OpenFileDialog

End Class
