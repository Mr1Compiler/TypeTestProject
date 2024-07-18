using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypeTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tbText.Text = Paragraphs[GetRandomNumber(0, 10)];
            
            
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
        public Guna2Button DetermineButton(object sender, KeyEventArgs e)
        { 
            switch (e.KeyValue)
            {
                case (char)Keys.A:
                    return btnA;
                case (char)Keys.B:
                    return btnB;
                case (char)Keys.C:
                    return btnC;
                case (char)Keys.D:
                    return btnD;
                case (char)Keys.E:
                    return btnE;
                case (char)Keys.F:
                    return btnF;
                case (char)Keys.G:
                    return btnG;
                case (char)Keys.H:
                    return btnH;
                case (char)Keys.I:
                    return btnI;
                case (char)Keys.J:
                    return btnJ;
                case (char)Keys.K:
                    return btnK;
                case (char)Keys.L:
                    return btnL;
                case (char)Keys.M:
                    return btnM;
                case (char)Keys.N:
                    return btnN;
                case (char)Keys.O:
                    return btnO;
                case (char)Keys.P:
                    return btnP;
                case (char)Keys.Q:
                    return btnQ;
                case (char)Keys.R:
                    return btnR;
                case (char)Keys.S:
                    return btnS;
                case (char)Keys.T:
                    return btnT;
                case (char)Keys.U:
                    return btnU;
                case (char)Keys.V:
                    return btnV;
                case (char)Keys.W:
                    return btnW;
                case (char)Keys.X:
                    return btnX;
                case (char)Keys.Y:
                    return btnY;
                case (char)Keys.Z:
                    return btnZ;
                case (char)Keys.D0:
                    return btnNoZero;
                case (char)Keys.D1:
                    return btnNoOne;
                case (char)Keys.D2:
                    return btnNoTwo;
                case (char)Keys.D3:
                    return btnNoThree;
                case (char)Keys.D4:
                    return btnNoFour;
                case (char)Keys.D5:
                    return btnNoFive;
                case (char)Keys.D6:
                    return btnNoSix;
                case (char)Keys.D7:
                    return btnNoSeven;
                case (char)Keys.D8:
                    return btnNoEight;
                case (char)Keys.D9:
                    return btnNoNine;
                case (char)Keys.OemMinus:
                    return btnMinus;
                case (char)Keys.Oemplus:
                    return btnPluse;
                case (char)Keys.Space:
                    return btnSpace;
                case (char)Keys.Back:
                    return btnBackSpace;
                case (char)Keys.ControlKey:
                    return btnControl;
                case (char)Keys.Menu:
                    return btnAlt1;
                case (char)Keys.Tab:
                    return btnTab;
                case (char)Keys.Enter:
                    return btnEnter;
                case (char)Keys.CapsLock:
                    return btnCapsLock;
                case (char)Keys.OemOpenBrackets:
                    return btnLeftCurlyBrace;
                case (char)Keys.OemCloseBrackets:
                    return btnRightCurlyBrace;
                case (char)Keys.OemSemicolon:
                    return btnColon;
                case (char)Keys.OemQuotes:
                    return btndDoubleQuotation;
                case (char)Keys.OemQuestion:
                    return btnQuestionMark;
                case (char)Keys.Oemcomma:
                    return btnLessThan;
                case (char)Keys.OemPeriod:
                    return btnGraterThan;
                case (char)Keys.Oem3:
                    return btnTilde;
                case (char)Keys.LWin:
                    return btnWin1;
                case (char)Keys.RWin:
                    return btnWin2;
                case (char)Keys.LControlKey:
                    return btnControl;
                case (char)Keys.RControlKey:
                    return btnControl2;
                case (char)Keys.ShiftKey:
                    return btnShift;
                case (char)Keys.OemPipe:
                    return btnVerticalBar;

            }

            return btnSpace;
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
        private void tbText_KeyDown(object sender, KeyEventArgs e)
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

        private void tbText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
