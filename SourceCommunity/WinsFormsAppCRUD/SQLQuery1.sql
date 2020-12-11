





DROP TABLE IF EXISTS Vente ;
DROP TABLE IF EXISTS LIGCOM ;
DROP TABLE IF EXISTS ENTCOM ;
DROP TABLE IF EXISTS Produits ;
DROP TABLE IF EXISTS Fournis ;


DROP DATABASE IF EXISTS MyPapyrus;

Create database MyPapyrus;


CREATE TABLE Produits (
  CODART INT NOT NULL,
  LIBART VARCHAR(45) NULL,
  STKLE VARCHAR(45) NULL,
  QTEANN INT NULL,
  UNIMES VARCHAR(45) NULL,
  PRIMARY KEY (CODART))




CREATE TABLE Fournis (
  NUMFOU INT NOT NULL,
  NOUFOU VARCHAR(45) NULL,
  RUEFOU VARCHAR(45) NULL,
  POSFOU INT NULL,
  VILFOU VARCHAR(45) NULL,
  CONFOU VARCHAR(45) NULL,
  SATISF INT NULL,
  PRIMARY KEY (NUMFOU));





CREATE TABLE Vente (
  CODART INT NOT NULL,
  NUMFOU INT NOT NULL,
  DELLIV VARCHAR(45) NULL,
  QTE1 INT NULL,
  PRIX1 DECIMAL(15) NULL,
  QTE2 INT NULL,
  PRIX2 DECIMAL(15) NULL,
  QTE3 INT NULL,
  PRIX3 DECIMAL(15) NULL,
  PRIMARY KEY (CODART, NUMFOU),
  FOREIGN KEY (CODART) REFERENCES Produits(CODART), 
  FOREIGN KEY (NUMFOU) REFERENCES Fournis(NUMFOU));
         


 


CREATE TABLE ENTCOM (
  NUMCOM INT NOT NULL,
  OBSCOM VARCHAR(45) NULL,
  DATCOM DATETIME NULL,
  NUMFOU INT NULL,
  PRIMARY KEY (NUMCOM),
  FOREIGN KEY (NUMFOU) REFERENCES Fournis(NUMFOU))





CREATE TABLE LIGCOM (
  NUMCOM INT NOT NULL,
  NUMLIG INT NOT NULL,
  CODART INT NULL,
  QTECDE INT NULL,
  PRIUNI DECIMAL(15) NULL,
  QTELIV INT NULL,
  DERLIV VARCHAR(45) NULL,
  PRIMARY KEY (NUMCOM, NUMLIG),
  FOREIGN KEY (NUMCOM) REFERENCES Entcom(NUMCOM),
  FOREIGN KEY (CODART) REFERENCES Produits(CODART))
  


  INSERT INTO Fournis 
    (NUMFOU, NOUFOU, RUEFOU, POSFOU, VILFOU, CONFOU, SATISF)
  VALUES (1, 'Nom du fournisseur 1', 'rue fournisseur 1', 54100, 'ville du fournisseur 1', 'Nom du Contact Fourniseeur 1', 5),
         (2, 'Nom du fournisseur 2', 'rue fournisseur 2', 55000, 'ville du fournisseur 2', 'Nom du Contact Fourniseeur 2', 4),
         (3, 'Nom du fournisseur 3', 'rue fournisseur 3', 57000, 'ville du fournisseur 3', 'Nom du Contact Fourniseeur 3', 2),
         (4, 'Nom du fournisseur 4', 'rue fournisseur 4', 54000, 'ville du fournisseur 4', 'Nom du Contact Fourniseeur 4', 1),
         (5, 'Nom du fournisseur 5', 'rue fournisseur 5', 55200, 'ville du fournisseur 5', 'Nom du Contact Fourniseeur 5', 3),
         (6, 'Nom du fournisseur 6', 'rue fournisseur 6', 54400, 'ville du fournisseur 6', 'Nom du Contact Fourniseeur 6', 8)

