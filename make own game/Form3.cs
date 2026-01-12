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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void answerButton_Click(object sender, EventArgs e)
        {
            if (ansTextBox.Text == "Indonesia ")
            {
                outputLabel.Text = "Good jpb!";

            }
            else if (ansTextBox.Text == "")
            {
                outputLabel.Text = "enter your answer";
            }
            else
            {
                outputLabel.Text = "Wrong!";

            }

            this.Refresh();
            Thread.Sleep(1000);
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }
    }
}
