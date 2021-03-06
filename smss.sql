USE [smss]
GO
/****** Object:  Table [dbo].[grade]    Script Date: 02/20/2019 01:12:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[grade](
	[code] [varchar](10) NOT NULL,
	[name] [nvarchar](200) NULL,
	[yearin] [int] NULL,
	[yearout] [int] NULL,
	[note] [nvarchar](200) NULL,
	[codeview] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[code] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[grade] ([code], [name], [yearin], [yearout], [note], [codeview]) VALUES (N'1921900001', N'Khóa 12', 2012, 2018, N'2', N'K12')
INSERT [dbo].[grade] ([code], [name], [yearin], [yearout], [note], [codeview]) VALUES (N'1921900002', N'Khóa 13', 2013, 2019, N'1', N'k13')
/****** Object:  Table [dbo].[class]    Script Date: 02/20/2019 01:12:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[class](
	[code] [varchar](10) NOT NULL,
	[name] [nvarchar](200) NULL,
	[note] [nvarchar](200) NULL,
	[staffcode] [varchar](10) NULL,
	[gradecode] [varchar](10) NULL,
	[codeview] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[code] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[class] ([code], [name], [note], [staffcode], [gradecode], [codeview]) VALUES (N'1921900000', N'Công nghệ thông tin', N'', N'1', N'1921900001', N'cntt12')
INSERT [dbo].[class] ([code], [name], [note], [staffcode], [gradecode], [codeview]) VALUES (N'1921900002', N'Công nghệ phần mềm', N'1', N'1', N'1921900001', N'cnpm12')
INSERT [dbo].[class] ([code], [name], [note], [staffcode], [gradecode], [codeview]) VALUES (N'1921900003', N'Điện tử y sinh', N'', N'1', N'1921900001', N'dtys12')
/****** Object:  Table [dbo].[student]    Script Date: 02/20/2019 01:12:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[student](
	[code] [varchar](10) NOT NULL,
	[name] [nvarchar](200) NULL,
	[photo] [nvarchar](2000) NULL,
	[userpass] [varchar](200) NULL,
	[birthday] [date] NULL,
	[mark] [float] NULL,
	[gradecode] [varchar](10) NULL,
	[classcode] [varchar](10) NULL,
	[note] [nvarchar](200) NULL,
	[codeview] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[code] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[student] ([code], [name], [photo], [userpass], [birthday], [mark], [gradecode], [classcode], [note], [codeview]) VALUES (N'1', N'1', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[student] ([code], [name], [photo], [userpass], [birthday], [mark], [gradecode], [classcode], [note], [codeview]) VALUES (N'1922000000', N'lê quang trung', N'C:\Users\quang\Documents\GitHub\smss\smss\smss\image\1.jpg', NULL, CAST(0x553F0B00 AS Date), NULL, N'1921900001', N'1921900000', N'123', N'sv1')
INSERT [dbo].[student] ([code], [name], [photo], [userpass], [birthday], [mark], [gradecode], [classcode], [note], [codeview]) VALUES (N'1922000001', N'11', N'C:\Users\quang\Documents\GitHub\smss\smss\smss\image\1.jpg', NULL, CAST(0x553F0B00 AS Date), NULL, N'1921900001', N'1921900002', N'11', N'11')
INSERT [dbo].[student] ([code], [name], [photo], [userpass], [birthday], [mark], [gradecode], [classcode], [note], [codeview]) VALUES (N'1922000002', N'test', N'C:\Users\quang\Documents\GitHub\smss\smss\smss\image\1.jpg', NULL, CAST(0x553F0B00 AS Date), NULL, N'1921900001', N'1921900002', N'thử', N'3')
INSERT [dbo].[student] ([code], [name], [photo], [userpass], [birthday], [mark], [gradecode], [classcode], [note], [codeview]) VALUES (N'1922000003', N'2', N'', NULL, CAST(0x553F0B00 AS Date), NULL, N'1921900001', N'1921900000', N'', N'1')
/****** Object:  Table [dbo].[staff]    Script Date: 02/20/2019 01:12:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[staff](
	[code] [varchar](10) NOT NULL,
	[name] [nvarchar](200) NULL,
	[photo] [nvarchar](2000) NULL,
	[userpass] [varchar](200) NULL,
	[birthday] [date] NULL,
	[note] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[code] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[staff] ([code], [name], [photo], [userpass], [birthday], [note]) VALUES (N'1', N'Lê Quang Trung', NULL, N'1', CAST(0xBB1E0B00 AS Date), N'Không có ghi chú gì')
/****** Object:  StoredProcedure [dbo].[UpdateStudent]    Script Date: 02/20/2019 01:12:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UpdateStudent]
@code varchar(10),
@codeview varchar(20),
@name nvarchar(200),
@note nvarchar(200),
@photo nvarchar(2000),
@birthday date,
@gradecode varchar(10),
@classcode varchar(10)
as
update student
set codeview = @codeview,
name = @name,
note = @note,
photo = @photo,
birthday = @birthday,
gradecode = @gradecode,
classcode = @classcode
where code = @code
GO
/****** Object:  StoredProcedure [dbo].[UpdateGrade]    Script Date: 02/20/2019 01:12:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[UpdateGrade]
@code varchar(10),
@name nvarchar(200),
@yearin int,
@yearout int,
@note varchar(200),
@codeview varchar(20)
as
update grade set name = @name,
yearin = @yearin,
yearout = @yearout,
note = @note,
codeview = @codeview
where code = @code
GO
/****** Object:  StoredProcedure [dbo].[UpdateClass]    Script Date: 02/20/2019 01:12:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[UpdateClass]
@code varchar(10),
@name nvarchar(200),
@note nvarchar(200),
@staffcode varchar(10),
@gradecode varchar(10),
@codeview varchar(20)
as
update class set name = @name,
note = @note,
staffcode = @staffcode,
gradecode = @gradecode,
codeview = @codeview
where code = @code
GO
/****** Object:  StoredProcedure [dbo].[InsertStudent]    Script Date: 02/20/2019 01:12:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[InsertStudent]
@code varchar(10),
@codeview varchar(20),
@name nvarchar(200),
@note nvarchar(200),
@photo nvarchar(2000),
@birthday date,
@gradecode varchar(10),
@classcode varchar(10)
as
insert into student values(@code,@name,@photo,null,@birthday,null,@gradecode,@classcode,@note,@codeview)
GO
/****** Object:  StoredProcedure [dbo].[InsertGrade]    Script Date: 02/20/2019 01:12:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[InsertGrade]
@code varchar(10),
@name nvarchar(200),
@yearin int,
@yearout int,
@note varchar(200),
@codeview varchar(20)
as
insert into grade values(@code,@name,@yearin,@yearout,@note,@codeview)
GO
/****** Object:  StoredProcedure [dbo].[InsertClass]    Script Date: 02/20/2019 01:12:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[InsertClass]
@code varchar(10),
@name nvarchar(200),
@note nvarchar(200),
@staffcode varchar(10),
@gradecode varchar(10),
@codeview varchar(20)
as
insert into class values(@code,@name,@note,@staffcode,@gradecode,@codeview)
GO
