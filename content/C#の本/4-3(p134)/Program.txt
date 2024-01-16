using System;

namespace Smaple
{
    class Program
    {
        static void Main(string[] args)
        {
            Plyer plyer = new Plyer("AAAA", -999999);
            
            int hp = plyer.GetHp();

            plyer.SetHp(hp);

            Console.WriteLine(hp);
        }
    }
}