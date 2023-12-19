using System;
using System.Collections.Generic;
using System.Text;

namespace SampleRPG
{

    class Katana
    {

    //メンバ変数（その１）
        public int baseAttack;

    //メンバ変数（その２）
        public string weaponName;

    //メンバメソッド
        public void Skill_1 ()
        {
            this.baseAttack += 10;
            Console.WriteLine("現在の攻撃力" + this.baseAttack);
        }

        //コンストラクタ
        public Katana()
        {
            this.weaponName = "刀の名称";
            this.baseAttack = 20;
        }


    }
}