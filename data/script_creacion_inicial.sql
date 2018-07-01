USE GD1C2018

GO


/* Dropeo de tablas si estas ya existen */

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.fechasFinEstadias','U') IS NOT NULL    
	DROP TABLE TRAEME_LA_COPA_MESSI.fechasFinEstadias;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.ClienteIncRegistradoPorReserva','U') IS NOT NULL    --2
	DROP TABLE TRAEME_LA_COPA_MESSI.ClienteIncRegistradoPorReserva;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.ClienteRegistradoPorReserva','U') IS NOT NULL    
	DROP TABLE TRAEME_LA_COPA_MESSI.ClienteRegistradoPorReserva;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.Item_Factura','U') IS NOT NULL    
	DROP TABLE TRAEME_LA_COPA_MESSI.Item_Factura;

if OBJECT_ID('TRAEME_LA_COPA_MESSI.ConsumiblePorHabitacion','U') is not null
	drop table TRAEME_LA_COPA_MESSI.ConsumiblePorHabitacion;

if OBJECT_ID('Traeme_la_Copa_messi.HabitacionPorReserva','U') is not null
	drop table Traeme_la_Copa_messi.HabitacionPorReserva;

if OBJECT_ID('Traeme_la_Copa_messi.ReservasDeClientesIncon','U') is not null
	drop table Traeme_la_Copa_messi.ReservasDeClientesIncon;

if OBJECT_ID('Traeme_la_Copa_messi.ReservasDeClientes','U') is not null
	drop table Traeme_la_Copa_messi.ReservasDeClientes;

if OBJECT_ID('Traeme_la_Copa_messi.MailsInconsistentes','U') is not null
	drop table Traeme_la_Copa_messi.MailsInconsistentes;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.Direcciones_Hoteles','U') IS NOT NULL    
	DROP TABLE TRAEME_LA_COPA_MESSI.Direcciones_hoteles;

IF OBJECT_ID ('traeme_la_copa_messi.ConsumiblePorReserva','U') IS NOT NULL
    DROP TABLE traeme_la_copa_messi.ConsumiblePorReserva;

IF OBJECT_ID ('traeme_la_copa_messi.Consumible','U') IS NOT NULL
    DROP TABLE traeme_la_copa_messi.Consumible;

IF OBJECT_ID ('traeme_la_copa_messi.LogEstadia','U') IS NOT NULL
    DROP TABLE traeme_la_copa_messi.LogEstadia;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.Log_Reserva','U') IS NOT NULL    --1
	DROP TABLE TRAEME_LA_COPA_MESSI.Log_Reserva;

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

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.getClientesFiltradosActivos','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.getClientesFiltradosActivos;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.getClientesFiltradosConInactivos','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.getClientesFiltradosConInactivos;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.getHotelesFiltrados','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.getHotelesFiltrados;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.newCliente','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.newCliente;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.darBajaHotel','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.darBajaHotel;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.modificarHotel','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.modificarHotel;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.comprobarRegimen','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.comprobarRegimen;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.agregarRegimenHotel','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.agregarRegimenHotel;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.eliminarRegimenesHotel','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.eliminarRegimenesHotel;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.agregarRegimenPorHotel','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.agregarRegimenPorHotel;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.getRegimenesHotel','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.getRegimenesHotel;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.getHotel','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.getHotel;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.getCliente','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.getCliente;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.getDireccion','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.getDireccion;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.modificarCliente','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.modificarCliente;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.darDeBajaCliente','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.darDeBajaCliente;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.getClientesFiltrados','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.getClientesFiltrados;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.validarNombreDeRol','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.validarNombreDeRol;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.agregarNuevoRol','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.agregarNuevoRol;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.actualizarFuncionalidadporRol','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.actualizarFuncionalidadporRol;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.getRoles','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.getRoles;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.getFuncionalidadPorRol','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.getFuncionalidadPorRol;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.getTipoDocumentos','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.getTipoDocumentos;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.getTipoDocumento','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.getTipoDocumento;	

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.getHoteles','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.getHoteles;		

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.newUsuario','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.newUsuario;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.modificarRol','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.modificarRol;	
	
