using Oyunlar.InterFace;
using Oyunlar.Manager;
using Oyunlar.Varlıklar;
using System;

namespace Oyunlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Ioyuncu oyuncu1 = new EskiOyuncu() { Adı = "DERİN", Soyadı = "DENİZ", DogumTarihi = "1995", Tc = "1", UyelikTarihi = 20 };
            OyuncuManager oyuncuManager = new OyuncuManager();
            oyuncuManager.Ekle(oyuncu1);


            IOyun oyun1 = new EskiOyun() { OyunAdı = "MARİO", OyunFiyatı = 25.5, OyunYapımcı = "ÇİN", OyunYapımYılı = 1989 };
            OyunManager oyunManager = new OyunManager();
            oyunManager.Ekle(oyun1);
            while (true)
            {
                Console.WriteLine("**********MENU**********");
                Console.WriteLine("1-)Oyuncu Ekle\n2-)Oyuncu Sil\n3-)Kullanıcıları Listele\n4-)Oyun Ekle\n5-)Oyun Sil\n6-)Oyunları Listele\n7-)Çıkış");
                Console.WriteLine("************************");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Clear();


                if (a == 1)
                {
                    Console.WriteLine("Eklemek istediğiniz kullanıcı bilgilerini giriniz");
                    Console.WriteLine("Tc no:");
                    string Tc = Console.ReadLine();
                    Console.WriteLine("İsim");
                    string Adı = Console.ReadLine();
                    Console.WriteLine("Soyad");
                    string Soyadı = Console.ReadLine();
                    Console.WriteLine("doğum tarihi");
                    string DogumTarihi = Console.ReadLine();

                    oyuncuManager.Ekle(new YeniOyuncu { Adı = Adı, Soyadı = Soyadı, Tc = Tc, DogumTarihi = DogumTarihi });
                }

                else if (a == 2)
                {
                    Console.WriteLine("Silmek istediğiniz oyuncunun Tc Numarasını giriniz:");
                    oyuncuManager.Silme(Console.ReadLine());
                }
                else if (a == 3)
                {
                    oyuncuManager.Listeleme();
                }
                else if (a == 4)
                {
                    Console.WriteLine("Eklemek istediğiniz oyunun bilgilerini giriniz");
                    Console.WriteLine("Oyun Adı:");
                    string oyun = Console.ReadLine();
                    Console.WriteLine("Eklemek istediğiniz oyununun yapımcısı");
                    string yapımcı = Console.ReadLine();
                    Console.WriteLine("Eklemek istediğiniz oyununun yapım tarihi");
                    int tarih = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Eklemek istediğiniz oyununun yapım fiyatı");
                    double fiyat = Convert.ToDouble(Console.ReadLine());

                    oyunManager.Ekle(new YeniOyun { OyunAdı = oyun, OyunFiyatı = fiyat, OyunYapımcı = yapımcı, OyunYapımYılı = tarih });
                }

                else if (a == 5)
                {
                    Console.WriteLine("Silmek istediğiniz oyunun Adını giriniz:");
                    oyuncuManager.Silme(Console.ReadLine());
                }

                else if (a == 6)
                {
                    oyunManager.Liste();
                }
                else
                {
                    break;
                }
            }




        }
    }
}