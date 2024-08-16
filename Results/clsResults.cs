using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TypeTest.Colors;
using TypeTest.Keyboard;
using TypeTest.Paragraphs;
using TypeTest.Results;
using TypeTest.Settings;
using TypeTest.Settings.Restart;
using TypeTest.Settings.Timer;

namespace TypeTest.End_Screen
{
    public class clsResults
    {
        frmResults form;

        public short Wpm;
        public short AccurancyPrec;
        public int TotalLetters;
        public int TotalWords;
        public int NumOfRightWords;

        public clsResults(frmResults Form)
        {
            form = Form;
            MainForm.MyTimer.StopTimer();
            TotalLetters = MainForm.MyParagraph.TextLength();
            TotalWords = clsParagraphs.TotalWords;
            NumOfRightWords = MainForm.MyParagraph.NumberOfRightWords();

            MainForm.MyParagraph.TextColor(ref form.tbResult);

            form.PBAccuracy.Maximum = 100;
            form.PBRightLetters.Maximum = 100;
            form.PBWrongLetters.Maximum = 100;


            form.lblWpmResult.Text = Math.Round(WPM()).ToString();

            form.PBAccuracy.Value = Convert.ToInt16(Accurancy());
            form.lblAccuracyPrec.Text = form.PBAccuracy.Value.ToString() + "%";

            form.PBRightLetters.Value = Convert.ToInt32(CorrectLettersPrec());
            form.lblRightLettersPrec.Text = form.PBRightLetters.Value.ToString() + "%";

            form.PBWrongLetters.Value = Convert.ToInt32(WrongLettersPrec());
            form.lblWrongLettersPrec.Text = form.PBWrongLetters.Value.ToString() + "%";
        }
        public double WPM()
        {
            double Time = Convert.ToDouble(MainForm.MyTimer.GetCurrentTimerValue()) / 60;

            return Convert.ToDouble(NumOfRightWords) / Time;
        }
        public double Accurancy()
        {
            return ((double)NumOfRightWords / TotalWords) * 100;
        }
        public double CorrectLettersPrec()
        {
            return ((double)clsParagraphs.NumbersOfTrueLetters / TotalLetters ) * 100;
        }
        public double WrongLettersPrec()
        {
            return ((double)clsParagraphs.NumbersOfWrongLetters / TotalLetters) * 100;
        }
        public void RestartPressed()
        {
            form.Close();
            MainForm.SameText = true;
            MainForm.MyRestart.RestartAll();
            MainForm.SameText = false;
        }
        public void NextPressed()
        {
            form.Close();
            MainForm.MyParagraph.AnotherParagragh();
        }
    }
}
