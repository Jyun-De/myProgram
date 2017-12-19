using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//石頭不能變成猴子
//https://imgur.com/pZCBlvt


namespace ConversionExample_b
{
    class Program
    { 
        static void Main(string[] args)
        {
            Stone stone = new Stone();
            stone.Age = 5000;
            //孫悟空
            Monkey wukongSun = (Monkey)stone;
            //隱式類型轉換
            //Monkey wukongSun = stone;

            Console.WriteLine(wukongSun.Age);
        }
    }

    //西遊記
    class Stone
    {
        public int Age;
        //隱式類型轉換
        //public static implicit operator Monkey(Stone stone)
        
        public static explicit operator Monkey(Stone stone)
        {           
            //看起來像Monkey這個類型的構造器
            //寫在被轉化的類裡面
            Monkey m = new Monkey();
            m.Age = stone.Age / 500;
            return m;
        }
    }

    class Monkey
    {
        public int Age;
    }

}
