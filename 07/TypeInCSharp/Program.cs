using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Object 分兩類    A.引用類型 (1.類   2.接口    3.委託) B.值類型(1.結構體 2.枚舉)

//面試問題:C#中類型中有那些?
//C#語言他的類型系統包括引用類型、值類型兩種，引用類型內又包括類、接口、委託，類型裡包括結構體及枚舉，所有類型都已Object類型為自己的基類型
namespace TypeInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //類類型class
            Type myType = typeof(Form);
            Console.WriteLine(myType.FullName);//判斷在哪裡
            Console.WriteLine(myType.IsClass);//判斷是不是類

            //Form 選取案F12可直接查看定義
            
            //結構體類型struct
            //int,long.........


            //枚舉類型enum
            Form f = new Form();
            f.WindowState = FormWindowState.Normal;

            f.ShowDialog();


            //==========================



            //變量表示了存儲位置，並且每個變量都有一個類型，以決定什麼樣的值能夠存入變量
            //變量 = 以變量所名所對應的內存地址為儲空間長度的一塊內存區域

            short s = 200;
            long l = 100L;
            int x;            
            x = s;
            //x = l;轉化不了
            //變量定義  
            //a.狹義    1.  靜態    2.實例    3.數組元素  4.值參數   5.引用參數  6.輸出參數  7.局部變量
            //b.廣義  局部變量

            //==========================

            //Student stu = new Student();
            //stu.Age =-1;

            //數組
            //int[] array = new int[100];
            //array[0]

            //======================
            Student stu;                //站
            stu = new Student();//堆


            //==============
            //const int x2 = 100;
            //Console.WriteLine(x2 );
            //x2 = 200;//const 不能更改

            //=========裝箱  :先把站上的值複製到堆上再引用堆地址，絕對會損失程式的性能
            int x3 = 100;
            object obj;
            obj= x3;
            //==========拆箱  :將堆上的數值複製到站上，一樣會損失性能
            int y = (int)obj;
            Console.WriteLine(y);
        }
    }


    class Student
    {
        //public static int Amount;
        //public int Age;
        //public string Name;

        ////參數變量  ref引用   out輸出
        //public double Add(double a,double b)
        //{
        //    return a + b;
        //}

        //=====================
        class Student
        {
            uint ID;            //4個字莭
            ushort Score;//4個字莭
        }

    }
}
