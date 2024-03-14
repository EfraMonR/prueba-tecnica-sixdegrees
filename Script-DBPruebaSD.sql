--Creación base de datos
CREATE DATABASE PruebaSD;

--Usar base de datos recien creada
USE PruebaSD;

--Creación tabla Usuario
CREATE TABLE Usuario (
    usuID NUMERIC(18,0) IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(100),
    apellido VARCHAR(100)
);

--Inserción de datos
INSERT INTO Usuario (nombre, apellido)
VALUES ('Andres', 'Rodriguez Vera');

INSERT INTO Usuario (nombre, apellido)
VALUES ('Jose', 'Giraldo Perez');

INSERT INTO Usuario (nombre, apellido)
VALUES ('Carlos', 'Ruiz Díaz');

INSERT INTO Usuario (nombre, apellido)
VALUES ('Juanita', 'Zapata Castellanos');

INSERT INTO Usuario (nombre, apellido)
VALUES ('Pedro', 'Fernandez Sua');