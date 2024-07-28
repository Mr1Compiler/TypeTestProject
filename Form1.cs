using Guna.UI2.HtmlRenderer.Adapters;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace TypeTest
{
    public partial class Form1 : Form
    {
        public static RichTextBox tbText2 = new RichTextBox();
        public static int Counter = 0;
        public static bool[] Answer;
        public bool IsArray = true;

        public void TestArray()
        {
            if (IsArray)
            {
                Answer = new bool[tbText2.Text.Length];
            }
            tbText.HideSelection = true;
            tbText.Select(0, 1);
            tbText.SelectionBackColor = Color.FromArgb(192, 192, 0);

            IsArray = false;
        }
        void AddingParaghraph()
        {
            tbText.Text = Paragraphs[GetRandomNumber(0, 10)];
            tbText2.Text = tbText.Text;
        }
        public void MainText()
        {
            AddingParaghraph();
        }
        public Form1()
        {
            InitializeComponent();
            MainText();
            tbText.Focus();
            this.KeyPreview = true;
            TestArray();
        }
        public void Selection(int Counter, int SelectionIndex)
        {
            tbText.Select(Counter, SelectionIndex);
        }

        int GetRandomNumber(int Num1, int Num2)
        {
            Random rand = new Random();
            int RandomNumber = rand.Next(Num1, Num2);

            return RandomNumber;
        }

        string[] Paragraphs =
            { "The quick brown fox jumps over the lazy dog.",
            "A journey of a thousand miles begins with a single step.",
            "To be or not to be, that is the question.",
            "All that glitters is not gold.",
            "A picture is worth a thousand words.",
            "Fortune favors the bold.",
            "The early bird catches the worm.",
            "Actions speak louder than words.",
            "When in Rome, do as the Romans do.",
            "You can lead a horse to water, but you can't make it drink."
            };
        private void btnKeyboard_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button btn = sender as Guna.UI2.WinForms.Guna2Button;
            tbText.Text += btn.Text;
        }

        Color KeyboardHoverColor = Color.Orange;
        Color KeyboardNormalColor = Color.White;
        Guna2Button CuurBtn = null;
        Guna2Button PrevBtn = null;

        bool CheckButtonStatus = true;
        public Guna2Button DetermineButton(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case 'a':
                    return btnA;
                case 'b':
                    return btnB;
                case 'c':
                    return btnC;
                case 'd':
                    return btnD;
                case 'e':
                    return btnE;
                case 'f':
                    return btnF;
                case 'g':
                    return btnG;
                case 'h':
                    return btnH;
                case 'i':
                    return btnI;
                case 'j':
                    return btnJ;
                case 'k':
                    return btnK;
                case 'l':
                    return btnL;
                case 'm':
                    return btnM;
                case 'n':
                    return btnN;
                case 'o':
                    return btnO;
                case 'p':
                    return btnP;
                case 'q':
                    return btnQ;
                case 'r':
                    return btnR;
                case 's':
                    return btnS;
                case 't':
                    return btnT;
                case 'u':
                    return btnU;
                case 'v':
                    return btnV;
                case 'w':
                    return btnW;
                case 'x':
                    return btnX;
                case 'y':
                    return btnY;
                case 'z':
                    return btnZ;
                case '0':
                    return btnNoZero;
                case '1':
                    return btnNoOne;
                case '2':
                    return btnNoTwo;
                case '3':
                    return btnNoThree;
                case '4':
                    return btnNoFour;
                case '5':
                    return btnNoFive;
                case '6':
                    return btnNoSix;
                case '7':
                    return btnNoSeven;
                case '8':
                    return btnNoEight;
                case '9':
                    return btnNoNine;
                case '-':
                    return btnMinus;
                case '=':
                    return btnPluse;
                case ' ':
                    return btnSpace;
                case '\b':
                    return btnBackSpace;
                    //case '':
                    //    return btnControl;
                    //case '':
                    //    return btnAlt1;
                    //case '':
                    //    return btnTab;
                    //case '':
                    //    return btnEnter;
                    //case '':
                    //    return btnCapsLock;
                    //case '':
                    //    return btnLeftCurlyBrace;
                    //case '':
                    //    return btnRightCurlyBrace;
                    //case '':
                    //    return btnColon;
                    //case '':
                    //    return btndDoubleQuotation;
                    //case '':
                    //    return btnQuestionMark;
                    //case '':
                    //    return btnLessThan;
                    //case '':
                    //    return btnGraterThan;
                    //case '':
                    //    return btnTilde;
                    //case '':
                    //    return btnWin1;
                    //case '':
                    //    return btnWin2;
                    //case '':
                    //    return btnControl;
                    //case '':
                    //    return btnControl2;
                    //case '':
                    //    return btnShift;
                    //case '':
                    //    return btnVerticalBar;

            }


            return btnTab;
        }
        public void EditButtonStatus(Guna2Button PrevBtn, Guna2Button CuurBtn)
        {
            if (CuurBtn == PrevBtn)
            {
                // if the user press one button multiple times
            }
            CuurBtn.Checked = true;
            CuurBtn.HoverState.FillColor = KeyboardHoverColor;

            PrevBtn.Checked = true;
            PrevBtn.HoverState.FillColor = KeyboardNormalColor;
        }
        public void TurnTheKeyboard(object sender, KeyPressEventArgs e)
        {
            if (CuurBtn == null)
            {
                PrevBtn = btnEmpty;
            }

            else
            {
                PrevBtn = CuurBtn;
            }

            CuurBtn = DetermineButton(sender, e);
            EditButtonStatus(PrevBtn, CuurBtn);
        }
        public bool IsItTrue(char ch1, char ch2)
        {
            return (ch1 == ch2);
        }

        public void TextColor()
        {
            tbText.Text = tbText2.Text;
            tbText.HideSelection = true;

            for (int i = 0; i < Counter + 1; i++)
            {
                tbText.Select(i, 1);

                if (Answer[i] == true)
                {
                    tbText.SelectionColor = Color.Green;
                }
                
                else if (tbText.Text[Counter] == ' ')
                {
                    tbText.SelectionColor = Color.Red;
                }

                else
                {
                    tbText.SelectionColor = Color.Red;
                }

            }
            tbText.SelectionBackColor = Color.FromArgb(192, 192, 0);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            TurnTheKeyboard(sender, e);
            tbText2.Select(Counter, 1);
            char TrueChar = Convert.ToChar(tbText2.SelectedText);
            char EnteredChar = Convert.ToChar(e.KeyChar);
            tbText2.SelectionStart++;

            if(e.KeyChar == '\b')
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
            tbText.Select(Counter, 1);
            tbText.SelectionColor = Color.Black;
        }
    }
}
