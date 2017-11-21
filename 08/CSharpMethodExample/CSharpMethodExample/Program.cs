using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMethodExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            double result = Calculator.GetConeVolume(3.0, 4.0);
            Console.WriteLine(result);
        }
    }

    class Calculator
    {
        //https://imgur.com/WLZzA17
        //https://imgur.com/xCgzRFh
        //https://imgur.com/S6SaoGU
        public static double GetCircleArea(double r)
        {
            return Math.PI * r * r;
        }
        public static double GetCylinderValume(double r, double h)
        {
            return GetCircleArea(r)* h;
        }
        public static double GetConeVolume(double r, double h)
        {
            return GetCylinderValume(r,h) / 3;
        }
    }
}
