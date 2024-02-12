CREATE TRIGGER trg_Tbl_ilac_Insert
ON Tbl_ilac
FOR INSERT
AS 
BEGIN 
    DECLARE @Id int, @IlacAdi nvarchar(100), @ReceteKodu int, @IlacUcreti decimal, @IlacTarihi datetime;
	--Yeni eklenen ilaçla ilgili bilgileri saklamak için deðiþkenleri tanýmladým.
    SELECT @Id = id, 
           @IlacAdi = ilacadi, 
           @ReceteKodu = recetekodu, 
           @IlacUcreti = ilacucreti, 
           @IlacTarihi = ilactarihi 
    FROM inserted; --ekleme yaptým.
	
END