CREATE TABLE [dbo].Posts(
    Id uniqueidentifier NOT NULL PRIMARY KEY,
    Text NVARCHAR(MAX) NOT NULL,
    AddedDate datetime2
);