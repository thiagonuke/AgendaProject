Imports Agenda.Domain
Imports Agenda.Service

Public Class Cadastrar

    Private ReadOnly _SegAppService As New SegurancaService

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If String.IsNullOrEmpty(UserTxt.Text) Or String.IsNullOrEmpty(SenhaTxt.Text) Or String.IsNullOrEmpty(NomeTxt.Text) Then

            MessageBox.Show("Preencha os dados para prosseguir", "Atenção")

            Exit Sub
        End If

        If _SegAppService.CadastrarUser(NomeTxt.Text, UserTxt.Text, SenhaTxt.Text) Then

            MessageBox.Show("Cadastrado com sucesso.", "Sucesso!")

            Me.Close()

        Else

            MessageBox.Show("Erro ao cadastrar usuario.", "Erro!")

        End If

    End Sub

End Class