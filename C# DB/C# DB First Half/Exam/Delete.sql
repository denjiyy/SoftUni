DECLARE @AuthorId INT
SELECT @AuthorId = Id FROM Authors WHERE Name = 'Alex Michaelides'

DELETE FROM LibrariesBooks
WHERE BookId IN (SELECT Id FROM Books WHERE AuthorId = @AuthorId)

DELETE FROM Books
WHERE AuthorId = @AuthorId

DELETE FROM Authors
WHERE Id = @AuthorId
