using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using  static WindowsFormsApp2.Form2;
namespace WindowsFormsApp2

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public class Server
        {
            public MySqlConnection GetConn()
            {

                string connStr = "server=chuc.caseum.ru;port=33333;user=uchebka;database=uchebka;password=uchebka;";
                MySqlConnection conn = new MySqlConnection(connStr);
                return conn;
            }


        }



        WindowsFormsApp2.Form2 f1 = new WindowsFormsApp2.Form2();

        private void button1_Click(object sender, EventArgs e)
        {
            {
                f1.ShowDialog();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                this.Close();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    Server ser = new Server();
                    ser.GetConn();
                    MessageBox.Show("Подключено");

                }
                catch
                {
                    MessageBox.Show("Не подключено!");
                }
            }
        }
    }
}
