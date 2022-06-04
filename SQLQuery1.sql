create database usuarios;
use  usuarios;
CREATE TABLE administrador ( usuario VARCHAR(20), contraseña VARCHAR(20) );
INSERT INTO administrador VALUES ( 'admin', '1234' );
INSERT INTO administrador VALUES ( 'admin2', 'contra' );
INSERT INTO administrador VALUES ( 'beto', 'beto' );

CREATE TABLE cajero ( usuario VARCHAR(20), contraseña VARCHAR(20) );
INSERT INTO cajero VALUES ( 'cajero1', '1234' );
INSERT INTO cajero VALUES ( 'pedro', 'contra' );
INSERT INTO cajero VALUES ( 'vazquez', 'beto' );

create database inventario;
use inventario;
CREATE TABLE productos ( idproducto int primary key, nombre VARCHAR(20), cantidad int,precio int );
INSERT INTO productos VALUES ( 1001, 'router huawei',20,3000 );
CREATE TABLE cajeros ( idcajero int primary key, nombre VARCHAR(20), fechadecontratacion VARCHAR(20),horastrabajadas int );
INSERT INTO cajeros VALUES ( 1200, 'beto','25-de-mayo',50 );
use usuarios;
select * from cajero;

CREATE TABLE clientes ( idcliente int primary key, nombre VARCHAR(20), adeudo int );
INSERT INTO clientes VALUES ( 3000, 'Juan manuel',200 );
