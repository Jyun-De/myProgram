using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;

namespace IdentifiersExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //===可用中文=================
            int 我的變量 = 100;
            Console.WriteLine(我的變量);

            //===變量名要有意義===========
            //
            //類        名詞
            //屬性    名詞
            //方法    動詞

            //大小寫規範
            int myVariable = 100;
            //駝峰法
            int MyVarible = 100;
            //匈牙利命名
            //類別、方法、名稱空間

            //===標點符號======================
            //
            //不與程式做直接動作
            //for (int i = 0; i < length; i++)
            //{
                
            //}

            //===字面值=====================
            //整數
            int x = 2;//32byte
            long y = 3L;//64byte

            //實數
            float x2 = 3.0f;
            double y2 = 4.0d;

            //字符
            char c ='h';

            //字符串
            string str = "";

            //布爾值
            bool b2 = false;

            //空值
            //string str2 = null;
            //Form f = null;
            //f.ShowDialog();
            //編譯錯誤，不能引用空物件

            //===類型、變量、方法========
            var x3 = 3.0f;
            Console.WriteLine(x3.GetType().Name);
        }
    }
}
