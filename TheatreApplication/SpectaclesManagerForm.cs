using System;
using System.Drawing;
using System.Windows.Forms;

namespace TheatreApplication
{
    public partial class SpectaclesManagerForm : Form
    {
        public SpectaclesManagerForm()
        {
            InitializeComponent();
        }

        private void SpectaclesManagerForm_Load(object sender, EventArgs e)
        {
            this.Text = "Manage Spectacles Window";
            this.Icon = new Icon("../../theatreIcon.ico");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ReservationsSuperManagerForm().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new SeatsManagerForm().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            new LogInForm().Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SpectaclesManagerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
