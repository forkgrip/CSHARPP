using System;
using System.Text;//UTF8使うため


namespace first
{
    static class Program
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
            string Saving = "テキスト保存機";
            //この関数作る
            string ShowSave = "保存テキスト閲覧";
            string exit = "出てく";   
            //ユーザー入力


            //選択を繰り返す動作にする。while(ture)
            while(true)
                {
                    Console.WriteLine("所持金" + money + "円");
                    Console.WriteLine("水(100円)か茶(200円)か(出てく)か(テキスト保存機)");
                    string ChoseTask = Console.ReadLine();
                    //水が選ばれたとき
                    if (ChoseTask == drink1)
                    {
                        int usedmoney =VendingMachine(1, ref money);
                        ChoseTask = "null";
                    }
                    //茶が選ばれたとき
                    else if (ChoseTask == drink2)
                    {
                        int usedmoney = VendingMachine(2, ref money);
                        Console.WriteLine(money + "円残っています");
                        ChoseTask = "null";
                    }
                    //テキスト保存機が選ばれたととき
                    else if (ChoseTask == Saving)
                    {
                        //文字列を読み取り、SentenceSaveメソッドでその文字列を送り、そのメソッドで文字列を保保存する
                        Console.WriteLine("では、テキストを入力してください");
                        string InputText = Console.ReadLine();
                        string savedtext = SentenceSave(ref InputText);
                        Console.WriteLine("文字列「" + savedtext + "」を保存しました。");
                    }
                    /*テキスト保存したものを見れるようにする
                    else if (ChoseTask == ShowSave)
                    {
                        
                    }
                    */
                    //break処理で選ぶループを抜ける
                    else if (ChoseTask == exit)
                    {
                    Console.WriteLine("自販機？から離れました");
                    break;
                    }

                    //なんにも入力されてないとき、continueで、もっかいループの最初に行く
                    else if (ChoseTask == null)
                    {
                    Console.WriteLine("括弧内を入力してください。");
                    continue;
                    }
                    //ユーザーが選択したものをnullにするので、exitをしない限り、この選択画面を実行し続ける→これないと、一回選択したあと、無限ループになる。
                    if (ChoseTask != null)
                    {
                        ChoseTask = null;
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

        //テキストを保存するメソッド(渡された引数を保存するだけ)
        static string SentenceSave (ref String KeepSentence)
        {
            string SaveText1 = KeepSentence;
            return KeepSentence;
        }
    }
}