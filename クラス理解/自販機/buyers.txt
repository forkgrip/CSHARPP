using System;
using System.Collections.Generic;
using System.Text;
using VM;

namespace B
{
    class Buyers 
    {
        static void Main(string[] args)
        {

            VendingMachine Buyer = new VendingMachine();
            Buyer.BuyerMoney = 2000;
            Buyer.CheckCokeStock();
            Buyer.SarchkCokePrice();
            Buyer.Buy();
            Console.WriteLine("現在の購入者の所持金は、" + Buyer.BuyerMoney +"円です");
            Buyer.CheckCokeStock();
        }
    }
}