CREATE FUNCTION GetIlacSayisiBySirket()
RETURNS TABLE
AS
RETURN
(
    SELECT IlacSirketi, COUNT(*) AS IlacSayisi
    FROM Tbl_ilac
    GROUP BY IlacSirketi
);