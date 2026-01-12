using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace make_own_game
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ansTextBox.Text == "Ottawa" || ansTextBox.Text == "ottawa")
            {
                outputLabel.Text = "Nice answer";
            }
            else if (ansTextBox.Text == "")
            {
                outputLabel.Text = "enter your answer";
            }
            else
            {
                outputLabel.Text = "wrong answer";
            }
            this.Refresh();
            Thread.Sleep(1000);
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();

        }
    }
}
