USE [Echo]
GO
/****** Object:  StoredProcedure [dbo].[TenancyDatabaseByOccupancyYear]    Script Date: 5/20/2016 12:36:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[TenancyDatabaseByOccupancyYear]
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


USE [Echo]
GO
/****** Object:  StoredProcedure [dbo].[UnitAll]    Script Date: 5/20/2016 12:36:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[UnitAll]
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


USE [Echo]
GO
/****** Object:  StoredProcedure [dbo].[UnitAllAvailable]    Script Date: 5/20/2016 12:36:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[UnitAllAvailable]
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



USE [Echo]
GO
/****** Object:  StoredProcedure [dbo].[UnitAllOccupied]    Script Date: 5/20/2016 12:36:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[UnitAllOccupied]
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
