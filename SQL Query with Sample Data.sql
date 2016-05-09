USE [Echo]
GO
ALTER TABLE [dbo].[WaterBilling] DROP CONSTRAINT [FK_WaterBilling_UnitProfile]
GO
ALTER TABLE [dbo].[TenantArchive] DROP CONSTRAINT [FK_TenantArchive_UnitProfile]
GO
ALTER TABLE [dbo].[PaymentHistory] DROP CONSTRAINT [FK_PaymentHistory_Reservation]
GO
ALTER TABLE [dbo].[PaymentHistory] DROP CONSTRAINT [FK_PaymentHistory_MonthlyAssociationDue]
GO
ALTER TABLE [dbo].[MonthlyAssociationDue] DROP CONSTRAINT [FK_MonthlyAssociationDue_UnitProfile]
GO
ALTER TABLE [dbo].[LogSheetActivity] DROP CONSTRAINT [FK_LogSheetActivity_UserProfile]
GO
ALTER TABLE [dbo].[LogSheetActivity] DROP CONSTRAINT [FK_LogSheetActivity_LogSheet]
GO
ALTER TABLE [dbo].[LogSheet] DROP CONSTRAINT [FK_LogSheet_UserProfile]
GO
/****** Object:  Table [dbo].[WaterBilling]    Script Date: 5/9/2016 4:19:36 PM ******/
DROP TABLE [dbo].[WaterBilling]
GO
/****** Object:  Table [dbo].[UserProfile]    Script Date: 5/9/2016 4:19:36 PM ******/
DROP TABLE [dbo].[UserProfile]
GO
/****** Object:  Table [dbo].[UnitProfile]    Script Date: 5/9/2016 4:19:36 PM ******/
DROP TABLE [dbo].[UnitProfile]
GO
/****** Object:  Table [dbo].[TenantProfile]    Script Date: 5/9/2016 4:19:36 PM ******/
DROP TABLE [dbo].[TenantProfile]
GO
/****** Object:  Table [dbo].[TenantArchive]    Script Date: 5/9/2016 4:19:36 PM ******/
DROP TABLE [dbo].[TenantArchive]
GO
/****** Object:  Table [dbo].[Reservation]    Script Date: 5/9/2016 4:19:36 PM ******/
DROP TABLE [dbo].[Reservation]
GO
/****** Object:  Table [dbo].[PaymentHistory]    Script Date: 5/9/2016 4:19:36 PM ******/
DROP TABLE [dbo].[PaymentHistory]
GO
/****** Object:  Table [dbo].[MonthlyAssociationDue]    Script Date: 5/9/2016 4:19:36 PM ******/
DROP TABLE [dbo].[MonthlyAssociationDue]
GO
/****** Object:  Table [dbo].[LogSheetActivity]    Script Date: 5/9/2016 4:19:36 PM ******/
DROP TABLE [dbo].[LogSheetActivity]
GO
/****** Object:  Table [dbo].[LogSheet]    Script Date: 5/9/2016 4:19:36 PM ******/
DROP TABLE [dbo].[LogSheet]
GO
/****** Object:  Table [dbo].[LogSheet]    Script Date: 5/9/2016 4:19:36 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LogSheetActivity]    Script Date: 5/9/2016 4:19:36 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MonthlyAssociationDue]    Script Date: 5/9/2016 4:19:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MonthlyAssociationDue](
	[ID] [uniqueidentifier] NOT NULL,
	[UnitNumber] [varchar](5) NULL,
	[ChargeDate] [datetime] NULL,
	[DueDate] [datetime] NULL,
	[AssociationDue] [decimal](18, 2) NULL,
	[WaterBillTotalDue] [decimal](18, 2) NULL,
	[Discounts] [decimal](18, 2) NULL,
	[Penalty] [decimal](18, 2) NULL,
	[OtherPenalty] [varchar](100) NULL,
	[OtherPenaltyAmount] [decimal](18, 2) NULL,
	[TotalAmount] [decimal](18, 2) NULL,
	[Balance] [decimal](18, 2) NULL,
	[Paid] [decimal](18, 2) NULL,
 CONSTRAINT [PK_MonthlyAssociationDue] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PaymentHistory]    Script Date: 5/9/2016 4:19:36 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Reservation]    Script Date: 5/9/2016 4:19:36 PM ******/
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
 CONSTRAINT [PK_Reservation] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TenantArchive]    Script Date: 5/9/2016 4:19:36 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TenantProfile]    Script Date: 5/9/2016 4:19:36 PM ******/
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
	[StartOfOccupancy] [int] NULL,
	[EndOfOccupancy] [int] NULL,
 CONSTRAINT [PK_TenantProfile] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UnitProfile]    Script Date: 5/9/2016 4:19:36 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserProfile]    Script Date: 5/9/2016 4:19:36 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[WaterBilling]    Script Date: 5/9/2016 4:19:36 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[LogSheet] ([ID], [Item], [Quantity], [DateModified], [ModifiedBy]) VALUES (N'c4ed2ab1-4582-4be5-9f35-2ecb33fb42ea', N'GE CIRCULAR BULB 20W', 50, NULL, NULL)
