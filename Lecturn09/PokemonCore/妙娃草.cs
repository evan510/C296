using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonCore
{
    public class 妙娃草 : 妙娃種子
    {
        public 妙娃草()
        {
            this.名字 = "妙娃草";
            this.現在血量 = 40;
            this.完整血量 = this.現在血量;
            this.編號 = 2;

            Random random = new Random();
            int number = random.Next(1, 101);
            if (number >= 50)
                this.大絕 = "強的鞭打";
        }

        public override void 攻擊(寶可夢 另一隻寶可寶)
        {
            另一隻寶可寶.現在血量 -= 5;

            base.攻擊(另一隻寶可寶);
        }
    }
}