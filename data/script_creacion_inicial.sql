USE GD1C2018

GO


/* Dropeo de tablas si estas ya existen */


IF OBJECT_ID('TRAEME_LA_COPA_MESSI.consumiblesHotel','U') IS NOT NULL 
	DROP TABLE TRAEME_LA_COPA_MESSI.consumiblesHotel;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.puntosClientes','U') IS NOT NULL 
	DROP TABLE TRAEME_LA_COPA_MESSI.puntosClientes;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.fechasFinEstadias','U') IS NOT NULL    
	DROP TABLE TRAEME_LA_COPA_MESSI.fechasFinEstadias;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.ClienteIncRegistradoPorReserva','U') IS NOT NULL
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

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.Log_Reserva','U') IS NOT NULL 
	DROP TABLE TRAEME_LA_COPA_MESSI.Log_Reserva;

IF OBJECT_ID ('TRAEME_LA_COPA_MESSI.RegimenEstadia','U') IS NOT NULL
    DROP TABLE TRAEME_LA_COPA_MESSI.RegimenEstadia;

IF OBJECT_ID ('TRAEME_LA_COPA_MESSI.FuncionalidadPorRol','U') IS NOT NULL
    DROP TABLE TRAEME_LA_COPA_MESSI.FuncionalidadPorRol;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.Funcionalidad','U') IS NOT NULL    
	DROP TABLE TRAEME_LA_COPA_MESSI.Funcionalidad;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.Factura_Inconsistente','U') IS NOT NULL    
	DROP TABLE TRAEME_LA_COPA_MESSI.Factura_Inconsistente;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.Factura','U') IS NOT NULL    
	DROP TABLE TRAEME_LA_COPA_MESSI.Factura;

IF OBJECT_ID ('TRAEME_LA_COPA_MESSI.Hotel','U') IS NOT NULL
    DROP TABLE TRAEME_LA_COPA_MESSI.Hotel;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.Cliente_Inconsistente','U') IS NOT NULL    
	DROP TABLE TRAEME_LA_COPA_MESSI.Cliente_Inconsistente;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.Cliente','U') IS NOT NULL    
	DROP TABLE TRAEME_LA_COPA_MESSI.Cliente;

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

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.puntosClientes','U') IS NOT NULL 
	DROP TABLE TRAEME_LA_COPA_MESSI.puntosClientes;

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

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.comprobarDisponibilidadReserva','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.comprobarDisponibilidadReserva;	

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.newReservaReturnId','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.newReservaReturnId;	

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.hacerCheckOut','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.hacerCheckOut;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.crearFactura','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.crearFactura;
	
