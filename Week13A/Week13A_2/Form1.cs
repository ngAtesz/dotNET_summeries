using System;
using System.Windows.Forms;

namespace Week13A_2
{
    public partial class Form1 : Form
    {
        Timer _t;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            _t = new Timer();
            _t.Interval = 1000;
            _t.Tick += new EventHandler(t_Tick);

            _t.Start();
        }

        private void t_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
            if (progressBar1.Value >= 100)
            {
                _t.Stop();
            }
        }
    }
}
