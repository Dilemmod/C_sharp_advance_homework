using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L3_Task_4
{
    public partial class TimerForm : Form
    {
        Timer timer = new Timer();
        int time = 0;
        public TimerForm()
        {
            InitializeComponent();
            this.textBox1.Text = "H:00   M:00   S:00";
        }

        private void timer_Tick(object sender, EventArgs e)
        {
             time++;
             int h = time / 3600;
             int m = time % 3600 / 60;
             int s = time % 3600 % 60;
             this.textBox1.Text = ("H:" + (h < 10 ? "0" : "") + h + "   M:" + (m < 10 ? "0" : "") + m + "   S:" + (s < 10 ? "0" : "") + s);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                timer.Enabled = false;
            }
            else
            {
                timer.Interval = 1000;
                timer.Tick += new EventHandler(timer_Tick);
                timer.Start();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            time = 0;
            timer.Stop();
            this.textBox1.Text = "H:00   M:00   S:00";
        }
    }
}
