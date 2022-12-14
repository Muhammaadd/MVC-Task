USE [master]
GO
/****** Object:  Database [MonofiaDotNetQ3]    Script Date: 8/16/2022 2:53:44 PM ******/
CREATE DATABASE [MonofiaDotNetQ3]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MonofiaDotNetQ3', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\MonofiaDotNetQ3.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MonofiaDotNetQ3_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\MonofiaDotNetQ3_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [MonofiaDotNetQ3] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MonofiaDotNetQ3].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MonofiaDotNetQ3] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MonofiaDotNetQ3] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MonofiaDotNetQ3] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MonofiaDotNetQ3] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MonofiaDotNetQ3] SET ARITHABORT OFF 
GO
ALTER DATABASE [MonofiaDotNetQ3] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MonofiaDotNetQ3] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MonofiaDotNetQ3] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MonofiaDotNetQ3] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MonofiaDotNetQ3] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MonofiaDotNetQ3] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MonofiaDotNetQ3] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MonofiaDotNetQ3] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MonofiaDotNetQ3] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MonofiaDotNetQ3] SET  ENABLE_BROKER 
GO
ALTER DATABASE [MonofiaDotNetQ3] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MonofiaDotNetQ3] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MonofiaDotNetQ3] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MonofiaDotNetQ3] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MonofiaDotNetQ3] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MonofiaDotNetQ3] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [MonofiaDotNetQ3] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MonofiaDotNetQ3] SET RECOVERY FULL 
GO
ALTER DATABASE [MonofiaDotNetQ3] SET  MULTI_USER 
GO
ALTER DATABASE [MonofiaDotNetQ3] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MonofiaDotNetQ3] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MonofiaDotNetQ3] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MonofiaDotNetQ3] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MonofiaDotNetQ3] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MonofiaDotNetQ3] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'MonofiaDotNetQ3', N'ON'
GO
ALTER DATABASE [MonofiaDotNetQ3] SET QUERY_STORE = OFF
GO
USE [MonofiaDotNetQ3]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 8/16/2022 2:53:44 PM ******/
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
/****** Object:  Table [dbo].[courses]    Script Date: 8/16/2022 2:53:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[courses](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Degree] [int] NOT NULL,
	[PassDegree] [int] NOT NULL,
	[Dep_id] [int] NOT NULL,
 CONSTRAINT [PK_courses] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CrsResults]    Script Date: 8/16/2022 2:53:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CrsResults](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[degree] [real] NOT NULL,
	[Crs_id] [int] NOT NULL,
	[Trainee_id] [int] NOT NULL,
 CONSTRAINT [PK_CrsResults] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Departments]    Script Date: 8/16/2022 2:53:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Manager] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Departments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Instructors]    Script Date: 8/16/2022 2:53:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Instructors](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Img] [nvarchar](max) NOT NULL,
	[Salary] [real] NOT NULL,
	[Address] [nvarchar](max) NULL,
	[Crs_id] [int] NOT NULL,
	[Dept_id] [int] NOT NULL,
 CONSTRAINT [PK_Instructors] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Trainees]    Script Date: 8/16/2022 2:53:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Trainees](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Address] [nvarchar](max) NULL,
	[Level] [nvarchar](max) NOT NULL,
	[Dept_id] [int] NOT NULL,
	[Profile] [nvarchar](max) NULL,
 CONSTRAINT [PK_Trainees] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220716110929_v1', N'6.0.7')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220716111530_v2', N'6.0.7')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220716112554_v3', N'6.0.7')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220717102235_v4', N'6.0.7')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220717111352_v5', N'6.0.7')
GO
SET IDENTITY_INSERT [dbo].[courses] ON 

INSERT [dbo].[courses] ([Id], [Name], [Degree], [PassDegree], [Dep_id]) VALUES (1, N'C Sharp', 120, 30, 1)
INSERT [dbo].[courses] ([Id], [Name], [Degree], [PassDegree], [Dep_id]) VALUES (2, N'Java Script', 150, 45, 2)
INSERT [dbo].[courses] ([Id], [Name], [Degree], [PassDegree], [Dep_id]) VALUES (3, N'Angular', 200, 105, 3)
INSERT [dbo].[courses] ([Id], [Name], [Degree], [PassDegree], [Dep_id]) VALUES (4, N'Design P', 75, 20, 1)
INSERT [dbo].[courses] ([Id], [Name], [Degree], [PassDegree], [Dep_id]) VALUES (5, N'Node JS', 175, 75, 3)
INSERT [dbo].[courses] ([Id], [Name], [Degree], [PassDegree], [Dep_id]) VALUES (6, N'React Native', 175, 85, 2)
INSERT [dbo].[courses] ([Id], [Name], [Degree], [PassDegree], [Dep_id]) VALUES (7, N'SQL Server', 150, 50, 2)
INSERT [dbo].[courses] ([Id], [Name], [Degree], [PassDegree], [Dep_id]) VALUES (9, N'ASP .Net Core', 180, 100, 3)
INSERT [dbo].[courses] ([Id], [Name], [Degree], [PassDegree], [Dep_id]) VALUES (10, N'Solid Principles', 75, 30, 3)
INSERT [dbo].[courses] ([Id], [Name], [Degree], [PassDegree], [Dep_id]) VALUES (11, N'Solid Principles', 100, 50, 1)
INSERT [dbo].[courses] ([Id], [Name], [Degree], [PassDegree], [Dep_id]) VALUES (12, N'Design Patterns ', 120, 60, 3)
INSERT [dbo].[courses] ([Id], [Name], [Degree], [PassDegree], [Dep_id]) VALUES (14, N'Design P', 70, 50, 2)
INSERT [dbo].[courses] ([Id], [Name], [Degree], [PassDegree], [Dep_id]) VALUES (20, N'Singlton', 100, 55, 1)
SET IDENTITY_INSERT [dbo].[courses] OFF
GO
SET IDENTITY_INSERT [dbo].[CrsResults] ON 

INSERT [dbo].[CrsResults] ([Id], [degree], [Crs_id], [Trainee_id]) VALUES (1, 95, 1, 1)
INSERT [dbo].[CrsResults] ([Id], [degree], [Crs_id], [Trainee_id]) VALUES (2, 120, 2, 1)
INSERT [dbo].[CrsResults] ([Id], [degree], [Crs_id], [Trainee_id]) VALUES (3, 100, 3, 1)
INSERT [dbo].[CrsResults] ([Id], [degree], [Crs_id], [Trainee_id]) VALUES (4, 50, 5, 1)
INSERT [dbo].[CrsResults] ([Id], [degree], [Crs_id], [Trainee_id]) VALUES (5, 20, 1, 2)
INSERT [dbo].[CrsResults] ([Id], [degree], [Crs_id], [Trainee_id]) VALUES (6, 40, 7, 2)
INSERT [dbo].[CrsResults] ([Id], [degree], [Crs_id], [Trainee_id]) VALUES (7, 130, 2, 2)
INSERT [dbo].[CrsResults] ([Id], [degree], [Crs_id], [Trainee_id]) VALUES (8, 75, 4, 2)
INSERT [dbo].[CrsResults] ([Id], [degree], [Crs_id], [Trainee_id]) VALUES (9, 50, 1, 3)
INSERT [dbo].[CrsResults] ([Id], [degree], [Crs_id], [Trainee_id]) VALUES (10, 40, 2, 3)
INSERT [dbo].[CrsResults] ([Id], [degree], [Crs_id], [Trainee_id]) VALUES (11, 140, 3, 3)
INSERT [dbo].[CrsResults] ([Id], [degree], [Crs_id], [Trainee_id]) VALUES (12, 150, 5, 3)
INSERT [dbo].[CrsResults] ([Id], [degree], [Crs_id], [Trainee_id]) VALUES (14, 100, 1, 4)
INSERT [dbo].[CrsResults] ([Id], [degree], [Crs_id], [Trainee_id]) VALUES (15, 40, 2, 4)
INSERT [dbo].[CrsResults] ([Id], [degree], [Crs_id], [Trainee_id]) VALUES (16, 150, 3, 4)
INSERT [dbo].[CrsResults] ([Id], [degree], [Crs_id], [Trainee_id]) VALUES (17, 130, 7, 4)
INSERT [dbo].[CrsResults] ([Id], [degree], [Crs_id], [Trainee_id]) VALUES (18, 18, 6, 4)
SET IDENTITY_INSERT [dbo].[CrsResults] OFF
GO
SET IDENTITY_INSERT [dbo].[Departments] ON 

INSERT [dbo].[Departments] ([Id], [Name], [Manager]) VALUES (1, N'DP1', N'Muhammed')
INSERT [dbo].[Departments] ([Id], [Name], [Manager]) VALUES (2, N'DP2', N'Islam')
INSERT [dbo].[Departments] ([Id], [Name], [Manager]) VALUES (3, N'DP3', N'Abdelrazek')
SET IDENTITY_INSERT [dbo].[Departments] OFF
GO
SET IDENTITY_INSERT [dbo].[Instructors] ON 

INSERT [dbo].[Instructors] ([Id], [Name], [Img], [Salary], [Address], [Crs_id], [Dept_id]) VALUES (1, N'memo', N'5.jpg', 20000, N'Cairo , Egypt', 1, 2)
INSERT [dbo].[Instructors] ([Id], [Name], [Img], [Salary], [Address], [Crs_id], [Dept_id]) VALUES (5, N'Rami Mohamed', N'4.jpg', 12000, N'Menofia , Egypt', 7, 1)
INSERT [dbo].[Instructors] ([Id], [Name], [Img], [Salary], [Address], [Crs_id], [Dept_id]) VALUES (6, N'Amira Mostafa', N'1.jpg', 8000, N'Tahrir , Cairo', 5, 3)
INSERT [dbo].[Instructors] ([Id], [Name], [Img], [Salary], [Address], [Crs_id], [Dept_id]) VALUES (7, N'Sara Atef', N'2.jpg', 7000, N'Giza , Egypt', 2, 1)
INSERT [dbo].[Instructors] ([Id], [Name], [Img], [Salary], [Address], [Crs_id], [Dept_id]) VALUES (9, N'Gaber', N'6.jpg', 12000, N'Maadi , Egypt', 3, 2)
INSERT [dbo].[Instructors] ([Id], [Name], [Img], [Salary], [Address], [Crs_id], [Dept_id]) VALUES (10, N'New Ins', N'6.jpg', 15000, N'Mansoura , Egypt', 4, 3)
INSERT [dbo].[Instructors] ([Id], [Name], [Img], [Salary], [Address], [Crs_id], [Dept_id]) VALUES (11, N'qwfwf', N'6.jpg', 10000, N'wfff', 4, 3)
INSERT [dbo].[Instructors] ([Id], [Name], [Img], [Salary], [Address], [Crs_id], [Dept_id]) VALUES (12, N'dfwfwf', N'IMG_20220414_000842.jpg', 10000, N'fwdf', 1, 1)
INSERT [dbo].[Instructors] ([Id], [Name], [Img], [Salary], [Address], [Crs_id], [Dept_id]) VALUES (13, N'Hamody', N'Mada.jpg', 20000, N'Assuit', 9, 2)
SET IDENTITY_INSERT [dbo].[Instructors] OFF
GO
SET IDENTITY_INSERT [dbo].[Trainees] ON 

INSERT [dbo].[Trainees] ([Id], [Name], [Address], [Level], [Dept_id], [Profile]) VALUES (1, N'Muhammed A.abdelrazek', N'38 St ,Nasr Cit , Egypt', N'Bachelor''s degree', 1, N'6.jpg')
INSERT [dbo].[Trainees] ([Id], [Name], [Address], [Level], [Dept_id], [Profile]) VALUES (2, N'Mahmoud Ahmed', N'Cairo , Egypt', N'Associate degree', 2, N'5.jpg')
INSERT [dbo].[Trainees] ([Id], [Name], [Address], [Level], [Dept_id], [Profile]) VALUES (3, N'Noha Salem', N'Menofia , Egypt', N'Master''s degree', 3, N'1.jpg')
INSERT [dbo].[Trainees] ([Id], [Name], [Address], [Level], [Dept_id], [Profile]) VALUES (4, N'Magda Tony', N'Giza , Egypt', N'Doctoral degree', 2, N'3.jpg')
SET IDENTITY_INSERT [dbo].[Trainees] OFF
GO
/****** Object:  Index [IX_courses_Dep_id]    Script Date: 8/16/2022 2:53:44 PM ******/
CREATE NONCLUSTERED INDEX [IX_courses_Dep_id] ON [dbo].[courses]
(
	[Dep_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_CrsResults_Crs_id]    Script Date: 8/16/2022 2:53:44 PM ******/
CREATE NONCLUSTERED INDEX [IX_CrsResults_Crs_id] ON [dbo].[CrsResults]
(
	[Crs_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_CrsResults_Trainee_id]    Script Date: 8/16/2022 2:53:44 PM ******/
CREATE NONCLUSTERED INDEX [IX_CrsResults_Trainee_id] ON [dbo].[CrsResults]
(
	[Trainee_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Instructors_Crs_id]    Script Date: 8/16/2022 2:53:44 PM ******/
CREATE NONCLUSTERED INDEX [IX_Instructors_Crs_id] ON [dbo].[Instructors]
(
	[Crs_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Instructors_Dept_id]    Script Date: 8/16/2022 2:53:44 PM ******/
CREATE NONCLUSTERED INDEX [IX_Instructors_Dept_id] ON [dbo].[Instructors]
(
	[Dept_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Trainees_Dept_id]    Script Date: 8/16/2022 2:53:44 PM ******/
CREATE NONCLUSTERED INDEX [IX_Trainees_Dept_id] ON [dbo].[Trainees]
(
	[Dept_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[courses]  WITH CHECK ADD  CONSTRAINT [FK_courses_Departments_Dep_id] FOREIGN KEY([Dep_id])
REFERENCES [dbo].[Departments] ([Id])
GO
ALTER TABLE [dbo].[courses] CHECK CONSTRAINT [FK_courses_Departments_Dep_id]
GO
ALTER TABLE [dbo].[CrsResults]  WITH CHECK ADD  CONSTRAINT [FK_CrsResults_courses_Crs_id] FOREIGN KEY([Crs_id])
REFERENCES [dbo].[courses] ([Id])
GO
ALTER TABLE [dbo].[CrsResults] CHECK CONSTRAINT [FK_CrsResults_courses_Crs_id]
GO
ALTER TABLE [dbo].[CrsResults]  WITH CHECK ADD  CONSTRAINT [FK_CrsResults_Trainees_Trainee_id] FOREIGN KEY([Trainee_id])
REFERENCES [dbo].[Trainees] ([Id])
GO
ALTER TABLE [dbo].[CrsResults] CHECK CONSTRAINT [FK_CrsResults_Trainees_Trainee_id]
GO
ALTER TABLE [dbo].[Instructors]  WITH CHECK ADD  CONSTRAINT [FK_Instructors_courses_Crs_id] FOREIGN KEY([Crs_id])
REFERENCES [dbo].[courses] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Instructors] CHECK CONSTRAINT [FK_Instructors_courses_Crs_id]
GO
ALTER TABLE [dbo].[Instructors]  WITH CHECK ADD  CONSTRAINT [FK_Instructors_Departments_Dept_id] FOREIGN KEY([Dept_id])
REFERENCES [dbo].[Departments] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Instructors] CHECK CONSTRAINT [FK_Instructors_Departments_Dept_id]
GO
ALTER TABLE [dbo].[Trainees]  WITH CHECK ADD  CONSTRAINT [FK_Trainees_Departments_Dept_id] FOREIGN KEY([Dept_id])
REFERENCES [dbo].[Departments] ([Id])
GO
ALTER TABLE [dbo].[Trainees] CHECK CONSTRAINT [FK_Trainees_Departments_Dept_id]
GO
USE [master]
GO
ALTER DATABASE [MonofiaDotNetQ3] SET  READ_WRITE 
GO
