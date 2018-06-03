USE GD1C2018

GO


/* Dropeo de tablas si estas ya existen */

IF OBJECT_ID ('traeme_la_copa_messi.HabitacionPorReserva','U') IS NOT NULL
    DROP TABLE traeme_la_copa_messi.HabitacionPorReserva;

IF OBJECT_ID ('traeme_la_copa_messi.ConsumiblePorReserva','U') IS NOT NULL
    DROP TABLE traeme_la_copa_messi.ConsumiblePorReserva;

IF OBJECT_ID ('traeme_la_copa_messi.Consumible','U') IS NOT NULL
    DROP TABLE traeme_la_copa_messi.Consumible;

IF OBJECT_ID ('traeme_la_copa_messi.LogEstadia','U') IS NOT NULL
    DROP TABLE traeme_la_copa_messi.LogEstadia;

IF OBJECT_ID ('traeme_la_copa_messi.Reserva','U') IS NOT NULL
    DROP TABLE traeme_la_copa_messi.Reserva;

IF OBJECT_ID ('traeme_la_copa_messi.EstadoReserva','U') IS NOT NULL
    DROP TABLE traeme_la_copa_messi.EstadoReserva;

IF OBJECT_ID ('TRAEME_LA_COPA_MESSI.Habitacion','U') IS NOT NULL
    DROP TABLE TRAEME_LA_COPA_MESSI.Habitacion;

IF OBJECT_ID ('TRAEME_LA_COPA_MESSI.TipoHabitacion','U') IS NOT NULL
    DROP TABLE TRAEME_LA_COPA_MESSI.TipoHabitacion;

IF OBJECT_ID ('TRAEME_LA_COPA_MESSI.InhabilitacionesHotel','U') IS NOT NULL
    DROP TABLE TRAEME_LA_COPA_MESSI.InhabilitacionesHotel;

IF OBJECT_ID ('TRAEME_LA_COPA_MESSI.RegimenPorHotel','U') IS NOT NULL
    DROP TABLE TRAEME_LA_COPA_MESSI.RegimenPorHotel;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.UsuariosPorHotel','U') IS NOT NULL    
	DROP TABLE TRAEME_LA_COPA_MESSI.UsuariosPorHotel;

IF OBJECT_ID ('TRAEME_LA_COPA_MESSI.Hotel','U') IS NOT NULL
    DROP TABLE TRAEME_LA_COPA_MESSI.Hotel;

IF OBJECT_ID ('TRAEME_LA_COPA_MESSI.RegimenEstadia','U') IS NOT NULL
    DROP TABLE TRAEME_LA_COPA_MESSI.RegimenEstadia;

IF OBJECT_ID ('TRAEME_LA_COPA_MESSI.FuncionalidadPorRol','U') IS NOT NULL
    DROP TABLE TRAEME_LA_COPA_MESSI.FuncionalidadPorRol;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.Funcionalidad','U') IS NOT NULL    
	DROP TABLE TRAEME_LA_COPA_MESSI.Funcionalidad;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.Cliente_Inconsistente','U') IS NOT NULL    
	DROP TABLE TRAEME_LA_COPA_MESSI.Cliente_Inconsistente;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.Cliente','U') IS NOT NULL    
	DROP TABLE TRAEME_LA_COPA_MESSI.Cliente;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.Factura_Inconsistente','U') IS NOT NULL    
	DROP TABLE TRAEME_LA_COPA_MESSI.Factura_Inconsistente;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.Factura','U') IS NOT NULL    
	DROP TABLE TRAEME_LA_COPA_MESSI.Factura;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.Item_Factura','U') IS NOT NULL    
	DROP TABLE TRAEME_LA_COPA_MESSI.Item_Factura;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.RolPorUsuario','U') IS NOT NULL    
	DROP TABLE TRAEME_LA_COPA_MESSI.RolPorUsuario;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.Rol','U') IS NOT NULL    
	DROP TABLE TRAEME_LA_COPA_MESSI.Rol;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.Usuario','U') IS NOT NULL    
	DROP TABLE TRAEME_LA_COPA_MESSI.Usuario;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.TipoDoc','U') IS NOT NULL    
	DROP TABLE TRAEME_LA_COPA_MESSI.TipoDoc;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.Direccion','U') IS NOT NULL    
	DROP TABLE TRAEME_LA_COPA_MESSI.Direccion;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.Direcciones_Hoteles','U') IS NOT NULL    
	DROP TABLE TRAEME_LA_COPA_MESSI.Direcciones_hoteles;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.Habitacion','U') IS NOT NULL    
	DROP TABLE TRAEME_LA_COPA_MESSI.Habitacion;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.RegimenPorHotel','U') IS NOT NULL    
	DROP TABLE TRAEME_LA_COPA_MESSI.RegimenPorHotel;


