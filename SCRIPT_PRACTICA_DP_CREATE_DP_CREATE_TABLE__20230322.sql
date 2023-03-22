
-- Volcando estructura de base de datos para practica_dp
CREATE DATABASE IF NOT EXISTS `practica_dp`
USE `practica_dp`;

-- Volcando estructura para tabla practica_dp.addresses
DROP TABLE IF EXISTS practica_dp.addresses;
CREATE TABLE IF NOT EXISTS practica_dp.addresses (
  `Id_Distribuidor` varchar(25) DEFAULT NULL,
  `Calle` varchar(255) DEFAULT NULL,
  `Numero_Casa` varchar(25) DEFAULT NULL,
  `Colonia` varchar(120) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- La exportación de datos fue deseleccionada.

-- Volcando estructura para tabla practica_dp.distributors
DROP TABLE IF EXISTS practica_dp.distributors;
CREATE TABLE IF NOT EXISTS practica_dp.distributors (
  `Id` varchar(11) NOT NULL,
  `Fecha_Registro` datetime DEFAULT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- La exportación de datos fue deseleccionada.

-- Volcando estructura para tabla practica_dp.persons
DROP TABLE IF EXISTS practica_dp.persons;
CREATE TABLE IF NOT EXISTS practica_dp.persons (
  `Id_Distribuidor` varchar(25) DEFAULT NULL,
  `Nombre` varchar(255) DEFAULT NULL,
  `Apellido_Paterno` varchar(255) DEFAULT NULL,
  `Apellido_Materno` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- La exportación de datos fue deseleccionada.
