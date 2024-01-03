DROP DATABASE IF EXISTS `restaurant`;
CREATE DATABASE IF NOT EXISTS `restaurant`;
USE `restaurant`;

-- -- DISHNAMES -- --

DROP TABLE IF EXISTS `dishnames`;
CREATE TABLE `dishnames` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `DishName` varchar(45) NOT NULL,
  PRIMARY KEY (`Id`)
);

INSERT INTO `dishnames` VALUES (1,'Кордіал із чорної смородини'), (2,'Дальгона кава'), (3,'Суккоташ'), (4,'Цибулеві кільця'),(5,'Гарбузовий суп-пюре'),(6,'Ірландський чаудер'),(7,'Крильця Баффало'),(8,'Запечена індичка');

-- -- DISHES -- --

DROP TABLE IF EXISTS `dishes`;
CREATE TABLE `dishes` (
  `Food` varchar(45) NOT NULL,
  `Class` varchar(45) NOT NULL,
  `Kitchen` varchar(50) NOT NULL,
  `Composition` varchar(50) NOT NULL,
  `Price` int NOT NULL,
  `DishId` int NOT NULL,
   CONSTRAINT `FK_dishes_dishnames_id` FOREIGN KEY (`DishId`) REFERENCES `dishnames` (`Id`)
);

INSERT INTO `dishes` 
VALUES ('Кордіал із чорної смородини','Напої','Англійська кухня','чорна смородина,сахар,вода',100,1), 
	   ('Дальгона кава','Напої','Корейська кухня','розчинна кава,цукор,молоко',200,2), 
	   ('Суккоташ','Салати','Кухня США','кукурудза,місячна квасоля,помідори',300,3), 
	   ('Цибулеві кільця','Салати','Кухня США','цибуля, вершки, мука, яйця, соль та перець',400,4),
	   ('Гарбузовий суп-пюре','Супи','Кухня США','картопля, цибуля, часник, гарбуз',500,5),
	   ('Ірландський чаудер','Супи','Ірландська кухня','тріска, бекон, молоко, картопля',600,6),
	   ('Крильця Баффало','Другі страви','Кухня США','курячі крильця, масло, гострий соус чилі',700,7),
	   ('Запечена індичка','Другі страви','Кухня США','індичка, яблука, соус',800,8);
       
-- -- ORDERTYPES -- --

DROP TABLE IF EXISTS `ordertypes`;
CREATE TABLE `ordertypes` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `OrderName` varchar(45) NOT NULL,
  PRIMARY KEY (`Id`)
);

INSERT INTO `ordertypes` VALUES (1,'Замовлення'),(2,'Передзамовлення'),(3,'Банкет');
                            
-- -- ORDERS -- --

DROP TABLE IF EXISTS `orders`;
CREATE TABLE `orders` (
  `OrderId` int NOT NULL,
  `Dish` varchar(45) NOT NULL,
  `Status` varchar(45) NOT NULL,
  CONSTRAINT `FK_orders_ordertypes_id` FOREIGN KEY (`OrderId`) REFERENCES `ordertypes` (`Id`)
);

INSERT INTO `orders` VALUES ('1','3','Виконується'),('2','5','Виконується'),('3','8','Виконується');

-- -- USERTYPES -- --

DROP TABLE IF EXISTS `usertypes`;
CREATE TABLE `usertypes` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `UserName` varchar(45) NOT NULL,
  PRIMARY KEY (`Id`)
) ;

INSERT INTO `usertypes` VALUES (1,'Гість'),(2,'Клієнт'),(3,'Офіціант'),(4,'Менеджер');

-- -- USERS -- --

DROP TABLE IF EXISTS `users`;
CREATE TABLE `users` (
  `Login` varchar(45) NOT NULL,
  `Password` varchar(45) NOT NULL,
  `UserId` int NOT NULL,
  PRIMARY KEY (`Login`),
  CONSTRAINT `FK_users_usertypes_id` FOREIGN KEY (`UserId`) REFERENCES `usertypes` (`Id`)
);

INSERT INTO `users` VALUES ('Alex','godadmin',1),('Egor','admin19',1),('Roman','admin123',4),('Sasha','wp-admin',2),('Yuriy','qweadmin123',3);
