using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionExample_e
{
    class Program
    {
        static void Main(string[] args)
        {

            Teacher t = new Teacher();
            var result = t is Teacher;
            Console.WriteLine(result.GetType().FullName);       //bool
            Console.WriteLine(result);                      //true


            //空值不是老師
            t = null;
            result = t is Teacher;            
            Console.WriteLine(result);           //F

            //老師是人
            t = new Teacher();
            result = t is Human;
            Console.WriteLine(result);          //T

            //老師是動物
            result = t is Animal;
            Console.WriteLine(result);          //T

            Car car = new Car();
            Console.WriteLine(car is Animal);           //F
            Console.WriteLine(car is object);           //T

            //人不一定是老師
            Human h = new Human();
            result = h is Teacher;
            Console.WriteLine(result);              //F


            object o = new Teacher();
            if(o is Teacher)
            {
                t = (Teacher)o;
                t.Teach();
            }

            //o像Teacher 一樣
            t = o as Teacher;
            if(t!= null)
            {
                t.Teach();
            }
        }
    }


    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eatting...");
        }
    }

    class Human : Animal
    {
        public void Think()
        {
            Console.WriteLine("Who I am?");
        }
    }
    class Teacher : Human
    {
        public void Teach()
        {
            Console.WriteLine("1+1=2");
        }
    }
    class Car
    {
        public void Run()
        {
            Console.WriteLine("Running...");
        }
    }

    
}
