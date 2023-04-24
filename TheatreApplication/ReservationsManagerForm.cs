using System;
using System.Drawing;
using System.Windows.Forms;

namespace TheatreApplication
{
    public partial class ReservationsManagerForm : Form
    {
        public ReservationsManagerForm()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.Text = "Manage Reservations Window";
            this.Icon = new Icon("../../theatreIcon.ico");

            textBox1.ReadOnly = true;
            textBox1.Text = "Name of the Spectacle";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new SeatsSelectorForm().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel your reservation?", "Cancel Reservation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No || result == DialogResult.Cancel)
            {
                return;
            }
            MessageBox.Show("The reservation is beign cancelled...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new LogInForm().Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ReservationsManagerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
