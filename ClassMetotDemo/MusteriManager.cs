using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Id : " + musteri.Id);
            Console.WriteLine("Adı : " + musteri.Adi);
            Console.WriteLine("Soy Adı : " + musteri.SoyAdi);
            Console.WriteLine("Doğum Tarihi : " + musteri.DogumTarihi);
            Console.WriteLine("Doğum Yeri : " + musteri.DogumYeri);
            Console.WriteLine("Kredi Puanı : " + musteri.KrediPuani);

        }

        public void Sil(Musteri musteri)
        {
            string silindi1 = musteri.Id.Remove(0, musteri.Id.Length);
            string silindi2 = musteri.Adi.Remove(0,musteri.Adi.Length);
            string silindi3 = musteri.SoyAdi.Remove(0, musteri.SoyAdi.Length);
            string silindi5 = musteri.DogumTarihi.Remove(0, musteri.DogumTarihi.Length);
            string silindi4 = musteri.DogumYeri.Remove(0, musteri.DogumYeri.Length);
            string silindi6 = musteri.KrediPuani.Remove(0, musteri.KrediPuani.Length);




            //int a = 1989.ToString();


            //Console.WriteLine("Silindi" + silindi);
            Console.WriteLine("Id : " + "Silindi" + silindi1);

            Console.WriteLine("Adı : " + "Silindi" + silindi2);

            Console.WriteLine("Soy Adı : " + "Silindi" + silindi3);

            Console.WriteLine("Doğum Tarihi : " + "Silindi" + silindi4);

            Console.WriteLine("Doğum Yeri : " + "Silindi" + silindi5);

            Console.WriteLine("Kredi Puanı : " + "Silindi" + silindi6);

        }







    }
}
