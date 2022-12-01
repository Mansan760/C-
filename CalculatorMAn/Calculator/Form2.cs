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

            //string query = "Select * from Student";
            //SqlCommand sqlcommand = new SqlCommand(query, con);
            //SqlDataAdapter sda = new SqlDataAdapter(sqlcommand);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //dataGridView1.DataSource = dt;
            //string query = "Insert into Student" +
            //                "(name,address,contact,Email)" +
            //                "values(@student_name,@address" +
            //                ",@contact,@Email)";
            //SqlCommand cmd = con.CreateCommand();
            //cmd.CommandText = query;
            //cmd.Parameters.AddWithValue("@student_name", textBox1.Text);
            //cmd.Parameters.AddWithValue("@address", textBox2.Text);
            //cmd.Parameters.AddWithValue("@student_name", textBox3.Text);
            //cmd.Parameters.AddWithValue("@student_name", textBox4.Text);
            //cmd.ExecuteNonQuery();
            //con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "Insert into Student" +
                           "(name,address,contact,Email)" +
                           "values(@Name,@address" +
                           ",@contact,@Email)";
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@Name", textBox1.Text);
            cmd.Parameters.AddWithValue("@address", textBox2.Text);
            cmd.Parameters.AddWithValue("@Contact", textBox3.Text);
            cmd.Parameters.AddWithValue("@Email", textBox4.Text);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
