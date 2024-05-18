CREATE DATABASE Colegio 
USE Colegio


-- CREACION DE LAS TABLAS
CREATE TABLE APODERADO(
Id_Apoderado VARCHAR(6) PRIMARY KEY,
Ape_Mate  VARCHAR(30) NOT NULL,
Ape_Pate VARCHAR (30) NOT NULL,
Nombres VARCHAR (30) NOT NULL,
Dni INT NOT NULL,
Num_Telefono INT NOT NULL,
)

CREATE TABLE HORARIOS(
Id_Horario VARCHAR(6) PRIMARY KEY,
Id_Año VARCHAR(6) NOT NULL,
Hora_Inicio TIME NOT NULL,
Hora_Fin TIME NOT NULL,
Turno VARCHAR(30) NOT NULL,
Dias_Semana VARCHAR(60) NOT NULL,
)

CREATE TABLE AÑO_ESCOLAR(
Id_Año VARCHAR(6) PRIMARY KEY,
Id_Horario VARCHAR(6) NOT NULL,
Grado VARCHAR(20) NOT NULL,
Seccion VARCHAR(20) NOT NULL,
)

CREATE TABLE SALON
(
Id_Salon VARCHAR(6) PRIMARY KEY,
Capacidad INT NOT NULL,
)

	CREATE TABLE DOCENTE
	(
	Id_Docente VARCHAR(6) PRIMARY KEY,
	Ape_Paterno VARCHAR (20) NOT NULL,
	Ape_Materno VARCHAR (20) NOT NULL,
	Nombres VARCHAR (20) NOT NULL,
	Estado_Civil VARCHAR (20) NOT NULL,
	Fecha_Nacimiento VARCHAR (20) NOT NULL,
	Direccion VARCHAR (60) NOT NULL,
	Telefono INT NOT NULL,
	DNI INT NOT NULL,
	Sueldo DECIMAL(10,2) NOT NULL,	
	)
CREATE TABLE ESTUDIANTE
(
Id_Estudiante VARCHAR(6) PRIMARY KEY,
Ape_Paterno VARCHAR (20) NOT NULL,
Ape_Materno VARCHAR (20) NOT NULL,
Nombres VARCHAR (20) NOT NULL,
Fecha_Nacimiento VARCHAR (20) NOT NULL,
Direccion VARCHAR (60) NOT NULL,
Telefono INT NOT NULL,
DNI INT NOT NULL,
Distrito VARCHAR(30) NOT NULL,	
CorreoElectronico VARCHAR(30) NOT NULL,
Genero VARCHAR(30) NOT NULL,
)

select * from ESTUDIANTE
SELECT * FROM NOTAS
select * from CURSO
select * from DOCENTE

CREATE TABLE CURSO
(
Id_Curso VARCHAR(6) PRIMARY KEY,
Id_Horario VARCHAR(6) NOT NULL,
Id_Docente VARCHAR(6) NOT NULL,
Nombre VARCHAR(50) NOT NULL,
)

SELECT * FROM CURSO

CREATE TABLE NOTAS(
Id_Nota VARCHAR(6) PRIMARY KEY,
Id_Estudiante VARCHAR(6) NOT NULL,
Id_Curso VARCHAR(6) NOT NULL,
Calificacion INT NOT NULL,
)


CREATE TABLE ASISTENCIA(
Id_Asistencia VARCHAR(6) NOT NULL,
Id_Estudiante VARCHAR(6) NOT NULL,
Id_Horario VARCHAR(6) NOT NULL,
Descripcion VARCHAR(30) NOT NULL

)

CREATE TABLE PAGOS(
Id_Pago VARCHAR(6) PRIMARY KEY,
Id_Estudiante VARCHAR(6) NOT NULL,
Descripcion VARCHAR(50) NOT NULL,
Monto DECIMAL(10,2) NOT NULL,
)
	

--AGREGAR DATOS A LAS TABLAS

-- Datos para la tabla APODERADO
INSERT INTO APODERADO (Id_Apoderado, Ape_Mate, Ape_Pate, Nombres, Dni, Num_Telefono) 
VALUES 
('APO001', 'Lopez', 'Gonzalez', 'Maria', 12345678, 987654321),
('APO002', 'Martinez', 'Perez', 'Juan', 87654321, 654321987),
('APO003', 'Garcia', 'Sanchez', 'Ana', 56781234, 123456789),
('APO004', 'Rodriguez', 'Lopez', 'Pedro', 34567812, 456789123),
('APO005', 'Gomez', 'Martinez', 'Luis', 98765432, 321987654),
('APO006', 'Fernandez', 'Lopez', 'Sofia', 23456789, 789123456),
('APO007', 'Diaz', 'Gomez', 'Carlos', 34567890, 456789012),
('APO008', 'Perez', 'Sanchez', 'Laura', 45678901, 987012345),
('APO009', 'Sanchez', 'Gonzalez', 'Jorge', 56789012, 654789012),
('APO010', 'Lopez', 'Martinez', 'Ana', 67890123, 321654987);

