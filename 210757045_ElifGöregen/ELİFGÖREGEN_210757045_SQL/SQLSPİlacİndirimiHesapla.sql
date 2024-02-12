CREATE PROCEDURE HesaplaIndirimOrannni
    @sigortaTuru nvarchar(50),--sigorta türü deðiþkenimi nvarchar tipinde tanýmladým.
    @indirimOrani decimal(3,2) OUT --indirimOrani türü deðiþkenimi decimal tipinde tanýmladým.
AS
BEGIN
    SET NOCOUNT ON;

    IF @sigortaTuru = 'SGK' -- sigorta türüne göre indirim yaptým.
        SET @indirimOrani = 0.30; -- %30 indirim
    ELSE IF @sigortaTuru = 'Baðkur'
        SET @indirimOrani = 0.00; -- %10 indirim
    ELSE IF @sigortaTuru = 'Özel'
        SET @indirimOrani = 0.25; -- %25 indirim
    ELSE  
        SET @indirimOrani = 0; -- Sigortasý yoksa indirim yok.
END