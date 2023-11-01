using ClassMetotDemo;
using System;
using System.Collections.Generic;

public class MusteriManager
{
    private List<Musteri> musteriler;

    public MusteriManager()
    {
        musteriler = new List<Musteri>();
    }
    public void MusterileriEkle(params Musteri[] staticMusteriler)
    {
        musteriler.AddRange(staticMusteriler);
    }
    public void MusteriEkle(Musteri musteri)
    {
        musteriler.Add(musteri);
        Console.WriteLine("Müşteri eklendi: " + musteri.Ad + " " + musteri.Soyad);
    }

    public void MusteriListele()
    {
        Console.WriteLine("\n------------|Users|------------");
        foreach (var musteri in musteriler)
        {
            Console.WriteLine("ID: " + musteri.Id + ", Ad: " + musteri.Ad + ", Soyad: " + musteri.Soyad);
        }
        Console.WriteLine("-------------------------------\n");
    }

    public void MusteriSil(int musteriId)
    {
        Musteri silinecekMusteri = musteriler.Find(m => m.Id == musteriId);
        if (silinecekMusteri != null)
        {
            musteriler.Remove(silinecekMusteri);
            Console.WriteLine("Müşteri silindi: " + silinecekMusteri.Ad + " " + silinecekMusteri.Soyad);
        }
        else
        {
            Console.WriteLine("Müşteri bulunamadı.");
        }
    }
}
