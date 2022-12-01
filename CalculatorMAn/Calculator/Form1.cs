namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float num1, ans;
        int count;
        private void button1_Click(object sender, EventArgs e)
        {
            Display.Text= Display.Text + 1;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + 9;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + 0;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Display.Clear(); 
        }

        private void button15_Click(object sender, EventArgs e)
        {
            compute(count);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(Display.Text);
            Display.Clear();
            Display.Focus();
            count = 2;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (Display.Text != "")
            {
                num1 = float.Parse(Display.Text);
                Display.Clear();
                Display.Focus();
                count = 1;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(Display.Text);
            Display.Clear();
            Display.Focus();
            count = 3;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(Display.Text);
            Display.Clear();
            Display.Focus();
            count = 4;
        }

        private void button17_Click(object sender, EventArgs e)
        {
                Display.Text = Display.Text + ".";

        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.Hide();
            Small smallForm = new Small();
            smallForm.ShowDialog();
        }

        public void compute(int count)
        {
            switch (count)
            {
                case 1:
                    ans = num1 - float.Parse(Display.Text);
                    Display.Text = ans.ToString();
                    break;
                case 2:
                    ans = num1 + float.Parse(Display.Text);
                    Display.Text = ans.ToString();
                    break;
                case 3:
                    ans = num1 * float.Parse(Display.Text);
                    Display.Text = ans.ToString();
                    break;
                case 4:
                    ans = num1 / float.Parse(Display.Text);
                    Display.Text = ans.ToString();

                    break;
                default:
                    break;
            }
        }
        }
}