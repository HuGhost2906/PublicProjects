CREATE TABLE IF NOT EXISTS `TRAN_QUESTION` (
    `QUESTION_ID` INT(11) NOT NULL AUTO_INCREMENT,
    `QUESTION_TITLE` VARCHAR(500) NOT NULL,
	`QUESTION_HTML` MEDIUMTEXT NULL,
    `THREAD_ID` INT(11) NULL,
	`IS_VALID` BOOL NULL,
    `CREATED_BY` INT(11) DEFAULT NULL,
	`CREATED_DATE` DATETIME DEFAULT NULL,
    `MODIFIED_BY` INT(11) DEFAULT NULL,
	`MODIFIED_DATE` DATETIME DEFAULT NULL,
    `UPDATE_SEQ` INT(11) DEFAULT NULL,
    PRIMARY KEY (`QUESTION_ID`)
)  
ENGINE=InnoDB DEFAULT 
COLLATE utf8_unicode_ci;