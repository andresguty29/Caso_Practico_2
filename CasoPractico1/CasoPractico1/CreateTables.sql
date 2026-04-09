-- Script para crear las tablas en la base de datos CASO_PRACTICO_MEDICO
USE CASO_PRACTICO_MEDICO;
GO

-- Crear tabla Servicios
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Servicios]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[Servicios](
        [Id] [int] IDENTITY(1,1) NOT NULL,
        [Nombre] [nvarchar](100) NOT NULL,
        [Descripcion] [nvarchar](200) NOT NULL,
        [Monto] [decimal](18, 2) NOT NULL,
        [IVA] [decimal](18, 2) NOT NULL,
        [Especialidad] [int] NOT NULL,
        [Especialista] [nvarchar](200) NOT NULL,
        [Clinica] [nvarchar](200) NOT NULL,
        [FechaDeRegistro] [datetime] NOT NULL,
        [FechaDeModificacion] [datetime] NULL,
        [ESTADO] [bit] NOT NULL,
        CONSTRAINT [PK_Servicios] PRIMARY KEY CLUSTERED ([Id] ASC)
    );
    PRINT 'Tabla Servicios creada exitosamente';
END
ELSE
BEGIN
    PRINT 'La tabla Servicios ya existe';
END
GO

-- Crear tabla CITAS
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CITAS]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[CITAS](
        [Id] [int] IDENTITY(1,1) NOT NULL,
        [NombreDeLaPersona] [nvarchar](150) NOT NULL,
        [Identificacion] [nvarchar](30) NOT NULL,
        [Telefono] [nvarchar](10) NOT NULL,
        [Correo] [nvarchar](50) NOT NULL,
        [FechaNacimiento] [datetime] NOT NULL,
        [Direccion] [nvarchar](200) NOT NULL,
        [MontoTotal] [decimal](18, 2) NOT NULL,
        [FechaDeLaCita] [datetime] NOT NULL,
        [FechaDeRegistro] [datetime] NOT NULL,
        [IdServicio] [int] NOT NULL,
        CONSTRAINT [PK_CITAS] PRIMARY KEY CLUSTERED ([Id] ASC),
        CONSTRAINT [FK_CITAS_Servicios] FOREIGN KEY([IdServicio])
            REFERENCES [dbo].[Servicios] ([Id])
    );
    PRINT 'Tabla CITAS creada exitosamente';
END
ELSE
BEGIN
    PRINT 'La tabla CITAS ya existe';
END
GO

-- Insertar datos de ejemplo en Servicios
IF NOT EXISTS (SELECT * FROM Servicios)
BEGIN
    INSERT INTO [dbo].[Servicios] 
        ([Nombre], [Descripcion], [Monto], [IVA], [Especialidad], [Especialista], [Clinica], [FechaDeRegistro], [ESTADO])
    VALUES
        ('Consulta General', 'Consulta médica general', 50.00, 6.50, 1, 'Dr. Juan Pérez', 'Clínica Central', GETDATE(), 1),
        ('Cardiología', 'Consulta especializada en cardiología', 100.00, 13.00, 2, 'Dra. María López', 'Clínica del Corazón', GETDATE(), 1),
        ('Pediatría', 'Consulta pediátrica', 60.00, 7.80, 3, 'Dr. Carlos Ramírez', 'Clínica Infantil', GETDATE(), 1),
        ('Odontología', 'Limpieza dental', 75.00, 9.75, 4, 'Dra. Ana García', 'Clínica Dental', GETDATE(), 1),
        ('Oftalmología', 'Examen de la vista', 80.00, 10.40, 5, 'Dr. Luis Martínez', 'Clínica Visual', GETDATE(), 1);
    
    PRINT 'Datos de ejemplo insertados en Servicios';
END
GO

PRINT 'Script ejecutado completamente';
