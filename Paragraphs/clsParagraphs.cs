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
using TypeTest.Results;
using TypeTest.Settings.Timer;
using TypeTest.Paragraphs;

namespace TypeTest.Paragraphs
{
    public class clsParagraphs
    {
        MainForm form = null;
        public string ShowenParagraph = "";
        private string _PrevParagraph = "";
        private int _TotalNumberOfParagraphs;
        private int RightWords;
        public static int TotalWords;
        private RichTextBox tbText2;
        private int Counter;
        private bool[] Answer;
        private bool IsArray = false;
        public static int NumbersOfTrueLetters;
        public static int NumbersOfWrongLetters;
        public bool IsBackSpace = false;
        public static bool CustomText = false;
        public static string CustomParagraph = "";

        public clsParagraphs(MainForm Form)
        {
            form = Form;
            tbText2 = new RichTextBox();
            _TotalNumberOfParagraphs = Texts.Paragraphs.Length;
            RightWords = 0;
            TotalWords = 0;
            Counter = 0;
            IsArray = true;
            NumbersOfTrueLetters = 0;
            NumbersOfWrongLetters = 0;
            IsBackSpace = false;
            

            if (CustomText)
            {
                ShowenParagraph = CustomParagraph;
            }
            else
            {
                if (MainForm.SameText)
                {
                    ShowenParagraph = form.tbText.Text;
                }
                else
                {
                    GetRandomParagraph();
                    _PrevParagraph = ShowenParagraph;
                }
            }

            form.tbText.Text = ShowenParagraph;
            tbText2.Text = ShowenParagraph;
            TestArray();
        }
        public void AsiggnNewParagraph(string Paragraph)
        {
            form.CustomText(Paragraph);
        }
        public clsParagraphs(MainForm form,string Paragraph)
        {
            tbText2 = new RichTextBox();
            _TotalNumberOfParagraphs = Texts.Paragraphs.Length;
            RightWords = 0;
            TotalWords = 0;
            Counter = 0;
            IsArray = true;
            NumbersOfTrueLetters = 0;
            NumbersOfWrongLetters = 0;
            IsBackSpace = false;

            if (MainForm.SameText)
            {
                ShowenParagraph = form.tbText.Text;
            }
            else
            {
                ShowenParagraph = Paragraph;
                _PrevParagraph = ShowenParagraph;
            }

            form.tbText.Text = ShowenParagraph;
            tbText2.Text = ShowenParagraph;
            TestArray();
        }
        public int NumberOfRightWords()
        {
            return RightWords;
        }
        public void AnotherParagragh()
        {
            MainForm.MyColors.SetKeyboardColors();
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
            return Texts.Paragraphs[Index];
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
        public void TextColor(ref RichTextBox tb)
        {
            tb.Text = ShowenParagraph;
            tb.HideSelection = true;

            MainForm.MyColors.ColoringTextBox(ref tb);

            for (int i = 0; i < Counter + 1; i++)
            {
                tb.Select(i, 1);

                if (Answer[i] == true)
                {
                    tb.SelectionColor = MainForm.MyColors.ColoringTrueLetter();
                }

                else
                {
                    tb.SelectionColor = MainForm.MyColors.ColoringWrongLetter();
                }
            }
           // tb.SelectionBackColor = MainForm.MyColors.SelectedLetterBackColor();
        }
        public void TextColor()
        {
            form.tbText.Text = tbText2.Text;
            form.tbText.HideSelection = true;

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
                form.lblTimer.Text = clsTimer.TimerValue.ToString();
                form.pbRestart.Visible = true;
            }

            MainForm.MyKeyboard.HoverTheButton(sender, e);
            tbText2.Select(Counter, 1);
            char TrueChar = Convert.ToChar(tbText2.SelectedText);
            char EnteredChar = Convert.ToChar(e.KeyChar);
            tbText2.SelectionStart++;


            if (e.KeyChar == '\b' )
            {
                if (Counter == 0)
                {
                    form.ProgressBar.Value = 0;
                }
                else
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
        public void KeyUp(object sender, KeyEventArgs e)
        {
            MainForm.MyKeyboard.ButtonNormalColor(sender, e);
        }
        private void IsAllLettersRight()
        {
            int AnsCounter = 0;
            string[] Words = ShowenParagraph.Split(' ');
            bool[] CheckWord;
            TotalWords = Words.Length;

            for (int i = 0; i < Words.Length; i++)
            {
                CheckWord = new bool[Words[i].Length];

                for (int j = 0; j < Words[i].Length; j++)
                {

                    if (Answer[AnsCounter] == false)
                    {
                        CheckWord[j] = false;
                    }
                    else
                        CheckWord[j] = true;

                    AnsCounter++;
                }
                AnsCounter++;

                if (!CheckWord.Contains(false))
                    RightWords++;
            }

        }          
        public void ShowResultsForm()
        {
            IsAllLettersRight();
            frmResults Result = new frmResults();
            Result.ShowDialog();

        }


    }
}
