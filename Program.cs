using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metot
{
    class Program
    {


        public static int Topla(float s1, float s2)
        {
            return (int)(s1 + s2); 
        }
        public static void Yaz(string mesaj)
        {
            Console.WriteLine("Hoşgeldin UZEM !"  + mesaj);
         }

        public static int ardisikToplam(int n)
        {
            if (n == 0) return 0;
            return n + ardisikToplam(n - 1);
         }
        public static int fakt(int n)
        {
            if (n == 1) return 1;
            return n * fakt(n - 1);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Topla(5,6));
            Yaz(" 2019");

            Console.WriteLine("Bir sayısal değer giriniz : ");
            int s = Int32.Parse(Console.ReadLine());
            Console.WriteLine(s + " sayısının 0 dan toplamı : " + ardisikToplam(s));

         
            Console.WriteLine(s + " sayısının fakoriyeli : " + fakt(s));

        }
    }
}
