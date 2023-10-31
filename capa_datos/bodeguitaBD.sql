
CREATE DATABASE bodeguitaBD;

USE bodeguitaBD;

CREATE TABLE tiposEmpleados(
	idTipoEmpleado INT IDENTITY PRIMARY KEY,
	descripcion VARCHAR(30)
);

CREATE TABLE empleados(
	dniEmpleado INT PRIMARY KEY,
	nombre VARCHAR(30),
	apellido VARCHAR(30),
	fechaNac DATE,
	fechaIncorp DATE,
	fechaDeshab DATE,
	direccion VARCHAR(30),
	telefono VARCHAR(30),
	email VARCHAR(30),
	contraseña VARCHAR(30),
	idTipoEmpleado INT,
	baja BIT DEFAULT 0,
	CONSTRAINT fk_tipoEmpleado FOREIGN KEY (idTipoEmpleado) REFERENCES tiposEmpleados(idTipoEmpleado)
);

CREATE TABLE clientes(
	dniCliente INT PRIMARY KEY,
	nombre VARCHAR(30),
	apellido VARCHAR(30),
	email VARCHAR(30),
	fechaNac DATE,
	baja BIT
);

/* Datos de entidades accesorio */

INSERT INTO tiposEmpleados(descripcion) VALUES('Vendedor');
INSERT INTO tiposEmpleados(descripcion) VALUES('Supervisor');
INSERT INTO tiposEmpleados(descripcion) VALUES('Administrador');

/* Agregada parte de proveedor 23/10/ */

CREATE TABLE proveedor(
	cuitProveedor BIGINT PRIMARY KEY,
	razonSocial VARCHAR(50),
	direccion VARCHAR(30),
	telefono VARCHAR(30),
	email VARCHAR(30),
	fechaAlta DATE,
	fechaBaja DATE,
	baja BIT DEFAULT 0
);

/* datos de prueba sin DATE*/

INSERT INTO proveedor(cuitProveedor,razonSocial,direccion,telefono,email) VALUES(77111111117,'Whiskeria UNO','Calle Falsa 111','3794000111','whiskeriaUNO@gmail.com');
INSERT INTO proveedor(cuitProveedor,razonSocial,direccion,telefono,email) VALUES(77222222227,'CERVECERIA DOS','Calle Falsa 222','3794000222','cerveceriaDOS@live.com');
INSERT INTO proveedor(cuitProveedor,razonSocial,direccion,telefono,email) VALUES(77333333337,'Viñedo tres','Calle Falsa 333','3794000333','viñedosTRES@gmail.com');

/**/

create table tipoBebida(
	idTipoBebida INT IDENTITY PRIMARY KEY,
	descripcion VARCHAR(30)
);
INSERT INTO tipoBebida(descripcion) VALUES('Licor');
INSERT INTO tipoBebida(descripcion) VALUES('Gaseosa');
INSERT INTO tipoBebida(descripcion) VALUES('Cerveza');
INSERT INTO tipoBebida(descripcion) VALUES('Whisky');

create table marca(
	idMarca INT IDENTITY PRIMARY KEY,
	descripcion VARCHAR(30)
);

INSERT INTO marca(descripcion) VALUES('Quilmes');
INSERT INTO marca(descripcion) VALUES('Jack Daniels');
INSERT INTO marca(descripcion) VALUES('Absolut');

create table producto(
	idProducto INT IDENTITY PRIMARY KEY,
	descripcion VARCHAR(50),
	idMarca INT,
	precioCompra float,
	precioVenta float,
	stockMinimo int,
	stockActual int,
	cuitProveedor bigint,
	idTipoBebida int,
	baja bit default 0,
	CONSTRAINT fk_idMarca FOREIGN KEY (idMarca) REFERENCES marca(idMarca),
	CONSTRAINT fk_cuitProveedor FOREIGN KEY (cuitProveedor) REFERENCES proveedor(cuitProveedor),
	CONSTRAINT fk_tipoBebida FOREIGN KEY (idTipoBebida) REFERENCES tipoBebida(idTipoBebida)
);

INSERT INTO producto(descripcion,idMarca,precioCompra,precioVenta,stockMinimo,StockActual,cuitProveedor,idTipoBebida)
VALUES ('Quilmes Bajo Cero 1L',1,1000.11,1250.50,5,30,77222222227,3)
/* hasta 24/10*/

	
SELECT producto.idProducto AS 'ID Producto',producto.descripcion AS 'Descripcion',marca.descripcion AS 'Marca',
producto.precioCompra AS 'Precio Compra',producto.precioVenta AS 'Precio Venta',producto.stockMinimo AS 'Stock Minimo',
producto.stockActual AS 'Stock Actual',proveedor.razonSocial AS 'Nombre Proveedor',tipoBebida.descripcion AS 'Tipo Bebida',producto.baja AS 'Baja'
	FROM producto
	INNER JOIN marca ON (producto.idMarca = marca.idMarca)
	INNER JOIN proveedor ON (producto.cuitProveedor = proveedor.cuitProveedor)
	INNER JOIN tipoBebida ON (producto.idTipoBebida = tipoBebida.idTipoBebida)
	GROUP BY producto.idProducto,producto.descripcion,marca.descripcion
	/*INNER JOIN marca.idMarc*/
	
	select * from producto