-- Datos para la tabla HORARIOS
INSERT INTO HORARIOS (Id_Horario, Id_Año, Hora_Inicio, Hora_Fin, Turno, Dias_Semana) 
VALUES 
('HOR001', 'AE001', '08:00:00', '12:00:00', 'Mañana', 'Lunes-Martes-Miércoles-Jueves-Viernes'),
('HOR002', 'AE002', '13:00:00', '17:00:00', 'Tarde', 'Lunes-Martes-Miércoles-Jueves-Viernes'),
('HOR003', 'AE003', '08:30:00', '11:30:00', 'Mañana', 'Lunes-Martes-Miércoles-Jueves-Viernes'),
('HOR004', 'AE004', '14:00:00', '18:00:00', 'Tarde', 'Lunes-Martes-Miércoles-Jueves-Viernes'),
('HOR005', 'AE005', '07:45:00', '11:45:00', 'Mañana', 'Lunes-Martes-Miércoles-Jueves-Viernes');

-- Datos para la tabla AÑO_ESCOLAR
INSERT INTO AÑO_ESCOLAR (Id_Año, Id_Horario, Grado, Seccion) 
VALUES 
('AE001', 'HOR001', 'Primero', 'A'),
('AE002', 'HOR002', 'Segundo', 'B'),
('AE003', 'HOR003', 'Tercero', 'C'),
('AE004', 'HOR004', 'Cuarto', 'D'),
('AE005', 'HOR005', 'Quinto', 'E');

-- Datos para la tabla SALON
INSERT INTO SALON (Id_Salon, Capacidad) 
VALUES 
('SAL001', 30),
('SAL002', 25),
('SAL003', 35),
('SAL004', 28),
('SAL005', 40);

-- Datos para la tabla DOCENTE
INSERT INTO DOCENTE (Id_Docente, Ape_Paterno, Ape_Materno, Nombres, Estado_Civil, Fecha_Nacimiento, Direccion, Telefono, DNI, Sueldo) 
VALUES 
('DOC001', 'Gonzalez', 'Perez', 'Carlos', 'Soltero', '1980-05-15', 'Av. Lima 123', 987654321, 34567891, 2500.00),
('DOC002', 'Perez', 'Garcia', 'Laura', 'Casado', '1975-08-20', 'Calle Arequipa 456', 654321987, 45678912, 2800.00),
('DOC003', 'Sanchez', 'Martinez', 'Javier', 'Soltero', '1982-02-10', 'Jr. Huancayo 789', 123456789, 56789123, 2700.00),
('DOC004', 'Rodriguez', 'Lopez', 'Sofia', 'Casado', '1978-11-30', 'Av. Tacna 789', 456789123, 67891234, 2600.00),
('DOC005', 'Lopez', 'Gomez', 'Diego', 'Soltero', '1985-04-25', 'Calle Lima 789', 789123456, 78912345, 2900.00);

-- Datos para la tabla ESTUDIANTE
	
VALUES 
('EST001', 'APO001', 'SAL001', 'AE001', 'Lopez', 'Gonzalez', 'Jorge', '2008-03-12', 'Av. Tacna 123', 987654321, 12345678, 'San Juan De Miraflores', 'jorgelopez@example.com', 'Masculino'),
('EST002', 'APO002', 'SAL002', 'AE001', 'Martinez', 'Perez', 'Ana', '2009-06-25', 'Calle Lima 456', 654321987, 23456789, 'Villa Maria Del Triunfo', 'anamartinez@example.com', 'Femenino'),
('EST003', 'APO003', 'SAL003', 'AE002', 'Garcia', 'Sanchez', 'Luis', '2007-11-08', 'Jr. Arequipa 789', 123456789, 34567891, 'Villa el Salvador', 'luisgarcia@example.com', 'Masculino'),
('EST004', 'APO004', 'SAL004', 'AE002', 'Rodriguez', 'Lopez', 'Mariana', '2008-09-14', 'Av. Huancayo 456', 456789123, 45678912, 'San Juan De Miraflores', 'marianarodriguez@example.com', 'Femenino'),
('EST005', 'APO005', 'SAL005', 'AE003', 'Gomez', 'Martinez', 'Carlos', '2007-04-30', 'Calle Junín 789', 789123456, 56789123, 'Lima', 'carlosgomez@example.com', 'Masculino'),
('EST006', 'APO006', 'SAL001', 'AE003', 'Fernandez', 'Lopez', 'Laura', '2008-11-20', 'Av. Arequipa 123', 987123456, 67891234, 'Lima', 'lauraf@example.com', 'Femenino'),
('EST007', 'APO007', 'SAL002', 'AE004', 'Diaz', 'Gomez', 'Pedro', '2007-07-15', 'Jr. Puno 456', 654789012, 78901234, 'Lima', 'pedrodiaz@example.com', 'Masculino'),
('EST008', 'APO008', 'SAL003', 'AE004', 'Perez', 'Sanchez', 'Miguel', '2009-02-28', 'Av. Ayacucho 789', 987012345, 89012345, 'San Juan De Miraflores', 'miguelperez@example.com', 'Masculino'),
('EST009', 'APO009', 'SAL004', 'AE005', 'Sanchez', 'Gonzalez', 'Diana', '2008-06-10', 'Calle Lima 789', 456789012, 90123456, 'San Juan De Miraflores', 'dianasanchez@example.com', 'Femenino'),
('EST010', 'APO010', 'SAL005', 'AE005', 'Lopez', 'Martinez', 'Manuel', '2007-10-05', 'Jr. Huancayo 789', 321654987, 67890123, 'San Luis', 'manuelopez@example.com', 'Masculino');

