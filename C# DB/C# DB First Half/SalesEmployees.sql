SELECT e.EmployeeID, e.FirstName, e.LastName, d.Name AS DepartmentName FROM Employees e
	LEFT JOIN Departments d ON d.DepartmentID = e.DepartmentID
WHERE e.DepartmentID = 3 ORDER BY e.EmployeeID ASC
