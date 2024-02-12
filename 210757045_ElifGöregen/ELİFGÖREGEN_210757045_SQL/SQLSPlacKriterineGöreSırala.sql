CREATE PROCEDURE ListeleIlacSiralamaSecenegineGore --Sp tanýmladým.
    @SiralamaKriteri nvarchar(50)
AS
BEGIN
    SET NOCOUNT ON;

    IF @SiralamaKriteri = 'IlacTarihi' --Koþulumu yazdým.
        SELECT id, ilacadi, ilactarihi, recetekodu, ilacadedi
        FROM Tbl_ilac --Tablomdan seçeceðim deðiþkenleri çektim.
        ORDER BY IlacTarihi DESC; --Ýlaç tarihi deðiþkenime göre sýralama yaptým.
    ELSE IF @SiralamaKriteri = 'IlacAdi'
        SELECT id, ilacadi, ilactarihi, recetekodu, ilacadedi
        FROM Tbl_ilac
        ORDER BY IlacAdi; --Ýlaç adý deðiþkenime göre sýralama yaptým.
    ELSE IF @SiralamaKriteri = 'ReceteKodu'
        SELECT id, ilacadi, ilactarihi, recetekodu, ilacadedi
        FROM Tbl_ilac --Ýlaç tablomdan seçeceðim deðiþkenleri çektim.
        ORDER BY ReceteKodu; --Reçete kodu deðiþkenime göre sýralama yaptým.
    ELSE
        SELECT id, ilacadi, ilactarihi, recetekodu, ilacadedi
        FROM Tbl_ilac; -- Eðer geçerli bir kriter yoksa varsayýlan sýralama yaptým.
END