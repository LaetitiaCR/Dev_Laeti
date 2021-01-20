CREATE PROCEDURE [dbo].[ProcedureInsertFournisseur]
@id int,
@pnom_fournisseur varchar,
@prue_fournisseur varchar,
@pville_fournisseur varchar,
@pcp_fournisseur int,
@ppersonne_fournisseur varchar,
@psatisfaction_fournisseur int

AS  
INSERT INTO Fournis (NUMFOU,NOUFOU, RUEFOU, VILFOU, POSFOU, CONFOU, SATISF)  VALUES(@id, @pnom_fournisseur, @prue_fournisseur, @pville_fournisseur, @pcp_fournisseur, @ppersonne_fournisseur, @psatisfaction_fournisseur)  
 
RETURN @@ROWCOUNT 
