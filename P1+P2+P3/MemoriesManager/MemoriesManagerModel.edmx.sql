
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/08/2020 19:09:04
-- Generated from EDMX file: C:\Users\alexa\source\repos\MemoriesManager\MemoriesManager\MemoriesManagerModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MemoriesManagerDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Files'
CREATE TABLE [dbo].[Files] (
    [FileId] int IDENTITY(1,1) NOT NULL,
    [Path] nvarchar(max)  NOT NULL,
    [Created_at] datetime  NOT NULL,
    [Type] nvarchar(max)  NOT NULL,
    [Path_changed] bit  NOT NULL,
    [Location] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Keywords'
CREATE TABLE [dbo].[Keywords] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Kword] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'People'
CREATE TABLE [dbo].[People] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [First_name] nvarchar(max)  NOT NULL,
    [Last_name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'FileKeyword'
CREATE TABLE [dbo].[FileKeyword] (
    [Files_FileId] int  NOT NULL,
    [Keywords_Id] int  NOT NULL
);
GO

-- Creating table 'FilePerson'
CREATE TABLE [dbo].[FilePerson] (
    [Files_FileId] int  NOT NULL,
    [People_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [FileId] in table 'Files'
ALTER TABLE [dbo].[Files]
ADD CONSTRAINT [PK_Files]
    PRIMARY KEY CLUSTERED ([FileId] ASC);
GO

-- Creating primary key on [Id] in table 'Keywords'
ALTER TABLE [dbo].[Keywords]
ADD CONSTRAINT [PK_Keywords]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'People'
ALTER TABLE [dbo].[People]
ADD CONSTRAINT [PK_People]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Files_FileId], [Keywords_Id] in table 'FileKeyword'
ALTER TABLE [dbo].[FileKeyword]
ADD CONSTRAINT [PK_FileKeyword]
    PRIMARY KEY CLUSTERED ([Files_FileId], [Keywords_Id] ASC);
GO

-- Creating primary key on [Files_FileId], [People_Id] in table 'FilePerson'
ALTER TABLE [dbo].[FilePerson]
ADD CONSTRAINT [PK_FilePerson]
    PRIMARY KEY CLUSTERED ([Files_FileId], [People_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Files_FileId] in table 'FileKeyword'
ALTER TABLE [dbo].[FileKeyword]
ADD CONSTRAINT [FK_FileKeyword_File]
    FOREIGN KEY ([Files_FileId])
    REFERENCES [dbo].[Files]
        ([FileId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Keywords_Id] in table 'FileKeyword'
ALTER TABLE [dbo].[FileKeyword]
ADD CONSTRAINT [FK_FileKeyword_Keyword]
    FOREIGN KEY ([Keywords_Id])
    REFERENCES [dbo].[Keywords]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FileKeyword_Keyword'
CREATE INDEX [IX_FK_FileKeyword_Keyword]
ON [dbo].[FileKeyword]
    ([Keywords_Id]);
GO

-- Creating foreign key on [Files_FileId] in table 'FilePerson'
ALTER TABLE [dbo].[FilePerson]
ADD CONSTRAINT [FK_FilePerson_File]
    FOREIGN KEY ([Files_FileId])
    REFERENCES [dbo].[Files]
        ([FileId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [People_Id] in table 'FilePerson'
ALTER TABLE [dbo].[FilePerson]
ADD CONSTRAINT [FK_FilePerson_Person]
    FOREIGN KEY ([People_Id])
    REFERENCES [dbo].[People]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FilePerson_Person'
CREATE INDEX [IX_FK_FilePerson_Person]
ON [dbo].[FilePerson]
    ([People_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------