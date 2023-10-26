using System;
using System.Reflection.Metadata;

namespace SampleRPG
{

    class Program
    {

        static void Main (string[] args)
        {
            //Player1インスタンス作成、値代入
            Player player1 = new Player("たかし",100);

            //----------------

            int hp = player1.Gethp(); //現在の体力を取得（0を取得）

            int newHP = hp -2000;     //取得した値から -2000 する
            
            player1.Setup(newHP);     //newHPの値をplyaer1に入れる

            //----------------

            string newname = player1.Getname();

            string newNAME = "かめ"; //文字列を代入して、

            player1.Setname(newNAME);
            

            Console.WriteLine("体力は" + player1.Gethp() + "名前は" + player1.Getname());

        }

    }

}