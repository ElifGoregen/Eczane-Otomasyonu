CREATE PROCEDURE ilacBilgisiGetir
				@ilacAdi nvarchar(50)
AS 
BEGIN 
       SELECT * FROM Tbl_ilac WHERE ilacadi=@ilacAdi
END
--ilacadina göre ilacýn bilgilerini getirir.			