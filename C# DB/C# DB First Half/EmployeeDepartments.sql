SELECT TOP(5) e.EmployeeID, e.FirstName, e.Salary, d.Name AS DepartmentName FROM Employees e
	LEFT JOIN  Departments d ON d.DepartmentID = e.DepartmentID
WHERE e.Salary > 15000 ORDER BY e.DepartmentID ASC
