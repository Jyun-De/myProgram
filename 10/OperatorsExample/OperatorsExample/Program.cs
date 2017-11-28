using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OperatorsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Form myForm = new Form();
            ////成員訪問操作符
            //myForm.Text = "Hello World!";
            //myForm.ShowDialog();

            //創建檔案
            //System.IO.File.Create("D:\\HelloWorld.txt");

            //==================================
            //方法調用操作符
            Calcuator c = new Calcuator();
            double x =  c.Add(3.0, 5.0);
            Console.WriteLine(x);

            c.PrintHello();
            //==================================
            //委託
            Action myAction = new Action(c.PrintHello);
            myAction();

            //==================================
            //元素訪問操作符
            int[] myIntArray = new int[]{1,2,3,4,5};//"{}"這為初始化器，非構造器
            Console.WriteLine(myIntArray[0]);
            Console.WriteLine(myIntArray[myIntArray.Length-1]);//永遠不會超過邊界

            Dictionary<string, Student> stuDic = new Dictionary<string, Student>();
            for (int i = 0; i < 100; i++)
            {
                Student stu = new Student();
                stu.Name = "s_" + i.ToString();
                stu.Score = 100+i;
                stuDic.Add(stu.Name, stu);
            }
            //"[]"放集合的索引，不一定為整數
            Student number6 = stuDic["s_6"];
            Console.WriteLine(number6.Score );

            //==================================
            //Metadata
            Type t = typeof(int);
            Console.WriteLine(t.Namespace);
            Console.WriteLine(t.FullName);
            Console.WriteLine(t.Name);
            int c2 = t.GetMethods().Length;
            foreach (var mi in t.GetMethods())
            {
                Console.WriteLine(mi.Name);
            }
            Console.WriteLine(c2);

            //========================
            //default
            int x2 = default(int);//結構體類型預設值為0
            Console.WriteLine(x2);

            Form myForm = default(Form);//類類型預設值為null
            Console.WriteLine(myForm==null);

            Level level = default(Level);//枚舉類型預設值為第一個
            //預設值要有0，否則邏輯上有問題
            Console.WriteLine(level);
            
        }
    }

    //方法調用操作符
    class Calcuator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }
        public void PrintHello()
        {
            Console.WriteLine("Hello");
        }
    }

    class Student
    {
        public string Name;
        public int Score;
    }

    enum Level
    {
        //建立枚舉類型時要建立0，避免預設值出錯
        Low=2,
        Mid=1,
        High=3
    }

}
