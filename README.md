# AgendaProject

## Descrição

Este é um sistema de gerenciamento de compromissos desenvolvido com VB.NET Windows Forms. O projeto permite que os usuários se autentiquem, visualizem, criem, editem e excluam compromissos, além de realizar o logout e retornar à tela de login. A aplicação usa o SQL Server como banco de dados para armazenar as informações de compromissos.

## Fluxo de Uso

1. **Usuário faz login**: O usuário insere suas credenciais na tela de login. Se autenticado com sucesso, o usuário é redirecionado para o sistema.
2. **Visualização dos compromissos**: Após o login, o sistema exibe os compromissos do usuário logado na interface.
3. **Operações CRUD**: O usuário pode criar, editar ou excluir compromissos. Essas operações são realizadas diretamente na interface.
4. **Logout**: O usuário pode realizar o logout, retornando para a tela de login.

## Tecnologias Utilizadas

- **VB.NET Windows Forms**: Usado para a criação da interface gráfica da aplicação.
- **SQL Server**: Utilizado para o armazenamento de dados relacionados aos compromissos e informações do usuário.

## Configuração

### Banco de Dados

Dentro da classe `conApp`, defina a connection string no retorno da função `GetConnectionString`. A connection string deve apontar para o banco de dados do SQL Server que contém as tabelas de usuários e compromissos.

```vb
Public Function GetConnectionString() As String
    Return "Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;"
End Function
