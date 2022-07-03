Public Class Primeiro_acesso
    Dim visibilidade_1 As Boolean = False
    Dim visibilidade_2 As Boolean = False


    Private Sub Primeiro_acesso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        form_login.Close()
    End Sub


    Private Sub clique_btn(sender As Object, e As EventArgs) Handles btn_salvar_box.Click, btn_salvar.Click
        alterar_senha()
    End Sub

    Private Sub alterar_senha()
        Try
            If txt_senha.Text = "" Or txt_senha_confirmar.Text = "" Then
                MsgBox("Preencha todos os campos", MsgBoxStyle.Information, "Aviso")
                Exit Sub
            ElseIf txt_senha.Text <> txt_senha_confirmar.Text Then
                MsgBox("Senhas não são iguais", MsgBoxStyle.Exclamation, "Aviso")
                Exit Sub
            End If
            sql = "UPDATE tb_acesso SET senha='" & txt_senha.Text & "', primeiro_acesso='N' WHERE usuario='" & sessao_usuario & "'"
            rs = db.Execute(sql)
            Me.Close()
        Catch
            MsgBox("Algum erro ocorreu", MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub

    Private Sub btn_visiblidade_1_Click(sender As Object, e As EventArgs) Handles btn_visibilidade_1.Click
        If visibilidade_1 Then
            visibilidade_1 = False
            txt_senha.PasswordChar = "*"
            btn_visibilidade_1.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "img/icons/visibilidade-nao.png"))
        Else
            visibilidade_1 = True
            txt_senha.PasswordChar = ""
            btn_visibilidade_1.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "img/icons/visibilidade-sim.png"))
        End If
    End Sub


    Private Sub btn_visibilidade_2_Click(sender As Object, e As EventArgs) Handles btn_visibilidade_2.Click
        If visibilidade_2 Then
            visibilidade_2 = False
            txt_senha_confirmar.PasswordChar = "*"
            btn_visibilidade_2.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "img/icons/visibilidade-nao.png"))
        Else
            visibilidade_2 = True
            txt_senha_confirmar.PasswordChar = ""
            btn_visibilidade_2.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "img/icons/visibilidade-sim.png"))
        End If
    End Sub

    Private Sub inputs_keydowm(sender As Object, e As KeyEventArgs) Handles txt_senha.KeyDown, txt_senha_confirmar.KeyDown
        If e.KeyCode = Keys.Enter Then
            alterar_senha()
        End If
    End Sub
End Class