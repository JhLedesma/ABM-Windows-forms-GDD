USE GD1C2018

GO

/* Se dropea schema si existe*/

IF EXISTS (SELECT SCHEMA_NAME FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = 'TRAEME_LA_COPA_MESSI')
    DROP SCHEMA TRAEME_LA_COPA_MESSI

GO


/* Se crea schema */ 

CREATE SCHEMA TRAEME_LA_COPA_MESSI AUTHORIZATION gdHotel2018

GO

CREATE TABLE TRAEME_LA_COPA_MESSI.Direccion(
IdDir int IDENTITY(1,1) PRIMARY KEY,
Ciudad nvarchar(255) NOT NULL,
Calle nvarchar(255) NOT NULL,
NroCalle int NOT NULL,
Piso int NULL,
Departamento nvarchar(255) NULL,
Localidad nvarchar(255) NOT NULL,
Pais nvarchar(255) NOT NULL
);

CREATE TABLE TRAEME_LA_COPA_MESSI.TipoDoc(
IdTipo int IDENTITY(1,1) PRIMARY KEY,
Descripcion nvarchar(255) NOT NULL
);

CREATE TABLE TRAEME_LA_COPA_MESSI.Usuario( --Falta direccion
Username int IDENTITY(1,1) PRIMARY KEY,
Pass nvarchar(255)  NOT NULL,
Direccion int FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.Direccion(IdDir),
Nombre nvarchar(255) NOT NULL,
Apellido nvarchar(255) NOT NULL,
TipoDoc int FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.TipoDoc(IdTipo),
NroDocumento int NOT NULL,
Email nvarchar(255) UNIQUE NOT NULL,
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

CREATE TABLE TRAEME_LA_COPA_MESSI.RegimenEstadia(
IdRegimenEstadia int IDENTITY(1,1) PRIMARY KEY,
Descripcion nvarchar(255) NOT NULL,
PrecioBase int NOT NULL,
Estado int NOT NULL --No seberia ser int, luego lo cambio
);

CREATE TABLE TRAEME_LA_COPA_MESSI.Hotel(
IdHotel int IDENTITY(1,1) PRIMARY KEY,
Nombre nvarchar(255) NOT NULL,
Mail nvarchar(255) UNIQUE NOT NULL,
Telefono int NOT NULL,
Direccion int FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.Direccion(IdDir),
CantEstrellas int NOT NULL,
PorcentajeEstrellas numeric(18,0) NOT NULL,
FechaCreacion datetime NOT NULL
);

CREATE TABLE TRAEME_LA_COPA_MESSI.RegimenPorHotel(
IdHotel int FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.Hotel(IdHotel),
IdRegimenEstadia int FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.RegimenEstadia(IdRegimenEstadia)
CONSTRAINT IdRegimenPorHotel PRIMARY KEY(IdHotel,IdRegimenEstadia)
);

CREATE TABLE TRAEME_LA_COPA_MESSI.InhabilitacionesHotel(
IdHotel int FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.Hotel(IdHotel) PRIMARY KEY,
FechaInicio datetime NOT NULL,
FechaFin datetime NULL,
Descripcion nvarchar(255) NOT NULL
);

CREATE TABLE TRAEME_LA_COPA_MESSI.TipoHabitacion(
Codigo int IDENTITY(1,1) PRIMARY KEY,
Descripcion nvarchar(255) NOT NULL,
Porcentual int NOT NULL
);

CREATE TABLE TRAEME_LA_COPA_MESSI.Habitacion(
IdHotel int FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.Hotel(IdHotel),
Numero int,
Piso int NOT NULL,
Ubicacion nvarchar(255) NOT NULL,
CodigoTipo int FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.TipoHabitacion(Codigo),
Estado int NOT NULL --esto no deberia ser int, luego lo veo
);




