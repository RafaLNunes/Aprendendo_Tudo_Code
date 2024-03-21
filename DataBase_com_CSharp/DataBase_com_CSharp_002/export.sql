-- MariaDB dump 10.19  Distrib 10.4.24-MariaDB, for Win64 (AMD64)
--
-- Host: 127.0.0.1    Database: teste_database
-- ------------------------------------------------------
-- Server version	10.4.24-MariaDB

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
-- Table structure for table `juncao`
--

DROP TABLE IF EXISTS `juncao`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `juncao` (
  `cod_juncao` int(11) NOT NULL AUTO_INCREMENT,
  `CFK_prod` int(11) DEFAULT NULL,
  `CFK_user` int(11) DEFAULT NULL,
  PRIMARY KEY (`cod_juncao`),
  KEY `FK_prod` (`CFK_prod`),
  KEY `FK_user` (`CFK_user`),
  CONSTRAINT `FK_prod` FOREIGN KEY (`CFK_prod`) REFERENCES `produto` (`Cod_Prod`),
  CONSTRAINT `FK_user` FOREIGN KEY (`CFK_user`) REFERENCES `users` (`Cod_User`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `juncao`
--

LOCK TABLES `juncao` WRITE;
/*!40000 ALTER TABLE `juncao` DISABLE KEYS */;
/*!40000 ALTER TABLE `juncao` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `produto`
--

DROP TABLE IF EXISTS `produto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `produto` (
  `Cod_Prod` int(11) NOT NULL AUTO_INCREMENT,
  `nome_prod` varchar(40) DEFAULT NULL,
  `preco_prod` float(5,2) DEFAULT NULL,
  `qtd_prod` int(11) DEFAULT NULL,
  PRIMARY KEY (`Cod_Prod`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `produto`
--

LOCK TABLES `produto` WRITE;
/*!40000 ALTER TABLE `produto` DISABLE KEYS */;
/*!40000 ALTER TABLE `produto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `users` (
  `Cod_User` int(11) NOT NULL AUTO_INCREMENT,
  `Nome` varchar(30) DEFAULT NULL,
  `idade` int(11) DEFAULT NULL,
  `ano` datetime DEFAULT NULL,
  `NameUser` varchar(60) DEFAULT NULL,
  `pasword` varchar(40) DEFAULT NULL,
  PRIMARY KEY (`Cod_User`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'fdfghjk',56,'2015-09-05 11:22:39','cxv b','dfghn'),(2,'fdgh',14,'2017-12-08 12:50:41','sdfghj','dfg'),(3,'fdgh',14,'2017-12-08 12:50:45','sdfghj','dfg'),(4,'fdgh',14,'2017-12-08 12:50:47','sdfghj','dfg'),(5,'fdgh',14,'2017-12-08 12:50:48','sdfghj','dfg'),(6,'fdgh',14,'2017-12-08 12:50:50','sdfghj','dfg'),(7,'fdgh',14,'2017-12-08 12:50:52','sdfghj','dfg'),(8,'fdgh',14,'2017-12-08 12:50:54','sdfghj','dfg'),(9,'fdgh',14,'2017-12-08 12:50:55','sdfghj','dfg'),(10,'fdgh',14,'2017-12-08 12:50:56','sdfghj','dfg'),(11,'fdghmj',23,'2017-07-05 12:51:24','fghmj,','xcvbnm'),(12,'dfgh',45,'2017-09-15 12:52:52','fdghjjhhfds','ghj'),(13,'dfg',15,'2018-08-07 13:11:04','xcvbn','xcvbnm');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-03-11 13:19:22
