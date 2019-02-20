CREATE TABLE `personalinfo` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `FirstName` text NOT NULL,
  `LastName` text NOT NULL,
  `DateOfBirth` datetime DEFAULT NULL,
  `City` text,
  `Country` text,
  `MobileNo` text,
  `NID` text,
  `Email` text,
  `CreatedDate` datetime DEFAULT NULL,
  `LastModifiedDate` datetime DEFAULT NULL,
  `CreationUser` text,
  `LastUpdateUser` text,
  `Status` tinyint(4) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;


