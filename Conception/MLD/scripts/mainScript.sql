SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Drop and re-create database
-- -----------------------------------------------------
DROP DATABASE IF EXISTS `ticketing`;
CREATE DATABASE ticketing;
USE ticketing;


-- -----------------------------------------------------
-- Schema ticketing
-- -----------------------------------------------------
DROP SCHEMA IF EXISTS `ticketing` ;

-- -----------------------------------------------------
-- Schema ticketing
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `ticketing` DEFAULT CHARACTER SET utf8 ;
USE `ticketing` ;

-- -----------------------------------------------------
-- Table `ticketing`.`roles`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `ticketing`.`roles` ;

CREATE TABLE IF NOT EXISTS `ticketing`.`roles` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;

CREATE UNIQUE INDEX `id_UNIQUE` ON `ticketing`.`roles` (`id` ASC);

CREATE UNIQUE INDEX `name_UNIQUE` ON `ticketing`.`roles` (`name` ASC);


-- -----------------------------------------------------
-- Table `ticketing`.`people`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `ticketing`.`people` ;

CREATE TABLE IF NOT EXISTS `ticketing`.`people` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `lastname` VARCHAR(45) NOT NULL,
  `firstname` VARCHAR(45) NOT NULL,
  `phoneNumber` VARCHAR(13) NULL,
  `email` VARCHAR(50) NOT NULL,
  `password` VARCHAR(45) NOT NULL,
  `role_id` INT NOT NULL,
  PRIMARY KEY (`id`),
  CONSTRAINT `fk_people_roles`
    FOREIGN KEY (`role_id`)
    REFERENCES `ticketing`.`roles` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

CREATE UNIQUE INDEX `id_UNIQUE` ON `ticketing`.`people` (`id` ASC);

CREATE UNIQUE INDEX `uniquePerson` ON `ticketing`.`people` (`email` ASC);

CREATE UNIQUE INDEX `phoneNumber_UNIQUE` ON `ticketing`.`people` (`phoneNumber` ASC);

CREATE INDEX `fk_people_roles_idx` ON `ticketing`.`people` (`role_id` ASC);


-- -----------------------------------------------------
-- Table `ticketing`.`categories`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `ticketing`.`categories` ;

CREATE TABLE IF NOT EXISTS `ticketing`.`categories` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;

CREATE UNIQUE INDEX `id_UNIQUE` ON `ticketing`.`categories` (`id` ASC);

CREATE UNIQUE INDEX `name_UNIQUE` ON `ticketing`.`categories` (`name` ASC);


-- -----------------------------------------------------
-- Table `ticketing`.`states`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `ticketing`.`states` ;

CREATE TABLE IF NOT EXISTS `ticketing`.`states` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;

CREATE UNIQUE INDEX `id_UNIQUE` ON `ticketing`.`states` (`id` ASC);

CREATE UNIQUE INDEX `name_UNIQUE` ON `ticketing`.`states` (`name` ASC);


-- -----------------------------------------------------
-- Table `ticketing`.`tickets`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `ticketing`.`tickets` ;

CREATE TABLE IF NOT EXISTS `ticketing`.`tickets` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `title` VARCHAR(45) NOT NULL,
  `description` LONGTEXT NOT NULL,
  `category_id` INT NOT NULL,
  `state_id` INT NOT NULL,
  `manager_id` INT NOT NULL,
  `openingDate` DATETIME NOT NULL,
  `openingPerson_id` INT NOT NULL,
  `closingDate` DATETIME NULL,
  `closingPerson_id` INT NULL,
  `lastModifiedDate` DATETIME NULL,
  `lastModifiedPerson_id` INT NOT NULL,
  PRIMARY KEY (`id`),
  CONSTRAINT `fk_tickets_categories1`
    FOREIGN KEY (`category_id`)
    REFERENCES `ticketing`.`categories` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_tickets_states1`
    FOREIGN KEY (`state_id`)
    REFERENCES `ticketing`.`states` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_tickets_people1`
    FOREIGN KEY (`openingPerson_id`)
    REFERENCES `ticketing`.`people` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_tickets_people2`
    FOREIGN KEY (`manager_id`)
    REFERENCES `ticketing`.`people` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_tickets_people3`
    FOREIGN KEY (`lastModifiedPerson_id`)
    REFERENCES `ticketing`.`people` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_tickets_people4`
    FOREIGN KEY (`closingPerson_id`)
    REFERENCES `ticketing`.`people` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

CREATE UNIQUE INDEX `id_UNIQUE` ON `ticketing`.`tickets` (`id` ASC);

CREATE INDEX `fk_tickets_categories1_idx` ON `ticketing`.`tickets` (`category_id` ASC);

CREATE INDEX `fk_tickets_states1_idx` ON `ticketing`.`tickets` (`state_id` ASC);

CREATE INDEX `fk_tickets_people1_idx` ON `ticketing`.`tickets` (`openingPerson_id` ASC);

CREATE INDEX `fk_tickets_people2_idx` ON `ticketing`.`tickets` (`manager_id` ASC);

CREATE INDEX `fk_tickets_people3_idx` ON `ticketing`.`tickets` (`lastModifiedPerson_id` ASC);

CREATE INDEX `fk_tickets_people4_idx` ON `ticketing`.`tickets` (`closingPerson_id` ASC);


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

-- -----------------------------------------------------
-- Donn??es de bases
-- -----------------------------------------------------

INSERT INTO roles (name) VALUES ('Utilisateur');
INSERT INTO roles (name) VALUES ('Technicien');
INSERT INTO roles (name) VALUES ('admin');

INSERT INTO states (name) VALUES ('En Attente');
INSERT INTO states (name) VALUES ('Ouvert');
INSERT INTO states (name) VALUES ('R??solu');

INSERT INTO categories (name) VALUES ('Hardware');
INSERT INTO categories (name) VALUES ('Logiciel');
INSERT INTO categories (name) VALUES ('R??seau');
INSERT INTO categories (name) VALUES ('Inconnu');
INSERT INTO categories (name) VALUES ('?? d??t??rminer');


CREATE USER 'admin'@'%' IDENTIFIED BY 'Pa$$w0rd'; -- % signifie venant de partout, par seulement pour le localhost
GRANT SELECT, INSERT, UPDATE, DELETE, CREATE, ALTER on *.* TO 'admin'@'%'; -- *.* signifie partout (pr??f??rable de modifier)


