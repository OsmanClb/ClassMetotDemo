namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();

            musteri1.Id = 123;
            musteri1.Adi = "Osman";
            musteri1.Soyadi = "Çelebi";
            musteri1.DogumYeri = "Muğla";
            musteri1.Yasi = 21;
            musteri1.VergiNo = 123456789;

            Musteri musteri2 = new Musteri();

            musteri2.Id = 321;
            musteri2.Adi = "Selçuk";
            musteri2.Soyadi = "İnan";
            musteri2.DogumYeri = "İstanbul";
            musteri2.Yasi = 38;
            musteri2.VergiNo = 987654321;

            Musteri musteri3 = new Musteri();

            musteri3.Id = 111;
            musteri3.Adi = "Ahmet";
            musteri3.Soyadi = "Rıza";
            musteri3.DogumYeri = "Zonguldak";
            musteri3.Yasi = 90;
            musteri3.VergiNo = 987615621;

            Musteri[] musteriler = new Musteri[] { musteri1,musteri3 };

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.MusteriEkle(musteri2);           

            musteriManager.MusteriSilme(musteri2);

            musteriManager.MusteriListele(musteriler);



        }
    }
}