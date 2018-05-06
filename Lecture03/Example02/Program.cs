using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //取值運算
            string message = "Hello World";
            Console.Write("請選擇你要的字元位置");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine("message的第{0}個字元是{1}", index, message[index]);
        }
    }
}