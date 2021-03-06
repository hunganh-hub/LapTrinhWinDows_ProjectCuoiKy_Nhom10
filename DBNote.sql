USE [DBDangNhap]
GO
/****** Object:  Table [dbo].[BangDangNhap]    Script Date: 6/25/2020 10:24:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BangDangNhap](
	[TenDangNhap] [nchar](50) NOT NULL,
	[MatKhau] [nchar](50) NULL,
 CONSTRAINT [PK_BangDangNhap] PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ContentNote]    Script Date: 6/25/2020 10:24:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContentNote](
	[ID] [int] NOT NULL,
	[Title] [nchar](100) NULL,
	[NoteContent] [nchar](100) NULL,
 CONSTRAINT [PK_ContentNote_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BangDangNhap] ([TenDangNhap], [MatKhau]) VALUES (N'a                                                 ', N'86f7e437faa5a7fce15d1ddcb9eaeaea377667b8          ')
INSERT [dbo].[BangDangNhap] ([TenDangNhap], [MatKhau]) VALUES (N'Anh                                               ', N'e0c95748a455c27a80fd289269120d4944d1f318          ')
INSERT [dbo].[BangDangNhap] ([TenDangNhap], [MatKhau]) VALUES (N'Anh1                                              ', N'258c4e653cbb9d5580da2e575814c56e1c6fe4fc          ')
INSERT [dbo].[BangDangNhap] ([TenDangNhap], [MatKhau]) VALUES (N'anh12                                             ', N'356a192b7913b04c54574d18c28d46e6395428ab          ')
INSERT [dbo].[BangDangNhap] ([TenDangNhap], [MatKhau]) VALUES (N'hunganh                                           ', N'9878e362285eb314cfdbaa8ee8c300c285856810          ')
INSERT [dbo].[BangDangNhap] ([TenDangNhap], [MatKhau]) VALUES (N'mai                                               ', N'356a192b7913b04c54574d18c28d46e6395428ab          ')
INSERT [dbo].[BangDangNhap] ([TenDangNhap], [MatKhau]) VALUES (N'Triều                                             ', N'85ce153eaf5767639a1855d8bbcffdf25ea323f3          ')
INSERT [dbo].[BangDangNhap] ([TenDangNhap], [MatKhau]) VALUES (N'xuan                                              ', N'356a192b7913b04c54574d18c28d46e6395428ab          ')
INSERT [dbo].[BangDangNhap] ([TenDangNhap], [MatKhau]) VALUES (N'xuang                                             ', N'603d6ae37af2b09b7bc8f7384840b4e4bb891aef          ')
GO
INSERT [dbo].[ContentNote] ([ID], [Title], [NoteContent]) VALUES (1, N'title1                                                                                              ', N'tran thi le xuan                                                                                    ')
INSERT [dbo].[ContentNote] ([ID], [Title], [NoteContent]) VALUES (2, N'title2                                                                                              ', N'truong hung anh                                                                                     ')
INSERT [dbo].[ContentNote] ([ID], [Title], [NoteContent]) VALUES (4, N'title3                                                                                              ', N'tran thi le xuan                                                                                    ')
INSERT [dbo].[ContentNote] ([ID], [Title], [NoteContent]) VALUES (5, N'note1                                                                                               ', N'mai                                                                                                 ')
GO
