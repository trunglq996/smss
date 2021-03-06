USE [smss]
GO
/****** Object:  Table [dbo].[grade]    Script Date: 02/17/2019 17:51:05 ******/
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
PRIMARY KEY CLUSTERED 
(
	[code] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[grade] ([code], [name], [yearin], [yearout], [note]) VALUES (N'1902170001', N'Khóa 12', 2012, 2018, N'123')
INSERT [dbo].[grade] ([code], [name], [yearin], [yearout], [note]) VALUES (N'1902170002', N'Khóa 13', 2013, 2020, N'')
INSERT [dbo].[grade] ([code], [name], [yearin], [yearout], [note]) VALUES (N'k15', N'Khóa 15', 2014, 2019, N'test')
/****** Object:  Table [dbo].[class]    Script Date: 02/17/2019 17:51:05 ******/
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
PRIMARY KEY CLUSTERED 
(
	[code] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[class] ([code], [name], [note], [staffcode], [gradecode]) VALUES (N'CNTT', N'Công nghệ thông tin', N'Ghi chú', NULL, N'1902170001')
/****** Object:  Table [dbo].[student]    Script Date: 02/17/2019 17:51:05 ******/
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
PRIMARY KEY CLUSTERED 
(
	[code] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[staff]    Script Date: 02/17/2019 17:51:05 ******/
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
/****** Object:  StoredProcedure [dbo].[UpdateGrade]    Script Date: 02/17/2019 17:51:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UpdateGrade]
@code varchar(10),
@name nvarchar(200),
@yearin int,
@yearout int,
@note varchar(200)
as
update grade set name = @name,
yearin = @yearin,
yearout = @yearout,
note = @note
where code = @code
GO
/****** Object:  StoredProcedure [dbo].[InsertGrade]    Script Date: 02/17/2019 17:51:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[InsertGrade]
@code varchar(10),
@name nvarchar(200),
@yearin int,
@yearout int,
@note varchar(200)
as
insert into grade values(@code,@name,@yearin,@yearout,@note)
GO
