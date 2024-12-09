namespace Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="yasirraiyan"&&textBox2.Text=="Yasyan480"&&textBox3.Text=="Yasyan480")
            {
                MessageBox.Show("Registration Successful.Welcome Login Page");
                Form2 form = new Form2();
                form.Show();
            }
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Please fill all the field first");
            }
            if (textBox1.Text != "yasirraiyan" && textBox2.Text == "Yasyan480" && textBox3.Text == "Yasyan480")
            {
                MessageBox.Show("Username is incorrect!Please give valid username.");
            }
            if (textBox1.Text == "yasirraiyan" && textBox2.Text != "Yasyan480" && textBox3.Text == "Yasyan480")
            {
                MessageBox.Show("Password is incorrect!Please give valid password.");
            }
            if (textBox1.Text == "yasirraiyan" && textBox2.Text == "Yasyan480" && textBox3.Text != "Yasyan480")
            {
                MessageBox.Show("Password and confirm password not match");
            }
            else
            {
                MessageBox.Show("Registration Failed!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
        }
    }
}
