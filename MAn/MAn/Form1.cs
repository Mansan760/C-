namespace MAn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Mansan_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string data = FullName.Text;
                int data2 = Convert.ToInt32(Age.Text);
                MessageBox.Show("Age: " + data2);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Invalid Number" +ex);
            }
            //for (int i = 0; i <= 2; i++)
            //{
            //    if (data == "Mansan")
            //    {
            //        MessageBox.Show("Very Beautiful name.");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Please Enter a proper name.");
            //    }
            //}
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FullName.Text = "test";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}