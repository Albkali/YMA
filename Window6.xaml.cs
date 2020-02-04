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
    /// Interaction logic for Window6.xaml
    /// </summary>
    public partial class Window6 : Window
    {
        public Window6()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window7 frm10 = new Window7();
            this.Hide();
            frm10.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window5 frm4 = new Window5();
            this.Hide();
            frm4.Show();
        }

        private void Combo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
