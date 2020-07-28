use master;
go

create database PizzaBoxDb;
go

use PizzaBoxDb;
go

create schema Pizza;
go

create table Pizza.Pizza -- ~touch pizza/pizza
(
  PizzaId int not null identity(1,1),
  SizeId int not null,
  [Name] nvarchar(200) not null,
  DateModified datetime2(0) not null,
  Active bit not null default 1,
  constraint PK_PizzaId primary key (PizzaId),
  constraint FK_CrustId foreign key (CrustId) references Pizza.Crust(CrustId),  --**NEED TO RUN THESE IN ALTERS OR AFTER THE REFERENCED TABLES ARE CREATED CAUSE THESE KEYS AREN'T CREATED YET
  constraint FK_SizeId foreign key (SizeId) references Pizza.Size(SizeId)
);

create table Pizza.Crust
(
  CrustId int not null identity(1,1),
  [option] nvarchar(100) not null,
  Active bit not null,
  constraint PK_CrustId primary key (CrustId),
  constraint Active default 1
);

create table Pizza.Size
(
  SizeId int not null identity(1,1),
  [option] nvarchar(100) not null,
  Active bit not null,
  constraint PK_SizeId primary key (SizeId)
);

create table Pizza.Topping
(
  ToppingId int not null identity(1,1),
  --PizzaId int not null, ??get rid of ToppingId and make this primary??
  [option] nvarchar(100) not null,
  Active bit not null,
  constraint PK_ToppingId primary key (ToppingId)
);

create table Pizza.PizzaTopping --Junction table (solves issue of only being able to have one topping at a time)
(
  PizzaToppingId int not null identity(1,1),
  PizzaId int not null,
  ToppingId int not null,
  Active bit not null,
  constraint PK_PizzaToppingId primary key (PizzaTopping),
  constraint PizzaId foreign key references Pizza.Pizza(PizzaId),
  constraint ToppingId foreign key references Pizza.Topping(ToppingId)
);
go

--User Schema
create schema Users;
go

create table Users.Users 
(
  UserId int not null identity(1,1),
  [username] nvarchar(10) not null,
  [password] nvarchar(10) not null,
  Active bit not null
);


go

--Order Schema
create schema Orders;
go

create table Orders.Orders
(
  OrdersId int not null,
  constraint OrdersId primary key
);

create table Orders.Pizzas
(
  PizzaId int not null,
  [Option] nvarchar(50) not null,
  Active bit not null,
  constraint PizzaId primary key,
  constraint Active default 1
);