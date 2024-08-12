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
        public static int Value;
        public int ProgressBarValue;

        public clsTimer(MainForm Form)
        {
            form = Form;
            Value = 30;
            form.timer1.Enabled = false;
            form.ProgressBar.Enabled = true;
            ProgressBarValue = MainForm.MyParagraph.TextLength();
            form.ProgressBar.Value = 0;
            form.ProgressBar.Minimum = 0;
            form.ProgressBar.Maximum = ProgressBarValue;

        }

        public void TimerTick()
        {
            if (!IsTimerEnd())
            {
                form.lblTimer.Text = Value.ToString();
                Value--;
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

        public bool IsTimerEnd()
        {
            return (Value == 0);
        }
    }
}
