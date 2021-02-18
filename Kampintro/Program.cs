using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayısı = 32000;
            double faizOranı = 1.45;
            bool sistemeGirişYapmısMi = true;
            double dolarDün = 7.35;
            double dolarBugün = 7.45;

            if (dolarDün>dolarBugün)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDün<dolarBugün)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }


            if (sistemeGirişYapmısMi == true)
            {
                Console.WriteLine("kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("giriş yap butonu");
            }
      
            Console.WriteLine(kategoriEtiketi);
            
        }
    }
}
