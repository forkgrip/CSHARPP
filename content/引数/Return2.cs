using System;

namespace first
{
    class Program
    {
        static int money = 300;

        static void Main(string[] args)
        {
            Console.WriteLine("所持金" + money + "円");
            Console.WriteLine("水(100円)か茶(200円)");
            Console.ReadLine();
            string choseDrink = Console.ReadLine();
            string drink1 = "水";
            string drink2 = "茶";

            if (drink1 == choseDrink)
            {
                VendingMachine(1, ref money, 100);
            }
            else if (drink2 == choseDrink)
            {
                VendingMachine(2, ref money, 200);
            }
            else
            {
                Console.WriteLine("水か茶を選んでください");
            }

            Console.WriteLine("残りの所持金: " + money + "円");
        }

        static void VendingMachine(int chosen, ref int usedMoney, int VMmoney)
        {
            if (chosen == 1 && usedMoney >= 100)
            {
                usedMoney -= 100;
                Console.WriteLine("自動販売機に" + VMmoney + "円支払われました。");
            }
            else if (chosen == 2 && usedMoney >= 200)
            {
                usedMoney -= 200;
                Console.WriteLine("自動販売機に" + VMmoney + "円支払われました。");
            }
            else
            {
                Console.WriteLine("所持金が足りません");
            }
        }
    }
}