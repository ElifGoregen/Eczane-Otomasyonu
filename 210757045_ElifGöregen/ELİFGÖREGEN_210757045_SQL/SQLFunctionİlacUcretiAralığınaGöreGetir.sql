CREATE FUNCTION GetIlacSayisiByFiyatAraligi(@MinFiyat decimal, @MaxFiyat decimal)
RETURNS int
AS
BEGIN
    DECLARE @IlacSayisi int;

    SELECT @IlacSayisi = COUNT(*) 
    FROM Tbl_ilac 
    WHERE ilacucreti BETWEEN @MinFiyat AND @MaxFiyat;

    RETURN @IlacSayisi;
END;
