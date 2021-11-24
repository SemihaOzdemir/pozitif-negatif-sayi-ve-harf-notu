using System;

namespace ödev1
{
    class Program
    {
        static void Main(string[] args)
        {

            //  1) kullanıcıdan tam sayı değer istenecek.sayı pozitifse sayı pozitif mesajı, negatifse negatif mesajı, 
            // 0 ise sayı 0'dır mesajı ekranda gösterilecek...

            Console.WriteLine("lütfen bir tam sayı değeri giriniz.");
            int sayi = int.Parse(Console.ReadLine());



            if (sayi > 0)
            {
                Console.WriteLine("girilen sayı pozitif değerdedir.");
            }

            else if (sayi < 0)
            {
                Console.WriteLine("girilen sayı negatif değerdedir.");
            }
            else 
            {
                Console.WriteLine("girdiğiniz sayı sıfırdır.lütfen tekrar deneyiniz.");
            }


            Console.ReadKey();
        }
    }
}
