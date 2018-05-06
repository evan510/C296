using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = new int[]
            {
                 1,2,3,4,5,6,7
            };
            Console.WriteLine("陣列numbers的長度是{0}", numbers.Length);
            Console.WriteLine("numbers[3]的長度是{0}", numbers[3]);
        }
    }
}