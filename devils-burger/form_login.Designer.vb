<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_login))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_login_box = New System.Windows.Forms.Panel()
        Me.txt_senha_box = New System.Windows.Forms.Panel()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.txt_login = New System.Windows.Forms.TextBox()
        Me.txt_login_box = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_login = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.btn_login_box.SuspendLayout()
        Me.txt_senha_box.SuspendLayout()
        Me.txt_login_box.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.btn_login_box)
        Me.Panel2.Controls.Add(Me.txt_senha_box)
        Me.Panel2.Location = New System.Drawing.Point(-145, 275)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(0, 10, 0, 10)
        Me.Panel2.Size = New System.Drawing.Size(900, 500)
        Me.Panel2.TabIndex = 3
        '
        'btn_login_box
        '
        Me.btn_login_box.BackColor = System.Drawing.Color.Transparent
        Me.btn_login_box.BackgroundImage = CType(resources.GetObject("btn_login_box.BackgroundImage"), System.Drawing.Image)
        Me.btn_login_box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_login_box.Controls.Add(Me.btn_login)
        Me.btn_login_box.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_login_box.Location = New System.Drawing.Point(334, 220)
        Me.btn_login_box.Name = "btn_login_box"
        Me.btn_login_box.Size = New System.Drawing.Size(242, 89)
        Me.btn_login_box.TabIndex = 4
        '
        'txt_senha_box
        '
        Me.txt_senha_box.BackColor = System.Drawing.Color.Transparent
        Me.txt_senha_box.BackgroundImage = CType(resources.GetObject("txt_senha_box.BackgroundImage"), System.Drawing.Image)
        Me.txt_senha_box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txt_senha_box.Controls.Add(Me.txt_senha)
        Me.txt_senha_box.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_senha_box.Location = New System.Drawing.Point(242, 68)
        Me.txt_senha_box.Name = "txt_senha_box"
        Me.txt_senha_box.Size = New System.Drawing.Size(410, 60)
        Me.txt_senha_box.TabIndex = 3
        '
        'txt_senha
        '
        Me.txt_senha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_senha.Font = New System.Drawing.Font("Microsoft JhengHei", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.txt_senha.Location = New System.Drawing.Point(35, 17)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(344, 31)
        Me.txt_senha.TabIndex = 0
        Me.txt_senha.Text = "Senha"
        '
        'txt_login
        '
        Me.txt_login.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_login.Font = New System.Drawing.Font("Microsoft JhengHei", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_login.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.txt_login.Location = New System.Drawing.Point(35, 17)
        Me.txt_login.Name = "txt_login"
        Me.txt_login.Size = New System.Drawing.Size(344, 31)
        Me.txt_login.TabIndex = 0
        Me.txt_login.Text = "Login"
        '
        'txt_login_box
        '
        Me.txt_login_box.BackColor = System.Drawing.Color.Transparent
        Me.txt_login_box.BackgroundImage = CType(resources.GetObject("txt_login_box.BackgroundImage"), System.Drawing.Image)
        Me.txt_login_box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txt_login_box.Controls.Add(Me.txt_login)
        Me.txt_login_box.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_login_box.Location = New System.Drawing.Point(97, 275)
        Me.txt_login_box.Name = "txt_login_box"
        Me.txt_login_box.Size = New System.Drawing.Size(410, 60)
        Me.txt_login_box.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Leelawadee UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(180, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 81)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "DEVIL'S" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Leelawadee UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(171, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(269, 81)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "BURGER"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_login
        '
        Me.btn_login.AutoSize = True
        Me.btn_login.Font = New System.Drawing.Font("Leelawadee UI", 22.2!, System.Drawing.FontStyle.Bold)
        Me.btn_login.ForeColor = System.Drawing.Color.White
        Me.btn_login.Location = New System.Drawing.Point(51, 17)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(139, 51)
        Me.btn_login.TabIndex = 0
        Me.btn_login.Text = "LOGIN"
        '
        'form_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(610, 669)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_login_box)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Panel2.ResumeLayout(False)
        Me.btn_login_box.ResumeLayout(False)
        Me.btn_login_box.PerformLayout()
        Me.txt_senha_box.ResumeLayout(False)
        Me.txt_senha_box.PerformLayout()
        Me.txt_login_box.ResumeLayout(False)
        Me.txt_login_box.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btn_login_box As System.Windows.Forms.Panel
    Friend WithEvents txt_login As System.Windows.Forms.TextBox
    Protected WithEvents txt_senha_box As System.Windows.Forms.Panel
    Friend WithEvents txt_senha As System.Windows.Forms.TextBox
    Protected WithEvents txt_login_box As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_login As System.Windows.Forms.Label

End Class
