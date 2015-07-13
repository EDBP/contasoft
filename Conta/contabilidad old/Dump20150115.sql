CREATE DATABASE  IF NOT EXISTS `conta_bd` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `conta_bd`;
-- MySQL dump 10.13  Distrib 5.6.17, for Win32 (x86)
--
-- Host: localhost    Database: conta_bd
-- ------------------------------------------------------
-- Server version	5.6.19

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
-- Table structure for table `categoria`
--

DROP TABLE IF EXISTS `categoria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `categoria` (
  `ca_codigo` varchar(4) NOT NULL,
  `ca_estado_finaciero` varchar(45) NOT NULL,
  PRIMARY KEY (`ca_codigo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categoria`
--

LOCK TABLES `categoria` WRITE;
/*!40000 ALTER TABLE `categoria` DISABLE KEYS */;
INSERT INTO `categoria` VALUES ('0','No Aplica'),('1A','Balance General'),('1P','Balance General'),('1R','Estado de Resultados'),('2A','Balance General'),('2P','Balance General'),('2R','Estado de Resultados'),('3A','Balance General'),('3P','Balance General'),('3R','Estado de Resultados'),('4R','Estado de Resultados'),('C','Balance General');
/*!40000 ALTER TABLE `categoria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cuenta`
--

DROP TABLE IF EXISTS `cuenta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cuenta` (
  `cu_codigo` varchar(50) NOT NULL,
  `cu_nombre` varchar(50) DEFAULT NULL,
  `cu_fecha_inicio` date DEFAULT NULL,
  `cu_fecha_fin` date DEFAULT NULL,
  `cu_moneda` tinyint(4) DEFAULT '0',
  `cu_nivel` smallint(6) DEFAULT NULL,
  `cu_digitos` int(11) DEFAULT NULL,
  `cu_contabilizable` tinyint(1) DEFAULT NULL,
  `cu_naturaleza` varchar(45) DEFAULT NULL,
  `ca_codigo` varchar(4) NOT NULL,
  `us_codigo` int(11) NOT NULL,
  PRIMARY KEY (`cu_codigo`),
  KEY `fk_Cuenta_Usuario1_idx` (`us_codigo`),
  KEY `fk_Cuenta_Categoria1_idx` (`ca_codigo`),
  CONSTRAINT `fk_Cuenta_Categoria1` FOREIGN KEY (`ca_codigo`) REFERENCES `categoria` (`ca_codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Cuenta_Usuario1` FOREIGN KEY (`us_codigo`) REFERENCES `usuario` (`us_codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cuenta`
--

LOCK TABLES `cuenta` WRITE;
/*!40000 ALTER TABLE `cuenta` DISABLE KEYS */;
INSERT INTO `cuenta` VALUES ('1','Activo','2015-01-01','2015-12-31',0,1,1,0,'0','0',1),('101','Circulante','2015-01-01','2015-12-31',0,2,2,0,'0','0',1),('10101','Caja','2015-01-01','2015-12-31',0,3,5,1,'1','1A',1),('10102','Bancos','2015-01-14','2015-12-14',0,3,5,1,'1','1A',1),('1010201','Banco Industrial','2015-01-14','2015-12-14',0,4,7,1,'1','1A',1),('101020101','Banco Industrial Ahorros','2015-01-14','2015-12-14',0,5,9,1,'1','1A',1),('101020102','Banco Industrial Monetario','2015-01-14','2015-12-14',0,5,9,1,'1','1A',1),('1010202','Banco Rural','2015-01-14','2015-12-14',0,4,7,1,'1','1A',1),('10103','Cuentas por Cobrar','2015-01-01','2015-12-31',0,3,5,1,'1','1A',1),('1010301','Clientes','2015-01-15','2015-01-15',0,4,7,1,'1','1A',1),('1010302','Reserva para cuentas Incobrables','2015-01-15','2015-01-15',0,4,7,1,'1','1A',1),('1010303','Deudores Varios','2015-01-15','2015-01-15',0,4,7,1,'0','1A',1),('1010304','Intereses por Cobrar','2015-01-15','2015-01-15',0,4,7,1,'0','1A',1),('102','No Circulante','2015-01-01','2015-12-31',0,2,3,0,'0','0',1),('103','Otros Activos','2015-01-01','2015-12-31',0,2,3,1,'0','0',1),('2','Pasivo','2015-01-14','2015-12-14',0,1,1,0,'0','0',1),('3','Capital','2015-01-15','2015-01-15',0,1,1,1,'0','0',1);
/*!40000 ALTER TABLE `cuenta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalle_partida`
--

DROP TABLE IF EXISTS `detalle_partida`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detalle_partida` (
  `depa_codigo` int(11) NOT NULL,
  `depa_debe` decimal(10,0) DEFAULT NULL,
  `depa_haber` decimal(10,0) DEFAULT NULL,
  `pa_numero` int(11) NOT NULL,
  `cu_codigo` varchar(50) NOT NULL,
  PRIMARY KEY (`depa_codigo`),
  KEY `fk_Detalle_Partida_Partida1_idx` (`pa_numero`),
  KEY `fk_Detalle_Partida_Cuenta1_idx` (`cu_codigo`),
  CONSTRAINT `fk_Detalle_Partida_Cuenta1` FOREIGN KEY (`cu_codigo`) REFERENCES `cuenta` (`cu_codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Detalle_Partida_Partida1` FOREIGN KEY (`pa_numero`) REFERENCES `partida` (`pa_numero`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_partida`
--

LOCK TABLES `detalle_partida` WRITE;
/*!40000 ALTER TABLE `detalle_partida` DISABLE KEYS */;
/*!40000 ALTER TABLE `detalle_partida` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `diario`
--

DROP TABLE IF EXISTS `diario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `diario` (
  `di_codigo` int(11) NOT NULL,
  `em_codigo` int(11) DEFAULT NULL,
  `per_numero` int(11) NOT NULL,
  PRIMARY KEY (`di_codigo`),
  KEY `fk_Diario_Periodo1_idx` (`per_numero`),
  CONSTRAINT `fk_Diario_Periodo1` FOREIGN KEY (`per_numero`) REFERENCES `periodo` (`per_numero`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `diario`
--

LOCK TABLES `diario` WRITE;
/*!40000 ALTER TABLE `diario` DISABLE KEYS */;
/*!40000 ALTER TABLE `diario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empresa`
--

DROP TABLE IF EXISTS `empresa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `empresa` (
  `em_codigo` int(11) NOT NULL AUTO_INCREMENT,
  `em_nombre` varchar(100) NOT NULL,
  `em_nit` char(15) NOT NULL,
  `em_direccion` varchar(100) DEFAULT NULL,
  `em_telefono` mediumint(10) DEFAULT NULL,
  `em_responsable` varchar(100) DEFAULT NULL,
  `em_fecha_ingreso` date DEFAULT NULL,
  PRIMARY KEY (`em_codigo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empresa`
--

LOCK TABLES `empresa` WRITE;
/*!40000 ALTER TABLE `empresa` DISABLE KEYS */;
/*!40000 ALTER TABLE `empresa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `partida`
--

DROP TABLE IF EXISTS `partida`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `partida` (
  `pa_numero` int(11) NOT NULL,
  `pa_fecha` date DEFAULT NULL,
  `di_codigo` int(11) NOT NULL,
  PRIMARY KEY (`pa_numero`),
  KEY `fk_Partida_Diario1_idx` (`di_codigo`),
  CONSTRAINT `fk_Partida_Diario1` FOREIGN KEY (`di_codigo`) REFERENCES `diario` (`di_codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `partida`
--

LOCK TABLES `partida` WRITE;
/*!40000 ALTER TABLE `partida` DISABLE KEYS */;
/*!40000 ALTER TABLE `partida` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `periodo`
--

DROP TABLE IF EXISTS `periodo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `periodo` (
  `per_numero` int(11) NOT NULL,
  `per_fechainicio` date DEFAULT NULL,
  `per_fechafin` date DEFAULT NULL,
  `em_codigo` int(11) NOT NULL,
  PRIMARY KEY (`per_numero`),
  KEY `fk_Periodo_Empresa1_idx` (`em_codigo`),
  CONSTRAINT `fk_Periodo_Empresa1` FOREIGN KEY (`em_codigo`) REFERENCES `empresa` (`em_codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `periodo`
--

LOCK TABLES `periodo` WRITE;
/*!40000 ALTER TABLE `periodo` DISABLE KEYS */;
/*!40000 ALTER TABLE `periodo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuario` (
  `us_codigo` int(11) NOT NULL AUTO_INCREMENT,
  `us_nombre_completo` varchar(90) NOT NULL,
  `us_usuario` char(15) NOT NULL,
  `us_contrasena` char(15) NOT NULL,
  `us_gnomenclatura` varchar(45) DEFAULT NULL,
  `us_glibros` varchar(45) DEFAULT NULL,
  `us_estadosfin` varchar(45) DEFAULT NULL,
  `us_gusuarios` varchar(45) DEFAULT NULL,
  `us_gempresas` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`us_codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES (1,'administrador','admin','admin','1','1','1','1','1');
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2015-01-15 21:49:53
