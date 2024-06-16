SELECT a.Name AS [Author], c.Email, c.PostAddress AS [Address] FROM Authors a
	JOIN Contacts c ON c.Id = a.ContactId
	WHERE c.PostAddress LIKE '%UK'
	ORDER BY a.Name ASC
