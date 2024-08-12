using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        MainForm form;
        frmResults frmResults;
        public short Wpm;
        public short AccurancyPrec;
        public short RightLettersPrec;
        public short WrongLettersPrec;
        public int TotalLetters;
        public int TotalWords;

        public clsResults(MainForm Form)
        {
            form = Form;
            frmResults.ShowDialog();
            form.timer1.Enabled = false;

            TotalLetters = MainForm.MyParagraph.TextLength();
            TotalWords = MainForm.MyParagraph.ShowenParagraph.Split().Length;

            frmResults.tbResult.Text = form.tbText.Text;

        }
        
        public void WPM()
        {
            
        }


        public void RestartPressed()
        {

        }

        public void NextPressed()
        {

        }
    }
}
