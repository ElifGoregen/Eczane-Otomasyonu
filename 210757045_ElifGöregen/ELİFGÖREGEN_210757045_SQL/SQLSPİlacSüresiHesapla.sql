CREATE PROCEDURE Sp_IlacSuresiiSorgula --Sp tan�mlad�m.
AS
BEGIN
    DECLARE @Bugun DATE = GETDATE() --Bug�n�n tarihini alan metodu de�i�kenime atad�m.
    DECLARE @IlacTarihi DATE -- ilactarihi adl� de�i�kenimi date tipinde tan�mlad�m.

    SELECT @IlacTarihi = ilactarihi FROM Tbl_ilac  --ilactarihi adl� de�i�kenimi ila� tablomdan �ektim.

    IF DATEDIFF(MONTH, @IlacTarihi, @Bugun) > 3 --E�er ilactarihi de�i�kenim ile 
                                 	-- bug�n�n tarihi aras�ndaki ay fark� ��� ge�tiyse:
        SELECT 1 AS Durum --durum 1 olur
    ELSE
        SELECT 0 AS Durum--de�ilse s�f�r olur.
END