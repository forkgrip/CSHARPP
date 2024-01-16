using System;
using System.Text;//UTF8使うため

namespace first
{
    class Program
    {
        static int money = 300;

        static void Main(string[] args)
        {
            //Console.ReadLine();では、ちっとも日本語を読み取らないので、入力されたものをUTF8で変換する
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            //売っているものを入力
            string drink1 = "水";
            string drink2 = "茶";
            string exit = "出てく";   
            //ユーザー入力
            Console.WriteLine("所持金" + money + "円");
            Console.WriteLine("水(100円)か茶(200円)か(出てく)か");
            string choseDrink = Console.ReadLine();
            //whileは、nullのときに、もう一回選択できるようにする（continueにより）
            while(true)
                {
                    //水が選ばれたとき
                    if (drink1 == choseDrink)
                    {
                    int usedmoney =VendingMachine(1, ref money);
                    break;
                    }
                    //茶が選ばれたとき
                    else if (drink2 == choseDrink)
                    {
                    int usedmoney = VendingMachine(2, ref money);
                    Console.WriteLine(money + "円残っています");
                    break;
                    }
                    //break処理で選ぶループを抜ける
                    else if (exit == choseDrink)
                    {
                    Console.WriteLine("自販機から離れました");
                    break;
                    }
                    //なんにも入力されてないとき、continueで、もっかいループの最初に行く
                    else if (choseDrink == null)
                    {
                    Console.WriteLine("水か茶を入力してください。");
                    continue;
                    } 
                }
            Console.WriteLine("残りの所持金: " + money + "円");
        }
        //if文には、全部の分けめにretrunを入れる必要がある。
        //
        static int VendingMachine(int chosed, ref int useMoney)
        {
            //１が選ばれたときの処理
            if (chosed == 1 && useMoney >= 100)
            {
                useMoney -= 100;
                int VMmoney = 100; 
                Console.WriteLine("自動販売機に" + VMmoney + "円支払われました。");
                return useMoney;
                
            }
            //２が選ばれたときの処理
            else if (chosed == 2 && useMoney >= 200)
            {
                useMoney -= 200;
                int VMmoney = 200;
                Console.WriteLine("自動販売機に" + VMmoney + "円支払われました。");
                return useMoney;
            }
            //金ないとき
            else
            {
                Console.WriteLine("所持金が足りません");
                return useMoney;
            }
        }
    }
}