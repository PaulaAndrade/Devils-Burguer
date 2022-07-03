Public Class form_alterar_acesso
    Private visibilidade_1 As Boolean = False
    Private visibilidade_2 As Boolean = False
    Private _usuario As String = ""
    Private _usuario_novo As String = ""
    Private _idfuncionario As Integer

    Public Sub New(usuario As String, id As Integer)
        _usuario = usuario
        _idfuncionario = id
        InitializeComponent()
    End Sub

    Private Sub inicio(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_acesso.Text = _usuario
    End Sub


    Private Sub cliqueSalvar(sender As Object, e As EventArgs) Handles btn_salvar_box.Click, btn_salvar.Click
        testarSenha()
    End Sub

    Private Sub testarSenha()
        If txt_senha.Text = "" Or txt_senha_confirmar.Text = "" Then
            MsgBox("Preencha todos os campos", MsgBoxStyle.Information, "Aviso")
            Exit Sub
        ElseIf txt_senha.Text <> txt_senha_confirmar.Text Then
            MsgBox("Senhas não são iguais", MsgBoxStyle.Exclamation, "Aviso")
            Exit Sub
        End If
        alterarSenha()
    End Sub

    Private Sub alterarSenha()
        Try
            _usuario_novo = txt_acesso.Text
            If _usuario <> _usuario_novo Then
                rs = db.Execute("SELECT * FROM tb_acesso WHERE usuario='" & _usuario_novo & "'")
                If rs.EOF = False Then
                    MsgBox("Este nome de usuário já existe", MsgBoxStyle.Information, "Aviso")
                    Exit Sub
                End If
            End If
            rs = db.Execute("SELECT * from tb_acesso where usuario='" & _usuario_novo & "'")
            sql = "UPDATE tb_acesso SET usuario='" & _usuario_novo & "', senha='" & txt_senha.Text & "' WHERE idfuncionario=" & _idfuncionario
            db.Execute(sql)
            MsgBox("Acesso e/ou login de usuário alterado(s)", MsgBoxStyle.Information, "Sucesso")
            Me.Close()
        Catch
            MsgBox("Algum erro ocorreu", MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub

    Private Sub alterarVisibilidade1(sender As Object, e As EventArgs) Handles btn_visibilidade_1.Click
        If visibilidade_1 Then
            visibilidade_1 = False
            txt_senha.PasswordChar = "*"
            btn_visibilidade_1.Load(Application.StartupPath & "/img/icons/visibilidade-nao.png")
        Else
            visibilidade_1 = True
            txt_senha.PasswordChar = ""
            btn_visibilidade_1.Load(Application.StartupPath & "/img/icons/visibilidade-sim.png")
        End If
    End Sub


    Private Sub alterarVisibilidade2(sender As Object, e As EventArgs) Handles btn_visibilidade_2.Click
        If visibilidade_2 Then
            visibilidade_2 = False
            txt_senha_confirmar.PasswordChar = "*"
            btn_visibilidade_2.Load(Application.StartupPath & "/img/icons/visibilidade-nao.png")
        Else
            visibilidade_2 = True
            txt_senha_confirmar.PasswordChar = ""
            btn_visibilidade_2.Load(Application.StartupPath & "/img/icons/visibilidade-sim.png")
        End If
    End Sub

    Private Sub inputs_keydowm(sender As Object, e As KeyEventArgs) Handles txt_senha.KeyDown, txt_senha_confirmar.KeyDown, txt_acesso.KeyDown
        If e.KeyCode = Keys.Enter Then
            testarSenha()
        End If
    End Sub
End Class