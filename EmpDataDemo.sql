USE [master]
GO
/****** Object:  Database [DataTest2]    Script Date: 6/18/2024 3:41:05 PM ******/
CREATE DATABASE [DataTest2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DataTest2', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\DataTest2.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DataTest2_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\DataTest2_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DataTest2] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DataTest2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DataTest2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DataTest2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DataTest2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DataTest2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DataTest2] SET ARITHABORT OFF 
GO
ALTER DATABASE [DataTest2] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [DataTest2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DataTest2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DataTest2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DataTest2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DataTest2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DataTest2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DataTest2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DataTest2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DataTest2] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DataTest2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DataTest2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DataTest2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DataTest2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DataTest2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DataTest2] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [DataTest2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DataTest2] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DataTest2] SET  MULTI_USER 
GO
ALTER DATABASE [DataTest2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DataTest2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DataTest2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DataTest2] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DataTest2] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DataTest2] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [DataTest2] SET QUERY_STORE = OFF
GO
USE [DataTest2]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 6/18/2024 3:41:05 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Admins]    Script Date: 6/18/2024 3:41:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admins](
	[Admin_Id] [int] IDENTITY(1,1) NOT NULL,
	[Admin_Name] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[Divi_Id] [int] NOT NULL,
	[CreatedBy] [nvarchar](max) NOT NULL,
	[CreatedOn] [nvarchar](max) NOT NULL,
	[UpdateBy] [nvarchar](max) NULL,
	[UpdateOn] [nvarchar](max) NULL,
 CONSTRAINT [PK_Admins] PRIMARY KEY CLUSTERED 
(
	[Admin_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Departments]    Script Date: 6/18/2024 3:41:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departments](
	[Depa_id] [int] IDENTITY(1,1) NOT NULL,
	[Depa_name] [nvarchar](max) NOT NULL,
	[Divi_Id] [int] NOT NULL,
	[CreatedBy] [nvarchar](max) NOT NULL,
	[CreatedOn] [nvarchar](max) NOT NULL,
	[UpdateBy] [nvarchar](max) NULL,
	[UpdateOn] [nvarchar](max) NULL,
 CONSTRAINT [PK_Departments] PRIMARY KEY CLUSTERED 
(
	[Depa_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Divisions]    Script Date: 6/18/2024 3:41:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Divisions](
	[Divi_Id] [int] IDENTITY(1,1) NOT NULL,
	[Divi_Name] [nvarchar](max) NOT NULL,
	[CreatedBy] [nvarchar](max) NOT NULL,
	[CreatedOn] [nvarchar](max) NOT NULL,
	[UpdateBy] [nvarchar](max) NULL,
	[UpdateOn] [nvarchar](max) NULL,
 CONSTRAINT [PK_Divisions] PRIMARY KEY CLUSTERED 
(
	[Divi_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Educations]    Script Date: 6/18/2024 3:41:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Educations](
	[Edu_Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Educations] PRIMARY KEY CLUSTERED 
(
	[Edu_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 6/18/2024 3:41:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](max) NOT NULL,
	[Sec_id] [int] NOT NULL,
	[Edu_Id] [int] NOT NULL,
	[Sex] [nvarchar](max) NOT NULL,
	[Dob] [nvarchar](max) NOT NULL,
	[CreatedBy] [nvarchar](max) NOT NULL,
	[CreatedOn] [nvarchar](max) NOT NULL,
	[UpdateBy] [nvarchar](max) NULL,
	[UpdateOn] [nvarchar](max) NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sections]    Script Date: 6/18/2024 3:41:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sections](
	[Sec_id] [int] IDENTITY(1,1) NOT NULL,
	[Sec_name] [nvarchar](max) NOT NULL,
	[Depa_id] [int] NOT NULL,
	[CreatedBy] [nvarchar](max) NOT NULL,
	[CreatedOn] [nvarchar](max) NOT NULL,
	[UpdateBy] [nvarchar](max) NULL,
	[UpdateOn] [nvarchar](max) NULL,
 CONSTRAINT [PK_Sections] PRIMARY KEY CLUSTERED 
(
	[Sec_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240522031609_init1', N'8.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240522032327_InitialCreate', N'8.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240522032554_init2', N'8.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240522073849_drop_table', N'8.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240522073955_ReCreate_NewTables', N'8.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240614020851_fixspell', N'8.0.5')
GO
SET IDENTITY_INSERT [dbo].[Admins] ON 

INSERT [dbo].[Admins] ([Admin_Id], [Admin_Name], [Password], [Divi_Id], [CreatedBy], [CreatedOn], [UpdateBy], [UpdateOn]) VALUES (1, N'docuong', N'124', 1, N'1', N'2024-22-05', N'1', N'2024-22-05')
SET IDENTITY_INSERT [dbo].[Admins] OFF
GO
SET IDENTITY_INSERT [dbo].[Departments] ON 

INSERT [dbo].[Departments] ([Depa_id], [Depa_name], [Divi_Id], [CreatedBy], [CreatedOn], [UpdateBy], [UpdateOn]) VALUES (2, N'BR', 5, N'1', N'2024-05-22', N'1', N'2024-05-22')
INSERT [dbo].[Departments] ([Depa_id], [Depa_name], [Divi_Id], [CreatedBy], [CreatedOn], [UpdateBy], [UpdateOn]) VALUES (3, N'CR', 5, N'1', N'2024-05-28', N'1', N'2024-05-28')
INSERT [dbo].[Departments] ([Depa_id], [Depa_name], [Divi_Id], [CreatedBy], [CreatedOn], [UpdateBy], [UpdateOn]) VALUES (5, N'AD', 1, N'1', N'2024-05-28', N'1', N'2024-05-28')
SET IDENTITY_INSERT [dbo].[Departments] OFF
GO
SET IDENTITY_INSERT [dbo].[Divisions] ON 

INSERT [dbo].[Divisions] ([Divi_Id], [Divi_Name], [CreatedBy], [CreatedOn], [UpdateBy], [UpdateOn]) VALUES (1, N'Admin', N'1', N'2024-22-05', N'1', N'2024-22-05')
INSERT [dbo].[Divisions] ([Divi_Id], [Divi_Name], [CreatedBy], [CreatedOn], [UpdateBy], [UpdateOn]) VALUES (5, N'COR', N'1', N'2024-22-05', N'1', N'2024-22-05')
SET IDENTITY_INSERT [dbo].[Divisions] OFF
GO
SET IDENTITY_INSERT [dbo].[Educations] ON 

INSERT [dbo].[Educations] ([Edu_Id], [Name]) VALUES (1, N'BKA')
INSERT [dbo].[Educations] ([Edu_Id], [Name]) VALUES (2, N'FPT')
SET IDENTITY_INSERT [dbo].[Educations] OFF
GO
SET IDENTITY_INSERT [dbo].[Employees] ON 

INSERT [dbo].[Employees] ([Id], [FullName], [Sec_id], [Edu_Id], [Sex], [Dob], [CreatedBy], [CreatedOn], [UpdateBy], [UpdateOn]) VALUES (4, N'Đỗ Nam Trung', 1, 1, N'Male', N'2003-09-22', N'1', N'2024-23-05', N'sa', N'5/24/2024 11:44:13 AM')
INSERT [dbo].[Employees] ([Id], [FullName], [Sec_id], [Edu_Id], [Sex], [Dob], [CreatedBy], [CreatedOn], [UpdateBy], [UpdateOn]) VALUES (7, N'Le Na', 1, 1, N'Female', N'2024-05-23', N'sa', N'5/23/2024 2:57:42 PM', N'sa', N'5/28/2024 1:09:32 PM')
INSERT [dbo].[Employees] ([Id], [FullName], [Sec_id], [Edu_Id], [Sex], [Dob], [CreatedBy], [CreatedOn], [UpdateBy], [UpdateOn]) VALUES (26, N'LiL', 2, 2, N'Male', N'2024-04-29', N'sa', N'5/24/2024 4:06:10 PM', N'sa', N'5/29/2024 11:40:37 AM')
INSERT [dbo].[Employees] ([Id], [FullName], [Sec_id], [Edu_Id], [Sex], [Dob], [CreatedBy], [CreatedOn], [UpdateBy], [UpdateOn]) VALUES (27, N'Lee  Trung Hy', 1, 1, N'Female', N'2024-05-15', N'sa', N'5/24/2024 5:03:10 PM', N'sa', N'5/24/2024 5:03:25 PM')
INSERT [dbo].[Employees] ([Id], [FullName], [Sec_id], [Edu_Id], [Sex], [Dob], [CreatedBy], [CreatedOn], [UpdateBy], [UpdateOn]) VALUES (28, N'NP', 5, 2, N'Female', N'2024-05-15', N'sa', N'5/28/2024 1:02:12 PM', N'sa', N'5/28/2024 1:02:12 PM')
SET IDENTITY_INSERT [dbo].[Employees] OFF
GO
SET IDENTITY_INSERT [dbo].[Sections] ON 

INSERT [dbo].[Sections] ([Sec_id], [Sec_name], [Depa_id], [CreatedBy], [CreatedOn], [UpdateBy], [UpdateOn]) VALUES (1, N'IS', 2, N'1', N'2024-05-22', N'1', N'2024-05-22')
INSERT [dbo].[Sections] ([Sec_id], [Sec_name], [Depa_id], [CreatedBy], [CreatedOn], [UpdateBy], [UpdateOn]) VALUES (2, N'ACC', 2, N'1', N'2024-05-22', N'1', N'2024-05-22')
INSERT [dbo].[Sections] ([Sec_id], [Sec_name], [Depa_id], [CreatedBy], [CreatedOn], [UpdateBy], [UpdateOn]) VALUES (5, N'AL', 3, N'1', N'2024-05-28', N'1', N'2024-05-28')
INSERT [dbo].[Sections] ([Sec_id], [Sec_name], [Depa_id], [CreatedBy], [CreatedOn], [UpdateBy], [UpdateOn]) VALUES (7, N'ADD', 5, N'1', N'2024-05-29', N'1', N'2024-05-29')
SET IDENTITY_INSERT [dbo].[Sections] OFF
GO
/****** Object:  Index [IX_Admins_Divi_Id]    Script Date: 6/18/2024 3:41:05 PM ******/
CREATE NONCLUSTERED INDEX [IX_Admins_Divi_Id] ON [dbo].[Admins]
(
	[Divi_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Departments_Divi_Id]    Script Date: 6/18/2024 3:41:05 PM ******/
CREATE NONCLUSTERED INDEX [IX_Departments_Divi_Id] ON [dbo].[Departments]
(
	[Divi_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Employees_Edu_Id]    Script Date: 6/18/2024 3:41:05 PM ******/
CREATE NONCLUSTERED INDEX [IX_Employees_Edu_Id] ON [dbo].[Employees]
(
	[Edu_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Employees_Sec_id]    Script Date: 6/18/2024 3:41:05 PM ******/
CREATE NONCLUSTERED INDEX [IX_Employees_Sec_id] ON [dbo].[Employees]
(
	[Sec_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Sections_Depa_id]    Script Date: 6/18/2024 3:41:05 PM ******/
CREATE NONCLUSTERED INDEX [IX_Sections_Depa_id] ON [dbo].[Sections]
(
	[Depa_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Admins]  WITH CHECK ADD  CONSTRAINT [FK_Admins_Divisions_Divi_Id] FOREIGN KEY([Divi_Id])
REFERENCES [dbo].[Divisions] ([Divi_Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Admins] CHECK CONSTRAINT [FK_Admins_Divisions_Divi_Id]
GO
ALTER TABLE [dbo].[Departments]  WITH CHECK ADD  CONSTRAINT [FK_Departments_Divisions_Divi_Id] FOREIGN KEY([Divi_Id])
REFERENCES [dbo].[Divisions] ([Divi_Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Departments] CHECK CONSTRAINT [FK_Departments_Divisions_Divi_Id]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_Educations_Edu_Id] FOREIGN KEY([Edu_Id])
REFERENCES [dbo].[Educations] ([Edu_Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_Educations_Edu_Id]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_Sections_Sec_id] FOREIGN KEY([Sec_id])
REFERENCES [dbo].[Sections] ([Sec_id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_Sections_Sec_id]
GO
ALTER TABLE [dbo].[Sections]  WITH CHECK ADD  CONSTRAINT [FK_Sections_Departments_Depa_id] FOREIGN KEY([Depa_id])
REFERENCES [dbo].[Departments] ([Depa_id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Sections] CHECK CONSTRAINT [FK_Sections_Departments_Depa_id]
GO
USE [master]
GO
ALTER DATABASE [DataTest2] SET  READ_WRITE 
GO
