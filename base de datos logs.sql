Use fileLogger
Go
CREATE TABLE [Logs](
[ID] int IDENTITY(1,1) NOT NULL,
[Level] [varchar](255) NOT NULL,
[CallSite] [varchar](255) NOT NULL,
[Type] [varchar](255) NOT NULL,
[Message] [varchar](255) NOT NULL,
[StackTrace] [varchar](max) NOT NULL,
[InnerException] [varchar](max) NOT NULL,
[AdditionalInfo] [varchar](max) NOT NULL,
[LoggedOnDate] [datetime] NOT NULL,
CONSTRAINT [PK_Logs] PRIMARY KEY CLUSTERED
(
[ID] ASC
)--se pude hacer un WITH PAD_INDEX
)ON [PRIMARY]
ALTER TABLE [dbo].[Logs] ADD CONSTRAINT [DF_Logs_TimeStamp] DEFAULT (getdate()) FOR [LoggedOnDate]
Go

CREATE PROCEDURE [dbo].[InsertLog]
(
	@level varchar(20),
	@callSite varchar(max),
	@type varchar(max),
	@message varchar(max),
	@stackTrace varchar(max),
	@innerException varchar(max),
	@additionalInfo varchar(max)
)
AS
	INSERT INTO [dbo].Logs
	(
		[Level],
		CallSite,
		[Type],
		[Message],
		StackTrace,
		InnerException,
		AdditionalInfo
	)
	VALUES
	(
		@level,
		@callSite,
		@type,
		@message,
		@stackTrace,
		@innerException,
		@additionalInfo
	)
GO