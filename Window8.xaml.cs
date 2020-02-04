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
    /// Interaction logic for Window8.xaml
    /// </summary>
    public partial class Window8 : Window
    {
        public Window8()
        {
            InitializeComponent();
            //textd.Text = System.IO.File.ReadAllText(@"E:\\Request1.txt");


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window9 frm10 = new Window9();
            this.Hide();
            frm10.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window7 frm4 = new Window7();
            this.Hide();
            frm4.Show();
        }
    }
}