IF OBJECT_ID('TRAEME_LA_COPA_MESSI.eliminarFuncionalidadesDelRol','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.eliminarFuncionalidadesDelRol;		
	
IF OBJECT_ID('TRAEME_LA_COPA_MESSI.eliminarRol','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.eliminarRol;	

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.newUsuario','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.newUsuario;			

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.validarCancelacionUsuario','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.validarCancelacionUsuario;		
		
IF OBJECT_ID('TRAEME_LA_COPA_MESSI.validarCancelacion','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.validarCancelacion;			

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.newUsuario','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.newUsuario;
	
IF OBJECT_ID('TRAEME_LA_COPA_MESSI.getTiposHabitaciones','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.getTiposHabitaciones;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.crearHabitacion','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.crearHabitacion;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.newRolPorUsuario','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.newRolPorUsuario;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.newUsuariosPorHotel','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.newUsuariosPorHotel;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.getUsuariosFiltradosConInactivos','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.getUsuariosFiltradosConInactivos;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.validarMailUsuario','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.validarMailUsuario;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.getHabitacionesFiltradas','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.getHabitacionesFiltradas;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.cancelarReserva','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.cancelarReserva;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.getHotelesDeUsuario','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.getHotelesDeUsuario;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.modificarUsuario','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.modificarUsuario;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.eliminarRolesDeUsuario','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.eliminarRolesDeUsuario;
	
IF OBJECT_ID('TRAEME_LA_COPA_MESSI.eliminarHotelesDeUsuario','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.eliminarHotelesDeUsuario;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.getHabitacion','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.getHabitacion;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.modificarHabitacion','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.modificarHabitacion;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.darBajaHabitacion','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.darBajaHabitacion;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.cancelarReserva','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.cancelarReserva;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.comprobarNumReserva','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.comprobarNumReserva;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.getClienteReserva','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.getClienteReserva;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.getUsuariosFiltradosSinInactivos','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.getUsuariosFiltradosSinInactivos;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.darDeBajaUsuario','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.darDeBajaUsuario;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.getConsumibles','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.getConsumibles;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.newClienteReturnId','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.newClienteReturnId;	

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.hacerCheckIn','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.hacerCheckIn;	

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.generarLogEstadia','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.generarLogEstadia;		
	
IF OBJECT_ID('TRAEME_LA_COPA_MESSI.validarMailCliente','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.validarMailCliente;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.hacerCheckOut','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.hacerCheckOut;

	

/* Dropeo las views si ya existen */



/* Se dropea schema si existe*/

IF EXISTS (SELECT SCHEMA_NAME FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = 'TRAEME_LA_COPA_MESSI')
    DROP SCHEMA TRAEME_LA_COPA_MESSI

GO


/* Se crea schema */ 

CREATE SCHEMA TRAEME_LA_COPA_MESSI AUTHORIZATION gdHotel2018

GO





Create table TRAEME_LA_COPA_MESSI.Log_Reserva( --QUE ES ESTO? NO TIENE REFERENCIA A RESERVA
LogId int identity(1,1) Primary key,
Log_Tipo nvarchar(255),
Log_UsuarioId nvarchar(255),
Log_Motivo nvarchar (255),
Log_Fecha Datetime
);


CREATE TABLE TRAEME_LA_COPA_MESSI.Direccion(
IdDir int IDENTITY(1,1) PRIMARY KEY,
Ciudad nvarchar(255) DEFAULT '',
Calle nvarchar(255) DEFAULT '',
NroCalle numeric(18,0) DEFAULT 0,
Piso numeric(18,0) DEFAULT 0,
Departamento nvarchar(50) DEFAULT '',
Localidad nvarchar(255) DEFAULT '',
Pais nvarchar(255) DEFAULT '',
);

CREATE TABLE TRAEME_LA_COPA_MESSI.TipoDoc(
IdTipo int IDENTITY(1,1) PRIMARY KEY,
Descripcion nvarchar(255) NOT NULL
);

CREATE TABLE TRAEME_LA_COPA_MESSI.Usuario( 
Username nvarchar(255) PRIMARY KEY,
Pass nvarchar(255)  NOT NULL,
Direccion int FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.Direccion(IdDir) not null,
Nombre nvarchar(255) not null,
Apellido nvarchar(255) not null,
TipoDoc int FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.TipoDoc(IdTipo) not null,
NroDocumento numeric(18,0) not null,
Email nvarchar(255) UNIQUE not null,
Telefono numeric(18,0) not null,
FechaNacimiento datetime not null,
LogsFallidos int DEFAULT 0,
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

CREATE TABLE TRAEME_LA_COPA_MESSI.Factura(
Fact_Nro int PRIMARY KEY,
Fact_Fecha DateTime NOT NULL,
Fact_Total int NOT NULL
);

CREATE TABLE TRAEME_LA_COPA_MESSI.Factura_Inconsistente(
Fact_Nro int,
Fact_Fecha DateTime,
Fact_Total numeric (18,2),
PRIMARY KEY (Fact_Nro)
);


CREATE TABLE TRAEME_LA_COPA_MESSI.Cliente(
IdCliente int IDENTITY(1,1) PRIMARY KEY,
Email nvarchar(255) UNIQUE,
Direccion int FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.Direccion(IdDir) not null, --FALTA EN LA MIGRACION ASOCIAR CON LAS DIRECCIONES CORRESPONDIENTES
Nombre nvarchar(255) NOT NULL,
Apellido nvarchar(255) NOT NULL,
TipoDoc int FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.TipoDoc(IdTipo) NOT NULL,
NumDoc numeric(18,0) NOT NULL,
Telefono numeric(18,0) DEFAULT -1,
PaisOrigen nvarchar(255) DEFAULT '',
Nacionalidad nvarchar(255) NOT NULL,
FechaNacimiento Datetime NOT NULL,
Estado BIT DEFAULT 0,
);

CREATE TABLE TRAEME_LA_COPA_MESSI.Cliente_Inconsistente( --Agrego id porque en esta tabla el email se repite
IdCliente int IDENTITY(1,1) PRIMARY KEY,
Email nvarchar(255),
Direccion int FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.Direccion(IdDir) not null, --FALTA EN LA MIGRACION ASOCIAR CON LAS DIRECCIONES CORRESPONDIENTES
Nombre nvarchar(255) NOT NULL,
Apellido nvarchar(255) NOT NULL,
TipoDoc int FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.TipoDoc(IdTipo) NOT NULL,
NumDoc numeric(18,0) NOT NULL,
Telefono numeric(18,0) DEFAULT -1,
PaisOrigen nvarchar(255)  DEFAULT '',
Nacionalidad nvarchar(255) NOT NULL,
FechaNacimiento Datetime NOT NULL,
Estado BIT DEFAULT 0,
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
Nombre nvarchar(255) DEFAULT '',
Mail nvarchar(255) DEFAULT '',
Telefono int DEFAULT -1,
Direccion int FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.Direccion(IdDir),
CantEstrellas int  NULL,
PorcentajeEstrellas numeric(18,0) NULL,
FechaCreacion datetime DEFAULT GETDATE()
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
Porcentual numeric(12,2) NOT NULL
);

CREATE TABLE TRAEME_LA_COPA_MESSI.Habitacion(
IdHotel int FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.Hotel(IdHotel),
Numero int,
Piso int NOT NULL,
Ubicacion nvarchar(255) NOT NULL,
CodigoTipo int FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.TipoHabitacion(Codigo),
Estado BIT DEFAULT 0,
Descripcion nvarchar(255) DEFAULT '',
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
IdClienteInconsistente int FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.Cliente_Inconsistente(IdCliente) null,
IdHotel int FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.Hotel(IdHotel) null, --Cambiar a not null
tipoHabitacion int FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.TipoHabitacion(Codigo) null,
FechaReserva datetime  NULL,
FechaGeneracionReserva datetime NOT NULL,
CantidadNochesReservadas numeric(18,0)  NULL,
EstadoReserva int FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.EstadoReserva(IdEstadoReserva)  null,
RegimenEstadiaId int FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.RegimenEstadia(IdRegimenEstadia)  null
);

create table traeme_la_copa_messi.LogEstadia(
IdLogEstadia int IDENTITY(1,1) PRIMARY KEY ,
Tipo nvarchar null,
Autor nvarchar null,
FechaInicio datetime null,
CantidadNocheUsadas int,
FechaFin datetime,
ReservaId numeric(18,0) FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.Reserva(IdReserva)
);

create table traeme_la_copa_messi.Consumible(
IdConsumible numeric(18,0) PRIMARY KEY not null,
Descripcion nvarchar(255) not null,
Precio numeric(18,2) not null,
);

create table traeme_la_copa_messi.ConsumiblePorReserva(
ConsumibleId numeric(18,0) FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.Consumible(IdConsumible),
ReservaID numeric(18,0) FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.Reserva(IdReserva),
Cantidad int NOT NULL,
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

create table Traeme_la_Copa_messi.MailsInconsistentes(
mailInconsistente nvarchar(255) not null Primary key,
);

CREATE TABLE TRAEME_LA_COPA_MESSI.ReservasDeClientes(
IdClienteAux int,
IdReservaAux int,
CONSTRAINT IdReservasDeClientes PRIMARY KEY(IdClienteAux, IdReservaAux)
);

CREATE TABLE TRAEME_LA_COPA_MESSI.ReservasDeClientesIncon(
IdClienteInconAux int,
IdReservaAux int,
CONSTRAINT IdReservasDeClientesIncon PRIMARY KEY(IdClienteInconAux, IdReservaAux)
);

CREATE TABLE TRAEME_LA_COPA_MESSI.HabitacionPorReserva(
IdHotel int,
NumeroHabitacion int,
IdReserva numeric(18,0) FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.Reserva(IdReserva),
CONSTRAINT FK_Habitacion FOREIGN KEY(IdHotel, NumeroHabitacion) REFERENCES TRAEME_LA_COPA_MESSI.Habitacion(IdHotel, Numero)
);

Create Table TRAEME_LA_COPA_MESSI.ConsumiblePorHabitacion(
idHotel int,
NumeroHabitacion int,
ConsumibleId numeric (18,0) Foreign key references TRAEME_LA_COPA_MESSI.Consumible(IdConsumible),
CONSTRAINT FK_ConsPorHab FOREIGN KEY(IdHotel, NumeroHabitacion) REFERENCES TRAEME_LA_COPA_MESSI.Habitacion(IdHotel, Numero)
);

CREATE TABLE TRAEME_LA_COPA_MESSI.Item_Factura(
Id_item int IDENTITY (1,1) PRIMARY KEY,
Fac_Numero int FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.Factura(Fact_Nro),
Fac_Numero_Inc int FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.Factura_Inconsistente(Fact_nro),
IdReserva numeric(18,0) FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.Reserva(IdReserva),
IdConsumible numeric(18,0) FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.Consumible(IdConsumible),
Cantidad int,
Monto int
);

create table traeme_la_copa_messi.ClienteRegistradoPorReserva(
ClienteId int FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.Cliente(IdCliente),
ReservaId numeric(18,0) FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.Reserva(IdReserva),
CONSTRAINT IdAcompaniantePorReserva PRIMARY KEY(ClienteId,ReservaId)
);

CREATE TABLE TRAEME_LA_COPA_MESSI.ClienteIncRegistradoPorReserva(
ClienteId int FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.Cliente_Inconsistente(IdCliente) ,
ReservaId numeric(18,0) FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.Reserva(IdReserva),
CONSTRAINT IdAcompanianteIncPorReserva PRIMARY KEY(ClienteId,ReservaId)
);

CREATE TABLE TRAEME_LA_COPA_MESSI.fechasFinEstadias(
Reserva int PRIMARY KEY,
fechaFin datetime
);

-----------------------------------------------------------------------/* Migracion de datos */-------------------------------------------------------------------------- 

-- Tablas auxiliares creacion clientes --

insert into TRAEME_LA_COPA_MESSI.MailsInconsistentes(mailInconsistente)
select distinct t1.Cliente_Mail 
        from gd_esquema.Maestra t1 JOIN gd_esquema.Maestra t2 ON t1.Cliente_Mail = t2.Cliente_Mail
        where (t1.Cliente_Pasaporte_Nro != t2.Cliente_Pasaporte_Nro)
        group by t1.Cliente_Mail;


INSERT INTO TRAEME_LA_COPA_MESSI.MailsInconsistentes(mailInconsistente)
SELECT DISTINCT t1.Cliente_Mail 
        from gd_esquema.Maestra t1 JOIN gd_esquema.Maestra t2 ON t1.Cliente_Pasaporte_Nro = t2.Cliente_Pasaporte_Nro
        where  t1.Cliente_Mail not in (select * from TRAEME_LA_COPA_MESSI.MailsInconsistentes) and(t1.Cliente_Mail != t2.Cliente_Mail)
        group by t1.Cliente_Mail;


-- Tipos de regimenes --

INSERT INTO TRAEME_LA_COPA_MESSI.RegimenEstadia(Descripcion,PrecioBase)
	SELECT DISTINCT Regimen_Descripcion , Regimen_Precio 
	FROM gd_esquema.Maestra 

-- Direcciones --

INSERT INTO TRAEME_LA_COPA_MESSI.Direcciones_Hoteles(Ciudad,Calle,NroCalle,Pais)
	SELECT DISTINCT Hotel_Ciudad, Hotel_Calle, Hotel_Nro_Calle,''
	FROM gd_esquema.Maestra

INSERT INTO TRAEME_LA_COPA_MESSI.Direccion(Ciudad,Calle,NroCalle) --Dejamos pais como null, aunque se podria determinar por la ciudad
	SELECT Ciudad, Calle, NroCalle
	FROM TRAEME_LA_COPA_MESSI.Direcciones_Hoteles


INSERT INTO TRAEME_LA_COPA_MESSI.Direccion(Calle,NroCalle,Piso,Departamento)
	SELECT DISTINCT Cliente_Dom_Calle, Cliente_Nro_Calle, Cliente_Piso, Cliente_Depto
	FROM gd_esquema.Maestra

-- Tipo de documentos --

INSERT INTO TRAEME_LA_COPA_MESSI.TipoDoc(Descripcion) VALUES ('Pasaporte');

-- Usuarios --
declare @tipoDoc int
set @tipoDoc = (select top 1 IdTipo from TRAEME_LA_COPA_MESSI.TipoDoc)
declare @direccion int
set @direccion = (select top 1 IdDir from TRAEME_LA_COPA_MESSI.Direccion)
INSERT INTO TRAEME_LA_COPA_MESSI.Usuario(Username,Pass, Nombre, Apellido, Email, NroDocumento, Telefono, FechaNacimiento, TipoDoc, Direccion) VALUES ('admin','e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7', '', '', '', 0, 0, GETDATE(),@tipoDoc,@direccion); --Falta agregar su rol con funcionalidades

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



INSERT INTO TRAEME_LA_COPA_MESSI.Cliente_Inconsistente(Email,Nombre,Apellido,NumDoc, Nacionalidad, FechaNacimiento, TipoDoc, Direccion)
    select distinct Cliente_Mail, Cliente_Nombre, Cliente_Apellido,Cliente_Pasaporte_Nro, Cliente_Nacionalidad, Cliente_Fecha_Nac, 1, IdDir
from gd_esquema.Maestra m join TRAEME_LA_COPA_MESSI.Direccion d on (d.Calle = m.Cliente_Dom_Calle and m.Cliente_Depto = d.Departamento and 
m.Cliente_Nro_Calle = d.NroCalle and m.Cliente_Piso = d.Piso)
where Cliente_Mail in (select mailInconsistente from TRAEME_LA_COPA_MESSI.MailsInconsistentes) 

-- Clientes --

INSERT INTO TRAEME_LA_COPA_MESSI.Cliente(Email,Nombre,Apellido,NumDoc, Nacionalidad, FechaNacimiento, TipoDoc, Direccion)
	select distinct Cliente_Mail, Cliente_Nombre, Cliente_Apellido, Cliente_Pasaporte_Nro, Cliente_Nacionalidad, Cliente_Fecha_Nac, 1, IdDir
from gd_esquema.Maestra m join TRAEME_LA_COPA_MESSI.Direccion d on (d.Calle = m.Cliente_Dom_Calle and m.Cliente_Depto = d.Departamento and 
m.Cliente_Nro_Calle = d.NroCalle and m.Cliente_Piso = d.Piso)
where Cliente_Mail not in (select mailInconsistente from TRAEME_LA_COPA_MESSI.MailsInconsistentes) 

											


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

INSERT INTO TRAEME_LA_COPA_MESSI.TipoHabitacion(Codigo, Descripcion, Porcentual)
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

INSERT INTO TRAEME_LA_COPA_MESSI.EstadoReserva(DescripEstadoReserva)
	 VALUES('Reserva Cancelada Por Recepcion')

INSERT INTO TRAEME_LA_COPA_MESSI.EstadoReserva(DescripEstadoReserva)
	 VALUES('Reserva Cancelada Por Cliente')

INSERT INTO TRAEME_LA_COPA_MESSI.EstadoReserva(DescripEstadoReserva)
	 VALUES('Reserva Cancelada Por No-Show')
	 
INSERT INTO TRAEME_LA_COPA_MESSI.EstadoReserva(DescripEstadoReserva)
	 VALUES('Reserva Correcta') 
	 
INSERT INTO TRAEME_LA_COPA_MESSI.EstadoReserva(DescripEstadoReserva)
	 VALUES('Reserva Efectivizada') 
	 
INSERT INTO TRAEME_LA_COPA_MESSI.EstadoReserva(DescripEstadoReserva)
	 VALUES('Reserva Modificada')  


-- Tablas auxiliares creacion de reservas --

INSERT INTO TRAEME_LA_COPA_MESSI.ReservasDeClientes
SELECT DISTINCT IdCliente, Reserva_Codigo FROM TRAEME_LA_COPA_MESSI.Cliente JOIN gd_esquema.Maestra ON NumDoc = Cliente_Pasaporte_Nro;

INSERT INTO TRAEME_LA_COPA_MESSI.ReservasDeClientesIncon
SELECT DISTINCT IdCliente, Reserva_Codigo FROM TRAEME_LA_COPA_MESSI.Cliente_Inconsistente JOIN gd_esquema.Maestra ON NumDoc = Cliente_Pasaporte_Nro AND Email = Cliente_Mail;


-- Reserva --

INSERT INTO TRAEME_LA_COPA_MESSI.Reserva(IdReserva, IdHotel, FechaReserva, CantidadNochesReservadas,RegimenEstadiaId, FechaGeneracionReserva)


	SELECT DISTINCT m.Reserva_Codigo, h.IdHotel, m.Reserva_Fecha_Inicio, m.Estadia_Cant_Noches,
	(SELECT IdRegimenEstadia FROM TRAEME_LA_COPA_MESSI.RegimenEstadia WHERE Descripcion = m.Regimen_Descripcion), CAST('1950-10-10 12:35:29.123' AS datetime)

	FROM

	(gd_esquema.Maestra m JOIN TRAEME_LA_COPA_MESSI.Direcciones_Hoteles d ON m.Hotel_Calle = d.Calle AND m.Hotel_Nro_Calle = d.NroCalle AND m.Hotel_Ciudad = d.Ciudad)
	JOIN TRAEME_LA_COPA_MESSI.Hotel h ON h.Direccion = d.IdDir_Hotel
	WHERE m.Estadia_Fecha_Inicio IS NULL


UPDATE TRAEME_LA_COPA_MESSI.Reserva  SET  

IdCliente = (SELECT IdClienteAux FROM TRAEME_LA_COPA_MESSI.ReservasDeClientes  WHERE IdReservaAux = IdReserva),

IdClienteInconsistente = (SELECT IdClienteInconAux FROM TRAEME_LA_COPA_MESSI.ReservasDeClientesIncon  WHERE IdReservaAux = IdReserva)


-- LogEstadia --

INSERT INTO TRAEME_LA_COPA_MESSI.LogEstadia(ReservaId)
SELECT IdReserva FROM TRAEME_LA_COPA_MESSI.Reserva

UPDATE TRAEME_LA_COPA_MESSI.LogEstadia SET

CantidadNocheUsadas = (SELECT Estadia_Cant_Noches FROM gd_esquema.Maestra
							WHERE Reserva_Codigo = ReservaId AND Estadia_Cant_Noches IS NOT NULL
							GROUP BY Estadia_Cant_Noches),

FechaInicio = (SELECT Estadia_Fecha_Inicio FROM gd_esquema.Maestra
					 WHERE Reserva_Codigo = ReservaId AND Estadia_Fecha_Inicio IS NOT NULL
					 GROUP BY Estadia_Fecha_Inicio)


INSERT INTO TRAEME_LA_COPA_MESSI.fechasFinEstadias
SELECT ReservaId, FechaInicio+CantidadNocheUsadas FROM TRAEME_LA_COPA_MESSI.LogEstadia

UPDATE TRAEME_LA_COPA_MESSI.LogEstadia SET
FechaFin = (SELECT fechaFin FROM TRAEME_LA_COPA_MESSI.fechasFinEstadias f WHERE ReservaId = Reserva)
							

-- Carga de estado de reserva --

UPDATE TRAEME_LA_COPA_MESSI.Reserva SET EstadoReserva = 1 WHERE (SELECT FechaInicio FROM TRAEME_LA_COPA_MESSI.LogEstadia WHERE ReservaId = IdReserva) IS NULL

UPDATE TRAEME_LA_COPA_MESSI.Reserva SET EstadoReserva = 6 WHERE
(SELECT FechaInicio FROM TRAEME_LA_COPA_MESSI.LogEstadia WHERE ReservaId = IdReserva) IS NOT NULL AND
(SELECT FechaFin FROM TRAEME_LA_COPA_MESSI.LogEstadia WHERE ReservaId = IdReserva) IS NOT NULL


-- Consumibles --

INSERT INTO TRAEME_LA_COPA_MESSI.Consumible
SELECT DISTINCT Consumible_Codigo, Consumible_Descripcion, Consumible_Precio FROM gd_esquema.Maestra WHERE Consumible_Codigo IS NOT NULL

-- Consumible por reserva --

INSERT INTO TRAEME_LA_COPA_MESSI.ConsumiblePorReserva
SELECT Consumible_Codigo, Reserva_Codigo, SUM(Item_Factura_Cantidad) FROM gd_esquema.Maestra WHERE Consumible_Codigo IS NOT NULL GROUP BY Consumible_Codigo,Reserva_Codigo

-- Habitacion por reserva --

-- FALTA PRIMARY KEY EN TABLA
INSERT INTO TRAEME_LA_COPA_MESSI.HabitacionPorReserva
SELECT DISTINCT IdHotel, Habitacion_Numero, Reserva_Codigo FROM
TRAEME_LA_COPA_MESSI.Hotel h JOIN TRAEME_LA_COPA_MESSI.Direcciones_Hoteles d
ON h.Direccion = d.IdDir_Hotel, gd_esquema.Maestra m
WHERE m.Hotel_Calle = d.Calle AND m.Hotel_Ciudad = d.Ciudad AND m.Hotel_Nro_Calle = d.NroCalle


-- Consumible por habitacion
Insert into TRAEME_LA_COPA_MESSI.ConsumiblePorHabitacion
select distinct h.IdHotel,h.Numero,m.Consumible_Codigo
from TRAEME_LA_COPA_MESSI.Habitacion h join gd_esquema.Maestra m 
on (h.Numero = m.Habitacion_Numero and h.Piso = m.Habitacion_Piso and h.Ubicacion = m.Habitacion_Frente) where m.Consumible_Codigo is not null

--Factura
 
--item factura
--FALTA FACTURA PARA PROBAR Y AGREGAR IDFACTURA. FALTA VER SI SE CALCULA BIEN LA CANTIDAD TOTAL
insert into TRAEME_LA_COPA_MESSI.Item_Factura(Fac_Numero_Inc,IdReserva,IdConsumible,Cantidad,Monto)
select f.Fact_Nro, m.Reserva_Codigo, m.Consumible_Codigo, SUM(m.Item_Factura_Cantidad) as cantidad, m.Consumible_Precio * SUM(m.Item_Factura_Cantidad) as monto
from TRAEME_LA_COPA_MESSI.Factura_Inconsistente f JOIN gd_esquema.Maestra m
on (f.Fact_Nro = m.Factura_Nro) WHERE Consumible_Codigo IS NOT NULL
group by f.Fact_Nro, m.Reserva_Codigo, m.Consumible_Codigo, m.Consumible_Precio
ORDER BY Reserva_Codigo ASC


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


GO
create procedure TRAEME_LA_COPA_MESSI.newRolPorUsuario
@Rol int,
@username nvarchar(255)
as
begin transaction
	begin
		insert into TRAEME_LA_COPA_MESSI.RolPorUsuario (Username, IdRol)
			values(@username, @Rol)
	end
commit

GO
create procedure TRAEME_LA_COPA_MESSI.newUsuariosPorHotel
@hotelId int,
@username nvarchar(255),
@User_desempenio nvarchar(255)
as
begin transaction
	begin
		insert into TRAEME_LA_COPA_MESSI.UsuariosPorHotel (IdHotel, Username, User_desempenio)
			values(@hotelId, @username, @User_desempenio)
	end
commit


GO
create procedure TRAEME_LA_COPA_MESSI.newUsuario
@user nvarchar(255),
@pass nvarchar(255),
@email nvarchar(255),
@nombre nvarchar(255),
@apellido nvarchar(255),
@tipoDoc int,
@numDoc numeric(18,0),
@telefono numeric(18,0),
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
		declare @direccion int

		insert into TRAEME_LA_COPA_MESSI.Direccion (Ciudad, Calle, NroCalle, Piso, Departamento, Localidad, Pais)
			values(@ciudad, @calle, @nroCalle, @piso, @dpto, @localidad, @pais)

		set @direccion = (select IdDir from TRAEME_LA_COPA_MESSI.Direccion where Ciudad=@ciudad and Calle=@calle and NroCalle=@nroCalle and Piso=@piso and Departamento=@dpto and Localidad=@localidad and Pais=@pais)

		insert into TRAEME_LA_COPA_MESSI.Usuario (Username, Pass, Direccion, Nombre, Apellido, TipoDoc, NroDocumento, Email, Telefono, FechaNacimiento)
			values(@user, @pass, @direccion, @nombre, @apellido, @tipoDoc, @numDoc, @email, @telefono, @FechaNacimiento)
	end
commit


GO
create procedure TRAEME_LA_COPA_MESSI.getUsuariosFiltradosConInactivos
@Nombre nvarchar(255),
@Apellido nvarchar(255),
@Username nvarchar(255),
@Numero_Identificacion numeric(18,0)
as
begin
	
	SELECT Username, Nombre, Apellido,
	  NroDocumento, Telefono, FechaNacimiento,
	(case Estado when 0 then 'Activo' else 'Inactivo' end) as Estado
	FROM TRAEME_LA_COPA_MESSI.Usuario
	WHERE 
		Nombre LIKE '%' + @Nombre + '%' or Apellido LIKE '%' + @Apellido + '%' or Username LIKE '%' + @Username + '%' or CAST(NroDocumento AS NVARCHAR) LIKE '%' + CAST(@Numero_Identificacion AS NVARCHAR) + '%'
end



GO
create procedure TRAEME_LA_COPA_MESSI.getUsuariosFiltradosSinInactivos
@Nombre nvarchar(255),
@Apellido nvarchar(255),
@Username nvarchar(255),
@Numero_Identificacion numeric(18,0)
as
begin
	
	SELECT Username, Nombre, Apellido,
	  NroDocumento, Telefono, FechaNacimiento,
	(case Estado when 0 then 'Activo' else 'Inactivo' end) as Estado
	FROM TRAEME_LA_COPA_MESSI.Usuario
	WHERE 
		(Nombre LIKE '%' + @Nombre + '%' or Apellido LIKE '%' + @Apellido + '%' or Username LIKE '%' + @Username + '%' or CAST(NroDocumento AS NVARCHAR) LIKE '%' + CAST(@Numero_Identificacion AS NVARCHAR) + '%') and Estado = CAST(0 as bit)
end



GO
create procedure TRAEME_LA_COPA_MESSI.darDeBajaUsuario
@Username nvarchar(255)
as
begin transaction
	begin
		update TRAEME_LA_COPA_MESSI.Usuario set Estado=1 where Username=@Username
	end
commit



GO
create procedure TRAEME_LA_COPA_MESSI.validarMailUsuario
@mail nvarchar(255)
as
begin
	if exists (select 1 from TRAEME_LA_COPA_MESSI.Usuario where Email=@mail)
		return 1
	else
		return 0
end


GO
create procedure TRAEME_LA_COPA_MESSI.getHotelesDeUsuario
@Username nvarchar(255)
as
begin
	SELECT distinct IdHotel
	from TRAEME_LA_COPA_MESSI.UsuariosPorHotel
	where Username = @Username
end



GO
create procedure TRAEME_LA_COPA_MESSI.modificarUsuario
@user nvarchar(255),
@pass nvarchar(255),
@email nvarchar(255),
@nombre nvarchar(255),
@apellido nvarchar(255),
@tipoDoc int,
@numDoc numeric(18,0),
@telefono numeric(18,0),
@FechaNacimiento Datetime,
@ciudad nvarchar(255), 
@calle nvarchar(255), 
@nroCalle numeric(18,0),
@piso numeric(18,0),
@dpto nvarchar(50),
@localidad nvarchar(255),
@pais nvarchar(255),
@idDireccion int,
@estado bit
as
begin transaction
	begin
		update TRAEME_LA_COPA_MESSI.Direccion set Ciudad=@ciudad, Calle=@calle, NroCalle=@nroCalle, Piso=@piso, Departamento=@dpto, Localidad=@localidad, Pais=@pais where IdDir=@idDireccion

		update TRAEME_LA_COPA_MESSI.Usuario set Pass=@pass, Direccion=@idDireccion, Nombre=@nombre, Apellido=@apellido, TipoDoc=@tipoDoc, Email=@email, Telefono=@telefono, FechaNacimiento=@FechaNacimiento, Estado=@estado where Username=@user
	end
commit


GO
create procedure TRAEME_LA_COPA_MESSI.eliminarRolesDeUsuario
@username nvarchar(255)
as
begin transaction
	begin
		delete from TRAEME_LA_COPA_MESSI.RolPorUsuario where Username=@username  
	end
commit



GO
create procedure TRAEME_LA_COPA_MESSI.eliminarHotelesDeUsuario
@username nvarchar(255)
as
begin transaction
	begin
		delete from TRAEME_LA_COPA_MESSI.UsuariosPorHotel where Username=@username
	end
commit


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

select distinct * 
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
@calle nvarchar(255),
@nroCalle int,
@ciudad nvarchar(255),
@pais nvarchar(255)

AS
BEGIN

	DECLARE @direccion_id int

	INSERT INTO TRAEME_LA_COPA_MESSI.Direccion(Calle,NroCalle,Ciudad,Pais) VALUES (@calle,@nroCalle,@ciudad,@pais)

	SET @direccion_id = (SELECT d.IdDir FROM TRAEME_LA_COPA_MESSI.Direccion d WHERE d.Calle = @calle AND d.NroCalle = @nroCalle AND d.Ciudad = @ciudad AND d.Pais = @pais)

	INSERT INTO TRAEME_LA_COPA_MESSI.Hotel (Nombre, Mail,Telefono,CantEstrellas,PorcentajeEstrellas,Direccion,FechaCreacion)
	VALUES (@nombre, @mail, @telefono, @estrellas, @porcEstrellas,@direccion_id,GETDATE())

END

GO
CREATE PROCEDURE TRAEME_LA_COPA_MESSI.getHotel
@idHotel int

AS
BEGIN

	SELECT * FROM TRAEME_LA_COPA_MESSI.Hotel h JOIN TRAEME_LA_COPA_MESSI.Direccion d ON h.Direccion = d.IdDir
	WHERE h.IdHotel = @idHotel

END


GO
CREATE PROCEDURE TRAEME_LA_COPA_MESSI.agregarRegimenHotel
@regimen nvarchar(255),
@nombre nvarchar(255),
@mail nvarchar(255),
@telefono int

AS
BEGIN

	DECLARE @hotel_id int
	DECLARE @regimen_id int

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

	SELECT h.IdHotel, h.Nombre, h.Mail, h.Telefono, h.CantEstrellas, h.PorcentajeEstrellas, h.FechaCreacion, dh.Ciudad, dh.Pais, dh.Calle, dh.NroCalle FROM (TRAEME_LA_COPA_MESSI.Hotel h JOIN TRAEME_LA_COPA_MESSI.Direccion dh ON h.Direccion = dh.IdDir)
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
@hotelId int,
@fechaInicio datetime,
@fechaFin datetime,
@descripcion nvarchar(255)

AS
BEGIN
	
	IF (NOT EXISTS (SELECT * FROM TRAEME_LA_COPA_MESSI.Reserva r WHERE
				   ((r.IdHotel = @hotelId) AND (
				   (CONVERT(char(10),r.FechaReserva ,112) >= CONVERT(char(10), @fechaInicio ,112) AND  CONVERT(char(10),r.FechaReserva + r.CantidadNochesReservadas ,112) <= CONVERT(char(10),@fechaFin ,112))
				   OR (CONVERT(char(10),r.FechaReserva + r.CantidadNochesReservadas ,112) >= CONVERT(char(10), @fechaInicio ,112) AND CONVERT(char(10),r.FechaReserva + r.CantidadNochesReservadas ,112) <= CONVERT(char(10), @fechaFin ,112))
				   OR (CONVERT(char(10),r.FechaReserva ,112) >= CONVERT(char(10), @fechaInicio ,112) AND CONVERT(char(10),r.FechaReserva ,112) <= CONVERT(char(10), @fechaFin ,112))
				   OR (CONVERT(char(10),r.FechaReserva ,112) <= CONVERT(char(10), @fechaInicio ,112) AND CONVERT(char(10),r.FechaReserva + r.CantidadNochesReservadas ,112) >= CONVERT(char(10), @fechaInicio ,112))
				   ))
				   ))
	
	BEGIN

	INSERT INTO TRAEME_LA_COPA_MESSI.InhabilitacionesHotel(IdHotel,FechaInicio,FechaFin,Descripcion)
	VALUES (@hotelId, @fechaInicio, @fechaFin, @descripcion)

	RETURN 1

	END

	ELSE

	BEGIN

	RETURN 0

	END

END



GO
CREATE PROCEDURE TRAEME_LA_COPA_MESSI.modificarHotel
@hotelId int,
@nombre nvarchar(255),
@mail nvarchar(255),
@telefono int,
@estrellas int,
@porcEstrellas numeric(18,0),
@calle nvarchar(255),
@nroCalle int,
@ciudad nvarchar(255),
@pais nvarchar(255)

AS
BEGIN

	UPDATE TRAEME_LA_COPA_MESSI.Hotel SET
	Nombre = @nombre,
	Mail = @mail,
	Telefono = @telefono,
	CantEstrellas = @estrellas,
	PorcentajeEstrellas = @porcEstrellas

	WHERE IdHotel = @hotelId

	UPDATE TRAEME_LA_COPA_MESSI.Direcciones_Hoteles SET
	Calle = @calle,
	NroCalle = @nroCalle,
	Ciudad = @ciudad,
	Pais = @pais

	WHERE IdDir_Hotel = (SELECT Direccion FROM TRAEME_LA_COPA_MESSI.Hotel WHERE IdHotel = @hotelId)

	UPDATE TRAEME_LA_COPA_MESSI.Direccion SET
	Calle = @calle,
	NroCalle = @nroCalle,
	Ciudad = @ciudad,
	Pais = @pais

	WHERE IdDir = (SELECT Direccion FROM TRAEME_LA_COPA_MESSI.Hotel WHERE IdHotel = @hotelId)


END


GO
CREATE PROCEDURE TRAEME_LA_COPA_MESSI.comprobarRegimen
@idHotel int,
@regimenEstadiaId int

AS
BEGIN
	
	IF EXISTS (SELECT * FROM TRAEME_LA_COPA_MESSI.Reserva WHERE RegimenEstadiaId = @regimenEstadiaId AND IdHotel = @idHotel AND (FechaReserva <= GETDATE()))
	
		RETURN 0

	ELSE

		RETURN 1

END

GO
CREATE PROCEDURE TRAEME_LA_COPA_MESSI.eliminarRegimenesHotel
@idHotel int

AS
BEGIN

	DELETE FROM TRAEME_LA_COPA_MESSI.RegimenPorHotel WHERE IdHotel = @idHotel

END


GO
CREATE PROCEDURE TRAEME_LA_COPA_MESSI.agregarRegimenPorHotel
@idHotel int,
@idRegimen int

AS
BEGIN

	INSERT INTO TRAEME_LA_COPA_MESSI.RegimenPorHotel(IdHotel,IdRegimenEstadia)
	VALUES (@idHotel,@idRegimen)

END

GO
CREATE PROCEDURE TRAEME_LA_COPA_MESSI.getRegimenesHotel
@idHotel int

AS
BEGIN

	SELECT r.IdRegimenEstadia, Descripcion, PrecioBase

	FROM TRAEME_LA_COPA_MESSI.RegimenEstadia r JOIN TRAEME_LA_COPA_MESSI.RegimenPorHotel rh ON r.IdRegimenEstadia = rh.IdRegimenEstadia WHERE r.EstadoRegimenEstadia = 0 AND rh.IdHotel = @idHotel


END 



GO
CREATE PROCEDURE TRAEME_LA_COPA_MESSI.getHoteles

AS
BEGIN

	SELECT IdHotel,Nombre,Mail,Telefono,CantEstrellas,PorcentajeEstrellas,FechaCreacion FROM TRAEME_LA_COPA_MESSI.Hotel

END



/* Repositorio Clientes */


GO
create procedure TRAEME_LA_COPA_MESSI.getClientesFiltradosActivos
@Nombre nvarchar(255),
@Apellido nvarchar(255),
@Mail nvarchar(255),
@Tipo_Identificacion int,
@Numero_Identificacion numeric(18,0)
as
begin
	
	SELECT c.IdCliente,c.Email,c.Nombre,c.Apellido,
	(select Descripcion from TRAEME_LA_COPA_MESSI.TipoDoc where IdTipo=@Tipo_Identificacion) as TipoIdentidicacion,
	NumDoc, Telefono, PaisOrigen, Nacionalidad, FechaNacimiento,
	(case c.Estado when 0 then 'Activo' else 'Inactivo' end) as Estado
	FROM TRAEME_LA_COPA_MESSI.Cliente c
	WHERE 
	c.Estado = 0 and c.Nombre LIKE '%' + @Nombre + '%' AND c.Apellido LIKE '%' + @Apellido + '%' AND c.Email LIKE '%' + @Mail + '%' AND  CAST(c.TipoDoc AS NVARCHAR) LIKE '%' +  CAST(@Tipo_Identificacion AS NVARCHAR) + '%' AND CAST(c.NumDoc AS NVARCHAR) LIKE '%' + CAST(@Numero_Identificacion AS NVARCHAR) + '%'
	
	UNION

	SELECT ci.IdCliente,ci.Email,ci.Nombre,ci.Apellido,
	(select Descripcion from TRAEME_LA_COPA_MESSI.TipoDoc where IdTipo=@Tipo_Identificacion) as TipoIdentidicacion,
	NumDoc, Telefono, PaisOrigen, Nacionalidad, FechaNacimiento,
	(case ci.Estado when 0 then 'Activo' else 'Inactivo' end) as Estado
	FROM TRAEME_LA_COPA_MESSI.Cliente_Inconsistente ci
	WHERE
	ci.Estado = 0 and ci.Nombre LIKE '%' + @Nombre + '%' AND ci.Apellido LIKE '%' + @Apellido + '%' AND ci.Email LIKE '%' + @Mail + '%' AND CAST(ci.TipoDoc AS NVARCHAR) LIKE '%' + CAST(@Tipo_Identificacion AS NVARCHAR) + '%' AND CAST(ci.NumDoc AS nvarchar) LIKE '%' + CAST(@Numero_Identificacion AS NVARCHAR) + '%'
	
end



GO
create procedure TRAEME_LA_COPA_MESSI.getClientesFiltradosConInactivos
@Nombre nvarchar(255),
@Apellido nvarchar(255),
@Mail nvarchar(255),
@Tipo_Identificacion int,
@Numero_Identificacion numeric(18,0)
as
begin
	
	SELECT c.IdCliente,c.Email,c.Nombre,c.Apellido,
	(select Descripcion from TRAEME_LA_COPA_MESSI.TipoDoc where IdTipo=@Tipo_Identificacion) as TipoIdentidicacion,
	NumDoc, Telefono, PaisOrigen, Nacionalidad, FechaNacimiento,
	(case c.Estado when 0 then 'Activo' else 'Inactivo' end) as Estado
	FROM TRAEME_LA_COPA_MESSI.Cliente c
	WHERE 
	c.Nombre LIKE '%' + @Nombre + '%' AND c.Apellido LIKE '%' + @Apellido + '%' AND c.Email LIKE '%' + @Mail + '%' AND CAST(c.TipoDoc AS NVARCHAR) LIKE '%' +  CAST(@Tipo_Identificacion AS NVARCHAR) + '%' AND CAST(c.NumDoc AS NVARCHAR) LIKE '%' + CAST(@Numero_Identificacion AS NVARCHAR) + '%'
	
	UNION

	SELECT ci.IdCliente,ci.Email,ci.Nombre,ci.Apellido,
	(select Descripcion from TRAEME_LA_COPA_MESSI.TipoDoc where IdTipo=@Tipo_Identificacion) as TipoIdentidicacion,
	NumDoc, Telefono, PaisOrigen, Nacionalidad, FechaNacimiento,
	(case ci.Estado when 0 then 'Activo' else 'Inactivo' end) as Estado   
	FROM TRAEME_LA_COPA_MESSI.Cliente_Inconsistente ci
	WHERE
	ci.Nombre LIKE '%' + @Nombre + '%' AND ci.Apellido LIKE '%' + @Apellido + '%' AND ci.Email LIKE '%' + @Mail + '%' AND CAST(ci.TipoDoc AS NVARCHAR) LIKE '%' + CAST(@Tipo_Identificacion AS NVARCHAR) + '%' AND CAST(ci.NumDoc AS nvarchar) LIKE '%' + CAST(@Numero_Identificacion AS NVARCHAR) + '%'
	
end


GO
create procedure TRAEME_LA_COPA_MESSI.newCliente
@email nvarchar(255),
@nombre nvarchar(255),
@apellido nvarchar(255),
@tipoDoc int,
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
		--if exists (select 1 from TRAEME_LA_COPA_MESSI.Cliente c, TRAEME_LA_COPA_MESSI.Cliente_Inconsistente ci where c.Email=@email or ci.Email=@email)
			--begin
				declare @IdDireccion int

				insert into TRAEME_LA_COPA_MESSI.Direccion (Ciudad, Calle, NroCalle, Piso, Departamento, Localidad, Pais)
				values(@ciudad, @calle, @nroCalle, @piso, @dpto, @localidad, @pais)

				set @IdDireccion = (select IdDir from TRAEME_LA_COPA_MESSI.Direccion where Ciudad=@ciudad and Calle=@calle and NroCalle=@nroCalle and Piso=@piso and Departamento=@dpto and Localidad=@localidad and Pais=@pais)

				insert into TRAEME_LA_COPA_MESSI.Cliente (Email, Direccion, Nombre, Apellido, TipoDoc, NumDoc, Telefono, PaisOrigen, Nacionalidad, FechaNacimiento)
				values(@email, @IdDireccion, @nombre, @apellido, @tipoDoc, @numDoc, @telefono, @PaisOrigen, @Nacionalidad, @FechaNacimiento)
			--end
	end
commit


GO
create procedure TRAEME_LA_COPA_MESSI.newClienteReturnId
@email nvarchar(255),
@nombre nvarchar(255),
@apellido nvarchar(255),
@tipoDoc int,
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
	begin
		declare @IdDireccion int

		insert into TRAEME_LA_COPA_MESSI.Direccion (Ciudad, Calle, NroCalle, Piso, Departamento, Localidad, Pais)
		values(@ciudad, @calle, @nroCalle, @piso, @dpto, @localidad, @pais)

		set @IdDireccion = (select IdDir from TRAEME_LA_COPA_MESSI.Direccion where Ciudad=@ciudad and Calle=@calle and NroCalle=@nroCalle and Piso=@piso and Departamento=@dpto and Localidad=@localidad and Pais=@pais)

		insert into TRAEME_LA_COPA_MESSI.Cliente (Email, Direccion, Nombre, Apellido, TipoDoc, NumDoc, Telefono, PaisOrigen, Nacionalidad, FechaNacimiento)
		values(@email, @IdDireccion, @nombre, @apellido, @tipoDoc, @numDoc, @telefono, @PaisOrigen, @Nacionalidad, @FechaNacimiento)
		

		declare @idCliente int
			
		set @idCliente = (select IdCliente from TRAEME_LA_COPA_MESSI.Cliente c where c.Email=@email and c.Nombre=@nombre and c.Apellido=@apellido and c.Direccion=@IdDireccion and c.TipoDoc=@tipoDoc and c.NumDoc=@numDoc and c.Telefono=@telefono and c.PaisOrigen=@PaisOrigen and c.Nacionalidad=@Nacionalidad and c.FechaNacimiento=@FechaNacimiento)

		return @idCliente
	end


GO
create procedure TRAEME_LA_COPA_MESSI.getCliente
@id int,
@mail nvarchar(255)
as
begin
	if exists (select IdCliente from TRAEME_LA_COPA_MESSI.Cliente c where c.IdCliente=@id and c.Email=@mail)
		select * from TRAEME_LA_COPA_MESSI.Cliente c where c.IdCliente=@id and c.Email=@mail
	else
		select * from TRAEME_LA_COPA_MESSI.Cliente_Inconsistente ci where ci.IdCliente=@id and ci.Email=@mail
end

GO
create procedure TRAEME_LA_COPA_MESSI.getDireccion
@id int
as
	select * from TRAEME_LA_COPA_MESSI.Direccion where IdDir = @id


GO
create procedure TRAEME_LA_COPA_MESSI.modificarCliente
@email nvarchar(255),
@nombre nvarchar(255),
@apellido nvarchar(255),
@tipoDoc int,
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
@pais nvarchar(255),
@idCliente int,
@idDireccion int
as
begin transaction
	begin
		if exists (select IdCliente from TRAEME_LA_COPA_MESSI.Cliente c where c.IdCliente = @idCliente and c.Email=@email)
			begin
				update TRAEME_LA_COPA_MESSI.Cliente set Email=@email, Direccion=@idDireccion, Nombre=@nombre, Apellido=@apellido, TipoDoc=@tipoDoc, NumDoc=@numDoc, Telefono=@telefono, PaisOrigen=@PaisOrigen, Nacionalidad=@Nacionalidad, FechaNacimiento=@FechaNacimiento where IdCliente = @idCliente
				update TRAEME_LA_COPA_MESSI.Direccion set Ciudad=@ciudad, Calle=@calle, NroCalle=@nroCalle, Piso=@piso, Departamento=@dpto, Localidad=@localidad, Pais=@pais where IdDir=@idDireccion
			end
		else
			begin
				update TRAEME_LA_COPA_MESSI.Cliente_Inconsistente set Email=@email, Direccion=@idDireccion, Nombre=@nombre, Apellido=@apellido, TipoDoc=@tipoDoc, NumDoc=@numDoc, Telefono=@telefono, PaisOrigen=@PaisOrigen, Nacionalidad=@Nacionalidad, FechaNacimiento=@FechaNacimiento where IdCliente = @idCliente
				update TRAEME_LA_COPA_MESSI.Direccion set Ciudad=@ciudad, Calle=@calle, NroCalle=@nroCalle, Piso=@piso, Departamento=@dpto, Localidad=@localidad, Pais=@pais where IdDir=@idDireccion
			end
	end
commit


GO
create procedure TRAEME_LA_COPA_MESSI.darDeBajaCliente
@idCliente int,
@mail nvarchar(255)
as
begin transaction
	begin
		if(exists (select IdCliente from TRAEME_LA_COPA_MESSI.Cliente c where c.IdCliente = @idCliente and c.Email=@mail))
			update TRAEME_LA_COPA_MESSI.Cliente set Estado = 1 where IdCliente=@idCliente
		else
			update TRAEME_LA_COPA_MESSI.Cliente_Inconsistente set Estado = 1 where IdCliente=@idCliente and Email=@mail
	end
commit



/* Repositorio Rol*/


GO
create procedure TRAEME_LA_COPA_MESSI.validarNombreDeRol
@nombreRol nvarchar(255)
as
begin
	if exists (select 1 from TRAEME_LA_COPA_MESSI.Rol where Nombre = @nombreRol)
		return 1
	else
		return 0
	end

GO
create procedure TRAEME_LA_COPA_MESSI.agregarNuevoRol
@nombreRol nvarchar(255),
@estado int
as
begin
insert into TRAEME_LA_COPA_MESSI.Rol 
values (@nombreRol,@estado)
return (select IdRol from TRAEME_LA_COPA_MESSI.Rol where Nombre=@nombreRol)
end

GO
create procedure TRAEME_LA_COPA_MESSI.actualizarFuncionalidadporRol
@idRol int,
@funcionalidad nvarchar(255)
as
begin
insert into FuncionalidadPorRol
values((select IdFunc from TRAEME_LA_COPA_MESSI.Funcionalidad where @funcionalidad=Descripcion),@idRol)  
end

GO 
create procedure TRAEME_LA_COPA_MESSI.eliminarFuncionalidadesDelRol
@idRol int
as
begin
delete from TRAEME_LA_COPA_MESSI.FuncionalidadPorRol where @idRol=IdRol
end

GO
create procedure TRAEME_LA_COPA_MESSI.getRoles
as
begin
SELECT IdRol,Nombre,Estado from TRAEME_LA_COPA_MESSI.Rol
end

GO
create procedure TRAEME_LA_COPA_MESSI.getFuncionalidadPorRol
@idRol int
as
begin
select f1.Descripcion from TRAEME_LA_COPA_MESSI.Funcionalidad f1 join TRAEME_LA_COPA_MESSI.FuncionalidadPorRol f2 on (f1.IdFunc=f2.IdFunc) where @idRol = f2.IdRol
end

GO
create procedure TRAEME_LA_COPA_MESSI.eliminarRol
@idRol int
as
begin
delete from TRAEME_LA_COPA_MESSI.RolPorUsuario where @idRol=IdRol
delete from TRAEME_LA_COPA_MESSI.Rol where @idRol=IdRol

end 

GO
create procedure TRAEME_LA_COPA_MESSI.modificarRol
@nombreRol nvarchar(255),
@estado int
as
begin
update TRAEME_LA_COPA_MESSI.Rol set Estado = @estado where Nombre=@nombreRol;
end            

/* Repositorio Tipo Doc*/

GO
create procedure TRAEME_LA_COPA_MESSI.getTipoDocumentos
as
select * from TRAEME_LA_COPA_MESSI.TipoDoc


GO
create procedure TRAEME_LA_COPA_MESSI.getTipoDocumento
@id int
as
select * from TRAEME_LA_COPA_MESSI.TipoDoc where IdTipo=@id



/* Repositorio Reservas */

GO
create procedure TRAEME_LA_COPA_MESSI.validarCancelacion
@idReserva int 
as begin
select FechaReserva, FechaInicio from TRAEME_LA_COPA_MESSI.Reserva JOIN TRAEME_LA_COPA_MESSI.LogEstadia ON IdReserva = ReservaId where @idReserva=IdReserva 
end


GO
create procedure TRAEME_LA_COPA_MESSI.validarCancelacionUsuario
@usuario nvarchar (255)
as begin
if exists (select 1 from TRAEME_LA_COPA_MESSI.Usuario where @usuario=Username)
return 1
else
return 0
end


GO
create procedure TRAEME_LA_COPA_MESSI.cancelarReserva
@idReserva int,
@nombreUsuario nvarchar (255),
@fechaDeCancelacion Datetime,
@motivo nvarchar(255)
as begin
update TRAEME_LA_COPA_MESSI.Reserva set EstadoReserva =  2 where IdReserva = @idReserva   
insert into TRAEME_LA_COPA_MESSI.Log_Reserva values ('Cancelacion',@nombreUsuario,@motivo,@fechaDeCancelacion)
end


GO
CREATE PROCEDURE TRAEME_LA_COPA_MESSI.comprobarNumReserva
@idReserva int,
@idHotel int

AS
BEGIN

IF EXISTS(SELECT * FROM TRAEME_LA_COPA_MESSI.Reserva WHERE IdReserva = @idReserva AND IdHotel = @idHotel AND YEAR(FechaReserva) = YEAR(GETDATE()) AND MONTH(FechaReserva) = MONTH(GETDATE()) AND DAY(FechaReserva) = DAY(GETDATE()))
BEGIN

UPDATE TRAEME_LA_COPA_MESSI.Reserva SET EstadoReserva = 5 WHERE IdReserva = @idReserva

	RETURN 1
END

ELSE

	IF EXISTS(SELECT * FROM TRAEME_LA_COPA_MESSI.Reserva WHERE IdReserva = @idReserva AND IdHotel = @idHotel AND FechaReserva > GETDATE())
	BEGIN

		RETURN 2
	
	END

	ELSE
	
	IF EXISTS(SELECT * FROM TRAEME_LA_COPA_MESSI.Reserva WHERE IdReserva = @idReserva AND IdHotel = @idHotel AND FechaReserva < GETDATE() AND EstadoReserva != 6)
	BEGIN

	UPDATE TRAEME_LA_COPA_MESSI.Reserva SET EstadoReserva = 4 WHERE IdReserva = @idReserva

		RETURN 3
	
	END

	ELSE

	IF EXISTS(SELECT * FROM TRAEME_LA_COPA_MESSI.Reserva WHERE IdReserva = @idReserva AND IdHotel = @idHotel AND FechaReserva < GETDATE() AND EstadoReserva = 6)

		RETURN 4

	ELSE

		RETURN -1

END


GO
CREATE PROCEDURE TRAEME_LA_COPA_MESSI.hacerCheckOut
@idReserva int

AS
BEGIN

UPDATE TRAEME_LA_COPA_MESSI.LogEstadia SET FechaFin = GETDATE() WHERE ReservaId = @idReserva

UPDATE TRAEME_LA_COPA_MESSI.Reserva SET EstadoReserva = 6 WHERE IdReserva = @idReserva

UPDATE TRAEME_LA_COPA_MESSI.LogEstadia SET CantidadNocheUsadas =  DATEDIFF(DAY, FechaInicio, FechaFin) WHERE ReservaId = @idReserva

END


GO
CREATE PROCEDURE TRAEME_LA_COPA_MESSI.getClienteReserva
@idHotel int,
@numReserva int

AS
BEGIN

	SELECT c.IdCliente, c.nombre, c.Apellido, c.NumDoc, c.Email, t.Descripcion FROM TRAEME_LA_COPA_MESSI.Cliente c JOIN TRAEME_LA_COPA_MESSI.TipoDoc t ON t.IdTipo = c.TipoDoc
	WHERE c.IdCliente = (SELECT IdCliente FROM TRAEME_LA_COPA_MESSI.Reserva WHERE IdHotel = @idHotel AND IdReserva = @numReserva)

END


GO
CREATE PROCEDURE TRAEME_LA_COPA_MESSI.hacerCheckIn
@idCliente int,
@mailCliente nvarchar(255),
@numeroDoc int,
@idReserva int

AS
BEGIN

	IF EXISTS (SELECT IdCliente FROM TRAEME_LA_COPA_MESSI.Cliente WHERE IdCliente = @idCliente AND Email = @mailCliente AND NumDoc = @numeroDoc)

	INSERT INTO TRAEME_LA_COPA_MESSI.ClienteRegistradoPorReserva
	VALUES (@idCliente,@idReserva)

	ELSE

	IF EXISTS (SELECT IdCliente FROM TRAEME_LA_COPA_MESSI.Cliente_Inconsistente WHERE IdCliente = @idCliente AND Email = @mailCliente AND NumDoc = @numeroDoc)

	INSERT INTO TRAEME_LA_COPA_MESSI.ClienteIncRegistradoPorReserva
	VALUES (@idCliente,@idReserva)

	END

GO
CREATE PROCEDURE TRAEME_LA_COPA_MESSI.generarLogEstadia
@idReserva int
	
AS
BEGIN

INSERT INTO TRAEME_LA_COPA_MESSI.LogEstadia(FechaInicio,ReservaId)
	VALUES (GETDATE(),@idReserva)

END

/* Repositorio Tipo Habitacion*/

GO
CREATE PROCEDURE TRAEME_LA_COPA_MESSI.getTiposHabitaciones

AS
BEGIN

SELECT * FROM TRAEME_LA_COPA_MESSI.TipoHabitacion

END

GO
CREATE PROCEDURE TRAEME_LA_COPA_MESSI.crearHabitacion
@idHotel int,
@numero int,
@piso int,
@tipoHabitacion int,
@ubicacion nvarchar(255),
@descripcion nvarchar(255)

AS
BEGIN
	
	IF NOT EXISTS (SELECT IdHotel,Numero FROM TRAEME_LA_COPA_MESSI.Habitacion WHERE IdHotel = @idHotel AND Numero = @numero)

	BEGIN

	INSERT INTO TRAEME_LA_COPA_MESSI.Habitacion(IdHotel,Numero,Piso,Ubicacion,CodigoTipo,Estado,Descripcion)
	VALUES (@idHotel, @numero, @piso, @ubicacion, @tipoHabitacion, 0, @descripcion)

	RETURN 0

	END

	ELSE

	BEGIN

	RETURN 1

	END

END

GO
CREATE PROCEDURE TRAEME_LA_COPA_MESSI.getHabitacionesFiltradas
@idTipo int,
@ubicacion nvarchar(255),
@idHotel int

AS
BEGIN
	
	IF (@idTipo = -1 AND @idHotel = -1)

	BEGIN

	SELECT IdHotel, Numero, Piso, Ubicacion, t.Descripcion, Estado, h.Descripcion FROM TRAEME_LA_COPA_MESSI.Habitacion h JOIN TRAEME_LA_COPA_MESSI.TipoHabitacion t ON CodigoTipo = Codigo
	WHERE
	(Ubicacion LIKE '%' + @ubicacion + '%')
	
	END
	
	ELSE

	BEGIN
	
	IF (@idTipo = -1)
	
	BEGIN
	
	SELECT IdHotel, Numero, Piso, Ubicacion, t.Descripcion, Estado, h.Descripcion FROM TRAEME_LA_COPA_MESSI.Habitacion h JOIN TRAEME_LA_COPA_MESSI.TipoHabitacion t ON CodigoTipo = Codigo
	WHERE 
	(Ubicacion LIKE '%' + @ubicacion + '%' AND @idHotel = IdHotel)

	END

	ELSE

	BEGIN

	IF (@idHotel = -1)
	
	BEGIN

	SELECT IdHotel, Numero, Piso, Ubicacion, t.Descripcion, Estado, h.Descripcion FROM TRAEME_LA_COPA_MESSI.Habitacion h JOIN TRAEME_LA_COPA_MESSI.TipoHabitacion t ON CodigoTipo = Codigo
	WHERE
	(Ubicacion LIKE '%' + @ubicacion + '%' AND t.Codigo = @idTipo)
	
	END

	ELSE

	BEGIN

	SELECT IdHotel, Numero, Piso, Ubicacion, t.Descripcion, Estado, h.Descripcion FROM TRAEME_LA_COPA_MESSI.Habitacion h JOIN TRAEME_LA_COPA_MESSI.TipoHabitacion t ON CodigoTipo = Codigo
	WHERE
	(Ubicacion LIKE '%' + @ubicacion + '%' AND t.Codigo = @idTipo AND IdHotel = @idHotel)

	END

	END

	END

	END


	GO
	CREATE PROCEDURE TRAEME_LA_COPA_MESSI.getHabitacion
	@idHotel int,
	@numero int

	AS
	BEGIN

	SELECT * FROM TRAEME_LA_COPA_MESSI.Habitacion WHERE IdHotel = @idHotel AND Numero = @numero

	END


	GO
	CREATE PROCEDURE TRAEME_LA_COPA_MESSI.modificarHabitacion /*A modo de simplificacion, se elimina de las tablas consumiblePorHabitacion y habitacionPorReserva toda referencia a la habitacion modif*/
	@hotelIdModif int,
	@numeroHabModif int,
	@hotelIdNuevo int,
	@numeroHabNuevo int,
	@piso int,
	@ubicacion nvarchar(255),
	@descripcion nvarchar(255)

	AS
	BEGIN

	IF NOT EXISTS (SELECT IdHotel,Numero FROM TRAEME_LA_COPA_MESSI.Habitacion WHERE IdHotel = @hotelIdNuevo AND Numero = @numeroHabNuevo)

	BEGIN

		DECLARE @tipoHab int

		SET @tipoHab = (SELECT CodigoTipo FROM TRAEME_LA_COPA_MESSI.Habitacion WHERE IdHotel = @hotelIdModif AND Numero = @numeroHabModif)

		DELETE FROM TRAEME_LA_COPA_MESSI.ConsumiblePorHabitacion WHERE idHotel = @hotelIdModif AND NumeroHabitacion = @numeroHabModif

		DELETE FROM TRAEME_LA_COPA_MESSI.HabitacionPorReserva WHERE IdHotel = @hotelIdModif AND NumeroHabitacion = @numeroHabModif

		DELETE FROM TRAEME_LA_COPA_MESSI.Habitacion WHERE IdHotel = @hotelIdModif AND Numero = @numeroHabModif

		INSERT INTO TRAEME_LA_COPA_MESSI.Habitacion
		VALUES (@hotelIdNuevo, @numeroHabNuevo, @piso, @ubicacion, @tipoHab, 0, @descripcion)

		RETURN 1

	END

	ELSE

	BEGIN

		RETURN -1
	
	END

END


GO
CREATE PROCEDURE TRAEME_LA_COPA_MESSI.darBajaHabitacion
@idHotel int,
@numeroHab int

AS
BEGIN

	UPDATE TRAEME_LA_COPA_MESSI.Habitacion SET Estado = 1 WHERE Numero = @numeroHab AND IdHotel = @idHotel

END



--RegistrarConsumibles

Go
Create procedure TRAEME_LA_COPA_MESSI.getConsumibles
as
begin
select * from TRAEME_LA_COPA_MESSI.Consumible
END

