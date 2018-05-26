using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonCore
{
    public class 妙娃種子 : 寶可夢
    {
        public 妙娃種子()
        {
            this.名字 = "妙娃種子";
            this.現在血量 = 20;
            this.完整血量 = this.現在血量;
            this.編號 = 1;
            this.一般招 = "藤鞭";
            this.大絕 = "汙泥炸彈";
            //this.使用招式 = this.一般招;
        }

        public override void 攻擊(寶可夢 另一隻寶可寶)
        {
            base.攻擊(另一隻寶可寶);
            另一隻寶可寶.現在血量 -= 10;
            base.列印攻擊訊息(另一隻寶可寶);
        }
    }
}