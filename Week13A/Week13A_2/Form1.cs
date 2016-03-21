using System;
using System.Windows.Forms;

namespace Week13A_2
{
    public partial class Form1 : Form
    {
        Timer t;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            t = new System.Windows.Forms.Timer();
            t.Interval = 1000;
            t.Tick += new EventHandler(t_Tick);

            t.Start();
        }

        private void t_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
            if (progressBar1.Value >= 100)
            {
                t.Stop();
            }
        }
    }
}
