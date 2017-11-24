using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//F11   進入調用的函式裡
//F10   跳出函式Debug
// shift +F11   跑進方法裡

namespace CSharpMethodExampleDebug
{
    class Program
    {
        static void Main(string[] args)
        {            
            double result = Calculator.GetCylinderValume(100,100);                        
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
            return GetCircleArea(r) * h;
        }
        public static double GetConeVolume(double r, double h)
        {
            return GetCylinderValume(r, h) / 3;
        }
    }
}


