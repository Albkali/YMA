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
    /// Interaction logic for Window17.xaml
    /// </summary>
    public partial class Window17 : Window
    {
        public Window17()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow ad = new MainWindow();
            this.Hide();
            ad.Show();
        }
    }
}
