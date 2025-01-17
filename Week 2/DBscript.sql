USE [Lab2_Home]
GO
/****** Object:  Table [dbo].[Attendance]    Script Date: 28/01/2024 7:16:25 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Attendance](
	[StudentRegNo] [nchar](10) NULL,
	[TimeStamp] [time](7) NULL,
	[Status] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Course]    Script Date: 28/01/2024 7:16:25 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Course](
	[Name] [nchar](10) NULL,
	[Code] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Enrollments]    Script Date: 28/01/2024 7:16:25 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Enrollments](
	[StudentRegNo] [nchar](10) NULL,
	[CourseName] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 28/01/2024 7:16:25 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[RegisterationNumber] [nchar](10) NULL,
	[Name] [nchar](10) NULL,
	[Department] [nchar](10) NULL,
	[Session] [nchar](10) NULL,
	[Address] [nchar](10) NULL
) ON [PRIMARY]
GO
