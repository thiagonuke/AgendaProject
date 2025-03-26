Imports Agenda.Domain
Imports Agenda.Service

Public Class Home

    Private ReadOnly _HomeAppService As New HomeService

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label1.Text = $"Olá! Bem vindo {Usuario.Nome}"

        'AddHandler DataGridView1.CellContentClick, AddressOf DataGridView1_CellContentClick

        ListarGrid()

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        CadastrarCompromisso.Id = 0
        CadastrarCompromisso.Titulo = ""
        CadastrarCompromisso.Descricao = ""
        CadastrarCompromisso.DataInicio = DateTime.Now
        CadastrarCompromisso.DataFim = DateTime.Now
        CadastrarCompromisso.Localizacao = ""


        CadastrarCompromisso.Activate()
        CadastrarCompromisso.ShowDialog()

        ListarGrid()

    End Sub


    Private Sub logoutbtn_Click(sender As Object, e As EventArgs) Handles logoutbtn.Click
        Me.Hide()

        Dim logon As New Logon

        logon.Activate()
        logon.Show()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            If DataGridView1.Columns(e.ColumnIndex).Name = "btnEdit" Then

                Dim cadastrar As New CadastrarCompromisso

                cadastrar.Id = Convert.ToInt32(row.Cells("Id").Value)
                cadastrar.Titulo = row.Cells("Titulo").Value.ToString()
                cadastrar.Descricao = row.Cells("Descricao").Value.ToString()
                cadastrar.DataInicio = Convert.ToDateTime(row.Cells("DataInicio").Value)
                cadastrar.DataFim = Convert.ToDateTime(row.Cells("DataFim").Value)
                cadastrar.Localizacao = row.Cells("Localizacao").Value.ToString()

                cadastrar.Activate()
                cadastrar.ShowDialog()

                ListarGrid()

            ElseIf DataGridView1.Columns(e.ColumnIndex).Name = "btnDelete" Then
                Dim result As DialogResult = MessageBox.Show("Tem certeza que deseja excluir?", "Excluir", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then


                    If _HomeAppService.ExcluirCompromisso(row.Cells("Id").Value) Then

                        MessageBox.Show("Excluido com sucesso!", "Sucesso!")

                        ListarGrid()

                    End If
                End If
            End If
        End If
    End Sub


    Private Sub ListarGrid()

        DataGridView1.DataSource = _HomeAppService.GetCompromissos()

        If DataGridView1.Columns("btnEdit") Is Nothing Then
            Dim btnEdit As New DataGridViewButtonColumn()
            btnEdit.HeaderText = "Editar"
            btnEdit.Text = "Editar"
            btnEdit.Name = "btnEdit"
            btnEdit.UseColumnTextForButtonValue = True
            DataGridView1.Columns.Add(btnEdit)
        End If

        If DataGridView1.Columns("btnDelete") Is Nothing Then
            Dim btnDelete As New DataGridViewButtonColumn()
            btnDelete.HeaderText = "Excluir"
            btnDelete.Text = "Excluir"
            btnDelete.Name = "btnDelete"
            btnDelete.UseColumnTextForButtonValue = True
            DataGridView1.Columns.Add(btnDelete)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListarGrid()
    End Sub
End Class