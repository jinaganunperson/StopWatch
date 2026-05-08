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
        private System.Windows.Forms.Timer timer;
        private int hours = 0;
        private int minutes = 0;
        private int seconds = 0;

        public Form1()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            seconds++;
            if (seconds >= 60)
            {
                seconds = 0;
                minutes++;
            }
            if (minutes >= 60)
            {
                minutes = 0;
                hours++;
            }
            lblTime.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", hours, minutes, seconds);
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            // Stop only
            timer.Stop();
        }

        private void btnset_Click(object sender, EventArgs e)
        {
            timer.Stop();
            hours = 0; minutes = 0; seconds = 0;
            lblTime.Text = "00:00:00";
            // Clear history when SET is pressed
            if (lstHistory != null)
            {
                lstHistory.Items.Clear();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool dark = checkBox1.Checked;

            Color back = dark ? Color.Black : SystemColors.Control;
            Color fore = dark ? Color.White : SystemColors.ControlText;

            this.BackColor = back;
            this.ForeColor = fore;

            // Update controls individually where necessary
            lblTime.BackColor = back;
            lblTime.ForeColor = fore;
            lblName.BackColor = back;
            lblName.ForeColor = fore;

            btnstart.BackColor = dark ? Color.DimGray : SystemColors.Control;
            btnstart.ForeColor = fore;
            btnstop.BackColor = dark ? Color.DimGray : SystemColors.Control;
            btnstop.ForeColor = fore;
            btnset.BackColor = dark ? Color.DimGray : SystemColors.Control;
            btnset.ForeColor = fore;

            lstHistory.BackColor = dark ? Color.FromArgb(30,30,30) : SystemColors.Window;
            lstHistory.ForeColor = fore;

            checkBox1.BackColor = back;
            checkBox1.ForeColor = fore;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // HISTORY button: 기록만 하고 타이머를 멈추지 않음
            if (lstHistory == null) return;

            string current = lblTime.Text ?? string.Empty;
            if (string.IsNullOrEmpty(current)) return;

            bool add = false;
            if (lstHistory.Items.Count == 0)
            {
                add = true;
            }
            else
            {
                var last = lstHistory.Items[lstHistory.Items.Count - 1]?.ToString() ?? string.Empty;
                if (!string.Equals(last, current, StringComparison.Ordinal))
                    add = true;
            }

            if (add)
                lstHistory.Items.Add(current);
        }
    }
}
