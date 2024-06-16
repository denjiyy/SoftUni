SELECT b.Id, b.Title, b.ISBN, g.Name AS [Genre] FROM Books b
	JOIN Genres g ON g.Id = b.GenreId
	WHERE g.Name = 'Historical Fiction' OR g.Name = 'Biography'
	ORDER BY g.Name ASC, b.Title ASC
