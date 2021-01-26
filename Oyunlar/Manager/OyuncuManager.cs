using Oyunlar.InterFace;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oyunlar.Manager
{
    class OyuncuManager
    {
        List<Ioyuncu> oyuncular = new List<Ioyuncu>() { };
        public void Ekle( Ioyuncu oyuncu)
        {
            oyuncular.Add(oyuncu);
            Console.WriteLine("Oyuncunun ismi:" +"  " + oyuncu.Adı + " " + oyuncu.Soyadı);
        }

        public void Silme( string Tc)
        {
            foreach( var oyuncu in oyuncular) {

                if (oyuncu.Tc == Tc)
                {
                    oyuncular.Remove(oyuncu);
                    Console.WriteLine("oyuncu silindi : " +" " + oyuncu.Adı+ " " + oyuncu.Soyadı);
                }
                else
                {
                    Console.WriteLine("böyle bir oyuncu yok ");
                }
            }
        }
        public void Listeleme()
        {
            int i = 1;
            foreach (var oyuncu in oyuncular)
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine("{0}.Oyuncu\nAd Soyad:{1} {2}\nTc No:{3}\nDoğum Yılı:{4}", i, oyuncu.Adı, oyuncu.Soyadı, oyuncu.Tc, oyuncu.DogumTarihi);
                Console.WriteLine("--------------------------");
                i += 1;
            }
        }
    }
}
