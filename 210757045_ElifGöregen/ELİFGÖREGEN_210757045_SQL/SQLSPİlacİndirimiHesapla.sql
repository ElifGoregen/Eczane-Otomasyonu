CREATE PROCEDURE HesaplaIndirimOrannni
    @sigortaTuru nvarchar(50),--sigorta t�r� de�i�kenimi nvarchar tipinde tan�mlad�m.
    @indirimOrani decimal(3,2) OUT --indirimOrani t�r� de�i�kenimi decimal tipinde tan�mlad�m.
AS
BEGIN
    SET NOCOUNT ON;

    IF @sigortaTuru = 'SGK' -- sigorta t�r�ne g�re indirim yapt�m.
        SET @indirimOrani = 0.30; -- %30 indirim
    ELSE IF @sigortaTuru = 'Ba�kur'
        SET @indirimOrani = 0.00; -- %10 indirim
    ELSE IF @sigortaTuru = '�zel'
        SET @indirimOrani = 0.25; -- %25 indirim
    ELSE  
        SET @indirimOrani = 0; -- Sigortas� yoksa indirim yok.
END