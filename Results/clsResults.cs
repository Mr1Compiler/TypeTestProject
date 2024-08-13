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
        public short RightLettersPrec;
        public short WrongLettersPrec;
        public int TotalLetters;
        public int TotalWords;
        public int NumOfRightWords;
        public RichTextBox tbResult;

        public clsResults(frmResults Form)
        {
            form = Form;
            tbResult = new RichTextBox();
            MainForm.MyTimer.StopTimer();
            TotalLetters = MainForm.MyParagraph.TextLength();
            TotalWords = MainForm.MyParagraph.ShowenParagraph.Split().Length;
            MainForm.MyParagraph.TextColor(ref tbResult);
            NumOfRightWords = MainForm.MyParagraph.NumberOfRightWords();

            //MessageBox.Show($"Total: {TotalWords}\n Right:  {NumOfRightWords}");

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