IF OBJECT_ID('TRAEME_LA_COPA_MESSI.facturarConsumible','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.facturarConsumible;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.calcularTotalFactura','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.calcularTotalFactura;
	
IF OBJECT_ID('TRAEME_LA_COPA_MESSI.facturarEstadia','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.facturarEstadia;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.comprobarNumReservaCheckout','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.comprobarNumReservaCheckout;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.obtenerFuncionalidadesCompletasPorRol','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.obtenerFuncionalidadesCompletasPorRol;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.DescontarConsumibles','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.DescontarConsumibles;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.verificarAllInclusive','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.verificarAllInclusive;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.comprobarReservaNoPasoFecha','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.comprobarReservaNoPasoFecha;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.getHabitacionesEnFecha','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.getHabitacionesEnFecha;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.newHabitacionPorReserva','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.newHabitacionPorReserva;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.getTipoHabitacion','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.getTipoHabitacion;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.topReservasCanceladas','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.topReservasCanceladas;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.topConsumiblesFacturados','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.topConsumiblesFacturados;
	
IF OBJECT_ID('TRAEME_LA_COPA_MESSI.topDiasFueraDeServicio','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.topDiasFueraDeServicio;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.getTrimestre','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.getTrimestre;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.topCliente','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.topCliente;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.registrarCreacionReservaConGuest','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.registrarCreacionReservaConGuest;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.registrarCreacionReserva','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.registrarCreacionReserva;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.registrarModificacionReservaConGuest','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.registrarModificacionReservaConGuest;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.registrarModificacionReserva','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.registrarModificacionReserva;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.modificarReserva','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.modificarReserva;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.eliminarHabitacionPorReserva','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.eliminarHabitacionPorReserva;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.topHabitacionesOcupadas','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.topHabitacionesOcupadas;

IF OBJECT_ID('TRAEME_LA_COPA_MESSI.getReserva','P') IS NOT NULL  
	DROP PROCEDURE TRAEME_LA_COPA_MESSI.getReserva;

	
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

CREATE TABLE TRAEME_LA_COPA_MESSI.Cliente(
IdCliente int IDENTITY(23422,1) PRIMARY KEY,
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

CREATE TABLE TRAEME_LA_COPA_MESSI.Factura(
Fact_Nro numeric (18,0) IDENTITY(2483045,1) PRIMARY KEY,
Fact_Fecha DateTime NOT NULL,
Fact_Total numeric (18,2) NULL,
Fact_idCliente int FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.Cliente(IdCliente),
Fact_idClienteInc int FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.Cliente_Inconsistente(IdCliente),
Fact_idHotel int FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.Hotel(IdHotel) null
);

CREATE TABLE TRAEME_LA_COPA_MESSI.Factura_Inconsistente(
Fact_Nro numeric (18,0),
Fact_Fecha DateTime,
Fact_Total numeric (18,2),
Fact_idCliente int FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.Cliente(IdCliente),
Fact_idClienteInc int FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.Cliente_Inconsistente(IdCliente),
Fact_idHotel int FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.Hotel(IdHotel) null
PRIMARY KEY (Fact_Nro)
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
IdReserva numeric(18,0) IDENTITY(1,1) PRIMARY KEY,
IdCliente int FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.Cliente(IdCliente) null,
IdClienteInconsistente int FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.Cliente_Inconsistente(IdCliente) null,
IdHotel int FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.Hotel(IdHotel) null, --Cambiar a not null
FechaReserva datetime  NULL,
FechaGeneracionReserva datetime NOT NULL,
CantidadNochesReservadas numeric(18,0)  NULL,
EstadoReserva int FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.EstadoReserva(IdEstadoReserva)  null,
RegimenEstadiaId int FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.RegimenEstadia(IdRegimenEstadia)  null
);

Create table TRAEME_LA_COPA_MESSI.Log_Reserva( --QUE ES ESTO? NO TIENE REFERENCIA A RESERVA
LogId int identity(1,1) Primary key,
Log_Tipo nvarchar(255),
Log_UsuarioId nvarchar(255),
Log_Motivo nvarchar (255),
Log_Fecha Datetime,
Log_idReserva numeric(18,0) FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.Reserva(IdReserva)
);

create table traeme_la_copa_messi.LogEstadia(
IdLogEstadia int IDENTITY(1,1) PRIMARY KEY ,
Tipo nvarchar null,
Autor_check_in nvarchar(255) FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.Usuario(Username),
Autor_check_out nvarchar(255) FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.Usuario(Username),
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
Fac_Numero numeric (18,0) FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.Factura(Fact_Nro) null,
Fac_Numero_Inc numeric (18,0) FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.Factura_Inconsistente(Fact_nro) null,
Reserva_descrip nvarchar(255) null,
Reserva_diasUsados int null,
Reserva_diasSinUso int null,
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

CREATE TABLE TRAEME_LA_COPA_MESSI.puntosClientes( 
idCliente int PRIMARY KEY,
puntos int
);

CREATE TABLE TRAEME_LA_COPA_MESSI.consumiblesHotel(
idHotel int PRIMARY KEY,
cantidad int
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

INSERT INTO TRAEME_LA_COPA_MESSI.Usuario(Username,Pass, Nombre, Apellido, Email, NroDocumento, Telefono, FechaNacimiento, TipoDoc, Direccion) 
	VALUES ('admin','e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7', '', '', '', 0, 0, GETDATE(),@tipoDoc,@direccion); 

insert into TRAEME_LA_COPA_MESSI.Usuario(Username,Pass, Nombre, Apellido, Email, NroDocumento, Telefono, FechaNacimiento, TipoDoc, Direccion)
	VALUES ('guest','', '', '', 'guest', 0, 0, GETDATE(),@tipoDoc,@direccion); 



-- Roles --

INSERT INTO TRAEME_LA_COPA_MESSI.Rol(Nombre)
	VALUES ('Administrador'), ('Recepcionista'), ('Guest')

-- Rol por usuario --

INSERT INTO TRAEME_LA_COPA_MESSI.RolPorUsuario(Username,IdRol)
	
	select u.Username, r.IdRol from TRAEME_LA_COPA_MESSI.Usuario u, TRAEME_LA_COPA_MESSI.Rol r where u.Username = 'admin' and r.Nombre = 'Administrador'

-- Funcionalidades --

INSERT INTO TRAEME_LA_COPA_MESSI.Funcionalidad(Descripcion)
	VALUES ('ABM Hotel'),('ABM Cliente'),('ABM Rol'),('ABM Usuario'),('ABM Habitacion'),('Listado Estadistico'),('Reservas'),('Cancelar Reservas'),('Registrar Estadia')

-- Funcionalidad por rol --

INSERT INTO TRAEME_LA_COPA_MESSI.FuncionalidadPorRol
	select f.IdFunc, rpu.IdRol from TRAEME_LA_COPA_MESSI.Funcionalidad f,
	TRAEME_LA_COPA_MESSI.RolPorUsuario rpu join TRAEME_LA_COPA_MESSI.Usuario u on (rpu.Username = u.Username) where u.Username = 'admin'

INSERT INTO TRAEME_LA_COPA_MESSI.FuncionalidadPorRol(IdRol,IdFunc)
	VALUES (2,9)

INSERT INTO TRAEME_LA_COPA_MESSI.FuncionalidadPorRol(IdRol,IdFunc)
	VALUES (2,7)
	
INSERT INTO TRAEME_LA_COPA_MESSI.FuncionalidadPorRol(IdRol,IdFunc)
	VALUES (2,8)

INSERT INTO TRAEME_LA_COPA_MESSI.FuncionalidadPorRol(IdRol,IdFunc)
	VALUES (2,2)

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

-- Facturas inconsistentes --

INSERT INTO TRAEME_LA_COPA_MESSI.Factura_Inconsistente
	SELECT DISTINCT Factura_Nro,Factura_Fecha,Factura_Total,
	(SELECT DISTINCT IdCliente FROM TRAEME_LA_COPA_MESSI.Cliente c
	WHERE c.Email = m.Cliente_Mail AND c.NumDoc = m.Cliente_Pasaporte_Nro),
	(SELECT DISTINCT IdCliente FROM TRAEME_LA_COPA_MESSI.Cliente_Inconsistente ci
	WHERE ci.Email = m.Cliente_Mail AND ci.NumDoc = m.Cliente_Pasaporte_Nro),
	(SELECT DISTINCT IdHotel FROM TRAEME_LA_COPA_MESSI.Hotel h JOIN TRAEME_LA_COPA_MESSI.Direccion d ON h.Direccion = d.IdDir
	WHERE d.Ciudad = m.Hotel_Ciudad AND d.Calle = m.Hotel_Calle AND d.NroCalle = m.Hotel_Nro_Calle)
	FROM gd_esquema.Maestra m
	WHERE Factura_Nro IS NOT NULL

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

SET IDENTITY_INSERT TRAEME_LA_COPA_MESSI.Reserva ON

INSERT INTO TRAEME_LA_COPA_MESSI.Reserva(IdReserva, IdHotel, FechaReserva, CantidadNochesReservadas,RegimenEstadiaId, FechaGeneracionReserva)


	SELECT DISTINCT m.Reserva_Codigo, h.IdHotel, m.Reserva_Fecha_Inicio, m.Reserva_Cant_Noches,
	(SELECT IdRegimenEstadia FROM TRAEME_LA_COPA_MESSI.RegimenEstadia WHERE Descripcion = m.Regimen_Descripcion), CAST('1950-10-10 12:35:29.123' AS datetime)

	FROM

	(gd_esquema.Maestra m JOIN TRAEME_LA_COPA_MESSI.Direcciones_Hoteles d ON m.Hotel_Calle = d.Calle AND m.Hotel_Nro_Calle = d.NroCalle AND m.Hotel_Ciudad = d.Ciudad)
	JOIN TRAEME_LA_COPA_MESSI.Hotel h ON h.Direccion = d.IdDir_Hotel
	WHERE m.Estadia_Fecha_Inicio IS NULL


UPDATE TRAEME_LA_COPA_MESSI.Reserva  SET  

IdCliente = (SELECT IdClienteAux FROM TRAEME_LA_COPA_MESSI.ReservasDeClientes  WHERE IdReservaAux = IdReserva),

IdClienteInconsistente = (SELECT IdClienteInconAux FROM TRAEME_LA_COPA_MESSI.ReservasDeClientesIncon  WHERE IdReservaAux = IdReserva)

SET IDENTITY_INSERT TRAEME_LA_COPA_MESSI.Reserva OFF

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
insert into TRAEME_LA_COPA_MESSI.Item_Factura(Fac_Numero_Inc,IdConsumible,Cantidad,Monto)
select f.Fact_Nro, m.Consumible_Codigo, SUM(m.Item_Factura_Cantidad) as cantidad, m.Consumible_Precio * SUM(m.Item_Factura_Cantidad) as monto
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


GO
CREATE PROCEDURE TRAEME_LA_COPA_MESSI.obtenerFuncionalidadesCompletasPorRol
@idRol int

AS
BEGIN

	SELECT f.IdFunc, Descripcion, Estado FROM TRAEME_LA_COPA_MESSI.Funcionalidad f JOIN TRAEME_LA_COPA_MESSI.FuncionalidadPorRol fr ON f.IdFunc = fr.IdFunc WHERE fr.IdRol = @idRol

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
@idUsuario int,
@fechaDeCancelacion Datetime,
@motivo nvarchar(255)
as begin
update TRAEME_LA_COPA_MESSI.Reserva set EstadoReserva =  2 where IdReserva = @idReserva   
insert into TRAEME_LA_COPA_MESSI.Log_Reserva(Log_Tipo,Log_UsuarioId,Log_Motivo,Log_Fecha,Log_idReserva)
values ('Cancelacion',@idUsuario,@motivo,@fechaDeCancelacion,@idReserva)
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
@username nvarchar(255),
@idReserva int

AS
BEGIN

UPDATE TRAEME_LA_COPA_MESSI.LogEstadia SET FechaFin = GETDATE() WHERE ReservaId = @idReserva

UPDATE TRAEME_LA_COPA_MESSI.Reserva SET EstadoReserva = 6 WHERE IdReserva = @idReserva

UPDATE TRAEME_LA_COPA_MESSI.LogEstadia SET CantidadNocheUsadas =  DATEDIFF(DAY, FechaInicio, FechaFin) WHERE ReservaId = @idReserva

UPDATE TRAEME_LA_COPA_MESSI.LogEstadia SET Autor_check_out = @username

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
@idReserva int,
@usuario nvarchar(255)
	
AS
BEGIN

INSERT INTO TRAEME_LA_COPA_MESSI.LogEstadia(FechaInicio,ReservaId)
	VALUES (GETDATE(),@idReserva)

UPDATE TRAEME_LA_COPA_MESSI.LogEstadia SET Autor_check_in = @usuario WHERE ReservaId = @idReserva

END


GO
create procedure TRAEME_LA_COPA_MESSI.comprobarDisponibilidadReserva
@desde DateTime,
@hasta DateTime
as
begin
	declare @cantNoches numeric(18,0)
	set @cantNoches =  CAST((datediff(day,@desde,@hasta)) AS numeric(18,0))

	if not exists (select 1 from Reserva where FechaReserva >= @desde and CantidadNochesReservadas <= @cantNoches)
		return 1
	else
		return 0
end


GO
create procedure TRAEME_LA_COPA_MESSI.getHabitacionesEnFecha
@desde DateTime,
@hasta DateTime,
@idHotel int
as
begin
	declare @cantNoches numeric(18,0)
	set @cantNoches =  CAST((datediff(day,@desde,@hasta)) AS numeric(18,0))

	select * 
	from TRAEME_LA_COPA_MESSI.Habitacion hab
	where hab.IdHotel = @idHotel
	and hab.Numero not in
	(
	select distinct h.Numero
	from TRAEME_LA_COPA_MESSI.Habitacion h
	join TRAEME_LA_COPA_MESSI.HabitacionPorReserva hr
		on h.Numero = hr.NumeroHabitacion
		and h.IdHotel = hr.IdHotel
	join TRAEME_LA_COPA_MESSI.Reserva r
		on hr.IdReserva = r.IdReserva
	where r.FechaReserva >= @desde and r.CantidadNochesReservadas <= @hasta
	)
	
end


GO
create procedure TRAEME_LA_COPA_MESSI.newReservaReturnId
@desde dateTime,
@hasta dateTime,
@idHotel int,
@idRegimen int,
@mailCliente nvarchar(255),
@idCliente int
as
begin --transaction
	declare @cantNoches numeric(18,0)
	set @cantNoches =  CAST((datediff(day,@desde,@hasta)) AS numeric(18,0))

	declare @idReserva numeric(18,0)

	if exists(select 1 from TRAEME_LA_COPA_MESSI.Cliente where IdCliente=@idCliente and Email=@mailCliente)
		begin
			insert into TRAEME_LA_COPA_MESSI.Reserva(IdCliente, IdHotel, FechaReserva, FechaGeneracionReserva, CantidadNochesReservadas, EstadoReserva, RegimenEstadiaId)
				values(@idCliente, @idHotel, @desde, getdate(), @cantNoches, 5, @idRegimen)
			
			set @idReserva = (select IdReserva from TRAEME_LA_COPA_MESSI.Reserva where IdHotel=@idHotel and IdCliente=@idCliente and FechaReserva=@desde and CantidadNochesReservadas=@cantNoches and EstadoReserva=5 and RegimenEstadiaId=@idRegimen)
			return @idReserva
		end
	else
		begin
			insert into TRAEME_LA_COPA_MESSI.Reserva(IdClienteInconsistente, IdHotel, FechaReserva, FechaGeneracionReserva, CantidadNochesReservadas, EstadoReserva, RegimenEstadiaId)
				values(@idCliente, @idHotel, @desde, getdate(), @cantNoches, 5, @idRegimen)
			
			set @idReserva = (select IdReserva from TRAEME_LA_COPA_MESSI.Reserva where IdHotel=@idHotel and IdClienteInconsistente=@idCliente and FechaReserva=@desde and CantidadNochesReservadas=@cantNoches and EstadoReserva=5 and RegimenEstadiaId=@idRegimen)
			return @idReserva
		end
end
--commit


GO
create procedure TRAEME_LA_COPA_MESSI.modificarReserva
@id numeric(18,0),
@idHotel int,
@desde dateTime,
@hasta dateTime,
@idRegimen int
as
begin
	declare @cantNoches numeric(18,0)
	set @cantNoches =  CAST((datediff(day,@desde,@hasta)) AS numeric(18,0))

		update TRAEME_LA_COPA_MESSI.Reserva
			set IdHotel=@idHotel, FechaReserva=@desde, FechaGeneracionReserva=getdate(), CantidadNochesReservadas=@cantNoches, EstadoReserva=7, RegimenEstadiaId=@idRegimen
		where IdReserva=@id
end



GO
create procedure TRAEME_LA_COPA_MESSI.newHabitacionPorReserva
@idHotel int,
@numero int,
@idReserva numeric(18,0)
as
begin --transaction
	insert into TRAEME_LA_COPA_MESSI.HabitacionPorReserva (IdHotel, NumeroHabitacion, IdReserva)
		values(@idHotel, @numero, @idReserva)
end


GO
create procedure TRAEME_LA_COPA_MESSI.eliminarHabitacionPorReserva
@idHotel int,
@numero int,
@idReserva numeric(18,0)
as
begin
	delete TRAEME_LA_COPA_MESSI.HabitacionPorReserva where IdHotel=@idHotel and NumeroHabitacion=@numero and IdReserva=@idReserva
end


GO
create procedure TRAEME_LA_COPA_MESSI.getReserva
@idReserva numeric(18,0)
as
begin
	select * from Reserva where IdReserva = @idReserva
end


GO
create procedure TRAEME_LA_COPA_MESSI.comprobarReservaNoPasoFecha
@idReserva decimal(18, 0)
as
begin
	if exists (select 1 from TRAEME_LA_COPA_MESSI.Reserva where IdReserva=@idReserva and day(FechaReserva) < day(GETDATE()) and EstadoReserva != 2 and EstadoReserva != 3 and EstadoReserva != 4 and EstadoReserva != 6)
		return 1
	else if exists (select 1 from TRAEME_LA_COPA_MESSI.Reserva where IdReserva=@idReserva and day(FechaReserva) >= day(GETDATE()) and EstadoReserva != 2 and EstadoReserva != 3 and EstadoReserva != 4 and EstadoReserva != 6)
		return 2
	else if exists (select 1 from TRAEME_LA_COPA_MESSI.Reserva where IdReserva=@idReserva and EstadoReserva != 2 and EstadoReserva != 3 and EstadoReserva != 4 and EstadoReserva != 6)
		return 0
end


GO
create procedure TRAEME_LA_COPA_MESSI.registrarCreacionReservaConGuest
@idReserva decimal(18, 0)
as
begin
	insert into TRAEME_LA_COPA_MESSI.Log_Reserva (Log_Tipo, Log_UsuarioId, Log_Motivo, Log_Fecha, Log_idReserva)
		select 'creacion', Username, '', GETDATE(), @idReserva from TRAEME_LA_COPA_MESSI.Usuario where Username='guest'
end


GO
create procedure TRAEME_LA_COPA_MESSI.registrarCreacionReserva
@idReserva decimal(18, 0),
@user nvarchar(255)
as
begin
	insert into TRAEME_LA_COPA_MESSI.Log_Reserva (Log_Tipo, Log_UsuarioId, Log_Motivo, Log_Fecha, Log_idReserva)
		values ('creacion', @user, '', GETDATE(), @idReserva)
end


GO
create procedure TRAEME_LA_COPA_MESSI.registrarModificacionReservaConGuest
@idReserva decimal(18, 0)
as
begin
	insert into TRAEME_LA_COPA_MESSI.Log_Reserva (Log_Tipo, Log_UsuarioId, Log_Motivo, Log_Fecha, Log_idReserva)
		select 'modificacion', Username, '', GETDATE(), @idReserva from TRAEME_LA_COPA_MESSI.Usuario where Username='guest'
end


GO
create procedure TRAEME_LA_COPA_MESSI.registrarModificacionReserva
@idReserva decimal(18, 0),
@user nvarchar(255)
as
begin
	insert into TRAEME_LA_COPA_MESSI.Log_Reserva (Log_Tipo, Log_UsuarioId, Log_Motivo, Log_Fecha, Log_idReserva)
		values ('modificacion', @user, '', GETDATE(), @idReserva)
end




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


GO
CREATE PROCEDURE TRAEME_LA_COPA_MESSI.getTipoHabitacion
@idTipoHab int
AS
	select * from TRAEME_LA_COPA_MESSI.TipoHabitacion where Codigo=@idTipoHab


/* Repositorio consumibles */

GO
Create procedure TRAEME_LA_COPA_MESSI.getConsumibles

as
begin

select * from TRAEME_LA_COPA_MESSI.Consumible

END


GO
CREATE PROCEDURE TRAEME_LA_COPA_MESSI.crearFactura
@numReserva int,
@idHotel int

AS
BEGIN

	DECLARE @idCliente int
	DECLARE @idClienteInc int

	SET @idCliente = (SELECT IdCliente FROM TRAEME_LA_COPA_MESSI.Reserva WHERE IdReserva = @numReserva)
	SET @idClienteInc = (SELECT IdClienteInconsistente FROM TRAEME_LA_COPA_MESSI.Reserva WHERE IdReserva = @numReserva)

	INSERT INTO TRAEME_LA_COPA_MESSI.Factura(Fact_Fecha,Fact_idCliente,Fact_idClienteInc,Fact_idHotel)
	VALUES(GETDATE(), @idCliente, @idClienteInc, @idHotel)

	RETURN (SELECT MAX(Fact_Nro) FROM TRAEME_LA_COPA_MESSI.Factura)

END


GO
CREATE PROCEDURE TRAEME_LA_COPA_MESSI.facturarConsumible
@idConsumible int,
@cantidad int,
@factNum decimal(18,0)

AS
BEGIN

	INSERT INTO TRAEME_LA_COPA_MESSI.Item_Factura(Fac_Numero, IdConsumible, Cantidad, Monto)
	VALUES (@factNum,@idConsumible, @cantidad,
			(SELECT Precio FROM TRAEME_LA_COPA_MESSI.Consumible WHERE IdConsumible = @idConsumible) * @cantidad)

END

/*
GO
CREATE PROCEDURE TRAEME_LA_COPA_MESSI.facturarEstadia
@factNum decimal(18,0),
@idReserva int

AS
BEGIN
	
	DECLARE @diasUsados int
	DECLARE @costoPorDia int

	SET @diasUsados = (SELECT CantidadNocheUsadas FROM TRAEME_LA_COPA_MESSI.LogEstadia WHERE ReservaId = @idReserva)

	SET @costoPorDia = (
	
	((SELECT PrecioBase FROM TRAEME_LA_COPA_MESSI.RegimenEstadia re JOIN TRAEME_LA_COPA_MESSI.Reserva r ON
	r.RegimenEstadiaId = re.IdRegimenEstadia  WHERE IdReserva = @idReserva) * 
	(SELECT Porcentual FROM TRAEME_LA_COPA_MESSI.TipoHabitacion JOIN TRAEME_LA_COPA_MESSI.Reserva r ON
			r.tipoHabitacion = Codigo WHERE r.IdReserva = @idReserva)) +
	(SELECT PorcentajeEstrellas FROM TRAEME_LA_COPA_MESSI.Hotel h JOIN TRAEME_LA_COPA_MESSI.Reserva r ON
			r.IdHotel = h.IdHotel WHERE r.IdReserva = @idReserva)

			)


	INSERT INTO TRAEME_LA_COPA_MESSI.Item_Factura(Fac_Numero, Reserva_descrip, Reserva_diasUsados, Reserva_diasSinUso, Monto)
	VALUES (@factNum,
			(SELECT Descripcion FROM TRAEME_LA_COPA_MESSI.TipoHabitacion JOIN TRAEME_LA_COPA_MESSI.Reserva r ON
			r.tipoHabitacion = Codigo WHERE r.IdReserva = @idReserva) + ' + ' +
			(SELECT Descripcion FROM TRAEME_LA_COPA_MESSI.RegimenEstadia JOIN TRAEME_LA_COPA_MESSI.Reserva r ON
			r.RegimenEstadiaId = IdRegimenEstadia WHERE r.IdReserva = @idReserva),
			@diasUsados,
			((SELECT CantidadNochesReservadas FROM TRAEME_LA_COPA_MESSI.Reserva WHERE IdReserva = @idReserva) - @diasUsados),
			@costoPorDia * @diasUsados)



END
*/

GO
CREATE PROCEDURE TRAEME_LA_COPA_MESSI.calcularTotalFactura
@numFactura decimal(18,0)

AS
BEGIN

	UPDATE TRAEME_LA_COPA_MESSI.Factura SET
	Fact_Total = (SELECT SUM(Monto) FROM TRAEME_LA_COPA_MESSI.Item_Factura WHERE Fac_Numero = @numFactura)
	WHERE Fact_Nro = @numFactura

END


GO
CREATE PROCEDURE TRAEME_LA_COPA_MESSI.comprobarNumReservaCheckout
@reservaId int

AS
BEGIN

	IF (EXISTS (SELECT FechaInicio FROM TRAEME_LA_COPA_MESSI.LogEstadia WHERE ReservaId = @reservaId) AND
	   (SELECT FechaFin FROM TRAEME_LA_COPA_MESSI.LogEstadia WHERE ReservaId = @reservaId) IS NULL)

	BEGIN

	RETURN 1

	END

	ELSE

	IF NOT EXISTS (SELECT IdReserva FROM TRAEME_LA_COPA_MESSI.Reserva WHERE IdReserva = @reservaId)

	BEGIN

	RETURN 4

	END

	IF (EXISTS (SELECT FechaInicio FROM TRAEME_LA_COPA_MESSI.LogEstadia WHERE ReservaId = @reservaId) AND
	   (SELECT FechaFin FROM TRAEME_LA_COPA_MESSI.LogEstadia WHERE ReservaId = @reservaId) IS NOT NULL)

	BEGIN

	RETURN 3

	END

	ELSE

	IF NOT EXISTS (SELECT FechaInicio FROM TRAEME_LA_COPA_MESSI.LogEstadia WHERE ReservaId = @reservaId)

	BEGIN

	RETURN 2

	END


END


Go
Create procedure TRAEME_LA_COPA_MESSI.verificarAllInclusive
@numReserva int
as begin 
if (exists (select re.Descripcion from TRAEME_LA_COPA_MESSI.Reserva r join TRAEME_LA_COPA_MESSI.RegimenEstadia re on r.RegimenEstadiaId = re.IdRegimenEstadia
 where r.IdReserva= @numReserva and re.Descripcion= 'All inclusive'))
 return 1
 else 
 return 2
 End

 Go
 Create Procedure TRAEME_LA_COPA_MESSI.DescontarConsumibles
 @numFactura int
 as begin
 insert into TRAEME_LA_COPA_MESSI.Item_Factura (Fac_Numero,Cantidad,Reserva_descrip,Monto)
 values (@numFactura,1,'Descuento por regimen de estadia',(select -sum(monto) from TRAEME_LA_COPA_MESSI.Item_Factura where @numFactura=Fac_Numero and IdConsumible IS NOT NULL))
 end



 /* Repo listado estadistico */


GO
CREATE PROCEDURE TRAEME_LA_COPA_MESSI.topConsumiblesFacturados
@anio int,
@trimestre int

AS
BEGIN
	
	DECLARE @mesInicioTri int
	DECLARE @mesFinTri int
				
	IF @trimestre = 1
	BEGIN

	SET @mesInicioTri = 1
	SET @mesFinTri = 3

	END

	ELSE
		BEGIN

		IF @trimestre = 2

		BEGIN

		SET @mesInicioTri = 4
		SET @mesFinTri = 6

		END
		

		ELSE
			BEGIN

			IF @trimestre = 3

			BEGIN

			SET @mesInicioTri = 7
			SET @mesFinTri = 9

			END

			ELSE
				BEGIN

				IF @trimestre = 3

				BEGIN

				SET @mesInicioTri = 10
				SET @mesFinTri = 12
				
				END

			END

		END
	END

	TRUNCATE TABLE TRAEME_LA_COPA_MESSI.consumiblesHotel

	INSERT INTO TRAEME_LA_COPA_MESSI.consumiblesHotel

	SELECT f.Fact_idHotel, SUM(i.cantidad) Cantidad_consumibles FROM
	TRAEME_LA_COPA_MESSI.Factura f
	JOIN TRAEME_LA_COPA_MESSI.Item_Factura i ON i.Fac_Numero = f.Fact_Nro 
	WHERE i.IdConsumible IS NOT NULL AND 
	YEAR(f.Fact_Fecha) = 2017 AND
	(MONTH(f.Fact_Fecha) >= @mesInicioTri AND
	MONTH(f.Fact_Fecha) <= @mesFinTri)

	GROUP BY f.Fact_idHotel

	INSERT INTO TRAEME_LA_COPA_MESSI.consumiblesHotel

	SELECT f.Fact_idHotel, SUM(i.cantidad) Cantidad_consumibles FROM
	TRAEME_LA_COPA_MESSI.Factura_Inconsistente f
	JOIN TRAEME_LA_COPA_MESSI.Item_Factura i ON i.Fac_Numero_Inc = f.Fact_Nro 
	WHERE i.IdConsumible IS NOT NULL AND
	YEAR(f.Fact_Fecha) = @anio AND
	(MONTH(f.Fact_Fecha) >= @mesInicioTri AND
	MONTH(f.Fact_Fecha) <= @mesFinTri)

	GROUP BY f.Fact_idHotel



	SELECT TOP 5 * FROM TRAEME_LA_COPA_MESSI.consumiblesHotel
	ORDER BY cantidad DESC
	

END


GO
CREATE PROCEDURE TRAEME_LA_COPA_MESSI.topReservasCanceladas
@trimestre int,
@anio int

AS
BEGIN

	DECLARE @mesInicioTri int
	DECLARE @mesFinTri int
				
	IF @trimestre = 1
	BEGIN

	SET @mesInicioTri = 1
	SET @mesFinTri = 3

	END

	ELSE
		BEGIN

		IF @trimestre = 2

		BEGIN

		SET @mesInicioTri = 4
		SET @mesFinTri = 6

		END
		

		ELSE
			BEGIN

			IF @trimestre = 3

			BEGIN

			SET @mesInicioTri = 7
			SET @mesFinTri = 9

			END

			ELSE
				BEGIN

				IF @trimestre = 3

				BEGIN

				SET @mesInicioTri = 10
				SET @mesFinTri = 12
				
				END

			END

		END
	END


	SELECT TOP 5 r.IdHotel, COUNT(*) Cantidad_cancelaciones FROM TRAEME_LA_COPA_MESSI.Log_Reserva l JOIN
	TRAEME_LA_COPA_MESSI.Reserva r ON Log_idReserva = IdReserva
	WHERE
	YEAR(l.Log_Fecha) = @anio AND
	(MONTH(l.Log_Fecha) >= @mesInicioTri AND
	MONTH(l.Log_Fecha) <= @mesFinTri)
	GROUP BY r.IdHotel
	ORDER BY 2 DESC

END


GO
CREATE PROCEDURE TRAEME_LA_COPA_MESSI.topDiasFueraDeServicio
@anio int,
@trimestre int

AS
BEGIN

	DECLARE @mesInicioTri int
	DECLARE @mesFinTri int
				
	IF @trimestre = 1
	BEGIN

	SET @mesInicioTri = 1
	SET @mesFinTri = 3

	END

	ELSE
		BEGIN

		IF @trimestre = 2

		BEGIN

		SET @mesInicioTri = 4
		SET @mesFinTri = 6

		END
		

		ELSE
			BEGIN

			IF @trimestre = 3

			BEGIN

			SET @mesInicioTri = 7
			SET @mesFinTri = 9

			END

			ELSE
				BEGIN

				IF @trimestre = 3

				BEGIN

				SET @mesInicioTri = 10
				SET @mesFinTri = 12
				
				END

			END

		END
	END

	SELECT TOP 5 IdHotel, SUM(DAY(FechaFin) - DAY(FechaInicio)) AS Dias_fuera_servicio FROM
	TRAEME_LA_COPA_MESSI.InhabilitacionesHotel
	WHERE
	YEAR(FechaInicio) = @anio AND
	YEAR(FechaFin) = @anio AND
	MONTH(FechaInicio) >= @mesInicioTri AND
	MONTH(FechaFin) <= @mesFinTri
	GROUP BY IdHotel ORDER BY 2 DESC

END


GO
CREATE PROCEDURE TRAEME_LA_COPA_MESSI.topCliente
@trimestre int,
@anio int

AS
BEGIN

	DECLARE @mesInicioTri int
	DECLARE @mesFinTri int
				
	IF @trimestre = 1
	BEGIN

	SET @mesInicioTri = 1
	SET @mesFinTri = 3

	END

	ELSE
		BEGIN

		IF @trimestre = 2

		BEGIN

		SET @mesInicioTri = 4
		SET @mesFinTri = 6

		END
		

		ELSE
			BEGIN

			IF @trimestre = 3

			BEGIN

			SET @mesInicioTri = 7
			SET @mesFinTri = 9

			END

			ELSE
				BEGIN

				IF @trimestre = 3

				BEGIN

				SET @mesInicioTri = 10
				SET @mesFinTri = 12
				
				END

			END

		END
	END

	
	TRUNCATE TABLE TRAEME_LA_COPA_MESSI.puntosClientes

	INSERT INTO TRAEME_LA_COPA_MESSI.puntosClientes(idCliente,puntos)

	(SELECT IdCliente, SUM(Monto)/10 FROM TRAEME_LA_COPA_MESSI.Item_Factura i
	LEFT JOIN TRAEME_LA_COPA_MESSI.Factura f ON f.Fact_Nro = i.Fac_Numero
	LEFT JOIN TRAEME_LA_COPA_MESSI.Factura_Inconsistente fi ON fi.Fact_Nro = i.Fac_Numero_Inc
	JOIN TRAEME_LA_COPA_MESSI.Cliente c ON c.IdCliente = f.Fact_idCliente OR c.IdCliente = fi.Fact_idCliente
	WHERE

	i.IdConsumible IS NOT NULL  AND
	(YEAR(fi.Fact_Fecha) = @anio OR
	YEAR(f.Fact_Fecha) = @anio) AND
	((MONTH(fi.Fact_Fecha) > @mesInicioTri AND
	MONTH(fi.Fact_Fecha) < @mesFinTri) OR
	(MONTH(f.Fact_Fecha) > @mesInicioTri AND
	MONTH(f.Fact_Fecha) < @mesFinTri))

	GROUP BY IdCliente
	
	UNION
	
	SELECT IdCliente, SUM(Monto)/20 FROM TRAEME_LA_COPA_MESSI.Item_Factura i
	LEFT JOIN TRAEME_LA_COPA_MESSI.Factura f ON f.Fact_Nro = i.Fac_Numero
	LEFT JOIN TRAEME_LA_COPA_MESSI.Factura_Inconsistente fi ON fi.Fact_Nro = i.Fac_Numero_Inc
	JOIN TRAEME_LA_COPA_MESSI.Cliente c ON c.IdCliente = f.Fact_idCliente OR c.IdCliente = fi.Fact_idCliente
	WHERE
	
	i.IdConsumible IS NULL AND
	(YEAR(fi.Fact_Fecha) = @anio OR
	YEAR(f.Fact_Fecha) = @anio) AND
	((MONTH(fi.Fact_Fecha) > @mesInicioTri AND
	MONTH(fi.Fact_Fecha) < @mesFinTri) OR
	(MONTH(f.Fact_Fecha) > @mesInicioTri AND
	MONTH(f.Fact_Fecha) < @mesFinTri))

	GROUP BY IdCliente
	)

	
	INSERT INTO TRAEME_LA_COPA_MESSI.puntosClientes(idCliente,puntos)

	(SELECT IdCliente, SUM(Monto)/10 FROM TRAEME_LA_COPA_MESSI.Item_Factura i
	LEFT JOIN TRAEME_LA_COPA_MESSI.Factura f ON f.Fact_Nro = i.Fac_Numero
	LEFT JOIN TRAEME_LA_COPA_MESSI.Factura_Inconsistente fi ON fi.Fact_Nro = i.Fac_Numero_Inc
	JOIN TRAEME_LA_COPA_MESSI.Cliente_Inconsistente c ON c.IdCliente = f.Fact_idClienteInc OR c.IdCliente = fi.Fact_idClienteInc
	WHERE

	i.IdConsumible IS NOT NULL AND
	(YEAR(fi.Fact_Fecha) = @anio OR
	YEAR(f.Fact_Fecha) = @anio) AND
	((MONTH(fi.Fact_Fecha) > @mesInicioTri AND
	MONTH(fi.Fact_Fecha) < @mesFinTri) OR
	(MONTH(f.Fact_Fecha) > @mesInicioTri AND
	MONTH(f.Fact_Fecha) < @mesFinTri))

	GROUP BY IdCliente

	UNION
	
	SELECT IdCliente, SUM(Monto)/20 FROM TRAEME_LA_COPA_MESSI.Item_Factura i
	LEFT JOIN TRAEME_LA_COPA_MESSI.Factura f ON f.Fact_Nro = i.Fac_Numero
	LEFT JOIN TRAEME_LA_COPA_MESSI.Factura_Inconsistente fi ON fi.Fact_Nro = i.Fac_Numero_Inc
	JOIN TRAEME_LA_COPA_MESSI.Cliente_Inconsistente c ON c.IdCliente = f.Fact_idClienteInc OR c.IdCliente = fi.Fact_idClienteInc
	WHERE
	
	i.IdConsumible IS NULL AND
	(YEAR(fi.Fact_Fecha) = @anio OR
	YEAR(f.Fact_Fecha) = @anio) AND
	((MONTH(fi.Fact_Fecha) > @mesInicioTri AND
	MONTH(fi.Fact_Fecha) < @mesFinTri) OR
	(MONTH(f.Fact_Fecha) > @mesInicioTri AND
	MONTH(f.Fact_Fecha) < @mesFinTri))

	GROUP BY IdCliente
	)

	SELECT TOP 5 * FROM TRAEME_LA_COPA_MESSI.puntosClientes
	ORDER BY puntos DESC

END


GO
CREATE PROCEDURE TRAEME_LA_COPA_MESSI.topHabitacionesOcupadas
@anio int,
@trimestre int

AS
BEGIN


	DECLARE @mesInicioTri int
	DECLARE @mesFinTri int
				
	IF @trimestre = 1
	BEGIN

	SET @mesInicioTri = 1
	SET @mesFinTri = 3

	END

	ELSE
		BEGIN

		IF @trimestre = 2

		BEGIN

		SET @mesInicioTri = 4
		SET @mesFinTri = 6

		END
		

		ELSE
			BEGIN

			IF @trimestre = 3

			BEGIN

			SET @mesInicioTri = 7
			SET @mesFinTri = 9

			END

			ELSE
				BEGIN

				IF @trimestre = 3

				BEGIN

				SET @mesInicioTri = 10
				SET @mesFinTri = 12
				
				END

			END

		END
	END


	SELECT TOP 5 NumeroHabitacion, hr.IdHotel, COUNT(*) Cantidad_veces_reservada, SUM(le.CantidadNocheUsadas) Cantidad_noches_ocupada

	FROM

	TRAEME_LA_COPA_MESSI.HabitacionPorReserva hr JOIN
	TRAEME_LA_COPA_MESSI.Reserva r ON hr.IdReserva = r.IdReserva LEFT JOIN
	TRAEME_LA_COPA_MESSI.LogEstadia le ON r.IdReserva = le.ReservaId
	
	WHERE

	YEAR(le.FechaInicio) = @anio AND
	MONTH(le.FechaInicio) <= @mesInicioTri

	GROUP BY NumeroHabitacion, hr.IdHotel
	ORDER BY COUNT(*) + SUM(le.CantidadNocheUsadas) DESC


END
