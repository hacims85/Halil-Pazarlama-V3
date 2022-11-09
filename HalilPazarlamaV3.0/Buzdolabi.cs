using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalilPazarlamaV3._0
{
    public class Buzdolabi
    {
        public string Marka;
        public string Model;
        public double Fiyat;
        public int IcHacim;
        public int KapiSayisi;
        public bool BuzMakinasi;


        public Buzdolabi(string marka, string model, double fiyat, int icHacim, int kapiSayisi, bool buzMakinasi)
        {
            Marka = marka;
            Model = model;
            Fiyat = fiyat;
            IcHacim = icHacim;
            KapiSayisi = kapiSayisi;
            BuzMakinasi = buzMakinasi;
        }
        public string Yazdir()
        {
            return $"Marka={Marka} Model={Model}\nKapi Sayisi={KapiSayisi} Buz Makinası={BuzMakinasi}\nFiyat={Fiyat}";
        }
    }
}
