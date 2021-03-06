USE [master]
GO
/****** Object:  Database [ИС1811_СистемаТестирования]    Script Date: 23.10.2020 13:35:42 ******/
CREATE DATABASE [ИС1811_СистемаТестирования]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ИС1811_СистемаТестирования', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\ИС1811_СистемаТестирования.mdf' , SIZE = 7168KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ИС1811_СистемаТестирования_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\ИС1811_СистемаТестирования_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ИС1811_СистемаТестирования] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ИС1811_СистемаТестирования].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ИС1811_СистемаТестирования] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ИС1811_СистемаТестирования] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ИС1811_СистемаТестирования] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ИС1811_СистемаТестирования] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ИС1811_СистемаТестирования] SET ARITHABORT OFF 
GO
ALTER DATABASE [ИС1811_СистемаТестирования] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ИС1811_СистемаТестирования] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ИС1811_СистемаТестирования] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ИС1811_СистемаТестирования] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ИС1811_СистемаТестирования] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ИС1811_СистемаТестирования] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ИС1811_СистемаТестирования] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ИС1811_СистемаТестирования] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ИС1811_СистемаТестирования] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ИС1811_СистемаТестирования] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ИС1811_СистемаТестирования] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ИС1811_СистемаТестирования] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ИС1811_СистемаТестирования] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ИС1811_СистемаТестирования] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ИС1811_СистемаТестирования] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ИС1811_СистемаТестирования] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ИС1811_СистемаТестирования] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ИС1811_СистемаТестирования] SET RECOVERY FULL 
GO
ALTER DATABASE [ИС1811_СистемаТестирования] SET  MULTI_USER 
GO
ALTER DATABASE [ИС1811_СистемаТестирования] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ИС1811_СистемаТестирования] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ИС1811_СистемаТестирования] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ИС1811_СистемаТестирования] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [ИС1811_СистемаТестирования] SET DELAYED_DURABILITY = DISABLED 
GO
USE [ИС1811_СистемаТестирования]
GO
/****** Object:  Table [dbo].[log]    Script Date: 23.10.2020 13:35:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[log](
	[ID] [int] NOT NULL,
	[Login] [varchar](25) NOT NULL,
	[TestID] [int] NOT NULL,
	[Result] [nvarchar](100) NOT NULL,
	[Score] [int] NOT NULL,
	[Time] [int] NOT NULL,
	[Date] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[question]    Script Date: 23.10.2020 13:35:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[question](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TestID] [int] NOT NULL,
	[Number] [int] NOT NULL,
	[QuestionText] [nvarchar](max) NOT NULL,
	[Var1] [nvarchar](max) NOT NULL,
	[Var2] [nvarchar](max) NOT NULL,
	[Var3] [nvarchar](max) NOT NULL,
	[Answer] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[test]    Script Date: 23.10.2020 13:35:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[test](
	[ID] [int] NOT NULL,
	[TopicID] [int] NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[topics]    Script Date: 23.10.2020 13:35:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[topics](
	[ID] [int] NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[user]    Script Date: 23.10.2020 13:35:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[user](
	[Login] [varchar](25) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[LName] [nvarchar](100) NOT NULL,
	[FName] [nvarchar](100) NOT NULL,
	[FaName] [nvarchar](100) NULL,
 CONSTRAINT [PK__user__5E55825ADFAE3014] PRIMARY KEY CLUSTERED 
(
	[Login] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[log]  WITH CHECK ADD  CONSTRAINT [FK_log_test] FOREIGN KEY([TestID])
REFERENCES [dbo].[test] ([ID])
GO
ALTER TABLE [dbo].[log] CHECK CONSTRAINT [FK_log_test]
GO
ALTER TABLE [dbo].[log]  WITH CHECK ADD  CONSTRAINT [FK_log_user] FOREIGN KEY([Login])
REFERENCES [dbo].[user] ([Login])
GO
ALTER TABLE [dbo].[log] CHECK CONSTRAINT [FK_log_user]
GO
ALTER TABLE [dbo].[question]  WITH CHECK ADD  CONSTRAINT [FK_question_test] FOREIGN KEY([TestID])
REFERENCES [dbo].[test] ([ID])
GO
ALTER TABLE [dbo].[question] CHECK CONSTRAINT [FK_question_test]
GO
ALTER TABLE [dbo].[test]  WITH CHECK ADD  CONSTRAINT [FK_test_topics] FOREIGN KEY([TopicID])
REFERENCES [dbo].[topics] ([ID])
GO
ALTER TABLE [dbo].[test] CHECK CONSTRAINT [FK_test_topics]
GO
USE [master]
GO
ALTER DATABASE [ИС1811_СистемаТестирования] SET  READ_WRITE 
GO
