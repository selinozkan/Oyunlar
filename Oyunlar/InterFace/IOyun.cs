using System;
using System.Collections.Generic;
using System.Text;

namespace Oyunlar.InterFace
{
    interface IOyun
    {
        public string OyunAdı { get; set; }
        public string OyunYapımcı { get; set; }
        public int OyunYapımYılı { get; set; }
        public double OyunFiyatı { get; set; }
    }
}
