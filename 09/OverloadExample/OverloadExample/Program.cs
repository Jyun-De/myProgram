using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://imgur.com/j9G9QIc
namespace OverloadExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //方法從載
            Console.WriteLine("Hello");
            Console.WriteLine(100);
            Console.WriteLine(200L);
            Console.WriteLine(300D);
            Console.WriteLine();


            //重載決策
            Calculator c = new Calculator();
            int x = c.Add(100, 100);
            Console.WriteLine(x);

            double y = c.Add(100D, 200D);
            Console.WriteLine(y);
        }
    }

    class Calculator
    {
        //方法簽名
        public int Add(int a,int b)
        {
            return a + b;
        }

        public int Add(int a,int b ,int c)
        {
            return a + b + c;
        }

        public double Add(double x, double y)//方法簽名不能是(int x, int y)
        {
            return x + y;
        }

        //類型行參
        public int Add<T>(int a, int b )
        {
            T t;//....
            return a + b;
        }

        //參數的種類也參與構成方法的簽名
        //ref傳引用
        public int Add(ref int a,int b)
        {
            return a + b;
        }

        public int Add(int a, out int b)//輸出參數
        {
            b = 100;
            return a + b;
        }


    }


}
