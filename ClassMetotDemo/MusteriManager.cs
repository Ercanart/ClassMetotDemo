using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Adı : " + musteri.Adi);
            Console.WriteLine("Soy Adı : " + musteri.SoyAdi);
            Console.WriteLine("Doğum Tarihi : " + musteri.DogumTarihi);
            Console.WriteLine("Doğum Yeri : " + musteri.DogumYeri);
            Console.WriteLine("Kredi Puanı : " + musteri.KrediPuani);

        }

        public void Sil(Musteri musteri)
        {
            string silindi1 = musteri.Adi.Remove(0,musteri.Adi.Length);
            string silindi2 = musteri.SoyAdi.Remove(0, musteri.SoyAdi.Length);
            string silindi3 = musteri.DogumYeri.Remove(0, musteri.DogumYeri.Length);
            string silindi4 = musteri.DogumTarihi.Remove(0, musteri.DogumTarihi.Length);
            string silindi5 = musteri.DogumTarihi.Remove(0, musteri.DogumTarihi.Length);




            //int a = 1989.ToString();


            //Console.WriteLine("Silindi" + silindi);
            Console.WriteLine("Adı : " + "Silindi" + silindi1);

            Console.WriteLine("Soy Adı : " + "Silindi" + silindi2);

            Console.WriteLine("Doğum Tarihi : " + "Silindi" + silindi4);

            Console.WriteLine("Doğum Yeri : " + "Silindi" + silindi3);

            Console.WriteLine("Kredi Puanı : " + "Silindi" + silindi5);

        }







    }
}
