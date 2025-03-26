Imports Agenda.Data
Imports Agenda.Domain

Public Class SegurancaService

    Private ReadOnly _SegurancaRepository As New SegurancaRepository

    Public Function Logon(user As String, senha As String) As Boolean
        Try
            Return _SegurancaRepository.Logon(user, Cryptography.GerarHashSenha(senha))

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function CadastrarUser(nome As String, user As String, senha As String) As Boolean

        Try

            Return _SegurancaRepository.Cadastrar(nome, user, Cryptography.GerarHashSenha(senha))

        Catch ex As Exception
            Return False
        End Try

    End Function
End Class
