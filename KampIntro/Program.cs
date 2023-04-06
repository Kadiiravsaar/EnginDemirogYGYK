// See https://aka.ms/new-console-template for more information
using KampIntro;

Console.WriteLine("Hello, World!");


GercekMusteri gercekMusteri = new GercekMusteri();
gercekMusteri.ID = 1;
gercekMusteri.TcNo = "606060";
gercekMusteri.Adi = "Kadir";
gercekMusteri.Soyadi = "Avşar";

TuzelMusteri tuzelMusteri = new TuzelMusteri();
tuzelMusteri.ID = 1;
tuzelMusteri.MusteriNo = "61616161";
tuzelMusteri.SirketAdi = "Kadoa";
tuzelMusteri.VergiNo = "626262";

Musteri musteri = new GercekMusteri();
Musteri musteri2 = new TuzelMusteri();


CustomerManager customerManager = new CustomerManager();
customerManager.Add(gercekMusteri);
customerManager.Add(tuzelMusteri);
customerManager.Add(musteri);
customerManager.Add(musteri2);
