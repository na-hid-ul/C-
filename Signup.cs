using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic.Logging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bow_and_Arrow_1
{
    public partial class Signup : Form
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-I11GJ35\\SQLEXPRESS;Initial Catalog=game;Integrated Security=True");




        public Signup()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox3.Text) && !string.IsNullOrWhiteSpace(textBox6.Text))
                {


                    if (MessageBox.Show("Do You Want To Insert This Data", "Insert Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {


                        SqlCommand command = new SqlCommand("insert into registation values (@name,@email,@username,@password)", con);
                        command.Parameters.AddWithValue("@Name", textBox6.Text);
                        command.Parameters.AddWithValue("@Email", textBox3.Text);

                        command.Parameters.AddWithValue("@UserName", textBox2.Text);
                        command.Parameters.AddWithValue("@Password", textBox1.Text);


                        con.Open();
                        command.ExecuteNonQuery();
                        con.Close();


                        textBox1.Text = "";
                        textBox3.Text = "";

                        textBox6.Text = "";

                        login log = new login();
                        log.Show();
                        this.Hide();


                        con.Close();

                    }
                    else
                    {
                        MessageBox.Show("Data Not Inserted", "Insert Data", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                    return;
                }











                else
                {

                    MessageBox.Show("Please Fill Up All The Informaton");
                }
            }
            catch (Exception r)
            {
                MessageBox.Show(r.Message);

            }
            finally
            {
                con.Close();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand check_User_Name = new SqlCommand("SELECT COUNT(*) FROM [Game].[dbo].[registation] WHERE ([username] = @UserName)", con);
            check_User_Name.Parameters.AddWithValue("@UserName", textBox2.Text);
            int UserExist = (int)check_User_Name.ExecuteScalar();
            con.Close();
            if (UserExist > 0)
            {
                errorProvider2.SetError(this.textBox2, " User Name Already Inserted");
                button2.Enabled = false;
                button2.BackColor = Color.Red;

                return;

            }
            else
            {
                errorProvider2.Clear();
                button2.Enabled = true;
                button2.BackColor = Color.White;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("^([0-9a-zA-Z]([-.\\w\\+]*[0-9a-zA-Z\\+])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$");

            if (regex.IsMatch(textBox3.Text))
            {
                errorProvider1.Clear();
                button2.Enabled = true;
                button2.BackColor = Color.White;


            }
            else
            {
                errorProvider1.SetError(this.textBox3, " Provide valid Mail address");
                button2.Enabled = false;
                button2.BackColor = Color.Red;
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Hide();
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
