CREATE PROCEDURE CirooHesaplaa
    @ilacadi nvarchar(50),--ilacadi de�i�kenimi nvarchar tipinde olu�turdum.
    @ilacucreti decimal(10, 2) OUTPUT--ilacucreti de�i�kenimi decimal tipte olu�turdum.
AS
BEGIN
    SELECT @ilacUcreti = ilacucreti FROM Tbl_ilac WHERE ilacadi = @ilacAdi;--ilacadi tablomdan 
	--ilacadi ko�uluna g�re ilacucaretini getirdim.
END
