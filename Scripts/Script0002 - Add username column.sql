ALTER TABLE [dbo].Posts
    ADD Username NVARCHAR(MAX) NOT NULL
    CONSTRAINT Username_def DEFAULT N'Anonymours';