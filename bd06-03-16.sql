CREATE DATABASE  IF NOT EXISTS `centroestetica` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `centroestetica`;
-- MySQL dump 10.13  Distrib 5.5.16, for Win32 (x86)
--
-- Host: localhost    Database: centroestetica
-- ------------------------------------------------------
-- Server version	5.1.68-community

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `configuraciones`
--

DROP TABLE IF EXISTS `configuraciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `configuraciones` (
  `idconfiguraciones` int(11) NOT NULL AUTO_INCREMENT,
  `codigo` varchar(45) NOT NULL,
  `detalle` varchar(150) NOT NULL,
  PRIMARY KEY (`idconfiguraciones`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `configuraciones`
--

LOCK TABLES `configuraciones` WRITE;
/*!40000 ALTER TABLE `configuraciones` DISABLE KEYS */;
INSERT INTO `configuraciones` VALUES (1,'fotos','C:\\Users\\Public\\Documents\\');
/*!40000 ALTER TABLE `configuraciones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `contador`
--

DROP TABLE IF EXISTS `contador`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `contador` (
  `idcontador` int(11) NOT NULL AUTO_INCREMENT,
  `numero` int(11) NOT NULL,
  `detalle` varchar(45) NOT NULL,
  PRIMARY KEY (`idcontador`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `contador`
--

LOCK TABLES `contador` WRITE;
/*!40000 ALTER TABLE `contador` DISABLE KEYS */;
INSERT INTO `contador` VALUES (1,23,'factura'),(2,0,'recibo');
/*!40000 ALTER TABLE `contador` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ctacte`
--

DROP TABLE IF EXISTS `ctacte`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ctacte` (
  `idctacte` int(11) NOT NULL AUTO_INCREMENT,
  `idfacturacion` int(11) NOT NULL,
  `idpacientes` int(11) NOT NULL,
  `tipocomp` varchar(1) NOT NULL,
  `importe` decimal(10,2) NOT NULL,
  `cancelado` decimal(10,2) NOT NULL,
  PRIMARY KEY (`idctacte`),
  KEY `cidfact_idx` (`idfacturacion`),
  KEY `cidpac_idx` (`idpacientes`),
  CONSTRAINT `cidfact` FOREIGN KEY (`idfacturacion`) REFERENCES `facturacion` (`idfacturacion`) ON UPDATE CASCADE,
  CONSTRAINT `cidpac` FOREIGN KEY (`idpacientes`) REFERENCES `pacientes` (`idpacientes`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ctacte`
--

LOCK TABLES `ctacte` WRITE;
/*!40000 ALTER TABLE `ctacte` DISABLE KEYS */;
INSERT INTO `ctacte` VALUES (2,1,1,'1',200.00,200.00),(3,1,1,'2',50.00,50.00),(4,1,1,'1',500.00,5.00),(5,19,1,'2',100.00,100.00),(6,20,1,'2',5.00,5.00);
/*!40000 ALTER TABLE `ctacte` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cursos`
--

DROP TABLE IF EXISTS `cursos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cursos` (
  `idcursos` int(11) NOT NULL AUTO_INCREMENT,
  `idprofesionales` int(11) NOT NULL,
  `idservicios` int(11) NOT NULL,
  `idpacientes` int(11) NOT NULL,
  `asistencia` varchar(1) NOT NULL DEFAULT '1',
  `sesion` varchar(45) NOT NULL,
  `fecha` datetime NOT NULL,
  PRIMARY KEY (`idcursos`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cursos`
--

LOCK TABLES `cursos` WRITE;
/*!40000 ALTER TABLE `cursos` DISABLE KEYS */;
INSERT INTO `cursos` VALUES (1,3,6,1,'1','2/10','2016-03-06 00:00:00');
/*!40000 ALTER TABLE `cursos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `especialidades`
--

DROP TABLE IF EXISTS `especialidades`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `especialidades` (
  `idespecialidades` int(11) NOT NULL AUTO_INCREMENT,
  `detalle` varchar(100) NOT NULL,
  PRIMARY KEY (`idespecialidades`),
  UNIQUE KEY `detalle_UNIQUE` (`detalle`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `especialidades`
--

LOCK TABLES `especialidades` WRITE;
/*!40000 ALTER TABLE `especialidades` DISABLE KEYS */;
INSERT INTO `especialidades` VALUES (3,'123321'),(5,'ezequiel'),(1,'masaje'),(6,'probandooo'),(2,'prueba');
/*!40000 ALTER TABLE `especialidades` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `esperas`
--

DROP TABLE IF EXISTS `esperas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `esperas` (
  `idesperas` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) DEFAULT NULL,
  `telefono` varchar(45) DEFAULT NULL,
  `detalle` varchar(150) DEFAULT NULL,
  `fecha` datetime NOT NULL,
  PRIMARY KEY (`idesperas`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `esperas`
--

LOCK TABLES `esperas` WRITE;
/*!40000 ALTER TABLE `esperas` DISABLE KEYS */;
/*!40000 ALTER TABLE `esperas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `facturacion`
--

DROP TABLE IF EXISTS `facturacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `facturacion` (
  `idfacturacion` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` datetime NOT NULL,
  `idpaciente` int(11) DEFAULT NULL,
  `detalle` varchar(100) DEFAULT NULL,
  `domicilio` varchar(50) DEFAULT NULL,
  `documento` varchar(45) DEFAULT NULL,
  `localidad` varchar(100) DEFAULT NULL,
  `total` decimal(10,2) DEFAULT NULL,
  `ptoventa` int(11) DEFAULT '0',
  `factura` int(11) DEFAULT '0',
  `bonificacion` decimal(10,2) DEFAULT '0.00',
  `tipocomp` varchar(1) DEFAULT '1',
  `comentario` varchar(150) DEFAULT '',
  `regalo` varchar(1) DEFAULT '0',
  PRIMARY KEY (`idfacturacion`)
) ENGINE=InnoDB AUTO_INCREMENT=29 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `facturacion`
--

LOCK TABLES `facturacion` WRITE;
/*!40000 ALTER TABLE `facturacion` DISABLE KEYS */;
INSERT INTO `facturacion` VALUES (1,'2016-01-18 21:30:32',0,'Consumidor Final','S/Domicilio','','7600 - Mar del Plata',75.00,0,1,0.00,'1','','0'),(2,'2016-01-18 21:30:58',0,'Consumidor Final','S/Domicilio','','7600 - Mar del Plata',690.00,0,2,60.00,'1','','0'),(3,'2016-01-18 21:39:16',0,'Consumidor Final','S/Domicilio','','7600 - Mar del Plata',155.00,0,3,10.00,'1','','0'),(4,'2016-01-19 19:37:24',1,'eze','asd','231','7600 - Mar del Plata',100.00,0,4,0.00,'1','','0'),(5,'2016-01-19 20:46:44',0,'Consumidor Final','S/Domicilio','','7600 - Mar del Plata',100.00,0,5,0.00,'1','','0'),(6,'2016-01-19 20:55:47',1,'eze askjdlasjdlkasdsa','asd','','7600 - Mar del Plata',115.00,0,5,0.00,'1','','0'),(7,'2016-01-19 20:58:09',1,'eze','asd','231','7600 - Mar del Plata',100.00,0,6,0.00,'1','','0'),(8,'2016-01-26 20:02:08',1,'EZEQUIEL VAZQUEZ','asd','231','7600 - Mar del Plata',215.00,0,7,0.00,'1','','0'),(9,'2016-01-26 20:03:24',1,'EZEQUIEL VAZQUEZ','asd','231','7600 - Mar del Plata',115.00,0,7,0.00,'1','','0'),(10,'2016-01-26 20:03:51',1,'EZEQUIEL VAZQUEZ','asd','231','7600 - Mar del Plata',115.00,0,7,0.00,'1','','0'),(11,'2016-01-26 20:05:59',1,'EZEQUIEL VAZQUEZ','asd','231','7600 - Mar del Plata',130.00,0,7,0.00,'1','','0'),(12,'2016-01-26 20:07:31',1,'EZEQUIEL VAZQUEZ','asd','231','7600 - Mar del Plata',200.00,0,8,0.00,'1','','0'),(13,'2016-01-26 20:11:26',2,'fernando','sda','123','7600 - Mar del Plata',300.00,0,9,0.00,'1','','0'),(14,'2016-01-27 20:13:23',2,'fernando','sda','123','7600 - Mar del Plata',100.00,0,10,0.00,'1','','0'),(15,'2016-02-08 18:53:59',0,'Consumidor Final','S/Domicilio','','7600 - Mar del Plata',15.00,0,11,0.00,'1','','0'),(16,'2016-02-08 18:54:07',0,'1','S/Domicilio','','7600 - Mar del Plata',45.00,0,12,0.00,'1','','0'),(17,'2016-02-08 18:54:22',0,'Consumidor Final','S/Domicilio','','7600 - Mar del Plata',75.00,0,13,0.00,'1','','0'),(18,'2016-02-10 19:55:28',0,'Consumidor Final','S/Domicilio','','7600 - Mar del Plata',15.00,0,14,0.00,'1','','0'),(19,'2016-02-10 17:11:54',1,'EZEQUIEL VAZQUEZ','asd','231','',100.00,0,1,0.00,'2','','0'),(20,'2016-02-10 17:13:25',1,'EZEQUIEL VAZQUEZ','asd','231','',5.00,0,1,0.00,'2','','0'),(21,'2016-02-17 17:51:50',2,'fernando','sda','123','7600 - Mar del Plata',100.00,0,17,0.00,'1','PROBANDO','1'),(22,'2016-02-25 18:02:10',2,'fernando','sda','123','7600 - Mar del Plata',100.00,0,18,0.00,'1','para ezequiel machi y la concha de tu hermana','1'),(23,'2016-02-17 18:06:19',0,'Consumidor Final','S/Domicilio','','7600 - Mar del Plata',60.00,0,19,0.00,'1','','0'),(24,'2016-02-17 19:03:03',0,'Consumidor Final','S/Domicilio','','7600 - Mar del Plata',15.00,1,1,0.00,'1','','0'),(25,'2016-02-24 19:04:36',0,'Consumidor Final','S/Domicilio','','7600 - Mar del Plata',15.00,11,11,0.00,'1','','0'),(26,'2016-02-25 18:04:11',1,'EZEQUIEL VAZQUEZ','asd','231','7600 - Mar del Plata',1000.00,0,21,0.00,'1','','0');
/*!40000 ALTER TABLE `facturacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `feriados`
--

DROP TABLE IF EXISTS `feriados`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `feriados` (
  `idferiados` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` datetime NOT NULL,
  `detalle` varchar(105) DEFAULT NULL,
  PRIMARY KEY (`idferiados`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `feriados`
--

LOCK TABLES `feriados` WRITE;
/*!40000 ALTER TABLE `feriados` DISABLE KEYS */;
/*!40000 ALTER TABLE `feriados` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `formasdepago`
--

DROP TABLE IF EXISTS `formasdepago`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `formasdepago` (
  `idformasdepago` int(11) NOT NULL AUTO_INCREMENT,
  `idtipoformaspago` int(11) NOT NULL,
  `idfacturacion` int(11) NOT NULL,
  `idtarjetas` varchar(2) NOT NULL,
  `cupon` varchar(10) DEFAULT NULL,
  `cuotas` varchar(2) DEFAULT NULL,
  `total` decimal(10,2) NOT NULL,
  PRIMARY KEY (`idformasdepago`),
  KEY `fpfkidformaspago_idx` (`idtipoformaspago`),
  KEY `fpfkidfacturacion_idx` (`idfacturacion`),
  KEY `fpfkidtarjetas_idx` (`idtarjetas`),
  CONSTRAINT `fpfkidfacturacion` FOREIGN KEY (`idfacturacion`) REFERENCES `facturacion` (`idfacturacion`) ON UPDATE CASCADE,
  CONSTRAINT `fpfkidformaspago` FOREIGN KEY (`idtipoformaspago`) REFERENCES `tipoformaspago` (`idtipoformaspago`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `formasdepago`
--

LOCK TABLES `formasdepago` WRITE;
/*!40000 ALTER TABLE `formasdepago` DISABLE KEYS */;
INSERT INTO `formasdepago` VALUES (1,1,1,'','','',75.00),(2,1,2,'','','',690.00),(3,1,3,'','','',155.00),(4,1,4,'','','',100.00),(5,1,6,'','','',115.00),(6,1,7,'','','',100.00),(7,1,11,'','','',130.00),(8,1,12,'','','',200.00),(9,1,13,'','','',300.00),(10,1,14,'','','',100.00),(11,1,15,'','','',15.00),(12,2,16,'2','1','1',45.00),(13,3,17,'3','2','2',75.00),(14,4,18,'','','',15.00),(15,1,19,'','','',100.00),(16,1,20,'','','',5.00),(17,1,21,'','','',100.00),(18,1,22,'','','',100.00),(19,2,23,'2','','',60.00),(20,2,24,'2','4','3',15.00),(21,2,25,'2','11','1',15.00),(22,1,26,'','','',1000.00);
/*!40000 ALTER TABLE `formasdepago` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `honorarios`
--

DROP TABLE IF EXISTS `honorarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `honorarios` (
  `idhonorarios` int(11) NOT NULL AUTO_INCREMENT,
  `idprofesionales` int(11) NOT NULL,
  `idproductos` int(11) NOT NULL,
  `preciocalculo` decimal(10,2) NOT NULL,
  PRIMARY KEY (`idhonorarios`),
  KEY `fkhprof_idx` (`idprofesionales`),
  KEY `fkhprod_idx` (`idproductos`),
  CONSTRAINT `fkhprod` FOREIGN KEY (`idproductos`) REFERENCES `productos` (`idproductos`) ON UPDATE CASCADE,
  CONSTRAINT `fkhprof` FOREIGN KEY (`idprofesionales`) REFERENCES `profesionales` (`idprofesionales`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `honorarios`
--

LOCK TABLES `honorarios` WRITE;
/*!40000 ALTER TABLE `honorarios` DISABLE KEYS */;
INSERT INTO `honorarios` VALUES (1,3,2,25.00),(2,1,1,15.00);
/*!40000 ALTER TABLE `honorarios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `horariosprofesionales`
--

DROP TABLE IF EXISTS `horariosprofesionales`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `horariosprofesionales` (
  `idhorariosprofesionales` int(11) NOT NULL AUTO_INCREMENT,
  `idprofesionales` int(11) NOT NULL,
  `ingreso` varchar(8) NOT NULL,
  `egreso` varchar(8) NOT NULL,
  `desde` datetime NOT NULL,
  `hasta` datetime DEFAULT NULL,
  `lunes` varchar(1) DEFAULT NULL,
  `martes` varchar(1) DEFAULT NULL,
  `miercoles` varchar(1) DEFAULT NULL,
  `jueves` varchar(1) DEFAULT NULL,
  `viernes` varchar(1) DEFAULT NULL,
  `sabado` varchar(1) DEFAULT NULL,
  `domingo` varchar(1) DEFAULT NULL,
  `semana` varchar(1) NOT NULL,
  PRIMARY KEY (`idhorariosprofesionales`),
  KEY `fkhidprof_idx` (`idprofesionales`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `horariosprofesionales`
--

LOCK TABLES `horariosprofesionales` WRITE;
/*!40000 ALTER TABLE `horariosprofesionales` DISABLE KEYS */;
INSERT INTO `horariosprofesionales` VALUES (1,1,'08:00','12:00','2016-01-01 00:00:00','1900-01-01 00:00:00','0','0','1','1','0','0','0','0'),(2,3,'16:00','21:00','2016-01-01 00:00:00','1900-01-01 00:00:00','1','0','0','0','0','0','0','0'),(3,3,'08:00','12:00','2016-01-01 00:00:00','1900-01-01 00:00:00','0','1','1','1','1','0','0','0'),(4,3,'16:00','21:00','2016-01-01 00:00:00','1900-01-01 00:00:00','0','1','1','1','1','0','0','0'),(5,3,'09:00','12:00','2016-01-01 00:00:00','1900-01-01 00:00:00','0','0','0','0','0','1','0','0');
/*!40000 ALTER TABLE `horariosprofesionales` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `horasmanuales`
--

DROP TABLE IF EXISTS `horasmanuales`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `horasmanuales` (
  `idhorasmanuales` int(11) NOT NULL AUTO_INCREMENT,
  `idprofesionales` int(11) NOT NULL,
  `dia` datetime NOT NULL,
  `hora` varchar(5) NOT NULL,
  `estado` varchar(1) NOT NULL,
  PRIMARY KEY (`idhorasmanuales`),
  KEY `hmfkidprof_idx` (`idprofesionales`),
  CONSTRAINT `hmfkidprof` FOREIGN KEY (`idprofesionales`) REFERENCES `profesionales` (`idprofesionales`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `horasmanuales`
--

LOCK TABLES `horasmanuales` WRITE;
/*!40000 ALTER TABLE `horasmanuales` DISABLE KEYS */;
INSERT INTO `horasmanuales` VALUES (1,1,'2016-01-14 00:00:00','11:00','0'),(2,1,'2016-01-14 00:00:00','11:00','1'),(3,1,'2016-01-14 00:00:00','16:00','1');
/*!40000 ALTER TABLE `horasmanuales` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lineafactura`
--

DROP TABLE IF EXISTS `lineafactura`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `lineafactura` (
  `idlineafactura` int(11) NOT NULL AUTO_INCREMENT,
  `idproductos` int(11) NOT NULL,
  `cantidad` int(11) NOT NULL,
  `precioventa` decimal(10,2) NOT NULL,
  `idfacturacion` int(11) NOT NULL,
  `preciocalculo` decimal(10,2) NOT NULL,
  `sesiones` int(11) NOT NULL,
  PRIMARY KEY (`idlineafactura`),
  KEY `lffkidprod_idx` (`idproductos`),
  KEY `lffidfact_idx` (`idfacturacion`),
  CONSTRAINT `lffidfact` FOREIGN KEY (`idfacturacion`) REFERENCES `facturacion` (`idfacturacion`) ON UPDATE CASCADE,
  CONSTRAINT `lffkidprod` FOREIGN KEY (`idproductos`) REFERENCES `productos` (`idproductos`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=33 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lineafactura`
--

LOCK TABLES `lineafactura` WRITE;
/*!40000 ALTER TABLE `lineafactura` DISABLE KEYS */;
INSERT INTO `lineafactura` VALUES (9,1,1,15.00,8,0.00,0),(10,2,2,100.00,8,75.00,10),(11,2,1,100.00,9,75.00,10),(12,1,1,15.00,10,0.00,0),(13,2,1,100.00,10,75.00,10),(14,2,1,100.00,11,75.00,10),(15,1,2,15.00,11,0.00,0),(16,2,2,100.00,12,75.00,10),(17,2,3,100.00,13,75.00,10),(18,3,1,100.00,14,10.00,3),(19,1,1,15.00,15,0.00,0),(20,1,3,15.00,16,0.00,0),(21,1,5,15.00,17,0.00,0),(22,1,1,15.00,18,0.00,0),(23,2,1,100.00,21,75.00,10),(24,2,1,100.00,22,75.00,10),(25,1,4,15.00,23,0.00,0),(26,1,1,15.00,24,0.00,0),(27,1,1,15.00,25,0.00,0),(28,2,3,100.00,25,0.00,0),(29,2,10,100.00,26,75.00,10);
/*!40000 ALTER TABLE `lineafactura` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `liquidaciondiaria`
--

DROP TABLE IF EXISTS `liquidaciondiaria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `liquidaciondiaria` (
  `idliquidaciondiaria` int(11) NOT NULL AUTO_INCREMENT,
  `idprofesionales` int(11) NOT NULL,
  `fecha` datetime NOT NULL,
  `importe` decimal(10,2) NOT NULL,
  PRIMARY KEY (`idliquidaciondiaria`),
  KEY `lfkprofesionaless_idx` (`idprofesionales`),
  CONSTRAINT `lfkprofesionaless` FOREIGN KEY (`idprofesionales`) REFERENCES `profesionales` (`idprofesionales`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `liquidaciondiaria`
--

LOCK TABLES `liquidaciondiaria` WRITE;
/*!40000 ALTER TABLE `liquidaciondiaria` DISABLE KEYS */;
INSERT INTO `liquidaciondiaria` VALUES (1,3,'2016-01-27 00:00:00',38.33);
/*!40000 ALTER TABLE `liquidaciondiaria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `movcajas`
--

DROP TABLE IF EXISTS `movcajas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `movcajas` (
  `idmovcajas` int(11) NOT NULL AUTO_INCREMENT,
  `idtipomovcajas` int(11) NOT NULL,
  `detalle` varchar(105) DEFAULT NULL,
  `importe` decimal(10,2) NOT NULL,
  `fecha` datetime NOT NULL,
  `tipo` varchar(45) NOT NULL,
  PRIMARY KEY (`idmovcajas`),
  KEY `mfktipo_idx` (`idtipomovcajas`),
  CONSTRAINT `mfktipo` FOREIGN KEY (`idtipomovcajas`) REFERENCES `tipomovcajas` (`idtipomovcajas`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `movcajas`
--

LOCK TABLES `movcajas` WRITE;
/*!40000 ALTER TABLE `movcajas` DISABLE KEYS */;
INSERT INTO `movcajas` VALUES (1,1,'asd',10.00,'2016-02-05 00:00:00','INGRESO'),(2,1,'proabndog',15.50,'2016-02-05 00:00:00','INGRESO'),(3,1,'proabndog',15.50,'2016-02-05 00:00:00','INGRESO'),(4,1,'proabndog',15.50,'2016-02-05 00:00:00','INGRESO'),(5,1,'proabndog',15.50,'2016-02-05 00:00:00','INGRESO'),(6,1,'proabndog',15.50,'2016-02-05 00:00:00','INGRESO'),(7,1,'proabndog',15.50,'2016-02-05 00:00:00','INGRESO'),(8,1,'proabndog',15.50,'2016-02-05 00:00:00','INGRESO'),(9,1,'proabndog',15.50,'2016-02-05 00:00:00','INGRESO'),(10,1,'asd',153.50,'2016-02-08 00:00:00','INGRESO'),(11,1,'asd',25.00,'2016-02-08 00:00:00','EGRESO'),(12,3,'prueba',155.00,'2016-02-07 00:00:00','INGRESO'),(13,1,'coca',15.00,'2016-02-29 00:00:00','INGRESO');
/*!40000 ALTER TABLE `movcajas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `movproductos`
--

DROP TABLE IF EXISTS `movproductos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `movproductos` (
  `idmovproductos` int(11) NOT NULL AUTO_INCREMENT,
  `tipomov` varchar(45) NOT NULL,
  `idproductos` int(11) NOT NULL,
  `producto` varchar(45) NOT NULL,
  `cantidad` int(11) NOT NULL,
  `detalle` varchar(150) NOT NULL,
  `responsable` varchar(45) NOT NULL,
  `consignacion` varchar(1) NOT NULL DEFAULT '0',
  `fecha` datetime NOT NULL,
  PRIMARY KEY (`idmovproductos`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `movproductos`
--

LOCK TABLES `movproductos` WRITE;
/*!40000 ALTER TABLE `movproductos` DISABLE KEYS */;
INSERT INTO `movproductos` VALUES (1,'INGRESO',1,'prueb eze',1,'prueba','prueba','0','2016-02-28 00:00:00'),(2,'EGRESO',1,'prueb eze',1,'prueba','prueba','0','2016-02-28 00:00:00'),(3,'INGRESO',1,'prueb eze',2,'prueba','prueba','1','2016-02-28 00:00:00'),(4,'INGRESO',1,'prueb eze',2,'probando','ezequiel','0','2016-02-28 00:00:00'),(5,'INGRESO',1,'prueb eze',10,'','','0','2016-02-29 00:00:00'),(6,'EGRESO',1,'prueb eze',10,'','','0','2016-02-29 00:00:00');
/*!40000 ALTER TABLE `movproductos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pacientes`
--

DROP TABLE IF EXISTS `pacientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pacientes` (
  `idpacientes` int(11) NOT NULL AUTO_INCREMENT,
  `paciente` varchar(100) NOT NULL,
  `telefono` varchar(45) NOT NULL,
  `domicilio` varchar(80) NOT NULL,
  `mail` varchar(100) NOT NULL,
  `documento` varchar(45) NOT NULL,
  `idtipodoc` int(11) NOT NULL,
  `celular` varchar(45) NOT NULL,
  `activo` int(11) NOT NULL DEFAULT '1',
  `comentarios` varchar(250) NOT NULL,
  `foto` varchar(150) NOT NULL,
  PRIMARY KEY (`idpacientes`),
  UNIQUE KEY `documento_UNIQUE` (`documento`),
  KEY `fktipodoc_idx` (`idtipodoc`),
  KEY `fktipodocpac_idx` (`idtipodoc`),
  CONSTRAINT `fktipodocpac` FOREIGN KEY (`idtipodoc`) REFERENCES `tipodoc` (`idtipodoc`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pacientes`
--

LOCK TABLES `pacientes` WRITE;
/*!40000 ALTER TABLE `pacientes` DISABLE KEYS */;
INSERT INTO `pacientes` VALUES (1,'EZEQUIEL VAZQUEZ','','asd','','231',1,'',1,'','C:\\Users\\Ezequiel\\Documents\\eze 231.png'),(2,'fernando','123','sda','','123',1,'',1,'','');
/*!40000 ALTER TABLE `pacientes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productos`
--

DROP TABLE IF EXISTS `productos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `productos` (
  `idproductos` int(11) NOT NULL AUTO_INCREMENT,
  `detalle` varchar(100) NOT NULL,
  `precioventa` decimal(10,2) NOT NULL,
  `sesiones` int(11) NOT NULL DEFAULT '0',
  `stock` int(11) NOT NULL DEFAULT '0',
  `activo` int(11) NOT NULL,
  `preciocalculo` decimal(10,2) NOT NULL,
  PRIMARY KEY (`idproductos`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productos`
--

LOCK TABLES `productos` WRITE;
/*!40000 ALTER TABLE `productos` DISABLE KEYS */;
INSERT INTO `productos` VALUES (1,'prueb eze',15.00,0,-82,1,-10.00),(2,'masaje',100.00,10,0,1,75.00),(3,'masaje ultra super masajeante 1',100.00,3,0,1,10.00);
/*!40000 ALTER TABLE `productos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `profesionales`
--

DROP TABLE IF EXISTS `profesionales`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `profesionales` (
  `idprofesionales` int(11) NOT NULL AUTO_INCREMENT,
  `profesional` varchar(100) NOT NULL,
  `documento` varchar(45) NOT NULL,
  `idtipodoc` int(11) NOT NULL,
  `domicilio` varchar(80) DEFAULT NULL,
  `telefono` varchar(45) DEFAULT NULL,
  `activo` int(11) NOT NULL,
  `mail` varchar(80) DEFAULT NULL,
  `gabinete` varchar(2) DEFAULT '0',
  `sinturnero` varchar(1) DEFAULT '0',
  `idespecialidades` int(11) DEFAULT '1',
  PRIMARY KEY (`idprofesionales`),
  UNIQUE KEY `documento_UNIQUE` (`documento`),
  KEY `fktipodoc_idx` (`idtipodoc`),
  CONSTRAINT `fktipodoc` FOREIGN KEY (`idtipodoc`) REFERENCES `tipodoc` (`idtipodoc`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `profesionales`
--

LOCK TABLES `profesionales` WRITE;
/*!40000 ALTER TABLE `profesionales` DISABLE KEYS */;
INSERT INTO `profesionales` VALUES (1,'DOSSO KARINA','',1,'','',1,'','0','0',1),(3,'PARADA YESICA','24539113',1,'','',1,'','1','1',5);
/*!40000 ALTER TABLE `profesionales` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rubros`
--

DROP TABLE IF EXISTS `rubros`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `rubros` (
  `idrubros` int(11) NOT NULL AUTO_INCREMENT,
  `detalle` varchar(80) NOT NULL,
  PRIMARY KEY (`idrubros`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rubros`
--

LOCK TABLES `rubros` WRITE;
/*!40000 ALTER TABLE `rubros` DISABLE KEYS */;
INSERT INTO `rubros` VALUES (1,'prueba');
/*!40000 ALTER TABLE `rubros` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `seguimientos`
--

DROP TABLE IF EXISTS `seguimientos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `seguimientos` (
  `idseguimientos` int(11) NOT NULL AUTO_INCREMENT,
  `idprofesionales` int(11) NOT NULL,
  `hora` varchar(5) NOT NULL,
  `dia` datetime NOT NULL,
  `detalle` varchar(200) NOT NULL,
  `idturnos` int(11) DEFAULT NULL,
  `fechareal` datetime NOT NULL,
  `idusuarios` int(11) DEFAULT NULL,
  PRIMARY KEY (`idseguimientos`),
  KEY `sfkidprof_idx` (`idprofesionales`),
  KEY `sfkidturnos_idx` (`idturnos`)
) ENGINE=InnoDB AUTO_INCREMENT=147 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `seguimientos`
--

LOCK TABLES `seguimientos` WRITE;
/*!40000 ALTER TABLE `seguimientos` DISABLE KEYS */;
INSERT INTO `seguimientos` VALUES (1,1,'11:00','2016-01-14 00:00:00','Deshabilitacion Manual de Horario',0,'2016-01-13 16:08:08',0),(2,1,'11:00','2016-01-14 00:00:00','Habilitacion Manual de Horario',0,'2016-01-13 16:08:21',0),(3,1,'16:00','2016-01-14 00:00:00','Habilitacion Manual de Horario',0,'2016-01-13 16:08:28',0),(4,1,'11:00','2016-01-13 00:00:00','Inserta nuevo turno',0,'2016-01-13 19:25:40',0),(5,3,'12:00','2016-02-12 00:00:00','Inserta nuevo turno',0,'2016-01-15 18:16:36',0),(6,3,'12:00','2016-02-12 00:00:00','Libera turno',0,'2016-01-15 18:16:59',0),(7,3,'10:00','2016-01-15 00:00:00','Inserta nuevo turno',0,'2016-01-15 18:19:32',0),(8,3,'10:00','2016-02-26 00:00:00','Suspende turno fijo por el dia del Cliente: eze',0,'2016-01-15 18:21:56',0),(9,3,'08:00','2016-01-15 00:00:00','Inserta nuevo turno',0,'2016-01-15 18:31:18',0),(10,3,'08:00','2016-01-15 00:00:00','Libera turno del cliente: eze',0,'2016-01-15 18:31:24',0),(11,3,'08:00','2016-01-19 00:00:00','Inserta nuevo turno',0,'2016-01-19 21:32:53',0),(12,3,'09:00','2016-01-19 00:00:00','Inserta nuevo turno',0,'2016-01-19 21:49:42',0),(13,1,'10:00','2016-01-20 00:00:00','Inserta nuevo turno',0,'2016-01-20 18:13:22',0),(14,3,'11:00','2016-01-20 00:00:00','Inserta nuevo turno',0,'2016-01-20 18:51:18',0),(15,3,'18:00','2016-01-20 00:00:00','Inserta nuevo turno',0,'2016-01-20 19:27:41',0),(16,3,'19:00','2016-01-20 00:00:00','Inserta nuevo turno',0,'2016-01-20 19:48:32',0),(17,3,'17:00','2016-01-27 00:00:00','Inserta nuevo turno',0,'2016-01-20 20:15:54',0),(18,3,'09:00','2016-01-23 00:00:00','Inserta nuevo turno',0,'2016-01-23 19:21:03',0),(19,3,'10:00','2016-01-23 00:00:00','Inserta nuevo turno EZEQUIEL VAZQUEZ',0,'2016-01-23 20:47:26',0),(20,3,'10:00','2016-01-23 00:00:00','Agrego servicio: masaje',0,'2016-01-23 21:08:33',0),(21,3,'10:00','2016-01-23 00:00:00','Agrego servicio: masaje',0,'2016-01-23 21:09:32',0),(22,3,'10:00','2016-01-23 00:00:00','Elimino servicio: ',0,'2016-01-23 21:09:34',0),(23,3,'10:00','2016-01-23 00:00:00','Agrego servicio: masaje',0,'2016-01-23 21:09:52',0),(24,3,'10:00','2016-01-23 00:00:00','Agrego servicio: masaje',0,'2016-01-23 21:10:43',0),(25,3,'10:00','2016-01-23 00:00:00','Confirmo Asistencia',0,'2016-01-23 21:10:45',0),(26,3,'12:00','2016-01-30 00:00:00','Inserta nuevo turno EZEQUIEL VAZQUEZ',0,'2016-01-23 22:03:00',0),(27,3,'12:00','2016-01-23 00:00:00','Inserta nuevo turno EZEQUIEL VAZQUEZ',0,'2016-01-23 22:03:59',0),(28,3,'11:00','2016-02-06 00:00:00','Inserta nuevo turno ',0,'2016-01-23 22:04:25',0),(29,3,'18:00','2016-01-25 00:00:00','Libera turno del cliente: EZEQUIEL VAZQUEZ ',0,'2016-01-24 20:00:51',0),(30,3,'18:00','2016-01-25 00:00:00','Inserta nuevo turno EZEQUIEL VAZQUEZ',0,'2016-01-24 20:02:29',0),(31,3,'18:00','2016-01-25 00:00:00','Libera turno del cliente: EZEQUIEL VAZQUEZ 4/10',0,'2016-01-24 20:02:52',0),(32,3,'16:00','2016-01-25 00:00:00','Inserta nuevo turno EZEQUIEL VAZQUEZ',0,'2016-01-24 20:14:45',0),(33,3,'16:00','2016-01-25 00:00:00','Libera turno del cliente: EZEQUIEL VAZQUEZ 5/10',0,'2016-01-24 20:14:58',0),(34,3,'16:00','2016-01-25 00:00:00','Inserta nuevo turno EZEQUIEL VAZQUEZ',0,'2016-01-24 20:16:53',0),(35,3,'16:00','2016-01-25 00:00:00','Libera turno del cliente: EZEQUIEL VAZQUEZ ',0,'2016-01-24 20:16:57',0),(36,3,'16:00','2016-01-25 00:00:00','Inserta nuevo turno EZEQUIEL VAZQUEZ',0,'2016-01-24 20:22:17',0),(37,3,'16:00','2016-01-25 00:00:00','Suspende turno fijo por el dia del Cliente: EZEQUIEL VAZQUEZ 5/10',0,'2016-01-24 20:22:37',0),(38,3,'16:00','2016-01-25 00:00:00','Suspende turno fijo por el dia del Cliente: EZEQUIEL VAZQUEZ ',0,'2016-01-24 20:23:57',0),(39,3,'16:00','2016-02-01 00:00:00','Suspende turno fijo por el dia del Cliente: EZEQUIEL VAZQUEZ ',0,'2016-01-24 20:24:09',0),(40,3,'17:00','2016-01-25 00:00:00','Inserta nuevo turno EZEQUIEL VAZQUEZ',0,'2016-01-24 20:25:41',0),(41,3,'17:00','2016-01-25 00:00:00','Libera turno del cliente: EZEQUIEL VAZQUEZ ',0,'2016-01-24 20:25:45',0),(42,3,'17:00','2016-01-25 00:00:00','Inserta nuevo turno EZEQUIEL VAZQUEZ',0,'2016-01-24 20:25:59',0),(43,3,'17:00','2016-01-25 00:00:00','Inserta nuevo turno EZEQUIEL VAZQUEZ',0,'2016-01-24 20:26:45',0),(44,3,'19:00','2016-01-25 00:00:00','Inserta nuevo turno EZEQUIEL VAZQUEZ',0,'2016-01-24 20:26:57',0),(45,3,'17:00','2016-01-25 00:00:00','Libera turno del cliente: EZEQUIEL VAZQUEZ ',0,'2016-01-24 20:27:58',0),(46,3,'18:00','2016-01-25 00:00:00','Inserta nuevo turno EZEQUIEL VAZQUEZ',0,'2016-01-24 20:28:11',0),(47,3,'18:00','2016-01-25 00:00:00','Elimino servicio: masaje',0,'2016-01-24 20:28:21',0),(48,3,'16:00','2016-01-25 00:00:00','Inserta nuevo turno EZEQUIEL VAZQUEZ',0,'2016-01-24 20:28:59',0),(49,3,'18:00','2016-01-25 00:00:00','Inserta nuevo turno EZEQUIEL VAZQUEZ',0,'2016-01-24 20:29:42',0),(50,3,'19:00','2016-01-25 00:00:00','Inserta nuevo turno EZEQUIEL VAZQUEZ',0,'2016-01-24 20:30:18',0),(51,3,'18:00','2016-01-25 00:00:00','Suspende turno fijo por el dia del Cliente: EZEQUIEL VAZQUEZ ',0,'2016-01-24 20:37:14',0),(52,3,'17:00','2016-01-25 00:00:00','Inserta nuevo turno EZEQUIEL VAZQUEZ',0,'2016-01-24 20:38:10',0),(53,3,'17:00','2016-01-25 00:00:00','Suspende turno fijo por el dia del Cliente: EZEQUIEL VAZQUEZ ',0,'2016-01-24 20:38:16',0),(54,3,'16:00','2016-01-25 00:00:00','Inserta nuevo turno EZEQUIEL VAZQUEZ',0,'2016-01-24 20:38:57',0),(55,3,'17:00','2016-01-25 00:00:00','Inserta nuevo turno EZEQUIEL VAZQUEZ',0,'2016-01-24 20:41:45',0),(56,3,'17:00','2016-01-25 00:00:00','Suspende turno fijo por el dia del Cliente: EZEQUIEL VAZQUEZ ',0,'2016-01-24 20:41:50',0),(57,3,'17:00','2016-01-25 00:00:00','Libera Turno del Cliente: EZEQUIEL VAZQUEZ ',0,'2016-01-24 20:42:23',0),(58,3,'17:00','2016-01-25 00:00:00','Inserta nuevo turno fernando',0,'2016-01-24 20:52:40',0),(59,3,'17:00','2016-01-25 00:00:00','Agrego servicio: masaje',0,'2016-01-24 20:54:49',0),(60,3,'17:00','2016-01-25 00:00:00','Elimino servicio: masaje',0,'2016-01-24 20:55:23',0),(61,3,'16:00','2016-01-25 00:00:00','Inserta nuevo turno fernando',0,'2016-01-24 21:11:07',0),(62,3,'16:00','2016-01-25 00:00:00','Libera turno del cliente: fernando 4/10',0,'2016-01-24 21:11:12',0),(63,3,'17:00','2016-01-25 00:00:00','Agrego servicio: masaje',0,'2016-01-24 21:24:08',0),(64,3,'20:00','2016-01-25 00:00:00','Libera turno del cliente: probando ',0,'2016-01-25 20:19:22',0),(65,3,'20:00','2016-01-25 00:00:00','Libera turno del cliente: probando ',0,'2016-01-25 20:19:30',0),(66,3,'20:00','2016-01-25 00:00:00','Inserta nuevo turno ',0,'2016-01-25 20:19:44',0),(67,3,'20:00','2016-01-25 00:00:00','Libera turno del cliente: a ',0,'2016-01-25 20:19:55',0),(68,3,'20:00','2016-01-25 00:00:00','Inserta nuevo turno EZEQUIEL VAZQUEZ',0,'2016-01-25 20:20:11',0),(69,3,'20:00','2016-01-25 00:00:00','Libera turno del cliente: EZEQUIEL VAZQUEZ ',0,'2016-01-25 20:20:16',0),(70,3,'20:00','2016-01-25 00:00:00','Inserta nuevo turno EZEQUIEL VAZQUEZ',0,'2016-01-25 20:20:53',0),(71,3,'20:00','2016-01-25 00:00:00','Libera Turno del Cliente: EZEQUIEL VAZQUEZ ',0,'2016-01-25 20:21:08',0),(72,3,'16:00','2016-01-25 00:00:00','Inserta nuevo turno fernando',0,'2016-01-25 20:22:21',0),(73,3,'16:00','2016-01-25 00:00:00','Libera turno del cliente: fernando 5/10',0,'2016-01-25 20:22:42',0),(74,3,'08:00','2016-01-26 00:00:00','Inserta nuevo turno fernando',0,'2016-01-26 20:14:16',0),(75,3,'08:00','2016-01-26 00:00:00','Confirmo Asistencia',0,'2016-01-26 20:28:19',0),(76,1,'09:00','2016-01-27 00:00:00','Agrego servicio: masaje',0,'2016-01-27 19:41:56',0),(77,1,'09:00','2016-01-27 00:00:00','Confirmo Asistencia',0,'2016-01-27 19:41:59',0),(78,3,'17:00','2016-01-27 00:00:00','Agrego servicio: masaje',0,'2016-01-27 19:42:11',0),(79,3,'17:00','2016-01-27 00:00:00','Confirmo Asistencia',0,'2016-01-27 19:42:14',0),(80,3,'10:00','2016-01-27 00:00:00','Inserta nuevo turno fernando',0,'2016-01-27 19:53:32',0),(81,3,'10:00','2016-01-27 00:00:00','Confirmo Asistencia',0,'2016-01-27 19:53:36',0),(82,3,'19:00','2016-01-27 00:00:00','Inserta nuevo turno fernando',0,'2016-01-27 20:13:36',0),(83,3,'19:00','2016-01-27 00:00:00','Confirmo Asistencia',0,'2016-01-27 20:13:41',0),(84,1,'09:00','2016-02-03 00:00:00','Agrego servicio: masaje',0,'2016-02-03 19:37:37',0),(85,1,'09:00','2016-02-03 00:00:00','Elimino servicio: masaje Regalo de: EZEQUIEL VAZQUEZ',0,'2016-02-03 19:38:32',0),(86,1,'09:00','2016-02-03 00:00:00','Agrego servicio: masaje',0,'2016-02-03 19:38:38',0),(87,1,'09:00','2016-02-03 00:00:00','Elimino servicio: masaje Regalo de: EZEQUIEL VAZQUEZ',0,'2016-02-03 19:39:03',0),(88,1,'09:00','2016-02-03 00:00:00','Agrego servicio: masaje',0,'2016-02-03 19:39:20',0),(89,1,'09:00','2016-02-03 00:00:00','Elimino servicio: masaje Regalo de: EZEQUIEL VAZQUEZ',0,'2016-02-03 19:39:28',0),(90,1,'09:00','2016-02-03 00:00:00','Agrego servicio: masaje',0,'2016-02-03 19:40:38',0),(91,1,'09:00','2016-02-03 00:00:00','Elimino servicio: masaje',0,'2016-02-03 19:47:11',0),(92,1,'09:00','2016-02-03 00:00:00','Agrego servicio: masaje',0,'2016-02-03 19:47:21',0),(93,1,'09:00','2016-02-03 00:00:00','Libera Turno del Cliente: EZEQUIEL VAZQUEZ 3/30',0,'2016-02-03 19:51:28',0),(94,1,'09:00','2016-02-04 00:00:00','Inserta nuevo turno EZEQUIEL VAZQUEZ',0,'2016-02-04 20:03:54',0),(95,1,'11:00','2016-02-04 00:00:00','Inserta nuevo turno fernando',0,'2016-02-04 20:10:52',0),(96,1,'11:00','2016-02-04 00:00:00','Liberacion de inasistencia y reasignacion de sesiones',0,'2016-02-05 20:11:23',0),(97,3,'09:00','2016-02-17 00:00:00','Inserta nuevo turno EZEQUIEL VAZQUEZ',0,'2016-02-17 17:50:42',0),(98,3,'09:00','2016-02-17 00:00:00','Agrego servicio: masaje',0,'2016-02-17 18:02:43',0),(99,3,'16:00','2016-02-22 00:00:00','Inserta nuevo turno EZEQUIEL VAZQUEZ',0,'2016-02-22 18:31:01',0),(100,3,'16:00','2016-02-29 00:00:00','Libera Turno del Cliente: EZEQUIEL VAZQUEZ ',0,'2016-02-22 18:31:10',0),(101,3,'16:00','2016-02-22 00:00:00','Inserta nuevo turno EZEQUIEL VAZQUEZ',0,'2016-02-22 18:31:22',0),(102,3,'16:00','2016-02-29 00:00:00','Libera Turno del Cliente: EZEQUIEL VAZQUEZ ',0,'2016-02-23 18:33:23',0),(103,3,'10:00','2016-02-23 00:00:00','Inserta nuevo turno EZEQUIEL VAZQUEZ',0,'2016-02-23 18:48:11',0),(104,3,'10:00','2016-03-01 00:00:00','Suspende turno fijo por el dia del Cliente: EZEQUIEL VAZQUEZ ',0,'2016-02-23 18:53:54',0),(105,3,'10:00','2016-03-08 00:00:00','Agrego servicio: masaje',0,'2016-02-23 19:09:48',0),(106,3,'10:00','2016-03-08 00:00:00','Suspende turno fijo por el dia del Cliente: EZEQUIEL VAZQUEZ 1/10',0,'2016-02-23 19:09:53',0),(107,3,'10:00','2016-03-15 00:00:00','Agrego servicio: masaje',0,'2016-02-23 19:10:07',0),(108,3,'10:00','2016-02-23 00:00:00','Libera Turno del Cliente: EZEQUIEL VAZQUEZ ',0,'2016-02-23 19:10:15',0),(109,3,'10:00','2016-02-23 00:00:00','Inserta nuevo turno fernando',0,'2016-02-23 19:43:13',0),(110,3,'10:00','2016-03-15 00:00:00','Agrego servicio: masaje',0,'2016-02-23 19:43:40',0),(111,3,'10:00','2016-02-23 00:00:00','Elimino servicio: masaje',0,'2016-02-23 19:43:50',0),(112,3,'10:00','2016-02-23 00:00:00','Libera Turno del Cliente: fernando ',0,'2016-02-23 19:44:13',0),(113,3,'11:00','2016-02-23 00:00:00','Inserta nuevo turno fernando',0,'2016-02-23 19:57:36',0),(114,3,'11:00','2016-02-23 00:00:00','Libera turno del cliente: fernando 3/10',0,'2016-02-23 19:57:42',0),(115,3,'11:00','2016-02-23 00:00:00','Inserta nuevo turno fernando',0,'2016-02-23 19:57:50',0),(116,3,'11:00','2016-02-23 00:00:00','Libera turno del cliente: fernando 3/10',0,'2016-02-23 19:57:54',0),(117,3,'11:00','2016-02-23 00:00:00','Inserta nuevo turno fernando',0,'2016-02-23 20:02:39',0),(118,3,'11:00','2016-04-05 00:00:00','Agrego servicio: masaje',0,'2016-02-23 20:02:50',0),(119,3,'11:00','2016-02-23 00:00:00','Libera Turno del Cliente: fernando 3/10',0,'2016-02-23 20:03:06',0),(120,3,'11:00','2016-02-23 00:00:00','Inserta nuevo turno fernando',0,'2016-02-23 20:08:18',0),(121,3,'11:00','2016-02-23 00:00:00','Libera turno del cliente: fernando 4/10',0,'2016-02-23 20:08:24',0),(122,3,'11:00','2016-02-23 00:00:00','Inserta nuevo turno fernando',0,'2016-02-23 20:08:35',0),(123,3,'11:00','2016-03-01 00:00:00','Agrego servicio: masaje',0,'2016-02-23 20:08:41',0),(124,3,'11:00','2016-02-23 00:00:00','Libera Turno del Cliente: fernando 4/10',0,'2016-02-23 20:08:53',0),(125,3,'11:00','2016-02-23 00:00:00','Inserta nuevo turno fernando',0,'2016-02-23 20:09:35',0),(126,3,'11:00','2016-03-01 00:00:00','Elimino servicio: masaje',0,'2016-02-23 20:09:56',0),(127,3,'11:00','2016-03-01 00:00:00','Agrego servicio: masaje',0,'2016-02-23 20:10:11',0),(128,3,'11:00','2016-02-23 00:00:00','Libera Turno del Cliente: fernando 5/10',0,'2016-02-23 20:24:05',0),(129,3,'09:00','2016-02-23 00:00:00','Inserta nuevo turno fernando',0,'2016-02-23 19:12:35',0),(130,3,'09:00','2016-03-01 00:00:00','Suspende turno fijo por el dia del Cliente: fernando ',0,'2016-02-23 19:12:40',0),(131,3,'09:00','2016-03-08 00:00:00','Agrego servicio: masaje',0,'2016-02-23 20:23:00',0),(132,3,'09:00','2016-03-08 00:00:00','Libera Turno del Cliente: fernando 2/10',0,'2016-02-23 20:23:21',0),(133,3,'09:00','2016-02-23 00:00:00','Inserta nuevo turno fernando',0,'2016-02-23 20:24:03',0),(134,3,'09:00','2016-02-23 00:00:00','Libera turno del cliente: fernando ',0,'2016-02-23 20:24:08',0),(135,3,'09:00','2016-02-23 00:00:00','Inserta nuevo turno fernando',0,'2016-02-23 20:24:15',0),(136,3,'09:00','2016-03-08 00:00:00','Agrego servicio: masaje',0,'2016-02-23 20:33:01',0),(137,1,'09:00','2016-02-25 00:00:00','Inserta nuevo turno EZEQUIEL VAZQUEZ',0,'2016-02-25 18:05:15',0),(138,1,'09:00','2016-02-25 00:00:00','Agrego servicio: masaje',0,'2016-02-25 18:10:15',0),(139,1,'09:00','2016-02-25 00:00:00','Elimino servicio: masaje',0,'2016-02-25 18:10:46',0),(140,1,'09:00','2016-02-25 00:00:00','Agrego servicio: masaje',0,'2016-02-25 18:10:56',0),(141,1,'09:00','2016-02-25 00:00:00','Elimino servicio: masaje',0,'2016-02-25 18:11:08',0),(142,1,'09:00','2016-02-25 00:00:00','Agrego servicio: masaje',0,'2016-02-25 18:11:13',0),(143,1,'09:00','2016-02-25 00:00:00','Confirmo Asistencia',0,'2016-02-25 18:11:26',0),(144,3,'16:00','2016-02-29 00:00:00','Inserta nuevo turno EZEQUIEL VAZQUEZ',0,'2016-02-29 21:54:38',0),(145,3,'16:00','2016-03-07 00:00:00','Agrego servicio: masaje',0,'2016-02-29 21:55:17',0),(146,3,'16:00','2016-03-07 00:00:00','Suspende turno fijo por el dia del Cliente: EZEQUIEL VAZQUEZ 5/10',0,'2016-02-29 21:55:46',0);
/*!40000 ALTER TABLE `seguimientos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `servicios`
--

DROP TABLE IF EXISTS `servicios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `servicios` (
  `idservicios` int(11) NOT NULL AUTO_INCREMENT,
  `idproductos` int(11) NOT NULL,
  `detalle` varchar(100) NOT NULL,
  `sesiones` int(11) NOT NULL,
  `usadas` int(11) NOT NULL,
  `idlineafactura` int(11) NOT NULL,
  `idpacientes` int(11) NOT NULL,
  `fecha` datetime NOT NULL,
  PRIMARY KEY (`idservicios`),
  KEY `sfkidprod_idx` (`idproductos`),
  KEY `sfkidfact_idx` (`idlineafactura`),
  KEY `sfkidpac_idx` (`idpacientes`),
  CONSTRAINT `sfkidlineaf` FOREIGN KEY (`idlineafactura`) REFERENCES `lineafactura` (`idlineafactura`) ON UPDATE CASCADE,
  CONSTRAINT `sfkidpac` FOREIGN KEY (`idpacientes`) REFERENCES `pacientes` (`idpacientes`) ON UPDATE CASCADE,
  CONSTRAINT `sfkidprod` FOREIGN KEY (`idproductos`) REFERENCES `productos` (`idproductos`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `servicios`
--

LOCK TABLES `servicios` WRITE;
/*!40000 ALTER TABLE `servicios` DISABLE KEYS */;
INSERT INTO `servicios` VALUES (5,2,'masaje',10,1,14,1,'2016-01-26 20:05:59'),(6,2,'masaje',10,2,16,1,'2016-01-26 20:07:31'),(7,2,'masaje',30,2,17,2,'2016-01-26 20:11:26'),(8,3,'masaje 1 ultra super masajeante',3,1,18,2,'2016-01-27 20:13:23'),(9,2,'masaje',10,4,23,2,'2016-02-17 17:51:50'),(10,2,'masaje',10,2,24,2,'2016-02-17 18:02:10'),(11,2,'masaje',100,1,29,1,'2016-02-25 18:04:11');
/*!40000 ALTER TABLE `servicios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `serviciosturnos`
--

DROP TABLE IF EXISTS `serviciosturnos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `serviciosturnos` (
  `idserviciosturnos` int(11) NOT NULL AUTO_INCREMENT,
  `idprofesionales` int(11) NOT NULL,
  `idservicios` int(11) NOT NULL,
  `fecha` datetime NOT NULL,
  `hora` varchar(5) NOT NULL,
  `idpacientes` int(11) NOT NULL,
  `asistencia` varchar(1) NOT NULL DEFAULT '0',
  `estado` varchar(1) NOT NULL DEFAULT '0',
  `sesion` varchar(5) NOT NULL,
  PRIMARY KEY (`idserviciosturnos`),
  KEY `stfkprof_idx` (`idprofesionales`),
  KEY `stfkserv_idx` (`idservicios`),
  KEY `stfkpac_idx` (`idpacientes`),
  CONSTRAINT `stfkpac` FOREIGN KEY (`idpacientes`) REFERENCES `pacientes` (`idpacientes`) ON DELETE CASCADE,
  CONSTRAINT `stfkprof` FOREIGN KEY (`idprofesionales`) REFERENCES `profesionales` (`idprofesionales`) ON UPDATE CASCADE,
  CONSTRAINT `stfkserv` FOREIGN KEY (`idservicios`) REFERENCES `servicios` (`idservicios`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=58 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `serviciosturnos`
--

LOCK TABLES `serviciosturnos` WRITE;
/*!40000 ALTER TABLE `serviciosturnos` DISABLE KEYS */;
INSERT INTO `serviciosturnos` VALUES (26,3,7,'2016-01-26 00:00:00','08:00',2,'1','0','1/30'),(27,1,5,'2016-01-27 00:00:00','09:00',1,'1','0','1/10'),(28,3,6,'2016-01-27 00:00:00','17:00',1,'1','0','1/10'),(29,3,7,'2016-01-27 00:00:00','10:00',2,'1','0','2/30'),(30,3,8,'2016-01-27 00:00:00','19:00',2,'1','0','1/3'),(36,1,6,'2016-02-04 00:00:00','09:00',1,'0','1','2/10'),(37,1,7,'2016-02-04 00:00:00','11:00',2,'0','1','3/30'),(38,3,10,'2016-02-17 00:00:00','09:00',1,'0','0','1/10'),(40,3,9,'2016-03-15 00:00:00','10:00',1,'0','0','1/10'),(42,3,9,'2016-03-15 00:00:00','10:00',2,'0','0','3/10'),(46,3,9,'2016-04-05 00:00:00','11:00',2,'0','0','4/10'),(51,3,9,'2016-03-01 00:00:00','11:00',2,'0','0','5/10'),(53,3,10,'2016-03-08 00:00:00','09:00',2,'0','0','2/10'),(56,1,11,'2016-02-25 00:00:00','09:00',1,'1','0','1/100');
/*!40000 ALTER TABLE `serviciosturnos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `subrubros`
--

DROP TABLE IF EXISTS `subrubros`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `subrubros` (
  `idsubrubros` int(11) NOT NULL AUTO_INCREMENT,
  `detalle` varchar(80) NOT NULL,
  `idrubros` int(11) NOT NULL,
  PRIMARY KEY (`idsubrubros`),
  KEY `fkrubros_idx` (`idrubros`),
  CONSTRAINT `fkrubros` FOREIGN KEY (`idrubros`) REFERENCES `rubros` (`idrubros`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `subrubros`
--

LOCK TABLES `subrubros` WRITE;
/*!40000 ALTER TABLE `subrubros` DISABLE KEYS */;
INSERT INTO `subrubros` VALUES (1,'probando',1);
/*!40000 ALTER TABLE `subrubros` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `subrubrosprofesionales`
--

DROP TABLE IF EXISTS `subrubrosprofesionales`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `subrubrosprofesionales` (
  `idsubrubrosprofesionales` int(11) NOT NULL AUTO_INCREMENT,
  `idsubrubros` int(11) NOT NULL,
  `idprofesionales` int(11) NOT NULL,
  PRIMARY KEY (`idsubrubrosprofesionales`),
  KEY `fkspsubrubro_idx` (`idsubrubros`),
  KEY `fkspprofesionales_idx` (`idprofesionales`),
  CONSTRAINT `fkspprofesionales` FOREIGN KEY (`idprofesionales`) REFERENCES `profesionales` (`idprofesionales`) ON UPDATE CASCADE,
  CONSTRAINT `fkspsubrubro` FOREIGN KEY (`idsubrubros`) REFERENCES `subrubros` (`idsubrubros`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `subrubrosprofesionales`
--

LOCK TABLES `subrubrosprofesionales` WRITE;
/*!40000 ALTER TABLE `subrubrosprofesionales` DISABLE KEYS */;
/*!40000 ALTER TABLE `subrubrosprofesionales` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tarjetas`
--

DROP TABLE IF EXISTS `tarjetas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tarjetas` (
  `idtarjetas` int(11) NOT NULL AUTO_INCREMENT,
  `tarjeta` varchar(50) NOT NULL,
  PRIMARY KEY (`idtarjetas`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tarjetas`
--

LOCK TABLES `tarjetas` WRITE;
/*!40000 ALTER TABLE `tarjetas` DISABLE KEYS */;
INSERT INTO `tarjetas` VALUES (1,'AMERICAN EXPRESS'),(2,'VISA'),(3,'MASTER CARD'),(4,'NARANJA'),(5,'CABAL'),(6,'FAVACARD'),(7,'NATIVA'),(8,'ARGENTA');
/*!40000 ALTER TABLE `tarjetas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipodoc`
--

DROP TABLE IF EXISTS `tipodoc`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tipodoc` (
  `idtipodoc` int(11) NOT NULL AUTO_INCREMENT,
  `detalle` varchar(45) NOT NULL,
  PRIMARY KEY (`idtipodoc`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipodoc`
--

LOCK TABLES `tipodoc` WRITE;
/*!40000 ALTER TABLE `tipodoc` DISABLE KEYS */;
INSERT INTO `tipodoc` VALUES (1,'DNI'),(2,'LE'),(3,'CI'),(4,'PASAPORTE'),(5,'LC'),(6,'OTROS');
/*!40000 ALTER TABLE `tipodoc` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipoformaspago`
--

DROP TABLE IF EXISTS `tipoformaspago`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tipoformaspago` (
  `idtipoformaspago` int(11) NOT NULL AUTO_INCREMENT,
  `tipo` varchar(50) NOT NULL,
  PRIMARY KEY (`idtipoformaspago`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipoformaspago`
--

LOCK TABLES `tipoformaspago` WRITE;
/*!40000 ALTER TABLE `tipoformaspago` DISABLE KEYS */;
INSERT INTO `tipoformaspago` VALUES (1,'EFECTIVO'),(2,'TARJETA DE CREDITO'),(3,'TARJETA DE DEBITO'),(4,'CUENTA CORRIENTE');
/*!40000 ALTER TABLE `tipoformaspago` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipomovcajas`
--

DROP TABLE IF EXISTS `tipomovcajas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tipomovcajas` (
  `idtipomovcajas` int(11) NOT NULL AUTO_INCREMENT,
  `detalle` varchar(50) NOT NULL,
  PRIMARY KEY (`idtipomovcajas`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipomovcajas`
--

LOCK TABLES `tipomovcajas` WRITE;
/*!40000 ALTER TABLE `tipomovcajas` DISABLE KEYS */;
INSERT INTO `tipomovcajas` VALUES (1,'ANTICIPO DE SUELDO'),(2,'LIBRERIA'),(3,'LIMPIEZA'),(4,'ART VARIOS');
/*!40000 ALTER TABLE `tipomovcajas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `turnos`
--

DROP TABLE IF EXISTS `turnos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `turnos` (
  `idturnos` int(11) NOT NULL AUTO_INCREMENT,
  `idprofesionales` int(11) DEFAULT NULL,
  `hora` varchar(5) DEFAULT NULL,
  `fecha` datetime DEFAULT NULL,
  `idpacientes` varchar(5) DEFAULT NULL,
  `detalle` varchar(100) NOT NULL,
  `fijo` varchar(1) DEFAULT NULL,
  `semana` varchar(1) DEFAULT NULL,
  `dia` varchar(1) DEFAULT NULL,
  `telefono` varchar(45) DEFAULT NULL,
  `finturnofijo` datetime DEFAULT '1900-01-01 00:00:00',
  PRIMARY KEY (`idturnos`),
  KEY `tfkidprofesional_idx` (`idprofesionales`),
  CONSTRAINT `tfkidprofesional` FOREIGN KEY (`idprofesionales`) REFERENCES `profesionales` (`idprofesionales`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=59 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `turnos`
--

LOCK TABLES `turnos` WRITE;
/*!40000 ALTER TABLE `turnos` DISABLE KEYS */;
INSERT INTO `turnos` VALUES (1,1,'11:00','2016-01-13 00:00:00','','Micaela','','0','3','lala','1900-01-01 00:00:00'),(3,3,'10:00','2016-01-15 00:00:00','1','','s','0','5','848','1900-01-01 00:00:00'),(4,3,'11:00','2016-01-19 00:00:00','','jkxzc','','0','2','','1900-01-01 00:00:00'),(6,3,'08:00','2016-01-19 00:00:00','1','','','0','2','','1900-01-01 00:00:00'),(7,3,'09:00','2016-01-19 00:00:00','1','','','0','2','','1900-01-01 00:00:00'),(9,1,'10:00','2016-01-20 00:00:00','1','','s','0','3','','2016-03-16 00:00:00'),(10,3,'11:00','2016-01-20 00:00:00','1','asd','','0','3','321','1900-01-01 00:00:00'),(11,3,'18:00','2016-01-20 00:00:00','1','','','0','3','','1900-01-01 00:00:00'),(12,3,'19:00','2016-01-20 00:00:00','1','','','0','3','','1900-01-01 00:00:00'),(13,3,'17:00','2016-01-27 00:00:00','1','','','0','3','','1900-01-01 00:00:00'),(14,3,'09:00','2016-01-23 00:00:00','1','','s','0','6','','1900-01-01 00:00:00'),(15,3,'10:00','2016-01-23 00:00:00','1','','','0','6','','1900-01-01 00:00:00'),(16,3,'12:00','2016-01-30 00:00:00','1','','','0','6','','1900-01-01 00:00:00'),(17,3,'12:00','2016-01-23 00:00:00','1','','q','2','6','','1900-01-01 00:00:00'),(18,3,'11:00','2016-02-06 00:00:00','','j','','0','6','','1900-01-01 00:00:00'),(33,3,'19:00','2016-01-25 00:00:00','1','','','0','1','','1900-01-01 00:00:00'),(37,3,'17:00','2016-01-25 00:00:00','2','','','0','1','','1900-01-01 00:00:00'),(38,3,'08:00','2016-01-26 00:00:00','2','','','0','2','','1900-01-01 00:00:00'),(39,3,'10:00','2016-01-27 00:00:00','2','','','0','3','','1900-01-01 00:00:00'),(40,3,'19:00','2016-01-27 00:00:00','2','','','0','3','','1900-01-01 00:00:00'),(41,1,'09:00','2016-02-04 00:00:00','1','','','0','4','','1900-01-01 00:00:00'),(42,1,'11:00','2016-02-04 00:00:00','2','','','0','4','','1900-01-01 00:00:00'),(43,3,'09:00','2016-02-17 00:00:00','1','','','0','3','','1900-01-01 00:00:00'),(56,3,'09:00','2016-02-23 00:00:00','2','','s','0','2','','1900-01-01 00:00:00'),(57,1,'09:00','2016-02-25 00:00:00','1','','','0','4','','1900-01-01 00:00:00'),(58,3,'16:00','2016-02-29 00:00:00','1','','s','0','1','','1900-01-01 00:00:00');
/*!40000 ALTER TABLE `turnos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `turnossalon`
--

DROP TABLE IF EXISTS `turnossalon`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `turnossalon` (
  `idturnossalon` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) NOT NULL,
  `telefono` varchar(45) DEFAULT NULL,
  `celular` varchar(45) DEFAULT NULL,
  `fecha` datetime NOT NULL,
  `ingreso` varchar(5) NOT NULL,
  `cantidad` int(11) NOT NULL,
  `dia` varchar(1) NOT NULL,
  `egreso` varchar(5) NOT NULL,
  `pago` varchar(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`idturnossalon`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `turnossalon`
--

LOCK TABLES `turnossalon` WRITE;
/*!40000 ALTER TABLE `turnossalon` DISABLE KEYS */;
INSERT INTO `turnossalon` VALUES (7,'asd','asd','123','2016-02-29 00:00:00','09:00',1,'1','10:00','1'),(8,'asdeze','231','321','2016-03-06 00:00:00','14:00',1,'7','15:00','0');
/*!40000 ALTER TABLE `turnossalon` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `turnosuspendidos`
--

DROP TABLE IF EXISTS `turnosuspendidos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `turnosuspendidos` (
  `idturnosuspendidos` int(11) NOT NULL AUTO_INCREMENT,
  `idprofesionales` int(11) NOT NULL,
  `dia` datetime NOT NULL,
  `hora` varchar(5) NOT NULL,
  PRIMARY KEY (`idturnosuspendidos`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `turnosuspendidos`
--

LOCK TABLES `turnosuspendidos` WRITE;
/*!40000 ALTER TABLE `turnosuspendidos` DISABLE KEYS */;
INSERT INTO `turnosuspendidos` VALUES (1,3,'2016-01-29 00:00:00','10:00'),(2,3,'2016-01-22 00:00:00','10:00'),(3,3,'2016-02-05 00:00:00','10:00'),(4,3,'2016-02-26 00:00:00','10:00'),(5,3,'2016-01-25 00:00:00','16:00'),(6,3,'2016-01-25 00:00:00','16:00'),(7,3,'2016-02-01 00:00:00','16:00'),(8,3,'2016-01-25 00:00:00','18:00'),(9,3,'2016-01-25 00:00:00','17:00'),(10,3,'2016-01-25 00:00:00','17:00'),(11,3,'2016-03-01 00:00:00','10:00'),(12,3,'2016-03-08 00:00:00','10:00'),(13,3,'2016-03-01 00:00:00','09:00'),(14,3,'2016-03-07 00:00:00','16:00');
/*!40000 ALTER TABLE `turnosuspendidos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'centroestetica'
--

--
-- Dumping routines for database 'centroestetica'
--
/*!50003 DROP FUNCTION IF EXISTS `fn_prohoramanual` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50020 DEFINER=`root`@`localhost`*/ /*!50003 FUNCTION `fn_prohoramanual`(idpro int, fec datetime) RETURNS varchar(100) CHARSET latin1
BEGIN
-- --------------------------------------------------------------------------------

declare b varchar(700) default '';
declare a varchar(700) default '';
declare hor varchar(20) default '';
declare est varchar(1) default '';
DECLARE l_last_row INT DEFAULT 0;

declare cant int default 0;

declare cursor1 cursor for select he.hora,he.estado
from  horasmanuales he 
where he.idprofesionales=idpro and  he.dia=fec
order by he.idhorasmanuales,he.hora;
DECLARE CONTINUE HANDLER FOR NOT FOUND SET l_last_row=1;
open cursor1;
REPEAT
    FETCH cursor1 INTO hor, est;
    IF not l_last_row THEN
if cant =0 then
				set b = "",
				cant = cant + 1;
else
				set b = concat(b,";"),
				cant = cant + 1;
end if;
			set b = concat(b,hor,est,'0000');


    END IF;   
UNTIL l_last_row END REPEAT;
close cursor1;
if cant=0 then
	set a=b;
else
	set a=concat(b,cant);
end if;
RETURN a;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `fn_protrabaja` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50020 DEFINER=`root`@`localhost`*/ /*!50003 FUNCTION `fn_protrabaja`(idpro int, fec datetime) RETURNS varchar(100) CHARSET latin1
BEGIN
-- --------------------------------------------------------------------------------

declare b varchar(700) default '';
declare a varchar(700) default '';
declare dia varchar(700) default dayname(fec);
declare sem int default 0;
declare hor int default 0;
declare lun int default 0;
declare mar int default 0;
declare mie int default 0;
declare jue int default 0;
declare vie int default 0;
declare sab int default 0;
declare dom int default 0;
declare par int default 0;
declare in1 varchar(5) default '';
declare eg1 varchar(5) default '';

DECLARE l_last_row INT DEFAULT 0;
declare cant int default 0;

declare cursor1 cursor for select he.semana, lunes,martes,miercoles,
jueves,viernes,sabado,domingo, case when mod(week(fec,0),2) = 0 then 1 else 2 end as par, ingreso, egreso
from  horariosprofesionales he 
where he.idprofesionales=idpro and  he.desde<=fec and he.hasta>=fec or
(he.idprofesionales=idpro and he.desde<=fec and year(he.hasta)=1900)
order by he.idhorariosprofesionales desc ;
DECLARE CONTINUE HANDLER FOR NOT FOUND SET l_last_row=1;
open cursor1;
REPEAT
    FETCH cursor1 INTO sem,lun,mar,mie,jue,vie,sab,dom,par,in1,eg1;
    IF not l_last_row THEN
		SET lc_time_names = 'es_MX';
		SET DIA = DAYNAME(FEC);
if cant =0 then
				set b = "",
				cant = cant + 1;
else
	if mid(b,length(b),1)<>";" then
				set b = concat(b,";");
	end if;
			set cant = cant + 1;
	
end if;
	if sem=0 or sem=par then


		if lun=1 and upper(dia) = "LUNES"  then
			set b = concat(b,in1,eg1);
		ELSEIF mar=1 AND UPPER(DIA)="MARTES"  then
			set b = concat(b,in1,eg1);
		ELSEIF mie=1 AND upper(DIA)="MIÉRCOLES" then
			set b = concat(b,in1,eg1);
		ELSEIF jue=1 AND UPPER(DIA)="JUEVES" then
			set b = concat(b,in1,eg1);
		ELSEIF vie=1 AND UPPER(DIA)="VIERNES" then
			set b = concat(b,in1,eg1);
		ELSEIF sab=1 AND UPPER(DIA)="SÁBADO" then
			set b = concat(b,in1,eg1);
		ELSEIF dom=1 AND UPPER(DIA)="DOMINGO" then
			set b = concat(b,in1,eg1);
		ELSE
	
			SET B=concat(b,""),
			cant=cant-1;

		end if;
	else
		set b=concat(b,""),
        cant = cant -1;
	end if;


    END IF;   
UNTIL l_last_row END REPEAT;
close cursor1;
if cant=0 then
	set a=b;
else
	set a=concat(b,cant);
end if;
RETURN a;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_protrabaja` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50020 DEFINER=`root`@`localhost`*/ /*!50003 PROCEDURE `sp_protrabaja`(fec date )
BEGIN
SET lc_time_names = 'es_MX';
		select p.idprofesionales, case when fec=curdate() then concat(p.profesional,' (',p.gabinete,')') else p.profesional end as profesional,
			ifnull((select fn_protrabaja(p.idprofesionales,fec)),'') as horario ,
			ifnull((select fn_prohoramanual(p.idprofesionales,fec)),'') as horasmanuales, f.detalle as feriado
		from profesionales p
		left join feriados f on f.fecha=fec
		where p.activo=1 and p.sinturnero=0
		having horario<>""
		order by p.profesional ;

END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_turnos` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50020 DEFINER=`root`@`localhost`*/ /*!50003 PROCEDURE `sp_turnos`(fec date, dias integer,sema integer)
BEGIN
select t.idturnos, t.idprofesionales, t.hora,t.fecha, ifnull(p.paciente,t.detalle) as detalle, t.fijo,t.semana, 0 as suspendido, ifnull(st.sesion,'') as sesion,ifnull(st.asistencia,0) as asistencia
from turnos t
left join pacientes p on p.idpacientes=t.idpacientes
left join serviciosturnos st on st.fecha=t.fecha and st.hora=t.hora and st.idprofesionales=t.idprofesionales and st.idpacientes=t.idpacientes
where t.fecha=fec
union
select t.idturnos, t.idprofesionales, t.hora,t.fecha, ifnull(p.paciente,t.detalle) as detalle, t.fijo,t.semana, ifnull(ts.idturnosuspendidos,0) as suspendido, ifnull(st.sesion,'') as sesion,ifnull(st.asistencia,0) as asistencia
from turnos t
left join pacientes p on p.idpacientes=t.idpacientes
left join turnosuspendidos ts on ts.idprofesionales=t.idprofesionales and ts.dia=fec and t.hora=ts.hora
left join serviciosturnos st on st.fecha=fec and st.hora=t.hora and st.idprofesionales=t.idprofesionales and st.idpacientes=t.idpacientes
where t.fijo = 's' and t.dia=dias and t.finturnofijo>=fec  and t.fecha<fec or
(t.fijo = 's' and t.dia=dias and t.finturnofijo='1900-01-01'  and t.fecha<fec) or
(t.fijo = 'q' and t.dia=dias and t.semana=sema and t.finturnofijo>=fec and t.fecha<fec) or
(t.fijo = 'q' and t.dia=dias and t.semana=sema and t.finturnofijo='1900-01-01' and t.fecha<fec)
order by idprofesionales,hora;

END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-03-06 22:34:47
