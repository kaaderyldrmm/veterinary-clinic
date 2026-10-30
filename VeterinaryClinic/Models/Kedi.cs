using VeterinaryClinic.Interfaces;
using VeterinaryClinic.Models;

namespace VeterinaryClinic.Hayvanlar;

public class Kedi : Hayvan, IBakimYapilabilir
{
    public string Adi { set; get;  }
    public int Yas { set; get; }
    public double Kilo { set; get; }
    public string SahipAd { set; get; }

    public Kedi(string adi, int yas, double kilo, string sahipAd)
   : base("Kedi",adi, yas, kilo, sahipAd) 
    { 
    }
    public void BakimYap() 
    {
        Console.WriteLine("Kedinin tırnak bakımı yapılıyor...");
    }
    public override void SesCikar()
    {
        Console.WriteLine("Miyav");
    }

    public override void BilgiGoster()
    {
        base.BilgiGoster();
    }

    public override void MuayneUcretiHesapla()
    {
        decimal kedi = 500m;

        if (yas>10)
        {
            decimal muayneUcretiHesapla = 500m + (500m * 0.20m);
            Console.WriteLine($"Toplam Muayne Ücreti: {muayneUcretiHesapla}");
        }
        else
        {
            Console.WriteLine($"Toplam Muayne Ücreti: {kedi}");
        }
    }
}

