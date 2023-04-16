CREATE TABLE Region
(
	Id  int IDENTITY(1,1) ,
	RegionName varchar(52) NOT NULL
	constraint PK_Region primary key (id)
);
CREATE TABLE Lookup
(
		Id  int IDENTITY(1,1) ,
		Value varchar(52) NOT NULL,
		Category varchar(52) NOT NULL
		constraint PK_Lookup primary key (Id)

);
CREATE TABLE Wallet
(
	Id  int IDENTITY(1,1) ,
	Type int ,
	TotalAmount int DEFAULT 0
	constraint PK_Wallet primary key (Id)
	constraint FK_Wallet_Lookup foreign key (Type) references Lookup(Id)	
);
CREATE TABLE Credentails
(
	Id  int IDENTITY(1,1),
	Type int ,
	Email varchar(255) NOT NULL,
	Password varchar(255) NOT NULL
	constraint PK_Credentails primary key (Id)
	constraint FK_Credentails_Lookup foreign key (Type) references Lookup(Id)	
);
CREATE TABLE Person (
    Id int IDENTITY(1,1),
    FirstName varchar(52) NOT NULL,
	LastName varchar(52),
	PhoneNo varchar(15),
	CNIC int NOT NULL,
	RegionId int ,
	RegDate Datetime NOT NULL,
	Gender int ,
	WalletId int FOREIGN KEY REFERENCES Wallet(Id),
	CredentailId int FOREIGN KEY REFERENCES Credentails(Id),
	constraint PK_Person primary key (Id),
	constraint FK_Person_Region FOREIGN KEY (RegionId) REFERENCES Region(Id),
	constraint FK_Person_Lookup FOREIGN KEY (Gender) REFERENCES Lookup(Id),
	constraint FK_Person_Wallet FOREIGN KEY (WalletId) REFERENCES Wallet(Id),
	constraint FK_Person_Credentails FOREIGN KEY (CredentailId) REFERENCES Credentails(Id),

);
CREATE TABLE Employee
(
	EmployeeId int not null,   
	Salary int,
	Status int,
	Designation int,
	constraint PK_Employee primary key (EmployeeId),
	constraint FK_Employee_Person FOREIGN KEY (EmployeeId) REFERENCES Person(Id),
	constraint FK_Employee_Lookup_Status FOREIGN KEY (Status) REFERENCES Lookup(Id),
	constraint FK_Employee_Lookup_Designation FOREIGN KEY (Designation) REFERENCES Lookup(Id),
);
CREATE TABLE Farmer
(
    FarmerId int not null,   
	Status int,
	Address varchar(255),
	ManagerId int,
	constraint PK_Farmer primary key (FarmerId),
	constraint FK_Farmer_Person FOREIGN KEY (FarmerId) REFERENCES Person(Id),
	constraint FK_Farmer_Lookup FOREIGN KEY (Status) REFERENCES Lookup(Id),
	constraint FK_Farmer_Employee FOREIGN KEY (ManagerId) REFERENCES Employee(EmployeeId),
);
CREATE TABLE Driver
(
	DriverId int,
	Status int,
	Address varchar(255),
	DrivingLicence varchar(255) NOT NULL,
	ManagerId int,
	constraint PK_Driver primary key (DriverId),
	constraint FK_Driver_Person FOREIGN KEY (DriverId) REFERENCES Person(Id),
	constraint FK_Driver_Lookup FOREIGN KEY (Status) REFERENCES Lookup(Id),
	constraint FK_Driver_Employee FOREIGN KEY (ManagerId) REFERENCES Employee(EmployeeId),

);
CREATE TABLE Field
(
	Id int IDENTITY(1,1),
	FarmerId int,
	RegionId int,
	Address varchar(255),
	Status int,
	ManagerId int,

	constraint PK_Field primary key(Id),
	constraint FK_Field_Lookup FOREIGN KEY (Status) REFERENCES Lookup(Id),
	constraint FK_Field_Farmer FOREIGN KEY (FarmerId) REFERENCES Farmer(FarmerId), 
	constraint FK_Field_Region FOREIGN KEY (RegionId) REFERENCES Region(Id),
	constraint FK_Field_Employee FOREIGN KEY (ManagerId) REFERENCES Employee(EmployeeId),
);
CREATE TABLE Vehicle
(
	Id int IDENTITY(1,1),
	RegNo varchar(11) NOT NULL,
	SystemRegDate datetime NOT NULL,
	DriverId int,
	VehicleStatus int,
	ManagerId int,

	constraint PK_Vehicle primary key(Id),
	constraint FK_Vehicle_Employee FOREIGN KEY (ManagerId) REFERENCES Employee(EmployeeId),
	constraint FK_Vehicle_Driver FOREIGN KEY (DriverId) REFERENCES Driver(DriverId),
	constraint FK_Vehicle_Lookup FOREIGN KEY (VehicleStatus) REFERENCES Lookup(Id)

);
CREATE TABLE Organization
(
	Id int IDENTITY(1,1),
	OrganizationName varchar(52) NOT NULL,
	Address varchar(255),
	RegionId int,
	WalletId int,
	CredentailId int,
	Status int,

	constraint PK_Organization primary key(Id),
	constraint FK_Organization_Region FOREIGN KEY (RegionId) REFERENCES Region(Id),
	constraint FK_Organization_Wallet FOREIGN KEY (WalletId) REFERENCES Wallet(Id),
	constraint FK_Organization_Credentails FOREIGN KEY (CredentailId) REFERENCES Credentails(Id),
	constraint FK_Organization_Lookup FOREIGN KEY (Status) REFERENCES Lookup(Id)

);

