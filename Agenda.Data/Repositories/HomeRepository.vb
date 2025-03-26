Imports Agenda.Data.SegurancaRepository
Imports Agenda.Domain
Imports Dapper
Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Data.SqlClient

Public Class HomeRepository

    Private ReadOnly connectionString As String = ConApp.GetConnectionString()

    Public Function GetCompromissos()

        Dim retorno As New List(Of Compromisso)

        Using conn As New SqlConnection(connectionString)

            conn.Open()

            Dim sql As String = $"SELECT * FROM Compromissos where IdUsuario = {Usuario.Id}"

            Dim dados As List(Of Compromisso) = conn.Query(Of Compromisso)(sql).ToList()

            If dados IsNot Nothing Then

                retorno = dados

            End If

        End Using

        Return retorno

    End Function

    Public Function CadastrarCompromisso(dados As Compromisso)

        Dim retorno As Boolean = False

        Using conn As New SqlConnection(connectionString)

            conn.Open()

            Dim sql As String = $"INSERT INTO [dbo].[Compromissos] ([Titulo],[Descricao],[DataInicio],[DataFim],[Localizacao],[CriadoEm],[IdUsuario]) VALUES('{dados.Titulo}','{dados.Descricao}','{dados.DataInicio}','{dados.DataFim}','{dados.Localizacao}','{DateTime.Now}', {dados.IdUsuario})"

            conn.Execute(sql)

            retorno = True

        End Using

        Return retorno

    End Function
    Public Function UpdateCompromisso(dados As Compromisso)

        Dim retorno As Boolean = False

        Using conn As New SqlConnection(connectionString)

            conn.Open()

            Dim sql As String = $"UPDATE [dbo].[Compromissos]
                                SET 
                                    [Titulo] = '{dados.Titulo}',
                                    [Descricao] = '{dados.Descricao}',
                                    [DataInicio] = '{dados.DataInicio}',
                                    [DataFim] = '{dados.DataFim}',
                                    [Localizacao] = '{dados.Localizacao}'
                                WHERE
                                    [Id] = {dados.Id} AND
                                    [IdUsuario] = {dados.IdUsuario}"

            conn.Execute(sql)

            retorno = True

        End Using

        Return retorno

    End Function


    Public Function ExcluirCompromisso(id As String)

        Dim retorno As Boolean = False

        Using conn As New SqlConnection(connectionString)

            conn.Open()

            Dim sql As String = $"Delete from Compromissos where id = '{id}' and IdUsuario = {Usuario.Id}"

            conn.Execute(sql)

            retorno = True

        End Using

        Return retorno

    End Function

End Class