/* Dropeo de procedures si ya existen */

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.validarUsuario','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.validarUsuario;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.getUsuario','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.getUsuario;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.bloquearUsuario','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.bloquearUsuario;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.getRolesUsuario','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.getRolesUsuario;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.getRegimenes','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.getRegimenes;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.getFuncionalidades','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.getFuncionalidades;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.persistirRol','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.persistirRol;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.actualizarFuncionalidadesPorRol','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.actualizarFuncionalidadesPorRol;
	
IF OBJECT_ID('TRAEME_LA_COPA_MESSI.crearHotel','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.crearHotel;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.getClientesFiltrados','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.getClientesFiltrados;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.getHotelesFiltrados','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.getHotelesFiltrados;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.newCliente','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.newCliente;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.darBajaHotel','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.darBajaHotel;




/* Dropeo las views si ya existen */



/* Se dropea schema si existe*/

IF EXISTS (SELECT SCHEMA_NAME FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = 'TRAEME_LA_COPA_MESSI')
    DROP SCHEMA TRAEME_LA_COPA_MESSI

GO


/* Se crea schema */ 

CREATE SCHEMA TRAEME_LA_COPA_MESSI AUTHORIZATION gdHotel2018

GO


CREATE TABLE TRAEME_LA_COPA_MESSI.Direccion(
IdDir int IDENTITY(1,1) PRIMARY KEY,
Ciudad nvarchar(255) NULL,
Calle nvarchar(255) NOT NULL,
NroCalle numeric(18,0) NOT NULL,
Piso numeric(18,0) NULL,
Departamento nvarchar(50) NULL,
Localidad nvarchar(255) NULL,
Pais nvarchar(255) NULL
);

CREATE TABLE TRAEME_LA_COPA_MESSI.TipoDoc(
IdTipo int IDENTITY(1,1) PRIMARY KEY,
Descripcion nvarchar(255) NOT NULL
);

CREATE TABLE TRAEME_LA_COPA_MESSI.Usuario( 
Username nvarchar(255) PRIMARY KEY,
Pass nvarchar(255)  NOT NULL,
Direccion int FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.Direccion(IdDir) NULL,
Nombre nvarchar(255) NULL,
Apellido nvarchar(255) NULL,
TipoDoc int FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.TipoDoc(IdTipo),
NroDocumento int NULL,
Email nvarchar(255) UNIQUE NULL,
Telefono int NULL,
FechaNacimiento datetime NULL,
LogsFallidos int NOT NULL DEFAULT 0,
Estado bit DEFAULT 0
);

CREATE TABLE TRAEME_LA_COPA_MESSI.Rol(
IdRol int IDENTITY(1,1) PRIMARY KEY,
Nombre nvarchar(255) NOT NULL,
Estado BIT DEFAULT 0 
);

CREATE TABLE TRAEME_LA_COPA_MESSI.RolPorUsuario(
Username nvarchar(255) FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.Usuario(Username),
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
Fact_Nro int NOT NULL,
Fact_Fecha DateTime NOT NULL,
Fact_Total int NOT NULL,
PRIMARY KEY (Fact_Nro)
);

CREATE TABLE TRAEME_LA_COPA_MESSI.Factura_Inconsistente(
Fact_Nro int,
Fact_Fecha DateTime,
Fact_Total int,
PRIMARY KEY (Fact_Nro)
);

CREATE TABLE TRAEME_LA_COPA_MESSI.Cliente(
IdCliente int IDENTITY(1,1) PRIMARY KEY,
Email nvarchar(255) UNIQUE,
Direccion int NULL, --FALTA EN LA MIGRACION ASOCIAR CON LAS DIRECCIONES CORRESPONDIENTES
Nombre nvarchar(255) NOT NULL,
Apellido nvarchar(255) NOT NULL,
TipoDoc nvarchar(255) NULL,
NumDoc numeric(18,0) NOT NULL,
Telefono numeric(18,0) NULL,
PaisOrigen nvarchar(255) NULL,
Nacionalidad nvarchar(255) NOT NULL,
FechaNacimiento Datetime NOT NULL,
);

CREATE TABLE TRAEME_LA_COPA_MESSI.Cliente_Inconsistente( --Agrego id porque en esta tabla el email se repite
IdClienteInconsistente int IDENTITY(1,1) PRIMARY KEY,
Email nvarchar(255),
Direccion int NULL, --FALTA EN LA MIGRACION ASOCIAR CON LAS DIRECCIONES CORRESPONDIENTES
Nombre nvarchar(255) NOT NULL,
Apellido nvarchar(255) NOT NULL,
TipoDoc nvarchar(255) NULL,
NumDoc numeric(18,0) NOT NULL,
Telefono numeric(18,0),
PaisOrigen nvarchar(255)  NULL,
Nacionalidad nvarchar(255) NOT NULL,
FechaNacimiento Datetime NOT NULL,
);


CREATE TABLE TRAEME_LA_COPA_MESSI.Funcionalidad(
IdFunc int IDENTITY (1,1) PRIMARY KEY,
Descripcion nvarchar(255),
Estado BIT DEFAULT 0,
);

CREATE TABLE TRAEME_LA_COPA_MESSI.FuncionalidadPorRol(
IdFunc int FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.Funcionalidad(IdFunc),
IdRol int FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.Rol(IdRol),
CONSTRAINT IdFuncionalidadPorRol PRIMARY KEY(IdFunc,IdRol)
);

CREATE TABLE TRAEME_LA_COPA_MESSI.RegimenEstadia(
IdRegimenEstadia int IDENTITY(1,1) PRIMARY KEY,
Descripcion nvarchar(255) NOT NULL,
PrecioBase int NOT NULL,
EstadoRegimenEstadia BIT DEFAULT 0,
);

CREATE TABLE TRAEME_LA_COPA_MESSI.Hotel(
IdHotel int IDENTITY(1,1) PRIMARY KEY,
Nombre nvarchar(255) NULL,
Mail nvarchar(255) NULL,
Telefono int NULL,
Direccion int FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.Direccion(IdDir),
CantEstrellas int  NULL,
PorcentajeEstrellas numeric(18,0) NULL,
FechaCreacion datetime NULL,
EstadoHotel BIT DEFAULT 0
);

CREATE TABLE TRAEME_LA_COPA_MESSI.UsuariosPorHotel(
IdHotel int FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.Hotel(IdHotel),
Username nvarchar(255) FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.Usuario(Username),
User_desempenio nvarchar(255) NOT NULL
CONSTRAINT IdUsuariosPorHotel PRIMARY KEY(IdHotel,Username)
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
Codigo int PRIMARY KEY,
Descripcion nvarchar(255) NOT NULL,
Porcentual int NOT NULL
);

CREATE TABLE TRAEME_LA_COPA_MESSI.Habitacion(
IdHotel int FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.Hotel(IdHotel),
Numero int,
Piso int NOT NULL,
Ubicacion nvarchar(255) NOT NULL,
CodigoTipo int FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.TipoHabitacion(Codigo),
Estado BIT DEFAULT 0
CONSTRAINT IdHabitacion PRIMARY KEY(IdHotel,Numero)
);


create table traeme_la_copa_messi.EstadoReserva(
IdEstadoReserva int IDENTITY(1,1) PRIMARY KEY not null,
DescripEstadoReserva nvarchar(255) not null,
);

-- IdCliente o IdClienteIncon va a estar en NULL (uno de los dos) porque no se puede referenciar a dos clientes, uno solo hace reserva
create table traeme_la_copa_messi.Reserva(
IdReserva numeric(18,0) PRIMARY KEY,
IdCliente int FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.Cliente(IdCliente) null,
IdClienteInconsistente int FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.Cliente_Inconsistente(IdClienteInconsistente) null,
FechaReserva datetime  NULL,
FechaCheckIn datetime  NULL,
CantidadNochesReservadas numeric(18,0)  NULL,
CantidadNochesUsadas numeric(18,0)  NULL,
EstadoReserva int FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.EstadoReserva(IdEstadoReserva)  null,
RegimenEstadiaId int FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.RegimenEstadia(IdRegimenEstadia)  null
);


create table traeme_la_copa_messi.LogEstadia(
IdLogEstadia int IDENTITY(1,1) PRIMARY KEY not null,
Tipo nvarchar not null,
Autor nvarchar not null,
FechaInicio datetime not null,
CantidadNocheUsadas int,
FechaFin datetime,
ReservaId numeric(18,0) FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.Reserva(IdReserva)
);

create table traeme_la_copa_messi.Consumible(
IdConsumible numeric(18,0) IDENTITY(1,1) PRIMARY KEY not null,
Descripcion nvarchar(255) not null,
Precio numeric(18,2) not null,
);

create table traeme_la_copa_messi.ConsumiblePorReserva(
ConsumibleId numeric(18,0) FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.Consumible(IdConsumible),
ReservaID numeric(18,0) FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.Reserva(IdReserva),
CONSTRAINT IdConsumiblePorReserva PRIMARY KEY(ConsumibleId,ReservaID)
);

CREATE TABLE TRAEME_LA_COPA_MESSI.Direcciones_Hoteles(
IdDir_Hotel int IDENTITY(1,1) PRIMARY KEY,
Ciudad nvarchar(255) NULL,
Calle nvarchar(255) NOT NULL,
NroCalle int NOT NULL,
Piso int NULL,
Departamento nvarchar(255) NULL,
Localidad nvarchar(255) NULL,
Pais nvarchar(255) NULL
);


/*create table traeme_la_copa_messi.HabitacionPorReserva(
IdReserva numeric(18,0) FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.Reserva(IdReserva),
IdHotelHab int,
IdNumeroHab int,
CONSTRAINT IdConsumiblePorReserva PRIMARY KEY(IdReserva,IdHotelHab,IdNumeroHab),
FOREIGN KEY (IdHotelHab, IdNumeroHab) REFERENCES TRAEME_LA_COPA_MESSI.Habitacion(IdHotel,Numero)
); */


-----------------------------------------------------------------------/* Migracion de datos */-------------------------------------------------------------------------- 

-- Tipos de regimenes --

INSERT INTO TRAEME_LA_COPA_MESSI.RegimenEstadia(Descripcion,PrecioBase)
	SELECT DISTINCT Regimen_Descripcion , Regimen_Precio 
	FROM gd_esquema.Maestra 

-- Direcciones --

INSERT INTO TRAEME_LA_COPA_MESSI.Direcciones_Hoteles(Ciudad,Calle,NroCalle)
	SELECT DISTINCT Hotel_Ciudad, Hotel_Calle, Hotel_Nro_Calle
	FROM gd_esquema.Maestra

INSERT INTO TRAEME_LA_COPA_MESSI.Direccion(Ciudad,Calle,NroCalle) --Dejamos pais como null, aunque se podria determinar por la ciudad
	SELECT  Ciudad, Calle, NroCalle
	FROM TRAEME_LA_COPA_MESSI.Direcciones_Hoteles


INSERT INTO TRAEME_LA_COPA_MESSI.Direccion(Calle,NroCalle,Piso,Departamento)
	SELECT DISTINCT Cliente_Dom_Calle, Cliente_Nro_Calle, Cliente_Piso, Cliente_Depto
	FROM gd_esquema.Maestra

-- Tipo de documentos --

INSERT INTO TRAEME_LA_COPA_MESSI.TipoDoc(Descripcion) VALUES ('Pasaporte');

-- Usuarios --

INSERT INTO TRAEME_LA_COPA_MESSI.Usuario(Username,Pass) VALUES ('admin','e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7'); --Falta agregar su rol con funcionalidades

-- Roles --

INSERT INTO TRAEME_LA_COPA_MESSI.Rol(Nombre)
	VALUES ('Administrador'), ('Recepcionista'), ('Guest')

-- Rol por usuario --

INSERT INTO TRAEME_LA_COPA_MESSI.RolPorUsuario(Username,IdRol)
	VALUES ('admin',1)
				
-- Funcionalidades --

INSERT INTO TRAEME_LA_COPA_MESSI.Funcionalidad(Descripcion)
	VALUES ('ABM Hotel')

-- Funcionalidad por rol --

INSERT INTO TRAEME_LA_COPA_MESSI.FuncionalidadPorRol
	VALUES (1,1)

-- Facturas inconsistentes --

INSERT INTO TRAEME_LA_COPA_MESSI.Factura_Inconsistente
	SELECT DISTINCT Factura_Nro,Factura_Fecha,Factura_Total FROM gd_esquema.Maestra
	WHERE Factura_Nro IS NOT NULL

-- Clientes inconsistentes --

--FALTA EN LA MIGRACION ASOCIAR CON LAS DIRECCIONES CORRESPONDIENTES

INSERT INTO TRAEME_LA_COPA_MESSI.Cliente_Inconsistente(Email,Nombre,Apellido,NumDoc, Nacionalidad, FechaNacimiento, TipoDoc)
    SELECT DISTINCT Cliente_Mail, Cliente_Nombre, Cliente_Apellido, Cliente_Pasaporte_Nro, Cliente_Nacionalidad, Cliente_Fecha_Nac, 1
    FROM gd_esquema.Maestra 
    WHERE Cliente_Mail in
     (select t1.Cliente_Mail 
        from gd_esquema.Maestra t1, gd_esquema.Maestra t2
        where t1.Cliente_Mail = t2.Cliente_Mail and t1.Cliente_Pasaporte_Nro != t2.Cliente_Pasaporte_Nro
        group by t1.Cliente_Mail,t1.Cliente_Pasaporte_Nro, t2.Cliente_Pasaporte_Nro)

-- Clientes --

--FALTA EN LA MIGRACION ASOCIAR CON LAS DIRECCIONES CORRESPONDIENTES
INSERT INTO TRAEME_LA_COPA_MESSI.Cliente(Email,Nombre,Apellido,NumDoc, Nacionalidad, FechaNacimiento, TipoDoc,Direccion)
	SELECT DISTINCT Cliente_Mail, Cliente_Nombre, Cliente_Apellido, Cliente_Pasaporte_Nro, Cliente_Nacionalidad, Cliente_Fecha_Nac, 1,
		(SELECT IdDir FROM TRAEME_LA_COPA_MESSI.Direccion d , gd_esquema.Maestra m
		 WHERE d.Calle = m.Cliente_Dom_Calle AND d.Departamento = m.Cliente_Depto AND d.NroCalle = m.Cliente_Nro_Calle AND d.Piso = m.Cliente_Piso)
    FROM gd_esquema.Maestra 
    WHERE Cliente_Mail not in
	 (select t1.Cliente_Mail 
		from gd_esquema.Maestra t1, gd_esquema.Maestra t2
		where t1.Cliente_Mail = t2.Cliente_Mail and t1.Cliente_Pasaporte_Nro != t2.Cliente_Pasaporte_Nro
		group by t1.Cliente_Mail,t1.Cliente_Pasaporte_Nro, t2.Cliente_Pasaporte_Nro)

													


-- Hoteles --

INSERT INTO TRAEME_LA_COPA_MESSI.Hotel(Direccion) 
	SELECT IdDir_Hotel FROM TRAEME_LA_COPA_MESSI.Direcciones_Hoteles

UPDATE TRAEME_LA_COPA_MESSI.Hotel SET CantEstrellas =
(SELECT DISTINCT Hotel_CantEstrella FROM gd_esquema.Maestra m
 WHERE m.Hotel_Calle =
 (SELECT Calle FROM TRAEME_LA_COPA_MESSI.Direcciones_Hoteles WHERE IdDir_Hotel = Hotel.Direccion)
 AND
 m.Hotel_Nro_Calle = (SELECT NroCalle FROM TRAEME_LA_COPA_MESSI.Direcciones_Hoteles WHERE IdDir_Hotel = Hotel.Direccion)
 )

UPDATE TRAEME_LA_COPA_MESSI.Hotel SET PorcentajeEstrellas =
(SELECT DISTINCT Hotel_Recarga_Estrella FROM gd_esquema.Maestra m
 WHERE m.Hotel_Calle =
 (SELECT Calle FROM TRAEME_LA_COPA_MESSI.Direcciones_Hoteles WHERE IdDir_Hotel = Hotel.Direccion)
 AND
 m.Hotel_Nro_Calle = (SELECT NroCalle FROM TRAEME_LA_COPA_MESSI.Direcciones_Hoteles WHERE IdDir_Hotel = Hotel.Direccion)
 )


-- Tipo Habitacion --

INSERT INTO TRAEME_LA_COPA_MESSI.TipoHabitacion
	SELECT DISTINCT Habitacion_Tipo_Codigo, Habitacion_Tipo_Descripcion, Habitacion_Tipo_Porcentual
	FROM gd_esquema.Maestra


-- Habitacion --

INSERT INTO TRAEME_LA_COPA_MESSI.Habitacion(IdHotel,Numero,Piso,Ubicacion,CodigoTipo)
	SELECT DISTINCT h.IdHotel, m.Habitacion_Numero, m.Habitacion_Piso, m.Habitacion_Frente, m.Habitacion_Tipo_Codigo
	FROM TRAEME_LA_COPA_MESSI.Hotel h, gd_esquema.Maestra m
	WHERE h.Direccion =
		(SELECT IdDir_Hotel FROM TRAEME_LA_COPA_MESSI.Direcciones_Hoteles
		 WHERE Calle = m.Hotel_Calle AND NroCalle = m.Hotel_Nro_Calle AND Ciudad = m.Hotel_Ciudad)


-- Regimen por Hotel --

INSERT INTO TRAEME_LA_COPA_MESSI.RegimenPorHotel(IdHotel,IdRegimenEstadia)
	SELECT DISTINCT h.IdHotel, t.IdRegimenEstadia
	FROM TRAEME_LA_COPA_MESSI.Hotel h, gd_esquema.Maestra m, TRAEME_LA_COPA_MESSI.RegimenEstadia t
	WHERE h.Direccion =
		(SELECT IdDir_Hotel FROM TRAEME_LA_COPA_MESSI.Direcciones_Hoteles
		 WHERE Calle = m.Hotel_Calle AND NroCalle = m.Hotel_Nro_Calle AND Ciudad = m.Hotel_Ciudad)
		 AND
		 t.Descripcion = m.Regimen_Descripcion


-- Usuario por Hotel --

INSERT INTO TRAEME_LA_COPA_MESSI.UsuariosPorHotel(IdHotel,Username,User_desempenio)
	SELECT DISTINCT IdHotel,'admin', 'Administrador' FROM TRAEME_LA_COPA_MESSI.Hotel


-- Estado_Reserva --

/*Decidimos crear un nuevo estado "Reserva sistema anterior" porque no podemos inferir
la informacion necesaria para poner un estado correcto y sugerido por el enunciado en todas las reservas  */

INSERT INTO TRAEME_LA_COPA_MESSI.EstadoReserva(DescripEstadoReserva)
	 VALUES('Reserva sistema anterior') 


-- Reserva --

/*Falta agregar id clientes, estado reserva y regimen estadia id*/

INSERT INTO TRAEME_LA_COPA_MESSI.Reserva(IdReserva, FechaReserva, FechaCheckIn, CantidadNochesReservadas, CantidadNochesUsadas,EstadoReserva)

	SELECT DISTINCT m.Reserva_Codigo, m.Reserva_Fecha_Inicio, m.Estadia_Fecha_Inicio, m.Reserva_Cant_Noches, m.Estadia_Cant_Noches, 1 FROM gd_esquema.Maestra m
	WHERE m.Estadia_Fecha_Inicio IS NULL


UPDATE TRAEME_LA_COPA_MESSI.Reserva  SET
FechaCheckIn = (SELECT Estadia_Fecha_Inicio FROM gd_esquema.Maestra
					 WHERE Reserva_Codigo = IdReserva AND Estadia_Fecha_Inicio IS NOT NULL
					 GROUP BY Estadia_Fecha_Inicio),
CantidadNochesUsadas = (SELECT Estadia_Cant_Noches FROM gd_esquema.Maestra
							WHERE Reserva_Codigo = IdReserva AND Estadia_Cant_Noches IS NOT NULL
							GROUP BY Estadia_Cant_Noches)





-- Creacion de procedures --

/* Repositorio Usuarios */

GO
CREATE PROCEDURE TRAEME_LA_COPA_MESSI.validarUsuario
@usuarioNombre nvarchar(255),
@pass nvarchar(255)
AS
BEGIN
IF EXISTS (SELECT s.Username, s.Pass, s.Estado FROM TRAEME_LA_COPA_MESSI.Usuario s WHERE s.Username = @usuarioNombre AND s.Pass = @pass AND s.Estado = 0)
	BEGIN
		UPDATE TRAEME_LA_COPA_MESSI.Usuario SET LogsFallidos = 0 WHERE Username = @usuarioNombre
		RETURN 1
	END
ELSE
	IF EXISTS (SELECT s.Username, s.Estado FROM TRAEME_LA_COPA_MESSI.Usuario s WHERE s.Username = @usuarioNombre AND s.Estado = 0)
		BEGIN
			UPDATE TRAEME_LA_COPA_MESSI.Usuario SET LogsFallidos = LogsFallidos + 1 WHERE Username = @usuarioNombre 
			RETURN 0
		END
	ELSE
		RETURN -1
END


GO
CREATE PROCEDURE TRAEME_LA_COPA_MESSI.getUsuario

@usuarioNombre nvarchar(255)
AS

SELECT * FROM TRAEME_LA_COPA_MESSI.Usuario s WHERE s.Username = @usuarioNombre

GO
CREATE PROCEDURE TRAEME_LA_COPA_MESSI.bloquearUsuario

@usuarioId nvarchar(255)
AS

UPDATE TRAEME_LA_COPA_MESSI.Usuario SET Estado = 1 WHERE Username =  @usuarioId


GO
CREATE PROCEDURE TRAEME_LA_COPA_MESSI.getRolesUsuario

@IdUsuario nvarchar(255)

AS
BEGIN

	SELECT r.IdRol, r.Nombre, r.Estado

	FROM TRAEME_LA_COPA_MESSI.Usuario u 
		JOIN TRAEME_LA_COPA_MESSI.RolPorUsuario ru
			ON ru.Username = u.Username
		JOIN TRAEME_LA_COPA_MESSI.Rol r
			ON ru.IdRol = r.IdRol

	WHERE u.Username= @IdUsuario

END 


/* Repositorio Regimenes */

GO
CREATE PROCEDURE TRAEME_LA_COPA_MESSI.getRegimenes

AS
BEGIN

	SELECT IdRegimenEstadia, Descripcion, PrecioBase

	FROM TRAEME_LA_COPA_MESSI.RegimenEstadia WHERE EstadoRegimenEstadia = 0


END 


GO --obtener funcionalidades para abmRol
Create Procedure TRAEME_LA_COPA_MESSI.getFuncionalidades
as
begin

select *
from TRAEME_LA_COPA_MESSI.Funcionalidad
end


go
create procedure TRAEME_LA_COPA_MESSI.persistirRol
@nombreRol nvarchar(255), 
@funcionalidad nvarchar(255),
@estado int
as
begin
insert into TRAEME_LA_COPA_MESSI.Rol(Nombre,Estado)
values (@nombreRol,@estado)
end

go
create procedure TRAEME_LA_COPA_MESSI.actualizarFuncionalidadesPorRol
@funcionalidad nvarchar(255),
@rol nvarchar(255)
as
begin
insert into TRAEME_LA_COPA_MESSI.FuncionalidadPorRol (IdRol,IdFunc)
values ((select IdRol from TRAEME_LA_COPA_MESSI.Rol where Nombre = @rol), (select IdFunc from TRAEME_LA_COPA_MESSI.Funcionalidad))
end

/* Repositorio Hoteles */

GO
CREATE PROCEDURE TRAEME_LA_COPA_MESSI.crearHotel
@nombre nvarchar(255),
@mail nvarchar(255),
@telefono int,
@estrellas int,
@porcEstrellas numeric(18,0),
@regimen nvarchar(255),
@calle nvarchar(255),
@nroCalle int,
@ciudad nvarchar(255),
@pais nvarchar(255)

AS
BEGIN

	DECLARE @direccion_id int
	DECLARE @hotel_id int
	DECLARE @regimen_id int

	INSERT INTO TRAEME_LA_COPA_MESSI.Direccion(Calle,NroCalle,Ciudad,Pais) VALUES (@calle,@nroCalle,@ciudad,@pais)

	SET @direccion_id = (SELECT d.IdDir FROM TRAEME_LA_COPA_MESSI.Direccion d WHERE d.Calle = @calle AND d.NroCalle = @nroCalle AND d.Ciudad = @ciudad AND d.Pais = @pais)

	INSERT INTO TRAEME_LA_COPA_MESSI.Hotel (Nombre, Mail,Telefono,CantEstrellas,PorcentajeEstrellas,Direccion,FechaCreacion)
	VALUES (@nombre, @mail, @telefono, @estrellas, @porcEstrellas,@direccion_id,GETDATE())

	SET @hotel_id = (SELECT h.IdHotel FROM TRAEME_LA_COPA_MESSI.Hotel h WHERE h.Nombre = @nombre AND h.Mail = @mail AND h.Telefono = @telefono)
	SET @regimen_id = (SELECT r.IdRegimenEstadia FROM TRAEME_LA_COPA_MESSI.RegimenEstadia r WHERE r.Descripcion = @regimen)

	INSERT INTO TRAEME_LA_COPA_MESSI.RegimenPorHotel(IdHotel,IdRegimenEstadia)
	VALUES (@hotel_id, @regimen_id)

END 


GO
create procedure TRAEME_LA_COPA_MESSI.getHotelesFiltrados
@Nombre nvarchar(255),
@Ciudad nvarchar(255),
@Estrellas nvarchar(255),
@Pais nvarchar(255)

as
begin

	SELECT h.IdHotel, h.Nombre, h.Mail, h.Telefono, h.CantEstrellas, h.PorcentajeEstrellas, h.FechaCreacion, h.EstadoHotel, dh.Ciudad, dh.Pais, dh.Calle, dh.NroCalle FROM (TRAEME_LA_COPA_MESSI.Hotel h JOIN TRAEME_LA_COPA_MESSI.Direccion dh ON h.Direccion = dh.IdDir)
	WHERE 
	(h.Nombre LIKE '%' + @Nombre + '%' AND dh.Ciudad LIKE '%' + @Ciudad + '%' AND dh.Pais LIKE '%' + @Pais + '%' AND CAST(h.CantEstrellas AS NVARCHAR) LIKE '%' + @Estrellas  + '%')
	OR
	(@Nombre = '' AND @Pais = '' AND dh.Ciudad LIKE '%' + @Ciudad + '%' AND CAST(h.CantEstrellas AS NVARCHAR) LIKE '%' + @Estrellas + '%')
	OR
	(@Nombre = '' AND dh.Pais LIKE '%' + @Pais + '%' AND dh.Ciudad LIKE '%' + @Ciudad + '%' AND CAST(h.CantEstrellas AS NVARCHAR) LIKE '%' + @Estrellas + '%')
	OR
	(@Pais = '' AND h.Nombre LIKE '%' + @Nombre + '%' AND dh.Ciudad LIKE '%' + @Ciudad + '%' AND CAST(h.CantEstrellas AS NVARCHAR) LIKE '%' + @Estrellas + '%')

end

GO
CREATE PROCEDURE TRAEME_LA_COPA_MESSI.darBajaHotel
@hotelId int

AS
BEGIN

	UPDATE TRAEME_LA_COPA_MESSI.Hotel SET EstadoHotel = 1 WHERE IdHotel =  @hotelId
	
END



/* Repositorio Clientes */


GO
create procedure TRAEME_LA_COPA_MESSI.getClientesFiltrados
@Nombre nvarchar(255),
@Apellido nvarchar(255),
@Mail nvarchar(255),
@Tipo_Identificacion nvarchar(255),
@Numero_Identificacion numeric(18,0)

as
begin
	
	SELECT * FROM TRAEME_LA_COPA_MESSI.Cliente c
	WHERE 
	c.Nombre LIKE '%' + @Nombre + '%' AND c.Apellido LIKE '%' + @Apellido + '%' AND c.Email LIKE '%' + @Mail + '%' AND c.TipoDoc LIKE '%' + @Tipo_Identificacion + '%' AND CAST(c.NumDoc AS NVARCHAR) LIKE '%' + CAST(@Numero_Identificacion AS NVARCHAR) + '%'
	
	UNION

	SELECT *  FROM TRAEME_LA_COPA_MESSI.Cliente_Inconsistente ci
	WHERE
	ci.Nombre LIKE '%' + @Nombre + '%' AND ci.Apellido LIKE '%' + @Apellido + '%' AND ci.Email LIKE '%' + @Mail + '%' AND ci.TipoDoc LIKE '%' + @Tipo_Identificacion + '%' AND CAST(ci.NumDoc AS nvarchar) LIKE '%' + CAST(@Numero_Identificacion AS NVARCHAR) + '%'
	
end


GO
create procedure TRAEME_LA_COPA_MESSI.newCliente
@email nvarchar(255),
@nombre nvarchar(255),
@apellido nvarchar(255),
@tipoDoc nvarchar(255),
@numDoc numeric(18,0),
@telefono numeric(18,0),
@PaisOrigen nvarchar(255),
@Nacionalidad nvarchar(255),
@FechaNacimiento Datetime,
@ciudad nvarchar(255), 
@calle nvarchar(255), 
@nroCalle numeric(18,0),
@piso numeric(18,0),
@dpto nvarchar(50),
@localidad nvarchar(255),
@pais nvarchar(255)
as
begin transaction
	begin
		declare @IdDireccion int

		insert into TRAEME_LA_COPA_MESSI.Direccion (Ciudad, Calle, NroCalle, Piso, Departamento, Localidad, Pais)
		values(@ciudad, @calle, @nroCalle, @piso, @dpto, @localidad, @pais)

		set @IdDireccion = (select IdDir from TRAEME_LA_COPA_MESSI.Direccion where Ciudad=@ciudad and Calle=@calle and NroCalle=@nroCalle and Piso=@piso and Departamento=@dpto and Localidad=@localidad and Pais=@pais)

		insert into TRAEME_LA_COPA_MESSI.Cliente (Email, Direccion, Nombre, Apellido, TipoDoc, NumDoc, Telefono, PaisOrigen, Nacionalidad, FechaNacimiento)
		values(@email, @IdDireccion, @nombre, @apellido, @tipoDoc, @numDoc, @telefono, @PaisOrigen, @Nacionalidad, @FechaNacimiento)
	end
commit








