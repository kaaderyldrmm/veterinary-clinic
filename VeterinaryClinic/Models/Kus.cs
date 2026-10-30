using System;
using System.Collections.Generic;
using System.Text;
using VeterinaryClinic.Interfaces;

namespace VeterinaryClinic.Models
{
    public class Kus:Hayvan , IMuayeneEdilebilir
    {
        public string Adi { set; get; }
        public int Yas { set; get; }
        public double Kilo { set; get; }
        public string SahipAd { set; get; }

        public Kus(string adi, int yas, double kilo, string sahipAd)
       :base ("Kus",adi, yas, kilo, sahipAd)
        { }
        public override void BilgiGoster()
        {
            base.BilgiGoster();
        }
        public void MuayneEt()
        {
            Console.WriteLine("Kuş'un kanatlarının muaynesi yapılıyor...");
        }
        public override void SesCikar()
        {
            Console.WriteLine("Cik cik");
        }

        public override void MuayneUcretiHesapla()
        {
            decimal kus = 300m;

            if (yas > 10)
            {
                decimal muayneUcretiHesapla = 300m + (300m * 0.20m);
                Console.WriteLine($"Toplam Muayne Ücreti: {muayneUcretiHesapla}");
            }
            else
            {
                Console.WriteLine($"Toplam Muayne Ücreti: {kus}");
            }
        }
    }
}
