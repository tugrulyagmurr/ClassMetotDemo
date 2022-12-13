using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public static void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " isimli musteri sisteme eklendi.");
        }

        public static void Listele(params Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " isimli musteri sisteme kayıtlıdır.");
            }

        }

        public static void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " isimli musteri sistemden silindi.");
        }
    }
}
