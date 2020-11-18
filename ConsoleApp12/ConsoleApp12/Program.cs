using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Random slump = new Random();
            int datorTal = slump.Next(0, 101);
            int gissningar = 1;
            Console.WriteLine("Gissa ett tal mellan 1 och 100");
            int Tal = int.Parse(Console.ReadLine());

            while (Tal != datorTal)
            {

                if (Tal < datorTal)
                {
                    Console.WriteLine("Ditt tal är mindre än det slumpade talet, gissa igen!");
                    Tal = int.Parse(Console.ReadLine());
                    gissningar++;
                }

                else if (Tal > datorTal)
                {
                    Console.WriteLine("Ditt tal är större än det slumpade talet, gissa igen!");
                    Tal = int.Parse(Console.ReadLine());
                    gissningar++;
                }

            }
                Console.WriteLine("Du gissade rätt tal! Talet var " + datorTal + " Du behövde " + gissningar + " gissningar för att gissa rätt tal");
        }
    }
}
