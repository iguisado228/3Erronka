-- MySQL dump 10.13  Distrib 8.0.38, for Win64 (x86_64)
--
-- Host: 172.16.237.150    Database: erronka3
-- ------------------------------------------------------
-- Server version	8.0.41

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
-- Table structure for table `bazkidea`
--

DROP TABLE IF EXISTS `bazkidea`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bazkidea` (
  `idBazkidea` int NOT NULL AUTO_INCREMENT,
  `NAN` varchar(9) NOT NULL,
  `izena` varchar(20) NOT NULL,
  `abizena` varchar(45) NOT NULL,
  `telefonoa` varchar(9) NOT NULL,
  `helbidea` longtext NOT NULL,
  `identifikadorea` varchar(45) NOT NULL,
  `pasahitza` varchar(29) NOT NULL,
  PRIMARY KEY (`idBazkidea`)
) ENGINE=InnoDB AUTO_INCREMENT=33 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bazkidea`
--

LOCK TABLES `bazkidea` WRITE;
/*!40000 ALTER TABLE `bazkidea` DISABLE KEYS */;
INSERT INTO `bazkidea` VALUES (1,'12345678A','Jon','Etxeberria','688123456','Kale Nagusia 10, Andoain','B1001','pass123'),(2,'23456789B','Ane','Garmendia','622987654','Zumea Plaza 5, Andoain','B1002','secure456'),(3,'34567890C','Mikel','Olabarria','699112233','Arantzibia Kalea 3, Andoain','B1003','mypassword'),(4,'45678901D','Maite','Zuaznabar','666554433','Goiko Plaza 12, Andoain','B1004','maitepass'),(5,'56789012E','Ibai','Urdangarin','644332211','Txistulari Kalea 7, Andoain','B1005','ibaisecret'),(6,'67890123F','Nerea','Bengoetxea','655778899','Etxeberri Kalea 15, Andoain','B1006','nerea789'),(7,'78901234G','Unai','Zubiri','611223344','Sagastialde 8, Andoain','B1007','unai567'),(8,'89012345H','Leire','Mendia','699445566','Aitzol Kalea 2, Andoain','B1008','leirepass'),(9,'90123456I','Iker','Aldasoro','688112233','Larramendi 9, Andoain','B1009','iker321'),(10,'11234567J','Garazi','Lizarralde','677889900','San Juan Plaza 11, Andoain','B1010','garazi987'),(11,'22345678K','Xabier','Otegi','655998877','Pagadi Kalea 4, Andoain','B1011','xabier654'),(12,'33456789L','Maitane','Agirre','644556677','Olagibel 6, Andoain','B1012','maitane111'),(13,'44567890M','Ander','Goikoetxea','688776655','Mendialdea 14, Andoain','B1013','ander999'),(14,'55678901N','Ainhoa','Lizeaga','666332211','Arriaga Plaza 3, Andoain','B1014','ainhoa777'),(15,'66789012O','Gorka','Elorza','611554433','Ezkurralde 10, Andoain','B1015','gorka222'),(16,'77890123P','Oihane','Salaberria','622443322','Etxebeste 5, Andoain','B1016','oihane888'),(17,'88901234Q','Beñat','Iturralde','655223344','Sagastialde 12, Andoain','B1017','benat333'),(18,'99012345R','Irati','Zubizarreta','699667788','Iraola Kalea 7, Andoain','B1018','irati444'),(19,'10123456S','Jokin','Eraso','688990011','Latsunbe Kalea 1, Andoain','B1019','jokin555'),(20,'21234567T','Nahia','Etxezarreta','622889977','Txingudi 9, Andoain','B1020','nahia666'),(21,'32345678U','Markel','Aranburu','699554433','Goikobidea 11, Andoain','B1021','markel777'),(22,'43456789V','Miren','Jauregi','611667788','Lau Haizeta 6, Andoain','B1022','miren888'),(23,'54567890W','Eneko','Zaldua','655990022','Sarriegi Kalea 8, Andoain','B1023','eneko999'),(24,'65678901X','Uxue','Murgiondo','644221133','San Esteban 5, Andoain','B1024','uxue000'),(25,'76789012Y','Hodei','Azkarate','688556677','Larrunbide 10, Andoain','B1025','hodei111'),(26,'87890123Z','Amaia','Urrestarazu','622334455','Muguru Kalea 12, Andoain','B1026','amaia222'),(27,'98901234A','Iñigo','Eguzkitza','699445577','Altzibar 14, Andoain','B1027','iñigo333'),(28,'09012345B','Olatz','Aranguren','688667788','Zarategi Kalea 6, Andoain','B1028','olatz444'),(29,'10123456C','Xanti','Arrillaga','611778899','Mutiloa Kalea 7, Andoain','B1029','xanti555'),(30,'21234567D','Lide','Berasategi','644889900','Zaldibar Kalea 3, Andoain','B1030','lide666'),(31,'34364283Y','Hodei','Etxeberria','676445299','Aita Larramendi Kalea','Hodetxe','1234');
/*!40000 ALTER TABLE `bazkidea` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `bazkideaAldaketa` AFTER UPDATE ON `bazkidea` FOR EACH ROW BEGIN

INSERT INTO erronka3.bazkideahistorikoa ( idBazkidea, NAN, izena, abizena, telefonoa, helbidea, identifikadorea, pasahitza, aldaketa_mota )

VALUES ( OLD.idBazkidea, OLD.NAN, OLD.izena, OLD.abizena, OLD.telefonoa, OLD.helbidea, OLD.identifikadorea, OLD.pasahitza, 'UPDATE');

END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `ezabatuBazkidea` BEFORE DELETE ON `bazkidea` FOR EACH ROW BEGIN

INSERT INTO erronka3.bazkideahistorikoa ( idBazkidea, NAN, izena, abizena, telefonoa, helbidea, identifikadorea, pasahitza, aldaketa_mota )

VALUES ( OLD.idBazkidea, OLD.NAN, OLD.izena, OLD.abizena, OLD.telefonoa, OLD.helbidea, OLD.identifikadorea, OLD.pasahitza, 'DELETE');

END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `bazkideahistorikoa`
--

DROP TABLE IF EXISTS `bazkideahistorikoa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bazkideahistorikoa` (
  `idBazkidea` int DEFAULT NULL,
  `NAN` varchar(9) DEFAULT NULL,
  `izena` varchar(20) DEFAULT NULL,
  `abizena` varchar(45) DEFAULT NULL,
  `telefonoa` varchar(9) DEFAULT NULL,
  `helbidea` longtext,
  `identifikadorea` varchar(45) DEFAULT NULL,
  `pasahitza` varchar(20) DEFAULT NULL,
  `aldaketa_data` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `aldaketa_mota` enum('UPDATE','DELETE') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bazkideahistorikoa`
--

LOCK TABLES `bazkideahistorikoa` WRITE;
/*!40000 ALTER TABLE `bazkideahistorikoa` DISABLE KEYS */;
INSERT INTO `bazkideahistorikoa` VALUES (1,'12345678A','Jon','Etxeberria','688123456','Kale Nagusia 10, Andoain','B-1001','pass123','2025-03-24 09:09:07','UPDATE'),(2,'23456789B','Ane','Garmendia','622987654','Zumea Plaza 5, Andoain','B-1002','secure456','2025-03-24 09:09:07','UPDATE'),(3,'34567890C','Mikel','Olabarria','699112233','Arantzibia Kalea 3, Andoain','B-1003','mypassword','2025-03-24 09:09:07','UPDATE'),(4,'45678901D','Maite','Zuaznabar','666554433','Goiko Plaza 12, Andoain','B-1004','maitepass','2025-03-24 09:09:07','UPDATE'),(5,'56789012E','Ibai','Urdangarin','644332211','Txistulari Kalea 7, Andoain','B-1005','ibaisecret','2025-03-24 09:09:07','UPDATE'),(6,'67890123F','Nerea','Bengoetxea','655778899','Etxeberri Kalea 15, Andoain','B-1006','nerea789','2025-03-24 09:09:07','UPDATE'),(7,'78901234G','Unai','Zubiri','611223344','Sagastialde 8, Andoain','B-1007','unai567','2025-03-24 09:09:07','UPDATE'),(8,'89012345H','Leire','Mendia','699445566','Aitzol Kalea 2, Andoain','B-1008','leirepass','2025-03-24 09:09:07','UPDATE'),(9,'90123456I','Iker','Aldasoro','688112233','Larramendi 9, Andoain','B-1009','iker321','2025-03-24 09:09:07','UPDATE'),(10,'11234567J','Garazi','Lizarralde','677889900','San Juan Plaza 11, Andoain','B-1010','garazi987','2025-03-24 09:09:07','UPDATE'),(11,'22345678K','Xabier','Otegi','655998877','Pagadi Kalea 4, Andoain','B-1011','xabier654','2025-03-24 09:09:07','UPDATE'),(12,'33456789L','Maitane','Agirre','644556677','Olagibel 6, Andoain','B-1012','maitane111','2025-03-24 09:09:07','UPDATE'),(13,'44567890M','Ander','Goikoetxea','688776655','Mendialdea 14, Andoain','B-1013','ander999','2025-03-24 09:09:07','UPDATE'),(14,'55678901N','Ainhoa','Lizeaga','666332211','Arriaga Plaza 3, Andoain','B-1014','ainhoa777','2025-03-24 09:09:07','UPDATE'),(15,'66789012O','Gorka','Elorza','611554433','Ezkurralde 10, Andoain','B-1015','gorka222','2025-03-24 09:09:07','UPDATE'),(16,'77890123P','Oihane','Salaberria','622443322','Etxebeste 5, Andoain','B-1016','oihane888','2025-03-24 09:09:07','UPDATE'),(17,'88901234Q','Beñat','Iturralde','655223344','Sagastialde 12, Andoain','B-1017','benat333','2025-03-24 09:09:07','UPDATE'),(18,'99012345R','Irati','Zubizarreta','699667788','Iraola Kalea 7, Andoain','B-1018','irati444','2025-03-24 09:09:07','UPDATE'),(19,'10123456S','Jokin','Eraso','688990011','Latsunbe Kalea 1, Andoain','B-1019','jokin555','2025-03-24 09:09:07','UPDATE'),(20,'21234567T','Nahia','Etxezarreta','622889977','Txingudi 9, Andoain','B-1020','nahia666','2025-03-24 09:09:07','UPDATE'),(21,'32345678U','Markel','Aranburu','699554433','Goikobidea 11, Andoain','B-1021','markel777','2025-03-24 09:09:07','UPDATE'),(22,'43456789V','Miren','Jauregi','611667788','Lau Haizeta 6, Andoain','B-1022','miren888','2025-03-24 09:09:07','UPDATE'),(23,'54567890W','Eneko','Zaldua','655990022','Sarriegi Kalea 8, Andoain','B-1023','eneko999','2025-03-24 09:09:07','UPDATE'),(24,'65678901X','Uxue','Murgiondo','644221133','San Esteban 5, Andoain','B-1024','uxue000','2025-03-24 09:09:07','UPDATE'),(25,'76789012Y','Hodei','Azkarate','688556677','Larrunbide 10, Andoain','B-1025','hodei111','2025-03-24 09:09:07','UPDATE'),(26,'87890123Z','Amaia','Urrestarazu','622334455','Muguru Kalea 12, Andoain','B-1026','amaia222','2025-03-24 09:09:07','UPDATE'),(27,'98901234A','Iñigo','Eguzkitza','699445577','Altzibar 14, Andoain','B-1027','iñigo333','2025-03-24 09:09:07','UPDATE'),(28,'09012345B','Olatz','Aranguren','688667788','Zarategi Kalea 6, Andoain','B-1028','olatz444','2025-03-24 09:09:07','UPDATE'),(30,'21234567D','Lide','Berasategi','644889900','Zaldibar Kalea 3, Andoain','B-1030','lide666','2025-03-24 09:09:07','UPDATE'),(29,'10123456C','Xanti','Arrillaga','611778899','Mutiloa Kalea 7, Andoain','B-1029','xanti555','2025-03-24 09:09:07','UPDATE'),(32,'a','a','a','a','a','a','a','2025-04-01 07:31:12','UPDATE'),(32,'b','b','b','b','b','b','b','2025-04-01 07:31:40','DELETE');
/*!40000 ALTER TABLE `bazkideahistorikoa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `eremua`
--

DROP TABLE IF EXISTS `eremua`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `eremua` (
  `idEremua` int NOT NULL AUTO_INCREMENT,
  `izena` varchar(45) DEFAULT NULL,
  `gehienezkoAforoa` int DEFAULT NULL,
  `azalera` double DEFAULT NULL,
  PRIMARY KEY (`idEremua`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `eremua`
--

LOCK TABLES `eremua` WRITE;
/*!40000 ALTER TABLE `eremua` DISABLE KEYS */;
INSERT INTO `eremua` VALUES (1,'Gimnasioa',50,300),(2,'Futbol-zelaiak',500,7000),(3,'Igerileku estalia',100,500),(4,'Tenis-zelaiak',40,1200),(5,'Eskubaloi-pista',100,800),(6,'Saskibaloi-pista',100,800),(7,'Atletismo-pista',200,5000),(8,'Kanpoko saskibaloi-pista',150,1200),(9,'Kanpoko eskubaloi-pista',150,1200);
/*!40000 ALTER TABLE `eremua` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `eremuaAldaketa` AFTER UPDATE ON `eremua` FOR EACH ROW BEGIN

INSERT INTO erronka3.eremuahistorikoa ( idEremua, izena, gehienezkoAforoa, azalera, aldaketa_mota )

VALUES ( OLD.idEremua, OLD.izena, OLD.gehienezkoAforoa, OLD.azalera, 'UPDATE');

END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `ezabatuEremua` BEFORE DELETE ON `eremua` FOR EACH ROW BEGIN

INSERT INTO erronka3.eremuahistorikoa ( idEremua, izena, gehienezkoAforoa, azalera, aldaketa_mota )

VALUES ( OLD.idEremua, OLD.izena, OLD.gehienezkoAforoa, OLD.azalera, 'DELETE');

END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `eremuahistorikoa`
--

DROP TABLE IF EXISTS `eremuahistorikoa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `eremuahistorikoa` (
  `idEremua` int DEFAULT NULL,
  `izena` varchar(45) DEFAULT NULL,
  `gehienezkoAforoa` int DEFAULT NULL,
  `azalera` double DEFAULT NULL,
  `aldaketa_data` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `aldaketa_mota` enum('UPDATE','DELETE') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `eremuahistorikoa`
--

LOCK TABLES `eremuahistorikoa` WRITE;
/*!40000 ALTER TABLE `eremuahistorikoa` DISABLE KEYS */;
INSERT INTO `eremuahistorikoa` VALUES (10,'abi',2,2,'2025-04-01 07:35:34','UPDATE'),(10,'hodetxe',3,6,'2025-04-01 07:36:06','DELETE');
/*!40000 ALTER TABLE `eremuahistorikoa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `erreserba`
--

DROP TABLE IF EXISTS `erreserba`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `erreserba` (
  `idErreserba` int NOT NULL AUTO_INCREMENT,
  `idEremua` int NOT NULL,
  `idBazkidea` int DEFAULT NULL,
  `idKluba` int DEFAULT NULL,
  `erreserbaEguna` date NOT NULL,
  `hasieraOrdua` varchar(45) DEFAULT NULL,
  `amaieraOrdua` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idErreserba`),
  KEY `fk_erreserba_bazkidea1_idx` (`idBazkidea`),
  KEY `fk_erreserba_kluba1_idx` (`idKluba`),
  KEY `fk_erreserba_eremua1_idx` (`idEremua`),
  CONSTRAINT `fk_erreserba_bazkidea1` FOREIGN KEY (`idBazkidea`) REFERENCES `bazkidea` (`idBazkidea`),
  CONSTRAINT `fk_erreserba_eremua1` FOREIGN KEY (`idEremua`) REFERENCES `eremua` (`idEremua`),
  CONSTRAINT `fk_erreserba_kluba1` FOREIGN KEY (`idKluba`) REFERENCES `kluba` (`idKluba`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `erreserba`
--

LOCK TABLES `erreserba` WRITE;
/*!40000 ALTER TABLE `erreserba` DISABLE KEYS */;
/*!40000 ALTER TABLE `erreserba` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `erreserbaAldaketa` AFTER UPDATE ON `erreserba` FOR EACH ROW BEGIN

INSERT INTO erronka3.erreserbahistorikoa ( idErreserba, idEremua, idBazkidea, idKluba, erreserbaEguna, hasieraOrdua, amaieraOrdua, aldaketa_mota )

VALUES ( OLD.idErreserba, OLD.idEremua, OLD.idBazkidea, OLD.idKluba, OLD.erreserbaEguna, old.hasieraOrdua, old.amaieraOrdua, 'UPDATE');

END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `ezabatuErreserba` BEFORE DELETE ON `erreserba` FOR EACH ROW BEGIN

INSERT INTO erronka3.erreserbahistorikoa ( idErreserba, idEremua, idBazkidea, idKluba, erreserbaEguna, hasieraOrdua, amaieraOrdua, aldaketa_mota )

VALUES ( OLD.idErreserba, OLD.idEremua, OLD.idBazkidea, OLD.idKluba, OLD.erreserbaEguna, old.hasieraOrdua, old.amaieraOrdua, 'DELETE');

END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `erreserbahistorikoa`
--

DROP TABLE IF EXISTS `erreserbahistorikoa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `erreserbahistorikoa` (
  `idErreserba` int DEFAULT NULL,
  `idEremua` int DEFAULT NULL,
  `idBazkidea` int DEFAULT NULL,
  `idKluba` int DEFAULT NULL,
  `erreserbaEguna` date DEFAULT NULL,
  `aldaketa_data` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `aldaketa_mota` enum('UPDATE','DELETE') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `erreserbahistorikoa`
--

LOCK TABLES `erreserbahistorikoa` WRITE;
/*!40000 ALTER TABLE `erreserbahistorikoa` DISABLE KEYS */;
/*!40000 ALTER TABLE `erreserbahistorikoa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `hornitzailea`
--

DROP TABLE IF EXISTS `hornitzailea`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `hornitzailea` (
  `idHornitzailea` int NOT NULL AUTO_INCREMENT,
  `CIF` varchar(9) DEFAULT NULL,
  `izena` varchar(45) DEFAULT NULL,
  `telefonoa` varchar(9) DEFAULT NULL,
  `helbidea` longtext,
  PRIMARY KEY (`idHornitzailea`)
) ENGINE=InnoDB AUTO_INCREMENT=61 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hornitzailea`
--

LOCK TABLES `hornitzailea` WRITE;
/*!40000 ALTER TABLE `hornitzailea` DISABLE KEYS */;
INSERT INTO `hornitzailea` VALUES (31,'A20000123','Uranzu Kirol S.L.','943112233','Irun, Gipuzkoa'),(32,'A20000456','Ekipamendu Deportivoak S.A.','943223344','Donostia, Gipuzkoa'),(33,'A20000789','Bidasoa Material Kirolak','943334455','Hondarribia, Gipuzkoa'),(34,'A20001234','Goierri Sport S.L.','943445566','Beasain, Gipuzkoa'),(35,'A20001567','Tolosaldea Kirol Hornikuntza','943556677','Tolosa, Gipuzkoa'),(36,'A20001890','Debagoiena Fitness S.L.','943667788','Arrasate, Gipuzkoa'),(37,'A20002222','Oarsoaldea Kirolak','943778899','Errenteria, Gipuzkoa'),(38,'A20002555','Bertan Sport Hornikuntza','943889900','Eibar, Gipuzkoa'),(39,'A20002888','Zarautz Surf eta Kirol','943990011','Zarautz, Gipuzkoa'),(40,'A20003111','Buruntzaldea Kirol Ekipamendua','943101112','Andoain, Gipuzkoa'),(41,'A20003444','Donosti Sport Hornitzailea','943212223','Donostia, Gipuzkoa'),(42,'A20003777','Altzibar Kirol Ekipamendua','943323334','Oiartzun, Gipuzkoa'),(43,'A20004000','Elgoibar Kirol Hornitzaileak','943434445','Elgoibar, Gipuzkoa'),(44,'A20004333','Legazpi Kirol Market','943545556','Legazpi, Gipuzkoa'),(45,'A20004666','Hernani Sport Ekipamendua','943656667','Hernani, Gipuzkoa'),(46,'A20004999','Mutriku Kirol Zerbitzuak','943767778','Mutriku, Gipuzkoa'),(47,'A20005222','Azpeitia Kirol Hornikuntza','943878889','Azpeitia, Gipuzkoa'),(48,'A20005555','Bergara Kirol Materiala','943989900','Bergara, Gipuzkoa'),(49,'A20005888','Lasarte-Oria Fitness','943101213','Lasarte-Oria, Gipuzkoa'),(50,'A20006111','Urretxu Sport Ekipamendua','943212324','Urretxu, Gipuzkoa'),(51,'A20006444','Andoain Kirol Materialak','943323435','Andoain, Gipuzkoa'),(52,'A20006777','Zumaia Kirol Zerbitzuak','943434546','Zumaia, Gipuzkoa'),(53,'A20007000','Beasain Kirol Store','943545657','Beasain, Gipuzkoa'),(54,'A20007333','Oiartzun Kirolak S.L.','943656768','Oiartzun, Gipuzkoa'),(55,'A20007666','Errenteria Kirol Hornitzaileak','943767879','Errenteria, Gipuzkoa'),(56,'A20007999','Orio Kirolak eta Surf','943878990','Orio, Gipuzkoa'),(57,'A20008222','Deba Kirol Ekipamendua','943989101','Deba, Gipuzkoa'),(58,'A20008555','Tolosa Kirol Denda','943101212','Tolosa, Gipuzkoa'),(59,'A20008888','Eibar Fitness Hornikuntza','943212323','Eibar, Gipuzkoa'),(60,'A20009111','Zarautz Sport Equipment','943323434','Zarautz, Gipuzkoa');
/*!40000 ALTER TABLE `hornitzailea` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `hornitzaileaAldaketa` AFTER UPDATE ON `hornitzailea` FOR EACH ROW BEGIN

INSERT INTO erronka3.hornitzaileahistorikoa ( idHornitzailea, CIF, izena, telefonoa, helbidea, aldaketa_mota )

VALUES ( OLD.idHornitzailea, OLD.CIF, OLD.izena, OLD.telefonoa, OLD.helbidea, 'UPDATE');

END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `ezabatuHornitzailea` BEFORE DELETE ON `hornitzailea` FOR EACH ROW BEGIN

INSERT INTO erronka3.hornitzaileahistorikoa ( idHornitzailea, CIF, izena, telefonoa, helbidea, aldaketa_mota )

VALUES ( OLD.idHornitzailea, OLD.CIF, OLD.izena, OLD.telefonoa, OLD.helbidea, 'DELETE');

END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `hornitzaileahistorikoa`
--

DROP TABLE IF EXISTS `hornitzaileahistorikoa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `hornitzaileahistorikoa` (
  `idHornitzailea` int DEFAULT NULL,
  `CIF` varchar(9) DEFAULT NULL,
  `izena` varchar(45) DEFAULT NULL,
  `telefonoa` varchar(9) DEFAULT NULL,
  `helbidea` longtext,
  `aldaketa_data` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `aldaketa_mota` enum('UPDATE','DELETE') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hornitzaileahistorikoa`
--

LOCK TABLES `hornitzaileahistorikoa` WRITE;
/*!40000 ALTER TABLE `hornitzaileahistorikoa` DISABLE KEYS */;
/*!40000 ALTER TABLE `hornitzaileahistorikoa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `kluba`
--

DROP TABLE IF EXISTS `kluba`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `kluba` (
  `idKluba` int NOT NULL AUTO_INCREMENT,
  `identifikadorea` varchar(45) NOT NULL,
  `pasahitza` varchar(20) NOT NULL,
  `izena` varchar(45) NOT NULL,
  `kirola` varchar(45) NOT NULL,
  `jokalariKopurua` int NOT NULL,
  `taldeKopurua` int NOT NULL,
  PRIMARY KEY (`idKluba`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `kluba`
--

LOCK TABLES `kluba` WRITE;
/*!40000 ALTER TABLE `kluba` DISABLE KEYS */;
INSERT INTO `kluba` VALUES (1,'K2001','Euskalduna1923!','S.D. Euskalduna Andoaindarra','Futbola',150,5),(2,'K2002','LeizaranEskubaloi!','C.D.B. Leizaran','Eskubaloia',90,3),(3,'K2003','GanbaraSaski!','Ganbara Saskibaloi K.T.','Saskibaloia',120,4),(4,'K2004','123Zurrut!','Zumeatarra Kirol Elkartea','Atletismoa',110,4),(5,'K2005','EuskaldunMendi!','Zurrut S.K.T','Saskibaloia',25,2),(6,'K2006','Txirrindularitza!','Andoaingo Txirrindulari Eskola','Txirrindularitza',70,2),(7,'K2007','LeitzKultura!','Leitz Kirola eta Kultura Elkartea','Kultura eta Kirola',60,2),(8,'K2008','JudoAndoain!','Judo Club Andoain','Judoa',50,2),(9,'K2009','GaztePilota!','Gazteleku Pilota Elkartea','Pilota',40,2),(10,'K2010','IgeriBuruntza!','Buruntzaldea Igeriketa Kirol Taldea','Igeriketa',30,1);
/*!40000 ALTER TABLE `kluba` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `klubaAldaketa` AFTER UPDATE ON `kluba` FOR EACH ROW BEGIN

INSERT INTO erronka3.klubahistorikoa ( idKluba, identifikadorea, pasahitza, izena, kirola, jokalariKopurua, taldeKopurua, aldaketa_mota )

VALUES ( OLD.idKluba, OLD.identifikadorea, OLD.pasahitza, OLD.izena, OLD.kirola, old.jokalariKopurua, old.taldeKopurua, 'UPDATE');

END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `ezabatuKluba` BEFORE DELETE ON `kluba` FOR EACH ROW BEGIN

INSERT INTO erronka3.klubahistorikoa ( idKluba, identifikadorea, pasahitza, izena, kirola, jokalariKopurua, taldeKopurua, aldaketa_mota )

VALUES ( OLD.idKluba, OLD.identifikadorea, OLD.pasahitza, OLD.izena, OLD.kirola, old.jokalariKopurua, old.taldeKopurua, 'DELETE');

END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `klubahistorikoa`
--

DROP TABLE IF EXISTS `klubahistorikoa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `klubahistorikoa` (
  `idKluba` int DEFAULT NULL,
  `identifikadorea` varchar(45) DEFAULT NULL,
  `pasahitza` varchar(20) DEFAULT NULL,
  `izena` varchar(45) DEFAULT NULL,
  `kirola` varchar(45) DEFAULT NULL,
  `jokalariKopurua` int DEFAULT NULL,
  `taldeKopurua` int DEFAULT NULL,
  `aldaketa_data` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `aldaketa_mota` enum('UPDATE','DELETE') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `klubahistorikoa`
--

LOCK TABLES `klubahistorikoa` WRITE;
/*!40000 ALTER TABLE `klubahistorikoa` DISABLE KEYS */;
INSERT INTO `klubahistorikoa` VALUES (1,'K-2001','Euskalduna1923!',NULL,'Futbola',150,5,'2025-03-24 09:09:55','UPDATE'),(2,'K-2002','LeizaranEskubaloi!',NULL,'Eskubaloia',90,3,'2025-03-24 09:09:55','UPDATE'),(3,'K-2003','GanbaraSaski!',NULL,'Saskibaloia',120,4,'2025-03-24 09:09:55','UPDATE'),(4,'K-2004','123Zurrut!',NULL,'Atletismoa',110,4,'2025-03-24 09:09:55','UPDATE'),(5,'K-2005','EuskaldunMendi!',NULL,'Saskibaloia',25,2,'2025-03-24 09:09:55','UPDATE'),(6,'K-2006','Txirrindularitza!',NULL,'Txirrindularitza',70,2,'2025-03-24 09:09:55','UPDATE'),(7,'K-2007','LeitzKultura!',NULL,'Kultura eta Kirola',60,2,'2025-03-24 09:09:55','UPDATE'),(8,'K-2008','JudoAndoain!',NULL,'Judoa',50,2,'2025-03-24 09:09:55','UPDATE'),(9,'K-2009','GaztePilota!',NULL,'Pilota',40,2,'2025-03-24 09:09:55','UPDATE'),(10,'K-2010','IgeriBuruntza!',NULL,'Igeriketa',30,1,'2025-03-24 09:09:55','UPDATE');
/*!40000 ALTER TABLE `klubahistorikoa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `langilea`
--

DROP TABLE IF EXISTS `langilea`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `langilea` (
  `idLangilea` int NOT NULL AUTO_INCREMENT,
  `NAN` varchar(9) NOT NULL,
  `izena` varchar(20) NOT NULL,
  `abizena` varchar(45) NOT NULL,
  `telefonoa` varchar(9) NOT NULL,
  `helbidea` longtext NOT NULL,
  `lanpostua` varchar(45) DEFAULT NULL,
  `identifikadorea` varchar(45) NOT NULL,
  `pasahitza` varchar(20) NOT NULL,
  PRIMARY KEY (`idLangilea`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `langilea`
--

LOCK TABLES `langilea` WRITE;
/*!40000 ALTER TABLE `langilea` DISABLE KEYS */;
INSERT INTO `langilea` VALUES (1,'12345678A','Iker','Lopez','612345678','Andoaingo Euskadi Kalea, 5','Harrerako langilea','L-1001','pasahitza123'),(2,'12345679B','Ane','Garcia','612345679','Andoaingo San Pedro Kalea, 2','Harrerako langilea','L-1002','pasahitza456'),(3,'12345680C','Jon','Martinez','612345680','Andoaingo Zarautz Kalea, 8','Zaindaria','L-1003','pasahitza789'),(4,'12345681D','Mikel','Sanchez','612345681','Andoaingo Gipuzkoa Kalea, 12','Harrerako langilea','L-1004','pasahitza101'),(5,'12345682E','Nerea','Perez','612345682','Andoaingo Donostia Kalea, 7','Zaindaria','L-1005','pasahitza202'),(6,'12345683F','Aitor','Zubia','612345683','Andoaingo Iparralde Kalea, 4','Batzorde-txartela','L-1006','pasahitza303'),(7,'12345684G','Oihana','Ramirez','612345684','Andoaingo Errekalde Kalea, 3','Harrerako langilea','L-1007','pasahitza404'),(8,'12345685H','Gorka','Lopez','612345685','Andoaingo Ondarreta Kalea, 9','Zaindaria','L-1008','pasahitza505'),(9,'12345686I','Ane','Gonzalez','612345686','Andoaingo Kalero Kalea, 5','Batzorde-txartela','L-1009','pasahitza606'),(10,'12345687J','Iker','Martinez','612345687','Andoaingo Urumea Kalea, 6','Harrerako langilea','L-1010','pasahitza707'),(11,'12345688K','Julen','Salazar','612345688','Andoaingo Artza Kalea, 4','Zaindaria','L-1011','pasahitza808'),(12,'12345689L','Oihane','Zubizarreta','612345689','Andoaingo Aizkibel Kalea, 10','Batzorde-txartela','L-1012','pasahitza909'),(13,'12345690M','Mikel','Gomez','612345690','Andoaingo Benta Kalea, 8','Harrerako langilea','L-1013','pasahitza112'),(14,'12345691N','Ander','Arrieta','612345691','Andoaingo Iparralde Kalea, 7','Zaindaria','L-1014','pasahitza223'),(15,'12345692O','Leire','Gonzalez','612345692','Andoaingo Aizpurua Kalea, 6','Batzorde-txartela','L-1015','L-L-1015!2024');
/*!40000 ALTER TABLE `langilea` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `langileaAldaketa` AFTER UPDATE ON `langilea` FOR EACH ROW BEGIN

INSERT INTO erronka3.langileahistorikoa ( idLangilea, NAN, izena, abizena, telefonoa, helbidea, lanpostua, identifikadorea, pasahitza, aldaketa_mota )

VALUES ( OLD.idLangilea, OLD.NAN, OLD.izena, OLD.abizena, OLD.telefonoa, old.helbidea, old.lanpostua, old.identifikadorea, old.pasahitza, 'UPDATE');

END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `ezabatuLangilea` BEFORE DELETE ON `langilea` FOR EACH ROW BEGIN

INSERT INTO erronka3.langileahistorikoa ( idLangilea, NAN, izena, abizena, telefonoa, helbidea, lanpostua, identifikadorea, pasahitza, aldaketa_mota )

VALUES ( OLD.idLangilea, OLD.NAN, OLD.izena, OLD.abizena, OLD.telefonoa, old.helbidea, old.lanpostua, old.identifikadorea, old.pasahitza, 'DELETE');

END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `langileahistorikoa`
--

DROP TABLE IF EXISTS `langileahistorikoa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `langileahistorikoa` (
  `idLangilea` int DEFAULT NULL,
  `NAN` varchar(9) DEFAULT NULL,
  `izena` varchar(20) DEFAULT NULL,
  `abizena` varchar(45) DEFAULT NULL,
  `telefonoa` varchar(9) DEFAULT NULL,
  `helbidea` longtext,
  `lanpostua` varchar(45) DEFAULT NULL,
  `identifikadorea` varchar(45) DEFAULT NULL,
  `pasahitza` varchar(20) DEFAULT NULL,
  `aldaketa_data` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `aldaketa_mota` enum('UPDATE','DELETE') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `langileahistorikoa`
--

LOCK TABLES `langileahistorikoa` WRITE;
/*!40000 ALTER TABLE `langileahistorikoa` DISABLE KEYS */;
/*!40000 ALTER TABLE `langileahistorikoa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mantenua`
--

DROP TABLE IF EXISTS `mantenua`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `mantenua` (
  `idMantenua` int NOT NULL AUTO_INCREMENT,
  `idLangilea` int NOT NULL,
  `idEremua` int NOT NULL,
  `mota` longtext NOT NULL,
  `data` date NOT NULL,
  `egoera` enum('berrikusten','konpontzen','konponduta') NOT NULL,
  `beharrekoa` varchar(45) NOT NULL,
  PRIMARY KEY (`idMantenua`),
  KEY `fk_mantenua_langilea1_idx` (`idLangilea`),
  KEY `fk_mantenua_eremua1_idx` (`idEremua`),
  CONSTRAINT `fk_mantenua_eremua1` FOREIGN KEY (`idEremua`) REFERENCES `eremua` (`idEremua`),
  CONSTRAINT `fk_mantenua_langilea1` FOREIGN KEY (`idLangilea`) REFERENCES `langilea` (`idLangilea`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mantenua`
--

LOCK TABLES `mantenua` WRITE;
/*!40000 ALTER TABLE `mantenua` DISABLE KEYS */;
/*!40000 ALTER TABLE `mantenua` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `mantenuaAldaketa` AFTER UPDATE ON `mantenua` FOR EACH ROW BEGIN

INSERT INTO erronka3.mantenuahistorikoa ( idMantenua, idLangilea, idEremua, mota, data, egoera, beharrekoa, aldaketa_mota )

VALUES ( OLD.idMantenua, OLD.idLangilea, OLD.idEremua, OLD.mota, OLD.data, old.egoera, old.beharrekoa, 'UPDATE');

END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `ezabatuMantenua` BEFORE DELETE ON `mantenua` FOR EACH ROW BEGIN

INSERT INTO erronka3.mantenuahistorikoa ( idMantenua, idLangilea, idEremua, mota, data, egoera, beharrekoa, aldaketa_mota )

VALUES ( OLD.idMantenua, OLD.idLangilea, OLD.idEremua, OLD.mota, OLD.data, old.egoera, old.beharrekoa, 'DELETE');

END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `mantenuahistorikoa`
--

DROP TABLE IF EXISTS `mantenuahistorikoa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `mantenuahistorikoa` (
  `idMantenua` int DEFAULT NULL,
  `idLangilea` int DEFAULT NULL,
  `idEremua` int DEFAULT NULL,
  `mota` longtext,
  `data` date DEFAULT NULL,
  `egoera` enum('berrikusten','konpontzen','konponduta') DEFAULT 'berrikusten',
  `beharrekoa` varchar(45) DEFAULT NULL,
  `aldaketa_data` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `aldaketa_mota` enum('UPDATE','DELETE') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mantenuahistorikoa`
--

LOCK TABLES `mantenuahistorikoa` WRITE;
/*!40000 ALTER TABLE `mantenuahistorikoa` DISABLE KEYS */;
/*!40000 ALTER TABLE `mantenuahistorikoa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `materiala`
--

DROP TABLE IF EXISTS `materiala`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `materiala` (
  `idMateriala` int NOT NULL AUTO_INCREMENT,
  `idHornitzailea` int NOT NULL,
  `idEremua` int NOT NULL,
  `izena` varchar(45) NOT NULL,
  `data` date NOT NULL,
  `prezioa` double NOT NULL,
  PRIMARY KEY (`idMateriala`),
  KEY `fk_materiala_hornitzailea1_idx` (`idHornitzailea`),
  KEY `fk_materiala_eremua1_idx` (`idEremua`),
  CONSTRAINT `fk_materiala_eremua1` FOREIGN KEY (`idEremua`) REFERENCES `eremua` (`idEremua`),
  CONSTRAINT `fk_materiala_hornitzailea1` FOREIGN KEY (`idHornitzailea`) REFERENCES `hornitzailea` (`idHornitzailea`)
) ENGINE=InnoDB AUTO_INCREMENT=93 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `materiala`
--

LOCK TABLES `materiala` WRITE;
/*!40000 ALTER TABLE `materiala` DISABLE KEYS */;
INSERT INTO `materiala` VALUES (63,60,1,'Saskibaloi-baloia','2024-11-15',20),(64,31,1,'Eskubaloi-baloia','2023-06-10',15),(65,32,2,'Futbol-baloia','2022-09-05',25),(66,33,2,'Futbol-zelaiaren sarea','2023-12-20',50),(67,34,3,'Igerilekuaren flotagailua','2021-05-14',10),(68,35,3,'Igerilekuko eguzki-armairua','2022-07-18',30),(69,36,4,'Teniseko raketa','2022-03-22',35),(70,37,4,'Tenis-pelota','2023-02-10',5),(71,38,5,'Eskubaloi-baloi','2024-01-15',15),(72,39,5,'Eskubaloiaren sarea','2023-11-01',45),(73,40,6,'Saskibaloi-baloia','2024-03-10',20),(74,41,6,'Saskibaloi-uztaila','2022-10-25',150),(75,42,7,'Atletismo-hesiak','2021-09-30',80),(76,43,7,'Atletismo-zapatilak','2023-05-05',60),(77,44,8,'Saskibaloi-baloia','2023-06-19',20),(78,45,8,'Saskibaloi-sarea','2022-04-12',40),(79,46,9,'Eskubaloi-baloia','2023-08-23',15),(80,47,9,'Eskubaloi-sarea','2021-11-30',45),(81,48,1,'Eskubaloi-baloia','2020-12-10',15),(82,49,1,'Markagailu elektronikoa','2024-01-18',120),(83,50,2,'Futbol-baloia','2023-03-05',25),(84,51,2,'Futbol-zelaiaren sarea','2022-08-21',60),(85,52,3,'Igerilekuko txalekoa','2022-05-14',8),(86,53,3,'Igerileku-flotagailua','2024-07-02',10),(87,54,4,'Teniseko sarea','2021-10-03',40),(88,55,4,'Tenis-pelota','2020-06-01',5),(89,56,5,'Eskubaloi-baloia','2022-02-19',15),(90,57,5,'Eskubaloi-sarea','2023-07-12',45),(91,58,6,'Saskibaloi-baloia','2023-04-25',20),(92,59,6,'Saskibaloi-arokoa','2021-09-15',150);
/*!40000 ALTER TABLE `materiala` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `materialaAldaketa` AFTER UPDATE ON `materiala` FOR EACH ROW BEGIN

INSERT INTO erronka3.materialahistorikoa ( idMateriala, idHornitzailea, idEremua, izena, data, prezioa, aldaketa_mota )

VALUES ( OLD.idMateriala, OLD.idHornitzailea, OLD.idEremua, OLD.izena, OLD.data, old.prezioa, 'UPDATE');

END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `ezabatuMateriala` BEFORE DELETE ON `materiala` FOR EACH ROW BEGIN

INSERT INTO erronka3.materialahistorikoa ( idMateriala, idHornitzailea, idEremua, izena, data, prezioa, aldaketa_mota )

VALUES ( OLD.idMateriala, OLD.idHornitzailea, OLD.idEremua, OLD.izena, OLD.data, old.prezioa, 'DELETE');

END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `materialahistorikoa`
--

DROP TABLE IF EXISTS `materialahistorikoa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `materialahistorikoa` (
  `idMateriala` int DEFAULT NULL,
  `idHornitzailea` int DEFAULT NULL,
  `idEremua` int DEFAULT NULL,
  `izena` varchar(45) DEFAULT NULL,
  `data` date DEFAULT NULL,
  `prezioa` double DEFAULT NULL,
  `aldaketa_data` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `aldaketa_mota` enum('UPDATE','DELETE') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `materialahistorikoa`
--

LOCK TABLES `materialahistorikoa` WRITE;
/*!40000 ALTER TABLE `materialahistorikoa` DISABLE KEYS */;
/*!40000 ALTER TABLE `materialahistorikoa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sarrera`
--

DROP TABLE IF EXISTS `sarrera`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sarrera` (
  `idSarrera` int NOT NULL AUTO_INCREMENT,
  `idLangilea` int NOT NULL,
  `idEremua` int NOT NULL,
  `prezioa` double NOT NULL,
  PRIMARY KEY (`idSarrera`),
  KEY `fk_sarrera_langilea_idx` (`idLangilea`),
  KEY `fk_sarrera_eremua1_idx` (`idEremua`),
  CONSTRAINT `fk_sarrera_eremua1` FOREIGN KEY (`idEremua`) REFERENCES `eremua` (`idEremua`),
  CONSTRAINT `fk_sarrera_langilea` FOREIGN KEY (`idLangilea`) REFERENCES `langilea` (`idLangilea`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sarrera`
--

LOCK TABLES `sarrera` WRITE;
/*!40000 ALTER TABLE `sarrera` DISABLE KEYS */;
/*!40000 ALTER TABLE `sarrera` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `sarreraAldaketa` AFTER UPDATE ON `sarrera` FOR EACH ROW BEGIN

INSERT INTO erronka3.sarrerahistorikoa ( idSarrera, idLangilea, idEremua, prezioa, aldaketa_mota )

VALUES ( OLD.idSarrera, OLD.idLangilea, OLD.idEremua, old.prezioa, 'UPDATE');

END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `ezabatuSarrera` BEFORE DELETE ON `sarrera` FOR EACH ROW BEGIN

INSERT INTO erronka3.sarrerahistorikoa ( idSarrera, idLangilea, idEremua, prezioa, aldaketa_mota )

VALUES ( OLD.idSarrera, OLD.idLangilea, OLD.idEremua, old.prezioa, 'DELETE');

END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `sarrerahistorikoa`
--

DROP TABLE IF EXISTS `sarrerahistorikoa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sarrerahistorikoa` (
  `idSarrera` int DEFAULT NULL,
  `idLangilea` int DEFAULT NULL,
  `idEremua` int DEFAULT NULL,
  `prezioa` double DEFAULT NULL,
  `aldaketa_data` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `aldaketa_mota` enum('UPDATE','DELETE') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sarrerahistorikoa`
--

LOCK TABLES `sarrerahistorikoa` WRITE;
/*!40000 ALTER TABLE `sarrerahistorikoa` DISABLE KEYS */;
/*!40000 ALTER TABLE `sarrerahistorikoa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `taldea`
--

DROP TABLE IF EXISTS `taldea`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `taldea` (
  `idTaldea` int NOT NULL AUTO_INCREMENT,
  `idKluba` int NOT NULL,
  `kategoria` varchar(20) NOT NULL,
  `jokalariKopurua` int NOT NULL,
  PRIMARY KEY (`idTaldea`),
  KEY `fk_taldea_kluba1_idx` (`idKluba`),
  CONSTRAINT `fk_taldea_kluba1` FOREIGN KEY (`idKluba`) REFERENCES `kluba` (`idKluba`)
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `taldea`
--

LOCK TABLES `taldea` WRITE;
/*!40000 ALTER TABLE `taldea` DISABLE KEYS */;
INSERT INTO `taldea` VALUES (1,1,'Seniorra',40),(2,1,'Gaztea',35),(3,1,'Kadetea',30),(4,1,'Infantila',25),(5,1,'Alebinak',20),(6,2,'Seniorra',30),(7,2,'Gaztea',25),(8,2,'Kadetea',20),(9,3,'Seniorra',40),(10,3,'Gaztea',30),(11,3,'Kadetea',25),(12,3,'Infantila',25),(13,4,'Seniorra',30),(14,4,'Gaztea',30),(15,4,'Kadetea',25),(16,4,'Infantila',25),(17,5,'Seniorra',15),(18,5,'Gaztea',10),(19,6,'Elite',40),(20,6,'Amateur',30),(21,7,'Seniorra',30),(22,7,'Gaztea',30),(23,8,'Seniorra',25),(24,8,'Gaztea',25),(25,9,'Seniorra',20),(26,9,'Gaztea',20),(27,10,'Nagusiak',30);
/*!40000 ALTER TABLE `taldea` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `taldeaAldaketa` AFTER UPDATE ON `taldea` FOR EACH ROW BEGIN

INSERT INTO erronka3.taldeahistorikoa ( idTaldea, idKluba, kategoria, jokalariKopurua, aldaketa_mota )

VALUES ( OLD.idTaldea, OLD.idKluba, OLD.kategoria, old.jokalariKopurua, 'UPDATE');

END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `ezabatuTaldea` BEFORE DELETE ON `taldea` FOR EACH ROW BEGIN

INSERT INTO erronka3.taldeahistorikoa ( idTaldea, idKluba, kategoria, jokalariKopurua, aldaketa_mota )

VALUES ( OLD.idTaldea, OLD.idKluba, OLD.kategoria, old.jokalariKopurua, 'DELETE');

END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `taldeahistorikoa`
--

DROP TABLE IF EXISTS `taldeahistorikoa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `taldeahistorikoa` (
  `idTaldea` int DEFAULT NULL,
  `idKluba` int DEFAULT NULL,
  `kategoria` varchar(20) DEFAULT NULL,
  `jokalariKopurua` int DEFAULT NULL,
  `aldaketa_data` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `aldaketa_mota` enum('UPDATE','DELETE') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `taldeahistorikoa`
--

LOCK TABLES `taldeahistorikoa` WRITE;
/*!40000 ALTER TABLE `taldeahistorikoa` DISABLE KEYS */;
/*!40000 ALTER TABLE `taldeahistorikoa` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-04-01  9:52:13
