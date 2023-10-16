using System;
using System.Collections.Generic;
using System.Text;

namespace SampleRPG
{
    class Player
    {
        //プレイヤー情報
        public string name;

        public int hp;

        public Player()
        {
            this.name = "たかし";
            this.hp = 100;
        }




        //攻撃メソッド
        public void attack()
        {
            Console.WriteLine(this.name + "は攻撃した。");
        }
        //防御メソッド
        public void Defense()
        {
            Console.WriteLine(this.name + "は防御した。");
        }
        
    }
}