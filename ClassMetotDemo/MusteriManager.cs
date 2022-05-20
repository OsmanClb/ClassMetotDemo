using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Musteri Eklendi : " + musteri.Adi + "" + musteri.Soyadi);
        }
        
        public void MusteriListele(Musteri[] musteriler)
        {
            Console.WriteLine("*****Yeni Musteri Listesi*****");

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Ad         : " + musteri.Adi);
                Console.WriteLine("Soyad      : " + musteri.Soyadi);
                Console.WriteLine("Dogum Yeri : " + musteri.DogumYeri);
                Console.WriteLine("Yaşı       : " + musteri.Yasi);
                Console.WriteLine("Musteri ID : " + musteri.Id);
                Console.WriteLine("Vergi No   : " + musteri.VergiNo);
                Console.WriteLine("*******************************");
            }

        }

        public void MusteriSilme(Musteri musteri)       
        {
            Console.WriteLine("Muşteri Silindi : " + musteri.Adi + "" + musteri.Soyadi);
        }




    }
}
