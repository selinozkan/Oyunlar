using Oyunlar.InterFace;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oyunlar.Varlıklar
{
    class YeniOyun:IOyun
    {
        public string OyunAdı { get; set; }
        public string OyunYapımcı { get; set; }
        public int OyunYapımYılı { get; set; }
        public double OyunFiyatı { get; set; }
    }
}
