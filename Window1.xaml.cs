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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            
            InitializeComponent();

            name.Content = MainWindow.passName;
            id.Content = MainWindow.passId;

                    }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window2 frm10 = new Window2();
            this.Hide();
            frm10.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window16 frm4 = new Window16();
            this.Hide();
            frm4.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MainWindow fr = new MainWindow();
            this.Hide();
            fr.Show();
        }
    }
}
