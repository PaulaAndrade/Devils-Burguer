Public Class form_login
    Private Sub limpar_form()
        txt_login.Clear()
        txt_senha.Clear()
    End Sub

    Private Sub form_login_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.TopMost = True
        conectar_banco()
        splash_screen.Close()
        form_cozinheiro.Close()
        form_gerente.Close()
        form_mesas.Close()
    End Sub

    Private Sub verificar_teclas(sender As Object, e As KeyEventArgs) Handles txt_senha.KeyDown, txt_login.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
            Case Keys.Enter
                realizarLogin()
        End Select
    End Sub

    Private Sub fechar_form(sender As Object, e As KeyEventArgs) Handles btn_login_box.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub login_remover_placeholder(sender As Object, e As EventArgs) Handles txt_login.GotFocus
        'Placeholder
        If txt_login.Text = "Login" Then
            txt_login.ForeColor = Color.FromArgb(45, 52, 54)
            txt_login.Text = ""
        End If
    End Sub

    Private Sub login_corrigir_placeholder(sender As Object, e As EventArgs) Handles txt_login.LostFocus
        'Placeholder
        If txt_login.Text = "" Then
            txt_login.ForeColor = Color.FromArgb(204, 204, 204)
            txt_login.Text = "Login"
        End If
    End Sub

    Private Sub login_focar_input(sender As Object, e As EventArgs) Handles txt_login_box.Click
        txt_login.Focus()
    End Sub

    ' Input Senha
    Private Sub senha_remover_placeholder(sender As Object, e As EventArgs) Handles txt_senha.GotFocus
        'Placeholder
        If txt_senha.Text = "Senha" Then
            txt_senha.Text = ""
            txt_senha.PasswordChar = "*"
            txt_senha.ForeColor = Color.FromArgb(45, 52, 54)
        End If
    End Sub

    Private Sub senha_corrigir_placeholder(sender As Object, e As EventArgs) Handles txt_senha.LostFocus
        'Placeholder
        If txt_senha.Text = "" Then
            txt_senha.PasswordChar = ""
            txt_senha.Text = "Senha"
            txt_senha.ForeColor = Color.FromArgb(204, 204, 204)
        End If
    End Sub

    Private Sub senha_focar_input(sender As Object, e As EventArgs) Handles txt_senha_box.Click
        txt_senha.Focus()
    End Sub

    Private Sub clique_form(sender As Object, e As EventArgs) Handles Me.Click
        btn_login_box.Focus()
    End Sub

    Private Sub pressionar_login(sender As Object, e As EventArgs) Handles btn_login_box.Click, btn_login.Click
        Call realizarLogin()
    End Sub

    Private Sub realizarLogin()
        If txt_login.Text = "" Or txt_login.Text = "Login" Or txt_senha.Text = "" Or txt_senha.Text = "Senha" Then
            MsgBox("Preencha todos os campos", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Aviso")
            Exit Sub
        End If
        Try
            sql = "SELECT primeiro_acesso, idfuncionario FROM tb_acesso WHERE usuario='" & txt_login.Text & "' AND senha='" & txt_senha.Text & "'"
            rs = db.Execute(sql)
            sessao_usuario = txt_login.Text
            sessao_id = rs.Fields("idfuncionario").Value
            If rs.EOF Then
                MsgBox("Falha no login" & vbNewLine & "Credenciais incorretas", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Aviso")
                Exit Sub
            End If
            db.Execute("UPDATE tb_acesso SET ultimo_acesso='" & Date.Now & "' WHERE usuario='" & txt_login.Text & "'")
            If rs.Fields("primeiro_acesso").Value = "S" Then
                Primeiro_acesso.Show()
            End If
            tratarLogin()
        Catch
            MsgBox("Algum erro aconteceu", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Aviso")
        End Try
    End Sub

    Private Sub tratarLogin()
        sql = "SELECT cargo, nome, diretorio_foto FROM tb_funcionarios WHERE idfuncionario=" & sessao_id
        rs = db.Execute(sql)
        sessao_cargo = rs.Fields("cargo").Value
        sessao_nome = rs.Fields("nome").Value
        sessao_foto = rs.Fields("diretorio_foto").Value
        Select Case sessao_cargo
            Case "Operador"
                form_mesas.Show()
            Case "Gerente"
                form_gerente.Show()
            Case "Cozinheiro"
                form_cozinheiro.Show()
        End Select
    End Sub
End Class
