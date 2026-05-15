-- =============================================
-- SISTEMA DE RESERVACION DE CANCHAS DEPORTIVAS
-- Script de Base de Datos Completo
-- =============================================

USE master;
GO

IF EXISTS (SELECT name FROM sys.databases WHERE name = 'ReservacionCanchas')
    DROP DATABASE ReservacionCanchas;
GO

CREATE DATABASE ReservacionCanchas;
GO
USE ReservacionCanchas;
GO

-- Tipos de Cancha
CREATE TABLE TipoCancha (
    IdTipoCancha INT PRIMARY KEY IDENTITY(1,1),
    Nombre       NVARCHAR(50)  NOT NULL,
    Descripcion  NVARCHAR(200)
);

-- Canchas
CREATE TABLE Cancha (
    IdCancha      INT PRIMARY KEY IDENTITY(1,1),
    Nombre        NVARCHAR(100)  NOT NULL,
    IdTipoCancha  INT            NOT NULL,
    PrecioPorHora DECIMAL(10,2)  NOT NULL,
    Activa        BIT            DEFAULT 1,
    FOREIGN KEY (IdTipoCancha) REFERENCES TipoCancha(IdTipoCancha)
);

-- Clientes
CREATE TABLE Cliente (
    IdCliente INT PRIMARY KEY IDENTITY(1,1),
    Nombre    NVARCHAR(100) NOT NULL,
    Apellido  NVARCHAR(100) NOT NULL,
    Telefono  NVARCHAR(20),
    Email     NVARCHAR(100),
    DPI       NVARCHAR(20) UNIQUE
);

-- Horarios fijos
CREATE TABLE Horario (
    IdHorario   INT PRIMARY KEY IDENTITY(1,1),
    HoraInicio  TIME         NOT NULL,
    HoraFin     TIME         NOT NULL,
    Descripcion NVARCHAR(50)
);

-- Empleados (login)
CREATE TABLE Empleado (
    IdEmpleado INT PRIMARY KEY IDENTITY(1,1),
    Nombre     NVARCHAR(100) NOT NULL,
    Usuario    NVARCHAR(50)  UNIQUE NOT NULL,
    Contrasena NVARCHAR(255) NOT NULL,
    Rol        NVARCHAR(20)  DEFAULT 'Empleado'
);

-- Reservas
CREATE TABLE Reserva (
    IdReserva     INT PRIMARY KEY IDENTITY(1,1),
    IdCliente     INT           NOT NULL,
    IdCancha      INT           NOT NULL,
    IdHorario     INT           NOT NULL,
    FechaReserva  DATE          NOT NULL,
    Monto         DECIMAL(10,2) NOT NULL,
    Estado        NVARCHAR(20)  DEFAULT 'Confirmada',
    IdEmpleado    INT           NOT NULL,
    FechaRegistro DATETIME      DEFAULT GETDATE(),
    FOREIGN KEY (IdCliente)  REFERENCES Cliente(IdCliente),
    FOREIGN KEY (IdCancha)   REFERENCES Cancha(IdCancha),
    FOREIGN KEY (IdHorario)  REFERENCES Horario(IdHorario),
    FOREIGN KEY (IdEmpleado) REFERENCES Empleado(IdEmpleado),
    CONSTRAINT UQ_Reserva UNIQUE (IdCancha, FechaReserva, IdHorario)
);
GO

-- =============================================
-- DATOS DE PRUEBA
-- =============================================

INSERT INTO TipoCancha (Nombre, Descripcion) VALUES
('Futbol',   'Cancha de futbol 11 jugadores'),
('Tenis',    'Cancha de tenis individual o dobles'),
('Basquet',  'Cancha de baloncesto');

INSERT INTO Cancha (Nombre, IdTipoCancha, PrecioPorHora, Activa) VALUES
('Cancha Futbol A',  1, 250.00, 1),
('Cancha Futbol B',  1, 200.00, 1),
('Cancha Tenis 1',   2, 150.00, 1),
('Cancha Basquet 1', 3, 100.00, 1);

INSERT INTO Cliente (Nombre, Apellido, Telefono, Email, DPI) VALUES
('Carlos',   'García',    '55551234', 'carlos@email.com',   '1234567890101'),
('María',    'López',     '44442345', 'maria@email.com',    '2345678901202'),
('Pedro',    'Martínez',  '33333456', 'pedro@email.com',    '3456789012303'),
('Ana',      'Rodríguez', '22224567', 'ana@email.com',      '4567890123404');

INSERT INTO Horario (HoraInicio, HoraFin, Descripcion) VALUES
('07:00','08:00','Mañana temprano'),
('08:00','09:00','Mañana'),
('09:00','10:00','Mañana'),
('10:00','11:00','Mañana'),
('14:00','15:00','Tarde'),
('15:00','16:00','Tarde'),
('16:00','17:00','Tarde'),
('17:00','18:00','Tarde'),
('18:00','19:00','Noche'),
('19:00','20:00','Noche');

-- Empleado admin  (usuario: admin / contrasena: admin123)
INSERT INTO Empleado (Nombre, Usuario, Contrasena, Rol) VALUES
('Administrador', 'admin',    'admin123',    'Admin'),
('Juan Pérez',    'empleado1','empleado123', 'Empleado');

PRINT '================================================';
PRINT 'Base de datos creada exitosamente.';
PRINT '';
PRINT 'CREDENCIALES DE ACCESO:';
PRINT '  Usuario: admin       Contrasena: admin123';
PRINT '  Usuario: empleado1   Contrasena: empleado123';
PRINT '================================================';
