-- MySQL dump 10.13  Distrib 5.6.17, for Win32 (x86)
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
  CONSTRAINT `fkhprof` FOREIGN KEY (`idprofesionales`) REFERENCES `profesionales` (`idprofesionales`) ON UPDATE CASCADE,
  CONSTRAINT `fkhprod` FOREIGN KEY (`idproductos`) REFERENCES `productos` (`idproductos`) ON UPDATE CASCADE
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
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pacientes`
--

LOCK TABLES `pacientes` WRITE;
/*!40000 ALTER TABLE `pacientes` DISABLE KEYS */;
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
  `precioventa` decimal(10,0) NOT NULL,
  `sesiones` int(11) NOT NULL DEFAULT '0',
  `stock` int(11) NOT NULL DEFAULT '0',
  `idsubrubros` int(11) NOT NULL,
  `activo` int(11) NOT NULL,
  `preciocalculo` decimal(10,0) NOT NULL,
  PRIMARY KEY (`idproductos`),
  KEY `fksubrubros_idx` (`idsubrubros`),
  CONSTRAINT `fksubrubros` FOREIGN KEY (`idsubrubros`) REFERENCES `subrubros` (`idsubrubros`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productos`
--

LOCK TABLES `productos` WRITE;
/*!40000 ALTER TABLE `productos` DISABLE KEYS */;
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
  `domicilio` varchar(80) NOT NULL,
  `telefono` varchar(45) NOT NULL,
  `celular` varchar(45) NOT NULL,
  PRIMARY KEY (`idprofesionales`),
  UNIQUE KEY `documento_UNIQUE` (`documento`),
  KEY `fktipodoc_idx` (`idtipodoc`),
  CONSTRAINT `fktipodoc` FOREIGN KEY (`idtipodoc`) REFERENCES `tipodoc` (`idtipodoc`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `profesionales`
--

LOCK TABLES `profesionales` WRITE;
/*!40000 ALTER TABLE `profesionales` DISABLE KEYS */;
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
-- Dumping events for database 'centroestetica'
--

--
-- Dumping routines for database 'centroestetica'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2015-11-27 10:45:05
