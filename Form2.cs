namespace Game
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" )
            {
                MessageBox.Show("Please fill all the field first");
            }
            if (textBox2.Text != "yasirraiyan" && textBox1.Text == "Yasyan480")
            {
                MessageBox.Show("Username is incorrect!Please give valid username.");
            }
            if (textBox2.Text == "yasirraiyan" && textBox1.Text != "Yasyan480")
            {
                MessageBox.Show("Password is incorrect!Please give valid password.");
            }
            if (textBox2.Text=="yasirraiyan"&&textBox1.Text=="Yasyan480")
            {
                MessageBox.Show("Log In Successful");
                Form3 form = new Form3();
                form.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }
    }
}
