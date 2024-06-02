SELECT DepartmentID, MIN(Salary) FROM Employees
WHERE DepartmentID = 2 OR DepartmentID = 5 OR DepartmentID = 7 AND HireDate > '1-1-2000'
GROUP BY DepartmentID
