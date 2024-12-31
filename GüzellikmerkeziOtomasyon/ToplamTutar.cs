using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GüzellikmerkeziOtomasyon
{
    internal class ToplamTutar
    {
        
            private int _toplam;

            public int Toplam
            {
                get { return _toplam; }
                set { _toplam = value; }
            }

            public void ToplamEkle(int eklenenTutar)
            {
                _toplam += eklenenTutar;
            }
        
    }
}
