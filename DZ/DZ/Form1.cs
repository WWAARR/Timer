using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ
{
    public partial class Form1 : Form
    {
        System.Timers.Timer t;
        System.Timers.Timer tm;
        int h, m, s;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            t = new System.Timers.Timer();
            t.Interval = 100;
            t.Elapsed += OnTimeEvent;
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            t.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Stop();
            Application.DoEvents();
        }

        private void MoreH_Click(object sender, EventArgs e)
        {
            h++;
            MinTimeTable.Text = string.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
        }

        private void MoreM_Click(object sender, EventArgs e)
        {
            m++;
            MinTimeTable.Text = string.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
        }

        private void MoreS_Click(object sender, EventArgs e)
        {
            s++;
            MinTimeTable.Text = string.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            t.Stop();
        }

        private void Dead_Click(object sender, EventArgs e)
        {
            t = new System.Timers.Timer();
            t.Interval = -100;
            t.Elapsed += OnTimeEvent;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            t.Stop();
            s = 0;
            m = 0;
            h = 0;
            TimeTable.Text = string.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
        }
        private void OnTimeEvent (object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new Action(() => 
            {
                s += 1;
                if (s == 60)
                {
                    s = 0;
                    m += 1;
                }
                if (m == 60)
                {
                    m = 0;
                    h += 1;
                }
                if (h >= 24)
                {
                    h =0;
                }
                TimeTable.Text = string.Format("{0}:{1}:{2}",h.ToString().PadLeft(2,'0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
            }));
        }
    }
}
//Process.Start("shutdown", "/s /t 0");