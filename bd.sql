USE [master]
GO
/****** Object:  Database [AuthorizationDB]    Script Date: 03.06.2021 14:22:32 ******/
CREATE DATABASE [AuthorizationDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AuthorizationDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\AuthorizationDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AuthorizationDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\AuthorizationDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [AuthorizationDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AuthorizationDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AuthorizationDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AuthorizationDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AuthorizationDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AuthorizationDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AuthorizationDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [AuthorizationDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AuthorizationDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AuthorizationDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AuthorizationDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AuthorizationDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AuthorizationDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AuthorizationDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AuthorizationDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AuthorizationDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AuthorizationDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [AuthorizationDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AuthorizationDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AuthorizationDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AuthorizationDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AuthorizationDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AuthorizationDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AuthorizationDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AuthorizationDB] SET RECOVERY FULL 
GO
ALTER DATABASE [AuthorizationDB] SET  MULTI_USER 
GO
ALTER DATABASE [AuthorizationDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AuthorizationDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AuthorizationDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AuthorizationDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [AuthorizationDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [AuthorizationDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'AuthorizationDB', N'ON'
GO
ALTER DATABASE [AuthorizationDB] SET QUERY_STORE = OFF
GO
USE [AuthorizationDB]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 03.06.2021 14:22:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[ID] [int] IDENTITY(0,1) NOT NULL,
	[Name] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 03.06.2021 14:22:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Name] [nvarchar](50) NOT NULL,
	[Patronymic] [nvarchar](50) NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[Login] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Role ID] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Volunteer]    Script Date: 03.06.2021 14:22:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Volunteer](
	[VolunteerID] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Patronymic] [nvarchar](50) NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[CountryCode] [nvarchar](3) NULL,
	[Gender] [nvarchar](10) NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([ID], [Name]) VALUES (0, N'Администратор')
INSERT [dbo].[Role] ([ID], [Name]) VALUES (1, N'Пользователь')
SET IDENTITY_INSERT [dbo].[Role] OFF
GO
INSERT [dbo].[Users] ([Name], [Patronymic], [Surname], [Login], [Password], [Role ID]) VALUES (N'Иннокентий', N'Игоревич', N'Степанов', N'admin', N'admin', 0)
INSERT [dbo].[Users] ([Name], [Patronymic], [Surname], [Login], [Password], [Role ID]) VALUES (N'Кира', N'Куприяновна', N'Александрова', N'user', N'user', 1)
INSERT [dbo].[Users] ([Name], [Patronymic], [Surname], [Login], [Password], [Role ID]) VALUES (N'asd', N'asd', N'asd', N'testmail@gmail.com', N'Passw0rd', 1)
GO
USE [master]
GO
ALTER DATABASE [AuthorizationDB] SET  READ_WRITE 
GO
