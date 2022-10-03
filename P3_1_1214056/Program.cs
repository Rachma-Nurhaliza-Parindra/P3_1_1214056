using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_1_1214056
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ANAK AYAM TURUN ");
            var yayam1 = int.Parse(Console.ReadLine());
            var yayam2 = yayam1 - 1;
            Console.WriteLine("");

            if (yayam1 >= 1 && yayam1 <= 10)
            {
                for (int i = yayam1; i > 0; i--)
                {
                    if (i > 1)
                    {
                        var j = i - 1;
                        Console.WriteLine("Anak ayam turunlah " + i + " ,Mati satu tinggalah " + j);
                    }
                    else { Console.WriteLine("Anak ayam turunlah 1, mati satu tinggalah induknya"); }
                }
            }
        }
    }
}

