using System;

namespace Exercises2
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "c#";
            string kurs2 = "java";
            string kurs3 = "python";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);

            //array-dizi
            string[] kurslar = new string[] { "c#","java","python" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("sayfa sonu-footer");
            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
