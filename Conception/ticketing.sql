-- --------------------------------------------------------
-- Hôte:                         192.168.59.155
-- Version du serveur:           5.5.62-0+deb8u1 - (Debian)
-- SE du serveur:                debian-linux-gnu
-- HeidiSQL Version:             11.3.0.6295
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Listage de la structure de la base pour ticketing
CREATE DATABASE IF NOT EXISTS `ticketing` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `ticketing`;

-- Listage de la structure de la table ticketing. categories
CREATE TABLE IF NOT EXISTS `categories` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(45) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`),
  UNIQUE KEY `name_UNIQUE` (`name`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

-- Listage des données de la table ticketing.categories : ~4 rows (environ)
/*!40000 ALTER TABLE `categories` DISABLE KEYS */;
INSERT INTO `categories` (`id`, `name`) VALUES
	(1, 'Hardware'),
	(4, 'Inconnu'),
	(2, 'Logiciel'),
	(3, 'Réseau');
/*!40000 ALTER TABLE `categories` ENABLE KEYS */;

-- Listage de la structure de la table ticketing. people
CREATE TABLE IF NOT EXISTS `people` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `lastname` varchar(45) NOT NULL,
  `firstname` varchar(45) NOT NULL,
  `phoneNumber` varchar(13) DEFAULT NULL,
  `email` varchar(50) NOT NULL,
  `password` varchar(45) NOT NULL,
  `role_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`),
  UNIQUE KEY `uniquePerson` (`email`),
  UNIQUE KEY `phoneNumber_UNIQUE` (`phoneNumber`),
  KEY `fk_people_roles_idx` (`role_id`),
  CONSTRAINT `fk_people_roles` FOREIGN KEY (`role_id`) REFERENCES `roles` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

-- Listage des données de la table ticketing.people : ~5 rows (environ)
/*!40000 ALTER TABLE `people` DISABLE KEYS */;
INSERT INTO `people` (`id`, `lastname`, `firstname`, `phoneNumber`, `email`, `password`, `role_id`) VALUES
	(2, 'Cuany', 'Simon', '0798568405', 'simon.cuany@cpnv.ch', 'Pa$$w0rd', 2),
	(3, 'Volery', 'Sven', '0798474910', 'sven.volery@cpnv.ch', 'Pa$$w0rd', 2),
	(4, 'tech', 'toto', '123', 'a@a.a', 'a', 2),
	(5, 'User', 'tata', '124', 'b@b.b', 'b', 1),
	(6, 'Fanha', 'Yann', '0799173884', 'yann.fanha-dias@cpnv.ch', 'Pa$$w0rd', 2);
/*!40000 ALTER TABLE `people` ENABLE KEYS */;

-- Listage de la structure de la table ticketing. roles
CREATE TABLE IF NOT EXISTS `roles` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(45) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`),
  UNIQUE KEY `name_UNIQUE` (`name`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

-- Listage des données de la table ticketing.roles : ~3 rows (environ)
/*!40000 ALTER TABLE `roles` DISABLE KEYS */;
INSERT INTO `roles` (`id`, `name`) VALUES
	(3, 'admin'),
	(2, 'Technicien'),
	(1, 'Utilisateur');
/*!40000 ALTER TABLE `roles` ENABLE KEYS */;

-- Listage de la structure de la table ticketing. states
CREATE TABLE IF NOT EXISTS `states` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(45) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`),
  UNIQUE KEY `name_UNIQUE` (`name`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

-- Listage des données de la table ticketing.states : ~4 rows (environ)
/*!40000 ALTER TABLE `states` DISABLE KEYS */;
INSERT INTO `states` (`id`, `name`) VALUES
	(1, 'En Attente'),
	(4, 'Fermé'),
	(2, 'Ouvert'),
	(3, 'Résolu');
/*!40000 ALTER TABLE `states` ENABLE KEYS */;

-- Listage de la structure de la table ticketing. tickets
CREATE TABLE IF NOT EXISTS `tickets` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `title` varchar(45) NOT NULL,
  `description` longtext NOT NULL,
  `category_id` int(11) NOT NULL,
  `state_id` int(11) NOT NULL,
  `manager_id` int(11) NOT NULL,
  `openingDate` datetime NOT NULL,
  `openingPerson_id` int(11) NOT NULL,
  `closingDate` datetime DEFAULT NULL,
  `closingPerson_id` int(11) DEFAULT NULL,
  `lastModifiedDate` datetime DEFAULT NULL,
  `lastModifiedPerson_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`,`title`,`description`(100)) USING BTREE,
  KEY `fk_tickets_categories1_idx` (`category_id`),
  KEY `fk_tickets_states1_idx` (`state_id`),
  KEY `fk_tickets_people1_idx` (`openingPerson_id`),
  KEY `fk_tickets_people2_idx` (`manager_id`),
  KEY `fk_tickets_people3_idx` (`lastModifiedPerson_id`),
  KEY `fk_tickets_people4_idx` (`closingPerson_id`),
  CONSTRAINT `fk_tickets_people1` FOREIGN KEY (`openingPerson_id`) REFERENCES `people` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_tickets_people2` FOREIGN KEY (`manager_id`) REFERENCES `people` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_tickets_people3` FOREIGN KEY (`lastModifiedPerson_id`) REFERENCES `people` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_tickets_people4` FOREIGN KEY (`closingPerson_id`) REFERENCES `people` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_tickets_states1` FOREIGN KEY (`state_id`) REFERENCES `states` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=36 DEFAULT CHARSET=utf8;

-- Listage des données de la table ticketing.tickets : ~1 rows (environ)
/*!40000 ALTER TABLE `tickets` DISABLE KEYS */;
INSERT INTO `tickets` (`id`, `title`, `description`, `category_id`, `state_id`, `manager_id`, `openingDate`, `openingPerson_id`, `closingDate`, `closingPerson_id`, `lastModifiedDate`, `lastModifiedPerson_id`) VALUES
	(35, 'Au secours', 'Problème avec mon imprimante, elle parle', 4, 1, 6, '2022-01-21 12:08:33', 5, NULL, NULL, '2022-01-21 12:08:33', 5);
/*!40000 ALTER TABLE `tickets` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;

CREATE USER 'admin'@'%' IDENTIFIED BY 'Pa$$w0rd';
GRANT SELECT, INSERT, UPDATE, DELETE, CREATE, ALTER on *.* TO 'admin'@'%';