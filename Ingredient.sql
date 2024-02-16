USE [SG]
GO

/****** Object:  Table [dbo].[Ingredient]    Script Date: 16/02/2024 14:18:56 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Ingredient](
	[Id] [nvarchar](450) NOT NULL,
	[Nom] [nvarchar](max) NULL,
	[Prix] [varchar](400) NULL,
	[Dose] [int] NOT NULL,
	[RecetteId] [nvarchar](450) NULL,
 CONSTRAINT [PK_Ingredient] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Ingredient]  WITH CHECK ADD  CONSTRAINT [FK_Ingredient_Recette_RecetteId] FOREIGN KEY([RecetteId])
REFERENCES [dbo].[Ingredient] ([Id])
GO

ALTER TABLE [dbo].[Ingredient] CHECK CONSTRAINT [FK_Ingredient_Recette_RecetteId]
GO


