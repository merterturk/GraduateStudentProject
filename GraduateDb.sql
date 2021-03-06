USE [master]
GO
/****** Object:  Database [GraduateStudentDb]    Script Date: 14.03.2021 10:04:46 ******/
CREATE DATABASE [GraduateStudentDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GraduateStudentDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\GraduateStudentDb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'GraduateStudentDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\GraduateStudentDb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [GraduateStudentDb] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GraduateStudentDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GraduateStudentDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GraduateStudentDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GraduateStudentDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GraduateStudentDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GraduateStudentDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [GraduateStudentDb] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [GraduateStudentDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GraduateStudentDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GraduateStudentDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GraduateStudentDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GraduateStudentDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GraduateStudentDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GraduateStudentDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GraduateStudentDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GraduateStudentDb] SET  ENABLE_BROKER 
GO
ALTER DATABASE [GraduateStudentDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GraduateStudentDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GraduateStudentDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GraduateStudentDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GraduateStudentDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GraduateStudentDb] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [GraduateStudentDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GraduateStudentDb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [GraduateStudentDb] SET  MULTI_USER 
GO
ALTER DATABASE [GraduateStudentDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GraduateStudentDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GraduateStudentDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GraduateStudentDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [GraduateStudentDb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [GraduateStudentDb] SET QUERY_STORE = OFF
GO
USE [GraduateStudentDb]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 14.03.2021 10:04:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Announcements]    Script Date: 14.03.2021 10:04:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Announcements](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](max) NULL,
	[Content] [nvarchar](max) NULL,
 CONSTRAINT [PK_Announcements] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Departments]    Script Date: 14.03.2021 10:04:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[DepartmentYear] [int] NOT NULL,
 CONSTRAINT [PK_Departments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 14.03.2021 10:04:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](100) NOT NULL,
	[BirthdayDate] [datetime2](7) NOT NULL,
	[TelephoneNumber] [nvarchar](50) NULL,
	[Email] [nvarchar](75) NULL,
	[IsGraduate] [bit] NOT NULL,
	[GraduateYear] [int] NULL,
	[Password] [nvarchar](20) NULL,
	[RegistrationDate] [datetime2](7) NULL,
	[DepartmentId] [int] NOT NULL,
	[SchoolNumber] [nvarchar](20) NOT NULL,
	[TC] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210220005748_Init', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210220010659_UpdatedTables', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210220021014_TCAndSchoolNumberColumnsAdded', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210306150706_Announcement-Added', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210307132458_DeletedColumnCreatedDate', N'2.1.14-servicing-32113')
SET IDENTITY_INSERT [dbo].[Announcements] ON 

INSERT [dbo].[Announcements] ([Id], [Title], [Content]) VALUES (4, N'Mezun Öğrencilerin Dikkatine', N'LoreM Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.')
INSERT [dbo].[Announcements] ([Id], [Title], [Content]) VALUES (6, N'Mezun Öğrencilerimize Özel Duyuru', N'Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.')
SET IDENTITY_INSERT [dbo].[Announcements] OFF
SET IDENTITY_INSERT [dbo].[Departments] ON 

INSERT [dbo].[Departments] ([Id], [Name], [DepartmentYear]) VALUES (1, N'Bilgisayar Mühendisliği', 4)
INSERT [dbo].[Departments] ([Id], [Name], [DepartmentYear]) VALUES (2, N'Çevre Mühendisliği', 4)
INSERT [dbo].[Departments] ([Id], [Name], [DepartmentYear]) VALUES (4, N'Biyomedikal Mühendisliği', 4)
INSERT [dbo].[Departments] ([Id], [Name], [DepartmentYear]) VALUES (5, N'Elektrik Elektronik Mühendisliği', 4)
INSERT [dbo].[Departments] ([Id], [Name], [DepartmentYear]) VALUES (6, N'Makine Mühendisliği', 4)
INSERT [dbo].[Departments] ([Id], [Name], [DepartmentYear]) VALUES (7, N'Gıda Teknolojisi', 2)
INSERT [dbo].[Departments] ([Id], [Name], [DepartmentYear]) VALUES (8, N'Fizyoterapi', 2)
INSERT [dbo].[Departments] ([Id], [Name], [DepartmentYear]) VALUES (9, N'Elektronik Teknolojisi', 2)
INSERT [dbo].[Departments] ([Id], [Name], [DepartmentYear]) VALUES (10, N'Dış Ticaret', 2)
INSERT [dbo].[Departments] ([Id], [Name], [DepartmentYear]) VALUES (11, N'Bilgisayar Programcılığı', 2)
SET IDENTITY_INSERT [dbo].[Departments] OFF
SET IDENTITY_INSERT [dbo].[Students] ON 

INSERT [dbo].[Students] ([Id], [FullName], [BirthdayDate], [TelephoneNumber], [Email], [IsGraduate], [GraduateYear], [Password], [RegistrationDate], [DepartmentId], [SchoolNumber], [TC]) VALUES (1, N'Mert Furkan Ertürk', CAST(N'1997-11-07T00:00:00.0000000' AS DateTime2), N'342342342', N'meerterturk@gmail.com', 1, 2021, N'12345679', CAST(N'2021-02-20T00:00:00.0000000' AS DateTime2), 1, N'1170606016', N'13432342432')
INSERT [dbo].[Students] ([Id], [FullName], [BirthdayDate], [TelephoneNumber], [Email], [IsGraduate], [GraduateYear], [Password], [RegistrationDate], [DepartmentId], [SchoolNumber], [TC]) VALUES (2, N'Uğur Tuna', CAST(N'1995-12-05T00:00:00.0000000' AS DateTime2), N'423424234', N'ugurtuna@gmail.com', 0, NULL, NULL, NULL, 2, N'1150607016', N'1231231311')
INSERT [dbo].[Students] ([Id], [FullName], [BirthdayDate], [TelephoneNumber], [Email], [IsGraduate], [GraduateYear], [Password], [RegistrationDate], [DepartmentId], [SchoolNumber], [TC]) VALUES (3, N'Yusuf Hancı', CAST(N'1996-11-06T00:00:00.0000000' AS DateTime2), N'132131231', N'yusufhanci@gmail.com', 1, 2020, N'Yusuf123', CAST(N'2021-02-22T00:00:00.0000000' AS DateTime2), 8, N'1141231022', N'3124134324')
INSERT [dbo].[Students] ([Id], [FullName], [BirthdayDate], [TelephoneNumber], [Email], [IsGraduate], [GraduateYear], [Password], [RegistrationDate], [DepartmentId], [SchoolNumber], [TC]) VALUES (4, N'Betül Kovalı', CAST(N'1997-10-23T00:00:00.0000000' AS DateTime2), N'435345353', N'betulkovali@gmail.com', 1, 2019, N'Betul123', CAST(N'2021-02-22T00:00:00.0000000' AS DateTime2), 7, N'1132313212', N'3214234245')
INSERT [dbo].[Students] ([Id], [FullName], [BirthdayDate], [TelephoneNumber], [Email], [IsGraduate], [GraduateYear], [Password], [RegistrationDate], [DepartmentId], [SchoolNumber], [TC]) VALUES (6, N'Berke Duyar', CAST(N'1993-10-11T00:00:00.0000000' AS DateTime2), N'312313213', N'berkeduyar@gmail.com', 1, 2021, N'1234', CAST(N'2021-03-01T22:24:21.6752486' AS DateTime2), 7, N'1149873443', N'1243324223')
INSERT [dbo].[Students] ([Id], [FullName], [BirthdayDate], [TelephoneNumber], [Email], [IsGraduate], [GraduateYear], [Password], [RegistrationDate], [DepartmentId], [SchoolNumber], [TC]) VALUES (8, N'Yunus Tan', CAST(N'1997-10-20T00:00:00.0000000' AS DateTime2), N'321313131', N'yunustan@gmail.com', 1, NULL, NULL, NULL, 6, N'1132001030', N'3213123134')
INSERT [dbo].[Students] ([Id], [FullName], [BirthdayDate], [TelephoneNumber], [Email], [IsGraduate], [GraduateYear], [Password], [RegistrationDate], [DepartmentId], [SchoolNumber], [TC]) VALUES (9, N'Enes Saraçoğlu', CAST(N'1992-11-11T00:00:00.0000000' AS DateTime2), N'321312313', N'enessaracoglu@gmail.com', 0, NULL, NULL, NULL, 5, N'1151152322', N'3123143422')
INSERT [dbo].[Students] ([Id], [FullName], [BirthdayDate], [TelephoneNumber], [Email], [IsGraduate], [GraduateYear], [Password], [RegistrationDate], [DepartmentId], [SchoolNumber], [TC]) VALUES (10, N'Cihan Şener', CAST(N'1995-05-20T00:00:00.0000000' AS DateTime2), N'535345354', N'cihansener@gmail.com', 1, 2020, N'1234', CAST(N'2021-03-08T20:55:24.4367368' AS DateTime2), 6, N'1141143221', N'34234234242')
SET IDENTITY_INSERT [dbo].[Students] OFF
/****** Object:  Index [IX_Students_DepartmentId]    Script Date: 14.03.2021 10:04:47 ******/
CREATE NONCLUSTERED INDEX [IX_Students_DepartmentId] ON [dbo].[Students]
(
	[DepartmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Departments_DepartmentId] FOREIGN KEY([DepartmentId])
REFERENCES [dbo].[Departments] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_Departments_DepartmentId]
GO
USE [master]
GO
ALTER DATABASE [GraduateStudentDb] SET  READ_WRITE 
GO
