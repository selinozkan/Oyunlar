using System;
using System.Collections.Generic;
using System.Text;

namespace Oyunlar.InterFace
{
    interface Ioyuncu
    {
        public string Adı { get; set; }
        public string Soyadı { get; set;  }
        public string DogumTarihi { get; set; }
        public string Tc { get; set; }
    }
}
