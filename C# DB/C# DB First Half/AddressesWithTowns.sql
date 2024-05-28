SELECT TOP(50) e.FirstName, e.LastName, t.Name AS Town, a.AddressText FROM Employees e
	LEFT JOIN Addresses a ON a.AddressID = e.AddressID
	LEFT JOIN Towns t ON t.TownID = a.TownID
ORDER BY e.FirstName, e.LastName ASC
