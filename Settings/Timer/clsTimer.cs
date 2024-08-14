using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TypeTest.Paragraphs;

namespace TypeTest.Settings.Timer
{
    
    public class clsTimer
    {
        MainForm form;
        public int ProgressBarValue;
        public static int TimerValue;
        public int CurrentValue;

        public clsTimer(MainForm Form)
        {
            form = Form;

            TimerValue = 30;
            CurrentValue = 0;
            form.timer1.Enabled = false;
            form.ProgressBar.Enabled = true;
            ProgressBarValue = clsParagraphs.TextLength();
            form.ProgressBar.Value = 0;
            form.ProgressBar.Minimum = 0;
            form.ProgressBar.Maximum = ProgressBarValue;

        }

        public void TimerTick()
        {
            if (!IsTimerEnd())
            {
                form.lblTimer.Text = TimerValue.ToString();
                TimerValue--;
                CurrentValue++;
            }

            else
            {
                form.timer1.Enabled = false;
                MessageBox.Show("Time end");
            }
        }

        public void ProgressBar(bool IsBackSpace)
        {
            if (IsBackSpace)
                form.ProgressBar.Value--;
            else
                form.ProgressBar.Value++;
        }

        public int GetTimerValue()
        {
            return TimerValue;
        }

        public int GetCurrentTimerValue()
        {
            return CurrentValue;
        }

        public bool IsTimerEnd()
        {
            return (TimerValue == 0);
        }

        public void StopTimer()
        {
            form.timer1.Enabled = false;
        }
    }
}
