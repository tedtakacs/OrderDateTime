/*
 Pre-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be executed before the build script.	
 Use SQLCMD syntax to include a file in the pre-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the pre-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
USE EmploymentTest
GO
SELECT
	p.PersonId,
	p.NameFirst,
	p.NameLast,
	lord.LastOrderId,
	lord.LastOrderDateTime
FROM dbo.Person p
LEFT JOIN	-- LEFT JOIN allows PersonId that placed no Order to appear in results
(SELECT		-- Query to select LastOrderDateTime for each PersonId that placed an Order
	o.PersonId,
	o.OrderId LastOrderId,
	maxord.LastOrderDateTime
FROM
	(SELECT
		PersonId, 
		MAX(OrderDateTime) LastOrderDateTime
	FROM dbo.Orders
	GROUP BY
		PersonId) maxord
	INNER JOIN
	(SELECT *
	FROM dbo.Orders) o
	ON maxord.LastOrderDateTime = o.OrderDateTime
	AND maxord.PersonId = o.PersonId) lord
ON p.PersonId = lord.PersonId
