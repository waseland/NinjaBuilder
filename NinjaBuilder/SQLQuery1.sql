CREATE TABLE [dbo].[Categories] ( 
    [Categorieid] [int] NOT NULL IDENTITY(1,1),
    [Naam] [nvarchar](max), 
    CONSTRAINT [PK_dbo.Categories] PRIMARY KEY ([Categorieid]) 
) 

CREATE TABLE [dbo].[Equipments] ( 
	[Equipmentid] [int] NOT NULL IDENTITY(1,1),
    [Categorieid] [int] NOT NULL, 
    [Naam] [nvarchar](max), 
    CONSTRAINT [PK_dbo.Equipments] PRIMARY KEY ([Equipmentid]) 

) 

CREATE INDEX [IX_CategoryId] ON [dbo].[Equipments]([Categorieid]) 
ALTER TABLE [dbo].[Equipments] ADD CONSTRAINT [FK_dbo.Equipmentid_dbo.Categories_Categorieid] FOREIGN KEY ([Categorieid]) REFERENCES [dbo].[Categories] ([Categorieid]) ON DELETE CASCADE