-- Datos para la tabla CURSO
INSERT INTO CURSO (Id_Curso, Id_Horario, Id_Docente, Id_Año, Nombre) 
VALUES 
('CUR001', 'HOR001', 'DOC001', 'AE001', 'Matemáticas'),
('CUR002', 'HOR002', 'DOC002', 'AE001', 'Ciencias Naturales'),
('CUR003', 'HOR003', 'DOC003', 'AE002', 'Historia'),
('CUR004', 'HOR004', 'DOC004', 'AE002', 'Lenguaje'),
('CUR005', 'HOR005', 'DOC005', 'AE003', 'Educación Física'),
('CUR006', 'HOR001', 'DOC002', 'AE003', 'Arte'),
('CUR007', 'HOR002', 'DOC003', 'AE004', 'Música'),
('CUR008', 'HOR003', 'DOC004', 'AE004', 'Geografía'),
('CUR009', 'HOR004', 'DOC005', 'AE005', 'Inglés'),
('CUR010', 'HOR005', 'DOC001', 'AE005', 'Computación');

-- Datos para la tabla NOTAS
INSERT INTO NOTAS (Id_Nota, Id_Estudiante, Id_Curso, Calificacion) 
VALUES 
('NOT001', 'EST001', 'CUR001', 15),
('NOT002', 'EST002', 'CUR002', 16),
('NOT003', 'EST003', 'CUR001', 14),
('NOT004', 'EST004', 'CUR001', 17),
('NOT005', 'EST005', 'CUR005', 18),
('NOT006', 'EST006', 'CUR006', 16),
('NOT007', 'EST007', 'CUR001', 15),
('NOT008', 'EST008', 'CUR008', 14),
('NOT009', 'EST009', 'CUR009', 16),
('NOT010', 'EST010', 'CUR010', 17),
('NOT011', 'EST001', 'CUR010', 17),
('NOT012', 'EST002', 'CUR009', 18),
('NOT013', 'EST003', 'CUR008', 15),
('NOT014', 'EST004', 'CUR007', 16),
('NOT015', 'EST005', 'CUR006', 14);

-- Datos para la tabla ASISTENCIA
INSERT INTO ASISTENCIA (Id_Asistencia, Id_Estudiante, Id_Horario, Descripcion) 
VALUES 
('ASI001', 'EST001', 'HOR001', 'Asistió'),
('ASI002', 'EST002', 'HOR002', 'Asistió'),
('ASI003', 'EST003', 'HOR003', 'Asistió'),
('ASI004', 'EST004', 'HOR004', 'Falto'),
('ASI005', 'EST005', 'HOR005', 'Falto'),
('ASI006', 'EST00', 'HOR001', 'Asistió'),
('ASI007', 'EST007', 'HOR002', 'Asistió'),
('ASI008', 'EST008', 'HOR003', 'Asistió'),
('ASI009', 'EST009', 'HOR004', 'Falto'),
('ASI010', 'EST010', 'HOR005', 'Asistió');
	
-- Datos para la tabla PAGOS
INSERT INTO PAGOS (Id_Pago, Id_Estudiante, Descripcion, Monto) 
VALUES 
('PAG001', 'EST001', 'Matrícula', 200.00),
('PAG002', 'EST002', 'Pensión', 150.00),
('PAG003', 'EST003', 'Matrícula', 200.00),
('PAG004', 'EST004', 'Pensión', 150.00),
('PAG005', 'EST005', 'Matrícula', 200.00),
('PAG006', 'EST006', 'Pensión', 150.00),
('PAG007', 'EST007', 'Matrícula', 200.00),
('PAG008', 'EST008', 'Pensión', 150.00),
('PAG009', 'EST009', 'Matrícula', 200.00),
('PAG010', 'EST010', 'Pensión', 150.00);


