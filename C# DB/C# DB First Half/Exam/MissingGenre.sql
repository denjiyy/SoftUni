SELECT l.Name AS Library, c.Email
FROM Libraries l
JOIN Contacts c ON l.ContactId = c.Id
WHERE l.Id NOT IN (
    SELECT lb.LibraryId
    FROM LibrariesBooks lb
    JOIN Books b ON lb.BookId = b.Id
    JOIN Genres g ON b.GenreId = g.Id
    WHERE g.Name = 'Mystery'
)
ORDER BY l.Name ASC
