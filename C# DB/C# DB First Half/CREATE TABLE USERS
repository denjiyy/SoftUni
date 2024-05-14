CREATE TABLE [Users]
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Username VARCHAR(30) UNIQUE,
    [Password] VARCHAR(30),
    ProfilePicture VARBINARY(MAX),
    LastLoginTime DATETIME,
    IsDeleted BIT
)

INSERT INTO [Users] (Username, [Password], ProfilePicture, LastLoginTime, IsDeleted) VALUES 
('user1', 'password1', NULL, '2024-05-14 08:00:00', 0),
('user2', 'password2', NULL, '2024-05-14 09:15:00', 0),
('user3', 'password3', NULL, '2024-05-14 10:30:00', 0),
('user4', 'password4', NULL, '2024-05-14 11:45:00', 0),
('user5', 'password5', NULL, '2024-05-14 12:00:00', 0)
