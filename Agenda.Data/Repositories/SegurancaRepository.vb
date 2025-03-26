Imports System.Data.SqlClient
Imports Agenda.Domain
Imports Dapper

Public Class SegurancaRepository

    Private ReadOnly connectionString As String = ConApp.GetConnectionString()


    Public Function Logon(user As String, senha As String) As Boolean

        Dim retorno As Boolean = False

        Using conn As New SqlConnection(connectionString)

            conn.Open()

            Dim sql As String = $"SELECT * FROM Usuarios WHERE Usuario = '{user}' and Senha = '{senha}'"

            Dim dados As RetornoUsuario = conn.QuerySingleOrDefault(Of RetornoUsuario)(sql)

            If dados IsNot Nothing Then

                Dim usuario As New Usuario()

                Usuario.Usuario = dados.Usuario
                Usuario.Nome = dados.Nome
                Usuario.Senha = dados.Senha
                Usuario.Logado = dados.Logado
                Usuario.Id = dados.Id

                retorno = True

            End If

        End Using

        Return retorno

    End Function

    Public Function Cadastrar(Nome As String, user As String, senha As String) As Boolean

        Dim retorno As Boolean = False

        Using conn As New SqlConnection(connectionString)

            conn.Open()

            Dim sql As String = $"INSERT INTO [dbo].[Usuarios] ([Nome],[Usuario],[Senha]) VALUES ('{Nome}', '{user}', '{senha}')"

            conn.Execute(sql)

            retorno = True

        End Using

        Return retorno


    End Function


    Public Class RetornoUsuario
        Public Property Id As Integer
        Public Property Nome As String
        Public Property Usuario As String
        Public Property Senha As String
        Public Property Logado As Boolean? 
    End Class
End Class
