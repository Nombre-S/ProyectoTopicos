create database TallerMecanico
use TallerMecanico

create table CLIENTES(
DNI_Cliente int primary key,
Nombre_Cliente varchar(15),
Apellidos_Cliente varchar(30),
telefono varchar(50),
Direccion_Cliente varchar(50)
)

create table VEHICULO(
Matricula varchar(7) primary key,
Modelo varchar(20),
Color varchar(20),
DNI_Cliente int,
foreign key(DNI_Cliente) references CLIENTES(DNI_Cliente)
)

create table REGISTRO(
ID_Registro int primary key,
Matricula varchar(7),
Fecha_Entrada varchar(30),
Hora_Entrada varchar(9),
foreign key(Matricula) references VEHICULO(Matricula)
)

create table MECANICO(
ID_Mecanico int primary key,
Nombre_Mecanico varchar(15),
ID_Registro int,
foreign key(ID_Registro) references REGISTRO(ID_Registro)
)

create table FACTURA(
ID_Factura int primary key,
Repuesto varchar(20),
Costo_Repuesto float,
Mano_De_Obra float,
Total_Factura float,
Total_Euros float,
Total_Pesetas float,
DNI_Cliente int,
foreign key(DNI_Cliente) references CLIENTES(DNI_Cliente),
ID_Mecanico int,
foreign key(ID_Mecanico) references MECANICO(ID_Mecanico)
)