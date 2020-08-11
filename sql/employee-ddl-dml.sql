use master;
go

create database DepartmentDb;
go

create schema Company
go

create table Company.Employee-- ~touch pizza/pizza
(
  EmployeeId int not null primary key identity(1,1),
  SizeId int not null,
  [FirstName] nvarchar(200) not null,
  [LastName] nvarchar(200) not null,
  [SSN] int not null,

  Active bit not null default 1,
  constraint FK_DepartmentId foreign key (DepartmentId) references Company.Department
);

create table Company.EmpDetails
(
  DetailsId int not null primary key identity(1,1),
  [Salary] int not null,
  [Address 1] nvarchar(200) not null,
  [Address 2] nvarchar(200) not null,
  [City] nvarchar(100) not null,
  [State] nvarchar(100) not null,
  [Country] nvarchar(100) not null,

  Active bit not null,
  constraint FK_EmployeeId foreign key (EmployeeId) references Company.Employee
);

create table Company.Department
(
  DepartmentId int not null primary key identity(1,1),
  [Name] nvarchar(100) not null,
  [Location] nvarchar(100) not null,

  Active bit not null,
);