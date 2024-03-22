
CREATE DATABASE QuanlibanveCGV
GO
USE QuanlibanveCGV
GO



-- Bảng Người dùng
CREATE TABLE Users (
    UserID INT IDENTITY(100,1) PRIMARY KEY,
    UserName NVARCHAR(1200),
    Email VARCHAR(1200),
    Password VARCHAR(1200),
    Phone VARCHAR(20),
    AccountType INT
);

-- Bảng Phim
CREATE TABLE Movies (
    MovieID INT IDENTITY(100,1) PRIMARY KEY,
    MovieName NVARCHAR(1200),
    Genre VARCHAR(1200),
    Director VARCHAR(1200),
    Actors VARCHAR(1200),
    Description TEXT,
    TrailerLink VARCHAR(1200)
);

-- Bảng Xuất chiếu
CREATE TABLE Screenings (
    ScreeningID INT IDENTITY(100,1) PRIMARY KEY,
    MovieID INT,
    Room VARCHAR(1200),
    Times VARCHAR(1200),
    RemainingSeats INT,
    FOREIGN KEY (MovieID) REFERENCES Movies(MovieID)
);

-- Bảng Vé
CREATE TABLE Tickets (
    TicketID INT IDENTITY(100,1) PRIMARY KEY,
    ScreeningID INT,
    UserID INT,
    SeatNumber VARCHAR(20),
    Status INT,
    FOREIGN KEY (ScreeningID) REFERENCES Screenings(ScreeningID),
    FOREIGN KEY (UserID) REFERENCES Users(UserID)
);


-- Bảng Hóa đơn
CREATE TABLE Invoices (
    InvoiceID INT IDENTITY(100,1) PRIMARY KEY,
    UserID INT,
	CustomerName NVARCHAR(500),
	CustomerPhome VARCHAR(20),
    TotalAmount DECIMAL,
    CreatedTime VARCHAR(1200),
    FOREIGN KEY (UserID) REFERENCES Users(UserID)
);

-- Bảng Chi tiết hóa đơn
CREATE TABLE InvoiceDetails (
    InvoiceDetailID INT IDENTITY(100,1) PRIMARY KEY,
    InvoiceID INT,
    TicketID INT,
    ItemName VARCHAR(1200),
    Quantity INT,
    Price DECIMAL,
    FOREIGN KEY (InvoiceID) REFERENCES Invoices(InvoiceID),
    FOREIGN KEY (TicketID) REFERENCES Tickets(TicketID)
);



-- Insert random data into Users table
INSERT INTO Users (UserName, Email, Password, Phone, AccountType)
SELECT TOP 5
    'User' + CONVERT(NVARCHAR(10), ROW_NUMBER() OVER (ORDER BY NEWID())),
    'user' + CONVERT(NVARCHAR(10), ROW_NUMBER() OVER (ORDER BY NEWID())) + '@example.com',
    'password' + CONVERT(NVARCHAR(10), ROW_NUMBER() OVER (ORDER BY NEWID())),
    '123456789',
    1 -- Assuming 1 represents a regular user account type
FROM sys.objects;

-- Insert random data into Movies table
INSERT INTO Movies (MovieName, Genre, Director, Actors, Description, TrailerLink)
SELECT TOP 5
    'Movie' + CONVERT(NVARCHAR(10), ROW_NUMBER() OVER (ORDER BY NEWID())),
    'Genre' + CONVERT(NVARCHAR(10), ROW_NUMBER() OVER (ORDER BY NEWID())),
    'Director' + CONVERT(NVARCHAR(10), ROW_NUMBER() OVER (ORDER BY NEWID())),
    'Actors' + CONVERT(NVARCHAR(10), ROW_NUMBER() OVER (ORDER BY NEWID())),
    'Description' + CONVERT(NVARCHAR(10), ROW_NUMBER() OVER (ORDER BY NEWID())),
    'http://example.com/trailer' + CONVERT(NVARCHAR(10), ROW_NUMBER() OVER (ORDER BY NEWID()))
FROM sys.objects;

-- Insert random data into Screenings table
INSERT INTO Screenings (MovieID, Room, Times, RemainingSeats)
SELECT TOP 5
    (SELECT TOP 1 MovieID FROM Movies ORDER BY NEWID()),
    'Room' + CONVERT(NVARCHAR(10), ROW_NUMBER() OVER (ORDER BY NEWID())),
    'Times' + CONVERT(NVARCHAR(10), ROW_NUMBER() OVER (ORDER BY NEWID())),
    100 -- Assuming all screenings initially have 100 remaining seats
FROM sys.objects;

-- Insert random data into Tickets table
INSERT INTO Tickets (ScreeningID, UserID, SeatNumber, Status)
SELECT TOP 5
    (SELECT TOP 1 ScreeningID FROM Screenings ORDER BY NEWID()),
    (SELECT TOP 1 UserID FROM Users ORDER BY NEWID()),
    'Seat' + CONVERT(NVARCHAR(10), ROW_NUMBER() OVER (ORDER BY NEWID())),
    1 -- Assuming 1 represents a booked status
FROM sys.objects;

-- Insert random data into Invoices table
INSERT INTO Invoices (UserID, CustomerName, CustomerPhome, TotalAmount, CreatedTime)
SELECT TOP 5
    (SELECT TOP 1 UserID FROM Users ORDER BY NEWID()),
    'Customer' + CONVERT(NVARCHAR(10), ROW_NUMBER() OVER (ORDER BY NEWID())),
    '123456789',
    100.00, -- Assuming a fixed total amount for each invoice
    CONVERT(VARCHAR(20), GETDATE(), 120)
FROM sys.objects;

-- Insert random data into InvoiceDetails table
INSERT INTO InvoiceDetails (InvoiceID, TicketID, ItemName, Quantity, Price)
SELECT TOP 5
    (SELECT TOP 1 InvoiceID FROM Invoices ORDER BY NEWID()),
    (SELECT TOP 1 TicketID FROM Tickets ORDER BY NEWID()),
    'Item' + CONVERT(NVARCHAR(10), ROW_NUMBER() OVER (ORDER BY NEWID())),
    1, -- Assuming a quantity of 1 for each item
    10.00 -- Assuming a fixed price for each item
FROM sys.objects;

GO



























