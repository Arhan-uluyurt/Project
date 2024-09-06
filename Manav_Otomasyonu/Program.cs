using System.Collections;

namespace ManavOtomasyonu
{
    internal class Program
    {
        static ArrayList meyveler = new ArrayList() { "elma", "muz", "çilek", "portakal", "üzüm" };
        static ArrayList sebzeler = new ArrayList() { "patates", "domates", "soğan", "biber", "havuç" };

        static ArrayList manavStok = new ArrayList();

        static void Main()
        {
            Toptanci();
            Manav();
            Musteri();
        }

        static void Toptanci()
        {
            bool devam = true;
            while (devam)
            {
                Console.WriteLine("Meyve mi Sebze mi?");
                string secim = Console.ReadLine().ToLower();

                if (secim == "meyve")
                {
                    MeyveListele();
                    UrunSecVeAl(meyveler);
                }
                else if (secim == "sebze")
                {
                    SebzeListele();
                    UrunSecVeAl(sebzeler);
                }
                else
                {
                    Console.WriteLine("Geçerli bir işlem giriniz.");
                    Thread.Sleep(1000);
                    Console.Clear();
                    continue;
                }

                Console.WriteLine("Başka bir arzunuz var mı? (evet/hayır)");
                string cevap = Console.ReadLine().ToLower();
                if (cevap != "evet")
                    devam = false;
            }

            Console.WriteLine("İyi günler.");
        }

        static void MeyveListele()
        {
            Console.WriteLine("Meyveler:");
            foreach (string meyve in meyveler)
            {
                Console.WriteLine($"{meyve}");
            }
        }

        static void SebzeListele()
        {
            Console.WriteLine("Sebzeler:");
            foreach (string sebze in sebzeler)
            {
                Console.WriteLine($"{sebze}");
            }
        }

        static void UrunSecVeAl(ArrayList urunListesi)
        {
            Console.WriteLine("Hangi ürünü almak istersiniz?");
            string urun = Console.ReadLine().ToLower();

            if (urunListesi.Contains(urun))
            {
                Console.WriteLine("Kaç kilo almak istersiniz?");
                double kilo = Convert.ToDouble(Console.ReadLine());

                bool urunVar = false;
                for (int i = 0; i < manavStok.Count; i++)
                {
                    var stok = (Tuple<string, double>)manavStok[i];
                    if (stok.Item1 == urun)
                    {
                        manavStok[i] = new Tuple<string, double>(urun, stok.Item2 + kilo);
                        urunVar = true;
                        break;
                    }
                }

                if (!urunVar)
                {
                    manavStok.Add(new Tuple<string, double>(urun, kilo));
                }

                Console.WriteLine($"{kilo} kg {urun} alındı.");
            }
            else
            {
                Console.WriteLine("Geçersiz ürün.");
            }
        }

        static void Manav()
        {
            bool devam = true;
            while (devam)
            {
                Console.WriteLine("MANAV- Meyve mi Sebze mi?");
                string secim = Console.ReadLine().ToLower();

                if (secim == "meyve")
                {
                    if (ManavdaMeyveVarMi())
                    {
                        MeyveListeleManav();
                        UrunSecVeSat();
                    }
                    else
                    {
                        Console.WriteLine("Manavda hiç meyve yok.");
                    }
                }
                else if (secim == "sebze")
                {
                    if (ManavdaSebzeVarMi())
                    {
                        SebzeListeleManav();
                        UrunSecVeSat();
                    }
                    else
                    {
                        Console.WriteLine("Manavda hiç sebze yok.");
                    }
                }
                else
                {
                    Console.WriteLine("Geçerli bir işlem giriniz.");
                    Thread.Sleep(1000);
                    Console.Clear();
                    continue;
                }

                Console.WriteLine("Başka bir arzunuz var mı? (evet/hayır)");
                string cevap = Console.ReadLine().ToLower();
                if (cevap != "evet")
                    devam = false;
            }

            Console.WriteLine("Afiyet olsun.");
        }

        static bool ManavdaMeyveVarMi()
        {
            foreach (var urun in manavStok)
            {
                var stok = (Tuple<string, double>)urun;
                if (meyveler.Contains(stok.Item1) && stok.Item2 > 0)
                {
                    return true;
                }
            }
            return false;
        }

        static bool ManavdaSebzeVarMi()
        {
            foreach (var urun in manavStok)
            {
                var stok = (Tuple<string, double>)urun;
                if (sebzeler.Contains(stok.Item1) && stok.Item2 > 0)
                {
                    return true;
                }
            }
            return false;
        }

        static void MeyveListeleManav()
        {
            Console.WriteLine("Manavdaki meyveler:");
            foreach (var urun in manavStok)
            {
                var stok = (Tuple<string, double>)urun;
                if (meyveler.Contains(stok.Item1))
                {
                    Console.WriteLine($"{stok.Item1}: {stok.Item2} kg");
                }
            }
        }

        static void SebzeListeleManav()
        {
            Console.WriteLine("Manavdaki sebzeler:");
            foreach (var urun in manavStok)
            {
                var stok = (Tuple<string, double>)urun;
                if (sebzeler.Contains(stok.Item1))
                {
                    Console.WriteLine($"{stok.Item1}: {stok.Item2} kg");
                }
            }
        }

        static ArrayList satilanUrunler = new ArrayList();

        static void UrunSecVeSat()
        {
            Console.WriteLine("Hangi ürünü almak istersiniz?");
            string urun = Console.ReadLine().ToLower();

            bool urunStoktaVarMi = false;

            for (int i = 0; i < manavStok.Count; i++)
            {
                var stok = (Tuple<string, double>)manavStok[i];
                if (stok.Item1 == urun)
                {
                    urunStoktaVarMi = true;
                    Console.WriteLine("Kaç kilo almak istersiniz?");
                    double kilo = Convert.ToDouble(Console.ReadLine());

                    if (stok.Item2 >= kilo)  
                    {
                        manavStok[i] = new Tuple<string, double>(urun, stok.Item2 - kilo);
                        Console.WriteLine($"{kilo} kg {urun} satıldı.");

                        satilanUrunler.Add(new Tuple<string, double>(urun, kilo));

                        if (stok.Item2 - kilo == 0)  
                        {
                            manavStok.RemoveAt(i);
                        }
                        break;
                    }
                    else if (stok.Item2 > 0)  
                    {
                        Console.WriteLine($"Yeterli stok yok");

                        manavStok.RemoveAt(i);  
                        break;
                    }
                    else  
                    {
                        Console.WriteLine($"Maalesef manavda {urun} yok.");
                        break;
                    }
                }
            }

            if (!urunStoktaVarMi && (meyveler.Contains(urun) || sebzeler.Contains(urun)))
            {
                Console.WriteLine($"Maalesef manavda {urun} yok.");
            }
            else if (!(meyveler.Contains(urun) || sebzeler.Contains(urun)))
            {
                Console.WriteLine("Geçersiz ürün.");
            }
        }

        static void Musteri()
        {
            Console.WriteLine("Satılan ürünler:");
            foreach (var urun in satilanUrunler)
            {
                var satilan = (Tuple<string, double>)urun;
                Console.WriteLine($"{satilan.Item1}: {satilan.Item2} kg");
            }
        }
    }
}
