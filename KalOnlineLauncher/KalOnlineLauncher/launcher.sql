/*
SQLyog Ultimate - MySQL GUI v8.2 
MySQL - 5.1.56-community-log : Database - arturass_updater
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`arturass_updater` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `arturass_updater`;

/*Table structure for table `args` */

DROP TABLE IF EXISTS `args`;

CREATE TABLE `args` (
  `aid` int(11) NOT NULL AUTO_INCREMENT,
  `value` varchar(999) DEFAULT NULL,
  UNIQUE KEY `aid` (`aid`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

/*Data for the table `args` */

insert  into `args`(`aid`,`value`) values (1,'/load /config 654rj');

/*Table structure for table `md5` */

DROP TABLE IF EXISTS `md5`;

CREATE TABLE `md5` (
  `mid` int(11) NOT NULL AUTO_INCREMENT,
  `file` varchar(999) DEFAULT NULL,
  `hash` varchar(999) DEFAULT NULL,
  UNIQUE KEY `mid` (`mid`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

/*Data for the table `md5` */

insert  into `md5`(`mid`,`file`,`hash`) values (1,'engine.exe','4451b5068d6eed5d81de116b2f55d19c'),(2,'dbghelp.dll','3b5f0bf4125688a531fa21c823ea6193');

/*Table structure for table `notes` */

DROP TABLE IF EXISTS `notes`;

CREATE TABLE `notes` (
  `nid` int(11) NOT NULL AUTO_INCREMENT,
  `text` varchar(999) DEFAULT NULL,
  UNIQUE KEY `nid` (`nid`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

/*Data for the table `notes` */

insert  into `notes`(`nid`,`text`) values (2,'October 19th: Security update, download from website. Welcome to the Long Cat Kal Open Beta 2010, please report any bugs to arty@arturasserver.com. Just to clarify; there will NOT be a wipe or reset at the end of the beta');

/*Table structure for table `updates` */

DROP TABLE IF EXISTS `updates`;

CREATE TABLE `updates` (
  `uid` int(11) NOT NULL AUTO_INCREMENT,
  `version` decimal(2,2) DEFAULT NULL,
  `url` varchar(999) DEFAULT NULL,
  `notes` varchar(999) DEFAULT NULL,
  UNIQUE KEY `uid` (`uid`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=latin1;

/*Data for the table `updates` */

insert  into `updates`(`uid`,`version`,`url`,`notes`) values (5,'0.00','',''),(14,'0.12','http://arturasserver.com/uploads/64/update_0_12.zip','Added Lucky Key and Lucky stone to F1 Menu'),(15,'0.13','http://arturasserver.com/update_1_00.zip','Increased Drop rate, Added Bead of Fire (Long Cat\'s Eyes), Added job change npc in temp fort ([Turd Burgler]Zenko)'),(16,'0.14','http://arturasserver.com/uploads/69/update_0_14.zip','Misc Changes');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
