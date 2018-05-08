using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //int[] numbers = new int[10];
            //Random random = new Random();

            ////TODO 產生亂數，不能有重覆的數字
            ////TODO 產生亂數、挑4個不同的數字
            //for (int index = 0; index < numbers.Length; index++)
            //{
            //    numbers[index] = random.Next(1, 11);
            //    Console.WriteLine(numbers[index]);
            //}

            int[] numbers = new int[9];
            Random random = new Random();
            int total = 0;

            for (int index = 0; index < numbers.Length; index++)
            {
                numbers[index] = random.Next(1, 11);
                total += numbers[index];
                Console.WriteLine(numbers[index]);
            }
            Console.WriteLine(total);

            //int total = 0;

            //for (int next = 1; next < 1001; next += 2)
            //{
            //    total = total + next;
            //    Console.WriteLine(total);
            //}
        }
    }
}