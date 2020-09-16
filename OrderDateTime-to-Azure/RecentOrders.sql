CREATE PROCEDURE [dbo].[RecentOrders]
AS
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
RETURN 0
