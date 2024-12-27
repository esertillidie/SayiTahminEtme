using System;

namespace SayiTahminEtmece
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Sayı Tahmin Etmece";
            Random rnd = new Random();
            int hak = 5; int sayi = 0; int tutulansayi = 0;
            Console.WriteLine("Sayı Tahmin Etme Oyununa Hoşgeldin");
            Console.WriteLine("1-20 arasında bir sayı tutucam ve bilmeye çalışıcaksın");
            Console.WriteLine("Coded By E5ERAURA");
            sayi = rnd.Next(1, 20);
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Bir Tahmini Sayı Gir:");
                tutulansayi = int.Parse(Console.ReadLine());

                if (tutulansayi == sayi)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Tebrikler Sayıyı Doğru Bildin");
                    break;
                }
                else if (tutulansayi != sayi)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Sayıyı Bilemedin");
                    hak--;
                    Console.WriteLine(hak + " " + "hakkın kaldı");
                }

                if (hak == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine("Tüm Hakların Bitti");
                    break;
                }
            }

            Console.Read();
        }
    }
}