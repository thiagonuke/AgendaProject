
Imports Agenda.Domain
Imports Agenda.Service

Public Class Logon

    Private ReadOnly _SegAppService As New SegurancaService

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If String.IsNullOrEmpty(UserTxt.Text) Or String.IsNullOrEmpty(SenhaTxt.Text) Then

            MessageBox.Show("Preencha os dados para prosseguir", "Atenção")

            Exit Sub
        End If


        If _SegAppService.Logon(UserTxt.Text, SenhaTxt.Text) Then

            Me.Hide()

            Dim formPrincipal As New Home

            formPrincipal.Activate()
            formPrincipal.Show()

        Else

            MessageBox.Show("Usuario ou senha invalidos.", "Atenção!")

        End If

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

        Cadastrar.Activate()
        Cadastrar.ShowDialog()

    End Sub


End Class
