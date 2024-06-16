SELECT TOP(3) 
    b.Title AS Title, 
    b.YearPublished AS Year, 
    g.Name AS Genre
FROM 
    Books b
JOIN 
    Genres g ON b.GenreId = g.Id
WHERE 
    (b.YearPublished > 2000 AND b.Title LIKE '%a%')
    OR
    (b.YearPublished < 1950 AND g.Name LIKE '%Fantasy%')
ORDER BY 
    b.Title ASC, 
    b.YearPublished DESC
