using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypeSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Type myType = typeof(Form);
            //Console.WriteLine(myType.Name);//Form
            //Console.WriteLine(myType.FullName);//System.Window.Form
            //Console.WriteLine(myType.BaseType.FullName);//找到自己類型的副類

            PropertyInfo[] plnfos = myType.GetProperties();
            foreach(var p in plnfos)
            {
                //列出Form所有屬性
                Console.WriteLine(p.Name);
            }

            MethodInfo[] mInfos = myType.GetMethods();
                foreach(var m in mInfos)
                {
                    //列出所有method
                    Console.WriteLine(m.Name);
                }

        }
    }
}
