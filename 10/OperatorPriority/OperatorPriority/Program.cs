using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorPriority
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 100;
            int y = 200;
            int z = 300;
            x += y += z;
            //附值操作符由右向左運算

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

        }
    }
}
