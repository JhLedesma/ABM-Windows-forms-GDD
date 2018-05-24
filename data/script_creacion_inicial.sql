USE GD1C2018

GO

/* Se dropea schema si existe*/

IF EXISTS (SELECT SCHEMA_NAME FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = 'TRAEME_LA_COPA_MESSI')
    DROP SCHEMA TRAEME_LA_COPA_MESSI

GO


/* Se crea schema */ 

CREATE SCHEMA TRAEME_LA_COPA_MESSI AUTHORIZATION gdHotel2018

GO

CREATE TABLE TRAEME_LA_COPA_MESSI.Usuario(
Username int IDENTITY(1,1) PRIMARY KEY,
Pass nvarchar(255)  NOT NULL,
Nombre nvarchar(255) NOT NULL,
Apellido nvarchar(255) NOT NULL,
TipoDoc nvarchar(255) NOT NULL,
NroDocumento int NOT NULL,
Email nvarchar(255) UNIQUE,
Telefono int NULL,
FechaNacimiento datetime NULL,
LogsFallidos int NOT NULL
);

CREATE TABLE TRAEME_LA_COPA_MESSI.Rol(
IdRol int IDENTITY(1,1) PRIMARY KEY,
Nombre nvarchar(255) NOT NULL,
Estado int NOT NULL --No deberia ser int, luego lo cambio
);

CREATE TABLE TRAEME_LA_COPA_MESSI.RolPorUsuario(
Username int FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.Usuario(Username),
IdRol int FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.Rol(IdRol),
CONSTRAINT IdRolPorUsuario PRIMARY KEY(Username,IdRol)
);

CREATE TABLE TRAEME_LA_COPA_MESSI.Item_Factura(
Fac_Numero int,
IdFac int,
-- Reserva --Agregar despues de crear Reserva
-- Consumible 
Cantidad int,
Monto int,
PRIMARY KEY (Fac_Numero , IdFac)
);


CREATE TABLE TRAEME_LA_COPA_MESSI.Factura(
Fact_Nro int,
Fact_Fecha DateTime,
Fact_Total int,
PRIMARY KEY (Fact_Nro)
);

CREATE TABLE TRAEME_LA_COPA_MESSI.Factura_Inconsistente(
Fact_Nro int,
Fact_Fecha DateTime,
Fact_Total int,
PRIMARY KEY (Fact_Nro)
);

CREATE TABLE TRAEME_LA_COPA_MESSI.Cliente(
Email nvarchar(255) UNIQUE,
Direccion nvarchar(255)NOT NULL,
Nombre nvarchar(255) NOT NULL,
Apellido nvarchar(255) NOT NULL,
TipoDoc nvarchar(255) NOT NULL,
NumDoc int NOT NULL,
Telefono int,
PaisOrigen nvarchar(255) NOT NULL,
Nacionalidad nvarchar(255) NOT NULL,
FechaNacimiento Datetime NOT NULL,
);

CREATE TABLE TRAEME_LA_COPA_MESSI.Cliente_Inconsistente(
Email nvarchar(255) UNIQUE,
Direccion nvarchar(255)NOT NULL,
Nombre nvarchar(255) NOT NULL,
Apellido nvarchar(255) NOT NULL,
TipoDoc nvarchar(255) NOT NULL,
NumDoc int NOT NULL,
Telefono int,
PaisOrigen nvarchar(255) NOT NULL,
Nacionalidad nvarchar(255) NOT NULL,
FechaNacimiento Datetime NOT NULL,
);


CREATE TABLE TRAEME_LA_COPA_MESSI.Funcionalidad(
IdFunc int PRIMARY KEY,
Descripcion nvarchar(255),
Estado nvarchar(255),
);

CREATE TABLE TRAEME_LA_COPA_MESSI.FuncionalidadPorRol(
IdFunc int FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.Funcionalidad(IdFunc),
IdRol int FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.Rol(IdRol),
CONSTRAINT FuncionalidadPorRol PRIMARY KEY(IdFunc,IdRol)
);