
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/18/2020 09:46:36
-- Generated from EDMX file: D:\project\c#\examodel\examodel\schoolexam.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Exam];
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

-- Creating table 'Students'
CREATE TABLE [dbo].[Students] (
    [Stid] int IDENTITY(1,1) NOT NULL,
    [Stname] nvarchar(max)  NOT NULL,
    [Course_cid] int  NOT NULL,
    [Exam_eid] int  NOT NULL
);
GO

-- Creating table 'Courses'
CREATE TABLE [dbo].[Courses] (
    [cid] int IDENTITY(1,1) NOT NULL,
    [cname] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Subjects'
CREATE TABLE [dbo].[Subjects] (
    [Suid] int IDENTITY(1,1) NOT NULL,
    [Suname] nvarchar(max)  NOT NULL,
    [Course_cid] int  NOT NULL,
    [SchoolScid] int  NOT NULL
);
GO

-- Creating table 'Invigilators'
CREATE TABLE [dbo].[Invigilators] (
    [Iid] int IDENTITY(1,1) NOT NULL,
    [Iname] nvarchar(max)  NOT NULL,
    [SchoolScid] int  NOT NULL
);
GO

-- Creating table 'Schools'
CREATE TABLE [dbo].[Schools] (
    [Scid] int IDENTITY(1,1) NOT NULL,
    [Scname] nvarchar(max)  NOT NULL,
    [Slocation] nvarchar(max)  NOT NULL,
    [Exam_eid] int  NOT NULL
);
GO

-- Creating table 'Exams'
CREATE TABLE [dbo].[Exams] (
    [eid] int IDENTITY(1,1) NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Stid] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [PK_Students]
    PRIMARY KEY CLUSTERED ([Stid] ASC);
GO

-- Creating primary key on [cid] in table 'Courses'
ALTER TABLE [dbo].[Courses]
ADD CONSTRAINT [PK_Courses]
    PRIMARY KEY CLUSTERED ([cid] ASC);
GO

-- Creating primary key on [Suid] in table 'Subjects'
ALTER TABLE [dbo].[Subjects]
ADD CONSTRAINT [PK_Subjects]
    PRIMARY KEY CLUSTERED ([Suid] ASC);
GO

-- Creating primary key on [Iid] in table 'Invigilators'
ALTER TABLE [dbo].[Invigilators]
ADD CONSTRAINT [PK_Invigilators]
    PRIMARY KEY CLUSTERED ([Iid] ASC);
GO

-- Creating primary key on [Scid] in table 'Schools'
ALTER TABLE [dbo].[Schools]
ADD CONSTRAINT [PK_Schools]
    PRIMARY KEY CLUSTERED ([Scid] ASC);
GO

-- Creating primary key on [eid] in table 'Exams'
ALTER TABLE [dbo].[Exams]
ADD CONSTRAINT [PK_Exams]
    PRIMARY KEY CLUSTERED ([eid] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Course_cid] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [FK_CourseStudent]
    FOREIGN KEY ([Course_cid])
    REFERENCES [dbo].[Courses]
        ([cid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CourseStudent'
CREATE INDEX [IX_FK_CourseStudent]
ON [dbo].[Students]
    ([Course_cid]);
GO

-- Creating foreign key on [Course_cid] in table 'Subjects'
ALTER TABLE [dbo].[Subjects]
ADD CONSTRAINT [FK_CourseSubject]
    FOREIGN KEY ([Course_cid])
    REFERENCES [dbo].[Courses]
        ([cid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CourseSubject'
CREATE INDEX [IX_FK_CourseSubject]
ON [dbo].[Subjects]
    ([Course_cid]);
GO

-- Creating foreign key on [SchoolScid] in table 'Invigilators'
ALTER TABLE [dbo].[Invigilators]
ADD CONSTRAINT [FK_SchoolInvigilator]
    FOREIGN KEY ([SchoolScid])
    REFERENCES [dbo].[Schools]
        ([Scid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SchoolInvigilator'
CREATE INDEX [IX_FK_SchoolInvigilator]
ON [dbo].[Invigilators]
    ([SchoolScid]);
GO

-- Creating foreign key on [Exam_eid] in table 'Schools'
ALTER TABLE [dbo].[Schools]
ADD CONSTRAINT [FK_ExamSchool]
    FOREIGN KEY ([Exam_eid])
    REFERENCES [dbo].[Exams]
        ([eid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ExamSchool'
CREATE INDEX [IX_FK_ExamSchool]
ON [dbo].[Schools]
    ([Exam_eid]);
GO

-- Creating foreign key on [SchoolScid] in table 'Subjects'
ALTER TABLE [dbo].[Subjects]
ADD CONSTRAINT [FK_SchoolSubject]
    FOREIGN KEY ([SchoolScid])
    REFERENCES [dbo].[Schools]
        ([Scid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SchoolSubject'
CREATE INDEX [IX_FK_SchoolSubject]
ON [dbo].[Subjects]
    ([SchoolScid]);
GO

-- Creating foreign key on [Exam_eid] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [FK_ExamStudent]
    FOREIGN KEY ([Exam_eid])
    REFERENCES [dbo].[Exams]
        ([eid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ExamStudent'
CREATE INDEX [IX_FK_ExamStudent]
ON [dbo].[Students]
    ([Exam_eid]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------