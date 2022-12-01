using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace Calculator
{
    public partial class Small : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog= bit3rdsem ; user id = sa;password = kist@123 ; ");
        public Small()
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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "insert into student  values ('swornim', 'rasuwa', '98xxxxxxx' , 'swornim@35gmail.com') ";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved successfully");
                con.Close();
            }

            catch (Exception ex)
            {

                MessageBox.Show("error:" + ex.InnerException);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "UPDATE student SET  Name='Satish',address='naya Bus park',Contact='98xxxxxxx' ,Email='Satish@36gmail.com' where id=3 ;";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Successfully");
                con.Close();
            }

            catch (Exception ex)
            {

                MessageBox.Show("Error:" + ex.InnerException);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "Delete from student where id=1 ;";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete Successfully");
                con.Close();
            }

            catch (Exception ex)
            {

                MessageBox.Show("Error:" + ex.InnerException);
            }
        }

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    string query = "Select * from Student";
        //    SqlCommand sqlcommand = new SqlCommand(query, con); 
        //    SqlDataAdapter sda = new SqlDataAdapter(sqlcommand);
        //    DataTable dt = new DataTable();
        //    sda.Fill(dt);
        //    dataGridView1.DataSource = dt;
        //}

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                 con.Open();
                // string query = "Insert into Student" +
                //     " (Name,Address,contact,Email)" +
                //"     values('" +
                //             Name.Text +
                //        "','" + Address.Text +
                //         "','" + Contact.Text +
                //          "','" +Email.Text +
                //          "')";
                // SqlCommand cmd = con.CreateCommand();
                // cmd.CommandText = query;
                string query = "Insert into Student" +
                            "(name,address,contact,Email)" +
                            "values(@Name,@address" +
                            ",@contact,@Email)";
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@Name", Name.Text);
                cmd.Parameters.AddWithValue("@address", Address.Text);
                cmd.Parameters.AddWithValue("@Contact", Contact.Text);
                cmd.Parameters.AddWithValue("@Email", Email.Text);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error:" + ex.Message);
            }

            //dataGridView1.Rows.Add("1", "Mansan", "Lalitpur", "9823379877", "mansansilwal@gmail.com");
            //dataGridView1.Rows.Add("2", "Anil", "Rasuwa", "9823379877", "Anilghale@gmail.com");
            //dataGridView1.Rows.Add("1", "Swornim", "Ktm", "9823379877", "swornim@gmail.com");
            //SqlConnection da = new SqlConnection("SELECT * FROM Student", "@Data Source = .\SQLEXPRESS; Initial Catalog = bit3rdsem; user id = sa; password = kist@123;");
            //DataSet ds = new DataSet();
            //da.fill(ds, "Student");
            //dataGridView1.DataSource = ds.Tables["Student"].DefaultView;
            //int n = dataGridView1.Rows.Add();
            //dataGridView1.Rows[n].Cells[0].Value = Id.Text;
            //dataGridView1.Rows[n].Cells[1].Value = Name.Text;
            //dataGridView1.Rows[n].Cells[2].Value = Address.Text;
            //dataGridView1.Rows[n].Cells[3].Value = Contact.Text;
            //dataGridView1.Rows[n].Cells[4].Value = Email.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
