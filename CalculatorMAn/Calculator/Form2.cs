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


namespace Calculator
{
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog= bit3rdsem ; user id = sa;password = kist@123 ; ");
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            string query = "Select * from Student";
            SqlCommand sqlcommand = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcommand);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

        }
    }
}
