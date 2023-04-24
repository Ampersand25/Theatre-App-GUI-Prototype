using System;
using System.Drawing;
using System.Windows.Forms;

namespace TheatreApplication
{
    public partial class SpectaclesViewerForm : Form
    {
        public SpectaclesViewerForm()
        {
            InitializeComponent();

            this.Text = "View Spectacles";
            this.Icon = new Icon("../../theatreIcon.ico");
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                new LogInForm().Show();
                this.Hide();
            }
            else
            {
                if (radioButton2.Checked)
                {
                    MessageBox.Show("[!]You cannot buy tickets for older spectacles!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (radioButton3.Checked)
                {
                    MessageBox.Show("[!]You cannot (yet) buy tickets for upcoming spectacles!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("[!]No spectacle selected!\nPlease select the current spectacle!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new LogInForm().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SpectaclesViewerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
