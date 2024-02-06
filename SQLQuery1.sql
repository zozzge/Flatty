-- Create Users table
CREATE TABLE Users (
    Id INT PRIMARY KEY,
    Name NVARCHAR(255) NOT NULL,
    Email NVARCHAR(255) NOT NULL,
    Password NVARCHAR(255) NOT NULL
);

-- Create Groups table
CREATE TABLE Groups (
    Id INT PRIMARY KEY,
    Name NVARCHAR(255) NOT NULL
);

-- Create Expenses table
CREATE TABLE Expenses (
    Id INT PRIMARY KEY,
    Description NVARCHAR(255) NOT NULL,
    Amount DECIMAL(10, 2) NOT NULL,
    EndDate DATETIME NOT NULL,
    PaidByUserId INT,
    GroupId INT,

    FOREIGN KEY (PaidByUserId) REFERENCES Users(Id),
    FOREIGN KEY (GroupId) REFERENCES Groups(Id)
);

-- Create MemberBalances table
CREATE TABLE MemberBalances (
    Id INT PRIMARY KEY,
    GroupId INT NOT NULL,
    DebtorUserId INT NOT NULL,
    CreditorUserId INT NOT NULL,
    Balance DECIMAL(10, 2) NOT NULL,

    FOREIGN KEY (GroupId) REFERENCES Groups(Id),
    FOREIGN KEY (DebtorUserId) REFERENCES Users(Id),
    FOREIGN KEY (CreditorUserId) REFERENCES Users(Id)
);
-- Add ExpenseId column to Groups table
ALTER TABLE Groups
ADD ExpenseId INT,
    FOREIGN KEY (ExpenseId) REFERENCES Expenses(Id);

-- Add BalanceId column to Groups table
ALTER TABLE Groups
ADD BalanceId INT,
    FOREIGN KEY (BalanceId) REFERENCES MemberBalances(Id);
