using System;
using System.Collections.Generic;
using System.Text;
using VeterinaryClinic.Hayvanlar;
using VeterinaryClinic.Interfaces;

namespace VeterinaryClinic.Models
{
    public class Hayvan
    {
        public string Ad {  get; set; }
        private int Yas;

        public int yas
        {
            get { return Yas; }
            set
            {
                if (value > 0)
                {
                    Yas = value;
                }
                else
                {
                    Console.WriteLine("Yaş sıfırdan büyük olmalı!");
                }
            }
        }
        private double Kilo;

        public double kilo
        {
            get { return Kilo; }
            set
            {
                if (value > 0)
                {
                    Kilo = value;
                }
                else
                {
                    Console.WriteLine("Sayfa sayısı 0'dan büyük olmalıdır.");
                }
            }
        }

        public string SahipAdi {  get; set; }

        public Hayvan(string tur,string ad, int yas, double kilo, string sahipAdi) 
        {
            Turu=tur;
            Ad = ad;
            this.yas = yas;
            this.kilo = kilo;
            SahipAdi = sahipAdi;
        }

        public string Turu {  get; set; }
        public virtual void SesCikar()
        {
            Console.WriteLine("Hayvan ses çıkarıyor...");
        }

        public virtual void BilgiGoster()
        {
            Console.WriteLine($"Hayvan Türü: {GetType().Name}");
            Console.WriteLine($"Hayvan Adı: {Ad}");
            Console.WriteLine($"Yaş: {yas}");
            Console.WriteLine($"Kilo: {kilo}");
            Console.WriteLine($"Sahibin Adı: {SahipAdi}");
        }

        public virtual void MuayneUcretiHesapla()
        {

        }


    }
    
}
