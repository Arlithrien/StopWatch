using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch
{
    public partial class Form1 : Form
    {

        int timeMs;
        int timeS;
        int timeM;
        bool isActive;
        private object lblMs;
        private object lblS;
        private object lblM;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            isActive = true;
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            isActive = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            isActive = false;
            resetTime();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void minutes_Click(object sender, EventArgs e)
        {

        }

        private void seconds_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            resetTime();
            

        }

        private void resetTime()
        {
            timeMs = 0;
            timeS = 0;
            timeM = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isActive)
            {
                timeMs++;
                if(timeMs >= 100)
                {
                    timeMs = 0;
                    timeS++;
                }
                else if (timeM >= 60)
                {
                    timeS = 0;
                    timeM ++;
                }
            }
            DrawTime();
        }

        private void DrawTime()
        {
            hours.Text = string.Format("{0:00}", timeM);
            minutes.Text = string.Format("{0:00}", timeS);
            seconds.Text = string.Format("{0:00}", timeMs);

        }
    }
}
