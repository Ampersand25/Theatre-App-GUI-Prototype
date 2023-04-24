using System;
using System.Drawing;
using System.Windows.Forms;

namespace TheatreApplication
{
    public partial class ReservationsSuperManagerForm : Form
    {
        public ReservationsSuperManagerForm()
        {
            InitializeComponent();
        }

        private void ReservationsSuperManager_Load(object sender, EventArgs e)
        {
            this.Text = "Manage Reservations Admin Window";
            this.Icon = new Icon("../../theatreIcon.ico");
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

        private void ReservationsSuperManagerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
