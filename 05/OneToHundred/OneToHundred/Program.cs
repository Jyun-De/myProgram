using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToHundred
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            int result = c.SumFrom1ToX_a(100);
            Console.WriteLine(result);

            result = c.SumFrom1ToX_b(100);
            Console.WriteLine(result);

            result = c.SumFrom1ToX_c(100);
            Console.WriteLine(result);
        }
    }

    class Calculator
    {
        public int SumFrom1ToX_a(int x )
        {
            //循環
            int result = 0;
            for (int i =1; i < x+1; i++)
            {
                result += i;
            }
            return result;
        }

        public int SumFrom1ToX_b(int x )
        {
            //遞規
            if(x==1)
            {
                return 1;
            }
            else
            {
                int result = x + SumFrom1ToX_b(x - 1);
                return result;
            }
        }


        public int SumFrom1ToX_c(int x )
        {
            //數學
            return (1 + x) * x / 2;
        }
    }

}
