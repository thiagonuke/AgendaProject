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


USE [master]
GO

/****** Object:  Database [AgendaDB]    Script Date: 26/03/2025 18:30:27 ******/
CREATE DATABASE [AgendaDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AgendaDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\AgendaDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AgendaDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\AgendaDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AgendaDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [AgendaDB] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [AgendaDB] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [AgendaDB] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [AgendaDB] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [AgendaDB] SET ARITHABORT OFF 
GO

ALTER DATABASE [AgendaDB] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [AgendaDB] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [AgendaDB] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [AgendaDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [AgendaDB] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [AgendaDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [AgendaDB] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [AgendaDB] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [AgendaDB] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [AgendaDB] SET  DISABLE_BROKER 
GO

ALTER DATABASE [AgendaDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [AgendaDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [AgendaDB] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [AgendaDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [AgendaDB] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [AgendaDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [AgendaDB] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [AgendaDB] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [AgendaDB] SET  MULTI_USER 
GO

ALTER DATABASE [AgendaDB] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [AgendaDB] SET DB_CHAINING OFF 
GO

ALTER DATABASE [AgendaDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [AgendaDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [AgendaDB] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [AgendaDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [AgendaDB] SET QUERY_STORE = OFF
GO

ALTER DATABASE [AgendaDB] SET  READ_WRITE 
GO


