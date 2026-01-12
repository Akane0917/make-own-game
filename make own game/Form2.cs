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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
          
        }

        private void answerButton_Click(object sender, EventArgs e)
        {
            if (answerTextBox.Text == "Nile River" || answerTextBox.Text == "Nile river")
            {
                outputLabel.Text = "correct answer!";




            }
            else if (answerTextBox.Text == "")
            {
                outputLabel.Text = "enter your answer";
            }
            else
            {
                outputLabel.Text = "incorrect answer...";
            }


            this.Refresh();
            Thread.Sleep(1000);
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide ();


          

        }
    }
}
