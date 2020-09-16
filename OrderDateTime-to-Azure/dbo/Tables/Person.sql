CREATE TABLE [dbo].[Person] (
    [PersonId]  INT        NOT NULL,
    [NameFirst] NCHAR (25) NOT NULL,
    [NameLast]  NCHAR (25) NOT NULL,
    CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED ([PersonId] ASC)
);

