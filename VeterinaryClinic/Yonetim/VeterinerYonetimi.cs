using System;
using System.Collections.Generic;
using System.Text;
using VeterinaryClinic.Models;
namespace VeterinaryClinic.Yonetim
{
    public class VeterinerYonetimi
    {
        private List<Hayvan> hayvanlar=new List<Hayvan>();

        public void HayvanEkle(Hayvan hayvan)
        {
            hayvanlar.Add(hayvan);
            // Console.WriteLine("Hayvan Bşarıyla Kaydedildi...");
        }
        public void HayvanlariListele()
        {
            if (hayvanlar.Count == 0)
            {
                Console.WriteLine("Henüz kayıtlı hayvan bulunmamaktadır!..");
                return;
            }
            Console.WriteLine($"\nToplam Hayvan Sayısı: {hayvanlar.Count}\n");

            Console.WriteLine("=============== KAYITLI HAYVANLAR =============\n");
           

            foreach (Hayvan hayvan in hayvanlar)
            {
                hayvan.BilgiGoster();
                Console.WriteLine("------------------------");
            }
        }

            public int HayvanSayisiGetir()
        {
            return hayvanlar.Count;
        }

        public Hayvan HayvanGetir(int index) 
        {
            return hayvanlar[index];
        }
      
    }
    }
