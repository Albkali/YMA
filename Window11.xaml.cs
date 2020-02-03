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

namespace YMApp2
{
    /// <summary>
    /// Interaction logic for Window11.xaml
    /// </summary>
    public partial class Window11 : Window
    {
        public Window11()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window12 frm10 = new Window12();
            this.Hide();
            frm10.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window10 frm4 = new Window10();
            this.Hide();
            frm4.Show();
        }
    }
}
