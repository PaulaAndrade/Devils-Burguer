<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_alterar_acesso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_alterar_acesso))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_acesso = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_visibilidade_2 = New System.Windows.Forms.PictureBox()
        Me.btn_visibilidade_1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_salvar_box = New System.Windows.Forms.Panel()
        Me.btn_salvar = New System.Windows.Forms.Label()
        Me.txt_senha_confirmar = New System.Windows.Forms.TextBox()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.btn_visibilidade_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_visibilidade_1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.btn_salvar_box.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.txt_acesso)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.btn_visibilidade_2)
        Me.Panel1.Controls.Add(Me.btn_visibilidade_1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btn_salvar_box)
        Me.Panel1.Controls.Add(Me.txt_senha_confirmar)
        Me.Panel1.Controls.Add(Me.txt_senha)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(16, 17)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(576, 419)
        Me.Panel1.TabIndex = 1
        '
        'txt_acesso
        '
        Me.txt_acesso.Font = New System.Drawing.Font("Leelawadee", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_acesso.Location = New System.Drawing.Point(67, 170)
        Me.txt_acesso.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_acesso.MaxLength = 15
        Me.txt_acesso.Name = "txt_acesso"
        Me.txt_acesso.Size = New System.Drawing.Size(443, 31)
        Me.txt_acesso.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Leelawadee", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(63, 147)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 20)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Login"
        '
        'btn_visibilidade_2
        '
        Me.btn_visibilidade_2.Image = CType(resources.GetObject("btn_visibilidade_2.Image"), System.Drawing.Image)
        Me.btn_visibilidade_2.Location = New System.Drawing.Point(478, 235)
        Me.btn_visibilidade_2.Name = "btn_visibilidade_2"
        Me.btn_visibilidade_2.Size = New System.Drawing.Size(32, 32)
        Me.btn_visibilidade_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_visibilidade_2.TabIndex = 30
        Me.btn_visibilidade_2.TabStop = False
        '
        'btn_visibilidade_1
        '
        Me.btn_visibilidade_1.Image = CType(resources.GetObject("btn_visibilidade_1.Image"), System.Drawing.Image)
        Me.btn_visibilidade_1.Location = New System.Drawing.Point(244, 235)
        Me.btn_visibilidade_1.Name = "btn_visibilidade_1"
        Me.btn_visibilidade_1.Size = New System.Drawing.Size(32, 32)
        Me.btn_visibilidade_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_visibilidade_1.TabIndex = 29
        Me.btn_visibilidade_1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Leelawadee UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 32)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.MaximumSize = New System.Drawing.Size(576, 0)
        Me.Label3.MinimumSize = New System.Drawing.Size(576, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(576, 45)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "ALTERAR ACESSO"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_salvar_box
        '
        Me.btn_salvar_box.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btn_salvar_box.Controls.Add(Me.btn_salvar)
        Me.btn_salvar_box.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_salvar_box.Location = New System.Drawing.Point(323, 330)
        Me.btn_salvar_box.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_salvar_box.Name = "btn_salvar_box"
        Me.btn_salvar_box.Size = New System.Drawing.Size(240, 76)
        Me.btn_salvar_box.TabIndex = 27
        '
        'btn_salvar
        '
        Me.btn_salvar.AutoSize = True
        Me.btn_salvar.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salvar.ForeColor = System.Drawing.Color.White
        Me.btn_salvar.Location = New System.Drawing.Point(57, 23)
        Me.btn_salvar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.btn_salvar.Name = "btn_salvar"
        Me.btn_salvar.Size = New System.Drawing.Size(117, 35)
        Me.btn_salvar.TabIndex = 0
        Me.btn_salvar.Text = "SALVAR"
        Me.btn_salvar.UseCompatibleTextRendering = True
        '
        'txt_senha_confirmar
        '
        Me.txt_senha_confirmar.Font = New System.Drawing.Font("Leelawadee", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha_confirmar.Location = New System.Drawing.Point(300, 236)
        Me.txt_senha_confirmar.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_senha_confirmar.MaxLength = 6
        Me.txt_senha_confirmar.Name = "txt_senha_confirmar"
        Me.txt_senha_confirmar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senha_confirmar.Size = New System.Drawing.Size(170, 31)
        Me.txt_senha_confirmar.TabIndex = 3
        '
        'txt_senha
        '
        Me.txt_senha.Font = New System.Drawing.Font("Leelawadee", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha.Location = New System.Drawing.Point(67, 236)
        Me.txt_senha.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_senha.MaxLength = 6
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senha.Size = New System.Drawing.Size(170, 31)
        Me.txt_senha.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Leelawadee", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(296, 213)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Confirmar nova senha"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Leelawadee", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(63, 213)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nova senha"
        '
        'form_alterar_acesso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(607, 453)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_alterar_acesso"
        Me.Text = "Alterar Acesso"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btn_visibilidade_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_visibilidade_1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.btn_salvar_box.ResumeLayout(False)
        Me.btn_salvar_box.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_visibilidade_2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_salvar_box As System.Windows.Forms.Panel
    Friend WithEvents btn_salvar As System.Windows.Forms.Label
    Friend WithEvents txt_senha_confirmar As System.Windows.Forms.TextBox
    Friend WithEvents txt_senha As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_acesso As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_visibilidade_1 As System.Windows.Forms.PictureBox
End Class
