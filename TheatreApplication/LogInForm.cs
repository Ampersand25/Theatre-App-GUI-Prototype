using System;
using System.Drawing;
using System.Windows.Forms;

namespace TheatreApplication
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();

            this.Text = "Authentication Window";
            this.Icon = new Icon("../../theatreIcon.ico");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "user" && textBox2.Text == "1234")
            {
                new ReservationsManagerForm().Show();
                this.Hide();
            }
            else if (textBox1.Text == "admin" && textBox2.Text == "1234")
            {
                new SpectaclesManagerForm().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("[X]Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new RegisterForm().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }

        private void LogInForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
