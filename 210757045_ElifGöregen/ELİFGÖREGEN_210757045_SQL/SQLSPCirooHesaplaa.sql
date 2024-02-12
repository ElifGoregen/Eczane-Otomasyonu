CREATE PROCEDURE CirooHesaplaa
    @ilacadi nvarchar(50),--ilacadi deðiþkenimi nvarchar tipinde oluþturdum.
    @ilacucreti decimal(10, 2) OUTPUT--ilacucreti deðiþkenimi decimal tipte oluþturdum.
AS
BEGIN
    SELECT @ilacUcreti = ilacucreti FROM Tbl_ilac WHERE ilacadi = @ilacAdi;--ilacadi tablomdan 
	--ilacadi koþuluna göre ilacucaretini getirdim.
END
