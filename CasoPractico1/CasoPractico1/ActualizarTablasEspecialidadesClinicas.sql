-- Script para agregar columnas faltantes a las tablas Especialidades y Clinicas
USE CASO_PRACTICO_MEDICO;
GO

-- Agregar columnas a Especialidades
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Especialidades' AND COLUMN_NAME = 'Descripcion')
BEGIN
    ALTER TABLE [dbo].[Especialidades] ADD [Descripcion] [nvarchar](200) NULL;
    PRINT 'Columna Descripcion agregada a Especialidades';
END

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Especialidades' AND COLUMN_NAME = 'FechaDeRegistro')
BEGIN
    ALTER TABLE [dbo].[Especialidades] ADD [FechaDeRegistro] [datetime] NOT NULL DEFAULT GETDATE();
    PRINT 'Columna FechaDeRegistro agregada a Especialidades';
END

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Especialidades' AND COLUMN_NAME = 'FechaDeModificacion')
BEGIN
    ALTER TABLE [dbo].[Especialidades] ADD [FechaDeModificacion] [datetime] NULL;
    PRINT 'Columna FechaDeModificacion agregada a Especialidades';
END
GO

-- Agregar columnas a Clinicas
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Clinicas' AND COLUMN_NAME = 'Telefono')
BEGIN
    ALTER TABLE [dbo].[Clinicas] ADD [Telefono] [nvarchar](15) NULL;
    PRINT 'Columna Telefono agregada a Clinicas';
END

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Clinicas' AND COLUMN_NAME = 'Correo')
BEGIN
    ALTER TABLE [dbo].[Clinicas] ADD [Correo] [nvarchar](100) NULL;
    PRINT 'Columna Correo agregada a Clinicas';
END

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Clinicas' AND COLUMN_NAME = 'FechaDeRegistro')
BEGIN
    ALTER TABLE [dbo].[Clinicas] ADD [FechaDeRegistro] [datetime] NOT NULL DEFAULT GETDATE();
    PRINT 'Columna FechaDeRegistro agregada a Clinicas';
END

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Clinicas' AND COLUMN_NAME = 'FechaDeModificacion')
BEGIN
    ALTER TABLE [dbo].[Clinicas] ADD [FechaDeModificacion] [datetime] NULL;
    PRINT 'Columna FechaDeModificacion agregada a Clinicas';
END
GO

-- Actualizar registros existentes si los hay
UPDATE Especialidades SET Descripcion = 'Especialidad m�dica' WHERE Descripcion IS NULL;
UPDATE Clinicas SET Telefono = '0000-0000' WHERE Telefono IS NULL;
UPDATE Clinicas SET Correo = 'info@clinica.com' WHERE Correo IS NULL;
GO

-- Insertar datos de ejemplo en Especialidades si est� vac�a
IF (SELECT COUNT(*) FROM Especialidades) = 0
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

-- Insertar datos de ejemplo en Clinicas si est� vac�a
IF (SELECT COUNT(*) FROM Clinicas) = 0
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

PRINT 'Script completado exitosamente';
