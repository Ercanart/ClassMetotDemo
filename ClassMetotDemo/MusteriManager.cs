using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Id : " + "Eklendi" + " / " + musteri.Id);
            Console.WriteLine("Adı : " + "Eklendi" + " / " + musteri.Adi);
            Console.WriteLine("Soy Adı : " + "Eklendi" + " / " + musteri.SoyAdi);
            Console.WriteLine("Doğum Tarihi : " + "Eklendi" + " / " + musteri.DogumTarihi);
            Console.WriteLine("Doğum Yeri : " + "Eklendi" + " / " + musteri.DogumYeri);
            Console.WriteLine("Kredi Puanı : " + "Eklendi" + " / " + musteri.KrediPuani);

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
        public void Listele(Musteri musteri)
        {
            //string[] listeler = new string[] { musteri.Id, musteri.Adi, musteri.SoyAdi, musteri.DogumTarihi, musteri.DogumYeri, musteri.KrediPuani};
            
            //for (int a = 0; a < listeler.Length; a++)

            //Array.Sort(listeler);
            //foreach (var musterim in listeler)
            {
                //Console.WriteLine("Id : " + listeler[0]);
                //Console.WriteLine("Adı : " + listeler[1]);
                //Console.WriteLine("Soy Adı : " + listeler[2]);
                //Console.WriteLine("Doğum Tarihi : " + listeler[3]);
                //Console.WriteLine("Doğum Yeri : " + listeler[4]);
                //Console.WriteLine("Kredi Puanı : " + listeler[5]);

                Console.WriteLine("Id : " + musteri.Id + " / " + "Adı : " + musteri.Adi + " / " + "Soy Adı : " + musteri.SoyAdi + " / " + "Doğum Tarihi : " + musteri.DogumTarihi + " / " + "Doğum Yeri : " + musteri.DogumYeri + " / " + "Kredi Puanı : " + musteri.KrediPuani);


            }

            //Array.Sort(listeler);

            



        }
        





    }
}
