using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalilPazarlamaV3._0
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Doldur
            List<CamasirMakinesi> camasirMakineleri = new List<CamasirMakinesi>();
            List<BulasikMakinesi> bulasikMakineleri = new List<BulasikMakinesi>();
            List<Buzdolabi> buzdolaplari = new List<Buzdolabi>();
            #region Camaşır Makineleri
            camasirMakineleri.Add(new CamasirMakinesi("Ariston", "AR123", 11000, 7, true));
            camasirMakineleri.Add(new CamasirMakinesi("SIEMENS", "S123", 5000, 8, true));
            camasirMakineleri.Add(new CamasirMakinesi("BOSCH", "WGA142XSTR", 11999, 9, true));
            camasirMakineleri.Add(new CamasirMakinesi("ALTUS", "AL 10123", 8829, 10, true));
            camasirMakineleri.Add(new CamasirMakinesi("PROFILO", "CMU12T91TR", 8499, 9, false));
            camasirMakineleri.Add(new CamasirMakinesi("SAMSUNG", "WW90T4020CE/AH", 8499, 9, true));
            camasirMakineleri.Add(new CamasirMakinesi("Oktay", "OC123", 1250, 3, false));
            #endregion
            #region Bulaşık Makineleri
            bulasikMakineleri.Add(new BulasikMakinesi("REGAL", "KAFA1500", 5500, 10, "A++"));
            bulasikMakineleri.Add(new BulasikMakinesi("Grundig", "GDF 6503", 5998, 6, "D"));
            bulasikMakineleri.Add(new BulasikMakinesi("PROFILO", "BM4321EG", 6900, 4, "D"));
            bulasikMakineleri.Add(new BulasikMakinesi("Vestel", "BM 4202 X", 6049, 4, "E"));
            bulasikMakineleri.Add(new BulasikMakinesi("ALTUS", "AL 434 P", 5150.60, 4, "E"));
            bulasikMakineleri.Add(new BulasikMakinesi("SIEMENS", "SN615X01DT IQ100", 9015.42, 5, "D"));
            #endregion
            #region Buzdolaplari
            buzdolaplari.Add(new Buzdolabi("SIEMENS", "IQ500 KG76NAIF0N", 23203.50, 578, 2, false));
            buzdolaplari.Add(new Buzdolabi("BOSCH", "KGN86AID1N", 24570, 631, 2, false));
            buzdolaplari.Add(new Buzdolabi("SAMSUNG", "RF85K90127F/TR", 55799.07, 850, 4, true));
            buzdolaplari.Add(new Buzdolabi("Grundig", "GSND 6384 S", 16499, 580, 2, false));
            buzdolaplari.Add(new Buzdolabi("ALTUS", "Alk 471", 9989, 514, 2, false));
            buzdolaplari.Add(new Buzdolabi("PROFILO", "BD3155WFVN", 14694, 483, 2, false));
            #endregion



            #endregion

            camasirMakineleri.Remove(camasirMakineleri[6]);

            string devammi = "E";
            double toplam = 0;
            while (devammi.ToUpper() == "E")
            {
                Console.Clear();

                Console.WriteLine("1-Çamaşır Makineleri");
                Console.WriteLine("2-Bulaşık Makineleri");
                Console.WriteLine("3-Buzdolapları");
                Console.WriteLine("4-Tümü");
                Console.WriteLine("Lütfen Reyon Numarasını Giriniz");
                int rynno = Convert.ToInt32(Console.ReadLine());
                while (rynno != 1 && rynno != 2 && rynno != 3 && rynno != 4)
                {
                    Console.WriteLine("Lütfen Geçerli Bir Reyon Numarası Giriniz");
                    rynno = Convert.ToInt32(Console.ReadLine());
                }
                if (rynno == 1)
                {
                    Console.WriteLine("-*-*-*Çamaşır Makineleri-*-*-*-");
                    for (int i = 0; i < camasirMakineleri.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}) {camasirMakineleri[i].Yazdir()}");
                    }
                    Console.WriteLine("Lütfen Almak İstediğiniz Ürünün Numarasını Giriniz");
                    int urunno = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < camasirMakineleri.Count; i++)
                    {
                        if (urunno == i + 1)
                        {
                            Console.WriteLine("Almak İstediğiniz Ürün");
                            Console.WriteLine($"{camasirMakineleri[i].Yazdir()}");
                            Console.WriteLine("Onaylıyor Musunuz");
                            string onay = Console.ReadLine();
                            if (onay.ToUpper() == "E")
                            {
                                Console.WriteLine("Alışveriş Başarılı");
                                toplam = camasirMakineleri[i].Fiyat + toplam;
                                Console.WriteLine("Bu Ürün İçin Ödenecek Tutar= " + camasirMakineleri[i].Fiyat + " TL");
                                Console.WriteLine("Toplam Ödenecek Tutar= " + toplam + " TL");
                            }
                        }
                    }
                }
                if (rynno == 2)

                {
                    Console.WriteLine("-*-*-*Bulaşık Makineleri-*-*-*-");
                    for (int i = 0; i < bulasikMakineleri.Count; i++)
                    {
                        Console.WriteLine($"{ i + 1}) {bulasikMakineleri[i].Yazdir()}");
                    }
                    Console.WriteLine("Lütfen Almak İstediğiniz Ürünün Numarasını Giriniz");
                    int urunno = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < bulasikMakineleri.Count; i++)
                    {
                        if (urunno == i + 1)
                        {
                            Console.WriteLine("Almak İstediğiniz Ürün");
                            Console.WriteLine($"{bulasikMakineleri[i].Yazdir()}");
                            Console.WriteLine("Onaylıyor Musunuz");
                            string onay = Console.ReadLine();
                            if (onay.ToUpper() == "E")
                            {
                                Console.WriteLine("Alışveriş Başarılı");
                                toplam = bulasikMakineleri[i].Fiyat + toplam;
                                Console.WriteLine("Bu Ürün İçin Ödenecek Tutar= " + bulasikMakineleri[i].Fiyat + " TL");
                                Console.WriteLine("Toplam Ödenecek Tutar= " + toplam + " TL");
                            }
                        }
                    }
                }
                if (rynno == 3)
                {
                    Console.WriteLine("-*-*-*Buzdolapları-*-*-*-");
                    for (int i = 0; i < buzdolaplari.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}) {buzdolaplari[i].Yazdir()}");
                    }
                    Console.WriteLine("Lütfen Almak İstediğiniz Ürünün Numarasını Giriniz");
                    int urunno = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < buzdolaplari.Count; i++)
                    {
                        if (urunno == i + 1)
                        {
                            Console.WriteLine("Almak İstediğiniz Ürün");
                            Console.WriteLine($"{buzdolaplari[i].Yazdir()}");
                            Console.WriteLine("Onaylıyor Musunuz");
                            string onay = Console.ReadLine();
                            if (onay.ToUpper() == "E")
                            {
                                Console.WriteLine("Alışveriş Başarılı");
                                toplam = buzdolaplari[i].Fiyat + toplam;
                                Console.WriteLine("Bu Ürün İçin Ödenecek Tutar= " + buzdolaplari[i].Fiyat + " TL");
                                Console.WriteLine("Toplam Ödenecek Tutar= " + toplam + " TL");
                            }
                        }
                    }
                }
                if (rynno == 4)
                {
                    Console.WriteLine("-*-*-*Çamaşır Makineleri-*-*-*-");
                    for (int i = 0; i < camasirMakineleri.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}) {camasirMakineleri[i].Yazdir()}");
                    }


                    Console.WriteLine("-*-*-*Bulaşık Makineleri-*-*-*-");
                    for (int i = 0; i < bulasikMakineleri.Count; i++)
                    {
                        Console.WriteLine($"{camasirMakineleri.Count + i + 1}) {bulasikMakineleri[i].Yazdir()}");
                    }
                    Console.WriteLine("-*-*-*Buzdolapları-*-*-*-");
                    for (int i = 0; i < buzdolaplari.Count; i++)
                    {
                        Console.WriteLine($"{camasirMakineleri.Count + bulasikMakineleri.Count + i + 1}) {buzdolaplari[i].Yazdir()}");
                    }
                    Console.WriteLine("Lütfen Almak İstediğiniz Ürünün Numarasını Giriniz");
                    int urunno = Convert.ToInt32(Console.ReadLine());
                    int a = camasirMakineleri.Count;
                    int b = bulasikMakineleri.Count;
                    int c = buzdolaplari.Count;
                    if (urunno <= a)
                    {
                        for (int i = 0; i < camasirMakineleri.Count; i++)
                        {
                            if (urunno == i + 1)
                            {
                                Console.WriteLine("Almak İstediğiniz Ürün");
                                Console.WriteLine($"{camasirMakineleri[i].Yazdir()}");
                                Console.WriteLine("Onaylıyor Musunuz");
                                string onay = Console.ReadLine();
                                if (onay.ToUpper() == "E")
                                {
                                    Console.WriteLine("Alışveriş Başarılı");
                                    toplam = camasirMakineleri[i].Fiyat + toplam;
                                    Console.WriteLine("Bu Ürün İçin Ödenecek Tutar= " + camasirMakineleri[i].Fiyat + " TL");
                                    Console.WriteLine("Toplam Ödenecek Tutar= " + toplam + " TL");
                                }
                            }
                        }
                    }
                    else if (a < urunno && urunno <= a + b)
                    {
                        for (int i = 0; i < bulasikMakineleri.Count; i++)
                        {
                            if (urunno == a + i + 1)
                            {
                                Console.WriteLine("Almak İstediğiniz Ürün");
                                Console.WriteLine($"{bulasikMakineleri[i].Yazdir()}");
                                Console.WriteLine("Onaylıyor Musunuz");
                                string onay = Console.ReadLine();
                                if (onay.ToUpper() == "E")
                                {
                                    Console.WriteLine("Alışveriş Başarılı");
                                    toplam = bulasikMakineleri[i].Fiyat + toplam;
                                    Console.WriteLine("Bu Ürün İçin Ödenecek Tutar= " + bulasikMakineleri[i].Fiyat + " TL");
                                    Console.WriteLine("Toplam Ödenecek Tutar= " + toplam + " TL");
                                }
                            }
                        }
                    }
                    else if (a + b < urunno && urunno <= a + b + c)
                    {
                        for (int i = 0; i < buzdolaplari.Count; i++)
                        {
                            if (urunno == a + b + i + 1)
                            {
                                Console.WriteLine("Almak İstediğiniz Ürün");
                                Console.WriteLine($"{buzdolaplari[i].Yazdir()}");
                                Console.WriteLine("Onaylıyor Musunuz");
                                string onay = Console.ReadLine();
                                if (onay.ToUpper() == "E")
                                {
                                    Console.WriteLine("Alışveriş Başarılı");
                                    toplam = buzdolaplari[i].Fiyat + toplam;
                                    Console.WriteLine("Bu Ürün İçin Ödenecek Tutar= " + buzdolaplari[i].Fiyat + " TL");
                                    Console.WriteLine("Toplam Ödenecek Tutar= " + toplam + " TL");
                                }
                            }
                        }
                    }


                }
                Console.WriteLine("Alışverişe Devam Edilsin Mi?");
                devammi = Console.ReadLine();

            }
            Console.Clear();
            Console.WriteLine("Bizi Tercih Ettiğiniz İçin Teşekkürler");
            Console.WriteLine("Toplam Alışverişiniz = " + toplam + " TL");

        }
    }
}
