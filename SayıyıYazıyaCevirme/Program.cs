using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayıyıYazıyaCevirme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sonuc = 0, gsonuc = 0;
            short a;
            string s = "";
            string[] Birler = { "Bir", "İki", "Üç", "Dört", "Beş", "Altı", "Yedi", "Sekiz", "Dokuz" };
            string[] Onlar = { "On", "Yirmi", "Otuz", "Kırk", "Elli", "Altmış", "Yetmiş", "Seksen", "Doksan" };
            string[] Yüzler = { "Yüz", "İkiyüz", "Üçyüz", "Dörtyüz", "Beşyüz", "Altıyüz", "Yediyüz", "Sekizyüz", "Dokuzyüz" };
            Console.Write("Bir sayı giriniz: ");
            a = short.Parse(Console.ReadLine());
            if (a / 100 >= 1)
            {
                s = Yüzler[(a / 100) - 1];
            }
            sonuc = (a / 100);
            sonuc = sonuc * 100;
            gsonuc = a - sonuc;

            if (gsonuc / 10 >= 1)
            {
                s = s + Onlar[(gsonuc / 10) - 1];
            }
            if (gsonuc % 10 != 0)
            {
                s = s + Birler[(gsonuc % 10) - 1];
            }
            Console.WriteLine(s);
            Console.ReadKey(true);
        }
    }
}
