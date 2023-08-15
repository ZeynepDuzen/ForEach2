using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEach2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // *** Diziye disaridan eleman girisi ***

            //string[] sehirler = new string[5];
            //for (int i = 0; i < sehirler.Length; i++)
            //{
            //    Console.WriteLine("Sehir ismi giriniz : ");
            //    sehirler[i] = Console.ReadLine();
            //}
            //for (int i = 0; i < sehirler.Length; i++)
            //{
            //    Console.WriteLine(sehirler[i]);
            //}

            int[] sayilar = new int[4];
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine("Lutfen sayi giriniz : ");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Sayilar dizisinin " + (i+1) +  ".elemani " + sayilar[i]);
            }



            Console.Read();
        }
    }
}
