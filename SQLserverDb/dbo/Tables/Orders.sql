CREATE TABLE [dbo].[Orders] (
    [OrderId]       INT      NOT NULL,
    [PersonId]      INT      NOT NULL,
    [OrderDateTime] DATETIME NOT NULL
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_Order]
    ON [dbo].[Orders]([OrderId] ASC);

