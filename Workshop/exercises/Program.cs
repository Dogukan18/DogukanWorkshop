using System;

namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            //değişkenler=değer tutucu,alias
            //Do not repeat yourself-Kendini tekrarlama
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.55;
            double dolarBugün = 7.45;

            if (dolarDun>dolarBugün)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if(dolarDun<dolarBugün)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu ");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            
            


        }
    }
}
