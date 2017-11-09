using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            int x  =c.Add(2 , 3);
            Console.WriteLine(x);

            string str = c.Today();
            Console.WriteLine(str);

            c.PrintSum(4, 6);

            //====================

            Calculator_b  c2 =new Calculator_b();
            c2.PrintXto1_a(10);
            c2.PrintXto1_b(10);
        }

        class Calculator
        {
             public int Add(int a,int b)//有數據輸入輸出
            {
                 int result =a+b;
                 return result;
            }

            public string Today()//無數據輸入有輸出
             {
                 int day = DateTime.Now.Day;
                 return day.ToString();
             }

            public void PrintSum(int a ,int b)//有數據輸入無輸出
            {
                int result = a + b;
                Console.WriteLine(result);
            }

      
        }
        class Calculator_b
        {
            //循環
            public void PrintXto1_a(int x)
            {
                for (int i = x; i > 0; i--)
                {
                    Console.WriteLine(i);
                }
            }

            public void PrintXto1_b(int x)
            {
                //遞規
                if (x == 1)
                {
                    Console.WriteLine(x);
                }
                else
                {
                    Console.WriteLine(x);
                    PrintXto1_b(x - 1);
                }
            }

        }
    }
}





