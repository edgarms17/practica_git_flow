Create Database CompraVenta
Use CompraVenta

Create table Usuario(
IdUser int primary key not null auto_increment,
Nombre_Usuario varchar(30) not null,
Nombre varchar(30) not null,
Apellido_Paterno varchar(25) not null,
Apellido_Materno varchar(25) not null,
Correo_Electronico varchar(50) not null,
Telefono varchar(10),
País varchar(15) not null
)

#CRUD
Insert into Usuario (Nombre_Usuario,Nombre,Apellido_Paterno,Apellido_Materno,Correo_Electronico,Telefono,País) 
values ("Luis123","Luis Antonio","Alonso","Villegas","luis@gmail.com","6645554874","México")
Insert into Usuario (Nombre_Usuario,Nombre,Apellido_Paterno,Apellido_Materno,Correo_Electronico,Telefono,País) 
values ("Antonio223","Antonio","Alvarez","Rodriguez","ARdrgz123@gmail.com","6642117335","Chile")

Select * from Usuario where IdUser=1 or IdUser=2

update Usuario set Correo_Electronico="Rodriguez23@gmail.com" where IdUser=2

Delete from Usuario where IdUser=2

Create table Productos(
IdProducto int primary key not null auto_increment,
Nombre_Producto varchar(30) not null,
Imagen Mediumblob not null,
Descripcion_general varchar(40) not null,
Descripcion_completa varchar(500) not null,
Precio decimal(6,2) not null
)

#CRUD
Insert into Productos (Nombre_Producto,Imagen,Descripcion_general,Descripcion_completa,Precio) 
values ("Cama matrimonial","dsadsadsa.png","Colchon matrimonial 2.5m x 2m","Para las personas que buscan comodidad y descansar en un lugar más amplio, les presentamos el nuevo colchón Randóm de Restonic. Cuenta con un Soporte de Nivel Medio a Semifirme. Con Tecnología Resorte Continuos (Resortes con alto desempeño).
Además, Dispone de Sistema Worry Free, manteniendo el alto nivel de Soporte y Confort por mucho más tiempo.",2499.99)
Insert into Productos (Nombre_Producto,Imagen,Descripcion_general,Descripcion_completa,Precio) 
values ("Xiaomi redmi note 10","sdadseweee.png","Xiaomi redmi note 10 6GB","Fotografía profesional en tu bolsillo
Descubre infinitas posibilidades para tus fotos con las 4 cámaras principales de tu equipo. 
Pon a prueba tu creatividad y juega con la iluminación, diferentes planos y efectos para obtener grandes resultados.",5499.99)

Select * from Productos where IdProducto=1 or IdProducto=2

update Productos set Imagen="jjk232.png" where IdProducto=2

Delete from Productos where IdProducto=2

Create table Direccion(
IdDireccion int primary key not null auto_increment,
IdUsuario int not null,
Calle varchar(20) not null,
Numero_ext varchar(5) not null,
Colonia varchar(20) not null,
Ciudad varchar(15) not null,
CodigoPostal varchar(5) not null,
CONSTRAINT FOREIGN KEY fk_usuario (idUsuario) REFERENCES usuario (IdUser)
)

Create table Vendedor(
IdVendedor int primary key not null auto_increment,
IdUsuario int not null,
Reputacion varchar(20) not null,
CONSTRAINT FOREIGN KEY fk_usuario (idUsuario) REFERENCES usuario (IdUser)
)
