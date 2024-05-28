SELECT COUNT(c.CountryCode) FROM Countries c
	LEFT JOIN MountainsCountries mc ON mc.CountryCode = c.CountryCode
	LEFT JOIN Mountains m ON m.Id = mc.MountainId
WHERE m.Id IS NULL
