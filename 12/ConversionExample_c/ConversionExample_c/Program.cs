using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionExample_c
{
    class Program
    {
        static void Main(string[] args)
        {

            /* //var x = 3 * 4;
             //Console.WriteLine(x.GetType().FullName);
             //Console.WriteLine(x);
             //結果https://imgur.com/CtQrkIE */

            /*var x = 3.0 * 4.0;
            Console.WriteLine();
            Console.WriteLine(x.GetType().FullName);
            Console.WriteLine(x);
            //結果https://imgur.com/9LF2X5X*/

            //============數值提升============
            /*var x = 3.0 * 4;
            Console.WriteLine(x.GetType().FullName);
            Console.WriteLine(x);
            //結果https://imgur.com/bBugPYh，整數*double 仍然是double*/

           /* //隱式類型轉換不會丟失精度
            int x = 100;
            double y = x;
            Console.WriteLine(y);*/

           /* //整數類型的除法
            int x = 5;
            int y = 4;
            int z = x / y;
            Console.WriteLine(z);           //1
            //被除數不能為0，否則會錯誤*/

            /*//============除法================
            double x = 5.0;
            double y = 4.0;
            double z = x / y;
            Console.WriteLine(z);           //1.25
            //浮點數被除數可除0

            double a = double.PositiveInfinity;//正無窮大
            double b = double.NegativeInfinity;//負無窮大
            double c = a / b;
            Console.WriteLine(c);           //非數值
            //除數表https://imgur.com/sVy4UgT

            double x1 = (double)5 / 4;        //(double)優先及高於"/"，造成數值提升避免失去精度
            Console.WriteLine(x1);              //1.25

            double x2 = (double)(5 / 4);
            Console.WriteLine(x2);              //1
            //==================================*/

            //取餘數表https://imgur.com/ZKou02l

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i%10);    //0,1,2,3,4,5.....9，對10取於
            }

            double x = 3.5;
            double y = 3;
            Console.WriteLine(x%y);         //0.5


            string s1 = "123";
            string s2 = "abc";
            string s3 = s1 + s2;
            Console.WriteLine(s3);      //123abc
        }
    }
}
