CREATE DATABASE `cspos` /*!40100 DEFAULT CHARACTER SET utf8 */;

CREATE TABLE `catalogcategories` (
  `CatalogCategoryID` int(11) NOT NULL,
  `Name` varchar(50) NOT NULL,
  `Description` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`CatalogCategoryID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Reference of spare part categories';

CREATE TABLE `catalogconditions` (
  `CatalogConditionID` int(11) NOT NULL,
  `Name` varchar(50) NOT NULL,
  `Description` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`CatalogConditionID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='reference of spare part conditions';

CREATE TABLE `catalogmakers` (
  `CatalogMakerID` int(11) NOT NULL,
  `Name` varchar(50) NOT NULL,
  `Description` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`CatalogMakerID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Reference of car spare part makers';

CREATE TABLE `catalogtypes` (
  `CatalogTypeID` int(11) NOT NULL,
  `Name` varchar(50) NOT NULL,
  `Description` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`CatalogTypeID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE `catalog` (
  `CatalogItemID` int(11) NOT NULL AUTO_INCREMENT,
  `CategoryID` int(11) NOT NULL,
  `MakerID` int(11) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `Description` varchar(500) NOT NULL,
  `Price` decimal(19,2) NOT NULL,
  `InStockNum` int(11) NOT NULL,
  `OrigCountry` varchar(255) DEFAULT NULL,
  `ManufactureDate` datetime NOT NULL,
  `Warranty` int(11) DEFAULT NULL,
  `ConditionID` int(11) DEFAULT NULL,
  `ModifiedDate` datetime NOT NULL,
  `Deleted` bit(1) NOT NULL DEFAULT b'0',
  `ItemType` int(11) NOT NULL DEFAULT '1',
  `RowVersion` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`CatalogItemID`),
  KEY `FK_Catalog_CatalogCategories_idx` (`CategoryID`),
  KEY `FK_Catalog_CatalogConditions_idx` (`ConditionID`),
  KEY `FK_Catalog_CatalogMakers_idx` (`MakerID`),
  KEY `FK_Catalog_CatalogTypes_idx` (`ItemType`),
  CONSTRAINT `FK_Catalog_CatalogCategories` FOREIGN KEY (`CategoryID`) REFERENCES `catalogcategories` (`CatalogCategoryID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_Catalog_CatalogConditions` FOREIGN KEY (`ConditionID`) REFERENCES `catalogconditions` (`CatalogConditionID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_Catalog_CatalogMakers` FOREIGN KEY (`MakerID`) REFERENCES `catalogmakers` (`CatalogMakerID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_Catalog_CatalogTypes` FOREIGN KEY (`ItemType`) REFERENCES `catalogtypes` (`CatalogTypeID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 COMMENT='car spare parts';

CREATE TABLE `orderstatuses` (
  `OrderStatusID` int(11) NOT NULL,
  `Name` varchar(50) NOT NULL,
  `Description` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`OrderStatusID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE `orders` (
  `OrderID` int(11) NOT NULL AUTO_INCREMENT,
  `CustomerName` varchar(255) NOT NULL,
  `CreatedDate` datetime NOT NULL,
  `OrderStatusID` int(11) NOT NULL,
  `Deleted` bit(1) NOT NULL DEFAULT b'0',
  `RowVersion` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`OrderID`),
  KEY `FK_Orders_OrderStatuses_idx` (`OrderStatusID`),
  CONSTRAINT `FK_Orders_OrderStatuses` FOREIGN KEY (`OrderStatusID`) REFERENCES `orderstatuses` (`OrderStatusID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

CREATE TABLE `orderitems` (
  `OrderID` int(11) NOT NULL,
  `CatalogItemID` int(11) NOT NULL,
  `Quantity` int(11) NOT NULL,
  `Price` decimal(19,2) NOT NULL,
  PRIMARY KEY (`OrderID`,`CatalogItemID`),
  KEY `FK_OrderItems_Catalog_idx` (`CatalogItemID`),
  CONSTRAINT `FK_OrderItems_Catalog` FOREIGN KEY (`CatalogItemID`) REFERENCES `catalog` (`CatalogItemID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_OrderItems_Orders` FOREIGN KEY (`OrderID`) REFERENCES `orders` (`OrderID`) ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;