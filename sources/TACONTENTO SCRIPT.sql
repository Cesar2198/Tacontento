create database Tacontento;

use Tacontento;

create table Clasificaciones(
idClasificacion int not null primary key auto_increment,
clasificacion varchar(100) not null
)engine = innodb;

create table Opciones(
idOpcion int not null primary key auto_increment,
opcion varchar(100) not null,
idClasificacion int not null,
foreign key(idClasificacion) references Clasificaciones(idClasificacion)
)engine= innodb;

create table Roles(
idRol int not null primary key auto_increment,
nombre varchar(100) not null,
estado int not null,
descripcion varchar(150)
)engine = innodb;

create table Permisos(
idPermiso int not null primary key auto_increment,
idRol int not null,
idOpcion int not null,
foreign key(idRol) references Roles(idRol),
foreign key(idOpcion) references Opciones(idOpcion)
)engine= innodb;

create table Empleados(
idEmpleado int not null primary key auto_increment,
Nombres varchar(100) not null,
Apellidos varchar(100) not null,
DUI varchar(10) not null,
NIT varchar(18) not null,
Direccion varchar(75) not null,
Genero enum('MASCULINO','FEMENINO') not null,
Fecha_Nac date not null,
estado int not null
)engine = innodb;

create table Usuarios(
idUsuario int not null primary key auto_increment,
usuario varchar(100) not null,
password varchar(100) not null,
idRol int not null,
estado int not null,
idEmpleado int not null,
foreign key(idRol) references Roles(idRol),
foreign key(idEmpleado) references Empleados(idEmpleado)
)engine=innodb;

create table ClasificacionesOrdenes(
idClasificacionOrden int not null primary key auto_increment,
clasificacionOrden varchar(50) not null
)engine=innodb;

create table Ordenes(
idOrden int not null primary key auto_increment,
nombre varchar(100) not null,
precio decimal(5,2) not null,
descripcion varchar(100),
idClasificacionOrden  int not null,
Estado int not null,
foreign key(idClasificacionOrden ) references ClasificacionesOrdenes(idClasificacionOrden )
)engine=innodb;

create table Pedidos(
idPedido int not null primary key auto_increment,
nombreCliente varchar(50) not null,
total decimal(5,2) not null,
fecha timestamp not null,
tipoPago int not null,
estado int not null,
idUsuario int not null,
foreign key(idUsuario) references Usuarios(idUsuario)
)engine=innodb;

create table Incidentes(
idIncidente int not null primary key auto_increment,
descripcion varchar(100) not null,
precio decimal(5,2) not null,
idPedido int not null,
foreign key(idPedido) references Pedidos(idPedido)
)engine=innodb;

create table DetallesPedidos(
idDetallePedido int not null primary key auto_increment,
idPedido int not null,
idOrden int not null,
cantidad int not null,
precio decimal(5,2) not null,
foreign key(idPedido) references Pedidos(idPedido),
foreign key(idOrden) references Ordenes(idOrden)
)engine = innodb;