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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void a1Button_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "nooooo";
            this.Refresh();
            Thread.Sleep(1000);
            Form7 form7 = new Form7();
            form7.Show();
            this.Hide();

        }

        private void a2Button_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "yessss";
            this.Refresh();
            Thread.Sleep(1000);
            Form7 form7 = new Form7();
            form7.Show();
            this.Hide();
        }

        private void a3Button_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "nooooo";
            this.Refresh();
            Thread.Sleep(1000);
            Form7 form7 = new Form7();
            form7.Show();
            this.Hide();
        }

        private void a4Button_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "nooooo";
            this.Refresh();
            Thread.Sleep(1000);
            Form7 form7 = new Form7();
            form7.Show();
            this.Hide();
        }
    }
}
