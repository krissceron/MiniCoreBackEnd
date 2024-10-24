create database MiniCoreVentas
GO
use MiniCoreVentas
GO
 
create table vendedores (
	idVendedor int not null Primary Key IDENTITY(1,1),
	NombreVendedor varchar(500) not null
)

create table Ventas(
	idVenta int not null Primary Key IDENTITY(1,1),
	idVendedor int not null ,
	ventas varchar(900) not null,
	Monto int not null,
	fechaVenta Date not null,
	CONSTRAINT FK_PersonOrder FOREIGN KEY (idVendedor) references vendedores(idVendedor)
)

insert into vendedores values ('Darwin Hidrobo')
insert into vendedores values ('Samantha Caicedo')
insert into vendedores values ('Edwin Torres')
insert into vendedores values ('Kate Dittmer')

select * from vendedores

insert into Ventas values (1,'Xiaomi Redmi',400,'2023-01-10')
insert into Ventas values (1,'Playstation 5',600,'2023-01-10')
insert into Ventas values (2,'Laptop Asus',900,'2023-01-10')
insert into Ventas values (2,'Iphone 14 pro max',1400,'2023-01-10')

select * from Ventas

select a.NombreVendedor, sum(c.Monto) from Ventas c
inner join vendedores a on c.idVendedor = a.idVendedor
where fechaVenta ='2023-01-10'
group by a.NombreVendedor