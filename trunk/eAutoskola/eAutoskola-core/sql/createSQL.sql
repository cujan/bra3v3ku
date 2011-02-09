SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL';

DROP SCHEMA IF EXISTS `e-autoskola` ;
CREATE SCHEMA IF NOT EXISTS `e-autoskola` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci ;
USE `e-autoskola` ;

-- -----------------------------------------------------
-- Table `e-autoskola`.`vseobecneUdaje`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `e-autoskola`.`vseobecneUdaje` ;

CREATE  TABLE IF NOT EXISTS `e-autoskola`.`vseobecneUdaje` (
  `id` INT NOT NULL AUTO_INCREMENT ,
  `nazovOrganizacie` VARCHAR(45) NULL ,
  `ulica` VARCHAR(45) NULL ,
  `ulicaCislo` VARCHAR(45) NULL ,
  `mesto` VARCHAR(45) NULL ,
  `psc` VARCHAR(45) NULL ,
  `ico` VARCHAR(45) NULL ,
  `dic` VARCHAR(45) NULL ,
  `telefon` VARCHAR(45) NULL ,
  `mobil` VARCHAR(45) NULL ,
  `email` VARCHAR(45) NULL ,
  `www` VARCHAR(45) NULL ,
  PRIMARY KEY (`id`) )
ENGINE = InnoDB
COMMENT = 'vseobecne udaje ohladom autoskoly';


-- -----------------------------------------------------
-- Table `e-autoskola`.`osoba`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `e-autoskola`.`osoba` ;

