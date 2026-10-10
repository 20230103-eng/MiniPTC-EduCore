CREATE DATABASE DbGestionAcademica;
GO

USE DbGestionAcademica;
GO

CREATE TABLE tbTipoUsuario
(
    IdTipoUsuario INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(30) NOT NULL
);
GO

CREATE TABLE tbUsuario
(
    IdUsuario INT IDENTITY(1,1) PRIMARY KEY,
    Codigo VARCHAR(20) NOT NULL,
    NombreUsuario VARCHAR(50) NOT NULL,
    Contrasena VARCHAR(100) NOT NULL,
    NombreCompleto VARCHAR(100) NOT NULL,
    IdTipoUsuario INT NOT NULL,
    Estado BIT NOT NULL,
    FOREIGN KEY (IdTipoUsuario) REFERENCES tbTipoUsuario(IdTipoUsuario)
);
GO

CREATE TABLE tbMateria
(
    IdMateria INT IDENTITY(1,1) PRIMARY KEY,
    Codigo VARCHAR(20) NOT NULL,
    Nombre VARCHAR(80) NOT NULL,
    IdProfesor INT NOT NULL,
    Estado BIT NOT NULL,
    FOREIGN KEY (IdProfesor) REFERENCES tbUsuario(IdUsuario)
);
GO

CREATE TABLE tbInscripcion
(
    IdInscripcion INT IDENTITY(1,1) PRIMARY KEY,
    IdEstudiante INT NOT NULL,
    IdMateria INT NOT NULL,
    FOREIGN KEY (IdEstudiante) REFERENCES tbUsuario(IdUsuario),
    FOREIGN KEY (IdMateria) REFERENCES tbMateria(IdMateria)
);
GO

CREATE TABLE tbCalificacion
(
    IdCalificacion INT IDENTITY(1,1) PRIMARY KEY,
    IdInscripcion INT NOT NULL,
    Periodo INT NOT NULL,
    NombreEvaluacion VARCHAR(80) NOT NULL,
    Nota DECIMAL(5,2) NOT NULL,
    Observacion VARCHAR(200),
    FOREIGN KEY (IdInscripcion) REFERENCES tbInscripcion(IdInscripcion)
);
GO
