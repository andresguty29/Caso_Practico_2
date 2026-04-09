-- Script para eliminar la columna Estado de las tablas Especialidades y Clinicas
USE CASO_PRACTICO_MEDICO;
GO

-- Eliminar columna Estado de Especialidades si existe
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Especialidades' AND COLUMN_NAME = 'Estado')
BEGIN
    ALTER TABLE [dbo].[Especialidades] DROP COLUMN [Estado];
    PRINT 'Columna Estado eliminada de Especialidades';
END
ELSE
BEGIN
    PRINT 'La columna Estado no existe en Especialidades';
END
GO

-- Eliminar columna Estado de Clinicas si existe
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Clinicas' AND COLUMN_NAME = 'Estado')
BEGIN
    ALTER TABLE [dbo].[Clinicas] DROP COLUMN [Estado];
    PRINT 'Columna Estado eliminada de Clinicas';
END
ELSE
BEGIN
    PRINT 'La columna Estado no existe en Clinicas';
END
GO

PRINT 'Script de eliminación de columna Estado ejecutado completamente';