using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//new操作符:幫助我們在內存當中創造實例，並且調用他的實例構造器
//new 功能強大不能過渡使用，在大型程序中避免高耦合"依賴注入"
namespace OperatorsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //C#強類型語言，無法更改類型
            //var x = "100";
            //x = 100;
            //Console.WriteLine(x.GetType().Name);

            //Form myForm = new Form() { Text ="Hello" ,FormBorderStyle = FormBorderStyle.SizableToolWindow};//也可調用初始化器
            //myForm.ShowDialog();

            new Form() { Text ="Hello"}.ShowDialog();

            //語法糖衣不用使用new
            int x = 100;
            string name = "Tim";
            int[] myArray = {1,2,3,4};

            Form myForm = new Form() { Text = "Hello" };


            //==============================
            //var的強大用法
            var person= new { Name = "Mr.OK", Age = 34 };
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
            Console.WriteLine(person.GetType().Name);

            //=================================
            //new 關鍵字



            //繼承
            Student stu = new Student();
            stu.Report();
            CsStudent csStu =new CsStudent();
            csStu.Report();


            //unchecked
            
            uint a = uint.MaxValue;
            Console.WriteLine(a);
            string binStr = Convert.ToString(a, 2);
            Console.WriteLine(binStr);

            //uint b = a + 1;
            //Console.WriteLine(b);
            ////溢出
            checked
            {
                try
                {
                    uint b = a + 1;
                    Console.WriteLine(b);
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("溢出!");
                }
            }
            
            //===========================
            //sizeof
            unsafe
            {
                //取得Student_b的內存大小
                int c = sizeof(Student_b);
                Console.WriteLine(c);
            }

            //===========================
            //->
            unsafe
            {
                Student_c stu2;
                stu2.ID = 1;
                stu2.Score = 99;
                Student_c* pStu = &stu2;
                pStu->Score = 100;
                (*pStu).Score = 1000;
                //指針優先權比"."低，故要先括號
                Console.WriteLine(stu2.Score);
            }
        }

        //===========================
        //sizeof
        struct Student_b
        {
            int ID;
            long Score;
        }

        //====================
        //指針
        struct Student_c
        {
            public int ID;
            public long Score;
        }

    }


    class Student
    {
        public void Report()
        {
            Console.WriteLine("I'm a student.");
        }
    }
    class CsStudent:Student
    {
        //new  修飾符，隱藏主類的方法
        new public void Report()
        {
            Console.WriteLine("I'm CS student");
        }
    }
}
