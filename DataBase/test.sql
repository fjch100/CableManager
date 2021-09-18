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

-- Volcando estructura para tabla Test.persona
CREATE TABLE IF NOT EXISTS `persona` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `PosicionId` int(11) NOT NULL DEFAULT 0,
  `Nombre` varchar(50) NOT NULL DEFAULT '0',
  `Apellido` varchar(50) DEFAULT '0',
  `Direccion` varchar(100) DEFAULT '0',
  `Activo` int(10) unsigned DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `FKposicion` (`PosicionId`) USING BTREE,
  CONSTRAINT `FKposicion` FOREIGN KEY (`posicionId`) REFERENCES `posicion` (`id`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4;

-- Volcando datos para la tabla Test.persona: ~8 rows (aproximadamente)
DELETE FROM `persona`;
/*!40000 ALTER TABLE `persona` DISABLE KEYS */;
INSERT INTO `persona` (`id`, `PosicionId`, `Nombre`, `Apellido`, `Direccion`, `Activo`) VALUES
	(1, 1, 'Felix', 'Centeno', 'Mexico', 1),
	(5, 2, 'malacatero', 'BH', 'Mexico', 1),
	(6, 2, 'Gustavo', 'Avalos', 'Mexico', 1),
	(7, 2, 'Deibi', 'Heredia', 'Mexico', 1),
	(8, 2, 'malactero3', 'BH', 'Mexico', 1),
	(9, 2, 'Malacatero4', 'BH', 'Mexico', 0),
	(10, 2, 'Malaca', 'BH', 'Mexico', 1),
	(11, 1, 'Juan', 'Ramirez', 'Paraiso', 1),
	(12, 1, 'Luis', 'Zetina', 'Mexico', 1),
	(13, 1, 'Pavel', 'Alvarez', 'Mexico', 0);
/*!40000 ALTER TABLE `persona` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
