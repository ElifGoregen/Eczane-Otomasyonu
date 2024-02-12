CREATE PROCEDURE ListeleIlacSiralamaSecenegineGore --Sp tan�mlad�m.
    @SiralamaKriteri nvarchar(50)
AS
BEGIN
    SET NOCOUNT ON;

    IF @SiralamaKriteri = 'IlacTarihi' --Ko�ulumu yazd�m.
        SELECT id, ilacadi, ilactarihi, recetekodu, ilacadedi
        FROM Tbl_ilac --Tablomdan se�ece�im de�i�kenleri �ektim.
        ORDER BY IlacTarihi DESC; --�la� tarihi de�i�kenime g�re s�ralama yapt�m.
    ELSE IF @SiralamaKriteri = 'IlacAdi'
        SELECT id, ilacadi, ilactarihi, recetekodu, ilacadedi
        FROM Tbl_ilac
        ORDER BY IlacAdi; --�la� ad� de�i�kenime g�re s�ralama yapt�m.
    ELSE IF @SiralamaKriteri = 'ReceteKodu'
        SELECT id, ilacadi, ilactarihi, recetekodu, ilacadedi
        FROM Tbl_ilac --�la� tablomdan se�ece�im de�i�kenleri �ektim.
        ORDER BY ReceteKodu; --Re�ete kodu de�i�kenime g�re s�ralama yapt�m.
    ELSE
        SELECT id, ilacadi, ilactarihi, recetekodu, ilacadedi
        FROM Tbl_ilac; -- E�er ge�erli bir kriter yoksa varsay�lan s�ralama yapt�m.
END