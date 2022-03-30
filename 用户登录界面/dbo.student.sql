CREATE TABLE [dbo].[student] (
    [id]     NCHAR(10)        NOT NULL,
    [name]   NCHAR (10) NULL,
    [cource] NCHAR(10) NULL,
    CONSTRAINT [PK_student] PRIMARY KEY CLUSTERED ([id] ASC)
);

