using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Median
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte čísla k výpočtu mediánu");
            List<int> list = new List<int>();
            while (true)
            {
                string vstupniCislo = Console.ReadLine();
                if (int.TryParse(vstupniCislo, out int cislo))
                {
                    list.Add(cislo);
                }
                else
                {
                    break;
                }
            }
            list.Sort();
            if (list.Count % 2 == 0)
            {
                int stredVpravo = list.Count / 2;
                int stredVlevo = list.Count / 2 - 1;
                double median = (list[stredVpravo] + list[stredVlevo]) / 2.0;
                Console.WriteLine("Váš medián je: {0}", median);
            }
            else
            {
                int stred = list.Count / 2;
                int median = list[stred];
                Console.WriteLine("Váš medián je: {0}", median);
            }
        }
    }
}
