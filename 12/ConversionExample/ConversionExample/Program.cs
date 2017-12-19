using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1544
//https://imgur.com/a/BCfCb

namespace ConversionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            //字符串相加，非數字相加
            Console.WriteLine(str1 + str2);

            //數字類型轉換
            int x = Convert.ToInt32(str1);
            int y = Convert.ToInt32(str2);
            Console.WriteLine(x + y);

            //裝箱、拆箱參考前面影片

            //不丟失精度的轉換
            //把一隻金魚丟進浴缸沒問題，以大小而言丟進泳池也不會有問題
            //https://imgur.com/Tl7Sdxu //轉換表
            int a = int.MaxValue;
            long b = a;
            Console.WriteLine(b);

            //所有面對對象的編程語言都支持子類向副類的引示類型轉換
            //繼承
            //https://imgur.com/0ouI6zs
            Teacher t = new Teacher();
            Human h = t;
            Animal ani = h;
            ani.Eat();

            //=======cast 鑄造==============================
            //顯示類類型轉換
            //大裝到小
            //https://imgur.com/uCF4qB3
            Console.WriteLine(ushort.MaxValue);
            uint x2 = 65536;
            ushort y2 = (ushort)x2  ;
            Console.WriteLine(y);

            //Convert.ToInt32                   //透過這個類可以透過一定的邏輯轉化類型
            //Convert展示
            //方法1
            //https://imgur.com/oedr7Dw
            //方法2
            //https://imgur.com/qrkzJQV
            //結果
            //https://imgur.com/vxruyBR
            //方法3，但其輸入必須為數學格式，否則會顯示錯誤
            //https://imgur.com/O21pKPQ

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
                public  void Run()
                {
                    Console.WriteLine("Running...");
                }
            }

    
    
    }

}
