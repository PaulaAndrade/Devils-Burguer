Public Class ficha_funcionario
    Private diretorio_foto As String
    Private acesso As String
    Private cpf As String = ""
    Private edicaoApenas As Boolean = False

    Public Sub New(cpfFuncionario As String)
        cpf = cpfFuncionario
        InitializeComponent()
    End Sub

    Private Sub frm_funcionarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        If cpf <> "" Then
            edicaoApenas = True
            txt_cpf.Text = cpf
            txt_cpf.Enabled = False
            combo_cargo.Enabled = False
            btn_procurar_cpf.Visible = False
            btn_salvar_box.Visible = False
            btn_excluir_box.Visible = False
            btn_editar_box.Location = New Point(294, 446)
            preencherCampos()
        End If
    End Sub


    Private Sub salvarDados(sender As Object, e As EventArgs) Handles btn_salvar_box.Click, btn_salvar_lbl.Click
        Dim cargo = combo_cargo.SelectedItem
        Try
            If txt_cpf.TextLength < 12 Or txt_nome.Text = "" Or combo_cargo.SelectedItem = "" Or txt_email.Text = "" Then
                MsgBox("Preencha todos os campos obrigatórios marcados com (*)", MsgBoxStyle.Exclamation, "Aviso")
                Exit Sub
            End If
            sql = "SELECT * FROM tb_funcionarios WHERE cpf='" & txt_cpf.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                MsgBox("CPF já está cadastrado", MsgBoxStyle.Exclamation, "Aviso")
                Exit Sub
            End If
            sql = "INSERT INTO tb_funcionarios (cpf, nome, data_nascimento, cargo, email, diretorio_foto, cep, " & _
                "sexo, cidade, bairro, endereco, complemento, telefone, celular) VALUES" & _
                "('" & txt_cpf.Text & "', '" & txt_nome.Text & "', '" & txt_data.Value & "', '" & combo_cargo.SelectedItem & "', '" & _
                txt_email.Text & "', '" & diretorio_foto & "', '" & txt_cep.Text & "', '" & combo_sexo.SelectedItem & "', '" & txt_cidade.Text & "', '" & _
                txt_bairro.Text & "', '" & txt_endereco.Text & "', '" & txt_comp.Text & "', '" & txt_tel.Text & "', '" & txt_cel.Text & "')"
            rs = db.Execute(sql)
            MsgBox("Funcionário registrado com sucesso", MsgBoxStyle.Information, "Sucesso")
            If cargo = "Operador" Or cargo = "Cozinheiro" Or cargo = "Gerente" Then
                cpf = txt_cpf.Text
                Call salvarAcesso()
            End If
            Call limparCampos()
            form_gerente.atualizar()
        Catch
            MsgBox("Algum erro ocorreu", MsgBoxStyle.Exclamation, "Aviso")
        End Try
    End Sub

    Private Sub cliqueBotProcurar(sender As Object, e As EventArgs) Handles btn_procurar_cpf.Click
        preencherCampos()
    End Sub
    Private Sub preencherCampos()
        sql = "SELECT * FROM tb_funcionarios where cpf='" & txt_cpf.Text & "'"
        rs = db.Execute(sql)
        If rs.EOF Then
            MsgBox("CPF não cadastrado como funcionário", MsgBoxStyle.Information, "Aviso")
            Exit Sub
        End If
        If edicaoApenas = False Then
            btn_excluir_box.Visible = True
        End If
        btn_editar_box.Visible = True
        txt_nome.Text = rs.Fields("nome").Value
        txt_data.Value = rs.Fields("data_nascimento").Value
        combo_sexo.SelectedItem = rs.Fields("sexo").Value
        combo_cargo.SelectedItem = rs.Fields("cargo").Value
        txt_email.Text = rs.Fields("email").Value
        txt_cel.Text = rs.Fields("celular").Value
        txt_tel.Text = rs.Fields("telefone").Value
        txt_cep.Text = rs.Fields("cep").Value
        txt_cidade.Text = rs.Fields("cidade").Value
        txt_bairro.Text = rs.Fields("bairro").Value
        txt_endereco.Text = rs.Fields("endereco").Value
        txt_comp.Text = rs.Fields("complemento").Value
        diretorio_foto = rs.Fields("diretorio_foto").Value.ToString
        If diretorio_foto.Length > 0 Then
            img_funcionario.Load(diretorio_foto)
        End If
    End Sub

    Private Sub editarRegistro(sender As Object, e As EventArgs) Handles btn_editar_box.Click, btn_editar_lbl.Click
        Try
            If txt_cpf.Text = "" Or txt_nome.Text = "" Or combo_cargo.SelectedItem = "" Or txt_email.Text = "" Then
                MsgBox("Preencha todos os campos obrigatórios marcados com (*)", MsgBoxStyle.Exclamation, "Aviso")
                Exit Sub
            End If
            sql = "SELECT * FROM tb_funcionarios WHERE cpf='" & txt_cpf.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF Then
                MsgBox("Funcionário não cadastrado para edição", MsgBoxStyle.Exclamation, "Aviso")
                btn_excluir_box.Visible = False
                btn_editar_box.Visible = False
                Exit Sub
            End If
            sql = "UPDATE tb_funcionarios SET nome='" & txt_nome.Text & "', data_nascimento='" & txt_data.Value & _
                "', cargo='" & combo_cargo.SelectedItem & "', email='" & txt_email.Text & _
                "', diretorio_foto='" & diretorio_foto & "', cep='" & txt_cep.Text & "', sexo='" & combo_sexo.SelectedItem & _
                "', cidade='" & txt_cidade.Text & "', bairro='" & txt_bairro.Text & "', endereco='" & txt_endereco.Text & _
                "', complemento='" & txt_comp.Text & "', telefone='" & txt_tel.Text & "', celular='" & txt_cel.Text & _
                "' WHERE cpf='" & txt_cpf.Text & "'"
            rs = db.Execute(sql)
            MsgBox("Dados editados com sucesso", MsgBoxStyle.Information, "Sucesso")
        Catch
            MsgBox("Algum erro ocorreu", MsgBoxStyle.Critical, "Aviso")
        End Try
        form_gerente.atualizar()
    End Sub

    Private Sub excluirRegistro(sender As Object, e As EventArgs) Handles btn_excluir_box.Click, btn_excluir_lbl.Click
        Try
            Dim resp = MsgBox("Deseja realmente excluir este registro de funcionário?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Aviso")
            If resp = vbNo Then
                Exit Sub
            End If
            sql = "DELETE FROM tb_funcionarios where cpf='" & txt_cpf.Text & "'"
            rs = db.Execute(sql)
            'Call limparCampos()
            MsgBox("Dados de funcionário deletados com sucesso", MsgBoxStyle.Information, "Sucesso")
        Catch
            MsgBox("Algum erro ocorreu", MsgBoxStyle.Critical, "Aviso")
        End Try
    End Sub

    Private Sub cpfLostFocus(sender As Object, e As EventArgs) Handles txt_cpf.LostFocus
        If edicaoApenas Then
            Exit Sub
        End If
        sql = "SELECT * FROM tb_funcionarios where cpf='" & txt_cpf.Text & "'"
        rs = db.Execute(sql)
        If rs.EOF Then
            btn_excluir_box.Visible = False
            btn_editar_box.Visible = False
        End If
    End Sub

    Private Sub adicionarFoto(sender As Object, e As EventArgs) Handles img_funcionario.Click
        With img_dialog
            .Title = "Selecione uma foto"
            .InitialDirectory = Application.StartupPath & "\img\funcionarios"
            .ShowDialog()
            diretorio_foto = .FileName
            If diretorio_foto.Length > 0 Then
                img_funcionario.Load(diretorio_foto)
            End If
        End With
    End Sub

    Private Sub gerarNomeAcesso()
        Dim nome = txt_nome.Text.Trim().ToLower()
        If nome.Length > 13 Then
            nome = nome.Substring(0, 13) ' <------
        End If
        acesso = nome
        Dim cpfFormatado = cpf.Replace(".", "").Replace("-", "")
        cpfFormatado = cpfFormatado.Substring(10, 1) & cpfFormatado.Substring(0, 1)
        If nome.IndexOf(" ") <> -1 Then 'Se não testar, causa erro
            acesso = acesso.Substring(0, nome.IndexOf(" "))
        End If
        acesso = acesso & cpfFormatado
    End Sub

    Private Sub salvarAcesso()
        Call gerarNomeAcesso()
        sql = "select TOP 1 * from tb_funcionarios ORDER BY idfuncionario DESC"
        rs = db.Execute(sql)
        Dim idFuncionario As Integer = rs.Fields("idfuncionario").Value
        sql = "INSERT INTO tb_acesso (usuario, senha, cargo, idfuncionario) VALUES ('" & acesso & "', '000000', '" & _
            combo_cargo.SelectedItem & "', '" & idFuncionario & "')"
        rs = db.Execute(sql)
        MsgBox("Novo acesso criado" & vbNewLine & "Login:   " & acesso & vbNewLine & _
               "Senha:   000000", MsgBoxStyle.Information, "Aviso")
    End Sub

    Private Sub limparCampos()
        cpf = ""
        btn_excluir_box.Visible = False
        btn_editar_box.Visible = False
        txt_nome.Clear()
        txt_data.Value = Date.Now
        txt_cpf.Clear()
        combo_sexo.SelectedIndex = -1
        combo_cargo.SelectedIndex = -1
        'txt_email.Clear()
        txt_cel.Clear()
        txt_tel.Clear()
        txt_cep.Clear()
        txt_cidade.Clear()
        txt_bairro.Clear()
        txt_endereco.Clear()
        txt_comp.Clear()
        img_funcionario.Image = Nothing
    End Sub
End Class
