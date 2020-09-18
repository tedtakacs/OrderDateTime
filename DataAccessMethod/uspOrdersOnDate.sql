USE [OrderDateTime]
GO

/****** Object:  StoredProcedure [dbo].[uspOdersOnDate]    Script Date: 9/17/2020 9:13:22 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE OR ALTER PROCEDURE [dbo].[uspOdersOnDate]
    @OrderDate date
AS

SELECT
	p.PersonId,
	NameFirst,
	NameLast
FROM Person p
JOIN Orders o
ON p.PersonId = o.PersonId
WHERE CONVERT(DATE,o.OrderDateTime) = @OrderDate
ORDER BY p.PersonId

GO


