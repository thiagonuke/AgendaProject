﻿Imports System.Security.Cryptography
Imports System.Text
Public Class Cryptography

    Public Shared Function GerarHashSenha(senha As String) As String

        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(senha))

            Dim sb As New StringBuilder()
            For Each b As Byte In bytes
                sb.Append(b.ToString("x2"))
            Next

            Return sb.ToString()
        End Using
    End Function


End Class
