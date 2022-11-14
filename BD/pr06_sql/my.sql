-- MySQL dump 10.13  Distrib 8.0.30, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: pr06
-- ------------------------------------------------------
-- Server version	5.7.38

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
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-11-15  0:42:38
-- MySQL dump 10.13  Distrib 8.0.30, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: mydb
-- ------------------------------------------------------
-- Server version	5.7.38

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
-- Table structure for table `courses`
--

DROP TABLE IF EXISTS `courses`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `courses` (
  `idCourses` int(11) NOT NULL AUTO_INCREMENT,
  `CourseName` varchar(25) NOT NULL,
  `StudyRoomID` int(11) NOT NULL,
  `LecturerID` int(11) NOT NULL,
  PRIMARY KEY (`idCourses`),
  KEY `LectureID_idx` (`LecturerID`),
  KEY `StudyRommID_idx` (`StudyRoomID`),
  CONSTRAINT `LectureID` FOREIGN KEY (`LecturerID`) REFERENCES `lecturers` (`idLecturer`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `StudyRommID` FOREIGN KEY (`StudyRoomID`) REFERENCES `studyrooms` (`idStudyRoom`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `courses`
--

LOCK TABLES `courses` WRITE;
/*!40000 ALTER TABLE `courses` DISABLE KEYS */;
/*!40000 ALTER TABLE `courses` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `courses_has_lecturers`
--

DROP TABLE IF EXISTS `courses_has_lecturers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `courses_has_lecturers` (
  `Courses_idCourses` int(11) NOT NULL,
  `Lecturers_idLecturer` int(11) NOT NULL,
  `Courses_has_Lecturerscol` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`Courses_idCourses`,`Lecturers_idLecturer`),
  UNIQUE KEY `Courses_has_Lecturerscol_UNIQUE` (`Courses_has_Lecturerscol`),
  KEY `fk_Courses_has_Lecturers_Lecturers1_idx` (`Lecturers_idLecturer`),
  KEY `fk_Courses_has_Lecturers_Courses_idx` (`Courses_idCourses`),
  CONSTRAINT `fk_Courses_has_Lecturers_Courses` FOREIGN KEY (`Courses_idCourses`) REFERENCES `courses` (`idCourses`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Courses_has_Lecturers_Lecturers1` FOREIGN KEY (`Lecturers_idLecturer`) REFERENCES `lecturers` (`idLecturer`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `courses_has_lecturers`
--

LOCK TABLES `courses_has_lecturers` WRITE;
/*!40000 ALTER TABLE `courses_has_lecturers` DISABLE KEYS */;
/*!40000 ALTER TABLE `courses_has_lecturers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `klients`
--

DROP TABLE IF EXISTS `klients`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `klients` (
  `idKlients` int(11) NOT NULL AUTO_INCREMENT,
  `FullName` varchar(15) NOT NULL,
  `DOB` date NOT NULL,
  `Gender` enum('муж','жен') NOT NULL,
  PRIMARY KEY (`idKlients`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `klients`
--

LOCK TABLES `klients` WRITE;
/*!40000 ALTER TABLE `klients` DISABLE KEYS */;
/*!40000 ALTER TABLE `klients` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `klients_has_courses`
--

DROP TABLE IF EXISTS `klients_has_courses`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `klients_has_courses` (
  `Klients_idKlients` int(11) NOT NULL,
  `Courses_idCourses` int(11) NOT NULL,
  KEY `fk_Klients_has_Courses_Courses1_idx` (`Courses_idCourses`),
  KEY `fk_Klients_has_Courses_Klients1_idx` (`Klients_idKlients`),
  CONSTRAINT `fk_Klients_has_Courses_Courses1` FOREIGN KEY (`Courses_idCourses`) REFERENCES `courses` (`idCourses`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Klients_has_Courses_Klients1` FOREIGN KEY (`Klients_idKlients`) REFERENCES `klients` (`idKlients`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `klients_has_courses`
--

LOCK TABLES `klients_has_courses` WRITE;
/*!40000 ALTER TABLE `klients_has_courses` DISABLE KEYS */;
/*!40000 ALTER TABLE `klients_has_courses` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lecturers`
--

DROP TABLE IF EXISTS `lecturers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `lecturers` (
  `idLecturer` int(11) NOT NULL AUTO_INCREMENT,
  `FullName` varchar(15) NOT NULL,
  `Education` varchar(45) DEFAULT NULL,
  `CourseSpec` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idLecturer`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lecturers`
--

LOCK TABLES `lecturers` WRITE;
/*!40000 ALTER TABLE `lecturers` DISABLE KEYS */;
/*!40000 ALTER TABLE `lecturers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `studyrooms`
--

DROP TABLE IF EXISTS `studyrooms`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `studyrooms` (
  `idStudyRoom` int(11) NOT NULL AUTO_INCREMENT,
  `City` varchar(15) NOT NULL,
  `Street` varchar(25) NOT NULL,
  `Structure` varchar(5) NOT NULL,
  `Cabinet` smallint(255) DEFAULT NULL,
  PRIMARY KEY (`idStudyRoom`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `studyrooms`
--

LOCK TABLES `studyrooms` WRITE;
/*!40000 ALTER TABLE `studyrooms` DISABLE KEYS */;
/*!40000 ALTER TABLE `studyrooms` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-11-15  0:42:38
