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

