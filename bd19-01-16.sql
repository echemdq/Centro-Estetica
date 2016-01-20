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
INSERT INTO `contador` VALUES (1,6,'factura'),(2,0,'recibo');
/*!40000 ALTER TABLE `contador` ENABLE KEYS */;
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
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
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
  PRIMARY KEY (`idfacturacion`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `facturacion`
--

LOCK TABLES `facturacion` WRITE;
/*!40000 ALTER TABLE `facturacion` DISABLE KEYS */;
INSERT INTO `facturacion` VALUES (1,'2016-01-18 21:30:32',0,'Consumidor Final','S/Domicilio','','7600 - Mar del Plata',75.00,0,1,0.00),(2,'2016-01-18 21:30:58',0,'Consumidor Final','S/Domicilio','','7600 - Mar del Plata',690.00,0,2,60.00),(3,'2016-01-18 21:39:16',0,'Consumidor Final','S/Domicilio','','7600 - Mar del Plata',155.00,0,3,10.00),(4,'2016-01-19 19:37:24',1,'eze','asd','231','7600 - Mar del Plata',100.00,0,4,0.00),(5,'2016-01-19 20:46:44',0,'Consumidor Final','S/Domicilio','','7600 - Mar del Plata',100.00,0,5,0.00),(6,'2016-01-19 20:55:47',1,'eze askjdlasjdlkasdsa','asd','','7600 - Mar del Plata',115.00,0,5,0.00),(7,'2016-01-19 20:58:09',1,'eze','asd','231','7600 - Mar del Plata',100.00,0,6,0.00);
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
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `formasdepago`
--

LOCK TABLES `formasdepago` WRITE;
/*!40000 ALTER TABLE `formasdepago` DISABLE KEYS */;
INSERT INTO `formasdepago` VALUES (1,1,1,'','','',75.00),(2,1,2,'','','',690.00),(3,1,3,'','','',155.00),(4,1,4,'','','',100.00),(5,1,6,'','','',115.00),(6,1,7,'','','',100.00);
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
  `tipo` int(11) NOT NULL,
  `importe` decimal(10,0) NOT NULL,
  PRIMARY KEY (`idhonorarios`),
  KEY `fkhprof_idx` (`idprofesionales`),
  KEY `fkhprod_idx` (`idproductos`),
  CONSTRAINT `fkhprod` FOREIGN KEY (`idproductos`) REFERENCES `productos` (`idproductos`) ON UPDATE CASCADE,
  CONSTRAINT `fkhprof` FOREIGN KEY (`idprofesionales`) REFERENCES `profesionales` (`idprofesionales`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `honorarios`
--

LOCK TABLES `honorarios` WRITE;
/*!40000 ALTER TABLE `honorarios` DISABLE KEYS */;
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
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lineafactura`
--

LOCK TABLES `lineafactura` WRITE;
/*!40000 ALTER TABLE `lineafactura` DISABLE KEYS */;
INSERT INTO `lineafactura` VALUES (1,1,5,15.00,1,0.00,0),(2,1,50,15.00,2,0.00,0),(3,1,11,15.00,3,0.00,0),(4,2,1,100.00,4,75.00,10),(5,2,1,100.00,5,75.00,10),(6,1,1,15.00,6,0.00,0),(7,2,1,100.00,6,75.00,10),(8,2,1,100.00,7,75.00,10);
/*!40000 ALTER TABLE `lineafactura` ENABLE KEYS */;
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
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pacientes`
--

LOCK TABLES `pacientes` WRITE;
/*!40000 ALTER TABLE `pacientes` DISABLE KEYS */;
INSERT INTO `pacientes` VALUES (1,'eze','','asd','','231',1,'',1,'','C:\\Users\\Ezequiel\\Documents\\eze 231.png');
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
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productos`
--

LOCK TABLES `productos` WRITE;
/*!40000 ALTER TABLE `productos` DISABLE KEYS */;
INSERT INTO `productos` VALUES (1,'prueb eze',15.00,0,-67,1,0.00),(2,'masaje',100.00,10,0,1,75.00);
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
INSERT INTO `profesionales` VALUES (1,'DOSSO KARINA','',1,'','',1,'','0'),(3,'PARADA YESICA','24539113',1,'','',1,'','1');
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
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rubros`
--

LOCK TABLES `rubros` WRITE;
/*!40000 ALTER TABLE `rubros` DISABLE KEYS */;
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
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `seguimientos`
--

LOCK TABLES `seguimientos` WRITE;
/*!40000 ALTER TABLE `seguimientos` DISABLE KEYS */;
INSERT INTO `seguimientos` VALUES (1,1,'11:00','2016-01-14 00:00:00','Deshabilitacion Manual de Horario',0,'2016-01-13 16:08:08',0),(2,1,'11:00','2016-01-14 00:00:00','Habilitacion Manual de Horario',0,'2016-01-13 16:08:21',0),(3,1,'16:00','2016-01-14 00:00:00','Habilitacion Manual de Horario',0,'2016-01-13 16:08:28',0),(4,1,'11:00','2016-01-13 00:00:00','Inserta nuevo turno',0,'2016-01-13 19:25:40',0),(5,3,'12:00','2016-02-12 00:00:00','Inserta nuevo turno',0,'2016-01-15 18:16:36',0),(6,3,'12:00','2016-02-12 00:00:00','Libera turno',0,'2016-01-15 18:16:59',0),(7,3,'10:00','2016-01-15 00:00:00','Inserta nuevo turno',0,'2016-01-15 18:19:32',0),(8,3,'10:00','2016-02-26 00:00:00','Suspende turno fijo por el dia del Cliente: eze',0,'2016-01-15 18:21:56',0),(9,3,'08:00','2016-01-15 00:00:00','Inserta nuevo turno',0,'2016-01-15 18:31:18',0),(10,3,'08:00','2016-01-15 00:00:00','Libera turno del cliente: eze',0,'2016-01-15 18:31:24',0),(11,3,'08:00','2016-01-19 00:00:00','Inserta nuevo turno',0,'2016-01-19 21:32:53',0),(12,3,'09:00','2016-01-19 00:00:00','Inserta nuevo turno',0,'2016-01-19 21:49:42',0);
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
  `idfacturacion` int(11) NOT NULL,
  `idpacientes` int(11) NOT NULL,
  `fecha` datetime NOT NULL,
  PRIMARY KEY (`idservicios`),
  KEY `sfkidprod_idx` (`idproductos`),
  KEY `sfkidfact_idx` (`idfacturacion`),
  KEY `sfkidpac_idx` (`idpacientes`),
  CONSTRAINT `sfkidfact` FOREIGN KEY (`idfacturacion`) REFERENCES `facturacion` (`idfacturacion`) ON UPDATE CASCADE,
  CONSTRAINT `sfkidpac` FOREIGN KEY (`idpacientes`) REFERENCES `pacientes` (`idpacientes`) ON UPDATE CASCADE,
  CONSTRAINT `sfkidprod` FOREIGN KEY (`idproductos`) REFERENCES `productos` (`idproductos`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `servicios`
--

LOCK TABLES `servicios` WRITE;
/*!40000 ALTER TABLE `servicios` DISABLE KEYS */;
INSERT INTO `servicios` VALUES (1,2,'masaje',10,0,4,1,'2015-12-19 00:00:00'),(3,2,'masaje',10,2,6,1,'2016-01-19 20:55:47'),(4,2,'masaje',10,0,7,1,'2016-01-19 20:58:09');
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
  PRIMARY KEY (`idserviciosturnos`),
  KEY `stfkprof_idx` (`idprofesionales`),
  KEY `stfkserv_idx` (`idservicios`),
  KEY `stfkpac_idx` (`idpacientes`),
  CONSTRAINT `stfkpac` FOREIGN KEY (`idpacientes`) REFERENCES `pacientes` (`idpacientes`) ON DELETE CASCADE,
  CONSTRAINT `stfkprof` FOREIGN KEY (`idprofesionales`) REFERENCES `profesionales` (`idprofesionales`) ON UPDATE CASCADE,
  CONSTRAINT `stfkserv` FOREIGN KEY (`idservicios`) REFERENCES `servicios` (`idservicios`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `serviciosturnos`
--

LOCK TABLES `serviciosturnos` WRITE;
/*!40000 ALTER TABLE `serviciosturnos` DISABLE KEYS */;
INSERT INTO `serviciosturnos` VALUES (2,3,3,'2016-01-19 00:00:00','09:00',1);
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
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `subrubros`
--

LOCK TABLES `subrubros` WRITE;
/*!40000 ALTER TABLE `subrubros` DISABLE KEYS */;
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
  `idpacientes` varchar(1) DEFAULT NULL,
  `detalle` varchar(100) NOT NULL,
  `fijo` varchar(1) DEFAULT NULL,
  `semana` varchar(1) DEFAULT NULL,
  `dia` varchar(1) DEFAULT NULL,
  `telefono` varchar(45) DEFAULT NULL,
  `idservicios` varchar(1) DEFAULT NULL,
  `finturnofijo` datetime DEFAULT '1900-01-01 00:00:00',
  PRIMARY KEY (`idturnos`),
  KEY `tfkidprofesional_idx` (`idprofesionales`),
  CONSTRAINT `tfkidprofesional` FOREIGN KEY (`idprofesionales`) REFERENCES `profesionales` (`idprofesionales`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `turnos`
--

LOCK TABLES `turnos` WRITE;
/*!40000 ALTER TABLE `turnos` DISABLE KEYS */;
INSERT INTO `turnos` VALUES (1,1,'11:00','2016-01-13 00:00:00','','Micaela','','0','3','lala','','1900-01-01 00:00:00'),(3,3,'10:00','2016-01-15 00:00:00','1','','s','0','5','848','','1900-01-01 00:00:00'),(4,3,'11:00','2016-01-19 00:00:00','','jkxzc','','0','2','',NULL,'1900-01-01 00:00:00'),(6,3,'08:00','2016-01-19 00:00:00','1','','','0','2','',NULL,'1900-01-01 00:00:00'),(7,3,'09:00','2016-01-19 00:00:00','1','','','0','2','',NULL,'1900-01-01 00:00:00');
/*!40000 ALTER TABLE `turnos` ENABLE KEYS */;
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
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `turnosuspendidos`
--

LOCK TABLES `turnosuspendidos` WRITE;
/*!40000 ALTER TABLE `turnosuspendidos` DISABLE KEYS */;
INSERT INTO `turnosuspendidos` VALUES (1,3,'2016-01-29 00:00:00','10:00'),(2,3,'2016-01-22 00:00:00','10:00'),(3,3,'2016-02-05 00:00:00','10:00'),(4,3,'2016-02-26 00:00:00','10:00');
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
				set b = concat(b,";"),
				cant = cant + 1;
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
		where p.activo=1
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
select t.idturnos, t.idprofesionales, t.hora,t.fecha, ifnull(p.paciente,t.detalle) as detalle, t.fijo,t.semana, 0 as suspendido
from turnos t
left join pacientes p on p.idpacientes=t.idpacientes
where fecha=fec
union
select t.idturnos, t.idprofesionales, t.hora,t.fecha, ifnull(p.paciente,t.detalle) as detalle, t.fijo,t.semana, ifnull(ts.idturnosuspendidos,0) as suspendido
from turnos t
left join pacientes p on p.idpacientes=t.idpacientes
left join turnosuspendidos ts on ts.idprofesionales=t.idprofesionales and ts.dia=fec and t.hora=ts.hora
where t.fijo = 's' and t.dia=dias and t.finturnofijo>fec  and t.fecha<fec or
(t.fijo = 's' and t.dia=dias and t.finturnofijo='1900-01-01'  and t.fecha<fec) or
(t.fijo = 'q' and t.dia=dias and t.semana=sema and t.finturnofijo>fec and t.fecha<fec) or
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

-- Dump completed on 2016-01-19 21:51:29
