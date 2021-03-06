CREATE TABLE `exclude` (
	`id` INT(10) UNSIGNED NOT NULL AUTO_INCREMENT,
	`sig_id` INT(10) UNSIGNED NULL DEFAULT NULL,
	`ip_src` INT(10) UNSIGNED NULL DEFAULT NULL,
	`port_src` SMALLINT(5) UNSIGNED NULL DEFAULT NULL,
	`ip_dst` INT(10) UNSIGNED NULL DEFAULT NULL,
	`port_dst` SMALLINT(5) UNSIGNED NULL DEFAULT NULL,
	`ip_proto` TINYINT(3) UNSIGNED NOT NULL,
	`comment` VARCHAR(100) NULL DEFAULT NULL,
	`fp` BIT(1) NULL DEFAULT NULL,
	`timeadded` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
	PRIMARY KEY (`id`),
	INDEX `sig_id` (`sig_id`),
	INDEX `ip_src` (`ip_src`),
	INDEX `ip_dst` (`ip_dst`)
)
ENGINE=InnoDB
AUTO_INCREMENT=0;
