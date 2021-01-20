﻿DROP TABLE DIPLOMESDUDEMANDEURDEMPLOI;
DROP TABLE DIPLOMES;
DROP TABLE DEMANDEURDEMPLOIS;

CREATE TABLE DEMANDEURDEMPLOIS
(
    NumSecuriteSocial BIGINT NOT NULL PRIMARY KEY,
    Nom VARCHAR(50) NOT NULL, 
    Prenom VARCHAR(50) NOT NULL, 
    DateDinscription DATETIME NULL,
);

CREATE TABLE DIPLOMES
(
    Id INT NOT NULL PRIMARY KEY, 
    Intitule NVARCHAR(50) NOT NULL
);

CREATE TABLE DIPLOMESDUDEMANDEURDEMPLOI
(
    IdDemandeurDEmploi BIGINT NOT NULL FOREIGN KEY REFERENCES DEMANDEURDEMPLOIS(NumSecuriteSocial), 
    IdDuDiplomes INT NOT NULL FOREIGN KEY REFERENCES DIPLOMES(Id), 
    AnneeDeValidation DATETIME NOT NULL 
);
