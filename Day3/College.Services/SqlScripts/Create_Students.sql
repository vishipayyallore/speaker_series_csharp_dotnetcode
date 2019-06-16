USE [Sample]
GO

ALTER TABLE [dbo].[Students] DROP CONSTRAINT [FK_Professors_Students]
GO

ALTER TABLE [dbo].[Students] DROP CONSTRAINT [DF_Students_Id]
GO

/****** Object:  Table [dbo].[Students]    Script Date: 6/16/2019 10:58:02 PM ******/
DROP TABLE [dbo].[Students]
GO

/****** Object:  Table [dbo].[Students]    Script Date: 6/16/2019 10:58:02 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Students](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [varchar](100) NULL,
	[RollNumber] [varchar](50) NULL,
	[ProfessorId] [uniqueidentifier] NOT NULL,
	[Dob] [datetime] NULL,
	[IsAthlete] [bit] NULL,
	[Fees] [numeric](18, 2) NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Students] ADD  CONSTRAINT [DF_Students_Id]  DEFAULT (newid()) FOR [Id]
GO

ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Professors_Students] FOREIGN KEY([ProfessorId])
REFERENCES [dbo].[Professors] ([Id])
GO

ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Professors_Students]
GO


