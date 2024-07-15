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
        }
        private void btnKeyboard_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button btn = sender as Guna.UI2.WinForms.Guna2Button;
        }

        Color KeyboardHoverColor = Color.Orange;
        Color KeyboardNormalColor = Color.White;

        bool CheckButtonStatus = false;
        public Guna2Button DetermineButton(KeyEventArgs e)
        {
            if (CheckButtonStatus == false)
            {
                CheckButtonStatus = true;
            }
            else
                CheckButtonStatus = false;

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
                case (char)Keys.Space:
                    return btnSpace;
            }

            return btnAlt1;
        }


        public void EditButtonStatus(Guna2Button btn)
        {
            btn.Checked = CheckButtonStatus;

            if(btn.Checked == true)
            {
                btn.HoverState.FillColor = KeyboardHoverColor;
            }
            else
                btn.HoverState.FillColor = KeyboardNormalColor;
        }

        private void tbText_KeyDown(object sender, KeyEventArgs e)
        {
            Guna2Button btn = DetermineButton(e);

            EditButtonStatus(btn);

        }

    }
}
