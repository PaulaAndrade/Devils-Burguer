Public Class form_clientes
    Private Sub inicio(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
    End Sub

    Private Sub cliqueLimpar(sender As Object, e As EventArgs) Handles btn_limpar.Click
        limpar()
    End Sub

    Private Sub cliqueBuscarCPF(sender As Object, e As EventArgs) Handles btn_procurar.Click
        form_pesquisa.TopMost = True
        form_pesquisa.ShowDialog()
    End Sub

    Private Sub cliqueGravar(sender As Object, e As EventArgs) Handles btn_gravar.Click, btn_gravar_lbl.Click
        Try
            sql = "SELECT * FROM tb_clientes WHERE cpf='" & txt_cpf.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF Then
                salvarDados()
            Else
                editarDados()
            End If
            limpar()
        Catch ex As Exception
            MsgBox("Algum erro ocorreu", MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub

    Private Sub salvarDados()
        sql = "INSERT INTO tb_clientes VALUES ('" & txt_cpf.Text & "','" & txt_nome.Text & "', '" & txt_data_nascimento.Text & "','" & txt_celular.Text & "', '" & txt_telefone.Text & "'," & _
                                                     "'" & txt_email.Text & "','" & txt_cep.Text & "', '" & txt_bairro.Text & "', '" & txt_cidade.Text & "', '" & txt_endereco.Text & "', '" & txt_complemento.Text & "')"
        rs = db.Execute(sql)
        MsgBox("Cliente cadastrado com sucesso!!", MsgBoxStyle.Information, "Sucesso")
    End Sub

    Private Sub editarDados()
        Dim cpf = txt_cpf.Text
        sql = "UPDATE tb_clientes SET nome='" & txt_nome.Text & "', data_nascimento='" & txt_data_nascimento.Text & "', celular='" & txt_celular.Text & _
            "', telefone='" & txt_telefone.Text & "', email='" & txt_email.Text & "', cep='" & txt_cep.Text & "', bairro='" & txt_bairro.Text & "', cidade='" & txt_cidade.Text & _
            "', endereco='" & txt_endereco.Text & "', complemento='" & txt_complemento.Text & "' WHERE cpf='" & cpf & "'"
        rs = db.Execute(sql)
        MsgBox("Dados do cliente editados com sucesso!!", MsgBoxStyle.Information, "Sucesso")
    End Sub

    Public Sub preencherCampos()
        Try
            txt_cpf.Text = rs.Fields("cpf").Value.ToString
            txt_nome.Text = rs.Fields("nome").Value.ToString
            If rs.Fields("data_nascimento").Value.ToString <> "" Then
                txt_data_nascimento.Value = rs.Fields("data_nascimento").Value.ToString
            End If
            txt_celular.Text = rs.Fields("celular").Value.ToString
            txt_telefone.Text = rs.Fields("telefone").Value.ToString
            txt_email.Text = rs.Fields("email").Value.ToString
            txt_cep.Text = rs.Fields("cep").Value.ToString
            txt_bairro.Text = rs.Fields("bairro").Value.ToString
            txt_cidade.Text = rs.Fields("cidade").Value.ToString
            txt_endereco.Text = rs.Fields("endereco").Value.ToString
            txt_complemento.Text = rs.Fields("complemento").Value.ToString
            txt_cpf.Enabled = False
        Catch
            MsgBox("Erro ao preencher campos", MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub

    Private Sub excluirDados(sender As Object, e As EventArgs) Handles btn_excluir.Click, btn_excluir_lbl.Click
        Try
            resp = MsgBox("Deseja excluir cadastro ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Aviso")
            If resp = MsgBoxResult.Yes Then
                sql = "DELETE * FROM tb_clientes WHERE cpf='" & txt_cpf.Text & "'"
                rs = db.Execute(sql)
                MsgBox("Cadastro excluido com sucesso!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Aviso")
            End If
        Catch
            MsgBox("Algum erro ocorreu", MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub

    Sub limpar()
        txt_cpf.Enabled = True
        txt_cpf.Clear()
        txt_bairro.Clear()
        txt_celular.Clear()
        txt_cep.Clear()
        txt_cidade.Clear()
        txt_complemento.Clear()
        txt_email.Clear()
        txt_endereco.Clear()
        txt_nome.Clear()
        txt_telefone.Clear()
        txt_cpf.Focus()
        btn_excluir.Visible = False
    End Sub
End Class