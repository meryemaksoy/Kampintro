using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adı = "Engin";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "c#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.izlenmeOranı = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.izlenmeOranı = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.izlenmeOranı = 80;

            //Console.WriteLine(kurs1.KursAdi + " : "+ kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)

            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen + " : " + kurs.izlenmeOranı );
            }


            //Console.WriteLine("Hello World!");
        }
    }

    class Kurs
    {
        public string KursAdi{ get; set; }
        public string Egitmen { get; set; }
        public int izlenmeOranı { get; set; }

    }
}
