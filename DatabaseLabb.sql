USE [master]
GO
/****** Object:  Database [SchoolLabb2]    Script Date: 2023-12-22 18:58:57 ******/
CREATE DATABASE [SchoolLabb2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SchoolLabb2', FILENAME = N'C:\Users\Tess\SchoolLabb2.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SchoolLabb2_log', FILENAME = N'C:\Users\Tess\SchoolLabb2_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [SchoolLabb2] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SchoolLabb2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SchoolLabb2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SchoolLabb2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SchoolLabb2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SchoolLabb2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SchoolLabb2] SET ARITHABORT OFF 
GO
ALTER DATABASE [SchoolLabb2] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [SchoolLabb2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SchoolLabb2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SchoolLabb2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SchoolLabb2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SchoolLabb2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SchoolLabb2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SchoolLabb2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SchoolLabb2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SchoolLabb2] SET  ENABLE_BROKER 
GO
ALTER DATABASE [SchoolLabb2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SchoolLabb2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SchoolLabb2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SchoolLabb2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SchoolLabb2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SchoolLabb2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SchoolLabb2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SchoolLabb2] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SchoolLabb2] SET  MULTI_USER 
GO
ALTER DATABASE [SchoolLabb2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SchoolLabb2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SchoolLabb2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SchoolLabb2] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SchoolLabb2] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SchoolLabb2] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [SchoolLabb2] SET QUERY_STORE = OFF
GO
USE [SchoolLabb2]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 2023-12-22 18:58:57 ******/
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
/****** Object:  Table [dbo].[Course]    Script Date: 2023-12-22 18:58:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Course](
	[CourseID] [int] IDENTITY(1,1) NOT NULL,
	[CourseName] [nvarchar](50) NULL,
	[CourseDescription] [nvarchar](150) NULL,
PRIMARY KEY CLUSTERED 
(
	[CourseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Course_Teacher]    Script Date: 2023-12-22 18:58:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Course_Teacher](
	[FK_CourseID] [int] NULL,
	[FK_TeacherID] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Enrollment]    Script Date: 2023-12-22 18:58:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Enrollment](
	[FK_StudentID] [int] NULL,
	[FK_CourseID] [int] NULL,
	[FK_GradeID] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Grade]    Script Date: 2023-12-22 18:58:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Grade](
	[GradeID] [int] IDENTITY(6,-1) NOT NULL,
	[Grade] [char](1) NULL,
	[FK_StudentID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[GradeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GradeDetails]    Script Date: 2023-12-22 18:58:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GradeDetails](
	[GradeDetailID] [int] IDENTITY(1,1) NOT NULL,
	[FK_GradeID] [int] NULL,
	[FK_StudentID] [int] NULL,
	[FK_CourseID] [int] NULL,
	[SetDate] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[GradeDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Professions]    Script Date: 2023-12-22 18:58:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Professions](
	[ProfessionID] [int] IDENTITY(1,1) NOT NULL,
	[StaffRole] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ProfessionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staff]    Script Date: 2023-12-22 18:58:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff](
	[StaffID] [int] IDENTITY(1,1) NOT NULL,
	[ProfessionID] [int] NULL,
	[SocialSecurityNumber] [bigint] NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[StaffID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staff_Professions]    Script Date: 2023-12-22 18:58:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff_Professions](
	[FK_StaffID] [int] NULL,
	[FK_ProfessionID] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 2023-12-22 18:58:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[StudentID] [int] IDENTITY(1,1) NOT NULL,
	[SocialSecurityNumber] [bigint] NULL,
	[Class] [nvarchar](5) NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[Gender] [nvarchar](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Course] ON 

INSERT [dbo].[Course] ([CourseID], [CourseName], [CourseDescription]) VALUES (1, N'Programing 1', N'Programming at entry level')
INSERT [dbo].[Course] ([CourseID], [CourseName], [CourseDescription]) VALUES (2, N'Math 2C', N'Math at high schools sencond level')
INSERT [dbo].[Course] ([CourseID], [CourseName], [CourseDescription]) VALUES (3, N'SocialStudies', N'Studies of todays socielty')
INSERT [dbo].[Course] ([CourseID], [CourseName], [CourseDescription]) VALUES (4, N'History', N'Studies of the history of everything')
INSERT [dbo].[Course] ([CourseID], [CourseName], [CourseDescription]) VALUES (5, N'English101', N'First english course')
INSERT [dbo].[Course] ([CourseID], [CourseName], [CourseDescription]) VALUES (6, N'Programing 1', N'Programming at entry level')
INSERT [dbo].[Course] ([CourseID], [CourseName], [CourseDescription]) VALUES (7, N'Math 2C', N'Math at high schools sencond level')
INSERT [dbo].[Course] ([CourseID], [CourseName], [CourseDescription]) VALUES (8, N'SocialStudies', N'Studies of todays socielty')
INSERT [dbo].[Course] ([CourseID], [CourseName], [CourseDescription]) VALUES (9, N'History', N'Studies of the history of everything')
INSERT [dbo].[Course] ([CourseID], [CourseName], [CourseDescription]) VALUES (10, N'English101', N'First english course')
SET IDENTITY_INSERT [dbo].[Course] OFF
GO
INSERT [dbo].[Enrollment] ([FK_StudentID], [FK_CourseID], [FK_GradeID]) VALUES (1, 3, 2)
INSERT [dbo].[Enrollment] ([FK_StudentID], [FK_CourseID], [FK_GradeID]) VALUES (10, 1, 1)
INSERT [dbo].[Enrollment] ([FK_StudentID], [FK_CourseID], [FK_GradeID]) VALUES (6, 2, 3)
INSERT [dbo].[Enrollment] ([FK_StudentID], [FK_CourseID], [FK_GradeID]) VALUES (8, 1, 1)
INSERT [dbo].[Enrollment] ([FK_StudentID], [FK_CourseID], [FK_GradeID]) VALUES (5, 2, 5)
INSERT [dbo].[Enrollment] ([FK_StudentID], [FK_CourseID], [FK_GradeID]) VALUES (11, 4, 6)
INSERT [dbo].[Enrollment] ([FK_StudentID], [FK_CourseID], [FK_GradeID]) VALUES (4, 3, 1)
INSERT [dbo].[Enrollment] ([FK_StudentID], [FK_CourseID], [FK_GradeID]) VALUES (9, 1, 4)
INSERT [dbo].[Enrollment] ([FK_StudentID], [FK_CourseID], [FK_GradeID]) VALUES (7, 3, 5)
GO
SET IDENTITY_INSERT [dbo].[Grade] ON 

INSERT [dbo].[Grade] ([GradeID], [Grade], [FK_StudentID]) VALUES (1, N'F', 3)
INSERT [dbo].[Grade] ([GradeID], [Grade], [FK_StudentID]) VALUES (2, N'E', 5)
INSERT [dbo].[Grade] ([GradeID], [Grade], [FK_StudentID]) VALUES (3, N'D', 1)
INSERT [dbo].[Grade] ([GradeID], [Grade], [FK_StudentID]) VALUES (4, N'C', 8)
INSERT [dbo].[Grade] ([GradeID], [Grade], [FK_StudentID]) VALUES (5, N'B', 2)
INSERT [dbo].[Grade] ([GradeID], [Grade], [FK_StudentID]) VALUES (6, N'A', 4)
SET IDENTITY_INSERT [dbo].[Grade] OFF
GO
SET IDENTITY_INSERT [dbo].[GradeDetails] ON 

INSERT [dbo].[GradeDetails] ([GradeDetailID], [FK_GradeID], [FK_StudentID], [FK_CourseID], [SetDate]) VALUES (2, 3, 8, 1, CAST(N'2023-12-07' AS Date))
INSERT [dbo].[GradeDetails] ([GradeDetailID], [FK_GradeID], [FK_StudentID], [FK_CourseID], [SetDate]) VALUES (3, 1, 4, 3, CAST(N'2023-12-02' AS Date))
INSERT [dbo].[GradeDetails] ([GradeDetailID], [FK_GradeID], [FK_StudentID], [FK_CourseID], [SetDate]) VALUES (4, 5, 5, 1, CAST(N'2023-12-03' AS Date))
INSERT [dbo].[GradeDetails] ([GradeDetailID], [FK_GradeID], [FK_StudentID], [FK_CourseID], [SetDate]) VALUES (5, 2, 2, 4, CAST(N'2023-05-23' AS Date))
INSERT [dbo].[GradeDetails] ([GradeDetailID], [FK_GradeID], [FK_StudentID], [FK_CourseID], [SetDate]) VALUES (6, 6, 3, 2, CAST(N'2023-11-20' AS Date))
SET IDENTITY_INSERT [dbo].[GradeDetails] OFF
GO
SET IDENTITY_INSERT [dbo].[Professions] ON 

INSERT [dbo].[Professions] ([ProfessionID], [StaffRole]) VALUES (1, N'Teacher')
INSERT [dbo].[Professions] ([ProfessionID], [StaffRole]) VALUES (2, N'Principal')
INSERT [dbo].[Professions] ([ProfessionID], [StaffRole]) VALUES (3, N'Janitor')
INSERT [dbo].[Professions] ([ProfessionID], [StaffRole]) VALUES (4, N'Teachers aid')
INSERT [dbo].[Professions] ([ProfessionID], [StaffRole]) VALUES (5, N'Lunch staff')
INSERT [dbo].[Professions] ([ProfessionID], [StaffRole]) VALUES (6, N'Guidance counselor')
SET IDENTITY_INSERT [dbo].[Professions] OFF
GO
SET IDENTITY_INSERT [dbo].[Staff] ON 

INSERT [dbo].[Staff] ([StaffID], [ProfessionID], [SocialSecurityNumber], [FirstName], [LastName]) VALUES (1, 1, 198101240202, N'David', N'Kopperfeild')
INSERT [dbo].[Staff] ([StaffID], [ProfessionID], [SocialSecurityNumber], [FirstName], [LastName]) VALUES (2, 3, 199202122319, N'Link', N'Potter')
INSERT [dbo].[Staff] ([StaffID], [ProfessionID], [SocialSecurityNumber], [FirstName], [LastName]) VALUES (3, 6, 198803145678, N'Kim', N'Elm')
INSERT [dbo].[Staff] ([StaffID], [ProfessionID], [SocialSecurityNumber], [FirstName], [LastName]) VALUES (4, 1, 197403191211, N'Sarah', N'Keys')
INSERT [dbo].[Staff] ([StaffID], [ProfessionID], [SocialSecurityNumber], [FirstName], [LastName]) VALUES (5, 3, 198912011923, N'Theodore', N'Maplethorpe')
INSERT [dbo].[Staff] ([StaffID], [ProfessionID], [SocialSecurityNumber], [FirstName], [LastName]) VALUES (6, 4, 196807311968, N'Lilly', N'Days')
INSERT [dbo].[Staff] ([StaffID], [ProfessionID], [SocialSecurityNumber], [FirstName], [LastName]) VALUES (7, 1, 198901235589, N'Maximiliam', N'Smith')
INSERT [dbo].[Staff] ([StaffID], [ProfessionID], [SocialSecurityNumber], [FirstName], [LastName]) VALUES (8, 5, 197103189905, N'Lilian', N'Krown')
INSERT [dbo].[Staff] ([StaffID], [ProfessionID], [SocialSecurityNumber], [FirstName], [LastName]) VALUES (9, 2, 198609158639, N'Milian', N'Foxt')
INSERT [dbo].[Staff] ([StaffID], [ProfessionID], [SocialSecurityNumber], [FirstName], [LastName]) VALUES (10, 4, 199910058692, N'Thomas', N'Weasley')
INSERT [dbo].[Staff] ([StaffID], [ProfessionID], [SocialSecurityNumber], [FirstName], [LastName]) VALUES (11, 6, 198904069356, N'Linus', N'Sanders')
INSERT [dbo].[Staff] ([StaffID], [ProfessionID], [SocialSecurityNumber], [FirstName], [LastName]) VALUES (12, 6, 197705063795, N'Sandra', N'Monofeild')
INSERT [dbo].[Staff] ([StaffID], [ProfessionID], [SocialSecurityNumber], [FirstName], [LastName]) VALUES (13, 2, 198811055692, N'Teddy', N'Kish')
INSERT [dbo].[Staff] ([StaffID], [ProfessionID], [SocialSecurityNumber], [FirstName], [LastName]) VALUES (14, 1, 196612035610, N'Dag', N'Andromeda')
INSERT [dbo].[Staff] ([StaffID], [ProfessionID], [SocialSecurityNumber], [FirstName], [LastName]) VALUES (15, 5, 198911305590, N'Jonas', N'Kanix')
INSERT [dbo].[Staff] ([StaffID], [ProfessionID], [SocialSecurityNumber], [FirstName], [LastName]) VALUES (16, 2, 195502094567, N'Axel', N'jones')
INSERT [dbo].[Staff] ([StaffID], [ProfessionID], [SocialSecurityNumber], [FirstName], [LastName]) VALUES (17, 1, 198212122345, N'Samy', N'Feild')
INSERT [dbo].[Staff] ([StaffID], [ProfessionID], [SocialSecurityNumber], [FirstName], [LastName]) VALUES (18, 2, 129502035567, N'Kasper', N'Token')
INSERT [dbo].[Staff] ([StaffID], [ProfessionID], [SocialSecurityNumber], [FirstName], [LastName]) VALUES (19, 6, 197419065903, N'Lamden', N'Dox')
INSERT [dbo].[Staff] ([StaffID], [ProfessionID], [SocialSecurityNumber], [FirstName], [LastName]) VALUES (20, 2, 197531079907, N'Maxine', N'Mongomery')
INSERT [dbo].[Staff] ([StaffID], [ProfessionID], [SocialSecurityNumber], [FirstName], [LastName]) VALUES (21, 4, 186807015693, N'Ted', N'Booth')
INSERT [dbo].[Staff] ([StaffID], [ProfessionID], [SocialSecurityNumber], [FirstName], [LastName]) VALUES (22, 1, 196901054986, N'Alexis', N'Brennan')
INSERT [dbo].[Staff] ([StaffID], [ProfessionID], [SocialSecurityNumber], [FirstName], [LastName]) VALUES (23, 3, 195511125678, N'Tobias', N'Fox')
SET IDENTITY_INSERT [dbo].[Staff] OFF
GO
SET IDENTITY_INSERT [dbo].[Students] ON 

INSERT [dbo].[Students] ([StudentID], [SocialSecurityNumber], [Class], [FirstName], [LastName], [Gender]) VALUES (1, 201501231191, N'5c', N'Millie', N'Borg', NULL)
INSERT [dbo].[Students] ([StudentID], [SocialSecurityNumber], [Class], [FirstName], [LastName], [Gender]) VALUES (2, 201209146901, N'8b', N'John', N'Davis', NULL)
INSERT [dbo].[Students] ([StudentID], [SocialSecurityNumber], [Class], [FirstName], [LastName], [Gender]) VALUES (3, 201308056783, N'7a', N'Alex', N'Dickenson', NULL)
INSERT [dbo].[Students] ([StudentID], [SocialSecurityNumber], [Class], [FirstName], [LastName], [Gender]) VALUES (4, 201111095869, N'9e', N'Amanda', N'Johnson', NULL)
INSERT [dbo].[Students] ([StudentID], [SocialSecurityNumber], [Class], [FirstName], [LastName], [Gender]) VALUES (5, 201111095869, N'9a', N'Caleb', N'Jacksson', NULL)
INSERT [dbo].[Students] ([StudentID], [SocialSecurityNumber], [Class], [FirstName], [LastName], [Gender]) VALUES (6, 201111095869, N'9e', N'Amber', N'Alexandria', NULL)
INSERT [dbo].[Students] ([StudentID], [SocialSecurityNumber], [Class], [FirstName], [LastName], [Gender]) VALUES (7, 201111095869, N'5c', N'Tom', N'Petersson', NULL)
INSERT [dbo].[Students] ([StudentID], [SocialSecurityNumber], [Class], [FirstName], [LastName], [Gender]) VALUES (8, 201111095869, N'5c', N'Hugo', N'Hill', NULL)
INSERT [dbo].[Students] ([StudentID], [SocialSecurityNumber], [Class], [FirstName], [LastName], [Gender]) VALUES (9, 201508173456, N'5c', N'Fred', N'Samsson', NULL)
INSERT [dbo].[Students] ([StudentID], [SocialSecurityNumber], [Class], [FirstName], [LastName], [Gender]) VALUES (10, 201201239524, N'8b', N'Emil', N'koon', NULL)
INSERT [dbo].[Students] ([StudentID], [SocialSecurityNumber], [Class], [FirstName], [LastName], [Gender]) VALUES (11, 201305785634, N'7a', N'Emily', N'Kimbley', NULL)
INSERT [dbo].[Students] ([StudentID], [SocialSecurityNumber], [Class], [FirstName], [LastName], [Gender]) VALUES (12, 201110135692, N'9e', N'Freddy', N'Nilsen', NULL)
INSERT [dbo].[Students] ([StudentID], [SocialSecurityNumber], [Class], [FirstName], [LastName], [Gender]) VALUES (13, 201102246789, N'9a', N'Hampus', N'Mannerstrom', NULL)
INSERT [dbo].[Students] ([StudentID], [SocialSecurityNumber], [Class], [FirstName], [LastName], [Gender]) VALUES (14, 201105115693, N'9e', N'Sandra', N'Johnsson', NULL)
INSERT [dbo].[Students] ([StudentID], [SocialSecurityNumber], [Class], [FirstName], [LastName], [Gender]) VALUES (15, 201503146731, N'5c', N'Gabe', N'Bish', NULL)
INSERT [dbo].[Students] ([StudentID], [SocialSecurityNumber], [Class], [FirstName], [LastName], [Gender]) VALUES (16, 201507083456, N'5c', N'Tim', N'Miller', NULL)
SET IDENTITY_INSERT [dbo].[Students] OFF
GO
ALTER TABLE [dbo].[Course_Teacher]  WITH CHECK ADD  CONSTRAINT [Course_Teacher_CourseID] FOREIGN KEY([FK_CourseID])
REFERENCES [dbo].[Course] ([CourseID])
GO
ALTER TABLE [dbo].[Course_Teacher] CHECK CONSTRAINT [Course_Teacher_CourseID]
GO
ALTER TABLE [dbo].[Course_Teacher]  WITH CHECK ADD  CONSTRAINT [Course_Teacher_TeacherID] FOREIGN KEY([FK_TeacherID])
REFERENCES [dbo].[Staff] ([StaffID])
GO
ALTER TABLE [dbo].[Course_Teacher] CHECK CONSTRAINT [Course_Teacher_TeacherID]
GO
ALTER TABLE [dbo].[Enrollment]  WITH CHECK ADD  CONSTRAINT [FK_CourseID_Enrollment] FOREIGN KEY([FK_CourseID])
REFERENCES [dbo].[Course] ([CourseID])
GO
ALTER TABLE [dbo].[Enrollment] CHECK CONSTRAINT [FK_CourseID_Enrollment]
GO
ALTER TABLE [dbo].[Enrollment]  WITH CHECK ADD  CONSTRAINT [FK_Grade_Enrollment] FOREIGN KEY([FK_GradeID])
REFERENCES [dbo].[Grade] ([GradeID])
GO
ALTER TABLE [dbo].[Enrollment] CHECK CONSTRAINT [FK_Grade_Enrollment]
GO
ALTER TABLE [dbo].[Enrollment]  WITH CHECK ADD  CONSTRAINT [FK_StudentID_Enrollment] FOREIGN KEY([FK_StudentID])
REFERENCES [dbo].[Students] ([StudentID])
GO
ALTER TABLE [dbo].[Enrollment] CHECK CONSTRAINT [FK_StudentID_Enrollment]
GO
ALTER TABLE [dbo].[Grade]  WITH CHECK ADD  CONSTRAINT [Grade_StudentID] FOREIGN KEY([FK_StudentID])
REFERENCES [dbo].[Students] ([StudentID])
GO
ALTER TABLE [dbo].[Grade] CHECK CONSTRAINT [Grade_StudentID]
GO
ALTER TABLE [dbo].[GradeDetails]  WITH CHECK ADD  CONSTRAINT [GradeDetails_FK_CourseID] FOREIGN KEY([FK_CourseID])
REFERENCES [dbo].[Course] ([CourseID])
GO
ALTER TABLE [dbo].[GradeDetails] CHECK CONSTRAINT [GradeDetails_FK_CourseID]
GO
ALTER TABLE [dbo].[GradeDetails]  WITH CHECK ADD  CONSTRAINT [GradeDetails_FK_Grade] FOREIGN KEY([FK_GradeID])
REFERENCES [dbo].[Grade] ([GradeID])
GO
ALTER TABLE [dbo].[GradeDetails] CHECK CONSTRAINT [GradeDetails_FK_Grade]
GO
ALTER TABLE [dbo].[GradeDetails]  WITH CHECK ADD  CONSTRAINT [GradeDetails_StudentID] FOREIGN KEY([FK_StudentID])
REFERENCES [dbo].[Students] ([StudentID])
GO
ALTER TABLE [dbo].[GradeDetails] CHECK CONSTRAINT [GradeDetails_StudentID]
GO
ALTER TABLE [dbo].[Staff_Professions]  WITH CHECK ADD  CONSTRAINT [FK_Staff_Professions_ProfessionID] FOREIGN KEY([FK_ProfessionID])
REFERENCES [dbo].[Professions] ([ProfessionID])
GO
ALTER TABLE [dbo].[Staff_Professions] CHECK CONSTRAINT [FK_Staff_Professions_ProfessionID]
GO
ALTER TABLE [dbo].[Staff_Professions]  WITH CHECK ADD  CONSTRAINT [FK_Staff_Professions_StaffID] FOREIGN KEY([FK_StaffID])
REFERENCES [dbo].[Staff] ([StaffID])
GO
ALTER TABLE [dbo].[Staff_Professions] CHECK CONSTRAINT [FK_Staff_Professions_StaffID]
GO
USE [master]
GO
ALTER DATABASE [SchoolLabb2] SET  READ_WRITE 
GO
