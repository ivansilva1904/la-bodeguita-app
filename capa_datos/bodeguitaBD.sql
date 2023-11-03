
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

create table tipoBebida(
	idTipoBebida INT IDENTITY PRIMARY KEY,
	descripcion VARCHAR(30)
);

create table marca(
	idMarca INT IDENTITY PRIMARY KEY,
	descripcion VARCHAR(30)
);

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

CREATE TABLE formasPago(
	idFormaPago INT IDENTITY PRIMARY KEY,
	descripcion VARCHAR(30)
);

CREATE TABLE ventasCabecera(
	idVentaCabecera INT IDENTITY PRIMARY KEY,
	fecha DATE,
	idFormaPago INT,
	nroTarjeta BIGINT DEFAULT NULL,
	importeTotal FLOAT,
	dniEmpleado INT,
	dniCliente INT,
	CONSTRAINT FK_formaPago FOREIGN KEY (idFormaPago) REFERENCES formasPago(idFormaPago),
	CONSTRAINT FK_empleado FOREIGN KEY (dniEmpleado) REFERENCES empleados(dniEmpleado),
	CONSTRAINT FK_cliente FOREIGN KEY (dniCliente) REFERENCES clientes(dniCliente)
);

CREATE TABLE ventasDetalle(
	idVentaDetalle INT IDENTITY,
	idVentaCabecera INT,
	idProducto INT,
	cantidad INT,
	precioParcial FLOAT,
	CONSTRAINT FK_ventaCabecera FOREIGN KEY (idVentaCabecera) REFERENCES ventasCabecera(idVentaCabecera),
	CONSTRAINT PK_detalle_cabecera PRIMARY KEY (idVentaDetalle, idVentaCabecera),
	CONSTRAINT FK_producto FOREIGN KEY (idProducto) REFERENCES producto(idProducto)
);

/* Datos de entidades accesorio */

INSERT INTO tiposEmpleados(descripcion) VALUES('Vendedor');
INSERT INTO tiposEmpleados(descripcion) VALUES('Supervisor');
INSERT INTO tiposEmpleados(descripcion) VALUES('Administrador');

INSERT INTO empleados(dniEmpleado, nombre, apellido, fechaNac, fechaIncorp, direccion, telefono, email, contraseña, idTipoEmpleado)
VALUES(11223344, 'El', 'Administrador', '1900-01-01', GETDATE(), 'Algun lugar', '3123-438283', 'eladmin@gmail.com', '1234', 3);
INSERT INTO empleados(dniEmpleado, nombre, apellido, fechaNac, fechaIncorp, direccion, telefono, email, contraseña, idTipoEmpleado)
VALUES(22334455, 'El', 'Supervisor', '1900-01-01', GETDATE(), 'Otro lugar', '3123-4382432', 'elsuper@gmail.com', '12345', 2);
INSERT INTO empleados(dniEmpleado, nombre, apellido, fechaNac, fechaIncorp, direccion, telefono, email, contraseña, idTipoEmpleado)
VALUES(33445566, 'El', 'Vendedor', '1900-01-01', GETDATE(), 'el infierno', '3123-64754', 'elvendedor@gmail.com', '123456', 1);

SELECT GETDATE();
SELECT * FROM empleados;
/* datos de prueba sin DATE*/

INSERT INTO proveedor(cuitProveedor,razonSocial,direccion,telefono,email) VALUES(77111111117,'Whiskeria UNO','Calle Falsa 111','3794000111','whiskeriaUNO@gmail.com');
INSERT INTO proveedor(cuitProveedor,razonSocial,direccion,telefono,email) VALUES(77222222227,'CERVECERIA DOS','Calle Falsa 222','3794000222','cerveceriaDOS@live.com');
INSERT INTO proveedor(cuitProveedor,razonSocial,direccion,telefono,email) VALUES(77333333337,'Viñedo tres','Calle Falsa 333','3794000333','viñedosTRES@gmail.com');

INSERT INTO tipoBebida(descripcion) VALUES('Licor');
INSERT INTO tipoBebida(descripcion) VALUES('Gaseosa');
INSERT INTO tipoBebida(descripcion) VALUES('Cerveza');
INSERT INTO tipoBebida(descripcion) VALUES('Whisky');
INSERT INTO tipoBebida(descripcion) VALUES('Vino');

INSERT INTO marca(descripcion) VALUES('Quilmes');
INSERT INTO marca(descripcion) VALUES('Jack Daniels');
INSERT INTO marca(descripcion) VALUES('Absolut');
INSERT INTO marca(descripcion) VALUES('Torres');
INSERT INTO marca(descripcion) VALUES('Antinori');

INSERT INTO producto(descripcion,idMarca,precioCompra,precioVenta,stockMinimo,StockActual,cuitProveedor,idTipoBebida)
VALUES ('Quilmes Bajo Cero 1L',1,1000.11,1250.50,5,30,77222222227,3);
INSERT INTO producto(descripcion,idMarca,precioCompra,precioVenta,stockMinimo,StockActual,cuitProveedor,idTipoBebida)
VALUES ('Old No 7 Tennessee', 2, 1500, 2500.50, 15, 30, 77111111117, 4);
INSERT INTO producto(descripcion,idMarca,precioCompra,precioVenta,stockMinimo,StockActual,cuitProveedor,idTipoBebida)
VALUES ('Honey', 2, 1700, 3000.50, 5, 40, 77111111117, 4);
INSERT INTO producto(descripcion,idMarca,precioCompra,precioVenta,stockMinimo,StockActual,cuitProveedor,idTipoBebida)
VALUES ('Quilmes 1890', 1, 1500, 2100.50, 20, 50, 77222222227, 3);
INSERT INTO producto(descripcion,idMarca,precioCompra,precioVenta,stockMinimo,StockActual,cuitProveedor,idTipoBebida)
VALUES ('Malbec ultima cepa', 4, 3200, 5000, 10, 13, 77333333337, 5);
INSERT INTO producto(descripcion,idMarca,precioCompra,precioVenta,stockMinimo,StockActual,cuitProveedor,idTipoBebida)
VALUES ('Cosecha tardia y echada a perder', 5, 10000, 20000, 1, 100, 77333333337, 5);

INSERT INTO formasPago(descripcion)
VALUES('Efectivo');
INSERT INTO formasPago(descripcion)
VALUES('Tarjeta');
	
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
