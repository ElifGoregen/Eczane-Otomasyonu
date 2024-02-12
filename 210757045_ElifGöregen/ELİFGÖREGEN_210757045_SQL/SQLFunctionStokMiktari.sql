CREATE FUNCTION GetStokMiktarii(@id int)
RETURNS int
AS
BEGIN
    DECLARE @StokMiktari int;

    SELECT @StokMiktari = ilacadedi FROM Tbl_ilac WHERE id = @id;

    RETURN @StokMiktari;
END;