CREATE  TABLE IF NOT EXISTS `e-autoskola`.`osoba` (
  `id` INT NOT NULL AUTO_INCREMENT ,
  `titulPred` VARCHAR(45) NULL ,
  `priezvisko` VARCHAR(45) NULL ,
  `rodnePriezvisko` VARCHAR(45) NULL ,
  `meno` VARCHAR(45) NULL ,
  `titulZa` VARCHAR(45) NULL ,
  `datumNarodenia` VARCHAR(45) NULL ,
  `rodneCislo` VARCHAR(45) NOT NULL ,
  `miestoNarodenia` VARCHAR(45) NULL ,
  `ulica` VARCHAR(45) NULL ,
  `ulicaCislo` VARCHAR(45) NULL ,
  `mesto` VARCHAR(45) NULL ,
  `psc` VARCHAR(45) NULL ,
  `telefon` VARCHAR(45) NULL ,
  `mobil` VARCHAR(45) NULL ,
  `email` VARCHAR(45) NULL ,
  `cisloOp` VARCHAR(45) NULL ,
  `cisloVp` VARCHAR(45) NULL ,
  PRIMARY KEY (`id`, `rodneCislo`) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `e-autoskola`.`student`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `e-autoskola`.`student` ;

CREATE  TABLE IF NOT EXISTS `e-autoskola`.`student` (
  `id` INT NOT NULL ,
  PRIMARY KEY (`id`) ,
  CONSTRAINT `fk_student_osoba`
    FOREIGN KEY (`id` )
    REFERENCES `e-autoskola`.`osoba` (`id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

CREATE INDEX `fk_student_osoba` ON `e-autoskola`.`student` (`id` ASC) ;


-- -----------------------------------------------------
-- Table `e-autoskola`.`kurz`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `e-autoskola`.`kurz` ;

CREATE  TABLE IF NOT EXISTS `e-autoskola`.`kurz` (
  `id` INT NOT NULL AUTO_INCREMENT ,
  `zaciatokDatum` DATE NULL ,
  `denVykonavania` VARCHAR(45) NULL COMMENT 'den v ktorom sa kurz vykonava\nnapr.  pondelok a streda' ,
  `hodinaVykonavania` VARCHAR(45) NULL ,
  `skupiny` VARCHAR(45) NULL COMMENT 'na ktore je kurz zamerany \nnapr. B,T' ,
  `idInstruktor` INT NULL COMMENT 'instruktor zodpovedny za kurz' ,
  PRIMARY KEY (`id`) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `e-autoskola`.`instruktor`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `e-autoskola`.`instruktor` ;

CREATE  TABLE IF NOT EXISTS `e-autoskola`.`instruktor` (
  `id` INT NOT NULL ,
  `datumVydaniaOsvedcenia` DATE NULL COMMENT 'preukaz instruktora autoskoly' ,
  `datumPlatnostiOsvedcenia` DATE NULL ,
  `evidencneCisloPreukazu` VARCHAR(45) NULL COMMENT 'preukaz instuktora autoskoly	' ,
  PRIMARY KEY (`id`) ,
  CONSTRAINT `fk_instruktor_osoba1`
    FOREIGN KEY (`id` )
    REFERENCES `e-autoskola`.`osoba` (`id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

CREATE INDEX `fk_instruktor_osoba1` ON `e-autoskola`.`instruktor` (`id` ASC) ;


-- -----------------------------------------------------
-- Table `e-autoskola`.`automobil`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `e-autoskola`.`automobil` ;

CREATE  TABLE IF NOT EXISTS `e-autoskola`.`automobil` (
  `id` INT NOT NULL AUTO_INCREMENT ,
  `spz` VARCHAR(45) NULL ,
  `vin` VARCHAR(45) NULL ,
  `stkPlatnost` DATE NULL ,
  `emisnaPlatnost` DATE NULL ,
  `znacka` VARCHAR(45) NULL ,
  `model` VARCHAR(45) NULL ,
  `priemernaSpotreba` DECIMAL NULL ,
  PRIMARY KEY (`id`) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `e-autoskola`.`ciselnik_skupina`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `e-autoskola`.`ciselnik_skupina` ;

CREATE  TABLE IF NOT EXISTS `e-autoskola`.`ciselnik_skupina` (
  `id` INT NOT NULL AUTO_INCREMENT ,
  `skupina` VARCHAR(45) NULL ,
  PRIMARY KEY (`id`) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `e-autoskola`.`studentSkupinaVlastnik`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `e-autoskola`.`studentSkupinaVlastnik` ;

CREATE  TABLE IF NOT EXISTS `e-autoskola`.`studentSkupinaVlastnik` (
  `id` INT NOT NULL AUTO_INCREMENT COMMENT 'previazanie na osobu resp. na student\n' ,
  `idStudent` INT NULL ,
  `idCiselnikSkupina` INT NULL ,
  PRIMARY KEY (`id`) )
ENGINE = InnoDB
COMMENT = 'obsahuje kombinaciu studenta a skupin, ktorych je student uz drzitelom	';


-- -----------------------------------------------------
-- Table `e-autoskola`.`studentSkupinaUchadzac`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `e-autoskola`.`studentSkupinaUchadzac` ;

CREATE  TABLE IF NOT EXISTS `e-autoskola`.`studentSkupinaUchadzac` (
  `id` INT NOT NULL AUTO_INCREMENT COMMENT 'previazanie na osobu resp. na student\n' ,
  `idStudent` INT NULL ,
  `idCiselnikSkupina` INT NULL ,
  PRIMARY KEY (`id`) )
ENGINE = InnoDB
COMMENT = 'obsahuje kombinaciu studenta a skupin, o ktore sa student uchadza\n	';


-- -----------------------------------------------------
-- Table `e-autoskola`.`platba`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `e-autoskola`.`platba` ;

CREATE  TABLE IF NOT EXISTS `e-autoskola`.`platba` (
  `id` INT NOT NULL AUTO_INCREMENT COMMENT '\n' ,
  `idStudent` INT NULL ,
  `idKurz` INT NULL ,
  `platbaZaKurz` DOUBLE NULL ,
  `kolokRiadnyTermin` TINYINT(1)  NULL COMMENT 'bude treba prehodnotiti ten typ koli tomu ze tam staci ci ma  dodal alebo nedodal kolok' ,
  `kolokOpravny1` TINYINT(1)  NULL COMMENT 'bude treba prehodnotiti ten typ koli tomu ze tam staci ci ma  dodal alebo nedodal kolok' ,
  `kolokOpravny2` TINYINT(1)  NULL COMMENT 'bude treba prehodnotiti ten typ koli tomu ze tam staci ci ma  dodal alebo nedodal kolok' ,
  PRIMARY KEY (`id`) )
ENGINE = InnoDB
COMMENT = 'zazanamenava vsetky platby studentov\n';


-- -----------------------------------------------------
-- Table `e-autoskola`.`dodanePotvrdenia`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `e-autoskola`.`dodanePotvrdenia` ;

CREATE  TABLE IF NOT EXISTS `e-autoskola`.`dodanePotvrdenia` (
  `id` INT NOT NULL AUTO_INCREMENT ,
  `idStudent` INT NULL ,
  `idKurz` INT NULL ,
  `cervenyKriz` TINYINT(1)  NULL ,
  `zdravotnaPrehliadka` TINYINT(1)  NULL ,
  `zdraotnaPrehliadkaDatum` DATE NULL COMMENT 'koli obmedzenej platnosti zdravotnej prehliadky\n' ,
  PRIMARY KEY (`id`) )
ENGINE = InnoDB
COMMENT = 'evidenica povinnych potvrdeni, ktore musi student dolozit do kurzu	';


-- -----------------------------------------------------
-- Table `e-autoskola`.`clenKurzu`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `e-autoskola`.`clenKurzu` ;

CREATE  TABLE IF NOT EXISTS `e-autoskola`.`clenKurzu` (
  `id` INT NOT NULL AUTO_INCREMENT ,
  `idStudent` INT NULL ,
  `idKurz` INT NULL ,
  PRIMARY KEY (`id`) )
ENGINE = InnoDB;



SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
