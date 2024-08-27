
CREATE DATABASE DBCRUDCORE;

USE DBCRUDCORE;

CREATE TABLE logins (
    id INT IDENTITY(1,1) PRIMARY KEY,
    Usuario NVARCHAR(50),
    Contraseńa NVARCHAR(50)
);


CREATE TABLE Usuarios (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    Fecha DATETIME NOT NULL,
    Clave NVARCHAR(50) NOT NULL
);

INSERT INTO logins (Usuario, Contraseńa)
VALUES 
('jgarcia', 'Passw0rd!'),
('mlopez', 'Secure123'),
('arojas', 'Contraseña1'),
('dfernandez', 'Clave2024'),
('rsolis', 'AdminPass45');

INSERT INTO Usuarios (Nombre, Fecha, Clave)
VALUES 
('Juan García', '2024-08-01 10:30:00', 'JuanClave2024'),
('María López', '2024-08-02 14:45:00', 'Maria12345'),
('Ana Rojas', '2024-08-03 09:15:00', 'AnaSegura99'),
('David Fernández', '2024-08-04 17:20:00', 'DavidClave01'),
('Raúl Solís', '2024-08-05 08:05:00', 'Raul2024!Pass');
