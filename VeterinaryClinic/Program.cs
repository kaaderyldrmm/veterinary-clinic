using VeterinaryClinic.Hayvanlar;
using VeterinaryClinic.Interfaces;
using VeterinaryClinic.Models;
using VeterinaryClinic.Yonetim;

VeterinerYonetimi yonetim = new VeterinerYonetimi();
yonetim.HayvanEkle(new Kedi("Boncuk", 3, 5, "SEREN"));
yonetim.HayvanEkle(new Kus("Kiko", 1, 0.68, "CİHAN"));
yonetim.HayvanEkle(new Kopek("Zula", 4, 7, "LEYLA"));
yonetim.HayvanEkle(new Kus("Mavi", 2, 1, "ZÜLAL"));

bool calis = true;
while (calis)
{
    Console.WriteLine("\n================ VETERİNER KLİNİĞİ YÖNETİM SİSTEMİ ================\n");
    Console.WriteLine("1. YENİ HAYVAN KAYDI EKLE");
    Console.WriteLine("2. KAYITLI HAYVANLARI LİSTELE");
    Console.WriteLine("3. HAYVAN SESLERİNİ GÖRÜNTÜLE");
    Console.WriteLine("4. MUAYNE ÜCRETİ HESAPLA");
    Console.WriteLine("5. HAYVAN İŞLEMİ GERÇEKLEŞTİR");
    Console.WriteLine("6. ÇIKIŞ");

    Console.Write("\nSEÇİMİNİZ: ");
    int secimYap=Convert.ToInt32(Console.ReadLine());

    switch (secimYap)
    {
        case 1:

            Console.WriteLine("\n======== HAYVAN KAYIT İŞLEMİ =========\n");

            Console.WriteLine("1. Kedi");
            Console.WriteLine("2. Köpek");
            Console.WriteLine("3. Kuş");

            Console.Write("\nHayvan Türünü Girin: ");
            int turu=Convert.ToInt32(Console.ReadLine());

            Console.Write("Hayvanın Adını Girin:");
            string ad = Console.ReadLine();

            Console.Write("Hayvanın Yaşını Girin:");
            int yas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Hayvanın Kilosunu Girin: ");
            double kilo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Hayvan Sahibinin Adı: ");
            string sahipAdi = Console.ReadLine();

            Hayvan yeniHayvan = null;

            switch (turu)
            {
                case 1:
                    yeniHayvan = new Kedi(ad, yas, kilo, sahipAdi);
                    break;
                case 2:
                    yeniHayvan = new Kopek(ad, yas, kilo, sahipAdi);
                    break;
                case 3:
                    yeniHayvan = new Kus(ad, yas, kilo, sahipAdi);
                    break;
                default:
                    Console.WriteLine("GEÇERSİZ TÜR SEÇİMİ!!!");
                    break;
            }
            if (yeniHayvan!=null)
            {
                yonetim.HayvanEkle(yeniHayvan);
            }
            break;

        case 2:

            yonetim.HayvanlariListele();
            break;

        case 3:
            if (yonetim.HayvanSayisiGetir() == 0)
            {
                Console.WriteLine("Henüz Kayıtlı Hayvan Bulunmamaktadır!..");
            }
            else
            {
                Console.WriteLine("\n=========== HAYVAN SESLERİ ============\n");
                int sayac = 1;

                for (int i = 0; i < yonetim.HayvanSayisiGetir(); i++)
                {
                    Hayvan hayvan = yonetim.HayvanGetir(i);
                    Console.WriteLine($"{i + 1} - {hayvan.GetType().Name} - {hayvan.Ad}");
                }

                Console.Write("\nSesini Görüntülemek İstediğiniz Hayvanı Seçin:");
                int seciminiz = Convert.ToInt32(Console.ReadLine());

                if (seciminiz >= 1 && seciminiz <= yonetim.HayvanSayisiGetir())
                {
                    yonetim.HayvanGetir(seciminiz - 1).SesCikar();
                }
                else
                {
                    Console.WriteLine("Geçersiz hayvan seçimi yaptınız!..");
                }
            }
            break;

        case 4:

            if (yonetim.HayvanSayisiGetir() == 0)
            {
                Console.WriteLine("Henüz kayıtlı hayvan bulunmamaktadır!");
            }
            else
            {
                Console.WriteLine("\n=========== MUAYENE ÜCRET HESABI ===========\n");

                for (int i = 0; i < yonetim.HayvanSayisiGetir(); i++)
                {
                    Hayvan hayvan = yonetim.HayvanGetir(i);
                    Console.WriteLine($"{i + 1} - {hayvan.GetType().Name} - {hayvan.Ad}");
                }

                Console.Write("\nMuayene ücretini hesaplamak istediğiniz hayvanı seçin: ");
                int seciminiz = Convert.ToInt32(Console.ReadLine());

                if (seciminiz >= 1 && seciminiz <= yonetim.HayvanSayisiGetir())
                {
                    yonetim.HayvanGetir(seciminiz - 1).MuayneUcretiHesapla();
                }
                else
                {
                    Console.WriteLine("Geçersiz hayvan seçimi yaptınız!");
                }
            }

            break;

        case 5:

            if (yonetim.HayvanSayisiGetir() == 0)
            {
                Console.WriteLine("Henüz kayıtlı hayvan bulunmamaktadır!");
            }
            else
            {
                Console.WriteLine("\n================ HAYVAN İŞLEMLERİ ================\n");

                for (int i = 0; i < yonetim.HayvanSayisiGetir(); i++)
                {
                    Hayvan hayvan = yonetim.HayvanGetir(i);
                    Console.WriteLine($"{i + 1} - {hayvan.GetType().Name} - {hayvan.Ad}");
                }

                Console.Write("\nİşlem yapmak istediğiniz hayvanı seçin: ");
                int seciminiz = Convert.ToInt32(Console.ReadLine());

                if (seciminiz >= 1 && seciminiz <= yonetim.HayvanSayisiGetir())
                {
                    Hayvan secilenHayvan = yonetim.HayvanGetir(seciminiz - 1);

                    Console.WriteLine("\n------------ İşlem Seçimi ------------\n");
                    Console.WriteLine("1. Bakım İşlemi");
                    Console.WriteLine("2. Muayene İşlemi");
                    Console.Write("\nSecim: ");
                    int sec = Convert.ToInt32(Console.ReadLine());

                    switch (sec)
                    {
                        case 1:
                            Console.WriteLine("\n---- Bakım İşlemi ----");

                            if (secilenHayvan is IBakimYapilabilir bakim)
                            {
                                bakim.BakimYap();
                            }
                            else
                            {
                                Console.WriteLine("Bu hayvan bakım işlemini desteklemiyor!");
                            }
                            break;

                        case 2:
                            Console.WriteLine("\n---- Muayene İşlemi ----");

                            if (secilenHayvan is IMuayeneEdilebilir muayene)
                            {
                                muayene.MuayneEt();
                            }
                            else
                            {
                                Console.WriteLine("Bu hayvan muayene işlemini desteklemiyor!");
                            }
                            break;

                        default:
                            Console.WriteLine("Tanımsız işlem!");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Geçersiz hayvan seçimi!");
                }
            }

            break;
        case 6:

            calis=false;
            Console.WriteLine("ÇIKIŞ YAPILIYOR...");
            Console.ReadKey();

            break;

        default:
            Console.WriteLine("TANIMSIZ İŞLEM SEÇİMİ YAPTINIZ!..");
                break;

    }

}
