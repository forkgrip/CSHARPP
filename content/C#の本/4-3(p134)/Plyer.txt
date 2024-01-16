using System;

namespace Smaple
{
    class Plyer
    {
        //とりあえず定義
        private string name;
        private int hp;
        //コンストラクタ（初期値決め）
        public Plyer (string name, int hp)
        {
            this.name = name;
            this.hp = hp;
        }
        //Hpの値の設定(0未満にならないようにする)
        //Hpを再設定したい場合は、インスタンス.SetHp(設定する変数名)
        public void SetHp(int hp)
        {
            if (this.hp < 0)
            {
                this.hp = 0;
            }
        }
        
        public int GetHp()
        {
            return this.hp;
        }

        public void attck()
        {
            Console.WriteLine(this.name +"は攻撃した");
        }

        public void Defense()
        {
            Console.WriteLine(this.name +"は防御した");
        }

    }

}

