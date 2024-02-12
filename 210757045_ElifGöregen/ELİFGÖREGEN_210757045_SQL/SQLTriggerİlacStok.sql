CREATE TRIGGER trg_CheckStockLevel
ON Tbl_ilac
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;--sat�r say�s�n�n d�nd�r�lmesini engeller.

    -- Stok seviyesi kontrol edilecek e�ik de�eri tan�mlad�m.
    DECLARE @StockThreshold INT = 10;  

    -- Stok seviyesi d���k olan ila�lar�n listesiniyazd�rd�m.
    DECLARE @LowStockTable TABLE (IlacID INT, IlacAdi NVARCHAR(100), MevcutStok INT);

    -- G�ncellenen ila�lar�n stok seviyesini kontrol ettim.
    INSERT INTO @LowStockTable (IlacID, IlacAdi, MevcutStok)
    SELECT i.id, i.IlacAdi, i.ilacadedi
    FROM inserted ins
    INNER JOIN Tbl_ilac i ON ins.id = i.id
    WHERE i.ilacadedi < @StockThreshold;
	   IF EXISTS (SELECT 1 FROM @LowStockTable)
    BEGIN
        Print('�la� sto�u d���k ecza deposundan isteyiniz.');--E�er stok seviyesi d���kse
		--ecza deposundan isteyiniz mesaj� yazd�rd�m.
    END
END