SELECT 
    c.CountryCode, 
    COUNT(DISTINCT m.MountainRange) AS MountainRanges 
FROM 
    Countries c
    LEFT JOIN MountainsCountries mc ON mc.CountryCode = c.CountryCode
    LEFT JOIN Mountains m ON m.Id = mc.MountainId
WHERE 
    c.CountryCode IN ('US', 'RU', 'BG')
GROUP BY 
    c.CountryCode
