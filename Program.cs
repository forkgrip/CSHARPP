using System;
using System.Reflection.Metadata;

namespace SampleRPG
{

    class Program
    {

        static void Main (string[] args)
        {



            //Player1インスタンス作成、値代入
            Player player1 = new Player();
            Console.WriteLine(player1.name + "の体力は" + player1.hp);

        }

    }

}