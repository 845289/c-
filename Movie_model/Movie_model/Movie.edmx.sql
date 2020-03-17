
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/28/2020 09:30:17
-- Generated from EDMX file: C:\Users\Admin\source\repos\Movie_model\Movie_model\Movie.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Movie];
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

-- Creating table 'Movies'
CREATE TABLE [dbo].[Movies] (
    [MId] int IDENTITY(1,1) NOT NULL,
    [Mname] nvarchar(max)  NOT NULL,
    [Price] decimal(18,0)  NOT NULL
);
GO

-- Creating table 'Theatres'
CREATE TABLE [dbo].[Theatres] (
    [TId] int IDENTITY(1,1) NOT NULL,
    [Tname] nvarchar(max)  NOT NULL,
    [Tlocation] nvarchar(max)  NOT NULL,
    [MovieMId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [MId] in table 'Movies'
ALTER TABLE [dbo].[Movies]
ADD CONSTRAINT [PK_Movies]
    PRIMARY KEY CLUSTERED ([MId] ASC);
GO

-- Creating primary key on [TId] in table 'Theatres'
ALTER TABLE [dbo].[Theatres]
ADD CONSTRAINT [PK_Theatres]
    PRIMARY KEY CLUSTERED ([TId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [MovieMId] in table 'Theatres'
ALTER TABLE [dbo].[Theatres]
ADD CONSTRAINT [FK_MovieTheatre]
    FOREIGN KEY ([MovieMId])
    REFERENCES [dbo].[Movies]
        ([MId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MovieTheatre'
CREATE INDEX [IX_FK_MovieTheatre]
ON [dbo].[Theatres]
    ([MovieMId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------