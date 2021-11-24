using System;

namespace ödev2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 2 ) kullanıcında vize ve final notları istenecek. alınan vize ve finalden ortalama hesaplanacak.
                 Vizenin 0.4'ü finalin 0.6'sı.ve ortalması 100 ile 80 arasında ise AA,80 ve 70 arasında ise BA 
                 diğer değer aralıklarını belirleyerek ekrana harf notunu gösteren mesajı veren prog. yazınız..*/

            Console.WriteLine("lütfen vize notunuzu giriniz.");
            int vizenotu = int.Parse(Console.ReadLine());

            Console.WriteLine("lütfen final notunuzu giriniz.");
            int finalnotu = int.Parse(Console.ReadLine());


            int sonuc=(((vizenotu*40)/100)+((finalnotu*60)/100));

            if (sonuc < 100 && sonuc > 80)
            {
                Console.WriteLine("not ortalamanız AA'dır");
            }
            else if (sonuc < 80 && sonuc > 70)
            {
                Console.WriteLine("not ortalamanız BA'dır.");
            }
            else if (sonuc < 70 && sonuc > 50)
            {
                Console.WriteLine("not ortalamanız BB'dir.");

            }
            else if (sonuc < 50 && sonuc > 30)
            {
                Console.WriteLine("not ortalamanız CC'dir");
            }
            else if (sonuc < 30 && sonuc > 10) 
            {
                Console.WriteLine("not ortalamanız DD'dir.");
            }

            else
            {
                Console.WriteLine("not ortalamanız FF'dir.");

            }

            Console.ReadKey();
        }
    }
}
