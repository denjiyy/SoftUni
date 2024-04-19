using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_and_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < n; i++)
            {
                Advertisement ad = new Advertisement();
                Console.WriteLine(ad.GenerateRandomMessage());
            }

            Console.ReadLine();
        }
    }
}