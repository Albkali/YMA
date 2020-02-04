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
        public static string passId , passName , passDep,passLev,passAbsCo,passAbs;
        public MainWindow()
        {

            InitializeComponent();

        }


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            // you can use your own mysqlconnection here or other server


            //MySqlConnection sqlcon = new MySqlConnection("server=localhost;uid=root;password=1234;database=project;");
            //string query = "select Type from login Where username ='" + TXTUser.Text + "' and password = '" + TXTPass.Password + "'";
            //string query2 = "select username from login Where username ='" + TXTUser.Text + "' and password = '" + TXTPass.Password + "'";
            //string query3 = "select id from login Where username ='" + TXTUser.Text + "' and password = '" + TXTPass.Password + "'";

            //string query4 = "select * from Department ";

            //Console.WriteLine(query);
            ////   MySqlDataAdapter sda = new MySqlDataAdapter(query, sqlcon);
            //MySqlConnection conn = new MySqlConnection();

            //MySqlCommand cmd = new MySqlCommand(query, sqlcon);
            //MySqlDataAdapter dataA = new MySqlDataAdapter(cmd);
            //DataTable dtbl = new DataTable();
            //dataA.Fill(dtbl);

            //MySqlCommand cmd2 = new MySqlCommand(query2, sqlcon);
            //MySqlDataAdapter dataA2 = new MySqlDataAdapter(cmd2);
            //DataTable dtb2 = new DataTable();
            //dataA2.Fill(dtb2);

            //MySqlCommand cmd3 = new MySqlCommand(query3, sqlcon);
            //MySqlDataAdapter dataA3 = new MySqlDataAdapter(cmd3);
            //DataTable dtb3 = new DataTable();
            //dataA3.Fill(dtb3);



            //if (dtb2.Rows.Count > 0)
            //{
            //    string columnvalue2 = dtb2.Rows[0]["username"].ToString();
            //    if (columnvalue2.Contains(TXTUser.Text))
            //    {
            //        passName = columnvalue2;
            //    }
            //}

            //if (dtb3.Rows.Count > 0)
            //{
            //    string columnvalue3 = dtb3.Rows[0]["id"].ToString();
            //    passId = columnvalue3;               
            //}

            //if (dtbl.Rows.Count > 0)
            //{
            //    string columnvalue = dtbl.Rows[0]["Type"].ToString();




            //    if (columnvalue.Contains("admin"))

            //    {
            //Window4 frm4 = new Window4();
            //this.Hide();
            //frm4.Show();
            //    }
            //    else if (columnvalue.Contains("student"))
            //    {
            Window1 frm2 = new Window1();
                   this.Hide();
                    frm2.Show();
            //    }
            //    else
            //    {
            //        Window10 frm10 = new Window10();
            //        this.Hide();
            //        frm10.Show();
            //    }


            //}
            //else
            //{
              //Window18 fr = new Window18();
              //  fr.WindowStartupLocation = WindowStartupLocation.CenterScreen;
              //  fr.Show();
                
            //}

           
        }


        private void Ins_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void Click_Handler(object sender, RoutedEventArgs e)
        {
            Window17 ad = new Window17();
            this.Hide();
            ad.Show();
        }
    }
}