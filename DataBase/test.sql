-- --------------------------------------------------------
-- Host:                         192.168.0.20
-- Versión del servidor:         10.3.27-MariaDB-0+deb10u1 - Raspbian 10
-- SO del servidor:              debian-linux-gnueabihf
-- HeidiSQL Versión:             11.3.0.6295
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Volcando estructura de base de datos para Test
CREATE DATABASE IF NOT EXISTS `Test` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;
USE `Test`;

-- Volcando estructura para tabla Test.cable
CREATE TABLE IF NOT EXISTS `cable` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `numero` varchar(50) NOT NULL,
  `long_inicial` double DEFAULT 0,
  `long_actual` double NOT NULL DEFAULT 0,
  `carreras` int(11) NOT NULL DEFAULT 0,
  `drum` varchar(50) NOT NULL DEFAULT '0',
  `fecha_llegada` date DEFAULT NULL,
  `fecha_instalacion` date DEFAULT NULL,
  `tipo_cable` varchar(50) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4;

-- Volcando datos para la tabla Test.cable: ~6 rows (aproximadamente)
DELETE FROM `cable`;
/*!40000 ALTER TABLE `cable` DISABLE KEYS */;
INSERT INTO `cable` (`id`, `numero`, `long_inicial`, `long_actual`, `carreras`, `drum`, `fecha_llegada`, `fecha_instalacion`, `tipo_cable`) VALUES
	(1, '33645', 7900, 6500, 20, '123456', '2021-08-01', '2021-08-01', '7H490RTZZQ'),
	(3, '27456', 7600, 7520, 5, 'kl45216', '2020-08-20', '2020-05-20', '7H490TRZZ'),
	(4, '27027', 8000, 8000, 0, '984532', '2021-08-01', '2021-08-23', '7h490RTZZ'),
	(5, '46784', 7900, 7898, 0, '45632', '2021-07-01', '2021-08-23', '7H490RTZZ'),
	(6, 'ZCABLE-30120', 8000, 7492, 10, 'Z123654', '2020-12-23', '2021-07-20', '7H490RTZZ'),
	(7, 'ZCABLE-33683', 7900, 7488, 6, 'Z119963', '2021-05-18', '2021-07-29', '7H490KZG');
/*!40000 ALTER TABLE `cable` ENABLE KEYS */;

-- Volcando estructura para tabla Test.carrera
CREATE TABLE IF NOT EXISTS `carrera` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `CableId` int(11) NOT NULL DEFAULT 0,
  `Num_carreras` int(11) NOT NULL DEFAULT 0,
  `Max_profundidad` double DEFAULT 0,
  `Max_tension` double DEFAULT 0,
  `Service_order` varchar(50) DEFAULT NULL,
  `Fecha_servicio` date NOT NULL,
  `Ingeniero` varchar(50) DEFAULT '',
  `Malacatero` varchar(50) DEFAULT '',
  `Long_actual` double NOT NULL,
  `Cantidad_cortada` double DEFAULT NULL,
  `Long_previa` double NOT NULL,
  `Comentarios` varchar(250) DEFAULT '',
  PRIMARY KEY (`Id`),
  KEY `CableCarrera` (`CableId`),
  CONSTRAINT `CableCarrera` FOREIGN KEY (`CableId`) REFERENCES `cable` (`id`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4;

-- Volcando datos para la tabla Test.carrera: ~6 rows (aproximadamente)
DELETE FROM `carrera`;
/*!40000 ALTER TABLE `carrera` DISABLE KEYS */;
INSERT INTO `carrera` (`Id`, `CableId`, `Num_carreras`, `Max_profundidad`, `Max_tension`, `Service_order`, `Fecha_servicio`, `Ingeniero`, `Malacatero`, `Long_actual`, `Cantidad_cortada`, `Long_previa`, `Comentarios`) VALUES
	(1, 1, 2, 5500, 3500, 'MX321654', '2021-07-20', 'Fcenteno', 'Malvarez', 6500, 10, 6510, 'ok'),
	(3, 1, 3, 2500, 1500, 'MX321456', '2021-07-24', 'Fcenteno', 'DHeredia', 6500, 0, 6500, 'ok3'),
	(4, 3, 1, 3500, 2000, 'MX784512', '2021-08-21', 'Fcenteno', 'GAvalos', 7200, 0, 7200, 'OK4'),
	(5, 7, 3, 8000, 5000, 'MX123654', '2021-08-29', 'Fcenteno', 'malacatero', 7488, 0, 7488, 'editado 2 veces'),
	(7, 6, 2, 4500, 4000, 'MX321456', '2021-09-01', 'Fcenteno', 'malacatero3', 7492, 8, 7500, ''),
	(8, 5, 3, 6000, 5000, 'MX132654', '2021-09-01', 'Fcenteno', 'Malacatero4', 7898, 2, 7900, '');
/*!40000 ALTER TABLE `carrera` ENABLE KEYS */;

-- Volcando estructura para tabla Test.persona
CREATE TABLE IF NOT EXISTS `persona` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) DEFAULT '0',
  `apellido` varchar(50) DEFAULT '0',
  `direccion` varchar(100) DEFAULT '0',
  `edad` int(11) DEFAULT NULL,
  `peso` double DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4;

-- Volcando datos para la tabla Test.persona: ~4 rows (aproximadamente)
DELETE FROM `persona`;
/*!40000 ALTER TABLE `persona` DISABLE KEYS */;
INSERT INTO `persona` (`id`, `nombre`, `apellido`, `direccion`, `edad`, `peso`) VALUES
	(1, 'Felix', 'Centeno', 'Mexico', 51, 104.5),
	(2, 'Ilce', 'Villavicencio', 'Mexico', 51, 65.4),
	(3, 'Diego', 'Centeno', 'Quito-Ecuador', 22, 62.3),
	(4, 'Maria', 'Centeno', 'Quito-Ecuador', 25, 67.5);
/*!40000 ALTER TABLE `persona` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
