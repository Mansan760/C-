namespace Newdatagrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string query = "select * from student";
            SqlCommand sqlcommand = new SqlCommand(query, con);
            SqlDataAdapter sda = new 
        }
    }
}