CREATE DATABASE DEMO
GO

USE DEMO
GO


CREATE TABLE SEDE_OLIMPICA(
	Id int primary key identity (1,1),
	NOMBRE nvarchar(250),
	UBICACION nvarchar(MAX),
	PRESUPUESTO decimal(8,2)
)
go

CREATE TABLE COMPLEJO_DEPORTIVO(
	Id int primary key identity (1,1),
	LOCALIZACION nvarchar(MAX),
	JEFE_ORGANIZACION nvarchar(250),
	AREA_TOTAL decimal(8,2),
	ID_SEDE_OLIMPICA int foreign key references SEDE_OLIMPICA(Id)
)
go

CREATE TABLE COMPLEJO_DEPORTE_UNICO(
	Id int primary key identity (1,1),
	NOMBRE nvarchar(250),
	LOCALIZACION nvarchar(MAX),
	AREA decimal(8,2),
	ID_COMPLEJO_DEPORTIVO int foreign key references COMPLEJO_DEPORTIVO(Id)
)
go

CREATE TABLE COMPLEJO_POLIDEPORTIVO(
	Id int primary key identity (1,1),
	NOMBRE nvarchar(250),
	LOCALIZACION nvarchar(MAX),
	AREA decimal(8,2),
	ID_COMPLEJO_DEPORTIVO int foreign key references COMPLEJO_DEPORTIVO(Id)
)
go

CREATE TABLE EVENTO(
	Id int primary key identity (1,1),
	NOMBRE nvarchar(250),
	FECHA datetime,
	DURACION nvarchar(150),
	NROPARTICIPANTES INT,
	ID_COMPLEJO_DEPORTE_UNICO int foreign key references COMPLEJO_DEPORTE_UNICO(Id),
	ID_COMPLEJO_POLIDEPORTIVO int foreign key references COMPLEJO_POLIDEPORTIVO(Id)
)
go

CREATE TABLE EQUIPAMIENTO(
	Id int primary key identity (1,1),
	TIPO nvarchar(250),
	ID_EVENTO int foreign key references EVENTO(Id)
)
go

CREATE TABLE EVENTO_EQUIPAMIENTO(
	Id int primary key identity (1,1),
	ID_EVENTO int foreign key references EVENTO(Id),
	ID_EQUIPAMIENTO int foreign key references EQUIPAMIENTO(Id)
)
go

CREATE TABLE COMISARIO(
	Id int primary key identity (1,1),
	NOMBRE nvarchar(250),
	TIPO nvarchar(250),
	ID_EVENTO int foreign key references EVENTO(Id)
)
go