using System;
using System.Drawing;
using System.Windows.Forms;

namespace TheatreApplication
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            this.Text = "User Registration Window";
            this.Icon = new Icon("../../theatreIcon.ico");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox5.PasswordChar = '*';
        }

        private void label8_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ReservationsManagerForm().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new LogInForm().Show();
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                textBox5.PasswordChar = '\0';
            }
            else
            {
                textBox5.PasswordChar = '*';
            }
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
