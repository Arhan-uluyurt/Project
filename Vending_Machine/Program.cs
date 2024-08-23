using System.Runtime.CompilerServices;

namespace vending_machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int urunsayisi = 5;
            string[] urunler = new string[urunsayisi];
            int[] fiyatlar = new int[urunsayisi];

            urunler[0] = "Gofret";
            fiyatlar[0] = 5;

            urunler[1] = "Soda";
            fiyatlar[1] = 3;

            urunler[2] = "Kola";
            fiyatlar[2] = 7;

            urunler[3] = "Bisküvi";
            fiyatlar[3] = 4;

            urunler[4] = "Meyve suyu";
            fiyatlar[4] = 6;

            
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Ürün almak için => 1\nÇıkmak için =>     0");

                string giris = Console.ReadLine().ToUpper();

                if (giris == "1") 
                {
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("Mevcut Ürünler:");
                        for (int i = 0; i < urunsayisi; i++)
                        {
                            Console.WriteLine((i + 1) + "-) " + urunler[i] + " - " + fiyatlar[i] + " TL");
                        }

                        Console.WriteLine("Almak istediğiniz ürünün numarasını giriniz:");
                        int secilenUrun;
                        while (!int.TryParse(Console.ReadLine(), out secilenUrun) || secilenUrun < 1 || secilenUrun > urunsayisi)
                        {
                            Console.WriteLine("Geçersiz numara. geçerli bir ürün numarası giriniz:");
                            break;
                        }

                        int urunIndex = secilenUrun - 1;
                        
                        while (true)
                        {
                            Console.WriteLine("Seçilen Ürün: " + urunler[urunIndex] + " - Fiyat: " + fiyatlar[urunIndex] + " TL");

                            Console.WriteLine("Ödeme yapmak için ücreti giriniz:");
                            int girilenPara;
                            while (!int.TryParse(Console.ReadLine(), out girilenPara) || girilenPara < 0)
                            {
                                Console.WriteLine("Geçersiz tutar. Geçerli bir tutar giriniz:");
                            }

                            if (girilenPara >= fiyatlar[urunIndex])
                            {
                                Console.WriteLine("İşlem gerçekleşti. Para üstü: " + (girilenPara - fiyatlar[urunIndex]) + " TL");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Yetersiz bakiye. Tekrar deneyin.");
                            }
                        }
                        break;
                    }
                }
                else if (giris == "Q") 
                {
                    while (true) 
                    {
                        Console.Clear();
                        Console.WriteLine("******* Admin paneli *******\nÜrün eklemek için =>      1\nÜrün çıkarmak için =>     2\nFiyat güncellemek için => 3");
                        Console.WriteLine("Geri gitmek için =>       9\nÇıkmak için =>            0");

                        string admin = Console.ReadLine();

                        if (admin == "1") 
                        {
                            Console.WriteLine("Eklemek istediğiniz ürünün adını giriniz.");
                            string urunekleme = Console.ReadLine();
                            Console.WriteLine("Fiyatını giriniz.");
                            int fiyatekle;

                            while (!int.TryParse(Console.ReadLine(), out fiyatekle) || fiyatekle <= 0)
                            {
                                Console.WriteLine("Geçersiz fiyat. Tekrar girin:");
                            }

                            string[] yeniUrunler = new string[urunsayisi + 1];
                            int[] yeniFiyatlar = new int[urunsayisi + 1];

                            for (int i = 0; i < urunsayisi; i++)
                            {
                                yeniUrunler[i] = urunler[i];
                                yeniFiyatlar[i] = fiyatlar[i];
                            }

                            yeniUrunler[urunsayisi] = urunekleme;
                            yeniFiyatlar[urunsayisi] = fiyatekle;

                            urunler = yeniUrunler;
                            fiyatlar = yeniFiyatlar;
                            urunsayisi++;

                            Console.Clear();
                            Console.WriteLine("İşlem gerçekleştirildi, Ürün eklendi.");
                            break;
                        }
                        else if (admin == "2") 
                        {
                            Console.WriteLine("Çıkarmak istediğiniz ürünün numarasını giriniz (1'den başlayarak):");

                            int urunNumarası;
                            while (!int.TryParse(Console.ReadLine(), out urunNumarası) || urunNumarası < 1 || urunNumarası > urunsayisi)
                            {
                                Console.WriteLine("Geçersiz numara. Geçerli bir ürün numarası giriniz:");
                            }

                            int index = urunNumarası - 1;

                            string[] yeniUrunler = new string[urunsayisi - 1];
                            int[] yeniFiyatlar = new int[urunsayisi - 1];

                            for (int i = 0, j = 0; i < urunsayisi; i++)
                            {
                                if (i != index)
                                {
                                    yeniUrunler[j] = urunler[i];
                                    yeniFiyatlar[j] = fiyatlar[i];
                                    j++;
                                }
                            }

                            urunler = yeniUrunler;
                            fiyatlar = yeniFiyatlar;
                            urunsayisi--;

                            Console.WriteLine("İşlem gerçekleşti, ürün çıkartıldı.");
                            break;
                        }
                        else if (admin == "3") 
                        {
                            Console.WriteLine("Güncellemek istediğiniz ürünün numarasını giriniz (1'den başlayarak):");

                            int urunNumarası;
                            while (!int.TryParse(Console.ReadLine(), out urunNumarası) || urunNumarası < 1 || urunNumarası > urunsayisi)
                            {
                                Console.WriteLine("Geçersiz numara. Geçerli bir ürün numarası giriniz:");
                            }

                            int index = urunNumarası - 1;

                            Console.WriteLine("Yeni fiyatını giriniz:");

                            int yeniFiyat;
                            while (!int.TryParse(Console.ReadLine(), out yeniFiyat) || yeniFiyat <= 0)
                            {
                                Console.WriteLine("Geçersiz fiyat. Fiyat sıfırdan büyük bir tamsayı olmalıdır. Tekrar girin:");
                            }

                            fiyatlar[index] = yeniFiyat;

                            Console.WriteLine("İşlem gerçekleştirildi, ürün fiyatı güncellendi.");
                            break;
                        }
                        else if (admin == "9") 
                        {
                            break;
                        }
                        else if (admin == "0") 
                        {
                            Console.WriteLine("Sistem sonlandırılıyor.");
                            Thread.Sleep(1500);
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("Hatalı giriş, geçerli bir sayı giriniz.");
                            continue;
                        }
                    }
                    
                }
                else if (giris == "0") 
                {
                    Console.WriteLine("Sistm sonlandırılıyor.");
                    Thread.Sleep(1500);
                    break;
                }
                else 
                {
                    Console.WriteLine("Hatalı giriş, geçerli bir sayı giriniz.");
                    Thread.Sleep(1600);
                    continue;
                }
                while (true)
                {
                    Console.WriteLine("Ana menü için => 1\nÇıkmak için =>   0");
                    string menugecis = Console.ReadLine();
                    if (menugecis == "1") 
                    {
                        break;
                    }
                    else if (menugecis == "0") 
                    {
                        Console.WriteLine("Sistem sonlandırılıyor.");
                        Thread.Sleep(1500);
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Hatalı giriş, geçerli bir sayı giriniz.");
                    }
                }
                
            }
        }
    }
}
