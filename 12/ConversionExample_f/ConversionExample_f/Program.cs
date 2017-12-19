using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionExample_f
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 7;
            int y = 28;
            int z = x & y; //and
            int z1 = x | y; //or
            int z2 = x ^ y; //XOR
            string strX = Convert.ToString(x, 2).PadLeft(32, '0');
            string strY = Convert.ToString(y, 2).PadLeft(32, '0');
            string strZ = Convert.ToString(z, 2).PadLeft(32, '0');
            string strZ1 = Convert.ToString(z1, 2).PadLeft(32, '0');
            string strZ2 = Convert.ToString(z2, 2).PadLeft(32, '0');

            Console.WriteLine(strX);        //00000000000000000000000000000111
            Console.WriteLine(strY);        //00000000000000000000000000011100


            Console.WriteLine(strZ);        //00000000000000000000000000000100
            Console.WriteLine(strZ1);      //00000000000000000000000000011111
            Console.WriteLine(strZ2);      //00000000000000000000000000011011



            x = 5;
            y = 4;
            int a = 3;
            if(x>y||++a>3)      //有短路的作用，但寫程式時要避開這個部分       ++a= 4
            {
                Console.WriteLine("Hello");
            }
            Console.WriteLine(a);

            //========"??"可空類型====================
            //x = null;         無法給空值
            //交作業前給空值
            //'
            Nullable<int> x_ = null;
            Console.WriteLine(x_.HasValue);         //F

            int? x__ = null;
            int y__ = x__ ?? 1;    //如果是null就給他1
            Console.WriteLine(y__);

            //===============?:條件操作符=====
            x = 80;
            string str = string.Empty;
            //if(x>=60)
            //{
            //    str = "Pass";
            //}else
            //{
            //    str = "Failed";
            //}
            //Console.WriteLine(str);

            //跟上述一樣功能
            str = (x > 60 )? "Pass" : "Falied";
            Console.WriteLine(str);



        }
    }
}
