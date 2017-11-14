using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrongTyped
{
    class Program
    {
        static void Main(string[] args)
        {
            //強類型，無法編譯成功
                int x = 100;
                if(x=200)
                {
                    Console.WriteLine("It's OK!");
                }

            
        }
    }
}
