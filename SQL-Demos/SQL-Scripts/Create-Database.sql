-- 1. Направете база от данни с 2 таблици:​
-- Потребители​
-- ID,​
-- Име,​
-- Презиме,​
-- Фамилия,​
-- Година на раждане,​
-- Банкови сметки​
-- ID,​
-- Наименование,​
-- IBAN,​
-- Сума,​
-- Потребителско ID (за връзка с потребители),​
-- Разплащателна ли е?​
-- Вкарайте няколко потребителя, като всеки от тях нека да има по 2-3 сметки.​
-- Сложете backup на базата ви във вашето repository.​








DROP DATABASE IF EXISTS `sql_banking`;
CREATE DATABASE `sql_banking`; 
USE `sql_banking`;

SET NAMES utf8 ;
SET character_set_client = utf8mb4 ;

CREATE TABLE `clients` (
  `client_id` int(11) NOT NULL,
  `firstname` varchar(50) NOT NULL,
  `surname` varchar(50) NOT NULL,
  `familyname` varchar(50) NOT NULL,
  `yearofbirth` date NOT NULL,
  PRIMARY KEY (`client_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
INSERT INTO `clients` VALUES (1,'Orlin','Danielov','Romanov','1974-11-25');
INSERT INTO `clients` VALUES (2,'Chavdar','Teodorov','Zhelev','1978-07-01');
INSERT INTO `clients` VALUES (3,'Marko','Iskrenov','Vasev','1980-08-19');
INSERT INTO `clients` VALUES (4,'Mila','Borisova','Popova','1997-01-27');
INSERT INTO `clients` VALUES (5,'Yoana','Mladenova','Zhivkova','1991-03-30');

CREATE TABLE `bank_accounts` (
  `account_id` int(11) NOT NULL AUTO_INCREMENT,
  `client_id` int(11) NOT NULL,
  `statuse` varchar(50) DEFAULT NULL,
  `iban` varchar(50) NOT NULL,
  `sum_total` decimal NOT NULL,
  `is_itpaying` BIT, 
  PRIMARY KEY (`account_id`),
  KEY `FK_client_id` (`client_id`),
  CONSTRAINT `FK_client_id` FOREIGN KEY (`client_id`) REFERENCES `clients` (`client_id`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
INSERT INTO `bank_accounts` VALUES (1,1,'Credit','BG22RZBB91556667955149',2101,0);
INSERT INTO `bank_accounts` VALUES (2,1,'Credit','BG22RZBB91556667955149',1500,0);
INSERT INTO `bank_accounts` VALUES (3,1,'Paying','BG22RZBB91556667955149',75000,1);
INSERT INTO `bank_accounts` VALUES (4,2,'Credit','BG75IORT80942462248252',5700,0);
INSERT INTO `bank_accounts` VALUES (5,2,'Credit','BG75IORT80942462248252',10000,0);
INSERT INTO `bank_accounts` VALUES (6,2,'Paying','BG75IORT80942462248252',2650,1);
INSERT INTO `bank_accounts` VALUES (7,3,'Credit','BG31UNCR70008435855645',1000,0);
INSERT INTO `bank_accounts` VALUES (8,3,'Credit','BG31UNCR70008435855645',1000,0);
INSERT INTO `bank_accounts` VALUES (9,3,'Credit','BG31UNCR70008435855645',500,0);
INSERT INTO `bank_accounts` VALUES (10,4,'Credit','BG19BNPA94405539357941',10000,0);
INSERT INTO `bank_accounts` VALUES (11,4,'Credit','BG19BNPA94405539357941',6000,0);
INSERT INTO `bank_accounts` VALUES (12,4,'Credit','BG19BNPA94405539357941',3000,0);
INSERT INTO `bank_accounts` VALUES (13,5,'Paying','BG97TTBB94001892166873',30000,1);
INSERT INTO `bank_accounts` VALUES (14,5,'Paying','BG97TTBB94001892166873',65000,1);