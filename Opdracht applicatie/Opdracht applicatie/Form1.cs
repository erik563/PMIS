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

namespace Opdracht_applicatie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            password_txt.PasswordChar = '*'; //vervangd alles in password tekstbox met *
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //databse connectie
                String myConnection = "datasource=127.0.0.1;port=3306;username=root;password=root"; // database string
                MySqlConnection myConn = new MySqlConnection(myConnection);

                MySqlCommand SelectCommand = new MySqlCommand("select * from database1.user where idUser='" + this.username_txt.Text + "'and Password='" + this.password_txt.Text + "' ;", myConn);

                MySqlDataReader myReader;
                myConn.Open(); //Open connectie database
                myReader = SelectCommand.ExecuteReader();
                int count = 0;
                while (myReader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)  //Unieke username+password
                {
                    MessageBox.Show("Username and password is correct");
                    this.Hide(); //hide eerste form
                    Form2 f2 = new Form2(); //nieuwe variabel form2
                    f2.ShowDialog(); //laat form 2 zien
                }
                else if (count > 1) //Username en password meer dan 1 keer aanwezig
                {
                    MessageBox.Show("Duplicate username and password");
                }
                else //Username en password niet aanwezig
                    MessageBox.Show("Username and password is not correct");
                myConn.Close(); //sluit connectie database
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Create_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }
    }
}
