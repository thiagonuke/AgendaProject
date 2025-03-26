Imports Agenda.Domain
Imports Agenda.Service

Public Class CadastrarCompromisso

    Private ReadOnly _homeService As New HomeService
    Public Id As Integer = Nothing
    Public Titulo As String
    Public Descricao As String
    Public DataInicio As DateTime
    Public DataFim As DateTime
    Public Localizacao As String
    Public CriadoEm As DateTime
    Public IdUsuario As Integer

    Private Sub Cadastrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        titTxt.Text = Titulo
        desctxt.Text = Descricao
        dtInitxt.Text = DataInicio
        dtfinaltxt.Text = DataFim
        localtxt.Text = Localizacao


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        SalvarCompromisso()

    End Sub


    Private Sub SalvarCompromisso()

        Dim retorno As Boolean = False

        If String.IsNullOrEmpty(titTxt.Text) Or String.IsNullOrEmpty(desctxt.Text) Or String.IsNullOrEmpty(dtInitxt.Text) Or String.IsNullOrEmpty(dtfinaltxt.Text) Or String.IsNullOrEmpty(localtxt.Text) Then

            MessageBox.Show("Preencha todos os dados para prosseguir", "Atenção")


            Exit Sub
        End If

        Dim dados As New Compromisso With {
            .Id = IIf(Id <> 0, Id, Nothing),
            .Titulo = titTxt.Text,
            .Descricao = desctxt.Text,
            .DataInicio = dtInitxt.Text,
            .DataFim = dtfinaltxt.Text,
            .Localizacao = localtxt.Text,
            .IdUsuario = Usuario.Id}


        If Titulo <> "" Then

            retorno = _homeService.UpdateCompromisso(dados)

        Else

            retorno = _homeService.CadastrarCompromisso(dados)


        End If

        If retorno Then

            MessageBox.Show("Salvo com sucesso!", "Sucesso")

            Me.Close()

        Else

            MessageBox.Show("Erro ao cadastrar!", "Erro")


        End If


    End Sub




End Class