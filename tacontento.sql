-- MySQL dump 10.13  Distrib 5.7.28, for Win64 (x86_64)
--
-- Host: localhost    Database: tacontento
-- ------------------------------------------------------
-- Server version	5.5.5-10.4.11-MariaDB

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
-- Table structure for table `clasificaciones`
--

DROP TABLE IF EXISTS `clasificaciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `clasificaciones` (
  `idClasificacion` int(11) NOT NULL AUTO_INCREMENT,
  `clasificacion` varchar(100) NOT NULL,
  PRIMARY KEY (`idClasificacion`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clasificaciones`
--

LOCK TABLES `clasificaciones` WRITE;
/*!40000 ALTER TABLE `clasificaciones` DISABLE KEYS */;
INSERT INTO `clasificaciones` VALUES (1,'PERMISOS');
/*!40000 ALTER TABLE `clasificaciones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `clasificacionesordenes`
--

DROP TABLE IF EXISTS `clasificacionesordenes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `clasificacionesordenes` (
  `idClasificacionOrden` int(11) NOT NULL AUTO_INCREMENT,
  `clasificacionOrden` varchar(50) NOT NULL,
  `estado` int(11) NOT NULL,
  PRIMARY KEY (`idClasificacionOrden`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clasificacionesordenes`
--

LOCK TABLES `clasificacionesordenes` WRITE;
/*!40000 ALTER TABLE `clasificacionesordenes` DISABLE KEYS */;
INSERT INTO `clasificacionesordenes` VALUES (1,'Entraditas',1),(2,'Especialidades',1),(3,'Tacos',1),(4,'Tortas',1),(5,'Bebidas Frias',1),(6,'Tragos',1),(7,'Cervezas',1),(8,'Baldes',1),(9,'Baldes',2);
/*!40000 ALTER TABLE `clasificacionesordenes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detallespedidos`
--

DROP TABLE IF EXISTS `detallespedidos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detallespedidos` (
  `idDetallePedido` int(11) NOT NULL AUTO_INCREMENT,
  `idPedido` int(11) NOT NULL,
  `idOrden` int(11) NOT NULL,
  `cantidad` int(11) NOT NULL,
  `precio` decimal(5,2) NOT NULL,
  PRIMARY KEY (`idDetallePedido`),
  KEY `idPedido` (`idPedido`),
  KEY `idOrden` (`idOrden`),
  CONSTRAINT `detallespedidos_ibfk_1` FOREIGN KEY (`idPedido`) REFERENCES `pedidos` (`idPedido`),
  CONSTRAINT `detallespedidos_ibfk_2` FOREIGN KEY (`idOrden`) REFERENCES `ordenes` (`idOrden`)
) ENGINE=InnoDB AUTO_INCREMENT=97 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detallespedidos`
--

LOCK TABLES `detallespedidos` WRITE;
/*!40000 ALTER TABLE `detallespedidos` DISABLE KEYS */;
INSERT INTO `detallespedidos` VALUES (1,1,1,1,6.45),(2,2,1,1,6.45),(90,1,12,1,3.75),(91,1,4,1,2.00),(92,1,2,1,2.25),(93,1,30,1,3.00),(94,1,23,2,1.25),(95,1,39,1,2.00),(96,1,34,1,2.50);
/*!40000 ALTER TABLE `detallespedidos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empleados`
--

DROP TABLE IF EXISTS `empleados`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `empleados` (
  `idEmpleado` int(11) NOT NULL AUTO_INCREMENT,
  `Nombres` varchar(100) NOT NULL,
  `Apellidos` varchar(100) NOT NULL,
  `DUI` varchar(10) NOT NULL,
  `NIT` varchar(18) NOT NULL,
  `Direccion` varchar(75) NOT NULL,
  `Genero` enum('MASCULINO','FEMENINO') NOT NULL,
  `Fecha_Nac` date NOT NULL,
  `estado` int(11) NOT NULL,
  PRIMARY KEY (`idEmpleado`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empleados`
--

LOCK TABLES `empleados` WRITE;
/*!40000 ALTER TABLE `empleados` DISABLE KEYS */;
INSERT INTO `empleados` VALUES (1,'Cesar','Guerrero','05781121-6','0315-180298-111-1','SONSONATE','MASCULINO','1998-02-18',0);
/*!40000 ALTER TABLE `empleados` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `incidentes`
--

DROP TABLE IF EXISTS `incidentes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `incidentes` (
  `idIncidente` int(11) NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(100) NOT NULL,
  `precio` decimal(5,2) NOT NULL,
  `idPedido` int(11) NOT NULL,
  PRIMARY KEY (`idIncidente`),
  KEY `idPedido` (`idPedido`),
  CONSTRAINT `incidentes_ibfk_1` FOREIGN KEY (`idPedido`) REFERENCES `pedidos` (`idPedido`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `incidentes`
--

LOCK TABLES `incidentes` WRITE;
/*!40000 ALTER TABLE `incidentes` DISABLE KEYS */;
/*!40000 ALTER TABLE `incidentes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `opciones`
--

DROP TABLE IF EXISTS `opciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `opciones` (
  `idOpcion` int(11) NOT NULL AUTO_INCREMENT,
  `opcion` varchar(100) NOT NULL,
  `idClasificacion` int(11) NOT NULL,
  PRIMARY KEY (`idOpcion`),
  KEY `idClasificacion` (`idClasificacion`),
  CONSTRAINT `opciones_ibfk_1` FOREIGN KEY (`idClasificacion`) REFERENCES `clasificaciones` (`idClasificacion`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `opciones`
--

LOCK TABLES `opciones` WRITE;
/*!40000 ALTER TABLE `opciones` DISABLE KEYS */;
INSERT INTO `opciones` VALUES (1,'PANEL PRINCIPAL',1),(2,'MANTENIMIENTO ORDENES',1),(3,'MANTENIMIENTO LOCAL',1);
/*!40000 ALTER TABLE `opciones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ordenes`
--

DROP TABLE IF EXISTS `ordenes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ordenes` (
  `idOrden` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) NOT NULL,
  `precio` decimal(5,2) NOT NULL,
  `descripcion` varchar(100) DEFAULT NULL,
  `idClasificacionOrden` int(11) NOT NULL,
  `Estado` int(11) NOT NULL,
  PRIMARY KEY (`idOrden`),
  KEY `idClasificacionOrden` (`idClasificacionOrden`),
  CONSTRAINT `ordenes_ibfk_1` FOREIGN KEY (`idClasificacionOrden`) REFERENCES `clasificacionesordenes` (`idClasificacionOrden`)
) ENGINE=InnoDB AUTO_INCREMENT=43 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ordenes`
--

LOCK TABLES `ordenes` WRITE;
/*!40000 ALTER TABLE `ordenes` DISABLE KEYS */;
INSERT INTO `ordenes` VALUES (1,'Ensalada de Carne',6.45,'Rica ensalada de Carnesssss	',1,1),(2,'Orden de guacamole',2.25,'Guacamole y frijoles con tortilla o nachos',1,1),(3,'Plato de costilla',4.00,'Costilla ahumada con BBQ y tortillas',1,1),(4,'Orden de papas fritas',2.00,'	',1,1),(5,'Orden de alitas',3.00,'',1,1),(6,'Orden de chicharrones',3.75,'Acompaniado de frijoles y tortillas',1,1),(7,'Orden de nachos',4.00,'Queso derretido con carne a tu eleccion	',2,1),(8,'Super burrito',4.25,'Res, pollo, pastor o mixto',2,1),(9,'Orden de quesadillas',2.75,'3 tortillas con quesillo derretido',2,1),(10,'Orden de gringas',3.75,'2 tortillas con queso derretido y carne',2,1),(11,'Orden de 3 tacos',3.00,'',3,1),(12,'Orden de 4 tacos',3.75,'',3,1),(13,'Orden de 5 tacos',4.50,'',3,1),(14,'Taquiza',14.00,'16 tacos, 4 de cada especialidad',3,1),(15,'Hamburguesa + papas',5.00,'Carne,tocino y quesillo derritdo',4,1),(16,'Torta de carne',3.50,'Res, pastor o pollo con quesillo derretido',4,1),(17,'Torta mixta',3.75,'Pollo y carne con quesillo derretido',4,1),(18,'Torta cubana',3.75,'Jamon y tocino con quesiilo derretido',4,1),(19,'Horchata de mani',1.00,'',5,1),(20,'Gaseosas ',0.75,'',5,1),(21,'Frozzen',1.75,'Pina, fresa, sandia, melon,papaya, limon',5,1),(22,'Licuados',2.00,'Pina, fresa, sandia, melon,papaya',5,1),(23,'Limonada',1.25,'',5,1),(24,'Jugo del valle',0.75,'',5,1),(25,'Botella con agua',0.75,'',5,1),(26,'Frappa',2.00,'',5,1),(27,'Michelada nacional',2.00,'pilsener o golden	',6,1),(28,'Michelada suprema',2.25,'		',6,1),(29,'Michelada extranjera',3.00,'Corona	',6,1),(30,'Margarita',3.00,'',6,1),(31,'Tequila sencillo',2.00,'	',6,1),(32,'Tequila doble',3.50,'',6,1),(33,'Mojito cubano',3.50,'',6,1),(34,'Cuba libre',2.50,'',6,1),(35,'Laguna azul',3.00,'',6,1),(36,'Pilsener',1.00,'',7,1),(37,'Golden y extra',1.00,'',7,1),(38,'Suprema',1.50,'',7,1),(39,'Corona',2.00,'',7,1),(40,'Golden o pilsener',7.50,'8 unidades',8,1),(41,'Suprema',8.00,'6 unidades',8,1),(42,'Corona',11.00,'6 unidades',8,1);
/*!40000 ALTER TABLE `ordenes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pedidos`
--

DROP TABLE IF EXISTS `pedidos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pedidos` (
  `idPedido` int(11) NOT NULL AUTO_INCREMENT,
  `nombreCliente` varchar(50) NOT NULL,
  `total` decimal(5,2) NOT NULL,
  `fecha` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `tipoPago` int(11) NOT NULL,
  `estado` int(11) NOT NULL,
  `idUsuario` int(11) NOT NULL,
  PRIMARY KEY (`idPedido`),
  KEY `idUsuario` (`idUsuario`),
  CONSTRAINT `pedidos_ibfk_1` FOREIGN KEY (`idUsuario`) REFERENCES `usuarios` (`idUsuario`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pedidos`
--

LOCK TABLES `pedidos` WRITE;
/*!40000 ALTER TABLE `pedidos` DISABLE KEYS */;
INSERT INTO `pedidos` VALUES (1,'FAMILIA GUERRERO',24.45,'2020-05-08 03:06:42',2,1,1),(2,'Juan',6.45,'2020-05-06 07:40:31',1,1,1);
/*!40000 ALTER TABLE `pedidos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `permisos`
--

DROP TABLE IF EXISTS `permisos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `permisos` (
  `idPermiso` int(11) NOT NULL AUTO_INCREMENT,
  `idRol` int(11) NOT NULL,
  `idOpcion` int(11) NOT NULL,
  PRIMARY KEY (`idPermiso`),
  KEY `idRol` (`idRol`),
  KEY `idOpcion` (`idOpcion`),
  CONSTRAINT `permisos_ibfk_1` FOREIGN KEY (`idRol`) REFERENCES `roles` (`idRol`),
  CONSTRAINT `permisos_ibfk_2` FOREIGN KEY (`idOpcion`) REFERENCES `opciones` (`idOpcion`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `permisos`
--

LOCK TABLES `permisos` WRITE;
/*!40000 ALTER TABLE `permisos` DISABLE KEYS */;
INSERT INTO `permisos` VALUES (1,1,1),(2,1,2),(3,1,3),(4,2,1);
/*!40000 ALTER TABLE `permisos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `roles`
--

DROP TABLE IF EXISTS `roles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `roles` (
  `idRol` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) NOT NULL,
  `descripcion` varchar(150) DEFAULT NULL,
  `estado` int(11) NOT NULL,
  PRIMARY KEY (`idRol`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `roles`
--

LOCK TABLES `roles` WRITE;
/*!40000 ALTER TABLE `roles` DISABLE KEYS */;
INSERT INTO `roles` VALUES (1,'ADMINISTRADOR','Persona Encargada.',1),(2,'MESERO','Persona que toma ordenes.',1),(3,'COCINERO','Persona encargada de platillos.',1);
/*!40000 ALTER TABLE `roles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuarios` (
  `idUsuario` int(11) NOT NULL AUTO_INCREMENT,
  `usuario` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL,
  `idRol` int(11) NOT NULL,
  `estado` int(11) NOT NULL,
  `idEmpleado` int(11) NOT NULL,
  PRIMARY KEY (`idUsuario`),
  KEY `idRol` (`idRol`),
  KEY `idEmpleado` (`idEmpleado`),
  CONSTRAINT `usuarios_ibfk_1` FOREIGN KEY (`idRol`) REFERENCES `roles` (`idRol`),
  CONSTRAINT `usuarios_ibfk_2` FOREIGN KEY (`idEmpleado`) REFERENCES `empleados` (`idEmpleado`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES (1,'Cesar','123',1,1,1),(2,'Cesar','admin',2,1,1),(3,'Jorge','1234',3,1,1),(4,'asdasd','sdfsdf',1,2,1);
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-05-07 21:31:20
