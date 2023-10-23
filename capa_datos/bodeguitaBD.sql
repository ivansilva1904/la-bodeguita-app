
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