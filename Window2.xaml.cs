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
using MySql.Data.MySqlClient;


namespace YMApp2
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
            Name.Content = MainWindow.passName;
            id1.Content = MainWindow.passId;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
           

            Window3 frm10 = new Window3();
            this.Hide();
            frm10.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)

        {
            // you can use your own mysqlconnection here or other server

            ///*MySqlConnection conn = new MySqlConnection();

            //string mystring = "server=localhost;uid=root" + "password=1234;database=project;";

            //conn.ConnectionString = mystring;

            //conn.Open();

            //string query = " INSERT INTO `project`.`userinfo` ( `username`, `department`, `level`" +
            //    ", `absence`, `date`) VALUES ( '" + this.NAME.Text + "','" + this.ComboBox1.Items + "'," +
            //    " '" + this.ComboBox2.Items + "', '" + this.TextBox1.Text + "', '" 
            //    + this.DatePicker1.ToolTip + "');"  ;

            //MySqlCommand cmd = new MySqlCommand(query, conn);

            //cmd.ExecuteNonQuery();

            //conn.Close();*/

            Window1 frm4 = new Window1();
            this.Hide();
            frm4.Show();
        }
    }
}
