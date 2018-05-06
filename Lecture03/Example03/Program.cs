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
            string mail = "abc@gmail.com";
            //找出@是在第幾號
            //Console.WriteLine(mail.IndexOf("@"));
            int atPosition = mail.IndexOf("@");
            int dotPosiition = mail.IndexOf(".");
            bool ismail = (atPosition > 0) &&
                (atPosition < dotPosiition) &&
                (dotPosiition < mail.Length - 2);
            Console.WriteLine("{0}是合法的mail嗎? {1}", mail, ismail);

            //int後面放? 表示可以是null
            //int? number = null;
            int number = ((800 * 600) - (10 * 10)) / (100 * 100);
            Console.WriteLine(number);
        }
    }
}