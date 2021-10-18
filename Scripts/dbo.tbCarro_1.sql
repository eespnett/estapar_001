alter TABLE [dbo].[tbCarro] (
    [Id]          INT          NULL IDENTITY,
    [MarcaCarro]  VARCHAR (50) NULL,
    [ModeloCarro] VARCHAR (50) NULL,
    [PlacaCarro]  VARCHAR (20) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

