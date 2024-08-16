namespace Cash_Dispenser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hesapparasi1 = 1500000;
            int mevcutpara = 2500;
            string sifre = "ab18";
            
        Sama:
            Console.Clear();
            Console.WriteLine("Kartlı işlem =>  1\nKartsız işlem => 2\nÇıkmak için =>   0");

            int adim1 = Convert.ToInt32(Console.ReadLine());

            if (adim1 == 1)
            {
                Console.WriteLine("Kartlı işlem için şifre giriniz.\nŞifrenin 3 defa yanlış girilmesi durumunda sistem kapatılacaktır.");

                int hak = 3;

                for (int i = hak; i > 0; i--)
                {
                    string girdi = Console.ReadLine();
                    if (sifre != girdi && i == 1)
                    {
                        Console.WriteLine("Hakkınız bitmiştir, sistem kapatılacak.");
                        Environment.Exit(0);
                    }
                    else if (sifre == girdi)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Şifreyi yanlış girdiniz tekrar deneyin");
                    }
                }
                while (true)
                {
                    Yon:
                    Console.Clear();
                    Console.WriteLine("*******Ana Menü*******\nPara çekmek için =>   1\nPara yatırmak için => 2");
                    Console.WriteLine("Para transferleri =>  3\nEğitim ödemeleri =>   4\nÖdemeler =>           5\nBilgi güncelleme =>   6");
                    Console.WriteLine("Ger gitmek için =>    9\nÇıkmak için =>        0");

                    int anamenu1 = Convert.ToInt32(Console.ReadLine());

                    if (anamenu1 == 1)
                    {
                        
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("Hesabınızdan çekmek istediğiniz tutarı giriniz.");

                            int paracekim = Convert.ToInt32(Console.ReadLine());

                            if (paracekim <= mevcutpara)
                            {
                                mevcutpara -= paracekim;
                                Console.WriteLine("işleminiz gerçekleştirildi.\nKalan para:" + mevcutpara + "\nçekilen para:" + paracekim);
                            }
                            else
                            {
                                Console.WriteLine("İşlem gerçekleştirilemedi, hesapta yeterli bakiye yok.");
                            }
                            Bir:
                            Console.WriteLine("\nAna menüye dönmek için => 9\nÇıkmak için =>            0\nGeri gitmek için =>       1");
                            int menugecisi = Convert.ToInt32(Console.ReadLine());

                            if (menugecisi == 9)
                            {
                                break;
                            }
                            else if (menugecisi == 0)
                            {
                                Console.WriteLine("Sistem sonlandırılıyor.");
                                
                                Environment.Exit(0);
                            }
                            else if (menugecisi != 1)
                            {
                                Console.Clear();
                                Console.WriteLine("Geçerli bir sayı giriniz.");
                                goto Bir;
                            }
                        }
                    }
                    else if (anamenu1 == 2)
                    {
                        while (true)
                        {
                            Tun:
                            Console.Clear();
                            Console.WriteLine("Kredi kartına yatırmak için =>    1\nKendi hesabınıza yatırmak için => 2");
                            Console.WriteLine("Ana menü için =>                  9\nÇıkmak için =>                    0");

                            int parayatirma1 = Convert.ToInt32(Console.ReadLine());
                            
                            if (parayatirma1 == 1)
                            {
                                long kartnumara1 = 158023903444;

                                Console.Clear();
                                Console.WriteLine("İşleme devam edebilmek için 12 haneli kart numarasını giriniz.");
                                long kartgirdisi1 = Convert.ToInt64(Console.ReadLine());

                                while (true)
                                {

                                    if (kartgirdisi1 == kartnumara1)
                                    {
                                        Console.WriteLine("Yatırılacak tutarı giriniz.");
                                        int hesapgirdisi1 = Convert.ToInt32(Console.ReadLine());

                                        if (hesapgirdisi1 <= hesapparasi1)
                                        {
                                            hesapparasi1 -= hesapgirdisi1;
                                            mevcutpara += hesapgirdisi1;
                                            
                                            Console.WriteLine("İşleminiz gerçekleştirildi.\nHesapta kalan para:" + hesapparasi1 + "\nKarttaki para:" + mevcutpara);
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("İşlem gerçekleştirilemedi, hesapta yeterli para yok.");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Girdiğiniz numara hatalı.");
                                    }
                                    break;
                                }
                                Bir:
                                Console.WriteLine("\nAna menüye dönmek için => 9\nÇıkmak için =>            0\nGeri gitmek için =>       1");
                                int menugecisi = Convert.ToInt32(Console.ReadLine());

                                if (menugecisi == 9)
                                {
                                    goto Yon;
                                }
                                else if (menugecisi == 0)
                                {
                                    Console.WriteLine("Sistem sonlandırılıyor.");

                                    Environment.Exit(0);
                                }
                                else if (menugecisi != 1)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Geçerli bir sayı giriniz.");
                                    goto Bir;
                                }
                            }
                            else if (parayatirma1 == 2)
                            {
                                Console.WriteLine("Hesabınıza yatırmak istediğiniz tutarı giriniz.");
                                int hesabayatirma = Convert.ToInt32(Console.ReadLine());
                                
                                while (true)
                                {
                                    hesapparasi1 += hesabayatirma;
                                    Console.WriteLine("İşlem gerçekleştirilmiştir.\nYatırılan para:" + hesabayatirma + "\nHesabınızdaki yeni bakiye:" + hesapparasi1);

                                    break;
                                }
                                Bir:
                                Console.WriteLine("\nAna menüye dönmek için => 9\nÇıkmak için =>            0\nGeri gitmek için =>       1");
                                int menugecisi = Convert.ToInt32(Console.ReadLine());

                                if (menugecisi == 9)
                                {
                                    goto Yon;
                                }
                                else if (menugecisi == 0)
                                {
                                    Console.WriteLine("Sistem sonlandırılıyor.");

                                    Environment.Exit(0);
                                }
                                else if (menugecisi != 1)
                                {
                                    Console.WriteLine("Geçerli bir sayı giriniz.");
                                    goto Bir;
                                }
                            }
                            else if (parayatirma1 == 9)
                            {
                                goto Yon;
                            }
                            else if (parayatirma1 == 0)
                            {
                                Console.WriteLine("Sistem sonlandırılıyor.");

                                Environment.Exit(0);
                            }
                            else if (parayatirma1 != 1)
                            {
                                Console.WriteLine("Geçerli bir sayı giriniz.");
                                goto Tun;
                            }
                        }
                    }
                    else if (anamenu1 == 3)
                    {
                        while (true)
                        {
                            San:
                            Console.Clear();
                            Console.WriteLine("Başka hesaba EFT =>    1\nBaşka hesaba havale => 2\nAna menü için =>       9\nÇıkmak için =>         0");
                            int transfer1 = Convert.ToInt32(Console.ReadLine());

                            if (transfer1 == 1)
                            {
                                string EFT = "tr158023903444";

                                Console.Clear();
                                Console.WriteLine("Başında, 'tr' olucak şekilde 12 haneli EFT numaasını giriniz.");
                                string EFTgiris = Console.ReadLine();

                                while (true)
                                {
                                    if (EFTgiris == EFT)
                                    {
                                        Console.WriteLine("Transfer edilecek para miktarını giriniz.");
                                        int eft = Convert.ToInt32(Console.ReadLine());
                                        
                                        if (eft <= hesapparasi1)
                                        {
                                            hesapparasi1-=eft;
                                            Console.WriteLine("İşlem gerçekleştirildi.\nTransfer edilen para;" + eft + "\nHesapta kalan para:" + hesapparasi1);
                                        }
                                        else
                                        {
                                            Console.WriteLine("İşlem gerçekleştirilemedi, hesapta yeterli para yok.");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Girdiğiniz numara hatalı");
                                    }
                                    break;
                                }
                                Bir:
                                Console.WriteLine("\nAna menüye dönmek için => 9\nÇıkmak için =>            0\nGeri gitmek için =>       1");
                                int menugecisi = Convert.ToInt32(Console.ReadLine());

                                if (menugecisi == 9)
                                {
                                    goto Yon;
                                }
                                else if (menugecisi == 0)
                                {
                                    Console.WriteLine("Sistem sonlandırılıyor.");

                                    Environment.Exit(0);
                                }
                                else if (menugecisi != 1)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Geçerli bir sayı giriniz.");
                                    goto Bir;
                                }
                            }
                            else if (transfer1 == 2)
                            {
                                long HAVALE = 15802390344;

                                Console.Clear();
                                Console.WriteLine("Devam etmek için 11 haneli hesap numarasını giriniz.");
                                long havalegiris = Convert.ToInt64(Console.ReadLine());

                                while (true)
                                {
                                    if (havalegiris == HAVALE)
                                    {
                                        Console.WriteLine("Transfer edilecek para miktarını giriniz.");
                                        int havale = Convert.ToInt32(Console.ReadLine());

                                        if (havale <= hesapparasi1)
                                        {
                                            hesapparasi1 -= havale;
                                            Console.WriteLine("İşlem gerçekleştirildi.\nTransfer edilen para;" + havale + "\nHesapta kalan para:" + hesapparasi1);
                                        }
                                        else
                                        {
                                            Console.WriteLine("İşlem gerçekleştirilemedi, hesapta yeterli para yok.");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Girdiğiniz numara hatalı");
                                    }
                                    break;
                                }
                                Bir:
                                Console.WriteLine("\nAna menüye dönmek için => 9\nÇıkmak için =>            0\nGeri gitmek için =>       1");
                                int menugecisi = Convert.ToInt32(Console.ReadLine());

                                if (menugecisi == 9)
                                {
                                    goto Yon;
                                }
                                else if (menugecisi == 0)
                                {
                                    Console.WriteLine("Sistem sonlandırılıyor.");

                                    Environment.Exit(0);
                                }
                                else if (menugecisi != 1)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Geçerli bir sayı giriniz.");
                                    goto Bir;
                                }
                            }
                            else if (transfer1 == 9)
                            {
                                goto Yon;
                            }
                            else if (transfer1 == 0)
                            {
                                Console.WriteLine("Sistem sonlandırılıyor.");

                                Environment.Exit(0);
                            }
                            else if (transfer1 != 1)
                            {
                                Console.WriteLine("Geçerli bir sayı giriniz.");
                                Thread.Sleep(1500);
                                goto San;
                            }
                        }
                    }
                    else if (anamenu1 == 4)
                    {
                        Bir:
                        Console.Clear();
                        Console.WriteLine("Eğitim ödemeleri sayfası arızalı.");
                        Console.WriteLine("\nAna menüye dönmek için => 9\nÇıkmak için =>            0");
                        int egitim1 = Convert.ToInt32(Console.ReadLine());

                        if (egitim1 == 9)
                        {
                            goto Yon;
                        }
                        else if (egitim1 == 0)
                        {
                            Console.WriteLine("Sistem sonlandırılıyor.");

                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("Geçerli bir sayı giriniz.");
                            Thread.Sleep(1500);
                            goto Bir;
                        }
                    }
                    else if (anamenu1 == 5)
                    {
                        while (true)
                        {
                            Kun:
                            Console.Clear();
                            Console.WriteLine("Elektrik faturası =>      1\nTelefon faturası =>       2\nİnternet faturası =>      3");
                            Console.WriteLine("Su faturası =>            4\nOGS ödemeleri =>          5\nAna menüye dönmek için => 9\nÇıkmak için =>            0");

                            int odemeler1 = Convert.ToInt32(Console.ReadLine());

                            while (true)
                            {
                                if (odemeler1 == 1)
                                {
                                    Console.WriteLine("Yapılacak ödeme tutarını giriniz.");
                                    int elektrik1 = Convert.ToInt32(Console.ReadLine());
                                    while (true)
                                    {
                                        if (elektrik1 <= hesapparasi1)
                                        {
                                            hesapparasi1 -= elektrik1;
                                            Console.Clear();
                                            Console.WriteLine("İşlem gerçekleştirildi.\nYapılan ödeme:" + elektrik1 + "\nHesapta kalan para:" + hesapparasi1);
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("İşlem gerçekleştirilemedi, hesapta yeterli para yok.");
                                        }
                                        break;
                                    }
                                    Bir:
                                    Console.WriteLine("\nAna menüye dönmek için => 9\nÇıkmak için =>            0\nGeri gitmek için =>       1");
                                    int menugecisi = Convert.ToInt32(Console.ReadLine());

                                    if (menugecisi == 9)
                                    {
                                        goto Yon;
                                    }
                                    else if (menugecisi == 0)
                                    {
                                        Console.WriteLine("Sistem sonlandırılıyor.");

                                        Environment.Exit(0);
                                    }
                                    else if (menugecisi != 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Geçerli bir sayı giriniz.");
                                        goto Bir;
                                    }
                                }
                                else if (odemeler1 == 2)
                                {
                                    Console.WriteLine("Yapılacak ödeme tutarını giriniz.");
                                    int telefon1 = Convert.ToInt32(Console.ReadLine());
                                    while (true)
                                    {
                                        if (telefon1 <= hesapparasi1)
                                        {
                                            hesapparasi1 -= telefon1;
                                            Console.Clear();
                                            Console.WriteLine("İşlem gerçekleştirildi.\nYapılan ödeme:" + telefon1 + "\nHesapta kalan para:" + hesapparasi1);
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("İşlem gerçekleştirilemedi, hesapta yeterli para yok.");
                                        }
                                        break;
                                    }
                                    Bir:
                                    Console.WriteLine("\nAna menüye dönmek için => 9\nÇıkmak için =>            0\nGeri gitmek için =>       1");
                                    int menugecisi = Convert.ToInt32(Console.ReadLine());

                                    if (menugecisi == 9)
                                    {
                                        goto Yon;
                                    }
                                    else if (menugecisi == 0)
                                    {
                                        Console.WriteLine("Sistem sonlandırılıyor.");

                                        Environment.Exit(0);
                                    }
                                    else if (menugecisi != 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Geçerli bir sayı giriniz.");
                                        goto Bir;
                                    }
                                }
                                else if (odemeler1 == 3)
                                {
                                    Console.WriteLine("Yapılacak ödeme tutarını giriniz.");
                                    int internet1 = Convert.ToInt32(Console.ReadLine());
                                    while (true)
                                    {
                                        if (internet1 <= hesapparasi1)
                                        {
                                            hesapparasi1 -= internet1;
                                            Console.Clear();
                                            Console.WriteLine("İşlem gerçekleştirildi.\nYapılan ödeme:" + internet1 + "\nHesapta kalan para:" + hesapparasi1);
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("İşlem gerçekleştirilemedi, hesapta yeterli para yok.");
                                        }
                                        break;
                                    }
                                    Bir:
                                    Console.WriteLine("\nAna menüye dönmek için => 9\nÇıkmak için =>            0\nGeri gitmek için =>       1");
                                    int menugecisi = Convert.ToInt32(Console.ReadLine());

                                    if (menugecisi == 9)
                                    {
                                        goto Yon;
                                    }
                                    else if (menugecisi == 0)
                                    {
                                        Console.WriteLine("Sistem sonlandırılıyor.");

                                        Environment.Exit(0);
                                    }
                                    else if (menugecisi != 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Geçerli bir sayı giriniz.");
                                        goto Bir;
                                    }
                                }
                                else if (odemeler1 == 4)
                                {
                                    Console.WriteLine("Yapılacak ödeme tutarını giriniz.");
                                    int su1 = Convert.ToInt32(Console.ReadLine());
                                    while (true)
                                    {
                                        if (su1 <= hesapparasi1)
                                        {
                                            hesapparasi1 -= su1;
                                            Console.Clear();
                                            Console.WriteLine("İşlem gerçekleştirildi.\nYapılan ödeme:" + su1 + "\nHesapta kalan para:" + hesapparasi1);
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("İşlem gerçekleştirilemedi, hesapta yeterli para yok.");
                                        }
                                        break;
                                    }
                                    Bir:
                                    Console.WriteLine("\nAna menüye dönmek için => 9\nÇıkmak için =>            0\nGeri gitmek için =>       1");
                                    int menugecisi = Convert.ToInt32(Console.ReadLine());

                                    if (menugecisi == 9)
                                    {
                                        goto Yon;
                                    }
                                    else if (menugecisi == 0)
                                    {
                                        Console.WriteLine("Sistem sonlandırılıyor.");

                                        Environment.Exit(0);
                                    }
                                    else if (menugecisi != 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Geçerli bir sayı giriniz.");
                                        goto Bir;
                                    }
                                }
                                else if (odemeler1 == 5)
                                {
                                    Console.WriteLine("Yapılacak ödeme tutarını giriniz.");
                                    int ogs1 = Convert.ToInt32(Console.ReadLine());
                                    while (true)
                                    {
                                        if (ogs1 <= hesapparasi1)
                                        {
                                            hesapparasi1 -= ogs1;
                                            Console.Clear();
                                            Console.WriteLine("İşlem gerçekleştirildi.\nYapılan ödeme:" + ogs1 + "\nHesapta kalan para:" + hesapparasi1);
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("İşlem gerçekleştirilemedi, hesapta yeterli para yok.");
                                        }
                                        break;
                                    }
                                    Bir:
                                    Console.WriteLine("\nAna menüye dönmek için => 9\nÇıkmak için =>            0\nGeri gitmek için =>       1");
                                    int menugecisi = Convert.ToInt32(Console.ReadLine());

                                    if (menugecisi == 9)
                                    {
                                        goto Yon;
                                    }
                                    else if (menugecisi == 0)
                                    {
                                        Console.WriteLine("Sistem sonlandırılıyor.");

                                        Environment.Exit(0);
                                    }
                                    else if (menugecisi != 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Geçerli bir sayı giriniz.");
                                        goto Bir;
                                    }
                                }
                                else if (odemeler1 == 9)
                                {
                                    goto Yon;
                                }
                                else if (odemeler1 == 0)
                                {
                                    Console.WriteLine("Sistem sonlandırılıyor.");

                                    Environment.Exit(0);
                                }
                                else if (odemeler1 != 1)
                                {
                                    Console.WriteLine("Geçerli bir sayı giriniz.");
                                    Thread.Sleep(1500);
                                    goto Kun;
                                }
                                break;
                            }
                        }
                    }
                    else if (anamenu1 == 6)
                    {
                        while (true)
                        {
                            Dono:
                            Console.Clear();
                            Console.WriteLine("Şifre değiştirme için => 1\nAna menü için =>         9\nÇıkmak için =>           0");
                            int sifredegisim = Convert.ToInt32(Console.ReadLine());

                            if (sifredegisim == 1)
                            {
                                Console.WriteLine("Yeni şifrenizi giriniz.");
                                string yenisifre = Console.ReadLine();

                                while (true)
                                {
                                    if (yenisifre != sifre)
                                    {
                                        sifre = yenisifre;

                                        Console.Clear();
                                        Console.WriteLine("İşleminiz gerçekleştirilmiştir.");
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Yeni şifre eskisi ile aynı olamaz.");
                                    }
                                    break;
                                }
                                Bir:
                                Console.WriteLine("\nAna menüye dönmek için => 9\nÇıkmak için =>            0\nGeri gitmek için =>       1");
                                int menugecisi = Convert.ToInt32(Console.ReadLine());

                                if (menugecisi == 9)
                                {
                                    goto Yon;
                                }
                                else if (menugecisi == 0)
                                {
                                    Console.WriteLine("Sistem sonlandırılıyor.");

                                    Environment.Exit(0);
                                }
                                else if (menugecisi != 1)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Geçerli bir sayı giriniz.");
                                    goto Bir;
                                }
                            }
                            else if (sifredegisim == 9)
                            {
                                goto Yon;
                            }
                            else if (sifredegisim == 0)
                            {
                                Console.WriteLine("Sistem sonlandırılıyor.");

                                Environment.Exit(0);
                            }
                            else if (sifredegisim != 1)
                            {
                                Console.WriteLine("Geçerli bir sayı giriniz.");
                                Thread.Sleep(1500);
                                goto Dono;
                            }
                        }
                    }
                    else if (anamenu1 == 9)
                    {
                        goto Sama;
                    }
                    else if (anamenu1 == 0)
                    {
                        Console.WriteLine("Sistem sonlandırılıyor.");

                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Geçerli bir sayı giriniz.");
                        Thread.Sleep(1500);
                    }
                }
            }
            else if (adim1 == 2)
            {
                while (true)
                {
                Gon:

                    Console.Clear();
                    Console.WriteLine("********Ana Menü********\nCepBank para çekmek => 1\nPara yatırmak için =>  2\nKredi kartı Ödeme =>   3");
                    Console.WriteLine("Eğitim ödemeleri =>    4\nÖdemeler =>            5\nGeri gitmek için =>    9\nÇıkmak için =>         0");

                    int anamenu2 = Convert.ToInt32(Console.ReadLine());

                    if (anamenu2 == 1)
                    {
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("İşleme devam edebilmek için TC kimlik no ve cep telefonu numaranızı giriniz.\n3 defa yanlış giriş olması durumunda sistem 1 saatliğine kilitlenecektir.");

                            int hak2 = 3;

                            for (int j = hak2; j > 0; j--)
                            {
                                Tan:
                                Console.Write("TC kimlik no:");
                                string tc = Console.ReadLine();

                                if (tc.Length != 11 && j == 1)
                                {
                                    Console.WriteLine("Hakkınız bitmiştir, sistem 1 saat kilitlenecektir.");
                                    Thread.Sleep(3600000);
                                }
                                else if (tc.Length == 11 && long.TryParse(tc, out _))
                                {
                                    int hak3 = 3;

                                    for (int k = hak3; k > 0; k--)
                                    {

                                        long telno = 54534442930;
                                        Console.Write("Cep telefonu:");

                                        long telnocevap = Convert.ToInt64(Console.ReadLine());

                                        if (telnocevap == telno)
                                        {
                                            mevcutpara += 1000;

                                            Console.Clear();
                                            Console.WriteLine("İşlem gerçekleştirildi.\nYatırılan ödeme:1000" + "\nYeni bakiye:" + mevcutpara);
                                            break;
                                        }
                                        else if (k == 1)
                                        {
                                            Console.WriteLine("Hakkınız bitmiştir, sistem 1 saat kilitlenecektir.");
                                            Thread.Sleep(3600000);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Hatalı numara, geçerli bir numara giriniz.");
                                            Thread.Sleep(1000);
                                        }
                                    }
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("TC kimlik no 11 haneli ve sadece sayı içeriyor olmalı, tekrar giriniz.");
                                }
                            }

                        Bir:
                            Console.WriteLine("\nAna menüye dönmek için => 9\nÇıkmak için =>            0\nGeri gitmek için =>       1");
                            int menugecisi = Convert.ToInt32(Console.ReadLine());

                            if (menugecisi == 9)
                            {
                                goto Gon;
                            }
                            else if (menugecisi == 0)
                            {
                                Console.WriteLine("Sistem sonlandırılıyor.");

                                Environment.Exit(0);
                            }
                            else if (menugecisi != 1)
                            {
                                Console.Clear();
                                Console.WriteLine("Geçerli bir sayı giriniz.");
                                goto Bir;
                            }
                        }
                    }
                    else if (anamenu2 == 2)
                    {
                        while (true)
                        {
                        Tan:
                            Console.Clear();
                            Console.WriteLine("Nakit ödeme =>    1\nHesaptan ödeme => 2\nAna menü =>       9\nÇıkmak için =>    0");
                            int parayatirma2 = Convert.ToInt32(Console.ReadLine());

                            if (parayatirma2 == 1)
                            {
                                
                                while (true)
                                {
                                    long kartnumara2 = 158023903444;
                                    Console.Clear();
                                    Console.WriteLine("İşleme devam edebilmek için 12 haneli kart numarasını giriniz");
                                    long kartgirisi = Convert.ToInt64(Console.ReadLine());

                                    if (kartgirisi == kartnumara2)
                                    {
                                        
                                        while (true)
                                        {
                                            Console.WriteLine("TC kimlik numaranızı giriniz.");
                                            string tc2 = Console.ReadLine();

                                            if (tc2.Length == 11 && long.TryParse(tc2, out _))
                                            {
                                                Console.WriteLine("Yatırılacak tutarı giriniz.");
                                                int parayatirma3 = Convert.ToInt32(Console.ReadLine());

                                                mevcutpara += parayatirma3;
                                                Console.WriteLine("İşleminiz gerçekleştirildi.\nYatırılan tutar:" + parayatirma3 + "\nKarttaki para:" + mevcutpara);
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Girdiğiniz TC numarası hatalı.\nTC kimlik no 11 haneli ve sadece sayı içeriyor olmalı, tekrar giriniz.");
                                                Thread.Sleep(6000);
                                                Console.Clear();
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hatalı giriş, gerçerli bir numara giriniz.");
                                        Thread.Sleep(800);
                                    }
                                }
                            }
                            else if (parayatirma2 == 2)
                            {
                                while (true)
                                {
                                    long kartnumarasi3 = 158023903444;

                                    Console.Clear();
                                    Console.WriteLine("İşleme devam edebilmek için 12 haneli kart numarasını giriniz");
                                    long kartgirisi = Convert.ToInt64(Console.ReadLine());

                                    if (kartgirisi == kartnumarasi3)
                                    {
                                        Console.WriteLine("Yatırılacak tutarı giriniz.");
                                        int parayatirma3 = Convert.ToInt32(Console.ReadLine());

                                        if (parayatirma3 <= hesapparasi1)
                                        {
                                            hesapparasi1 -= parayatirma3;
                                            mevcutpara += parayatirma3;

                                            Console.Clear();
                                            Console.WriteLine("İşleminiz gerçekleştirildi.\nHesapta kalan para:" + hesapparasi1 + "\nKarttaki para:" + mevcutpara);
                                        }
                                        else
                                        {
                                            Console.WriteLine("İşlem gerçekleştirilemedi, hesapta yeterli para yok.");
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hatalı giriş, gerçerli bir numara giriniz.");
                                        Thread.Sleep(1000);
                                    }
                                }
                            }
                            else if (parayatirma2 == 9)
                            {
                                goto Gon;
                            }
                            else if (parayatirma2 == 0)
                            {
                                Console.WriteLine("Sistem sonlandırılıyor.");

                                Environment.Exit(0);
                            }
                            else
                            {
                                Console.WriteLine("Geçerli bir sayı giriniz.");
                                Thread.Sleep(1500);
                                goto Tan;
                            }

                        Bir:
                            Console.WriteLine("\nAna menüye dönmek için => 9\nÇıkmak için =>            0\nGeri gitmek için =>       1");
                            int menugecisi = Convert.ToInt32(Console.ReadLine());

                            if (menugecisi == 9)
                            {
                                goto Gon;
                            }
                            else if (menugecisi == 0)
                            {
                                Console.WriteLine("Sistem sonlandırılıyor.");

                                Environment.Exit(0);
                            }
                            else if (menugecisi != 1)
                            {
                                Console.Clear();
                                Console.WriteLine("Geçerli bir sayı giriniz.");
                                goto Bir;
                            }
                        }
                    }
                    else if (anamenu2 == 3)
                    {
                        while (true)
                        {
                        San:
                            Console.Clear();
                            Console.WriteLine("Başka hesaba EFT =>    1\nBaşka hesaba havale => 2\nAna menü için =>       9\nÇıkmak için =>         0");
                            int transfer2 = Convert.ToInt32(Console.ReadLine());

                            if (transfer2 == 1)
                            {
                                string EFT = "tr158023903444";

                                Console.Clear();
                                Console.WriteLine("Başında, 'tr' olucak şekilde 12 haneli EFT numaasını giriniz.");
                                string EFTgiris = Console.ReadLine();

                                while (true)
                                {
                                    if (EFTgiris == EFT)
                                    {
                                        Console.WriteLine("Transfer edilecek para miktarını giriniz.");
                                        int eft = Convert.ToInt32(Console.ReadLine());

                                        if (eft <= hesapparasi1)
                                        {
                                            hesapparasi1 -= eft;
                                            Console.WriteLine("İşlem gerçekleştirildi.\nTransfer edilen para;" + eft + "\nHesapta kalan para:" + hesapparasi1);
                                        }
                                        else
                                        {
                                            Console.WriteLine("İşlem gerçekleştirilemedi, hesapta yeterli para yok.");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Girdiğiniz numara hatalı");
                                    }
                                    break;
                                }
                            Bir:
                                Console.WriteLine("\nAna menüye dönmek için => 9\nÇıkmak için =>            0\nGeri gitmek için =>       1");
                                int menugecisi = Convert.ToInt32(Console.ReadLine());

                                if (menugecisi == 9)
                                {
                                    goto Gon;
                                }
                                else if (menugecisi == 0)
                                {
                                    Console.WriteLine("Sistem sonlandırılıyor.");

                                    Environment.Exit(0);
                                }
                                else if (menugecisi != 1)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Geçerli bir sayı giriniz.");
                                    goto Bir;
                                }
                            }
                            else if (transfer2 == 2)
                            {
                                long HAVALE = 15802390344;

                                Console.Clear();
                                Console.WriteLine("Devam etmek için 11 haneli hesap numarasını giriniz.");
                                long havalegiris = Convert.ToInt64(Console.ReadLine());

                                while (true)
                                {
                                    if (havalegiris == HAVALE)
                                    {
                                        Console.WriteLine("Transfer edilecek para miktarını giriniz.");
                                        int havale = Convert.ToInt32(Console.ReadLine());

                                        if (havale <= hesapparasi1)
                                        {
                                            hesapparasi1 -= havale;
                                            Console.WriteLine("İşlem gerçekleştirildi.\nTransfer edilen para;" + havale + "\nHesapta kalan para:" + hesapparasi1);
                                        }
                                        else
                                        {
                                            Console.WriteLine("İşlem gerçekleştirilemedi, hesapta yeterli para yok.");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Girdiğiniz numara hatalı");
                                    }
                                    break;
                                }
                            Bir:
                                Console.WriteLine("\nAna menüye dönmek için => 9\nÇıkmak için =>            0\nGeri gitmek için =>       1");
                                int menugecisi = Convert.ToInt32(Console.ReadLine());

                                if (menugecisi == 9)
                                {
                                    goto Gon;
                                }
                                else if (menugecisi == 0)
                                {
                                    Console.WriteLine("Sistem sonlandırılıyor.");

                                    Environment.Exit(0);
                                }
                                else if (menugecisi != 1)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Geçerli bir sayı giriniz.");
                                    goto Bir;
                                }
                            }
                            else if (transfer2 == 9)
                            {
                                goto Gon;
                            }
                            else if (transfer2 == 0)
                            {
                                Console.WriteLine("Sistem sonlandırılıyor.");

                                Environment.Exit(0);
                            }
                            else
                            {
                                Console.WriteLine("Geçerli bir sayı giriniz.");
                                Thread.Sleep(1500);
                                goto San;
                            }
                        }
                    }
                    else if (anamenu2 == 4)
                    {
                    Bir:
                        Console.Clear();
                        Console.WriteLine("Eğitim ödemeleri sayfası arızalı.");
                        Console.WriteLine("\nAna menüye dönmek için => 9\nÇıkmak için =>            0");
                        int egitim1 = Convert.ToInt32(Console.ReadLine());

                        if (egitim1 == 9)
                        {
                            goto Gon;
                        }
                        else if (egitim1 == 0)
                        {
                            Console.WriteLine("Sistem sonlandırılıyor.");

                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("Geçerli bir sayı giriniz.");
                            Thread.Sleep(1500);
                            goto Bir;
                        }
                    }
                    else if (anamenu2 == 5)
                    {
                        while (true)
                        {
                        Kun:
                            Console.Clear();
                            Console.WriteLine("Elektrik faturası =>      1\nTelefon faturası =>       2\nİnternet faturası =>      3");
                            Console.WriteLine("Su faturası =>            4\nOGS ödemeleri =>          5\nAna menüye dönmek için => 9\nÇıkmak için =>            0");

                            int odemeler2 = Convert.ToInt32(Console.ReadLine());

                            while (true)
                            {
                                if (odemeler2 == 1)
                                {
                                    Console.WriteLine("Yapılacak ödeme tutarını giriniz.");
                                    int elektrik1 = Convert.ToInt32(Console.ReadLine());
                                    while (true)
                                    {
                                        if (elektrik1 <= hesapparasi1)
                                        {
                                            hesapparasi1 -= elektrik1;
                                            Console.Clear();
                                            Console.WriteLine("İşlem gerçekleştirildi.\nYapılan ödeme:" + elektrik1 + "\nHesapta kalan para:" + hesapparasi1);
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("İşlem gerçekleştirilemedi, hesapta yeterli para yok.");
                                        }
                                        break;
                                    }
                                Bir:
                                    Console.WriteLine("\nAna menüye dönmek için => 9\nÇıkmak için =>            0\nGeri gitmek için =>       1");
                                    int menugecisi = Convert.ToInt32(Console.ReadLine());

                                    if (menugecisi == 9)
                                    {
                                        goto Gon;
                                    }
                                    else if (menugecisi == 0)
                                    {
                                        Console.WriteLine("Sistem sonlandırılıyor.");

                                        Environment.Exit(0);
                                    }
                                    else if (menugecisi != 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Geçerli bir sayı giriniz.");
                                        goto Bir;
                                    }
                                }
                                else if (odemeler2 == 2)
                                {
                                    Console.WriteLine("Yapılacak ödeme tutarını giriniz.");
                                    int telefon1 = Convert.ToInt32(Console.ReadLine());
                                    while (true)
                                    {
                                        if (telefon1 <= hesapparasi1)
                                        {
                                            hesapparasi1 -= telefon1;
                                            Console.Clear();
                                            Console.WriteLine("İşlem gerçekleştirildi.\nYapılan ödeme:" + telefon1 + "\nHesapta kalan para:" + hesapparasi1);
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("İşlem gerçekleştirilemedi, hesapta yeterli para yok.");
                                        }
                                        break;
                                    }
                                Bir:
                                    Console.WriteLine("\nAna menüye dönmek için => 9\nÇıkmak için =>            0\nGeri gitmek için =>       1");
                                    int menugecisi = Convert.ToInt32(Console.ReadLine());

                                    if (menugecisi == 9)
                                    {
                                        goto Gon;
                                    }
                                    else if (menugecisi == 0)
                                    {
                                        Console.WriteLine("Sistem sonlandırılıyor.");

                                        Environment.Exit(0);
                                    }
                                    else if (menugecisi != 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Geçerli bir sayı giriniz.");
                                        goto Bir;
                                    }
                                }
                                else if (odemeler2 == 3)
                                {
                                    Console.WriteLine("Yapılacak ödeme tutarını giriniz.");
                                    int internet1 = Convert.ToInt32(Console.ReadLine());
                                    while (true)
                                    {
                                        if (internet1 <= hesapparasi1)
                                        {
                                            hesapparasi1 -= internet1;
                                            Console.Clear();
                                            Console.WriteLine("İşlem gerçekleştirildi.\nYapılan ödeme:" + internet1 + "\nHesapta kalan para:" + hesapparasi1);
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("İşlem gerçekleştirilemedi, hesapta yeterli para yok.");
                                        }
                                        break;
                                    }
                                Bir:
                                    Console.WriteLine("\nAna menüye dönmek için => 9\nÇıkmak için =>            0\nGeri gitmek için =>       1");
                                    int menugecisi = Convert.ToInt32(Console.ReadLine());

                                    if (menugecisi == 9)
                                    {
                                        goto Gon;
                                    }
                                    else if (menugecisi == 0)
                                    {
                                        Console.WriteLine("Sistem sonlandırılıyor.");

                                        Environment.Exit(0);
                                    }
                                    else if (menugecisi != 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Geçerli bir sayı giriniz.");
                                        goto Bir;
                                    }
                                }
                                else if (odemeler2 == 4)
                                {
                                    Console.WriteLine("Yapılacak ödeme tutarını giriniz.");
                                    int su1 = Convert.ToInt32(Console.ReadLine());
                                    while (true)
                                    {
                                        if (su1 <= hesapparasi1)
                                        {
                                            hesapparasi1 -= su1;
                                            Console.Clear();
                                            Console.WriteLine("İşlem gerçekleştirildi.\nYapılan ödeme:" + su1 + "\nHesapta kalan para:" + hesapparasi1);
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("İşlem gerçekleştirilemedi, hesapta yeterli para yok.");
                                        }
                                        break;
                                    }
                                Bir:
                                    Console.WriteLine("\nAna menüye dönmek için => 9\nÇıkmak için =>            0\nGeri gitmek için =>       1");
                                    int menugecisi = Convert.ToInt32(Console.ReadLine());

                                    if (menugecisi == 9)
                                    {
                                        goto Gon;
                                    }
                                    else if (menugecisi == 0)
                                    {
                                        Console.WriteLine("Sistem sonlandırılıyor.");

                                        Environment.Exit(0);
                                    }
                                    else if (menugecisi != 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Geçerli bir sayı giriniz.");
                                        goto Bir;
                                    }
                                }
                                else if (odemeler2 == 5)
                                {
                                    Console.WriteLine("Yapılacak ödeme tutarını giriniz.");
                                    int ogs1 = Convert.ToInt32(Console.ReadLine());
                                    while (true)
                                    {
                                        if (ogs1 <= hesapparasi1)
                                        {
                                            hesapparasi1 -= ogs1;
                                            Console.Clear();
                                            Console.WriteLine("İşlem gerçekleştirildi.\nYapılan ödeme:" + ogs1 + "\nHesapta kalan para:" + hesapparasi1);
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("İşlem gerçekleştirilemedi, hesapta yeterli para yok.");
                                        }
                                        break;
                                    }
                                Bir:
                                    Console.WriteLine("\nAna menüye dönmek için => 9\nÇıkmak için =>            0\nGeri gitmek için =>       1");
                                    int menugecisi = Convert.ToInt32(Console.ReadLine());

                                    if (menugecisi == 9)
                                    {
                                        goto Gon;
                                    }
                                    else if (menugecisi == 0)
                                    {
                                        Console.WriteLine("Sistem sonlandırılıyor.");

                                        Environment.Exit(0);
                                    }
                                    else if (menugecisi != 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Geçerli bir sayı giriniz.");
                                        goto Bir;
                                    }
                                }
                                else if (odemeler2 == 9)
                                {
                                    goto Gon;
                                }
                                else if (odemeler2 == 0)
                                {
                                    Console.WriteLine("Sistem sonlandırılıyor.");

                                    Environment.Exit(0);
                                }
                                else if (odemeler2 != 1)
                                {
                                    Console.WriteLine("Geçerli bir sayı giriniz.");
                                    Thread.Sleep(1500);
                                    goto Kun;
                                }
                                break;
                            }
                        }
                    }
                    else if (anamenu2 == 9)
                    {
                        goto Sama;
                    }
                    else if (anamenu2 == 0)
                    {
                        Console.WriteLine("Sistem sonlandırılıyor.");

                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Geçerli bir sayı giriniz.");
                        Thread.Sleep(1500);
                    }
                }
            }
            else if (adim1 == 0)
            {
                Console.WriteLine("Sistem sonlandırılıyor.");

                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Geçerli bir sayı giriniz.");
                Thread.Sleep(1500);

                goto Sama;
            }
        }
    }
}
