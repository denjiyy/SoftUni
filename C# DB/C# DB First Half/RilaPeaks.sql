SELECT m.MountainRange, p.PeakName, p.Elevation FROM Mountains m
LEFT JOIN Peaks p ON m.Id = p.MountainId WHERE m.Id = 17 ORDER BY p.Elevation DESC
