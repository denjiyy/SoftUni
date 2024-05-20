CREATE TABLE Cities
(
    CityID INT PRIMARY KEY,
    Name VARCHAR(50)
)

CREATE TABLE Customers
(
    CustomerID INT PRIMARY KEY,
    Name VARCHAR(50),
    Birthday DATETIME2,
    CityID INT,
    FOREIGN KEY (CityID) REFERENCES Cities(CityID)
)

CREATE TABLE Orders
(
    OrderID INT PRIMARY KEY,
    CustomerID INT,
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
)

CREATE TABLE ItemTypes
(
    ItemTypeID INT PRIMARY KEY,
    Name VARCHAR(50)
)

CREATE TABLE Items
(
    ItemID INT PRIMARY KEY,
    Name VARCHAR(50),
    ItemTypeID INT,
    FOREIGN KEY (ItemTypeID) REFERENCES ItemTypes(ItemTypeID)
)

CREATE TABLE OrderItems
(
    OrderID INT,
    ItemID INT,
    PRIMARY KEY (OrderID, ItemID),
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
    FOREIGN KEY (ItemID) REFERENCES Items(ItemID)
)
