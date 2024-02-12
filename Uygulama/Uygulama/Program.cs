using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            // SAYI BULMA OYUNU
            int sayi = 0, tahmin = 0, min = 0, max = 100, sayac = 0;
            Random Rnd = new Random();
            sayi = Convert.ToInt32(Rnd.Next(0, 100));
            Console.Write("0 ile 100 arası bir değer girin: ");
            do
            {
                sayac++;
                tahmin = Convert.ToByte(Console.ReadLine());
                if (tahmin > sayi)
                    max = tahmin;
                else
                    min = tahmin;
                Console.WriteLine("{0} - {1} arasında sayi gir: ", min, max);
            }
            while (sayi != tahmin);
            Console.WriteLine("TEBRİKLER SAYI {0} , {1} .tahminde bildin.", sayi, sayac);
            Console.ReadLine();
        }
    }
}
