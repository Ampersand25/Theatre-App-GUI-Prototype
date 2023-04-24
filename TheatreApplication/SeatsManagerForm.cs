using System;
using System.Drawing;
using System.Windows.Forms;

namespace TheatreApplication
{
    public partial class SeatsManagerForm : Form
    {
        public SeatsManagerForm()
        {
            InitializeComponent();
        }

        private void SeatsManagerForm_Load(object sender, EventArgs e)
        {
            this.Text = "Manage Seats Window";
            this.Icon = new Icon("../../theatreIcon.ico");

            radioButton1.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new SpectaclesManagerForm().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                MessageBox.Show("[?]Number of available seats: 0", "Available Seats", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("[?]Number of occupied seats: 0", "Occupied Seats", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SeatsManagerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
