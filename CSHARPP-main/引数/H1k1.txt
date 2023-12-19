//staticで定義してるのは、Mainプログラムがstatic固定だから(これ以降staticを使っていく。)
using System;

namespace hikisuu101
{
    class Program
    {
        //Methodの参照
        static void Main(string[] args)
        {
            Method();
        }
        //Methodメソッドの内容
        static public void Method()
        {   
            Console.WriteLine(num);
        }
        //staticでint型で、num変数として定義
        static public int num = 20;
    }
}