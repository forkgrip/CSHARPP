using System;
using System.Collections.Generic;
using System.Text;

namespace SampleRPG
{

    class Attack
    {
        static void Main(string[] args)
        {
            Katana PlayerKatana1 = new Katana();
            PlayerKatana1.Skill_1();
            Console.WriteLine(PlayerKatana1.weaponName);
            PlayerKatana1.weaponName = "村様";
            Console.WriteLine(PlayerKatana1.weaponName);
            Console.WriteLine(PlayerKatana1.baseAttack);
        }
    }

}