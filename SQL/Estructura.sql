-- creamos la base de datos de el sistema y despues la usamos para crear las tablas
CREATE DATABASE DbGestionAcademica;
GO

USE DbGestionAcademica;
GO

-- tabla de tipos de usuario, aca guardamos los roles que son administrador, profesor y estudiante
CREATE TABLE tbTipoUsuario
(
    IdTipoUsuario INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(30) NOT NULL
);
GO

-- tabla de usuarios, aca guardamos a todos los usuarios de el sistema con su codigo, usuario, la contraseña encriptada con bcrypt, su nombre y su tipo de usuario que es el rol que define a que puede entrar
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

-- tabla de materias, cada materia tiene un profesor asignado que sale de la tabla de usuarios
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

-- tabla de inscripciones, aca guardamos que estudiante esta inscrito en que materia
CREATE TABLE tbInscripcion
(
    IdInscripcion INT IDENTITY(1,1) PRIMARY KEY,
    IdEstudiante INT NOT NULL,
    IdMateria INT NOT NULL,
    FOREIGN KEY (IdEstudiante) REFERENCES tbUsuario(IdUsuario),
    FOREIGN KEY (IdMateria) REFERENCES tbMateria(IdMateria)
);
GO

-- tabla de evaluaciones, cada materia tiene sus evaluaciones por periodo como actividades o proyectos
CREATE TABLE tbEvaluacion
(
    IdEvaluacion INT IDENTITY(1,1) PRIMARY KEY,
    IdMateria INT NOT NULL,
    Periodo INT NOT NULL,
    Nombre VARCHAR(80) NOT NULL,
    Estado BIT NOT NULL,
    FOREIGN KEY (IdMateria) REFERENCES tbMateria(IdMateria)
);
GO

-- tabla de calificaciones, aca guardamos la nota de cada estudiante en cada evaluacion usando su inscripcion
CREATE TABLE tbCalificacion
(
    IdCalificacion INT IDENTITY(1,1) PRIMARY KEY,
    IdInscripcion INT NOT NULL,
    IdEvaluacion INT NOT NULL,
    Nota DECIMAL(5,2) NOT NULL,
    Observacion VARCHAR(200),
    FOREIGN KEY (IdInscripcion) REFERENCES tbInscripcion(IdInscripcion),
    FOREIGN KEY (IdEvaluacion) REFERENCES tbEvaluacion(IdEvaluacion)
);
GO
