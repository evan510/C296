using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture06
{
    internal class 寶可夢
    {
        public string 名字;
        public int 編號;
        private int iv;

        public 寶可夢(int 編號, string 名字)
        {
            Random random = new Random();
            this.iv = random.Next(1000);
            this.編號 = 編號;
            this.名字 = 名字;
        }
    }
}