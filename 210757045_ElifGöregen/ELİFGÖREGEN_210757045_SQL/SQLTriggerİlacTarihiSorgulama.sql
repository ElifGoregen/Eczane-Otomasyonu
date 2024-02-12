CREATE TRIGGER trg_CheckExpirationDate
ON Tbl_ilac
AFTER INSERT, UPDATE --Bir sat�r eklendi�inde veya g�ncellendi�inde trigger �al���r.
AS
BEGIN
    SET NOCOUNT ON; --sat�r say�s�n�n d�nd�r�lmesini engeller.

    IF EXISTS (SELECT 1 FROM inserted WHERE ilactarihi < GETDATE())-- eklenen veya g�ncellenen
	--sat�rlar�n i�erisinde, son kullanma tarihi bug�n�n tarihinden 
	--k���k olanlar� (yani ge�mi� tarihte olanlar�) kontrol eder.
    BEGIN
        
        PRINT '�lac�n son kullanma tarihi ge�mi�.';--Yazd�rma i�lemi
    END
END