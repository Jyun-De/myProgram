using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Example
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //delegate 宣告匿名方法，過時的語法
            //this.myButton.Click += delegate(object sender, RoutedEventArgs e)
            //{
            //    this.myTextBox.Text = "Hello,World!";
            //};

            //======================================
            this.myButton.Click += (sender, e)=>
            {
                this.myTextBox.Text = "Hello,World!";
            };
        }


    }
}
