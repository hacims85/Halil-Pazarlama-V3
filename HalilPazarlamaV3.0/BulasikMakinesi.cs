using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalilPazarlamaV3._0
{
    public class BulasikMakinesi
    {
        public string Marka;
        public string Model;
        public double Fiyat;
        public int ProgramSayisi;
        public string EnerjiSinifi;

        public BulasikMakinesi(string marka, string model, double fiyat, int programSayisi, string enerjiSınıfı)
        {
            Marka = marka;
            Model = model;
            Fiyat = fiyat;
            ProgramSayisi = programSayisi;
            EnerjiSinifi = enerjiSınıfı;

        }

        public string Yazdir()
        {
            return $"Marka={Marka} Model={Model}\nProgram Sayisi={ProgramSayisi} Enerji Sınıfı={EnerjiSinifi}\nFiyat={Fiyat}";
        }
    }
}
