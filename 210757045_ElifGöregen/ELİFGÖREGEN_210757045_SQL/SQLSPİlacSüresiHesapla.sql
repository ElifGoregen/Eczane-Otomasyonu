CREATE PROCEDURE Sp_IlacSuresiiSorgula --Sp tanýmladým.
AS
BEGIN
    DECLARE @Bugun DATE = GETDATE() --Bugünün tarihini alan metodu deðiþkenime atadým.
    DECLARE @IlacTarihi DATE -- ilactarihi adlý deðiþkenimi date tipinde tanýmladým.

    SELECT @IlacTarihi = ilactarihi FROM Tbl_ilac  --ilactarihi adlý deðiþkenimi ilaç tablomdan çektim.

    IF DATEDIFF(MONTH, @IlacTarihi, @Bugun) > 3 --Eðer ilactarihi deðiþkenim ile 
                                 	-- bugünün tarihi arasýndaki ay farký üçü geçtiyse:
        SELECT 1 AS Durum --durum 1 olur
    ELSE
        SELECT 0 AS Durum--deðilse sýfýr olur.
END