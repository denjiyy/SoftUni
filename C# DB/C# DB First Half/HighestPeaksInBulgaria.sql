SELECT c.CountryCode, m.MountainRange, p.PeakName, p.Elevation FROM Countries c
	LEFT JOIN MountainsCountries mc ON mc.CountryCode = c.CountryCode
	LEFT JOIN Peaks p ON p.MountainId = mc.MountainId
	LEFT JOIN Mountains m ON m.Id = p.MountainId
WHERE c.CountryCode = 'BG' AND p.Elevation > 2835
ORDER BY Elevation DESC
