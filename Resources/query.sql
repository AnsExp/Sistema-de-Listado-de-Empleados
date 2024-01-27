CREATE TABLE empleados
(
    nombres VARCHAR(30) NOT NULL,
    apellidos VARCHAR(30) NOT NULL,
    cargo VARCHAR(30) NOT NULL,
    salario INT NOT NULL,
    foto_perfil VARCHAR(MAX),
    fecha_nacimiento DATE NOT NULL,
    fecha_ingreso DATE NOT NULL,
    fecha_retiro DATE,
    tipo_documento VARCHAR(20) NOT NULL,
    numero_documento VARCHAR(10) NOT NULL
);

INSERT INTO empleados
    (nombres, apellidos, cargo, salario, foto_perfil, fecha_nacimiento, fecha_ingreso, fecha_retiro, tipo_documento, numero_documento)
VALUES
    ('Juan', 'Pérez', 'Gerente', 5000, NULL, '1980-01-01', '2020-01-01', NULL, 'Cédula', '1234567890'),
    ('María', 'García', 'Asistente', 2000, NULL, '1990-01-01', '2020-01-01', NULL, 'Cédula', '2345678901'),
    ('Pedro', 'Gómez', 'Desarrollador', 3000, NULL, '1995-01-01', '2020-01-01', NULL, 'Cédula', '3456789012'),
    ('Ana', 'Hernández', 'Diseñadora', 2500, NULL, '1995-01-01', '2020-01-01', NULL, 'Cédula', '4567890123'),
    ('Luis', 'Martínez', 'Desarrollador', 3000, NULL, '1995-01-01', '2020-01-01', NULL, 'Cédula', '5678901234'),
    ('Sofía', 'Sánchez', 'Asistente', 2000, NULL, '1990-01-01', '2020-01-01', NULL, 'Cédula', '6789012345'),
    ('Carlos', 'Torres', 'Gerente', 5000, NULL, '1980-01-01', '2020-01-01', NULL, 'Cédula', '7890123456'),
    ('Laura', 'González', 'Diseñadora', 2500, NULL, '1995-01-01', '2020-01-01', NULL, 'Cédula', '8901234567'),
    ('Jorge', 'Díaz', 'Desarrollador', 3000, NULL, '1995-01-01', '2020-01-01', NULL, 'Cédula', '9012345678'),
    ('Fernanda', 'Vargas', 'Asistente', 2000, NULL, '1990-01-01', '2020-01-01', NULL, 'Cédula', '0123456789'),
    ('Andrés', 'Ramírez', 'Desarrollador', 3000, NULL, '1995-01-01', '2020-01-01', NULL, 'Cédula', '2345678901'),
    ('Mónica', 'Castillo', 'Diseñadora', 2500, NULL, '1995-01-01', '2020-01-01', NULL, 'Cédula', '3456789012'),
    ('Diego', 'Alvarado', 'Desarrollador', 3000, NULL, '1995-01-01', '2020-01-01', NULL, 'Cédula', '4567890123'),
    ('Valeria', 'Rojas', 'Asistente', 2000, NULL, '1990-01-01', '2020-01-01', NULL, 'Cédula', '5678901234'),
    ('Gabriel', 'Acosta', 'Gerente', 5000, NULL, '1980-01-01', '2020-01-01', NULL, 'Cédula', '6789012345');

SELECT
    nombres, apellidos, cargo, salario, foto_perfil, fecha_nacimiento, fecha_ingreso, fecha_retiro, tipo_documento, numero_documento
FROM empleados;

DROP TABLE empleados;