GO
INSERT [dbo].[LogSheet] ([ID], [Item], [Quantity], [DateModified], [ModifiedBy]) VALUES (N'e1221b27-0ac9-4313-9f8a-86c83e3974d6', N'CD-R KING LED BULB 5W', 93, CAST(0x0000A60100F84A17 AS DateTime), N'13d14d70-2325-4163-928a-3f104fde431b')
GO
INSERT [dbo].[LogSheetActivity] ([ID], [Date], [ItemID], [Balance], [Quantity], [Purpose], [Area], [IssuedBy], [ReceivedBy]) VALUES (N'0d644795-8ab0-4944-862f-41477a62da0f', CAST(0x0000A601010975D7 AS DateTime), N'c4ed2ab1-4582-4be5-9f35-2ecb33fb42ea', 5, 50, N'Room', N'RM 2001', N'13d14d70-2325-4163-928a-3f104fde431b', N'Ramil Ignacio')
GO
INSERT [dbo].[LogSheetActivity] ([ID], [Date], [ItemID], [Balance], [Quantity], [Purpose], [Area], [IssuedBy], [ReceivedBy]) VALUES (N'd9fd294e-4865-40ef-b829-bcbf69b128bc', CAST(0x0000A601010A967B AS DateTime), N'e1221b27-0ac9-4313-9f8a-86c83e3974d6', 5, 98, N'g', N'g', N'13d14d70-2325-4163-928a-3f104fde431b', N'g')
GO
INSERT [dbo].[LogSheetActivity] ([ID], [Date], [ItemID], [Balance], [Quantity], [Purpose], [Area], [IssuedBy], [ReceivedBy]) VALUES (N'0328b28d-172c-41c6-b6e5-dcad18ed172d', CAST(0x0000A6010109E2F5 AS DateTime), N'c4ed2ab1-4582-4be5-9f35-2ecb33fb42ea', 5, 50, N'a', N'a', N'13d14d70-2325-4163-928a-3f104fde431b', N'a')
GO
INSERT [dbo].[UnitProfile] ([UnitNumber], [StartOfOccupancy], [ExpectedEndOfOccupancy], [Owner], [Tenant], [NatureOfOccupancy], [Type], [Floor]) VALUES (N'2001', NULL, NULL, NULL, NULL, NULL, NULL, N'2')
GO
INSERT [dbo].[UnitProfile] ([UnitNumber], [StartOfOccupancy], [ExpectedEndOfOccupancy], [Owner], [Tenant], [NatureOfOccupancy], [Type], [Floor]) VALUES (N'3001', NULL, NULL, NULL, NULL, NULL, NULL, N'3')
GO
INSERT [dbo].[UserProfile] ([ID], [Username], [FirstName], [MiddleName], [LastName], [DateOfBirth], [MaritalStatus], [HomeAddress], [ProvincialAddress], [Password], [MobileNo], [TelephoneNo], [Email], [ContactPerson], [ContactNo], [RelationshipToContact], [ImageContent], [Status], [Type], [IfGeneratedPassword], [FullName]) VALUES (N'13d14d70-2325-4163-928a-3f104fde431b', N'admin', N'Ramil', N'Valencia', N'Ignacio', CAST(0x0000858D00000000 AS DateTime), N'Single', N'Pasig', N'Pasig', N'admin', NULL, NULL, N'r@gmail.com', NULL, NULL, NULL, NULL, N'Y', N'admin', N'N', N'Ramil Charles')
GO
ALTER TABLE [dbo].[LogSheet]  WITH CHECK ADD  CONSTRAINT [FK_LogSheet_UserProfile] FOREIGN KEY([ModifiedBy])
REFERENCES [dbo].[UserProfile] ([ID])
GO
ALTER TABLE [dbo].[LogSheet] CHECK CONSTRAINT [FK_LogSheet_UserProfile]
GO
ALTER TABLE [dbo].[LogSheetActivity]  WITH CHECK ADD  CONSTRAINT [FK_LogSheetActivity_LogSheet] FOREIGN KEY([ItemID])
REFERENCES [dbo].[LogSheet] ([ID])
GO
ALTER TABLE [dbo].[LogSheetActivity] CHECK CONSTRAINT [FK_LogSheetActivity_LogSheet]
GO
ALTER TABLE [dbo].[LogSheetActivity]  WITH CHECK ADD  CONSTRAINT [FK_LogSheetActivity_UserProfile] FOREIGN KEY([IssuedBy])
REFERENCES [dbo].[UserProfile] ([ID])
GO
ALTER TABLE [dbo].[LogSheetActivity] CHECK CONSTRAINT [FK_LogSheetActivity_UserProfile]
GO
ALTER TABLE [dbo].[MonthlyAssociationDue]  WITH CHECK ADD  CONSTRAINT [FK_MonthlyAssociationDue_UnitProfile] FOREIGN KEY([UnitNumber])
REFERENCES [dbo].[UnitProfile] ([UnitNumber])
GO
ALTER TABLE [dbo].[MonthlyAssociationDue] CHECK CONSTRAINT [FK_MonthlyAssociationDue_UnitProfile]
GO
ALTER TABLE [dbo].[PaymentHistory]  WITH CHECK ADD  CONSTRAINT [FK_PaymentHistory_MonthlyAssociationDue] FOREIGN KEY([MonthlyAssocID])
REFERENCES [dbo].[MonthlyAssociationDue] ([ID])
GO
ALTER TABLE [dbo].[PaymentHistory] CHECK CONSTRAINT [FK_PaymentHistory_MonthlyAssociationDue]
GO
ALTER TABLE [dbo].[PaymentHistory]  WITH CHECK ADD  CONSTRAINT [FK_PaymentHistory_Reservation] FOREIGN KEY([ReservationID])
REFERENCES [dbo].[Reservation] ([ID])
GO
ALTER TABLE [dbo].[PaymentHistory] CHECK CONSTRAINT [FK_PaymentHistory_Reservation]
GO
ALTER TABLE [dbo].[TenantArchive]  WITH CHECK ADD  CONSTRAINT [FK_TenantArchive_UnitProfile] FOREIGN KEY([UnitNumber])
REFERENCES [dbo].[UnitProfile] ([UnitNumber])
GO
ALTER TABLE [dbo].[TenantArchive] CHECK CONSTRAINT [FK_TenantArchive_UnitProfile]
GO
ALTER TABLE [dbo].[WaterBilling]  WITH CHECK ADD  CONSTRAINT [FK_WaterBilling_UnitProfile] FOREIGN KEY([UnitNumber])
REFERENCES [dbo].[UnitProfile] ([UnitNumber])
GO
ALTER TABLE [dbo].[WaterBilling] CHECK CONSTRAINT [FK_WaterBilling_UnitProfile]
GO
