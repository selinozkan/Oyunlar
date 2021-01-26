using Oyunlar.InterFace;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oyunlar.Manager
{
    class OyunManager
    {

        List<IOyun> oyunlar = new List<IOyun>() { };
        public void Ekle(IOyun oyun)
        {
            oyunlar.Add(oyun);
            Console.WriteLine("Oyunun ismi:" + "  " + oyun.OyunAdı);
        }

        public void Silme(string OyunAdı)
        {
            foreach (var oyun in oyunlar)
            {

                if (OyunAdı == OyunAdı)
                {
                    oyunlar.Remove(oyun);
                    Console.WriteLine("oyun silindi : " + oyun.OyunAdı);
                }
                else
                {
                    Console.WriteLine("böyle bir oyuncu yok ");
                }
            }
        }
        public void Liste()
        {
            int i = 1;
            foreach (var oyun in oyunlar)
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine(oyun.OyunAdı);
                Console.WriteLine("--------------------------");
                i += 1;
            }
        }
    }
}
