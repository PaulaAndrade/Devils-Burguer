Module funcoes_gerais
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public sql, resp As String
    'Variaveis importantes
    Public sessao_usuario As String = "usuario"
    Public sessao_nome As String = "[Nome logado]"
    Public sessao_foto As String = Application.StartupPath & "\img\funcionarios\img-3.jpg"
    Public sessao_cargo As String = "Gerente"

    Public sessao_id As Integer
    Public acesso_permitido As Boolean = False
    Public form_aberto As Form

    Sub conectar_banco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=SQLOLEDB;Data Source=LAPTOP-7FOB5UFC;Initial Catalog=devils_burger;trusted_connection=yes;")
        Catch ex As Exception
            MsgBox("Erro ao conectar ao banco", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub
End Module
