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

    }
}
