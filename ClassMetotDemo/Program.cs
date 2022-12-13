using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Tuğrul";
            musteri1.Soyad = "Yağmur";
            musteri1.Id = 1;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Batuhan";
            musteri2.Soyad = "Diler";
            musteri2.Id = 1;

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Enes";
            musteri3.Soyad = "Bircan";
            musteri3.Id = 1;

            MusteriManager.Ekle(musteri1);
            MusteriManager.Ekle(musteri2);
            MusteriManager.Ekle(musteri3);

            MusteriManager.Listele(musteri1,musteri2,musteri3);


            MusteriManager.Sil(musteri1);


            Console.ReadLine();
        }
    }
}
