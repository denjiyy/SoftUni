WITH HighestPeaks AS (
    SELECT 
        c.CountryCode,
        c.CountryName,
        MAX(p.Elevation) AS HighestPeakElevation
    FROM 
        Countries c
        LEFT JOIN MountainsCountries mc ON mc.CountryCode = c.CountryCode
        LEFT JOIN Mountains m ON m.Id = mc.MountainId
        LEFT JOIN Peaks p ON p.MountainId = m.Id
    GROUP BY 
        c.CountryCode, c.CountryName
),
LongestRivers AS (
    SELECT 
        c.CountryCode,
        MAX(r.Length) AS LongestRiverLength
    FROM 
        Countries c
        LEFT JOIN CountriesRivers cr ON cr.CountryCode = c.CountryCode
        LEFT JOIN Rivers r ON r.Id = cr.RiverId
    GROUP BY 
        c.CountryCode
)

SELECT DISTINCT TOP(5)
    hp.CountryName,
    hp.HighestPeakElevation,
    lr.LongestRiverLength
FROM 
    HighestPeaks hp
    LEFT JOIN LongestRivers lr ON hp.CountryCode = lr.CountryCode
ORDER BY 
    hp.HighestPeakElevation DESC,
    lr.LongestRiverLength DESC,
    hp.CountryName
