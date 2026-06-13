-- MySQL dump 10.13  Distrib 8.0.19, for Win64 (x86_64)
--
-- Host: localhost    Database: bdprojetosenac
-- ------------------------------------------------------
-- Server version	5.5.5-10.4.32-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `tbcadastronovousuario`
--

DROP TABLE IF EXISTS `tbcadastronovousuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbcadastronovousuario` (
  `id_tbcadastronovousuario` int(11) NOT NULL AUTO_INCREMENT,
  `nomeCompleto` varchar(50) DEFAULT NULL,
  `numeroRegistro` int(7) DEFAULT NULL,
  `nivelPermisao` varchar(20) DEFAULT NULL,
  `nomeUsuario` varchar(20) DEFAULT NULL,
  `senhaAcesso` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_tbcadastronovousuario`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbcadastronovousuario`
--

LOCK TABLES `tbcadastronovousuario` WRITE;
/*!40000 ALTER TABLE `tbcadastronovousuario` DISABLE KEYS */;
INSERT INTO `tbcadastronovousuario` VALUES (22,'bruno hernqieu',123,'Administrador','123','123'),(23,'Jorge Gabriel Suxo Ramos',1234567890,'Usuário Comum','Reidelas','coringaorebaixado'),(24,'bruni hhh',7,'Usuário Comum','77','77'),(25,'bruno henrique',123,'Administrador','cabrera','123');
/*!40000 ALTER TABLE `tbcadastronovousuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbcadastropeca`
--

DROP TABLE IF EXISTS `tbcadastropeca`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbcadastropeca` (
  `id_tdcadastropeca` int(11) NOT NULL AUTO_INCREMENT,
  `codigoproduto` int(11) DEFAULT NULL,
  `nomeProduto` varchar(20) DEFAULT NULL,
  `fabricanteProduto` varchar(20) DEFAULT NULL,
  `pesoProduto` double DEFAULT NULL,
  `alturaProduto` double DEFAULT NULL,
  `comprimentoProduto` double DEFAULT NULL,
  PRIMARY KEY (`id_tdcadastropeca`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbcadastropeca`
--

LOCK TABLES `tbcadastropeca` WRITE;
/*!40000 ALTER TABLE `tbcadastropeca` DISABLE KEYS */;
INSERT INTO `tbcadastropeca` VALUES (9,123,'teste','teste',1,1,1),(10,124,'testea','teste',1,1,11),(11,125,'teste','teste',1,1,1),(12,126,'papel','suzano',1,1,1),(13,127,'teste','teste',1,1,1),(14,1258,'aaa','123',123,123,123),(15,1,'bruno','1',1,1,1);
/*!40000 ALTER TABLE `tbcadastropeca` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbentradaestoque`
--

DROP TABLE IF EXISTS `tbentradaestoque`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbentradaestoque` (
  `id_tbentradaestoque` int(11) NOT NULL AUTO_INCREMENT,
  `dataEntradaProduto` date DEFAULT NULL,
  `codigoProduto` int(11) DEFAULT NULL,
  `nomeProduto` varchar(20) DEFAULT NULL,
  `quantidadeProduto` int(11) DEFAULT NULL,
  `nFProduto` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_tbentradaestoque`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbentradaestoque`
--

LOCK TABLES `tbentradaestoque` WRITE;
/*!40000 ALTER TABLE `tbentradaestoque` DISABLE KEYS */;
INSERT INTO `tbentradaestoque` VALUES (1,'2026-06-01',123,'123',123,123),(2,'2026-06-01',123,'123',123,123),(3,'2026-06-07',122,'123',123,123),(4,'2026-06-07',123,'123',123,123),(5,'2026-06-01',123,'123',123,123),(6,'2026-06-01',123,'123',123,123),(7,'2026-06-07',123,'123',123,123),(8,'2026-06-07',123,'123',123,123),(9,'2026-06-07',122,'123',123,123),(10,'2026-06-07',123,'123',123,123),(11,'2026-06-07',123,'123',123,123),(12,'2026-06-07',123,'123',123,123),(13,'2026-06-07',123,'123',123,123),(14,'2026-06-07',123,'123',123,123),(15,'2026-06-07',123,'123',123,123),(16,'2026-06-07',1224,'1224',1224,124),(17,'2026-06-09',124,'123',124,124),(18,'2026-06-09',124,'aaa',1,1),(19,'2026-06-09',1,'rere',1,1),(20,'2026-06-09',2,'aaaaa',2,3);
/*!40000 ALTER TABLE `tbentradaestoque` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbordemservico`
--

DROP TABLE IF EXISTS `tbordemservico`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbordemservico` (
  `int_tbordemservico` int(11) NOT NULL AUTO_INCREMENT,
  `codigoOS` int(11) DEFAULT NULL,
  `codigoProduto` int(11) DEFAULT NULL,
  `nomeProduto` varchar(20) DEFAULT NULL,
  `quantidadeProduzida` int(11) DEFAULT NULL,
  `idTabelaEstoque` int(11) DEFAULT NULL,
  PRIMARY KEY (`int_tbordemservico`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbordemservico`
--

LOCK TABLES `tbordemservico` WRITE;
/*!40000 ALTER TABLE `tbordemservico` DISABLE KEYS */;
INSERT INTO `tbordemservico` VALUES (1,123,123,'teste',NULL,NULL),(2,123,123,'aaaaa',NULL,NULL),(3,123,123,'AAAA',NULL,NULL);
/*!40000 ALTER TABLE `tbordemservico` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbordeservi`
--

DROP TABLE IF EXISTS `tbordeservi`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbordeservi` (
  `id_tbordeservi` int(11) NOT NULL AUTO_INCREMENT,
  `codidoOs` int(7) DEFAULT NULL,
  `nomeProduto` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_tbordeservi`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbordeservi`
--

LOCK TABLES `tbordeservi` WRITE;
/*!40000 ALTER TABLE `tbordeservi` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbordeservi` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbsaidaestoque`
--

DROP TABLE IF EXISTS `tbsaidaestoque`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbsaidaestoque` (
  `id_tbsaidaestoque` int(11) NOT NULL AUTO_INCREMENT,
  `dataSaida` date DEFAULT NULL,
  `codigoPeca` int(11) DEFAULT NULL,
  `nomePeca` varchar(20) DEFAULT NULL,
  `quantidaPeca` int(11) DEFAULT NULL,
  `numeroNf` int(11) DEFAULT NULL,
  `cpfPeca` int(11) DEFAULT NULL,
  `numeroOs` int(11) DEFAULT NULL,
  `situacaoPeca` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_tbsaidaestoque`)
) ENGINE=InnoDB AUTO_INCREMENT=32 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbsaidaestoque`
--

LOCK TABLES `tbsaidaestoque` WRITE;
/*!40000 ALTER TABLE `tbsaidaestoque` DISABLE KEYS */;
INSERT INTO `tbsaidaestoque` VALUES (1,'2026-05-26',123,'123',123,0,0,0,''),(2,'2026-05-26',123,'123',123,0,0,0,''),(3,'2026-05-26',123,'123',123,0,0,0,''),(4,'2026-05-26',123,'123',123,0,0,0,''),(5,'2026-05-26',123,'123',123,0,0,0,''),(6,'2026-05-26',123,'123',123,123,123,123,'123'),(7,'2026-05-26',123,'123',123,123,123,123,'123'),(8,'2026-05-26',123,'123',123,123,123,123,'123'),(9,'2026-05-26',123,'123',123,123,123,123,'123'),(10,'2026-05-26',123,'123',123,123,123,123,'123'),(11,'2026-05-26',123,'123',123,123,123,123,'123'),(12,'2026-05-26',123,'123',123,123,123,123,'123'),(13,'2026-05-02',122,'123',123,123,123,123,'123'),(14,'2026-05-02',122,'123',123,123,123,123,'123'),(15,'2026-05-02',122,'123',123,123,123,123,'123'),(16,'2026-05-02',122,'123',123,123,123,123,'123'),(17,'2026-05-26',123,'123',123,123,123,123,'123'),(18,'2026-05-26',123,'123',123,123,123,123,'123'),(19,'2026-05-26',123,'123',123,123,123,123,'123'),(20,'2026-05-26',123,'123',123,123,123,123,'123'),(21,'2026-05-26',123,'',123,123,123,123,'123'),(22,'2026-05-26',123,'',123,123,123,123,'123'),(23,'2026-05-26',123,'',123,123,123,123,'123'),(24,'2026-05-26',123,'',123,123,123,123,'123'),(25,'2026-05-26',111,'a',11,1,1,111,'1111'),(26,'2026-05-26',123,'123',123,123,123,123,'123'),(27,'2026-05-26',123,'123',123,123,123,123,'123'),(28,'2026-05-26',123,'123',123,123,123,123,'123'),(29,'2026-05-26',123,'123',123,123,123,123,''),(30,'2026-05-26',11,'bruno',1,100,11,15,'@@'),(31,'2026-06-09',1,'11',1,1,1,1,'1');
/*!40000 ALTER TABLE `tbsaidaestoque` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'bdprojetosenac'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-06-12 21:49:36
