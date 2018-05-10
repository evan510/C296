using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // 首先我先宣告兩個陣列
            // 0到21總共有22個元素，所以宣告陣列大小為22

            int[] Num = new int[22];
            int[] RndArr = new int[22];

            Random rnd = new Random();
            int temp;

            // 宣告亂數物件 rnd
            // 宣告一個 temp 變數

            for (int k = 0; k <= 21; k++)
            {
                Num[k] = k;
            }

            // 將 Num 陣列設值 就是依序為0到21
            // 重點來了 下一段

            for (int j = 0, x = 22; j <= 21; j++, x--)
            {
                temp = rnd.Next(x);
                RndArr[j] = Num[temp];
                Num[temp] = Num[x - 1];
            }
            Console.Write(RndArr);
        }
    }
}