using System;
using third_store;

namespace third_buy
{
    //Buyerクラスを作成、購入者の所持金などのデータを入力
    class Buyer
    {
        //購入者の所持金を5000円にする
        public int Buyer_Money = 5000;
    }
    //Byuingクラスを作成、買う時の処理を入力
    class Buying
    {
        static void Main(string[] args)
        {   
            
            Console.WriteLine("お店へようこそ");

            Console.WriteLine("どのお店に行きたいですか？");
            //どのお店に行きたいかを選ばせる
            Console.WriteLine("1(お店ショップ) 2(お店)");
            //ユーザーが入力した値をstringから
            string chose_shop_srt = Console.ReadLine();
            //intへ
            int chose_shop = int.Parse(chose_shop_srt);
            //1を選んだ時の処理
            if (chose_shop == 1)
            {
                //お店ショップの参照（お店ショップへの処理につなげるため）
                Store_StoreShop SaleFromStoreShop = new Store_StoreShop();
                //お店ショップの処理を参照（簡単に言うと、お店ショップの取引を開始）
                SaleFromStoreShop.sale_stuff();
            }
            
        }
    }

}