CREATE TRIGGER trg_CheckExpirationDate
ON Tbl_ilac
AFTER INSERT, UPDATE --Bir satýr eklendiðinde veya güncellendiðinde trigger çalýþýr.
AS
BEGIN
    SET NOCOUNT ON; --satýr sayýsýnýn döndürülmesini engeller.

    IF EXISTS (SELECT 1 FROM inserted WHERE ilactarihi < GETDATE())-- eklenen veya güncellenen
	--satýrlarýn içerisinde, son kullanma tarihi bugünün tarihinden 
	--küçük olanlarý (yani geçmiþ tarihte olanlarý) kontrol eder.
    BEGIN
        
        PRINT 'Ýlacýn son kullanma tarihi geçmiþ.';--Yazdýrma iþlemi
    END
END