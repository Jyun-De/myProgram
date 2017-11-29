using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsExample_b
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = int.MinValue;
            //int y = checked(-x);//溢出
            //Console.WriteLine(x);
            //Console.WriteLine(y);

            //====================
            //~按位取反
            int x = 12345678;
            int y = ~x;

            string xStr = Convert.ToString(x, 2).PadLeft(32, '0');//用0不足至32位元
            string yStr = Convert.ToString(y, 2).PadLeft(32, '0');
            Console.WriteLine(xStr);
            Console.WriteLine(yStr);

            int a = int.MinValue;
            int b = -a;
            Console.WriteLine(b);
            string aStr = Convert.ToString(a, 2).PadLeft(32, '0');
            Console.WriteLine(aStr);

            //==============================
            bool b1 = true;
            bool b2 = !b1;
            Console.WriteLine(b2);
            //=============================
            int c = 100;
            int d = ++c;//先做++再附值
            
            Console.WriteLine(c);
            Console.WriteLine(d);
           
        }
    }
}
