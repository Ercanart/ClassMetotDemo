using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();

            musteri1.Id = 112233.ToString();
            musteri1.Adi = "Jimi";
            musteri1.SoyAdi = "Hendrix";
            musteri1.DogumTarihi = 1942.ToString();
            musteri1.DogumYeri = "Seattle";
            musteri1.KrediPuani = 1850.ToString();
            

            Musteri musteri2 = new Musteri();

            musteri2.Id = 223344.ToString();
            musteri2.Adi = "Eddie";
            musteri2.SoyAdi = "Van Halen";
            musteri2.DogumTarihi = 1955.ToString();
            musteri2.DogumYeri = "Amsterdam";
            musteri2.KrediPuani = 1860.ToString();

            Musteri musteri3 = new Musteri();

            musteri3.Id = 334455.ToString();
            musteri3.Adi = "Jason";
            musteri3.SoyAdi = "Becker";
            musteri3.DogumTarihi = 1969.ToString();
            musteri3.DogumYeri = "Richmond";
            musteri3.KrediPuani = 1900.ToString();

            Musteri musteri4 = new Musteri();

            musteri4.Id = 445566.ToString();
            musteri4.Adi = "Anthony Frank";
            musteri4.SoyAdi = "Iommi";
            musteri4.DogumTarihi = 1948.ToString();
            musteri4.DogumYeri = "Birmingham";
            musteri4.KrediPuani = 1880.ToString();

            /*Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };

            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi);

            }
            */

            MusteriManager musteriManager = new MusteriManager();
            Console.WriteLine("-------Ekleme-------");
            musteriManager.Ekle(musteri1);
            Console.WriteLine("--------------------");
            musteriManager.Ekle(musteri2);
            Console.WriteLine("--------Sİlme-------");
            musteriManager.Sil(musteri1);
            Console.WriteLine("--------------------");
            musteriManager.Sil(musteri2);
            Console.WriteLine("-----listeleme------");
            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);
            musteriManager.Listele(musteri3);
            musteriManager.Listele(musteri4);












        }
    }
}
