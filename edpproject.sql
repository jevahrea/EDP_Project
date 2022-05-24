CREATE DATABASE  IF NOT EXISTS `edpproject` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `edpproject`;
-- MySQL dump 10.13  Distrib 8.0.28, for Win64 (x86_64)
--
-- Host: localhost    Database: edpproject
-- ------------------------------------------------------
-- Server version	8.0.28

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
-- Table structure for table `appointment`
--

DROP TABLE IF EXISTS `appointment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `appointment` (
  `idappointment` int NOT NULL AUTO_INCREMENT,
  `idpatient` int NOT NULL,
  `procedure` varchar(45) NOT NULL,
  `description` varchar(45) NOT NULL,
  `date` date DEFAULT NULL,
  `time` time DEFAULT NULL,
  `status` varchar(20) NOT NULL,
  `datecreated` timestamp NOT NULL,
  PRIMARY KEY (`idappointment`),
  KEY `FKidpatient_idx` (`idpatient`),
  CONSTRAINT `FKidpatient` FOREIGN KEY (`idpatient`) REFERENCES `patient` (`idpatient`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `appointment`
--

LOCK TABLES `appointment` WRITE;
/*!40000 ALTER TABLE `appointment` DISABLE KEYS */;
/*!40000 ALTER TABLE `appointment` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employee`
--

DROP TABLE IF EXISTS `employee`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employee` (
  `idemployee` bigint NOT NULL,
  `firstname` varchar(45) NOT NULL,
  `middlename` varchar(45) DEFAULT NULL,
  `lastname` varchar(45) NOT NULL,
  `email` varchar(45) NOT NULL,
  `contactno` varchar(45) NOT NULL,
  `dateofbirth` date NOT NULL,
  PRIMARY KEY (`idemployee`),
  UNIQUE KEY `email_UNIQUE` (`email`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employee`
--

LOCK TABLES `employee` WRITE;
/*!40000 ALTER TABLE `employee` DISABLE KEYS */;
INSERT INTO `employee` VALUES (1313131313,'Princess Joy','Bondoy','Borlagdan','princessjoyborlagdan@gmail.com','09390322427','2000-02-06'),(1414141414,'Jevah Rea','Blancaflor','Montas','jevahreamontas@gmail.com','09074342722','2001-01-28'),(1241241511251,'Mark','Teoxon','Rantael','markbenedickrantael@gmail.com','09566430159','2022-04-07');
/*!40000 ALTER TABLE `employee` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `patient`
--

DROP TABLE IF EXISTS `patient`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `patient` (
  `idpatient` int NOT NULL AUTO_INCREMENT,
  `firstname` varchar(45) NOT NULL,
  `middlename` varchar(45) DEFAULT NULL,
  `lastname` varchar(45) NOT NULL,
  `gender` char(10) NOT NULL,
  `dateofbirth` date NOT NULL,
  `age` int NOT NULL,
  `province` varchar(45) NOT NULL,
  `city` varchar(45) NOT NULL,
  `street` varchar(45) NOT NULL,
  `contactno` varchar(45) NOT NULL,
  `datecreated` datetime DEFAULT NULL,
  PRIMARY KEY (`idpatient`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `patient`
--

LOCK TABLES `patient` WRITE;
/*!40000 ALTER TABLE `patient` DISABLE KEYS */;
INSERT INTO `patient` VALUES (1,'Mark Benedick','Teoxon','Rantael','Male','2001-05-19',20,'Albay','Legazpi','Brgy. 10 Cabangan','09566430159','2022-04-07 16:15:14'),(2,'Jevah Rea','Blancaflor','Montas','Female','2001-01-26',20,'Albay','Legazpi','Brgy. 18 Cabangan','12345678910','2022-03-30 11:36:23'),(3,'Princess Joy','Bondoy','Borlagdan','Female','2022-03-30',20,'Albay','Legazpi','Brgy. 16 Malilipot','09559464949','2022-03-30 14:50:07'),(4,'choey','choey','choey','Male','2022-04-06',22,'LALbay','LEgazpi','streest','2014910521','2022-04-06 14:52:27');
/*!40000 ALTER TABLE `patient` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `userlogs`
--

DROP TABLE IF EXISTS `userlogs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `userlogs` (
  `iduserlogs` bigint NOT NULL,
  `username` varchar(45) NOT NULL,
  `usertype` varchar(45) NOT NULL,
  `dateTimeIn` timestamp NOT NULL,
  `dateTimeOut` timestamp NULL DEFAULT NULL,
  PRIMARY KEY (`iduserlogs`),
  KEY `FKusername_idx` (`username`),
  CONSTRAINT `FKusername` FOREIGN KEY (`username`) REFERENCES `users` (`username`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `userlogs`
--

LOCK TABLES `userlogs` WRITE;
/*!40000 ALTER TABLE `userlogs` DISABLE KEYS */;
INSERT INTO `userlogs` VALUES (20220407154623,'admins','admin','2022-04-07 07:46:23',NULL),(20220407160437,'markrantael','admin','2022-04-07 08:04:37','2022-04-07 08:05:00'),(20220407160618,'markrantael','admin','2022-04-07 08:06:18','2022-04-07 08:06:42'),(20220407160648,'jevah','staff','2022-04-07 08:06:48','2022-04-07 08:07:22'),(20220407160727,'markrantael','admin','2022-04-07 08:07:27','2022-04-07 08:08:01'),(20220407161116,'markrantael','admin','2022-04-07 08:11:16',NULL),(20220407161314,'markrantael','admin','2022-04-07 08:13:14',NULL),(20220407161804,'markrantael','admin','2022-04-07 08:18:04',NULL),(20220407162001,'markrantael','admin','2022-04-07 08:20:01','2022-04-07 08:20:50'),(20220407162108,'markrantael','admin','2022-04-07 08:21:08','2022-04-07 08:21:22'),(20220407162136,'markrantael','admin','2022-04-07 08:21:36','2022-04-07 08:22:39'),(20220407214659,'markrantael','admin','2022-04-07 13:46:59','2022-04-07 13:47:30');
/*!40000 ALTER TABLE `userlogs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `idusers` int NOT NULL AUTO_INCREMENT,
  `username` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  `usertype` varchar(45) NOT NULL,
  `email` varchar(45) NOT NULL,
  `fgtpassquestion` varchar(255) NOT NULL,
  `fgtpassanswer` varchar(45) NOT NULL,
  PRIMARY KEY (`idusers`),
  UNIQUE KEY `email_UNIQUE` (`email`),
  UNIQUE KEY `username_UNIQUE` (`username`),
  CONSTRAINT `FKemail` FOREIGN KEY (`email`) REFERENCES `employee` (`email`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (5,'admins','admin','admin','princessjoyborlagdan@gmail.com','Favorite Color?','Pink'),(6,'jevah','staff','staff','jevahreamontas@gmail.com','Pet Name','Holly'),(10,'markrantael','admin','admin','markbenedickrantael@gmail.com','nickname','mac');
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

-- Dump completed on 2022-04-07 21:48:24
