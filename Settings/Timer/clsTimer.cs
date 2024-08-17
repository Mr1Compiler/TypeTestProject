using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TypeTest.Paragraphs;
using TypeTest.Results;

namespace TypeTest.Settings.Timer
{
    
    public class clsTimer
    {
        MainForm form;
        public int ProgressBarValue;
        public static int TimerValue;
        public int CurrentValue;
        public static bool isCustomValue = false;
        public static int CustomValue = 0;
        public clsTimer(MainForm Form)
        {
            form = Form;

            if(MainForm.CustomTime)
            {
                TimerValue = CustomValue;
            }
            else
            {
                TimerValue = InitializingTimerValue();
            }
            
            CurrentValue = 0;
            form.timer1.Enabled = false;
            form.ProgressBar.Enabled = true;
            ProgressBarValue = MainForm.MyParagraph.TextLength();
            form.ProgressBar.Value = 0;
            form.ProgressBar.Minimum = 0;
            form.ProgressBar.Maximum = ProgressBarValue;
        }

        public void SetCustomValue(int Value)
        {
            form.CustomTimer(Value);
        }
        public int InitializingTimerValue()
        {
            if (isCustomValue)
            {
                isCustomValue = false;
                return CustomValue;
            }

            else
            {
                return 15;
            }
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
                MainForm.MyParagraph.ShowResultsForm();
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
