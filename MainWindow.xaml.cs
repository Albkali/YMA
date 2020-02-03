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
using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;


using System.IO;

namespace YMApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {

            InitializeComponent();

        }


       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MySqlConnection sqlcon = new MySqlConnection("server=localhost;uid=root;password=1234;database=project;");
            string query = "select type from userlogin Where id ='" + TXTUser.Text + "' and password = '" + TXTPass.Password + "'";
            Console.WriteLine(query);
            //   MySqlDataAdapter sda = new MySqlDataAdapter(query, sqlcon);
            MySqlConnection conn = new MySqlConnection();

            MySqlCommand cmd = new MySqlCommand(query, sqlcon);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if (dtbl.Rows.Count > 0)
            {
                string columnvalue = dtbl.Rows[0]["type"].ToString();
                if (columnvalue.Contains("admin"))

                {
                    Window4 frm4 = new Window4();
                    this.Hide();
                    frm4.Show();
                }
                else if (columnvalue.Contains("student"))
                {
                    Window1 frm2 = new Window1();
                    this.Hide();
                    frm2.Show();
                }
                else
                {
                    Window10 frm10 = new Window10();
                    this.Hide();
                    frm10.Show();
                }


            }
            else
            {
                MessageBox.Show("Check your username and password");



            }
        }
    }
}