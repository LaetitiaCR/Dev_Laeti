--======================================================
-- Create Natively Compiled Stored Procedure Template
--======================================================

USE MyPapyrus
GO

-- Drop stored procedure if it already exists
IF OBJECT_ID('ProcedureInsertFournisseur') IS NOT NULL
   DROP PROCEDURE ProcedureInsertFournisseur
GO


CREATE PROCEDURE ProcedureInsertFournisseur
@id int,
@pnom_fournisseur varchar,
@prue_fournisseur varchar,
@pville_fournisseur varchar,
@pcp_fournisseur int,
@ppersonne_fournisseur varchar,
@psatisfaction_fournisseur int

AS BEGIN 

INSERT INTO Fournis (NUMFOU,NOUFOU, RUEFOU, VILFOU, POSFOU, CONFOU, SATISF)  VALUES(@id, @pnom_fournisseur, @prue_fournisseur, @pville_fournisseur, @pcp_fournisseur, @ppersonne_fournisseur, @psatisfaction_fournisseur)  
END
GO
