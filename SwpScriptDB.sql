CREATE DATABASE JewelleryOrder
go
use JewelleryOrder
go
CREATE TABLE Role (
    RoleID INT PRIMARY KEY,
    Name NVARCHAR(255) NOT NULL
);

CREATE TABLE Users (
    UsersID INT PRIMARY KEY,
    Name NVARCHAR(255) NOT NULL,
    Email NVARCHAR(255) NOT NULL,
    Phone NVARCHAR(50),
    RoleID INT,
    FOREIGN KEY (RoleID) REFERENCES Role(RoleID)
);

CREATE TABLE Blog (
    BlogID INT PRIMARY KEY,
    Title NVARCHAR(255) NOT NULL,
    Description NVARCHAR(MAX),
    Image NVARCHAR(MAX),
    ManagerID INT,
    FOREIGN KEY (ManagerID) REFERENCES Users(UsersID)
);

CREATE TABLE Material (
    MaterialID INT PRIMARY KEY,
    Name NVARCHAR(255) NOT NULL,
    Price DECIMAL(18, 2),
    ManagerID INT,
    FOREIGN KEY (ManagerID) REFERENCES Users(UsersID)
);

CREATE TABLE Stones (
    StonesID INT PRIMARY KEY,
    Kind NVARCHAR(255) NOT NULL,
    Size NVARCHAR(50),
    Quantity INT,
    Price DECIMAL(18, 2)
);

CREATE TABLE MasterGemstone (
    MasterGemstoneID INT PRIMARY KEY,
    Kind NVARCHAR(255) NOT NULL,
    Size NVARCHAR(50),
    Price DECIMAL(18, 2)
);

CREATE TABLE TypeOfJewelry (
    TypeOfJewelryID INT PRIMARY KEY,
    Name NVARCHAR(255) NOT NULL
);

CREATE TABLE Design (
    DesignID INT PRIMARY KEY,
    ParentID INT,
    Image NVARCHAR(MAX),
    DesignName NVARCHAR(255) NOT NULL,
    WeightOfMaterial DECIMAL(18, 2),
    StonesID INT,
    MasterGemstoneID INT,
    ManagerID INT,
    TypeOfJewelryID INT,
    MaterialID INT,
    FOREIGN KEY (StonesID) REFERENCES Stones(StonesID),
    FOREIGN KEY (MasterGemstoneID) REFERENCES MasterGemstone(MasterGemstoneID),
    FOREIGN KEY (ManagerID) REFERENCES Users(UsersID),
    FOREIGN KEY (TypeOfJewelryID) REFERENCES TypeOfJewelry(TypeOfJewelryID),
    FOREIGN KEY (MaterialID) REFERENCES Material(MaterialID)
);

CREATE TABLE Requirements (
    RequirementsID INT PRIMARY KEY,
    Status NVARCHAR(255) NOT NULL,
    ExpectedDelivery DATE,
    Size NVARCHAR(50),
    Design3D NVARCHAR(MAX),
    GoldPriceAtMoment DECIMAL(18, 2),
    StonePriceAtMoment DECIMAL(18, 2),
    MatchingFee DECIMAL(18, 2),
    TotalMoney DECIMAL(18, 2),
	CustomerNote NVARCHAR(255),
	SellerNote NVARCHAR(255),
    DesignID INT,
    FOREIGN KEY (DesignID) REFERENCES Design(DesignID)
);

CREATE TABLE Payment (
    PaymentID INT PRIMARY KEY,
    Amount DECIMAL(18, 2) NOT NULL,
    Method NVARCHAR(255) NOT NULL,
    CompletedAt DATE,
    CustomerID INT,
    RequirementsID INT,
    FOREIGN KEY (RequirementsID) REFERENCES Requirements(RequirementsID),
	FOREIGN KEY (CustomerID) REFERENCES Users(UsersID)
);

CREATE TABLE WarrantyCard (
    WarrantyCardID INT PRIMARY KEY,
    Title NVARCHAR(255) NOT NULL,
    Description NVARCHAR(MAX)
);

CREATE TABLE Have (
    WarrantyCardID INT,
    RequirementsID INT,
    DateCreated DATE,
    ExpirationDate DATE,
    PRIMARY KEY (WarrantyCardID, RequirementsID),
    FOREIGN KEY (WarrantyCardID) REFERENCES WarrantyCard(WarrantyCardID),
    FOREIGN KEY (RequirementsID) REFERENCES Requirements(RequirementsID)
);

CREATE TABLE UsersRequirements (
    UsersID INT,
    RequirementsID INT,
    PRIMARY KEY (UsersID, RequirementsID),
    FOREIGN KEY (UsersID) REFERENCES Users(UsersID),
    FOREIGN KEY (RequirementsID) REFERENCES Requirements(RequirementsID)
);
