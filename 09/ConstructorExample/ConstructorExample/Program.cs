using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

        //小技巧輸入ctor+Tab*2自動建構出構造器函式
        //返回值:把數據加工後傳回給調用者
        //構造器:不用返回值，只需把內存塊建構好

namespace ConstructorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student(2,"Mr.Okay");//調用構造器      
            Console.WriteLine(stu.ID);
            Console.WriteLine(stu.Name);
            Console.WriteLine("=================");
            Student stu2 = new Student();
            Console.WriteLine(stu2.ID);
            Console.WriteLine(stu2.Name);

        }
    }

    class Student
    {
        
        public Student()//給程式建構初始值
        {
            this.ID = 1;
            this.Name = "No name";
        }

        public Student(int initId,string initName)//強制要求附值
        {
            this.ID = initId;
            this.Name = initName;
        }
        public int ID;
        public string Name;
    }
}
