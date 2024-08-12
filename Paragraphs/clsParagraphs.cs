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
using TypeTest.Keyboard;
using TypeTest.Settings.Timer;

namespace TypeTest.Paragraphs
{
    public class clsParagraphs
    {
        MainForm form;
        public static string _ShowenParagraph = "";
        private int _TotalNumberOfParagraphs = 10;
        private RichTextBox tbText2 = new RichTextBox();
        private int Counter = 0;
        private bool[] Answer;
        private bool IsArray = true;
        public clsParagraphs(MainForm Form) 
        { 
            
            form = Form;
            form.tbText.Text = GetRandomParagraph();
            tbText2.Text = form.tbText.Text;
            TestArray();
            
        }

        public static int TextLength()
        {
            return _ShowenParagraph.Length;
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
            return _ShowenParagraph = Paragraphs(GetRandomNumber(0,_TotalNumberOfParagraphs));
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
            }

            else if (IsItTrue(TrueChar, EnteredChar))
            {
                Answer[Counter] = true;
                Counter++;

            }

            else
            {
                Answer[Counter] = false;
                Counter++;
            }

            TextColor();
            form.tbText.Select(Counter, 1);
            form.tbText.SelectionBackColor = MainForm.MyColors.SelectionColorOfLetter();
            form.tbText.SelectionColor = MainForm.MyColors.SelectedLetterBackColor();
            MainForm.MyTimer.ProgressBar();

            if (IsItTheLastLetter()) EndOfText();
        }

        public void EndOfText()
        {
            form.timer1.Enabled = false;
            form.tbText.Enabled = false;
            form.KeyPreview = false;
            MessageBox.Show("The end");
        }

        public void KeyUp(object sender, KeyEventArgs e)
        {
            MainForm.MyKeyboard.ButtonNormalColor(sender, e);
        }

    }
}
