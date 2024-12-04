using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Bow_and_Arrow_1
{

    public partial class login : Form
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-I11GJ35\\SQLEXPRESS;Initial Catalog=game;Integrated Security=True");





        public static string loginName;

        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            signup.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text))
            {
                SqlCommand command = new SqlCommand("select * from registation where UserName=@UserName and Password=@Password", con);
                command.Parameters.AddWithValue("@UserName", textBox1.Text);
                command.Parameters.AddWithValue("@Password", textBox2.Text);
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();
                if (dt.Rows.Count > 0)
                {
                    loginName = textBox1.Text;
                    Form2 game = new Form2();
                    game.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid UserName or Password");
                }
            }
            else
            {
                MessageBox.Show("Please Enter the username password");
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tutorial tutorial = new tutorial(); 
            tutorial.Show();
            this.Hide();
        }
    }
}


