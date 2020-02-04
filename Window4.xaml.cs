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
    /// Interaction logic for Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
            name.Content = MainWindow.passName;
            id.Content = MainWindow.passId;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window5 frm10 = new Window5();
            this.Hide();
            frm10.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow frm4 = new MainWindow();
            this.Hide();
            frm4.Show();
        }
    }
}
