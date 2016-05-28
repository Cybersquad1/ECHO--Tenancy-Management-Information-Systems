USE [Echo]
GO
/****** Object:  Table [dbo].[Reservation]    Script Date: 05/28/2016 22:30:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Reservation](
	[ID] [uniqueidentifier] NOT NULL,
	[Facility] [varchar](50) NOT NULL,
	[UnitNumber] [varchar](10) NOT NULL,
	[Purpose] [varchar](200) NOT NULL,
	[DateOfFuntion] [datetime] NOT NULL,
	[NoOfGuest] [varchar](3) NULL,
	[Time] [varchar](10) NULL,
	[ContactNo] [varchar](20) NULL,
	[Date] [datetime] NOT NULL,
	[Amount] [decimal](18, 2) NULL,
	[Balance] [decimal](18, 2) NULL,
	[Paid] [decimal](18, 2) NULL,
 CONSTRAINT [PK_Reservation] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserProfile]    Script Date: 05/28/2016 22:30:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserProfile](
	[ID] [uniqueidentifier] NOT NULL,
	[Username] [varchar](100) NOT NULL,
	[FirstName] [varchar](100) NOT NULL,
	[MiddleName] [varchar](100) NULL,
	[LastName] [varchar](100) NULL,
	[DateOfBirth] [datetime] NOT NULL,
	[MaritalStatus] [varchar](100) NOT NULL,
	[HomeAddress] [varchar](300) NOT NULL,
	[ProvincialAddress] [varchar](300) NULL,
	[Password] [varchar](100) NOT NULL,
	[MobileNo] [varchar](15) NULL,
	[TelephoneNo] [varchar](10) NULL,
	[Email] [varchar](100) NOT NULL,
	[ContactPerson] [varchar](150) NULL,
	[ContactNo] [varchar](15) NULL,
	[RelationshipToContact] [varchar](100) NULL,
	[ImageContent] [image] NULL,
	[Status] [varchar](1) NULL,
	[Type] [varchar](20) NULL,
	[IfGeneratedPassword] [varchar](1) NULL,
	[FullName] [varchar](300) NULL,
 CONSTRAINT [PK_UserAccount] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UnitProfile]    Script Date: 05/28/2016 22:30:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UnitProfile](
	[UnitNumber] [varchar](5) NOT NULL,
	[StartOfOccupancy] [datetime] NULL,
	[ExpectedEndOfOccupancy] [datetime] NULL,
	[Owner] [uniqueidentifier] NULL,
	[Tenant] [uniqueidentifier] NULL,
	[NatureOfOccupancy] [varchar](50) NULL,
	[Type] [varchar](50) NULL,
	[Floor] [varchar](3) NULL,
 CONSTRAINT [PK_UnitProfile] PRIMARY KEY CLUSTERED 
(
	[UnitNumber] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TenantProfile]    Script Date: 05/28/2016 22:30:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TenantProfile](
	[ID] [uniqueidentifier] NOT NULL,
	[Username] [varchar](100) NULL,
	[FirstName] [varchar](100) NULL,
	[MiddleName] [varchar](100) NULL,
	[LastName] [varchar](100) NULL,
	[DateOfBirth] [datetime] NULL,
	[MaritalStatus] [varchar](100) NULL,
	[NatureOfOccupancy] [varchar](150) NULL,
	[HomeAddress] [varchar](300) NULL,
	[ProvincialAddress] [varchar](300) NULL,
	[MobileNo] [varchar](15) NULL,
	[TelephoneNo] [varchar](10) NULL,
	[Email] [varchar](100) NULL,
	[WithOtherOccupants] [varchar](1) NULL,
	[WithPets] [varchar](1) NULL,
	[WithFireExtinguisher] [varchar](1) NULL,
	[Password] [varchar](50) NULL,
	[ImageLocation] [image] NULL,
	[UnitNumber] [varchar](5) NULL,
	[Status] [varchar](1) NULL,
	[OtherName1] [varchar](150) NULL,
	[OtherRelation1] [varchar](100) NULL,
	[OtherDateOfBirth1] [datetime] NULL,
	[OtherName2] [varchar](150) NULL,
	[OtherRelation2] [varchar](100) NULL,
	[OtherDateOfBirth2] [datetime] NULL,
	[OtherName3] [varchar](150) NULL,
	[OtherRelation3] [varchar](100) NULL,
	[OtherDateOfBirth3] [datetime] NULL,
	[PetQuantity] [varchar](2) NULL,
	[PetType] [varchar](100) NULL,
	[PetBreed] [varchar](100) NULL,
	[PetName] [varchar](300) NULL,
	[StartOfOccupancy] [datetime] NULL,
	[EndOfOccupancy] [datetime] NULL,
	[ChangePassword] [varchar](1) NULL,
 CONSTRAINT [PK_TenantProfile] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[WaterBilling]    Script Date: 05/28/2016 22:30:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[WaterBilling](
	[ID] [uniqueidentifier] NOT NULL,
	[UnitNumber] [varchar](5) NULL,
	[ChargeDate] [datetime] NULL,
	[DueDate] [datetime] NULL,
	[FromDate] [datetime] NULL,
	[ToDate] [datetime] NULL,
	[CurrentReading] [varchar](100) NULL,
	[TotalAmount] [decimal](18, 2) NULL,
	[OverdueAmount] [decimal](18, 2) NULL,
	[DisconnectionFee] [decimal](18, 2) NULL,
	[PreviousReading] [varchar](100) NULL,
	[PreviousAmount] [decimal](18, 2) NULL,
	[Paid] [decimal](18, 2) NULL,
	[Balance] [decimal](18, 2) NULL,
 CONSTRAINT [PK_WaterBilling] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TenantArchive]    Script Date: 05/28/2016 22:30:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TenantArchive](
	[ID] [uniqueidentifier] NOT NULL,
	[UnitNumber] [varchar](5) NULL,
	[StartOfOccupancy] [datetime] NULL,
	[EndOfOccupancy] [datetime] NULL,
	[NatureOfOccupancy] [varchar](150) NULL,
	[TenantID] [uniqueidentifier] NULL,
 CONSTRAINT [PK_TenantArchive] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LogSheet]    Script Date: 05/28/2016 22:30:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LogSheet](
	[ID] [uniqueidentifier] NOT NULL,
	[Item] [varchar](150) NULL,
	[Quantity] [int] NULL,
	[DateModified] [datetime] NULL,
	[ModifiedBy] [uniqueidentifier] NULL,
 CONSTRAINT [PK_LogSheet] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MonthlyAssociationDue]    Script Date: 05/28/2016 22:30:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MonthlyAssociationDue](
	[ID] [uniqueidentifier] NOT NULL,
	[UnitNumber] [varchar](5) NULL,
	[ChargeDate] [date] NULL,
	[DueDate] [date] NULL,
	[AssociationDue] [decimal](18, 2) NULL,
	[WaterBillTotalDue] [decimal](18, 2) NULL,
	[Discounts] [decimal](18, 2) NULL,
	[Penalty] [decimal](18, 2) NULL,
	[OtherPenalty] [varchar](100) NULL,
	[OtherPenaltyAmount] [decimal](18, 2) NULL,
	[TotalAmount] [decimal](18, 2) NULL,
	[Balance] [decimal](18, 2) NULL,
	[Paid] [decimal](18, 2) NULL,
	[WaterCurrentReading] [varchar](50) NULL,
	[WaterPreviousReading] [varchar](50) NULL,
	[WaterDate] [date] NULL,
 CONSTRAINT [PK_MonthlyAssociationDue] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Request]    Script Date: 05/28/2016 22:30:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Request](
	[ID] [uniqueidentifier] NOT NULL,
	[Project] [varchar](200) NOT NULL,
	[UnitNumber] [varchar](5) NOT NULL,
	[Date] [datetime] NOT NULL,
	[Owner] [varchar](200) NOT NULL,
	[ContactNo] [varchar](10) NULL,
	[ScheduleDate] [datetime] NOT NULL,
	[Time] [varchar](10) NOT NULL,
	[Request1] [varchar](200) NULL,
	[Request2] [varchar](200) NULL,
	[Request3] [varchar](200) NULL,
	[Request4] [varchar](200) NULL,
 CONSTRAINT [PK_Request] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PaymentHistory]    Script Date: 05/28/2016 22:30:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PaymentHistory](
	[ID] [uniqueidentifier] NOT NULL,
	[ChargeDate] [datetime] NULL,
	[TotalPayment] [decimal](18, 2) NULL,
	[MonthlyAssocID] [uniqueidentifier] NULL,
	[Payable] [decimal](18, 2) NULL,
	[Balance] [decimal](18, 2) NULL,
	[UnitNumber] [varchar](10) NULL,
	[ReservationID] [uniqueidentifier] NULL,
	[Date] [datetime] NULL,
	[Type] [varchar](50) NULL,
 CONSTRAINT [PK_PaymentHistory] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LogSheetActivity]    Script Date: 05/28/2016 22:30:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LogSheetActivity](
	[ID] [uniqueidentifier] NOT NULL,
	[Date] [datetime] NULL,
	[ItemID] [uniqueidentifier] NULL,
	[Balance] [int] NULL,
	[Quantity] [int] NULL,
	[Purpose] [varchar](150) NULL,
	[Area] [varchar](100) NULL,
	[IssuedBy] [uniqueidentifier] NULL,
	[ReceivedBy] [varchar](150) NULL,
 CONSTRAINT [PK_LogSheetActivity] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  ForeignKey [FK_LogSheet_UserProfile]    Script Date: 05/28/2016 22:30:35 ******/
