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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Bow_and_Arrow_1
{

    public partial class myscore : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-I11GJ35\\SQLEXPRESS;Initial Catalog=game;Integrated Security=True");
        string username = login.loginName;
        public myscore()
        {
            InitializeComponent();
        }

        private void SetupDataGridView(DataGridView dataGridView, string mood)
        {
            //string username = login.loginName; // assuming login.loginName holds the username
            con.Open();
            SqlCommand com = new SqlCommand("SELECT * FROM dbo.point WHERE username = @username AND mood = @mood ORDER BY score DESC", con);
            com.Parameters.AddWithValue("@username", username);
            com.Parameters.AddWithValue("@mood", mood);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView.DataSource = dt;
            con.Close();

            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            dataGridView.Anchor = AnchorStyles.None;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.DefaultCellStyle.ForeColor = Color.FromArgb(43, 174, 102);
        }



        private void myscore_Load(object sender, EventArgs e)
        {

            SetupDataGridView(dataGridView1, "Easy");
            SetupDataGridView(dataGridView2, "Medium");
            SetupDataGridView(dataGridView3, "Hard");



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form1 = new Form2();
            form1.Show();
            this.Hide();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
