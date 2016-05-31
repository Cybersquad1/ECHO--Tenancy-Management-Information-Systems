USE [Echo]
GO
/****** Object:  StoredProcedure [dbo].[UnitAllOccupied]    Script Date: 05/28/2016 22:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UnitAllOccupied]
AS
SELECT unit.UnitNumber, unit.StartOfOccupancy, unit.ExpectedEndOfOccupancy, 
unit.NatureOfOccupancy, unit.Type, unit.Floor, owner.FirstName as OwnerFirstName, 
owner.LastName as OwnerLastName, tenant.FirstName as TenantFirstName,
tenant.LastName as TenantLastName
FROM UnitProfile as unit
LEFT JOIN TenantProfile as owner
ON owner.ID = unit.Owner
LEFT JOIN TenantProfile as tenant
ON tenant.ID = unit.Tenant
WHERE unit.Tenant IS NOT NULL
GO
/****** Object:  StoredProcedure [dbo].[UnitAllAvailable]    Script Date: 05/28/2016 22:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UnitAllAvailable]
AS
SELECT unit.UnitNumber, unit.StartOfOccupancy, unit.ExpectedEndOfOccupancy, 
unit.NatureOfOccupancy, unit.Type, unit.Floor, owner.FirstName as OwnerFirstName, 
owner.LastName as OwnerLastName, tenant.FirstName as TenantFirstName,
tenant.LastName as TenantLastName
FROM UnitProfile as unit
LEFT JOIN TenantProfile as owner
ON owner.ID = unit.Owner
LEFT JOIN TenantProfile as tenant
ON tenant.ID = unit.Tenant
WHERE unit.Tenant IS NULL
GO
/****** Object:  StoredProcedure [dbo].[UnitAll]    Script Date: 05/28/2016 22:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UnitAll]
AS
SELECT unit.UnitNumber, unit.StartOfOccupancy, unit.ExpectedEndOfOccupancy, 
unit.NatureOfOccupancy, unit.Type, unit.Floor, owner.FirstName as OwnerFirstName, 
owner.LastName as OwnerLastName, tenant.FirstName as TenantFirstName,
tenant.LastName as TenantLastName
FROM UnitProfile as unit
LEFT JOIN TenantProfile as owner
ON owner.ID = unit.Owner
LEFT JOIN TenantProfile as tenant
ON tenant.ID = unit.Tenant
GO
/****** Object:  StoredProcedure [dbo].[TenancyDatabaseByOccupancyYear]    Script Date: 05/28/2016 22:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TenancyDatabaseByOccupancyYear]
(
	@StartDate datetime,
	@EndDate datetime
)
AS
SELECT tenant.UnitNumber, unit.StartOfOccupancy, unit.ExpectedEndOfOccupancy, unit.NatureOfOccupancy,
unitowner.FirstName as OwnerFirstName, unitowner.LastName as OwnerLastName, unittenant.FirstName as TenantFirstName, 
unittenant.LastName as TenantLastName FROM TenantProfile as tenant
LEFT JOIN UnitProfile as unit
ON tenant.UnitNumber = unit.UnitNumber
LEFT JOIN TenantProfile as unitowner
on unit.Owner = unitowner.ID
LEFT JOIN TenantProfile as unittenant
ON unit.Tenant = unittenant.ID

WHERE tenant.StartOfOccupancy between @StartDate and @EndDate
AND tenant.Status = 'Y'
ORDER BY tenant.LastName ASC
GO
/****** Object:  StoredProcedure [dbo].[UserList]    Script Date: 05/28/2016 22:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UserList]
AS
Select * From UserProfile
GO
/****** Object:  StoredProcedure [dbo].[WaterBillingPaymentHistory]    Script Date: 05/28/2016 22:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[WaterBillingPaymentHistory]
(
	@UnitNo varchar(10)
)
AS
SELECT * FROM WaterBilling
WHERE UnitNumber = @UnitNo
ORDER BY ChargeDate DESC
GO
/****** Object:  StoredProcedure [dbo].[BillingStatement]    Script Date: 05/28/2016 22:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BillingStatement]
(
	@AssocID uniqueidentifier
)
AS
select assoc.UnitNumber, tenant.FirstName, tenant.LastName, assoc.ChargeDate,
assoc.AssociationDue, assoc.WaterBillTotalDue, assoc.OtherPenalty, assoc.OtherPenaltyAmount,
assoc.Penalty, assoc.WaterCurrentReading, assoc.WaterPreviousReading, assoc.WaterDate, assoc.TotalAmount from MonthlyAssociationDue as assoc
LEFT JOIN UnitProfile as unit
on unit.UnitNumber = assoc.UnitNumber
LEFT JOIN TenantProfile as tenant
on unit.Tenant = tenant.ID where assoc.ID=@AssocID
GO
/****** Object:  StoredProcedure [dbo].[MonthlyAssocPaymentHistory]    Script Date: 05/28/2016 22:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MonthlyAssocPaymentHistory]
(
@UnitNo varchar(10)
)
AS
SELECT * FROM MonthlyAssociationDue
WHERE UnitNumber = @UnitNo
ORDER BY ChargeDate DESC
GO


USE [Echo]
GO
/****** Object:  StoredProcedure [dbo].[Receipt]    Script Date: 5/30/2016 5:35:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[Receipt]
(
	@paymentHistoryID uniqueidentifier
)
AS
select * from PaymentHistory as payment
left join MonthlyAssociationDue as assoc 
ON assoc.ID = payment.MonthlyAssocID
where payment.ID = @paymentHistoryID
