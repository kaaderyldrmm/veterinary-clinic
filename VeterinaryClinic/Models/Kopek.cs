using VeterinaryClinic.Interfaces;
using VeterinaryClinic.Models;

namespace VeterinaryClinic.Hayvanlar;

public class Kopek : Hayvan, IBakimYapilabilir
    {
    public string Adi { get; set; }
    public int Yas { get; set; }
    public double Kilo { get; set; }
    public string Sahibi { get; set; }

    public Kopek(string adi, int yas, double kilo, string sahibi)
              :base ("Köpek",adi, yas, kilo, sahibi)
    {
    }
    public override void BilgiGoster()
    {
        base.BilgiGoster();
    }
    public void BakimYap()
    {
        Console.WriteLine("Köpeğin diş temizliği yapılıyor...");
    }

    public override void SesCikar()
    {
        Console.WriteLine("Hav hav");
    }

    public override void MuayneUcretiHesapla()
    {
        decimal kopek = 700m;

        if (yas > 10)
        {
            decimal muayneUcretiHesapla = 700m + (700m * 0.20m);
            Console.WriteLine($"Toplam Muayne Ücreti: {muayneUcretiHesapla}");
        }
        else
        {
            Console.WriteLine($"Toplam Muayne Ücreti: {kopek}");
        }
    }
}