--TAREA 15
/*
REALIZAR LAS SIGUIENTES CONSULTAS PARA LA BASE DE DATOS COLEGIO:
*/

--01. LISTAR A TODOS LOS ESTUDIANTES DE SEXO MASCULINO, Y EN QUE GRADO SE ENCUENTRAN MATRICULADOS.

SELECT e.Nombres AS Nombre_Estudiante, e.Ape_Paterno, e.Ape_Materno, ae.Grado, ae.Seccion
FROM ESTUDIANTE e
JOIN AÑO_ESCOLAR ae ON e.Id_Año = ae.Id_Año
WHERE e.Genero = 'Masculino';

--02. LISTAR A TODOS LOS DOCENTES CASADOS Y LOS CURSOS QUE ENSEÑA.

SELECT d.Nombres AS Nombre_Docente, d.Ape_Paterno, d.Ape_Materno, c.Nombre AS Curso_Enseñado
FROM DOCENTE d
JOIN CURSO c ON d.Id_Docente = c.Id_Docente
WHERE d.Estado_Civil = 'Casado';

--03. LISTAR LAS NOTAS DE CADA UNO DE LOS ESTUDIANTES DE UN DETERNIMADO CURSO (MATEMÁTICA).

SELECT e.Nombres AS Nombre_Estudiante, e.Ape_Paterno, e.Ape_Materno, n.Calificacion
FROM ESTUDIANTE e
JOIN NOTAS n ON e.Id_Estudiante = n.Id_Estudiante
JOIN CURSO c ON n.Id_Curso = c.Id_Curso
WHERE c.Nombre = 'Matemáticas';

--04. LISTAR A TODOS LOS ESTUDIANTES QUE VIVAN EN SJM Y NOMBRE DEL APODERADO.

SELECT e.Nombres AS Nombre_Estudiante, e.Ape_Paterno, e.Ape_Materno, e.Distrito, a.Nombres AS Nombre_Apoderado, a.Ape_Pate AS Apellido_Apoderado
FROM ESTUDIANTE e
JOIN APODERADO a ON e.Id_Apoderado = a.Id_Apoderado
WHERE e.Distrito = 'San Juan De Miraflores';

--05. LISTAR TODOS LOS CURSOS QUE SE LLEVAN EN CADA GRADO O AÑO DE ESTUDIOS.

SELECT ae.Grado, ae.Seccion, c.Nombre AS Curso
FROM AÑO_ESCOLAR ae
JOIN CURSO c ON ae.Id_Año = c.Id_Año;

--06. LISTAR EL HORARIO DE UNA SECCIÓN DETERMINADA (EL ALUMNO INDICA LA SECCIÓN).

SELECT ae.Seccion, h.Hora_Inicio, h.Hora_Fin, h.Turno, h.Dias_Semana
FROM HORARIOS h
JOIN AÑO_ESCOLAR ae ON h.Id_Horario = ae.Id_Horario
WHERE ae.Seccion = 'A';

--07. LISTAR LA CANTIDAD DE ALUMNOS QUE HAY POR TURNO.

SELECT h.Turno, COUNT(*) AS Cantidad_Alumnos
FROM HORARIOS h
JOIN AÑO_ESCOLAR ae ON h.Id_Horario = ae.Id_Horario
JOIN ESTUDIANTE e ON ae.Id_Año = e.Id_Año
GROUP BY h.Turno;

--08. LISTAR EL PAGO DE CADA ESTUDIANTE QUE HA REALIZADO POR PENSIÓN.

SELECT e.Nombres AS Nombre_Estudiante, e.Ape_Paterno, e.Ape_Materno, p.Descripcion AS Concepto_Pago, p.Monto
FROM ESTUDIANTE e
JOIN PAGOS p ON e.Id_Estudiante = p.Id_Estudiante
WHERE p.Descripcion = 'Pensión';

--09. LISTAR LAS NOTAS DE UN LOS ESTUDIANTE Y A QUE CURSO PERTENECE.

SELECT e.Nombres AS Nombre_Estudiante, e.Ape_Paterno, e.Ape_Materno, c.Nombre AS Curso, n.Calificacion
FROM ESTUDIANTE e
JOIN NOTAS n ON e.Id_Estudiante = n.Id_Estudiante
JOIN CURSO c ON n.Id_Curso = c.Id_Curso;

--10. LISTAR LA ASISTENCIA Y FALTAS DE LOS ESTUDIANTES

SELECT e.Nombres AS Nombre_Estudiante, e.Ape_Paterno, e.Ape_Materno, a.Descripcion AS Asistencia
FROM ESTUDIANTE e
JOIN ASISTENCIA a ON e.Id_Estudiante = a.Id_Estudiante;


