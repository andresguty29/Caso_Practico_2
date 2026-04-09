-- Script para crear las tablas Especialidades y Clinicas en la base de datos CASO_PRACTICO_MEDICO
USE CASO_PRACTICO_MEDICO;
GO

-- Crear tabla Especialidades
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Especialidades]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[Especialidades](
        [Id] [int] IDENTITY(1,1) NOT NULL,
        [Nombre] [nvarchar](100) NOT NULL,
        [Descripcion] [nvarchar](200) NOT NULL,
        [FechaDeRegistro] [datetime] NOT NULL,
        [FechaDeModificacion] [datetime] NULL,
        CONSTRAINT [PK_Especialidades] PRIMARY KEY CLUSTERED ([Id] ASC)
    );
    PRINT 'Tabla Especialidades creada exitosamente';
END
ELSE
BEGIN
    PRINT 'La tabla Especialidades ya existe';
END
GO

-- Crear tabla Clinicas
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Clinicas]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[Clinicas](
        [Id] [int] IDENTITY(1,1) NOT NULL,
        [Nombre] [nvarchar](150) NOT NULL,
        [Direccion] [nvarchar](250) NOT NULL,
        [Telefono] [nvarchar](15) NOT NULL,
        [Correo] [nvarchar](100) NOT NULL,
        [FechaDeRegistro] [datetime] NOT NULL,
        [FechaDeModificacion] [datetime] NULL,
        CONSTRAINT [PK_Clinicas] PRIMARY KEY CLUSTERED ([Id] ASC)
    );
    PRINT 'Tabla Clinicas creada exitosamente';
END
ELSE
BEGIN
    PRINT 'La tabla Clinicas ya existe';
END
GO

-- Insertar datos de ejemplo en Especialidades
IF NOT EXISTS (SELECT * FROM Especialidades)
BEGIN
    INSERT INTO [dbo].[Especialidades] 
        ([Nombre], [Descripcion], [FechaDeRegistro])
    VALUES
        ('Cardiología', 'Especialidad médica enfocada en el corazón y sistema circulatorio', GETDATE()),
        ('Pediatría', 'Especialidad médica enfocada en la salud de niños y adolescentes', GETDATE()),
        ('Dermatología', 'Especialidad médica enfocada en la piel y sus enfermedades', GETDATE()),
        ('Oftalmología', 'Especialidad médica enfocada en la salud visual', GETDATE()),
        ('Odontología', 'Especialidad médica enfocada en la salud dental', GETDATE());
    
    PRINT 'Datos de ejemplo insertados en Especialidades';
END
GO

-- Insertar datos de ejemplo en Clinicas
IF NOT EXISTS (SELECT * FROM Clinicas)
BEGIN
    INSERT INTO [dbo].[Clinicas] 
        ([Nombre], [Direccion], [Telefono], [Correo], [FechaDeRegistro])
    VALUES
        ('Clínica Central', 'Av. Principal #123, San José', '2222-3333', 'info@clinicacentral.com', GETDATE()),
        ('Clínica del Corazón', 'Calle 5 #456, San José', '2233-4444', 'contacto@clinicacorazon.com', GETDATE()),
        ('Clínica Infantil', 'Av. Los Niños #789, Heredia', '2244-5555', 'info@clinicainfantil.com', GETDATE()),
        ('Clínica Dental', 'Calle 10 #321, Cartago', '2255-6666', 'atencion@clinicadental.com', GETDATE()),
        ('Clínica Visual', 'Av. Central #654, Alajuela', '2266-7777', 'info@clinicavisual.com', GETDATE());
    
    PRINT 'Datos de ejemplo insertados en Clinicas';
END
GO

PRINT 'Script de Especialidades y Clinicas ejecutado completamente';