ALTER TABLE [dbo].[LogSheet]  WITH CHECK ADD  CONSTRAINT [FK_LogSheet_UserProfile] FOREIGN KEY([ModifiedBy])
REFERENCES [dbo].[UserProfile] ([ID])
GO
ALTER TABLE [dbo].[LogSheet] CHECK CONSTRAINT [FK_LogSheet_UserProfile]
GO
/****** Object:  ForeignKey [FK_LogSheetActivity_LogSheet]    Script Date: 05/28/2016 22:30:35 ******/
ALTER TABLE [dbo].[LogSheetActivity]  WITH CHECK ADD  CONSTRAINT [FK_LogSheetActivity_LogSheet] FOREIGN KEY([ItemID])
REFERENCES [dbo].[LogSheet] ([ID])
GO
ALTER TABLE [dbo].[LogSheetActivity] CHECK CONSTRAINT [FK_LogSheetActivity_LogSheet]
GO
/****** Object:  ForeignKey [FK_LogSheetActivity_UserProfile]    Script Date: 05/28/2016 22:30:35 ******/
ALTER TABLE [dbo].[LogSheetActivity]  WITH CHECK ADD  CONSTRAINT [FK_LogSheetActivity_UserProfile] FOREIGN KEY([IssuedBy])
REFERENCES [dbo].[UserProfile] ([ID])
GO
ALTER TABLE [dbo].[LogSheetActivity] CHECK CONSTRAINT [FK_LogSheetActivity_UserProfile]
GO
/****** Object:  ForeignKey [FK_MonthlyAssociationDue_UnitProfile]    Script Date: 05/28/2016 22:30:35 ******/
ALTER TABLE [dbo].[MonthlyAssociationDue]  WITH CHECK ADD  CONSTRAINT [FK_MonthlyAssociationDue_UnitProfile] FOREIGN KEY([UnitNumber])
REFERENCES [dbo].[UnitProfile] ([UnitNumber])
GO
ALTER TABLE [dbo].[MonthlyAssociationDue] CHECK CONSTRAINT [FK_MonthlyAssociationDue_UnitProfile]
GO
/****** Object:  ForeignKey [FK_PaymentHistory_MonthlyAssociationDue]    Script Date: 05/28/2016 22:30:35 ******/
ALTER TABLE [dbo].[PaymentHistory]  WITH CHECK ADD  CONSTRAINT [FK_PaymentHistory_MonthlyAssociationDue] FOREIGN KEY([MonthlyAssocID])
REFERENCES [dbo].[MonthlyAssociationDue] ([ID])
GO
ALTER TABLE [dbo].[PaymentHistory] CHECK CONSTRAINT [FK_PaymentHistory_MonthlyAssociationDue]
GO
/****** Object:  ForeignKey [FK_PaymentHistory_Reservation]    Script Date: 05/28/2016 22:30:35 ******/
ALTER TABLE [dbo].[PaymentHistory]  WITH CHECK ADD  CONSTRAINT [FK_PaymentHistory_Reservation] FOREIGN KEY([ReservationID])
REFERENCES [dbo].[Reservation] ([ID])
GO
ALTER TABLE [dbo].[PaymentHistory] CHECK CONSTRAINT [FK_PaymentHistory_Reservation]
GO
/****** Object:  ForeignKey [FK_Request_UnitProfile]    Script Date: 05/28/2016 22:30:35 ******/
ALTER TABLE [dbo].[Request]  WITH CHECK ADD  CONSTRAINT [FK_Request_UnitProfile] FOREIGN KEY([UnitNumber])
REFERENCES [dbo].[UnitProfile] ([UnitNumber])
GO
ALTER TABLE [dbo].[Request] CHECK CONSTRAINT [FK_Request_UnitProfile]
GO
/****** Object:  ForeignKey [FK_TenantArchive_UnitProfile]    Script Date: 05/28/2016 22:30:35 ******/
ALTER TABLE [dbo].[TenantArchive]  WITH CHECK ADD  CONSTRAINT [FK_TenantArchive_UnitProfile] FOREIGN KEY([UnitNumber])
REFERENCES [dbo].[UnitProfile] ([UnitNumber])
GO
ALTER TABLE [dbo].[TenantArchive] CHECK CONSTRAINT [FK_TenantArchive_UnitProfile]
GO
/****** Object:  ForeignKey [FK_WaterBilling_UnitProfile]    Script Date: 05/28/2016 22:30:35 ******/
ALTER TABLE [dbo].[WaterBilling]  WITH CHECK ADD  CONSTRAINT [FK_WaterBilling_UnitProfile] FOREIGN KEY([UnitNumber])
REFERENCES [dbo].[UnitProfile] ([UnitNumber])
GO
ALTER TABLE [dbo].[WaterBilling] CHECK CONSTRAINT [FK_WaterBilling_UnitProfile]
GO
