USE DbGestionAcademica;
GO

INSERT INTO tbTipoUsuario (Nombre) VALUES ('Administrador');
INSERT INTO tbTipoUsuario (Nombre) VALUES ('Profesor');
INSERT INTO tbTipoUsuario (Nombre) VALUES ('Estudiante');
GO

-- Usuarios de prueba:
-- admin01 / Admin123
-- prof01  / Profesor123
-- prof02  / Profesor123
-- est01   / Estudiante123
-- est02   / Estudiante123

INSERT INTO tbUsuario (Codigo, NombreUsuario, Contrasena, NombreCompleto, IdTipoUsuario, Estado)
VALUES ('ADMIN001', 'admin01', '$2a$10$J6RvmNi4VAC6XXI44TvfGO/P6ZG93k3Tuev52J0U0vIK.SWSDLe86', 'Administrador Principal', 1, 1);

INSERT INTO tbUsuario (Codigo, NombreUsuario, Contrasena, NombreCompleto, IdTipoUsuario, Estado)
VALUES ('PROF001', 'prof01', '$2a$10$F9HMMLKn3184NQ3dVP7PgeUSGj8v2NoiLE1QsRilJUdcSMBPYn7U6', 'Juan Sebastián Ruiz', 2, 1);

INSERT INTO tbUsuario (Codigo, NombreUsuario, Contrasena, NombreCompleto, IdTipoUsuario, Estado)
VALUES ('PROF002', 'prof02', '$2a$10$F9HMMLKn3184NQ3dVP7PgeUSGj8v2NoiLE1QsRilJUdcSMBPYn7U6', 'Laura Sofía Gómez', 2, 1);

INSERT INTO tbUsuario (Codigo, NombreUsuario, Contrasena, NombreCompleto, IdTipoUsuario, Estado)
VALUES ('2023001', 'est01', '$2a$10$jizyp3gNTHz2QCwDJI6FVutXKbwjM9nuObJquT3KpGlbN6yyUZrtG', 'Ana María López', 3, 1);

INSERT INTO tbUsuario (Codigo, NombreUsuario, Contrasena, NombreCompleto, IdTipoUsuario, Estado)
VALUES ('2023002', 'est02', '$2a$10$jizyp3gNTHz2QCwDJI6FVutXKbwjM9nuObJquT3KpGlbN6yyUZrtG', 'Carlos Andrés Pérez', 3, 1);
GO

INSERT INTO tbMateria (Codigo, Nombre, IdProfesor, Estado)
VALUES ('MAT001', 'Matemática', 2, 1);

INSERT INTO tbMateria (Codigo, Nombre, IdProfesor, Estado)
VALUES ('PRG001', 'Programación I', 2, 1);

INSERT INTO tbMateria (Codigo, Nombre, IdProfesor, Estado)
VALUES ('BDD001', 'Base de Datos', 3, 1);
GO

INSERT INTO tbInscripcion (IdEstudiante, IdMateria) VALUES (4, 1);
INSERT INTO tbInscripcion (IdEstudiante, IdMateria) VALUES (4, 2);
INSERT INTO tbInscripcion (IdEstudiante, IdMateria) VALUES (5, 1);
INSERT INTO tbInscripcion (IdEstudiante, IdMateria) VALUES (5, 3);
GO

INSERT INTO tbCalificacion (IdInscripcion, Periodo, NombreEvaluacion, Nota, Observacion)
VALUES (1, 1, 'Actividad 1', 8.50, '');
INSERT INTO tbCalificacion (IdInscripcion, Periodo, NombreEvaluacion, Nota, Observacion)
VALUES (1, 1, 'Actividad 2', 9.00, '');
INSERT INTO tbCalificacion (IdInscripcion, Periodo, NombreEvaluacion, Nota, Observacion)
VALUES (2, 1, 'Proyecto', 8.75, '');
INSERT INTO tbCalificacion (IdInscripcion, Periodo, NombreEvaluacion, Nota, Observacion)
VALUES (3, 1, 'Actividad 1', 7.50, '');
INSERT INTO tbCalificacion (IdInscripcion, Periodo, NombreEvaluacion, Nota, Observacion)
VALUES (4, 1, 'Proyecto', 9.25, '');
GO
