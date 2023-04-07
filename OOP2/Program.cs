
using OOP2;

#region İnterface ile referans etmek

//IKrediManager ihtiyacKrediManager1 = new İhtiyacKrediManager();
//ihtiyacKrediManager1.Hesapla();

//IKrediManager tasitKrediManager1 = new TasitKrediManager();
//tasitKrediManager1.Hesapla();

//IKrediManager konutKrediManager1 = new KonutKrediManager();
//konutKrediManager1.Hesapla();
#endregion

#region Class instance alarak çağırmak

İhtiyacKrediManager ihtiyacKrediManager = new İhtiyacKrediManager();

TasitKrediManager tasitKrediManager = new TasitKrediManager();

KonutKrediManager konutKrediManager = new KonutKrediManager();



BasvuruManager basvuruManager = new BasvuruManager();
basvuruManager.BasvuruYap(new KonutKrediManager());

#endregion

Console.WriteLine(); 
Console.WriteLine();    

#region Interface ile referans ederek çağırmak(polymorphism)

IKrediManager ihtiyacKrediManager1 = new İhtiyacKrediManager();
IKrediManager tasitKrediManager1 = new TasitKrediManager();
IKrediManager konutKrediManager1 = new KonutKrediManager();


BasvuruManager basvuruManagerInterfaceOlan = new BasvuruManager();
basvuruManagerInterfaceOlan.BasvuruYap(konutKrediManager1);

#endregion

Console.WriteLine();
Console.WriteLine();


List<IKrediManager> krediManagers = new List<IKrediManager>() { konutKrediManager1,tasitKrediManager1};
BasvuruManager basvuruManagerList = new BasvuruManager();
basvuruManagerList.KrediOnBilgilendirme(krediManagers);

