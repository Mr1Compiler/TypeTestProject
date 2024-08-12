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
        public static int Value = 30;
        

        public clsTimer(MainForm Form)
        {
            form = Form;
            form.ProgressBar.Maximum = clsParagraphs.TextLength();
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

        public void ProgressBar()
        {
            form.ProgressBar.Value++;
        }

        public bool IsTimerEnd()
        {
            return (Value == 0);
        }
    }
}
