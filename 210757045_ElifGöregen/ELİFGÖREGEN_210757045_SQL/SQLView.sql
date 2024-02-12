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
	--Her ilacýn adýný, üreten þirketi,
	--mevcut adedini, birim fiyatýný, toplam stok deðerini ve son güncellenme tarihini içeriyor.
	--Toplam stok deðeri, ilacýn adedi ile birim fiyatýnýn çarpýmý olarak hesapladým.