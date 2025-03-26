Imports System.IO

Public Class ConApp

    Public Shared Function GetConnectionString() As String

        'Dim configPath As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config", "dbconfig.txt")

        'If File.Exists(configPath) Then
        '    Return File.ReadAllText(configPath).Trim()
        'Else
        '    Throw New FileNotFoundException("Arquivo de configuração não encontrado: " & configPath)
        'End If

        Return "Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;"

    End Function


End Class
