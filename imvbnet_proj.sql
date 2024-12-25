-- MariaDB dump 10.19  Distrib 10.4.32-MariaDB, for Win64 (AMD64)
--
-- Host: localhost    Database: imvbnetupdate
-- ------------------------------------------------------
-- Server version	10.4.32-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `department`
--

DROP TABLE IF EXISTS `department`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `department` (
  `dept_code` varchar(10) NOT NULL,
  `dept_name` varchar(50) NOT NULL,
  PRIMARY KEY (`dept_code`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `department`
--

LOCK TABLES `department` WRITE;
/*!40000 ALTER TABLE `department` DISABLE KEYS */;
INSERT INTO `department` VALUES ('CAS','College of Arts and Sciences'),('CBA','College of Business and Accountancy'),('CCS','College of Computer Studies'),('CIHM','College of International Hospitality Management'),('COE','College of Engineering'),('COeD','College of Education'),('CON','College of Nursing');
/*!40000 ALTER TABLE `department` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `final`
--

DROP TABLE IF EXISTS `final`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `final` (
  `student_id` varchar(8) NOT NULL,
  `subject_code` varchar(10) NOT NULL,
  `section_code` varchar(10) NOT NULL,
  `no_of_absences` int(2) DEFAULT NULL,
  `Q1_score` int(2) DEFAULT NULL,
  `Q1_item` int(2) DEFAULT NULL,
  `Q2_score` int(2) DEFAULT NULL,
  `Q2_item` int(2) DEFAULT NULL,
  `Q3_score` int(2) DEFAULT NULL,
  `Q3_item` int(2) DEFAULT NULL,
  `Q4_score` int(2) DEFAULT NULL,
  `Q4_item` int(2) DEFAULT NULL,
  `LAB1_score` int(2) DEFAULT NULL,
  `LAB2_score` int(2) DEFAULT NULL,
  `LAB3_score` int(2) DEFAULT NULL,
  `LAB4_score` int(2) DEFAULT NULL,
  `final_exam_score` int(2) DEFAULT NULL,
  `final_exam_item` int(2) DEFAULT NULL,
  `case_study` int(2) DEFAULT NULL,
  PRIMARY KEY (`student_id`,`subject_code`,`section_code`),
  KEY `final_ibfk_2` (`subject_code`,`section_code`),
  KEY `subject_assign_ibfk_3` (`section_code`),
  CONSTRAINT `final_ibfk_1` FOREIGN KEY (`student_id`) REFERENCES `section_assign` (`student_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `final_ibfk_2` FOREIGN KEY (`subject_code`, `section_code`) REFERENCES `subject_assign` (`subject_code`, `section_code`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `subject_assign_ibfk_3` FOREIGN KEY (`section_code`) REFERENCES `section_assign` (`section_code`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `final`
--

LOCK TABLES `final` WRITE;
/*!40000 ALTER TABLE `final` DISABLE KEYS */;
INSERT INTO `final` VALUES ('21-00151','COMP 104','BSIT2A',0,24,30,25,35,37,50,31,40,94,91,93,97,38,50,96),('23-00071','COMP 105','BSIT2C',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `final` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `final_gw`
--

DROP TABLE IF EXISTS `final_gw`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `final_gw` (
  `student_id` varchar(8) NOT NULL,
  `subject_code` varchar(10) NOT NULL,
  `section_code` varchar(10) NOT NULL,
  `attendance_percentage` decimal(5,2) DEFAULT NULL,
  `quiz_percentage` decimal(5,2) DEFAULT NULL,
  `lab_percentage` decimal(5,2) DEFAULT NULL,
  `case_study` decimal(5,2) DEFAULT NULL,
  `final_exam_percentage` decimal(5,2) DEFAULT NULL,
  `final_grade` decimal(5,2) DEFAULT NULL,
  `remarks` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`student_id`,`subject_code`,`section_code`),
  CONSTRAINT `final_gw_ibfk_1` FOREIGN KEY (`student_id`, `subject_code`, `section_code`) REFERENCES `final` (`student_id`, `subject_code`, `section_code`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `final_gw`
--

LOCK TABLES `final_gw` WRITE;
/*!40000 ALTER TABLE `final_gw` DISABLE KEYS */;
INSERT INTO `final_gw` VALUES ('21-00151','COMP 104','BSIT2A',5.00,15.00,20.00,30.00,30.00,93.50,'PASSED'),('23-00071','COMP 105','BSIT2C',NULL,NULL,NULL,NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `final_gw` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `midterm`
--

DROP TABLE IF EXISTS `midterm`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `midterm` (
  `student_id` varchar(8) NOT NULL,
  `subject_code` varchar(10) NOT NULL,
  `section_code` varchar(10) NOT NULL,
  `no_of_absences` int(2) DEFAULT NULL,
  `Q1_score` int(2) DEFAULT NULL,
  `Q1_item` int(2) DEFAULT NULL,
  `Q2_score` int(2) DEFAULT NULL,
  `Q2_item` int(2) DEFAULT NULL,
  `Q3_score` int(2) DEFAULT NULL,
  `Q3_item` int(2) DEFAULT NULL,
  `Q4_score` int(2) DEFAULT NULL,
  `Q4_item` int(2) DEFAULT NULL,
  `LAB1_score` int(2) DEFAULT NULL,
  `LAB2_score` int(2) DEFAULT NULL,
  `LAB3_score` int(2) DEFAULT NULL,
  `LAB4_score` int(2) DEFAULT NULL,
  `mid_exam_score` int(2) DEFAULT NULL,
  `mid_exam_item` int(2) DEFAULT NULL,
  `case_study` int(2) DEFAULT NULL,
  `recitation` int(2) DEFAULT NULL,
  PRIMARY KEY (`student_id`,`subject_code`,`section_code`),
  KEY `midterm_ibfk_2` (`subject_code`,`section_code`),
  KEY `midterm_ibfk_3` (`section_code`),
  CONSTRAINT `midterm_ibfk_1` FOREIGN KEY (`student_id`) REFERENCES `section_assign` (`student_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `midterm_ibfk_2` FOREIGN KEY (`subject_code`, `section_code`) REFERENCES `subject_assign` (`subject_code`, `section_code`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `midterm_ibfk_3` FOREIGN KEY (`section_code`) REFERENCES `section_assign` (`section_code`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `midterm`
--

LOCK TABLES `midterm` WRITE;
/*!40000 ALTER TABLE `midterm` DISABLE KEYS */;
INSERT INTO `midterm` VALUES ('-9976','COMP 104','BSIT2D',0,34,45,NULL,NULL,NULL,NULL,NULL,NULL,94,NULL,NULL,NULL,40,60,95,100),('21-00151','COMP 104','BSIT2A',0,34,45,27,40,33,40,30,40,94,93,95,95,40,60,95,100),('23-00071','COMP 105','BSIT2C',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `midterm` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `midterm_gw`
--

DROP TABLE IF EXISTS `midterm_gw`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `midterm_gw` (
  `student_id` varchar(8) NOT NULL,
  `subject_code` varchar(10) NOT NULL,
  `section_code` varchar(10) NOT NULL,
  `attendance_percentage` decimal(5,2) DEFAULT NULL,
  `quiz_percentage` decimal(5,2) DEFAULT NULL,
  `lab_percentage` decimal(5,2) DEFAULT NULL,
  `case_study` decimal(5,2) DEFAULT NULL,
  `recitation` decimal(5,2) DEFAULT NULL,
  `mid_exam_percentage` decimal(5,2) DEFAULT NULL,
  `midterm_grade` decimal(5,2) DEFAULT NULL,
  `remarks` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`student_id`,`subject_code`,`section_code`),
  CONSTRAINT `midterm_gw_ibfk_1` FOREIGN KEY (`student_id`, `subject_code`, `section_code`) REFERENCES `midterm` (`student_id`, `subject_code`, `section_code`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `midterm_gw`
--

LOCK TABLES `midterm_gw` WRITE;
/*!40000 ALTER TABLE `midterm_gw` DISABLE KEYS */;
INSERT INTO `midterm_gw` VALUES ('21-00151','COMP 104','BSIT2A',5.00,15.00,20.00,20.00,10.00,30.00,92.75,'PASSED'),('23-00071','COMP 105','BSIT2C',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `midterm_gw` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `professor`
--

DROP TABLE IF EXISTS `professor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `professor` (
  `professor_id` varchar(50) NOT NULL,
  `last_name` varchar(50) NOT NULL,
  `first_name` varchar(50) NOT NULL,
  `middle_initial` char(2) DEFAULT NULL,
  `suffix` char(3) DEFAULT NULL,
  `dept_code` varchar(10) NOT NULL,
  `gender` varchar(10) DEFAULT NULL,
  `birh_date` date DEFAULT NULL,
  `address` varchar(200) DEFAULT NULL,
  `phone_no` int(11) DEFAULT NULL,
  `picture` mediumblob DEFAULT NULL,
  PRIMARY KEY (`professor_id`),
  KEY `dept_code` (`dept_code`),
  CONSTRAINT `professor_ibfk_1` FOREIGN KEY (`dept_code`) REFERENCES `department` (`dept_code`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `professor`
--

LOCK TABLES `professor` WRITE;
/*!40000 ALTER TABLE `professor` DISABLE KEYS */;
INSERT INTO `professor` VALUES ('CCSPF01','Laura','Altea','M.','','CCS',NULL,NULL,NULL,NULL,NULL),('CCSPF02','Cortez','Racquel','A.','','CCS',NULL,NULL,NULL,NULL,NULL),('CCSPF03','Rodolfo','Mirabel','A.','Jr.','CCS',NULL,NULL,NULL,NULL,NULL),('CCSPF04','Dela Cruz','Mark','P.','Sr.','CAS',NULL,NULL,NULL,NULL,NULL),('CCSPF06','Asuncion','Almeda',NULL,NULL,'CCS',NULL,NULL,NULL,NULL,NULL),('CCSPF07','Nueva','Federico',NULL,NULL,'CCS',NULL,NULL,NULL,NULL,NULL),('CCSPF08','Villareal','Benito','T.','III','CAS',NULL,NULL,NULL,NULL,NULL),('CCSPF56','Luscia','Anthonia','R.',NULL,'CCS',NULL,NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `professor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `program`
--

DROP TABLE IF EXISTS `program`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `program` (
  `program_code` varchar(10) NOT NULL,
  `prog_name` varchar(50) NOT NULL,
  `dept_code` varchar(10) NOT NULL,
  PRIMARY KEY (`program_code`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `program`
--

LOCK TABLES `program` WRITE;
/*!40000 ALTER TABLE `program` DISABLE KEYS */;
INSERT INTO `program` VALUES ('BSCS','Bachelor of Science in Computer Science','CCS'),('BSIT','Bachelor of Science in Information Technology','CCS');
/*!40000 ALTER TABLE `program` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `question`
--

DROP TABLE IF EXISTS `question`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `question` (
  `question_no` varchar(10) NOT NULL,
  `questions` varchar(100) NOT NULL,
  PRIMARY KEY (`question_no`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `question`
--

LOCK TABLES `question` WRITE;
/*!40000 ALTER TABLE `question` DISABLE KEYS */;
INSERT INTO `question` VALUES ('1','Which professor do you find most favorable?'),('2','What is your favorite color?'),('3','What is your mother\'s maiden name?');
/*!40000 ALTER TABLE `question` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `section`
--

DROP TABLE IF EXISTS `section`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `section` (
  `section_code` varchar(10) NOT NULL,
  `program_code` varchar(10) NOT NULL,
  `year` int(1) NOT NULL,
  `section` char(1) NOT NULL,
  PRIMARY KEY (`section_code`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `section`
--

LOCK TABLES `section` WRITE;
/*!40000 ALTER TABLE `section` DISABLE KEYS */;
INSERT INTO `section` VALUES ('BSCS1A','BSCS',1,'A'),('BSCS2A','BSCS',2,'A'),('BSCS3A','BSCS',3,'A'),('BSCS4A','BSCS',4,'A'),('BSIT1A','BSIT',1,'A'),('BSIT1B','BSIT',1,'B'),('BSIT1C','BSIT',1,'C'),('BSIT1D','BSIT',1,'D'),('BSIT1E','BSIT',1,'E'),('BSIT2A','BSIT',2,'A'),('BSIT2B','BSIT',2,'B'),('BSIT2C','BSIT',2,'C'),('BSIT2D','BSIT',2,'D'),('BSIT2E','BSIT',2,'E'),('BSIT3A','BSIT',3,'A'),('BSIT3B','BSIT',3,'B'),('BSIT3C','BSIT',3,'C'),('BSIT3D','BSIT',3,'D'),('BSIT3E','BSIT',3,'E'),('BSIT4A','BSIT',4,'A'),('BSIT4B','BSIT',4,'B'),('BSIT4C','BSIT',4,'C'),('BSIT4D','BSIT',4,'D'),('BSIT4E','BSIT',4,'E');
/*!40000 ALTER TABLE `section` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `section_assign`
--

DROP TABLE IF EXISTS `section_assign`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `section_assign` (
  `section_code` varchar(10) NOT NULL,
  `student_id` varchar(8) NOT NULL,
  KEY `section_code` (`section_code`),
  KEY `student_id` (`student_id`),
  CONSTRAINT `section_assign_ibfk_1` FOREIGN KEY (`section_code`) REFERENCES `section` (`section_code`),
  CONSTRAINT `section_assign_ibfk_2` FOREIGN KEY (`student_id`) REFERENCES `student` (`student_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `section_assign`
--

LOCK TABLES `section_assign` WRITE;
/*!40000 ALTER TABLE `section_assign` DISABLE KEYS */;
INSERT INTO `section_assign` VALUES ('BSIT1A','24-00001'),('BSIT1A','24-00002'),('BSIT1A','24-00003'),('BSIT1A','24-00004'),('BSIT1A','24-00005'),('BSIT1A','24-00006'),('BSIT1A','24-00007'),('BSIT1A','24-00008'),('BSIT1A','24-00009'),('BSIT1A','24-00010'),('BSIT1B','24-00011'),('BSIT1B','24-00012'),('BSIT1B','24-00013'),('BSIT1B','24-00014'),('BSIT1B','24-00015'),('BSIT1B','24-00016'),('BSIT1B','24-00017'),('BSIT1B','24-00018'),('BSIT1B','24-00019'),('BSIT1B','24-00020'),('BSIT1C','24-00021'),('BSIT1C','24-00022'),('BSIT1C','24-00023'),('BSIT1C','24-00024'),('BSIT1C','24-00025'),('BSIT1C','24-00026'),('BSIT1C','24-00027'),('BSIT1C','24-00028'),('BSIT1C','24-00029'),('BSIT1C','24-00030'),('BSIT1D','24-00031'),('BSIT1D','24-00032'),('BSIT1D','24-00033'),('BSIT1D','24-00034'),('BSIT1D','24-00035'),('BSIT1D','24-00036'),('BSIT1D','24-00037'),('BSIT1D','24-00038'),('BSIT1D','24-00039'),('BSIT1D','24-00040'),('BSIT1E','24-00041'),('BSIT1E','24-00042'),('BSIT1E','24-00043'),('BSIT1E','24-00044'),('BSIT1E','24-00045'),('BSIT1E','24-00046'),('BSIT1E','24-00047'),('BSIT1E','24-00048'),('BSIT1E','24-00049'),('BSIT1E','24-00050'),('BSIT2A','23-00051'),('BSIT2A','23-00052'),('BSIT2A','23-00053'),('BSIT2A','23-00054'),('BSIT2A','23-00055'),('BSIT2A','23-00056'),('BSIT2A','23-00057'),('BSIT2A','23-00058'),('BSIT2A','23-00059'),('BSIT2A','23-00060'),('BSIT2B','23-00061'),('BSIT2B','23-00062'),('BSIT2B','23-00063'),('BSIT2B','23-00064'),('BSIT2B','23-00065'),('BSIT2B','23-00066'),('BSIT2B','23-00067'),('BSIT2B','23-00068'),('BSIT2B','23-00069'),('BSIT2B','23-00070'),('BSIT2C','23-00071'),('BSIT2C','23-00072'),('BSIT2C','23-00073'),('BSIT2C','23-00074'),('BSIT2C','23-00075'),('BSIT2C','23-00076'),('BSIT2C','23-00077'),('BSIT2C','23-00078'),('BSIT2C','23-00079'),('BSIT2C','23-00080'),('BSIT2D','23-00081'),('BSIT2D','23-00082'),('BSIT2D','23-00083'),('BSIT2D','23-00084'),('BSIT2D','23-00085'),('BSIT2D','23-00086'),('BSIT2D','23-00087'),('BSIT2D','23-00088'),('BSIT2D','23-00089'),('BSIT2D','23-00090'),('BSIT2E','23-00091'),('BSIT2E','23-00092'),('BSIT2E','23-00093'),('BSIT2E','23-00094'),('BSIT2E','23-00095'),('BSIT2E','23-00096'),('BSIT2E','23-00097'),('BSIT2E','23-00098'),('BSIT2E','23-00099'),('BSIT2E','23-00100'),('BSIT3A','22-00101'),('BSIT3A','22-00102'),('BSIT3A','22-00103'),('BSIT3A','22-00104'),('BSIT3A','22-00105'),('BSIT3A','22-00106'),('BSIT3A','22-00107'),('BSIT3A','22-00108'),('BSIT3A','22-00109'),('BSIT3A','22-00110'),('BSIT3B','22-00111'),('BSIT3B','22-00112'),('BSIT3B','22-00113'),('BSIT3B','22-00114'),('BSIT3B','22-00115'),('BSIT3B','22-00116'),('BSIT3B','22-00117'),('BSIT3B','22-00118'),('BSIT3B','22-00119'),('BSIT3B','22-00120'),('BSIT3C','22-00121'),('BSIT3C','22-00122'),('BSIT3C','22-00123'),('BSIT3C','22-00124'),('BSIT3C','22-00125'),('BSIT3C','22-00126'),('BSIT3C','22-00127'),('BSIT3C','22-00128'),('BSIT3C','22-00129'),('BSIT3C','22-00130'),('BSIT3D','22-00131'),('BSIT3D','22-00132'),('BSIT3D','22-00133'),('BSIT3D','22-00134'),('BSIT3D','22-00135'),('BSIT3D','22-00136'),('BSIT3D','22-00137'),('BSIT3D','22-00138'),('BSIT3D','22-00139'),('BSIT3D','22-00140'),('BSIT3E','22-00141'),('BSIT3E','22-00142'),('BSIT3E','22-00143'),('BSIT3E','22-00144'),('BSIT3E','22-00145'),('BSIT3E','22-00146'),('BSIT3E','22-00147'),('BSIT3E','22-00148'),('BSIT3E','22-00149'),('BSIT3E','22-00150'),('BSIT4A','21-00151'),('BSIT4A','21-00152'),('BSIT4A','21-00153'),('BSIT4A','21-00154'),('BSIT4A','21-00155'),('BSCS2A','21-00156'),('BSIT4A','21-00157'),('BSIT4A','21-00158'),('BSIT4A','21-00159'),('BSCS1A','21-00160'),('BSIT4B','21-00162'),('BSIT4B','21-00163'),('BSIT4B','21-00164'),('BSIT4B','21-00165'),('BSIT4B','21-00166'),('BSIT4B','21-00167'),('BSIT4B','21-00168'),('BSIT4B','21-00169'),('BSIT4B','21-00170'),('BSIT4C','21-00171'),('BSIT4C','21-00172'),('BSIT4C','21-00173'),('BSIT4C','21-00174'),('BSIT4C','21-00175'),('BSIT4C','21-00176'),('BSIT4C','21-00177'),('BSIT4C','21-00178'),('BSIT4C','21-00179'),('BSIT4C','21-00180'),('BSIT4D','21-00181'),('BSIT4D','21-00182'),('BSIT4D','21-00183'),('BSIT4D','21-00184'),('BSIT4D','21-00185'),('BSIT4D','21-00186'),('BSIT4D','21-00187'),('BSIT4D','21-00188'),('BSIT4D','21-00189'),('BSIT4D','21-00190'),('BSIT4E','21-00191'),('BSIT4E','21-00192'),('BSIT4E','21-00193'),('BSIT4E','21-00194'),('BSIT4E','21-00195'),('BSIT4E','21-00196'),('BSIT4E','21-00197'),('BSIT4E','21-00198'),('BSIT4E','21-00199'),('BSIT4E','21-00200'),('BSCS1A','24-00201'),('BSCS1A','24-00202'),('BSCS1A','24-00203'),('BSCS1A','24-00204'),('BSCS1A','24-00205'),('BSCS1A','24-00206'),('BSCS1A','24-00207'),('BSCS1A','24-00208'),('BSCS1A','24-00209'),('BSCS1A','24-00210'),('BSCS2A','23-00211'),('BSCS2A','23-00212'),('BSCS2A','23-00213'),('BSCS2A','23-00214'),('BSCS2A','23-00215'),('BSCS2A','23-00216'),('BSCS2A','23-00217'),('BSCS2A','23-00218'),('BSCS2A','23-00219'),('BSCS2A','23-00220'),('BSCS3A','22-00221'),('BSCS3A','22-00222'),('BSCS3A','22-00223'),('BSCS3A','22-00224'),('BSCS3A','22-00225'),('BSCS3A','22-00226'),('BSCS3A','22-00227'),('BSCS3A','22-00228'),('BSCS3A','22-00229'),('BSCS3A','22-00230'),('BSCS4A','21-00231'),('BSCS4A','21-00232'),('BSCS4A','21-00233'),('BSCS4A','21-00234'),('BSCS4A','21-00235'),('BSCS4A','21-00236'),('BSCS4A','21-00237'),('BSCS4A','21-00238'),('BSCS4A','21-00239'),('BSCS4A','21-00240'),('BSCS1A','-9976'),('BSCS1A','23-00246');
/*!40000 ALTER TABLE `section_assign` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `semester`
--

DROP TABLE IF EXISTS `semester`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `semester` (
  `student_id` varchar(8) NOT NULL,
  `subject_code` varchar(10) NOT NULL,
  `section_code` varchar(10) NOT NULL,
  `midterm_grade` decimal(4,2) DEFAULT NULL,
  `final_grade` decimal(4,2) DEFAULT NULL,
  `semestral_grade` decimal(4,2) DEFAULT NULL,
  `remarks` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`student_id`,`subject_code`,`section_code`),
  CONSTRAINT `semester_ibfk_1` FOREIGN KEY (`student_id`, `subject_code`, `section_code`) REFERENCES `midterm_gw` (`student_id`, `subject_code`, `section_code`),
  CONSTRAINT `semester_ibfk_2` FOREIGN KEY (`student_id`, `subject_code`, `section_code`) REFERENCES `final_gw` (`student_id`, `subject_code`, `section_code`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `semester`
--

LOCK TABLES `semester` WRITE;
/*!40000 ALTER TABLE `semester` DISABLE KEYS */;
INSERT INTO `semester` VALUES ('21-00151','COMP 104','BSIT2A',93.50,93.50,1.75,'PASSED');
/*!40000 ALTER TABLE `semester` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `student`
--

DROP TABLE IF EXISTS `student`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `student` (
  `student_id` varchar(8) NOT NULL,
  `last_name` varchar(50) NOT NULL,
  `first_name` varchar(50) NOT NULL,
  `middle_initial` char(2) DEFAULT NULL,
  `suffix` char(3) DEFAULT NULL,
  `gender` varchar(10) DEFAULT NULL,
  `birth_date` date DEFAULT NULL,
  `address` varchar(200) DEFAULT NULL,
  `phone_no` int(11) DEFAULT NULL,
  `picture` mediumblob DEFAULT NULL,
  `academic_year` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`student_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `student`
--

LOCK TABLES `student` WRITE;
/*!40000 ALTER TABLE `student` DISABLE KEYS */;
INSERT INTO `student` VALUES ('-9976','qwreqwerqwerqwre','Talo','P.','',NULL,NULL,NULL,NULL,NULL,NULL),('21-00151','Banez','Carlo','T','',NULL,NULL,NULL,NULL,NULL,NULL),('21-00152','Palanca','Myra','F','',NULL,NULL,NULL,NULL,NULL,NULL),('21-00153','Llanes','Francisco','C','III',NULL,NULL,NULL,NULL,NULL,NULL),('21-00154','Acosta','Lucille','P','',NULL,NULL,NULL,NULL,NULL,NULL),('21-00155','Torres','Esteban','A','',NULL,NULL,NULL,NULL,NULL,NULL),('21-00156','Fajardoo','Arlenes','C','JR',NULL,NULL,NULL,NULL,NULL,NULL),('21-00157','Ilagan','Cesar','E','Jr',NULL,NULL,NULL,NULL,NULL,NULL),('21-00158','Lim','Charity','H','',NULL,NULL,NULL,NULL,NULL,NULL),('21-00159','Cuevas','Oscar','W','',NULL,NULL,NULL,NULL,NULL,NULL),('21-00160','Rizal','Lapu','O','SR',NULL,NULL,NULL,NULL,NULL,NULL),('21-00162','Navarro','Therese','L','',NULL,NULL,NULL,NULL,NULL,NULL),('21-00163','Salonga','Alfred','M','',NULL,NULL,NULL,NULL,NULL,NULL),('21-00164','De Luna','Sofia','S','',NULL,NULL,NULL,NULL,NULL,NULL),('21-00165','Mangahas','Leo','H','II',NULL,NULL,NULL,NULL,NULL,NULL),('21-00166','Ibanez','Marlene','I','',NULL,NULL,NULL,NULL,NULL,NULL),('21-00167','Serrano','George','R','',NULL,NULL,NULL,NULL,NULL,NULL),('21-00168','Velasco','Eleanor','R','',NULL,NULL,NULL,NULL,NULL,NULL),('21-00169','Abad','Danilo','Y','',NULL,NULL,NULL,NULL,NULL,NULL),('21-00170','Peralta','Celia','I','',NULL,NULL,NULL,NULL,NULL,NULL),('21-00171','Mendoza','Rey','D','',NULL,NULL,NULL,NULL,NULL,NULL),('21-00172','Gamboa','Maria','K','',NULL,NULL,NULL,NULL,NULL,NULL),('21-00173','Pagulayan','Joshua','Y','Jr',NULL,NULL,NULL,NULL,NULL,NULL),('21-00174','Robles','Karen','P','',NULL,NULL,NULL,NULL,NULL,NULL),('21-00175','Villena','Adrian','O','',NULL,NULL,NULL,NULL,NULL,NULL),('21-00176','Zabala','Tricia','D','',NULL,NULL,NULL,NULL,NULL,NULL),('21-00177','Balagtas','Paulo','S','',NULL,NULL,NULL,NULL,NULL,NULL),('21-00178','Escueta','Tina','K','',NULL,NULL,NULL,NULL,NULL,NULL),('21-00179','Yabut','Federico','D','',NULL,NULL,NULL,NULL,NULL,NULL),('21-00180','Manabat','Consuelo','T','',NULL,NULL,NULL,NULL,NULL,NULL),('21-00181','Quizon','Eddie','H','',NULL,NULL,NULL,NULL,NULL,NULL),('21-00182','Ong','Samantha','S','',NULL,NULL,NULL,NULL,NULL,NULL),('21-00183','De Vera','Carlos','G','IV',NULL,NULL,NULL,NULL,NULL,NULL),('21-00184','Fontanilla','Alma','C','',NULL,NULL,NULL,NULL,NULL,NULL),('21-00185','Buenaventura','Joel','I','',NULL,NULL,NULL,NULL,NULL,NULL),('21-00186','Villanueva','April','K','',NULL,NULL,NULL,NULL,NULL,NULL),('21-00187','Magsombol','Victor','K','',NULL,NULL,NULL,NULL,NULL,NULL),('21-00188','Carreon','Regina','P','',NULL,NULL,NULL,NULL,NULL,NULL),('21-00189','Del Fierro','Edmund','M','',NULL,NULL,NULL,NULL,NULL,NULL),('21-00190','Salcedo','Vicky','B','',NULL,NULL,NULL,NULL,NULL,NULL),('21-00191','Lao','Miguel','B','',NULL,NULL,NULL,NULL,NULL,NULL),('21-00192','Tayag','Sylvia','P','',NULL,NULL,NULL,NULL,NULL,NULL),('21-00193','Alipio','Martina','V','III',NULL,NULL,NULL,NULL,NULL,NULL),('21-00194','Masi','Jesse','K','',NULL,NULL,NULL,NULL,NULL,NULL),('21-00195','Tuan','Reginaldo','S','',NULL,NULL,NULL,NULL,NULL,NULL),('21-00196','Zubiri','Frances','U','',NULL,NULL,NULL,NULL,NULL,NULL),('21-00197','Alvarez','Lucas','U','',NULL,NULL,NULL,NULL,NULL,NULL),('21-00198','Garces','Carla','R','',NULL,NULL,NULL,NULL,NULL,NULL),('21-00199','Raguin','Iris','T','',NULL,NULL,NULL,NULL,NULL,NULL),('21-00200','Villacorta','Adeline','D','',NULL,NULL,NULL,NULL,NULL,NULL),('21-00231','Legarda','Leandro','R','',NULL,NULL,NULL,NULL,NULL,NULL),('21-00232','Macaraeg','Tomas','G','',NULL,NULL,NULL,NULL,NULL,NULL),('21-00233','Ibarra','Isidro','A','',NULL,NULL,NULL,NULL,NULL,NULL),('21-00234','Mendoza','Olga','A','',NULL,NULL,NULL,NULL,NULL,NULL),('21-00235','Silva','Vince','F','',NULL,NULL,NULL,NULL,NULL,NULL),('21-00236','Contreras','Gerry','C','',NULL,NULL,NULL,NULL,NULL,NULL),('21-00237','Pangilinan','Noemi','W','',NULL,NULL,NULL,NULL,NULL,NULL),('21-00238','Zamora','Anastasia','L','',NULL,NULL,NULL,NULL,NULL,NULL),('21-00239','Javier','Janice','K','',NULL,NULL,NULL,NULL,NULL,NULL),('21-00240','Dizon','Ricardo','G','',NULL,NULL,NULL,NULL,NULL,NULL),('22-00101','Panganiban','Delfin','R','',NULL,NULL,NULL,NULL,NULL,NULL),('22-00102','Castro','Lucinda','J','',NULL,NULL,NULL,NULL,NULL,NULL),('22-00103','Bernal','Albert','T','II',NULL,NULL,NULL,NULL,NULL,NULL),('22-00104','Ramos','Katrina','Q','',NULL,NULL,NULL,NULL,NULL,NULL),('22-00105','Ferrer','Gregorio','L','',NULL,NULL,NULL,NULL,NULL,NULL),('22-00106','Guzman','Mariana','P','',NULL,NULL,NULL,NULL,NULL,NULL),('22-00107','Carreon','Felix','S','',NULL,NULL,NULL,NULL,NULL,NULL),('22-00108','Llamas','Dolores','M','',NULL,NULL,NULL,NULL,NULL,NULL),('22-00109','Agustin','Cesar','A','',NULL,NULL,NULL,NULL,NULL,NULL),('22-00110','Villafuerte','Clara','E','',NULL,NULL,NULL,NULL,NULL,NULL),('22-00111','Cortez','Ismael','K','',NULL,NULL,NULL,NULL,NULL,NULL),('22-00112','Javier','Therese','W','',NULL,NULL,NULL,NULL,NULL,NULL),('22-00113','San Juan','Marco','O','III',NULL,NULL,NULL,NULL,NULL,NULL),('22-00114','Mariano','Loretta','F','',NULL,NULL,NULL,NULL,NULL,NULL),('22-00115','Francisco','Paul','D','',NULL,NULL,NULL,NULL,NULL,NULL),('22-00116','San Pedro','Eliza','V','',NULL,NULL,NULL,NULL,NULL,NULL),('22-00117','Amado','Jorge','C','',NULL,NULL,NULL,NULL,NULL,NULL),('22-00118','Del Valle','Patricia','Z','',NULL,NULL,NULL,NULL,NULL,NULL),('22-00119','Zaragoza','Emil','G','',NULL,NULL,NULL,NULL,NULL,NULL),('22-00120','Pascua','Arlene','B','',NULL,NULL,NULL,NULL,NULL,NULL),('22-00121','Labrador','Victor','X','Jr',NULL,NULL,NULL,NULL,NULL,NULL),('22-00122','Arce','Diana','Y','',NULL,NULL,NULL,NULL,NULL,NULL),('22-00123','Herrera','Ramon','U','',NULL,NULL,NULL,NULL,NULL,NULL),('22-00124','Neri','Anna','N','',NULL,NULL,NULL,NULL,NULL,NULL),('22-00125','Soriano','Julian','Z','',NULL,NULL,NULL,NULL,NULL,NULL),('22-00126','Ocampo','Erica','H','',NULL,NULL,NULL,NULL,NULL,NULL),('22-00127','Ortiz','Leandro','L','',NULL,NULL,NULL,NULL,NULL,NULL),('22-00128','Canlas','Lucia','V','',NULL,NULL,NULL,NULL,NULL,NULL),('22-00129','Dimagiba','Noel','A','',NULL,NULL,NULL,NULL,NULL,NULL),('22-00130','Mirasol','Joyce','E','',NULL,NULL,NULL,NULL,NULL,NULL),('22-00131','De Guzman','Arnold','B','',NULL,NULL,NULL,NULL,NULL,NULL),('22-00132','Montemayor','Angelo','F','IV',NULL,NULL,NULL,NULL,NULL,NULL),('22-00133','Tiongson','Carmela','P','',NULL,NULL,NULL,NULL,NULL,NULL),('22-00134','Catapang','Reynaldo','K','',NULL,NULL,NULL,NULL,NULL,NULL),('22-00135','Andaya','Gloria','D','',NULL,NULL,NULL,NULL,NULL,NULL),('22-00136','Buenaflor','Samuel','T','',NULL,NULL,NULL,NULL,NULL,NULL),('22-00137','Manlapig','Felicia','J','',NULL,NULL,NULL,NULL,NULL,NULL),('22-00138','Aguas','Roberto','S','',NULL,NULL,NULL,NULL,NULL,NULL),('22-00139','Celestino','Beatriz','O','',NULL,NULL,NULL,NULL,NULL,NULL),('22-00140','Villarica','Renato','I','',NULL,NULL,NULL,NULL,NULL,NULL),('22-00141','Cabrales','Isabel','L','',NULL,NULL,NULL,NULL,NULL,NULL),('22-00142','Tibayan','Antonio','Y','',NULL,NULL,NULL,NULL,NULL,NULL),('22-00143','Alcantara','Luis','U','II',NULL,NULL,NULL,NULL,NULL,NULL),('22-00144','Belmonte','Joanna','A','',NULL,NULL,NULL,NULL,NULL,NULL),('22-00145','Marasigan','Henry','R','',NULL,NULL,NULL,NULL,NULL,NULL),('22-00146','Tamayo','Celina','J','',NULL,NULL,NULL,NULL,NULL,NULL),('22-00147','Garcia','Pablo','D','',NULL,NULL,NULL,NULL,NULL,NULL),('22-00148','Legaspi','Ines','E','',NULL,NULL,NULL,NULL,NULL,NULL),('22-00149','Evangelista','Rolando','C','',NULL,NULL,NULL,NULL,NULL,NULL),('22-00150','Laxamana','Bianca','W','',NULL,NULL,NULL,NULL,NULL,NULL),('22-00221','Briones','Vera','A','',NULL,NULL,NULL,NULL,NULL,NULL),('22-00222','Bautista','Gloria','B','',NULL,NULL,NULL,NULL,NULL,NULL),('22-00223','Vasquez','Francisco','P','',NULL,NULL,NULL,NULL,NULL,NULL),('22-00224','Serrano','Mauricio','T','',NULL,NULL,NULL,NULL,NULL,NULL),('22-00225','Villarroel','Leila','R','',NULL,NULL,NULL,NULL,NULL,NULL),('22-00226','Galiano','Rochelle','S','',NULL,NULL,NULL,NULL,NULL,NULL),('22-00227','Palma','Chester','B','',NULL,NULL,NULL,NULL,NULL,NULL),('22-00228','Guevara','Catherine','C','',NULL,NULL,NULL,NULL,NULL,NULL),('22-00229','Santos','Leo','O','',NULL,NULL,NULL,NULL,NULL,NULL),('22-00230','Rosales','Gina','P','',NULL,NULL,NULL,NULL,NULL,NULL),('23-00051','Abella','Marco','S','',NULL,NULL,NULL,NULL,NULL,NULL),('23-00052','Zamora','Lucia','X','',NULL,NULL,NULL,NULL,NULL,NULL),('23-00053','Alvarez','Rogelio','Y','',NULL,NULL,NULL,NULL,NULL,NULL),('23-00054','Vergara','Isidro','A','',NULL,NULL,NULL,NULL,NULL,NULL),('23-00055','Salazar','Lea','B','III',NULL,NULL,NULL,NULL,NULL,NULL),('23-00056','Lagman','Rosa','C','',NULL,NULL,NULL,NULL,NULL,NULL),('23-00057','Caballero','Joaquin','D','II',NULL,NULL,NULL,NULL,NULL,NULL),('23-00058','Santiago','Angelica','E','',NULL,NULL,NULL,NULL,NULL,NULL),('23-00059','Ramirez','Alfredo','F','',NULL,NULL,NULL,NULL,NULL,NULL),('23-00060','Pineda','Diana','G','',NULL,NULL,NULL,NULL,NULL,NULL),('23-00061','Burgos','Oscar','H','',NULL,NULL,NULL,NULL,NULL,NULL),('23-00062','Tan','Lourdes','I','',NULL,NULL,NULL,NULL,NULL,NULL),('23-00063','Reyes','Julio','J','',NULL,NULL,NULL,NULL,NULL,NULL),('23-00064','Calderon','Estrella','K','',NULL,NULL,NULL,NULL,NULL,NULL),('23-00065','Mercado','Vicente','L','IV',NULL,NULL,NULL,NULL,NULL,NULL),('23-00066','Toribio','Arnel','M','',NULL,NULL,NULL,NULL,NULL,NULL),('23-00067','Del Mundo','Aurora','N','',NULL,NULL,NULL,NULL,NULL,NULL),('23-00068','Feliciano','Nestor','O','',NULL,NULL,NULL,NULL,NULL,NULL),('23-00069','Buenaventura','Cynthia','P','',NULL,NULL,NULL,NULL,NULL,NULL),('23-00070','Soriano','Gregory','Q','',NULL,NULL,NULL,NULL,NULL,NULL),('23-00071','Lazaro','Martha','R','',NULL,NULL,NULL,NULL,NULL,NULL),('23-00072','Jacinto','Frederick','S','II',NULL,NULL,NULL,NULL,NULL,NULL),('23-00073','Escobar','Melinda','T','',NULL,NULL,NULL,NULL,NULL,NULL),('23-00074','Pe?a','Gabriel','U','',NULL,NULL,NULL,NULL,NULL,NULL),('23-00075','Tolentino','Clarence','V','',NULL,NULL,NULL,NULL,NULL,NULL),('23-00076','Quintana','Joy','W','',NULL,NULL,NULL,NULL,NULL,NULL),('23-00077','Cabrera','Samuel','X','',NULL,NULL,NULL,NULL,NULL,NULL),('23-00078','Palma','Cristina','Y','',NULL,NULL,NULL,NULL,NULL,NULL),('23-00079','Santos','Joel','Z','',NULL,NULL,NULL,NULL,NULL,NULL),('23-00080','Dimaano','Veronica','A','',NULL,NULL,NULL,NULL,NULL,NULL),('23-00081','Arroyo','Ricardo','B','',NULL,NULL,NULL,NULL,NULL,NULL),('23-00082','Valencia','Teresa','C','Jr',NULL,NULL,NULL,NULL,NULL,NULL),('23-00083','Dizon','Emmanuel','D','',NULL,NULL,NULL,NULL,NULL,NULL),('23-00084','Carpio','Janice','E','',NULL,NULL,NULL,NULL,NULL,NULL),('23-00085','Guerrero','Francis','F','',NULL,NULL,NULL,NULL,NULL,NULL),('23-00086','Mata','Rene','G','',NULL,NULL,NULL,NULL,NULL,NULL),('23-00087','Ortega','Amelia','H','',NULL,NULL,NULL,NULL,NULL,NULL),('23-00088','Caluag','Benito','I','',NULL,NULL,NULL,NULL,NULL,NULL),('23-00089','Villamor','Marilou','J','',NULL,NULL,NULL,NULL,NULL,NULL),('23-00090','Cunanan','Alberto','K','',NULL,NULL,NULL,NULL,NULL,NULL),('23-00091','Sandoval','Elsa','L','',NULL,NULL,NULL,NULL,NULL,NULL),('23-00092','Magsaysay','Marvin','M','',NULL,NULL,NULL,NULL,NULL,NULL),('23-00093','Alcantara','Selena','N','',NULL,NULL,NULL,NULL,NULL,NULL),('23-00094','Manalang','Cristopher','O','III',NULL,NULL,NULL,NULL,NULL,NULL),('23-00095','Del Carmen','Bianca','P','',NULL,NULL,NULL,NULL,NULL,NULL),('23-00096','Galang','Edwin','Q','',NULL,NULL,NULL,NULL,NULL,NULL),('23-00097','Aquino','Angel','R','',NULL,NULL,NULL,NULL,NULL,NULL),('23-00098','Villanueva','Raquel','S','',NULL,NULL,NULL,NULL,NULL,NULL),('23-00099','Yap','Mario','T','',NULL,NULL,NULL,NULL,NULL,NULL),('23-00100','Perez','Victoria','U','Jr',NULL,NULL,NULL,NULL,NULL,NULL),('23-00211','Escobar','Adrian','D','',NULL,NULL,NULL,NULL,NULL,NULL),('23-00212','Agno','Patricia','T','',NULL,NULL,NULL,NULL,NULL,NULL),('23-00213','Pineda','Dennis','F','III',NULL,NULL,NULL,NULL,NULL,NULL),('23-00214','Magsaysay','Cristina','G','',NULL,NULL,NULL,NULL,NULL,NULL),('23-00215','San Antonio','Nina','W','',NULL,NULL,NULL,NULL,NULL,NULL),('23-00216','Raspa','Miguel','D','',NULL,NULL,NULL,NULL,NULL,NULL),('23-00217','Madlangbayan','Frankie','A','',NULL,NULL,NULL,NULL,NULL,NULL),('23-00218','Valdez','Isabel','V','',NULL,NULL,NULL,NULL,NULL,NULL),('23-00219','Calubiran','Andrea','L','',NULL,NULL,NULL,NULL,NULL,NULL),('23-00220','Del Mundo','Fernando','P','',NULL,NULL,NULL,NULL,NULL,NULL),('23-00246','haha','dafadfasdfasdf','fs','',NULL,NULL,NULL,NULL,NULL,NULL),('24-00001','Dela Cruz','Juan','A','Jr',NULL,NULL,NULL,NULL,NULL,NULL),('24-00002','Reyes','Maria','B','',NULL,NULL,NULL,NULL,NULL,NULL),('24-00003','Santos','Jose','K','III',NULL,NULL,NULL,NULL,NULL,NULL),('24-00004','Garcia','Anna','M','',NULL,NULL,NULL,NULL,NULL,NULL),('24-00005','Mendoza','Pedro','F','',NULL,NULL,NULL,NULL,NULL,NULL),('24-00006','Torres','Liza','D','Jr',NULL,NULL,NULL,NULL,NULL,NULL),('24-00007','Aquino','Ramon','P','',NULL,NULL,NULL,NULL,NULL,NULL),('24-00008','Gonzalez','Carmen','R','',NULL,NULL,NULL,NULL,NULL,NULL),('24-00009','Lopez','Esteban','H','',NULL,NULL,NULL,NULL,NULL,NULL),('24-00010','Pascual','Theresa','T','',NULL,NULL,NULL,NULL,NULL,NULL),('24-00011','Domingo','Carlo','G','',NULL,NULL,NULL,NULL,NULL,NULL),('24-00012','Fernandez','Angela','S','',NULL,NULL,NULL,NULL,NULL,NULL),('24-00013','Velasquez','Miguel','J','',NULL,NULL,NULL,NULL,NULL,NULL),('24-00014','Bautista','Sofia','E','',NULL,NULL,NULL,NULL,NULL,NULL),('24-00015','Delos Santos','Emilio','O','',NULL,NULL,NULL,NULL,NULL,NULL),('24-00016','Soriano','Rosanna','B','',NULL,NULL,NULL,NULL,NULL,NULL),('24-00017','Rivera','Andres','Y','II',NULL,NULL,NULL,NULL,NULL,NULL),('24-00018','Luna','Isabel','X','',NULL,NULL,NULL,NULL,NULL,NULL),('24-00019','Magbanua','Felipe','A','',NULL,NULL,NULL,NULL,NULL,NULL),('24-00020','Rizal','Clarissa','L','',NULL,NULL,NULL,NULL,NULL,NULL),('24-00021','Bonifacio','Gregorio','F','IV',NULL,NULL,NULL,NULL,NULL,NULL),('24-00022','Aguilar','Teresita','W','',NULL,NULL,NULL,NULL,NULL,NULL),('24-00023','Salvador','Eduardo','Z','',NULL,NULL,NULL,NULL,NULL,NULL),('24-00024','Manalo','Beatriz','V','',NULL,NULL,NULL,NULL,NULL,NULL),('24-00025','Cruz','Leandro','C','',NULL,NULL,NULL,NULL,NULL,NULL),('24-00026','Tagle','Irene','D','',NULL,NULL,NULL,NULL,NULL,NULL),('24-00027','Padilla','Romeo','Q','',NULL,NULL,NULL,NULL,NULL,NULL),('24-00028','Ramos','Cecilia','N','',NULL,NULL,NULL,NULL,NULL,NULL),('24-00029','Villanueva','Fernando','T','',NULL,NULL,NULL,NULL,NULL,NULL),('24-00030','Del Rosario','Victoria','J','III',NULL,NULL,NULL,NULL,NULL,NULL),('24-00031','Silva','Antonio','L','',NULL,NULL,NULL,NULL,NULL,NULL),('24-00032','Marquez','Corazon','M','',NULL,NULL,NULL,NULL,NULL,NULL),('24-00033','Espino','Roberto','P','',NULL,NULL,NULL,NULL,NULL,NULL),('24-00034','Montano','Amelia','O','',NULL,NULL,NULL,NULL,NULL,NULL),('24-00035','Valdez','Gerardo','G','',NULL,NULL,NULL,NULL,NULL,NULL),('24-00036','Campos','Juliana','F','',NULL,NULL,NULL,NULL,NULL,NULL),('24-00037','Castillo','Alfonso','I','',NULL,NULL,NULL,NULL,NULL,NULL),('24-00038','Navarro','Eleanor','K','',NULL,NULL,NULL,NULL,NULL,NULL),('24-00039','Ta?ada','Mariano','C','',NULL,NULL,NULL,NULL,NULL,NULL),('24-00040','Villareal','Consuelo','J','',NULL,NULL,NULL,NULL,NULL,NULL),('24-00041','Osmena','Francisco','N','Jr',NULL,NULL,NULL,NULL,NULL,NULL),('24-00042','Quezon','Esperanza','E','',NULL,NULL,NULL,NULL,NULL,NULL),('24-00043','Roxas','Elias','U','',NULL,NULL,NULL,NULL,NULL,NULL),('24-00044','Laurel','Patricia','X','',NULL,NULL,NULL,NULL,NULL,NULL),('24-00045','Aguinaldo','Daniel','B','',NULL,NULL,NULL,NULL,NULL,NULL),('24-00046','Andres','Carolina','H','',NULL,NULL,NULL,NULL,NULL,NULL),('24-00047','Estrada','Raul','R','',NULL,NULL,NULL,NULL,NULL,NULL),('24-00048','Vergara','Monica','T','',NULL,NULL,NULL,NULL,NULL,NULL),('24-00049','Perez','Arnulfo','Z','',NULL,NULL,NULL,NULL,NULL,NULL),('24-00050','Cayetano','Elisa','D','',NULL,NULL,NULL,NULL,NULL,NULL),('24-00201','Nobleza','Gilbert','T','',NULL,NULL,NULL,NULL,NULL,NULL),('24-00202','Sison','Cecilia','T','',NULL,NULL,NULL,NULL,NULL,NULL),('24-00203','Vega','Richard','P','Jr',NULL,NULL,NULL,NULL,NULL,NULL),('24-00204','Saavedra','Michael','R','',NULL,NULL,NULL,NULL,NULL,NULL),('24-00205','Belen','Carlos','N','',NULL,NULL,NULL,NULL,NULL,NULL),('24-00206','Rivera','Marietta','G','',NULL,NULL,NULL,NULL,NULL,NULL),('24-00207','Serna','Jovita','A','',NULL,NULL,NULL,NULL,NULL,NULL),('24-00208','Natividad','Louise','A','',NULL,NULL,NULL,NULL,NULL,NULL),('24-00209','Dela Cruz','Joshua','B','',NULL,NULL,NULL,NULL,NULL,NULL),('24-00210','Fuentes','Allan','L','',NULL,NULL,NULL,NULL,NULL,NULL),('999','Catapangan','Jessi','R.','',NULL,NULL,NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `student` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `subject`
--

DROP TABLE IF EXISTS `subject`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `subject` (
  `subject_code` varchar(10) NOT NULL,
  `subject_name` varchar(50) NOT NULL,
  `program_code` varchar(50) NOT NULL,
  `semester` varchar(50) NOT NULL,
  PRIMARY KEY (`subject_code`),
  KEY `program_code` (`program_code`),
  CONSTRAINT `subject_ibfk_1` FOREIGN KEY (`program_code`) REFERENCES `program` (`program_code`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `subject`
--

LOCK TABLES `subject` WRITE;
/*!40000 ALTER TABLE `subject` DISABLE KEYS */;
INSERT INTO `subject` VALUES ('COMP 104','Data Structure and Algorithms','BSIT','1st'),('COMP 105','Information Management','BSIT','1st'),('GEE 002','GE Elective 2: Living in the IT Era','BSIT','1st'),('IT 102','Quantitative Methods','BSIT','1st'),('IT 201','Platform Technologies','BSIT','1st'),('IT 202','OOP','BSIT','1st');
/*!40000 ALTER TABLE `subject` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `subject_assign`
--

DROP TABLE IF EXISTS `subject_assign`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `subject_assign` (
  `professor_id` varchar(50) NOT NULL,
  `subject_code` varchar(50) NOT NULL,
  `section_code` varchar(10) NOT NULL,
  `dept_code` varchar(10) NOT NULL,
  `day` enum('MON','TUE','WED','THU','FRI','SAT') NOT NULL,
  `time` varchar(20) NOT NULL,
  PRIMARY KEY (`subject_code`,`section_code`),
  KEY `professor_id` (`professor_id`),
  KEY `subject_code` (`subject_code`),
  KEY `section_code` (`section_code`),
  KEY `dept_code` (`dept_code`),
  CONSTRAINT `subject_assign_ibfk_1` FOREIGN KEY (`professor_id`) REFERENCES `professor` (`professor_id`),
  CONSTRAINT `subject_assign_ibfk_2` FOREIGN KEY (`subject_code`) REFERENCES `subject` (`subject_code`),
  CONSTRAINT `subject_assign_ibfk_4` FOREIGN KEY (`dept_code`) REFERENCES `department` (`dept_code`),
  CONSTRAINT `subject_assign_ibfk_5` FOREIGN KEY (`section_code`) REFERENCES `section_assign` (`section_code`),
  CONSTRAINT `subject_ibfk_5` FOREIGN KEY (`section_code`) REFERENCES `section_assign` (`section_code`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `subject_assign`
--

LOCK TABLES `subject_assign` WRITE;
/*!40000 ALTER TABLE `subject_assign` DISABLE KEYS */;
INSERT INTO `subject_assign` VALUES ('CCSPF01','COMP 104','BSIT2A','CCS','MON','8:00 AM - 11:00 AM'),('CCSPF01','COMP 104','BSIT2B','CCS','MON','2:30 PM - 5:30 PM'),('CCSPF01','COMP 104','BSIT2D','CCS','WED','2:30 PM - 5:30 PM'),('CCSPF01','COMP 105','BSIT2C','CCS','WED','11:00 AM - 2:00 PM'),('CCSPF06','GEE 002','BSIT2D','CCS','THU','11:00 AM - 2:00 PM'),('CCSPF07','IT 102','BSIT3B','CCS','WED','8:00 AM - 10:00 PM'),('CCSPF02','IT 201','BSIT2D','CCS','MON','2:30 PM - 5:30 PM');
/*!40000 ALTER TABLE `subject_assign` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user_account`
--

DROP TABLE IF EXISTS `user_account`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `user_account` (
  `account_id` varchar(10) NOT NULL,
  `email` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `user_type` varchar(50) NOT NULL,
  `question_no` varchar(10) NOT NULL,
  `answer` varchar(10) NOT NULL,
  PRIMARY KEY (`account_id`),
  KEY `question_no` (`question_no`),
  CONSTRAINT `user_account_ibfk_1` FOREIGN KEY (`question_no`) REFERENCES `question` (`question_no`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user_account`
--

LOCK TABLES `user_account` WRITE;
/*!40000 ALTER TABLE `user_account` DISABLE KEYS */;
INSERT INTO `user_account` VALUES ('23-00335','aldrinpogi01','shane','student','3','pamisa'),('23-00423','shaneph','shane','student','2','red'),('admin','bossaldrin','admin','admin','1','laura'),('prof','profako','oonga','professor','2','black');
/*!40000 ALTER TABLE `user_account` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary table structure for view `vfinal`
--

DROP TABLE IF EXISTS `vfinal`;
/*!50001 DROP VIEW IF EXISTS `vfinal`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `vfinal` AS SELECT
 1 AS `student_id`,
  1 AS `subject_code`,
  1 AS `section_code`,
  1 AS `no_of_absences`,
  1 AS `attendance_percentage`,
  1 AS `Q1_score`,
  1 AS `Q1_item`,
  1 AS `Q2_score`,
  1 AS `Q2_item`,
  1 AS `Q3_score`,
  1 AS `Q3_item`,
  1 AS `Q4_score`,
  1 AS `Q4_item`,
  1 AS `quiz_percentage`,
  1 AS `LAB1_score`,
  1 AS `LAB2_score`,
  1 AS `LAB3_score`,
  1 AS `LAB4_score`,
  1 AS `lab_percentage`,
  1 AS `case_study`,
  1 AS `final_exam_score`,
  1 AS `final_exam_item`,
  1 AS `final_exam_percentage`,
  1 AS `final_grade`,
  1 AS `remarks` */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `vmidterm`
--

DROP TABLE IF EXISTS `vmidterm`;
/*!50001 DROP VIEW IF EXISTS `vmidterm`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `vmidterm` AS SELECT
 1 AS `student_id`,
  1 AS `subject_code`,
  1 AS `section_code`,
  1 AS `no_of_absences`,
  1 AS `attendance_percentage`,
  1 AS `Q1_score`,
  1 AS `Q1_item`,
  1 AS `Q2_score`,
  1 AS `Q2_item`,
  1 AS `Q3_score`,
  1 AS `Q3_item`,
  1 AS `Q4_score`,
  1 AS `Q4_item`,
  1 AS `quiz_percentage`,
  1 AS `LAB1_score`,
  1 AS `LAB2_score`,
  1 AS `LAB3_score`,
  1 AS `LAB4_score`,
  1 AS `lab_percentage`,
  1 AS `case_study`,
  1 AS `recitation`,
  1 AS `mid_exam_score`,
  1 AS `mid_exam_item`,
  1 AS `mid_exam_percentage`,
  1 AS `midterm_grade`,
  1 AS `remarks` */;
SET character_set_client = @saved_cs_client;

--
-- Final view structure for view `vfinal`
--

/*!50001 DROP VIEW IF EXISTS `vfinal`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vfinal` AS select `f`.`student_id` AS `student_id`,`f`.`subject_code` AS `subject_code`,`f`.`section_code` AS `section_code`,`f`.`no_of_absences` AS `no_of_absences`,`fgw`.`attendance_percentage` AS `attendance_percentage`,`f`.`Q1_score` AS `Q1_score`,`f`.`Q1_item` AS `Q1_item`,`f`.`Q2_score` AS `Q2_score`,`f`.`Q2_item` AS `Q2_item`,`f`.`Q3_score` AS `Q3_score`,`f`.`Q3_item` AS `Q3_item`,`f`.`Q4_score` AS `Q4_score`,`f`.`Q4_item` AS `Q4_item`,`fgw`.`quiz_percentage` AS `quiz_percentage`,`f`.`LAB1_score` AS `LAB1_score`,`f`.`LAB2_score` AS `LAB2_score`,`f`.`LAB3_score` AS `LAB3_score`,`f`.`LAB4_score` AS `LAB4_score`,`fgw`.`lab_percentage` AS `lab_percentage`,`f`.`case_study` AS `case_study`,`f`.`final_exam_score` AS `final_exam_score`,`f`.`final_exam_item` AS `final_exam_item`,`fgw`.`final_exam_percentage` AS `final_exam_percentage`,`fgw`.`final_grade` AS `final_grade`,`fgw`.`remarks` AS `remarks` from (`final` `f` join `final_gw` `fgw` on(`f`.`student_id` = `fgw`.`student_id` and `f`.`subject_code` = `fgw`.`subject_code` and `f`.`section_code` = `fgw`.`section_code`)) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `vmidterm`
--

/*!50001 DROP VIEW IF EXISTS `vmidterm`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vmidterm` AS select `m`.`student_id` AS `student_id`,`m`.`subject_code` AS `subject_code`,`m`.`section_code` AS `section_code`,`m`.`no_of_absences` AS `no_of_absences`,`mgw`.`attendance_percentage` AS `attendance_percentage`,`m`.`Q1_score` AS `Q1_score`,`m`.`Q1_item` AS `Q1_item`,`m`.`Q2_score` AS `Q2_score`,`m`.`Q2_item` AS `Q2_item`,`m`.`Q3_score` AS `Q3_score`,`m`.`Q3_item` AS `Q3_item`,`m`.`Q4_score` AS `Q4_score`,`m`.`Q4_item` AS `Q4_item`,`mgw`.`quiz_percentage` AS `quiz_percentage`,`m`.`LAB1_score` AS `LAB1_score`,`m`.`LAB2_score` AS `LAB2_score`,`m`.`LAB3_score` AS `LAB3_score`,`m`.`LAB4_score` AS `LAB4_score`,`mgw`.`lab_percentage` AS `lab_percentage`,`m`.`case_study` AS `case_study`,`m`.`recitation` AS `recitation`,`m`.`mid_exam_score` AS `mid_exam_score`,`m`.`mid_exam_item` AS `mid_exam_item`,`mgw`.`mid_exam_percentage` AS `mid_exam_percentage`,`mgw`.`midterm_grade` AS `midterm_grade`,`mgw`.`remarks` AS `remarks` from (`midterm` `m` join `midterm_gw` `mgw` on(`m`.`student_id` = `mgw`.`student_id` and `m`.`subject_code` = `mgw`.`subject_code` and `m`.`section_code` = `mgw`.`section_code`)) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-12-12  2:15:18
