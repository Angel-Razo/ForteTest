--Create database TestForte
--go

use TestForte
go


--Persona
if object_id ('dbo.tbpersona') is not null
  drop table dbo.tbpersona
go

create table TbPersona
(IdPersona int primary key identity(1,1),
Nombre varchar(150) not null,
FechaNacimiento datetime,
Edad smallint)

--EstatusCLiente
if object_id ('dbo.TbEstatusCliente') is not null
  drop table dbo.TbEstatusCliente
go

create table TbEstatusCliente
( IdEstatusCliente int Primary key  identity(1,1),
  Descripcion varchar(100),
  EstatusClienteId bit
)
--Interface
if object_id ('dbo.TbISoftDelete') is not null
  drop table dbo.TbISoftDelete
go

create table TbISoftDelete
( IdISoftDelete int Primary key  identity(1,1),
  Eliminado bit
)
--IAuditable
if object_id ('dbo.TbIAuditable') is not null
  drop table dbo.TbIAuditable
go

create table TbIAuditable
( IdIAuditable int Primary key  identity(1,1),
  CreadoPor varchar(100),
  CreadoEl datetime,
  ModificadoPor varchar(100),
  ModificadoEl datetime,  
  EliminadoPor varchar(100),
  EliminadoEl datetime
)
--Cliente
if object_id ('dbo.TbCliente') is not null
  drop table dbo.TbCliente
go

create table TbCliente
(
ClienteId int primary key identity,
CorreoElectronico varchar(100),
Password varchar(100),
Domicilio varchar(150),
LimiteCredito decimal,
EstatusCliente bit,
IdEstatusCliente int not null FOREIGN KEY (IdEstatusCliente) REFERENCES TbEstatusCliente(IdEstatusCliente),
IdISoftDelete int not null FOREIGN KEY (IdISoftDelete) REFERENCES TbISoftDelete(IdISoftDelete),
IdIAuditable int not null FOREIGN KEY (IdIAuditable) REFERENCES TbIAuditable(IdIAuditable)
)
