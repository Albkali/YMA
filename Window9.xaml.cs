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
using System.Windows.Shapes;
using File = System.IO.File;

namespace YMApp2
{
    /// <summary>
    /// Interaction logic for Window9.xaml
    /// </summary>
    public partial class Window9 : Window
    {
        public Window9()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string path = @"E:\\Feedback1.txt";

            File.WriteAllText(path, textbox22.Text); 

            
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window8 frm4 = new Window8();
            this.Hide();
            frm4.Show();
        }
    }
}
