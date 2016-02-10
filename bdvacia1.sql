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
-- Table structure for table `tipomovcajas`
--

DROP TABLE IF EXISTS `tipomovcajas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tipomovcajas` (
  `idtipomovcajas` int(11) NOT NULL AUTO_INCREMENT,
  `detalle` varchar(50) NOT NULL,
  PRIMARY KEY (`idtipomovcajas`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

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

-- Dump completed on 2016-02-10 15:25:11
