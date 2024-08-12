using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TypeTest.Colors;
using TypeTest.End_Screen;
using TypeTest.Keyboard;
using TypeTest.Settings.Timer;

namespace TypeTest.Paragraphs
{
    public class clsParagraphs
    {
        MainForm form;
        public string ShowenParagraph = "";
        private string _PrevParagraph = "";
        private int _TotalNumberOfParagraphs = 10;
        public static int NumbersOfRightWords;
        private RichTextBox tbText2;
        private int Counter;
        private bool[] Answer;
        private bool IsArray = false;
        public static int NumbersOfTrueLetters;
        public static int NumbersOfWrongLetters;
        public bool IsBackSpace = false;

        
        public clsParagraphs(MainForm Form)
        {
            tbText2 = new RichTextBox();
            Counter = 0;
            IsArray = true;
            NumbersOfTrueLetters = 0;
            NumbersOfWrongLetters = 0;
            NumbersOfRightWords = 0;
            IsBackSpace = false;
            form = Form;

            if (MainForm.SameText)
            {
                ShowenParagraph = form.tbText.Text;
            }
            else
            {
                GetRandomParagraph();
                _PrevParagraph = ShowenParagraph;
            }

            form.tbText.Text = ShowenParagraph;
            tbText2.Text = ShowenParagraph;
            TestArray();
        }

        public void AnotherParagragh()
        {
            form.lblTimer.Visible = false;
            MainForm.MyParagraph = new clsParagraphs(form);
            MainForm.MyTimer = new clsTimer(form);
            form.tbText.Enabled = true;
        }

        public int TextLength()
        {
            return ShowenParagraph.Length;
        }
        private int GetRandomNumber(int Num1, int Num2)
        {
            Random rand = new Random();
            int RandomNumber = rand.Next(Num1, Num2);

            return RandomNumber;
        }
        private string Paragraphs(int Index)
        {
            string[] Paragraphs =
            {
            "The quick brown fox jumps over the lazy dog",
            "A journey of a thousand miles begins with a single step",
            "To be or not to be, that is the question",
            "All that glitters is not gold",
            "A picture is worth a thousand words",
            "Fortune favors the bold",
            "The early bird catches the worm",
            "Actions speak louder than words",
            "When in Rome, do as the Romans do",
            "You can lead a horse to water, but you can't make it drink"
            };

            return Paragraphs[Index];
        }
        private string GetRandomParagraph()
        {
            return ShowenParagraph = Paragraphs(GetRandomNumber(0,_TotalNumberOfParagraphs));
        }

        private void TestArray()
        {
            if (IsArray)
            {
                Answer = new bool[tbText2.Text.Length + 1];
            }
            form.tbText.HideSelection = true;
            form.tbText.Select(0, 1);
            form.tbText.SelectionBackColor = MainForm.MyColors.SelectionColorOfLetter();

        }

        private void TextColor()
        {
            form.tbText.Text = tbText2.Text;
            //form.tbText.HideSelection = true;

            for (int i = 0; i < Counter + 1; i++)
            {
                form.tbText.Select(i, 1);

                if (Answer[i] == true)
                {
                    form.tbText.SelectionColor = MainForm.MyColors.ColoringTrueLetter(); 
                }

                else
                {
                    form.tbText.SelectionColor = MainForm.MyColors.ColoringWrongLetter();           
                }
            }
            form.tbText.SelectionBackColor = MainForm.MyColors.SelectedLetterBackColor();
        }
        private void Selection(int Counter, int SelectionIndex)
        {
            form.tbText.Select(Counter, SelectionIndex);
        }
        private bool IsItTrue(char ch1, char ch2)
        {
            return (ch1 == ch2);
        }

        private bool IsItTheLastLetter()
        {
            return (Counter == TextLength());
        }
        public void KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Counter >= 0)
            {
                form.lblTimer.Visible = true;
                form.timer1.Enabled = true;
                form.lblTimer.Text = clsTimer.Value.ToString();
                form.pbRestart.Visible = true;
            }

            MainForm.MyKeyboard.HoverTheButton(sender, e);
            tbText2.Select(Counter, 1);
            char TrueChar = Convert.ToChar(tbText2.SelectedText);
            char EnteredChar = Convert.ToChar(e.KeyChar);
            tbText2.SelectionStart++;

            if (e.KeyChar == '\b')
            {
                Counter--;
                IsBackSpace = true;
                if (Answer[Counter] == true)
                {
                    NumbersOfTrueLetters--;
                }
                else
                {
                    NumbersOfWrongLetters--;
                }
            }

            if(e.KeyChar == ' ')
            {

            }

            else if (IsItTrue(TrueChar, EnteredChar))
            {
                Answer[Counter] = true;
                Counter++;
                NumbersOfTrueLetters++;
            }

            else
            {
                Answer[Counter] = false;
                Counter++;
                NumbersOfWrongLetters++;
            }

            TextColor();
            form.tbText.Select(Counter, 1);
            form.tbText.SelectionBackColor = MainForm.MyColors.SelectionColorOfLetter();
            form.tbText.SelectionColor = MainForm.MyColors.SelectedLetterBackColor();
            MainForm.MyTimer.ProgressBar(IsBackSpace);
            IsBackSpace = false;
            if (IsItTheLastLetter()) ShowResultsForm();
        }

        public void ShowResultsForm()
        {
            MainForm.MyResults = new clsResults(form);
        }


        
        public void KeyUp(object sender, KeyEventArgs e)
        {
            MainForm.MyKeyboard.ButtonNormalColor(sender, e);
        }

    }
}
