-- MySQL dump 10.13  Distrib 8.0.23, for Win64 (x86_64)
--
-- Host: localhost    Database: minimarket_db
-- ------------------------------------------------------
-- Server version	8.0.23

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
-- Table structure for table `employees`
--

DROP TABLE IF EXISTS `employees`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employees` (
  `id` int NOT NULL AUTO_INCREMENT,
  `full_name` varchar(45) DEFAULT NULL,
  `address` varchar(45) DEFAULT NULL,
  `contact_number` varchar(45) DEFAULT NULL,
  `role` varchar(45) DEFAULT NULL,
  `username` varchar(45) DEFAULT NULL,
  `status` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `username_UNIQUE` (`username`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employees`
--

LOCK TABLES `employees` WRITE;
/*!40000 ALTER TABLE `employees` DISABLE KEYS */;
INSERT INTO `employees` VALUES (1,'Daniel Rokach','Hertzel 25, Ashdod','0542118715','Administrator','admin','Active'),(2,'Gala Libster','Rimon 5, Ashdod','0525667153','Cashier','pigeon','Active'),(3,'Barney Bone','Hamaccabim 25, Holon','0557886215','Warehouse clerk','woof','Active'),(4,'Shimon Shimon','Bialik 29, Ashkelon','0548555999','Cashier','Shimi','Vacation'),(5,'Elik Gabot','Hamaccabim 25, Holon','0528888111','WarehouseClerk','Elikopter','Active');
/*!40000 ALTER TABLE `employees` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `products`
--

DROP TABLE IF EXISTS `products`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `products` (
  `number` int NOT NULL AUTO_INCREMENT,
  `code` varchar(45) DEFAULT NULL,
  `product_name` varchar(45) DEFAULT NULL,
  `description` varchar(45) DEFAULT NULL,
  `category` varchar(45) DEFAULT NULL,
  `price` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`number`)
) ENGINE=InnoDB AUTO_INCREMENT=56 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `products`
--

LOCK TABLES `products` WRITE;
/*!40000 ALTER TABLE `products` DISABLE KEYS */;
INSERT INTO `products` VALUES (1,'A0001','Cucamber','1 KG','Fruits And Vegetables','6.5'),(2,'A0002','Tomato','1 KG','Fruits And Vegetables','6.9'),(3,'A0003','Onion','1 KG','Fruits And Vegetables','5.9'),(4,'A0004','Potato','1 KG','Fruits And Vegetables','6.9'),(5,'A0005','Orange','1 KG','Fruits And Vegetables','5.9'),(6,'A0006','Apple','1 KG','Fruits And Vegetables','10.9'),(7,'A0007','Strawberry','1 KG','Fruits And Vegetables','19.90'),(8,'A0008','Bannana','1 KG','Fruits And Vegetables','5.9'),(9,'A0009','Avocado','1 KG','Fruits And Vegetables','9.9'),(10,'A0010','Pineapple','1 KG','Fruits And Vegetables','29.9'),(11,'A0011','Grapes','1 KG','Fruits And Vegetables','36.9'),(12,'A0012','Muller Yogurt','150 gram, 3% fat','Diary','5.0'),(13,'A0013','Yoplait Yogurt','150 gram, 3% fat','Diary','5.0'),(14,'A0014','Go Yogurt','200 gram','Diary','5.7'),(15,'A0015','Tnuva Milk','1 Liter, 3% fat','Diary','5.94'),(16,'A0016','Tara Milk','1 Liter, 3% fat','Diary','5.94'),(17,'A0017','Tnuva Milk','1.5 Liter, 3% fat','Diary','8.91'),(18,'A0018','Tara Milk','2 Liter, 3% fat','Diary','11.8'),(19,'A0019','Tnuva Milk','1 Liter, 1% fat','Diary','5.59'),(20,'A0020','Eggs','12 units, M','Diary','10.4'),(21,'A0021','Eggs','12 units, L','Diary','11.3'),(22,'A0022','Eggs','30 units, M','Diary','26.0'),(23,'A0023','Eggs','30 units, L','Diary','28.25'),(24,'A0024','Farmers Cheese','250 gram. 3%fat','Diary','4.8'),(25,'A0025','Gaude Cheese','400 gram, 27% fat','Diary','18.0'),(26,'A0026','Mozzarella Cheese Slices','400 gram, 28% fat','Diary','27.8'),(27,'A0027','Chicken Breast','1 KG','Meat','31.9'),(28,'A0028','Chicken Wings','1 KG','Meat','11.9'),(29,'A0029','Chicken Thigh','1 KG','Meat','54.9'),(30,'A0030','Brioche Bread Sliced','500 gram','Baked And Bread','17.9'),(31,'A0031','Rye Bread Sliced','750 gram','Baked And Bread','14.9'),(32,'A0032','White Bread Sliced','500 gram','Baked And Bread','9.2'),(33,'A0033','Vodka Russian Standard','700ml, 40% alcohol','Alcohol And Beverages','69.9'),(34,'A0034','Vodka smirnoff','700ml, 40% alcohol','Alcohol And Beverages','64.9'),(35,'A0035','Whisky Black Label','700ml, 40% alcohol','Alcohol And Beverages','119.9'),(36,'A0036','Whisky Jameson','750ml, 40% alcohol','Alcohol And Beverages','159.9'),(37,'A0037','Whisky Jack Daniels','700ml, 40% alcohol','Alcohol And Beverages','119.9'),(38,'A0038','Mineral Water','6 pack of 1.5 Liter','Alcohol And Beverages','12.7'),(39,'A0039','Olive Oil','750ml','Cooking','39.9'),(40,'A0040','Olive Oil Spray','148ml','Cooking','12.9'),(41,'A0041','Salt','1 KG','Cooking','8.9'),(42,'A0042','Sugar','1 KG','Cooking','7.9'),(43,'A0043','Bread Crumbs','350 gram','Cooking','7.8'),(44,'A0044','Honey','250 gram','Cooking','15.5');
/*!40000 ALTER TABLE `products` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `stock`
--

DROP TABLE IF EXISTS `stock`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `stock` (
  `number` int NOT NULL AUTO_INCREMENT,
  `code` varchar(45) DEFAULT NULL,
  `product_name` varchar(45) DEFAULT NULL,
  `description` varchar(45) DEFAULT NULL,
  `quantity` int DEFAULT NULL,
  PRIMARY KEY (`number`)
) ENGINE=InnoDB AUTO_INCREMENT=45 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `stock`
--

LOCK TABLES `stock` WRITE;
/*!40000 ALTER TABLE `stock` DISABLE KEYS */;
INSERT INTO `stock` VALUES (1,'A0001','Cucamber','1 KG',11),(2,'A0002','Tomato','1 KG',9),(3,'A0003','Onion','1 KG',10),(4,'A0004','Potato','1 KG',20),(5,'A0005','Orange','1 KG',13),(6,'A0006','Apple','1 KG',11),(7,'A0007','Strawberry','1 KG',8),(8,'A0008','Bannana','1 KG',7),(9,'A0009','Avocado','1 KG',9),(10,'A0010','Pineapple','1 KG',8),(11,'A0011','Grapes','1 KG',2),(12,'A0012','Muller Yogurt','150 gram, 3% fat',11),(13,'A0013','Yoplait Yugurt','150 gram, 3% fat',23),(14,'A0014','Go Yugurt','200 gram',3),(15,'A0015','Tnuva Milk','1 Liter, 3% fat',46),(16,'A0016','Tara Milk','1 Liter, 3% fat',19),(17,'A0017','Tnuva Milk','1.5 Liter, 3% fat',2),(18,'A0018','Tara Milk','2 Liter, 3% fat',12),(19,'A0019','Tnuva Milk','1 Liter, 1% fat',15),(20,'A0020','Eggs','12 units, M',22),(21,'A0021','Eggs','12 units, L',33),(22,'A0022','Eggs','30 units, M',19),(23,'A0023','Eggs','30 units, L',19),(24,'A0024','Farmers Cheese','250 gram. 3%fat',22),(25,'A0025','Gauda Cheese','400 gram, 27% fat',31),(26,'A0026','Mozzarella Cheese Slices','400 gram, 28% fat',13),(27,'A0027','Chicken Breast','1 KG',22),(28,'A0028','Chicken wings','1 KG',28),(29,'A0029','Chicken Thigh','1 KG',29),(30,'A0030','Brioche Bread Sliced','500 gram',37),(31,'A0031','Rye Bread Sliced','750 gram',23),(32,'A0032','White Bread Sliced','500 gram',25),(33,'A0033','Vodka Russian Standard','700ml, 40% alcohol',17),(34,'A0034','Vodka smirnoff','700ml, 40% alcohol',14),(35,'A0035','Whisky Black Label','700ml, 40% alcohol',10),(36,'A0036','Whisky Jameson','750ml, 40% alcohol',14),(37,'A0037','Whisky Jack Daniels','700ml, 40% alcohol',20),(38,'A0038','Mineral Water','6 pack of 1.5 Liter',32),(39,'A0039','Olive oil','750ml',15),(40,'A0040','Olive oil Spray','148ml',18),(41,'A0041','Salt','1 KG',51),(42,'A0042','Sugar','1 KG',54),(43,'A0043','Bread Crumbs','350 gram',38),(44,'A0044','Honey','250 gram',11);
/*!40000 ALTER TABLE `stock` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `username` varchar(45) NOT NULL,
  `password` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES ('admin','admin'),('pigeon','1234'),('shimi','1234'),('woof','1221');
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

-- Dump completed on 2022-05-07 12:49:31
