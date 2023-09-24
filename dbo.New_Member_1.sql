CREATE TABLE [dbo].[New_Member] (
    [Id]             INT          NOT NULL,
    [First Name]     VARCHAR (50) NOT NULL,
    [LastName]       VARCHAR (50) NOT NULL,
    [Gender]         VARCHAR (50) NOT NULL,
    [DateofBirth]    INT          NOT NULL,
    [MobileNo]       BIGINT       NOT NULL,
    [Email]          VARCHAR (50) NULL,
    [JoinDate]       DATE NOT NULL,
    [City]           VARCHAR (50) NOT NULL,
    [Weight]         INT          NOT NULL,
    [Time]           VARCHAR (50) NOT NULL,
    [Address]        VARCHAR (50) NOT NULL,
    [MemberShipTime] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

