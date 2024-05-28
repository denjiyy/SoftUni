SELECT MIN(avg_salary) 
FROM (
    SELECT AVG(e.Salary) AS avg_salary 
    FROM Employees e
	GROUP BY e.DepartmentID
) AS subquery;
