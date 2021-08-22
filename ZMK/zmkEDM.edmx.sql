
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/18/2021 16:10:13
-- Generated from EDMX file: C:\Users\kiril\source\repos\ZMK\ZMK\zmkEDM.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [zmk];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_InstrumentTechOps]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TechOpsSet] DROP CONSTRAINT [FK_InstrumentTechOps];
GO
IF OBJECT_ID(N'[dbo].[FK_JobTitleTP]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TPSet] DROP CONSTRAINT [FK_JobTitleTP];
GO
IF OBJECT_ID(N'[dbo].[FK_fkLaborObjectsTechOps]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TechOpsSet] DROP CONSTRAINT [FK_fkLaborObjectsTechOps];
GO
IF OBJECT_ID(N'[dbo].[fk_ManufacturingStepsTP]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TPSet] DROP CONSTRAINT [fk_ManufacturingStepsTP];
GO
IF OBJECT_ID(N'[dbo].[FK_fkProjectTP]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TPSet] DROP CONSTRAINT [FK_fkProjectTP];
GO
IF OBJECT_ID(N'[dbo].[FK_TimeNormTechOps]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TechOpsSet] DROP CONSTRAINT [FK_TimeNormTechOps];
GO
IF OBJECT_ID(N'[dbo].[FK_TPTechOps]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TechOpsSet] DROP CONSTRAINT [FK_TPTechOps];
GO
IF OBJECT_ID(N'[dbo].[FK_WorkTypeTimeNorm]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TimeNormSet] DROP CONSTRAINT [FK_WorkTypeTimeNorm];
GO
IF OBJECT_ID(N'[dbo].[FK_fkWorkTypeTP]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TPSet] DROP CONSTRAINT [FK_fkWorkTypeTP];
GO
IF OBJECT_ID(N'[dbo].[FK_ProjectSetProjectStep]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProjectStepSet] DROP CONSTRAINT [FK_ProjectSetProjectStep];
GO
IF OBJECT_ID(N'[dbo].[FK_ManufacturingStepsSetProjectStep]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProjectStepSet] DROP CONSTRAINT [FK_ManufacturingStepsSetProjectStep];
GO
IF OBJECT_ID(N'[dbo].[FK_ProjectStepProjectStep]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProjectStepSet] DROP CONSTRAINT [FK_ProjectStepProjectStep];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[InstrumentSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[InstrumentSet];
GO
IF OBJECT_ID(N'[dbo].[JobTitleSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[JobTitleSet];
GO
IF OBJECT_ID(N'[dbo].[LaborObjectsSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LaborObjectsSet];
GO
IF OBJECT_ID(N'[dbo].[ManufacturingStepsSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ManufacturingStepsSet];
GO
IF OBJECT_ID(N'[dbo].[ProjectSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProjectSet];
GO
IF OBJECT_ID(N'[dbo].[TechOpsSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TechOpsSet];
GO
IF OBJECT_ID(N'[dbo].[TimeNormSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TimeNormSet];
GO
IF OBJECT_ID(N'[dbo].[TPSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TPSet];
GO
IF OBJECT_ID(N'[dbo].[WorkTypeSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[WorkTypeSet];
GO
IF OBJECT_ID(N'[dbo].[ProjectStepSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProjectStepSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'InstrumentSet'
CREATE TABLE [dbo].[InstrumentSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'JobTitleSet'
CREATE TABLE [dbo].[JobTitleSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'LaborObjectsSet'
CREATE TABLE [dbo].[LaborObjectsSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ManufacturingStepsSet'
CREATE TABLE [dbo].[ManufacturingStepsSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ProjectSet'
CREATE TABLE [dbo].[ProjectSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [description] nvarchar(max)  NULL,
    [params] nvarchar(max)  NULL,
    [create_time] datetime  NOT NULL,
    [update_time] datetime  NOT NULL
);
GO

-- Creating table 'TechOpsSet'
CREATE TABLE [dbo].[TechOpsSet] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [LaborObjectsId] int  NOT NULL,
    [InstrumentId] int  NOT NULL,
    [TPId] bigint  NOT NULL,
    [TimeNormId] bigint  NOT NULL
);
GO

-- Creating table 'TimeNormSet'
CREATE TABLE [dbo].[TimeNormSet] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Norm] float  NOT NULL,
    [WorkTypeId] int  NOT NULL
);
GO

-- Creating table 'TPSet'
CREATE TABLE [dbo].[TPSet] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [ManufacturingStepsId] int  NOT NULL,
    [WorkTypeId] int  NOT NULL,
    [JobTitleId] int  NOT NULL,
    [ProjectId] int  NOT NULL
);
GO

-- Creating table 'WorkTypeSet'
CREATE TABLE [dbo].[WorkTypeSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ProjectStepSet'
CREATE TABLE [dbo].[ProjectStepSet] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [ProjectSetId] int  NOT NULL,
    [ManufacturingStepsSetId] int  NOT NULL,
    [ParentStepId] bigint  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'InstrumentSet'
ALTER TABLE [dbo].[InstrumentSet]
ADD CONSTRAINT [PK_InstrumentSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'JobTitleSet'
ALTER TABLE [dbo].[JobTitleSet]
ADD CONSTRAINT [PK_JobTitleSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'LaborObjectsSet'
ALTER TABLE [dbo].[LaborObjectsSet]
ADD CONSTRAINT [PK_LaborObjectsSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ManufacturingStepsSet'
ALTER TABLE [dbo].[ManufacturingStepsSet]
ADD CONSTRAINT [PK_ManufacturingStepsSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ProjectSet'
ALTER TABLE [dbo].[ProjectSet]
ADD CONSTRAINT [PK_ProjectSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TechOpsSet'
ALTER TABLE [dbo].[TechOpsSet]
ADD CONSTRAINT [PK_TechOpsSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TimeNormSet'
ALTER TABLE [dbo].[TimeNormSet]
ADD CONSTRAINT [PK_TimeNormSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TPSet'
ALTER TABLE [dbo].[TPSet]
ADD CONSTRAINT [PK_TPSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'WorkTypeSet'
ALTER TABLE [dbo].[WorkTypeSet]
ADD CONSTRAINT [PK_WorkTypeSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ProjectStepSet'
ALTER TABLE [dbo].[ProjectStepSet]
ADD CONSTRAINT [PK_ProjectStepSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [InstrumentId] in table 'TechOpsSet'
ALTER TABLE [dbo].[TechOpsSet]
ADD CONSTRAINT [FK_InstrumentTechOps]
    FOREIGN KEY ([InstrumentId])
    REFERENCES [dbo].[InstrumentSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_InstrumentTechOps'
CREATE INDEX [IX_FK_InstrumentTechOps]
ON [dbo].[TechOpsSet]
    ([InstrumentId]);
GO

-- Creating foreign key on [JobTitleId] in table 'TPSet'
ALTER TABLE [dbo].[TPSet]
ADD CONSTRAINT [FK_JobTitleTP]
    FOREIGN KEY ([JobTitleId])
    REFERENCES [dbo].[JobTitleSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_JobTitleTP'
CREATE INDEX [IX_FK_JobTitleTP]
ON [dbo].[TPSet]
    ([JobTitleId]);
GO

-- Creating foreign key on [LaborObjectsId] in table 'TechOpsSet'
ALTER TABLE [dbo].[TechOpsSet]
ADD CONSTRAINT [FK_fkLaborObjectsTechOps]
    FOREIGN KEY ([LaborObjectsId])
    REFERENCES [dbo].[LaborObjectsSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_fkLaborObjectsTechOps'
CREATE INDEX [IX_FK_fkLaborObjectsTechOps]
ON [dbo].[TechOpsSet]
    ([LaborObjectsId]);
GO

-- Creating foreign key on [ManufacturingStepsId] in table 'TPSet'
ALTER TABLE [dbo].[TPSet]
ADD CONSTRAINT [fk_ManufacturingStepsTP]
    FOREIGN KEY ([ManufacturingStepsId])
    REFERENCES [dbo].[ManufacturingStepsSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_ManufacturingStepsTP'
CREATE INDEX [IX_fk_ManufacturingStepsTP]
ON [dbo].[TPSet]
    ([ManufacturingStepsId]);
GO

-- Creating foreign key on [ProjectId] in table 'TPSet'
ALTER TABLE [dbo].[TPSet]
ADD CONSTRAINT [FK_fkProjectTP]
    FOREIGN KEY ([ProjectId])
    REFERENCES [dbo].[ProjectSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_fkProjectTP'
CREATE INDEX [IX_FK_fkProjectTP]
ON [dbo].[TPSet]
    ([ProjectId]);
GO

-- Creating foreign key on [TimeNormId] in table 'TechOpsSet'
ALTER TABLE [dbo].[TechOpsSet]
ADD CONSTRAINT [FK_TimeNormTechOps]
    FOREIGN KEY ([TimeNormId])
    REFERENCES [dbo].[TimeNormSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TimeNormTechOps'
CREATE INDEX [IX_FK_TimeNormTechOps]
ON [dbo].[TechOpsSet]
    ([TimeNormId]);
GO

-- Creating foreign key on [TPId] in table 'TechOpsSet'
ALTER TABLE [dbo].[TechOpsSet]
ADD CONSTRAINT [FK_TPTechOps]
    FOREIGN KEY ([TPId])
    REFERENCES [dbo].[TPSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TPTechOps'
CREATE INDEX [IX_FK_TPTechOps]
ON [dbo].[TechOpsSet]
    ([TPId]);
GO

-- Creating foreign key on [WorkTypeId] in table 'TimeNormSet'
ALTER TABLE [dbo].[TimeNormSet]
ADD CONSTRAINT [FK_WorkTypeTimeNorm]
    FOREIGN KEY ([WorkTypeId])
    REFERENCES [dbo].[WorkTypeSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_WorkTypeTimeNorm'
CREATE INDEX [IX_FK_WorkTypeTimeNorm]
ON [dbo].[TimeNormSet]
    ([WorkTypeId]);
GO

-- Creating foreign key on [WorkTypeId] in table 'TPSet'
ALTER TABLE [dbo].[TPSet]
ADD CONSTRAINT [FK_fkWorkTypeTP]
    FOREIGN KEY ([WorkTypeId])
    REFERENCES [dbo].[WorkTypeSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_fkWorkTypeTP'
CREATE INDEX [IX_FK_fkWorkTypeTP]
ON [dbo].[TPSet]
    ([WorkTypeId]);
GO

-- Creating foreign key on [ProjectSetId] in table 'ProjectStepSet'
ALTER TABLE [dbo].[ProjectStepSet]
ADD CONSTRAINT [FK_ProjectSetProjectStep]
    FOREIGN KEY ([ProjectSetId])
    REFERENCES [dbo].[ProjectSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProjectSetProjectStep'
CREATE INDEX [IX_FK_ProjectSetProjectStep]
ON [dbo].[ProjectStepSet]
    ([ProjectSetId]);
GO

-- Creating foreign key on [ManufacturingStepsSetId] in table 'ProjectStepSet'
ALTER TABLE [dbo].[ProjectStepSet]
ADD CONSTRAINT [FK_ManufacturingStepsSetProjectStep]
    FOREIGN KEY ([ManufacturingStepsSetId])
    REFERENCES [dbo].[ManufacturingStepsSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ManufacturingStepsSetProjectStep'
CREATE INDEX [IX_FK_ManufacturingStepsSetProjectStep]
ON [dbo].[ProjectStepSet]
    ([ManufacturingStepsSetId]);
GO

-- Creating foreign key on [ParentStepId] in table 'ProjectStepSet'
ALTER TABLE [dbo].[ProjectStepSet]
ADD CONSTRAINT [FK_ProjectStepProjectStep]
    FOREIGN KEY ([ParentStepId])
    REFERENCES [dbo].[ProjectStepSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProjectStepProjectStep'
CREATE INDEX [IX_FK_ProjectStepProjectStep]
ON [dbo].[ProjectStepSet]
    ([ParentStepId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------