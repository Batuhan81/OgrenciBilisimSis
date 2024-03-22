-- MySQL dump 10.13  Distrib 8.0.36, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: obs_app
-- ------------------------------------------------------
-- Server version	8.0.36

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `__efmigrationshistory`
--

DROP TABLE IF EXISTS `__efmigrationshistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(150) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `ProductVersion` varchar(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `__efmigrationshistory`
--

LOCK TABLES `__efmigrationshistory` WRITE;
/*!40000 ALTER TABLE `__efmigrationshistory` DISABLE KEYS */;
INSERT INTO `__efmigrationshistory` VALUES ('20240222121928_init','8.0.2');
/*!40000 ALTER TABLE `__efmigrationshistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `adminler`
--

DROP TABLE IF EXISTS `adminler`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `adminler` (
  `adminId` int NOT NULL AUTO_INCREMENT,
  `adminIsim` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `adminSoyad` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `adminParola` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `adminEposta` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `olusturmaTarihi` datetime(6) NOT NULL,
  PRIMARY KEY (`adminId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `adminler`
--

LOCK TABLES `adminler` WRITE;
/*!40000 ALTER TABLE `adminler` DISABLE KEYS */;
/*!40000 ALTER TABLE `adminler` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `akademiktakvimler`
--

DROP TABLE IF EXISTS `akademiktakvimler`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `akademiktakvimler` (
  `akademikTakvimId` int NOT NULL AUTO_INCREMENT,
  `akademikTakvimBaslangic` datetime(6) NOT NULL,
  `akademikTakvimBitis` datetime(6) NOT NULL,
  `akademikTakvimAktivite` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `olusturmaTarihi` datetime(6) NOT NULL,
  PRIMARY KEY (`akademikTakvimId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `akademiktakvimler`
--

LOCK TABLES `akademiktakvimler` WRITE;
/*!40000 ALTER TABLE `akademiktakvimler` DISABLE KEYS */;
/*!40000 ALTER TABLE `akademiktakvimler` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `bolumler`
--

DROP TABLE IF EXISTS `bolumler`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bolumler` (
  `bolumId` int NOT NULL AUTO_INCREMENT,
  `bolumProfId` int NOT NULL,
  `bolumIsim` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `olusturmaTarihi` datetime(6) NOT NULL,
  PRIMARY KEY (`bolumId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bolumler`
--

LOCK TABLES `bolumler` WRITE;
/*!40000 ALTER TABLE `bolumler` DISABLE KEYS */;
/*!40000 ALTER TABLE `bolumler` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dersler`
--

DROP TABLE IF EXISTS `dersler`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `dersler` (
  `dersId` int NOT NULL AUTO_INCREMENT,
  `dersProfId` int NOT NULL,
  `profesorId` int NOT NULL,
  `dersIsim` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `dersKod` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `dersKredi` int NOT NULL,
  `dersAkts` int NOT NULL,
  `olusturmaTarihi` datetime(6) NOT NULL,
  PRIMARY KEY (`dersId`),
  KEY `IX_Dersler_profesorId` (`profesorId`),
  CONSTRAINT `FK_Dersler_Profesorler_profesorId` FOREIGN KEY (`profesorId`) REFERENCES `profesorler` (`profesorId`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dersler`
--

LOCK TABLES `dersler` WRITE;
/*!40000 ALTER TABLE `dersler` DISABLE KEYS */;
/*!40000 ALTER TABLE `dersler` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `duyurualicilar`
--

DROP TABLE IF EXISTS `duyurualicilar`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `duyurualicilar` (
  `duyuruAliciId` int NOT NULL AUTO_INCREMENT,
  `duyuruId` int NOT NULL,
  `duyuruAlici_ogrenci` int NOT NULL,
  `ogrenciId` int NOT NULL,
  `duyuruAliciOlusturmaTarihi` datetime(6) NOT NULL,
  PRIMARY KEY (`duyuruAliciId`),
  KEY `IX_DuyuruAlicilar_duyuruId` (`duyuruId`),
  KEY `IX_DuyuruAlicilar_ogrenciId` (`ogrenciId`),
  CONSTRAINT `FK_DuyuruAlicilar_Duyurular_duyuruId` FOREIGN KEY (`duyuruId`) REFERENCES `duyurular` (`duyuruId`) ON DELETE CASCADE,
  CONSTRAINT `FK_DuyuruAlicilar_Ogrenciler_ogrenciId` FOREIGN KEY (`ogrenciId`) REFERENCES `ogrenciler` (`ogrenciId`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `duyurualicilar`
--

LOCK TABLES `duyurualicilar` WRITE;
/*!40000 ALTER TABLE `duyurualicilar` DISABLE KEYS */;
/*!40000 ALTER TABLE `duyurualicilar` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `duyurular`
--

DROP TABLE IF EXISTS `duyurular`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `duyurular` (
  `duyuruId` int NOT NULL AUTO_INCREMENT,
  `duyuruGonderici` int NOT NULL,
  `profesorId` int NOT NULL,
  `duyuruMesaj` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `olusturmaTarihi` datetime(6) NOT NULL,
  PRIMARY KEY (`duyuruId`),
  KEY `IX_Duyurular_profesorId` (`profesorId`),
  CONSTRAINT `FK_Duyurular_Profesorler_profesorId` FOREIGN KEY (`profesorId`) REFERENCES `profesorler` (`profesorId`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `duyurular`
--

LOCK TABLES `duyurular` WRITE;
/*!40000 ALTER TABLE `duyurular` DISABLE KEYS */;
/*!40000 ALTER TABLE `duyurular` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `fakultebolumler`
--

DROP TABLE IF EXISTS `fakultebolumler`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `fakultebolumler` (
  `fakulteBolumId` int NOT NULL AUTO_INCREMENT,
  `fakulteId` int NOT NULL,
  `bolumId` int NOT NULL,
  `olusturmaTarihi` datetime(6) NOT NULL,
  PRIMARY KEY (`fakulteBolumId`),
  UNIQUE KEY `IX_FakulteBolumler_bolumId` (`bolumId`),
  UNIQUE KEY `IX_FakulteBolumler_fakulteId` (`fakulteId`),
  CONSTRAINT `FK_FakulteBolumler_Bolumler_bolumId` FOREIGN KEY (`bolumId`) REFERENCES `bolumler` (`bolumId`) ON DELETE CASCADE,
  CONSTRAINT `FK_FakulteBolumler_Fakulteler_fakulteId` FOREIGN KEY (`fakulteId`) REFERENCES `fakulteler` (`fakulteId`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fakultebolumler`
--

LOCK TABLES `fakultebolumler` WRITE;
/*!40000 ALTER TABLE `fakultebolumler` DISABLE KEYS */;
/*!40000 ALTER TABLE `fakultebolumler` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `fakulteler`
--

DROP TABLE IF EXISTS `fakulteler`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `fakulteler` (
  `fakulteId` int NOT NULL AUTO_INCREMENT,
  `fakulteProfId` int NOT NULL,
  `profesorId` int NOT NULL,
  `fakulteIsim` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `olusturmaTarihi` datetime(6) NOT NULL,
  PRIMARY KEY (`fakulteId`),
  KEY `IX_Fakulteler_profesorId` (`profesorId`),
  CONSTRAINT `FK_Fakulteler_Profesorler_profesorId` FOREIGN KEY (`profesorId`) REFERENCES `profesorler` (`profesorId`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fakulteler`
--

LOCK TABLES `fakulteler` WRITE;
/*!40000 ALTER TABLE `fakulteler` DISABLE KEYS */;
/*!40000 ALTER TABLE `fakulteler` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ogrencidersler`
--

DROP TABLE IF EXISTS `ogrencidersler`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ogrencidersler` (
  `ogrenciDersId` int NOT NULL AUTO_INCREMENT,
  `ogrenciId` int NOT NULL,
  `dersId` int NOT NULL,
  `dersSinavSonuc1` int NOT NULL,
  `dersSinavSonuc2` int NOT NULL,
  `dersFinalSonuc` int NOT NULL,
  `olusturmaTarihi` datetime(6) NOT NULL,
  PRIMARY KEY (`ogrenciDersId`),
  UNIQUE KEY `IX_OgrenciDersler_ogrenciId` (`ogrenciId`),
  KEY `IX_OgrenciDersler_dersId` (`dersId`),
  CONSTRAINT `FK_OgrenciDersler_Dersler_dersId` FOREIGN KEY (`dersId`) REFERENCES `dersler` (`dersId`) ON DELETE CASCADE,
  CONSTRAINT `FK_OgrenciDersler_Ogrenciler_ogrenciId` FOREIGN KEY (`ogrenciId`) REFERENCES `ogrenciler` (`ogrenciId`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ogrencidersler`
--

LOCK TABLES `ogrencidersler` WRITE;
/*!40000 ALTER TABLE `ogrencidersler` DISABLE KEYS */;
/*!40000 ALTER TABLE `ogrencidersler` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ogrenciler`
--

DROP TABLE IF EXISTS `ogrenciler`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ogrenciler` (
  `ogrenciId` int NOT NULL AUTO_INCREMENT,
  `ogrenciMesajId` int NOT NULL,
  `ogrenciDanisman` int NOT NULL,
  `profesorId` int NOT NULL,
  `ogrenciTc` int NOT NULL,
  `ogrenciNo` int NOT NULL,
  `ogrenciDogumTarihi` datetime(6) NOT NULL,
  `ogrenciCinsiyet` tinyint(1) NOT NULL,
  `ogrenciIsim` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `ogrenciSoyad` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `ogrenciParola` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `ogrenciEposta` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `ogrenciBolum` int NOT NULL,
  `bolumId` int NOT NULL,
  `ogrenciOlusturmaTarihi` datetime(6) NOT NULL,
  PRIMARY KEY (`ogrenciId`),
  KEY `IX_Ogrenciler_bolumId` (`bolumId`),
  KEY `IX_Ogrenciler_ogrenciMesajId` (`ogrenciMesajId`),
  KEY `IX_Ogrenciler_profesorId` (`profesorId`),
  CONSTRAINT `FK_Ogrenciler_Bolumler_bolumId` FOREIGN KEY (`bolumId`) REFERENCES `bolumler` (`bolumId`) ON DELETE CASCADE,
  CONSTRAINT `FK_Ogrenciler_ogrenciMesajlar_ogrenciMesajId` FOREIGN KEY (`ogrenciMesajId`) REFERENCES `ogrencimesajlar` (`ogrenciMesajId`) ON DELETE CASCADE,
  CONSTRAINT `FK_Ogrenciler_Profesorler_profesorId` FOREIGN KEY (`profesorId`) REFERENCES `profesorler` (`profesorId`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ogrenciler`
--

LOCK TABLES `ogrenciler` WRITE;
/*!40000 ALTER TABLE `ogrenciler` DISABLE KEYS */;
/*!40000 ALTER TABLE `ogrenciler` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ogrencimesajlar`
--

DROP TABLE IF EXISTS `ogrencimesajlar`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ogrencimesajlar` (
  `ogrenciMesajId` int NOT NULL AUTO_INCREMENT,
  `ogrenciMesajGonderici` int NOT NULL,
  `ogrenciMesajAlici` int NOT NULL,
  `ogrenciMesajMesaj` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `olusturmaTarihi` datetime(6) NOT NULL,
  PRIMARY KEY (`ogrenciMesajId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ogrencimesajlar`
--

LOCK TABLES `ogrencimesajlar` WRITE;
/*!40000 ALTER TABLE `ogrencimesajlar` DISABLE KEYS */;
/*!40000 ALTER TABLE `ogrencimesajlar` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `profesorler`
--

DROP TABLE IF EXISTS `profesorler`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `profesorler` (
  `profesorId` int NOT NULL AUTO_INCREMENT,
  `profesorIsim` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `profesorSoyad` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `profesorParola` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `profesorUnvan` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `profesorEposta` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `profesorOfisAdresi` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `profesorGorusmeSaatleri` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `olusturmaTarihi` datetime(6) NOT NULL,
  PRIMARY KEY (`profesorId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `profesorler`
--

LOCK TABLES `profesorler` WRITE;
/*!40000 ALTER TABLE `profesorler` DISABLE KEYS */;
/*!40000 ALTER TABLE `profesorler` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-02-22 15:31:17
