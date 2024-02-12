CREATE TRIGGER trg_CheckStockLevel
ON Tbl_ilac
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;--satýr sayýsýnýn döndürülmesini engeller.

    -- Stok seviyesi kontrol edilecek eþik deðeri tanýmladým.
    DECLARE @StockThreshold INT = 10;  

    -- Stok seviyesi düþük olan ilaçlarýn listesiniyazdýrdým.
    DECLARE @LowStockTable TABLE (IlacID INT, IlacAdi NVARCHAR(100), MevcutStok INT);

    -- Güncellenen ilaçlarýn stok seviyesini kontrol ettim.
    INSERT INTO @LowStockTable (IlacID, IlacAdi, MevcutStok)
    SELECT i.id, i.IlacAdi, i.ilacadedi
    FROM inserted ins
    INNER JOIN Tbl_ilac i ON ins.id = i.id
    WHERE i.ilacadedi < @StockThreshold;
	   IF EXISTS (SELECT 1 FROM @LowStockTable)
    BEGIN
        Print('Ýlaç stoðu düþük ecza deposundan isteyiniz.');--Eðer stok seviyesi düþükse
		--ecza deposundan isteyiniz mesajý yazdýrdým.
    END
END