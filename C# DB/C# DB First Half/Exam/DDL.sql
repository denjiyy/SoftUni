CREATE TABLE Contacts (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Email NVARCHAR(100),
    PhoneNumber NVARCHAR(20),
    PostAddress NVARCHAR(200),
    Website NVARCHAR(50)
)

CREATE TABLE Authors (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    ContactId INT NOT NULL,
    CONSTRAINT FK_Authors_Contacts FOREIGN KEY (ContactId) REFERENCES Contacts(Id)
)

CREATE TABLE Genres (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(30) NOT NULL
)

CREATE TABLE Books (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Title NVARCHAR(100) NOT NULL,
    YearPublished INT NOT NULL,
    ISBN NVARCHAR(13) NOT NULL UNIQUE,
    AuthorId INT NOT NULL,
    GenreId INT NOT NULL,
    CONSTRAINT FK_Books_Authors FOREIGN KEY (AuthorId) REFERENCES Authors(Id),
    CONSTRAINT FK_Books_Genres FOREIGN KEY (GenreId) REFERENCES Genres(Id)
)

CREATE TABLE Libraries (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(50) NOT NULL,
    ContactId INT NOT NULL,
    CONSTRAINT FK_Libraries_Contacts FOREIGN KEY (ContactId) REFERENCES Contacts(Id)
)

CREATE TABLE LibrariesBooks (
    LibraryId INT NOT NULL,
    BookId INT NOT NULL,
    PRIMARY KEY (LibraryId, BookId),
    CONSTRAINT FK_LibrariesBooks_Libraries FOREIGN KEY (LibraryId) REFERENCES Libraries(Id),
    CONSTRAINT FK_LibrariesBooks_Books FOREIGN KEY (BookId) REFERENCES Books(Id)
)
