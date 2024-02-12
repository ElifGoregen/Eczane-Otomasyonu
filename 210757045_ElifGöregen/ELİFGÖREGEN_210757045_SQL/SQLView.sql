CREATE VIEW vw_IlacStokDegeri AS
SELECT 
    ilacadi AS IlacAdi,
    ilacsirketi AS IlacSirketi,
    ilacadedi AS IlacAdedi,
    ilacucreti AS IlacUcreti,
    (ilacadedi * ilacucreti) AS ToplamStokDegeri,
    ilactarihi AS SonGuncellenmeTarihi
FROM 
    Tbl_ilac
	--Her ilac�n ad�n�, �reten �irketi,
	--mevcut adedini, birim fiyat�n�, toplam stok de�erini ve son g�ncellenme tarihini i�eriyor.
	--Toplam stok de�eri, ilac�n adedi ile birim fiyat�n�n �arp�m� olarak hesaplad�m.