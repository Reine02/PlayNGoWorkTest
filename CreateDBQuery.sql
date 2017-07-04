USE MadelieneDB
GO

CREATE TABLE [dbo.Members]
(
	[MemberID] int IDENTITY (1,1) NOT NULL,
	[Lastname] varchar(50) NOT NULL,
	[Firstname] varchar (50) NOT NULL,
	[Middlename] varchar (50) NULL,
	[Startdate] datetime,
	[Enddate] datetime,
	[Course] varchar (100) NOT NULL,
	[Assignment] varchar (100) NOT NULL,
	PRIMARY KEY (MemberID)
)