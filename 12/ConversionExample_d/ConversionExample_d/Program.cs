using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionExample_d
{
    class Program
    {
        static void Main(string[] args)
        {
            //位移操作符
            int x = -7;
            int y = x >> 2;
            string strX = Convert.ToString(x, 2).PadLeft(32, '0');
            string strY = Convert.ToString(y, 2).PadLeft(32, '0');
            Console.WriteLine(strX);
            Console.WriteLine(strY);
            //在沒有溢出的狀況下，2進制左移為*2，右移為/2
            Console.WriteLine(y);
            //規範:正數左移補0，負數右移補1


            //===============================

            //關係操作符
            int x2 = 5;
            double y2 = 4.0;
            var result = x2 > y2;
            Console.WriteLine(result.GetType().FullName);
            Console.WriteLine(result);

            char char1 = 'a';
            char char2 = 'A';

            ushort u1 = (ushort)char1;
            ushort u2 = (ushort)char2;

            Console.WriteLine(u1);          //97
            Console.WriteLine(u2);          //65
            var result_b = char1 > char2;
            Console.WriteLine(result_b);        //ture

            string str1 = "Abc";
            string str2 = "abc";
            Console.WriteLine(str1==str2);      //False

            //將值都轉為小寫
            Console.WriteLine(str1.ToLower()==str2.ToLower());          //Ture

           
        }
    }
}
