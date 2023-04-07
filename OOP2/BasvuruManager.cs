using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2  
{
    public class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager)
        {
            krediManager.Hesapla(); // IKrediManager parametre olarak verdim ki ondan implamente olanları kullanabileyim
        }

        public void KrediOnBilgilendirme(List<IKrediManager> krediManagers) // personel bir veya daha fazla kredi türü seçebilir o yüzden List
        {
            foreach (var kredi in krediManagers)
            {
                kredi.Hesapla();
            }

        }
        public int Id { get; set; }
    }
}
