using System;
using System.Diagnostics.Tracing;
using System.Text;//UTF8使うため


namespace first
{
    static class Program
    {
        static int money = 300;

        static string SaveText;

        static string ChoseTask = "none";

        static void Main(string[] args)
        {
            //Console.ReadLine();では、ちっとも日本語を読み取らないので、入力されたものをUTF8で変換する
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            //ユーザー入力
            string drink1 = "水";
            string drink2 = "茶";
            string Saving = "テキスト保存機";
            string Showing = "保存テキスト閲覧";
            string exit = "出てく";

            //選択を繰り返す動作にする。while(ture)
            while(true)
                {
                    Console.WriteLine("所持金" + money + "円");
                    Console.WriteLine("水(100円)か茶(200円)か(出てく)か(テキスト保存機)か(保存テキスト閲覧)");
                    string ChoseTask = Console.ReadLine();
                    //水が選ばれたとき
                    if (ChoseTask == drink1)
                    {
                        VendingMachine(1, ref money);
                        Console.WriteLine(money + "円残っています");
                        RestTask();
                    }
                    //茶が選ばれたとき
                    else if (ChoseTask == drink2)
                    {
                        VendingMachine(2, ref money);
                        Console.WriteLine(money + "円残っています");
                        RestTask();
                    }
                    //テキスト保存機が選ばれたととき
                    else if (ChoseTask == Saving)
                    {
                        Console.WriteLine("では、テキストを入力してください");
                        SaveText = Console.ReadLine();
                        RestTask();
                    }
                    //テキスト閲覧が選ばれたととき
                    else if (ChoseTask == Showing)
                    {
                        //テキストが保存されてたら見せる
                        if(SaveText == null)
                        {
                            Console.WriteLine("保存したテキストがありません");
                        }
                        else
                        {
                        Console.WriteLine("保存したテキスト->" + SaveText);
                        }
                        RestTask();
                    }
                    
                    //break処理で”選ぶ”ループを抜ける
                    else if (ChoseTask == exit)
                    {
                        Console.WriteLine("自販機？から離れました");
                        break;
                    }
                    //なんにも入力されてないとき、continueで、もっかいループの最初に行く
                }
        }

        //if文には、全部の分けめにretrunを入れる必要がある。
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

        static void RestTask()
        {
            ChoseTask = "null";
        }
    }
}