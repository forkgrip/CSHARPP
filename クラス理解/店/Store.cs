using System;
//別のcsファイルから、参照をするためにusing 名前空間の名前　を書いた
using third_buy;

namespace third_store
{
    //  お店ショップクラス作成
    class Store_StoreShop
    {
        public Buyer storebuy= new Buyer(); 
        //ここでインスタンスを作ろうとすると、値参照とかをつかうことになる。めんどい
        //public void Instan()
        //{
          //Buyer StoreBuy = new Buyer();
        //} 

        
        public void sale_stuff()
        {
            //インスタンス作成（これにより、third_buyから変数とかを参照する）
            Buyer StoreBuy = new Buyer();

            //入店時のあいさつ
            Console.WriteLine("お店ショップへようこそ");
            //商品を選ばせる
            Console.WriteLine("商品を選んでください");

            Console.WriteLine("1:飲料水 2:麦茶");
            //コンソールリードラインを使って、ユーザーに1か2で商品を選んでもらう、その値を一旦stringで保持
            string choose_stuff_str = Console.ReadLine();
            //stringで保持したもの(10進数)をint型に変換
            int chose_stuff = int.Parse(choose_stuff_str);
            //やっと、ユーザーが選んだものをプログラムが認識
            //1を選んだ時の処理
            if (chose_stuff == 1)
            {
                Console.WriteLine("飲料水を購入します。");
                //購入者の所持金から最大で何個買えるか計算して表示（BuyerクラスのBuyer_Money変数を参照）
                Console.WriteLine("現在の所持金は、"+ StoreBuy.Buyer_Money +"円なので、最大で" + (StoreBuy.Buyer_Money/this.stuff_1_price) +"コ買えます。" );
                //何本買うか、ユーザーが希望する数をstring型で数値を入力させ、
                Console.WriteLine("何本買いますか？");
                //何本買うか、ユーザーが希望する数をstring型で数値を入力させ、
                string choose_stuff_num_str = Console.ReadLine();
                //int型にする
                int chose_stuff_num = int.Parse(choose_stuff_num_str);
                //希望した個数を表示し、
                Console.WriteLine("合計で、" + (chose_stuff_num * this.stuff_1_price) + "円です" );
                //おつりを表示する
                Console.WriteLine("おつりは、" + (StoreBuy.Buyer_Money - (chose_stuff_num*this.stuff_1_price)) + "円です");
                //購入者の現在の所持金を入力(↑では、"StoreBuy.Buyer_Money"の値を変化させないから)
                StoreBuy.Buyer_Money -= (chose_stuff_num*this.stuff_1_price);

                Console.WriteLine("またのご利用お待ちしてます");
            }
        }
        //各商品とかの変数（状況は、工事中）
        public int store1Gain = 0;

        public string stuff_1 = "飲料水";

        public int stuff_1_price = 100;

        public int stuff_1_stock = 13;

        public string stuff_2 = "麦茶";

        public int stuff_2_price = 105;

        public int stuff_2_stock = 8;
        
    }
    
    //お店クラス作成（ここも工事中）
    class Store_OMISE
    {
        public string storeName2 = "お店";

        public int store2Gain = 0;

        public string stuff_1 = "炭酸水";

        public int stuff_1_price = 110;

        public int stuff_1_stock = 17;

        public string stuff_2 = "ソーダ";

        public int stuff_2_price = 1400;

        public int stuff_2_stock = 2;

        
    }

    

    
}