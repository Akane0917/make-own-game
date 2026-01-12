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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void jButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "Good answer";
            this.Refresh();
            Thread.Sleep(1000);
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();

        }

        private void gButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "wrong";
            this.Refresh();
            Thread.Sleep(1000);
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

    }
}
