using System;

namespace _180509_Core_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen isminizi giriniz");

            var isim = Console.ReadLine();

            Console.WriteLine($"Merhaba {isim}");

            Console.ReadKey();
        }
    }
}
