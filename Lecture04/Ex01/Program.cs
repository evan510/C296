using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    internal class Program
    {
        private int[] numbers = new int[9];
        private Random random = new Random();
        private int total = 0;

            for (int index = 0; index<numbers.Length; index++)
            {
                numbers[index] = random.Next(1, 11);
                total += numbers[index];
                Console.WriteLine(numbers[index]);
            }

    Console.WriteLine(total);
    }
}