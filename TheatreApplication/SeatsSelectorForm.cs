using System;
using System.Drawing;
using System.Windows.Forms;

namespace TheatreApplication
{
    public partial class SeatsSelectorForm : Form
    {
        public SeatsSelectorForm()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.Text = "Choose Seats Window";
            this.Icon = new Icon("../../theatreIcon.ico");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new ReservationsManagerForm().Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SeatsSelectorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