CREATE TABLE Warehouse
(
	Id int,
	MaxCapacity int NOT NULL,
	Address varchar(255),

	constraint PK_Warehouse primary key (Id),
	constraint FK_Warehouse_Region FOREIGN KEY (Id) REFERENCES Region(Id),
);
CREATE TABLE Product
(
	Id int IDENTITY(1,1),
	Name varchar(52) NOT NULL,
	Quantity int NOT NULL,
	UnitPrice int NOT NULL,
	RemaningUnits int ,
	ManagerId int,
	Status int,
	CategoryId int,

	constraint PK_Product primary key(Id),
	constraint FK_Product_Lookup_Status FOREIGN KEY (Status) REFERENCES Lookup(Id),
	constraint FK_Product_Employee FOREIGN KEY (ManagerId) REFERENCES Employee(EmployeeId),
	constraint FK_Product_Lookup_Category FOREIGN KEY (CategoryId) REFERENCES Lookup(Id),
);
CREATE TABLE WarehouseProduct
(
	WarehouseId int NOT NULL,
	ProductId int NOT NULL,

	constraint FK_Warehouseproduct_Warehouse FOREIGN KEY (WarehouseId) REFERENCES Warehouse(Id),
	constraint FK_Warehoueproduct_Product FOREIGN KEY (ProductId) REFERENCES Product(Id),
);
CREATE TABLE Orders
(
	Id int IDENTITY(1,1),
	RequestedUnits int NOT NULL,
	PricePerUnit int NOT NULL,
	OrderDate datetime NOT NULL,
	Status int,
	ProductId int,
	OrganizationId int,
	ManagerId int,

	constraint PK_Orders primary key(Id),
	constraint FK_Orders_Lookup FOREIGN KEY (Status) REFERENCES Lookup(Id),
	constraint FK_Orders_Product FOREIGN KEY (ProductId) REFERENCES Product(Id),
	constraint FK_Orders_Organization FOREIGN KEY (OrganizationId) REFERENCES Organization(Id),
	constraint FK_Orders_Employee FOREIGN KEY (ManagerId) REFERENCES Employee(EmployeeId),
	
);
CREATE TABLE TransactionDetails
(
	Id int IDENTITY(1,1),
	SenderId int,
	ReceiverId int,
	Amount int NOT NULL,
	TransactionType int,
	TimeStamp datetime NOT NULL,

	constraint PK_TransactionDetails primary key(Id),
	constraint FK_TransactionDetails_Wallet_Sender FOREIGN KEY (SenderId) REFERENCES Wallet(Id),
	constraint FK_TransactionDetails_Wallet_Receiver FOREIGN KEY (ReceiverId) REFERENCES Wallet(Id),
	constraint FK_TransactionDetails_Type FOREIGN KEY (TransactionType) REFERENCES Lookup(Id),

);
CREATE TABLE Office
(
	Id int, 
	Address varchar(255),
	WalletId int,
	
	constraint PK_Office primary key (Id),
	constraint FK_Office_Region FOREIGN KEY (Id) REFERENCES Region(Id),
	constraint FK_Office_Wallet FOREIGN KEY (WalletId) REFERENCES Wallet(Id),
);
CREATE TABLE Delivery
(
	Id int IDENTITY(1,1),
	VehicleId int,
	DeliveryType int,
	SourceId int,
	DestinationId int,
	ProductId int,
	CurrentStatus int,
	ManagerId int,

	constraint PK_Delivery PRIMARY KEY (Id) ,
	constraint FK_Delivery_Vehicle FOREIGN KEY (VehicleId) REFERENCES Vehicle(Id),
	constraint FK_Delivery_Product FOREIGN KEY (ProductId) REFERENCES Product(Id),
	constraint FK_Delivery_Lookup_DeliveryType FOREIGN KEY (DeliveryType) REFERENCES Lookup(Id),
	constraint FK_Delivery_Lookup_CurrentStatus FOREIGN KEY (CurrentStatus) REFERENCES Lookup(Id),
	constraint FK_Delivery_Employee FOREIGN KEY (ManagerId) REFERENCES Employee(EmployeeId),
	--constraint FK_DeliveryDetails_Lookup FOREIGN KEY (Status) REFERENCES Region(Id),
	--constraint FK_DeliveryDetails_Lookup FOREIGN KEY (Status) REFERENCES Region(Id),
);
CREATE TABLE DeliveryDetails
(
	DeliveryId int,
	Status int,
	TimeStamp datetime NOT NULL ,

	constraint FK_DeliveryDetails_Lookup FOREIGN KEY (Status) REFERENCES Region(Id),
	constraint FK_DeliveryDetails_Delivery FOREIGN KEY (DeliveryId) REFERENCES Delivery(Id),
);

