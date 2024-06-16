CREATE FUNCTION udf_AuthorsWithBooks (@name NVARCHAR(100))
RETURNS INT
AS
BEGIN
    DECLARE @TotalBooks INT;

    SELECT @TotalBooks = COUNT(*)
    FROM Books b
    JOIN Authors a ON b.AuthorId = a.Id
    WHERE a.Name = @name;

    RETURN @TotalBooks;
END
