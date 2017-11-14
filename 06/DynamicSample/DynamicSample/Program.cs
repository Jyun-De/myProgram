using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicSample
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic myVar = 100;
            Console.WriteLine(myVar);
            myVar = "Mr.OK";
            Console.WriteLine(myVar);
            //C#模仿弱類型
            //用於底層程式
        }
    }
}
