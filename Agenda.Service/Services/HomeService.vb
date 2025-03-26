Imports Agenda.Data
Imports Agenda.Domain

Public Class HomeService

    Private ReadOnly _HomeRepository As New HomeRepository

    Public Function GetCompromissos() As List(Of Compromisso)
        Try

            Return _HomeRepository.GetCompromissos()

        Catch ex As Exception
            Return New List(Of Compromisso)
        End Try

    End Function
    Public Function CadastrarCompromisso(dados As Compromisso) As Boolean
        Try

            Return _HomeRepository.CadastrarCompromisso(dados)

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function UpdateCompromisso(dados As Compromisso) As Boolean
        Try

            Return _HomeRepository.UpdateCompromisso(dados)

        Catch ex As Exception
            Return False
        End Try

    End Function
    Public Function ExcluirCompromisso(id As String) As Boolean
        Try

            Return _HomeRepository.ExcluirCompromisso(id)

        Catch ex As Exception
            Return False
        End Try

    End Function

End Class
