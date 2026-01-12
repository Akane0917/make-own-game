using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace make_own_game
{
  
    public partial class Form1 : Form
    {
      

        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            TimerManeger.Stopwatch.Start();
           


            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this .Close(); 
        }
    }
    public static class TimerManeger
    {
        public static Stopwatch Stopwatch = new Stopwatch();
    }
}
