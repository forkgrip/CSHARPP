using System;
using System.Security.Cryptography.X509Certificates;

namespace first
{
    class Program
    {
        static void Main(string[] args)
        {
            Method(23);
        }
        
        //methodメソッドを作り、引数を宣言
        static void Method(int num)
        {   
            int num2;
            Console.WriteLine(num);
            num2 = 200;
            return num2();
        }
    }
}