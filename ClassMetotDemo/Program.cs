using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            
            musteri1.Adi = "Jimi";
            musteri1.SoyAdi = "Hendrix";
            musteri1.DogumTarihi = 1942;
            musteri1.DogumYeri = "Seattle";
            musteri1.KrediPuani = 1850;

            Musteri musteri2 = new Musteri();

            musteri2.Adi = "Eddie";
            musteri2.SoyAdi = "Van Halen";
            musteri2.DogumTarihi = 1955;
            musteri2.DogumYeri = "Amsterdam";
            musteri2.KrediPuani = 1860;

            Musteri musteri3 = new Musteri();

            musteri3.Adi = "Jason";
            musteri3.SoyAdi = "Becker";
            musteri3.DogumTarihi = 1969;
            musteri3.DogumYeri = "Richmond";
            musteri3.KrediPuani = 1900;

            Musteri musteri4 = new Musteri();

            musteri4.Adi = "Anthony Frank";
            musteri4.SoyAdi = "Iommi";
            musteri4.DogumTarihi = 1948;
            musteri4.DogumYeri = "Birmingham";
            musteri4.KrediPuani = 1880;

            /*Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };

            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi);

            }
            */

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            Console.WriteLine("--------------------");
            musteriManager.Ekle(musteri2);









        }
    }
}
