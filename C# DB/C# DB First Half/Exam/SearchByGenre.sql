CREATE PROCEDURE usp_SearchByGenre
    @genreName NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        b.Title,
        b.YearPublished AS Year,
        b.ISBN,
        a.Name AS Author,
        g.Name AS Genre
    FROM 
        Books b
    JOIN 
        Authors a ON b.AuthorId = a.Id
    JOIN 
        Genres g ON b.GenreId = g.Id
    WHERE 
        g.Name = @genreName
    ORDER BY 
        b.Title ASC;

    SET NOCOUNT OFF;
END
