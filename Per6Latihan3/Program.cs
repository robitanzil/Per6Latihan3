using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Per6Latihan3
{
    class Program
    {
        static void Main(string[] args)
        {

            // CREATE KAKAK
            Kakak k = new Kakak(10);
            k.UangJajan = 10000;

            // KAKAK KEDUA
            KakakKedua kk = new KakakKedua(20);
            kk.UangJajan = 10000;

            // CREATE ADEK
            Adek adek = new Adek();
            adek.UangJajan = 10000;


            Console.WriteLine("Uang jajan kakak {0}", k.UangJajan);
            Console.WriteLine("Uang jajan kakak kedua {0}", kk.UangJajan);
            Console.WriteLine("Uang jajan adek {0}", adek.UangJajan);

            Console.ReadLine();
        }
    }
}
