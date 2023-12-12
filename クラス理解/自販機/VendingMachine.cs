using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VM
{
    class VendingMachine
    {

        public int cokeStock;

        public int cokePrice;

        public int vendingMachineMoney;

        public int BuyerMoney;

        public VendingMachine()
        {
            this.cokeStock = 10;
            this.cokePrice = 140;
            this.vendingMachineMoney = 0;
            this.BuyerMoney = 0;
        }

        public void CheckCokeStock()
        {
            Console.WriteLine("現在のコーラの在庫は、" + this.cokeStock + "コです");
        }

        public void SarchkCokePrice()
        {
            Console.WriteLine("コーラの値段は、" + this.cokePrice + "円です");
        }

        public void Buy()
        {
            this.cokeStock -= 1;
            this.BuyerMoney -= 140;
            this.vendingMachineMoney +=this.cokePrice;
            Console.WriteLine("コーラのご購入ありがとうございます");
        }

    }



}