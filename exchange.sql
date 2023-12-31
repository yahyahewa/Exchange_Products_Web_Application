USE [exch]
GO
/****** Object:  Table [dbo].[act]    Script Date: 7/24/2023 3:28:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[act](
	[username] [nvarchar](25) NOT NULL,
	[name] [nvarchar](max) NOT NULL,
	[pass] [nvarchar](max) NOT NULL,
	[joined] [time](7) NOT NULL CONSTRAINT [DF__act__joined__108B795B]  DEFAULT (getdate()),
	[adr] [nvarchar](max) NOT NULL CONSTRAINT [DF__act__adr__117F9D94]  DEFAULT ('-'),
 CONSTRAINT [PK__act__F3DBC57321791DA0] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[email]    Script Date: 7/24/2023 3:28:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[email](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[acc_id] [nvarchar](25) NOT NULL,
	[email] [nvarchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[exch_]    Script Date: 7/24/2023 3:28:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[exch_](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_item] [int] NOT NULL,
	[ex_to] [nvarchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[item]    Script Date: 7/24/2023 3:28:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[item](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[acc_id] [nvarchar](25) NOT NULL,
	[name] [nvarchar](max) NOT NULL,
	[price] [money] NOT NULL CONSTRAINT [DF__item__price__1A14E395]  DEFAULT ((0)),
	[img] [image] NOT NULL,
	[type] [nvarchar](max) NOT NULL,
	[info] [nvarchar](max) NOT NULL CONSTRAINT [DF__item__info__1B0907CE]  DEFAULT ('-'),
 CONSTRAINT [PK__item__3213E83F1DEA65B9] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[phnum]    Script Date: 7/24/2023 3:28:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[phnum](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[acc_id] [nvarchar](25) NOT NULL,
	[ph] [nvarchar](11) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[ph] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[email]  WITH CHECK ADD  CONSTRAINT [FK__email__acc_id__173876EA] FOREIGN KEY([acc_id])
REFERENCES [dbo].[act] ([username])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[email] CHECK CONSTRAINT [FK__email__acc_id__173876EA]
GO
ALTER TABLE [dbo].[exch_]  WITH CHECK ADD FOREIGN KEY([id_item])
REFERENCES [dbo].[item] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[phnum]  WITH CHECK ADD FOREIGN KEY([acc_id])
REFERENCES [dbo].[act] ([username])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
