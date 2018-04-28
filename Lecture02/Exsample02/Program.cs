using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exsample02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("請輸入一個數定：");
            try
            {
                double number1 = double.Parse(Console.ReadLine());
                //string number2 = (4.12345678).ToString("#.##");
                Console.WriteLine("你輸入的是:{0}", number1);
            }
            catch
            {
                Console.WriteLine("輸入有問題唷");
            }
        }
    }
}