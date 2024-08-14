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
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using TypeTest.Colors;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace TypeTest.Keyboard
{
    public class clsKeyboard
    {
        MainForm form;

        Guna2Button CuurBtn;
        Guna2Button PrevBtn;
        Color KeyboardHoverColor;
        Color KeyboardNormalColor;
        public clsKeyboard(MainForm Form)
        {
            form = Form;
            MainForm.MyColors.HoverButtonColor(ref KeyboardHoverColor, ref KeyboardNormalColor);
        }

        private Guna2Button DetermineOFFButton(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case(char)Keys.A:
                    return form.btnA;
                case (char)Keys.B:
                    return form.btnB;
                case (char)Keys.C:
                    return form.btnC;
                case (char)Keys.D:
                    return form.btnD;
                case (char)Keys.E:
                    return form.btnE;
                case (char)Keys.F:
                    return form.btnF;
                case (char)Keys.G:
                    return form.btnG;
                case (char)Keys.H:
                    return form.btnH;
                case (char)Keys.I:
                    return form.btnI;
                case (char)Keys.J:
                    return form.btnJ;
                case (char)Keys.K:
                    return form.btnK;
                case (char)Keys.L:
                    return form.btnL;
                case (char)Keys.M:
                    return form.btnM;
                case (char)Keys.N:
                    return form.btnN;
                case (char)Keys.O:
                    return form.btnO;
                case (char)Keys.P:
                    return form.btnP;
                case (char)Keys.Q:
                    return form.btnQ;
                case (char)Keys.R:
                    return form.btnR;
                case (char)Keys.S:
                    return form.btnS;
                case (char)Keys.T:
                    return form.btnT;
                case (char)Keys.U:
                    return form.btnU;
                case (char)Keys.V:
                    return form.btnV;
                case (char)Keys.W:
                    return form.btnW;
                case (char)Keys.X:
                    return form.btnX;
                case (char)Keys.Y:
                    return form.btnY;
                case (char)Keys.Z:
                    return form.btnZ;
                case (char)Keys.D0:
                    return form.btnNoZero;
                case (char)Keys.D1:
                    return form.btnNoOne;
                case (char)Keys.D2:
                    return form.btnNoTwo;
                case (char)Keys.D3:
                    return form.btnNoThree;
                case (char)Keys.D4:
                    return form.btnNoFour;
                case (char)Keys.D5:
                    return form.btnNoFive;
                case (char)Keys.D6:
                    return form.btnNoSix;
                case (char)Keys.D7:
                    return form.btnNoSeven;
                case (char)Keys.D8:
                    return form.btnNoEight;
                case (char)Keys.D9:
                    return form.btnNoNine;
                case (char)Keys.OemMinus:
                    return form.btnMinus;
                case (char)Keys.Oemplus:
                    return form.btnPluse;
                case (char)Keys.Space:
                        return form.btnSpace;
                case (char)Keys.Back:
                    return form.btnBackSpace;
                case (char)Keys.ControlKey:
                    return form.btnControl;
                case (char)Keys.Menu:
                    return form.btnAlt1;
                case (char)Keys.Tab:
                    return form.btnTab;
                case (char)Keys.Enter:
                    return form.btnEnter;
                case (char)Keys.CapsLock:
                    return form.btnCapsLock;
                case (char)Keys.OemOpenBrackets:
                    return form.btnLeftCurlyBrace;
                case (char)Keys.OemCloseBrackets:
                    return form.btnRightCurlyBrace;
                case (char)Keys.OemSemicolon:
                    return form.btnColon;
                case (char)Keys.OemQuotes:
                    return form.btndDoubleQuotation;
                case (char)Keys.OemQuestion:
                    return form.btnQuestionMark;
                case (char)Keys.Oemcomma:
                    return form.btnLessThan;
                case (char)Keys.OemPeriod:
                    return form.btnGraterThan;
                case (char)Keys.Oem3:
                    return form.btnTilde;
                case (char)Keys.LWin:
                    return form.btnWin1;
                case (char)Keys.RWin:
                    return form.btnWin2;
                case (char)Keys.LControlKey:
                    return form.btnControl;
                case (char)Keys.RControlKey:
                    return form.btnControl2;
                case (char)Keys.ShiftKey: 
                        return form.btnShift;
                case (char)Keys.OemPipe:
                    return form.btnVerticalBar;

            }
            return form.btnEmpty;
        }

        private Guna2Button DetermineButton(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {          
                case 'a':
                    return form.btnA;
                case 'b':
                    return form.btnB;
                case 'c':
                    return form.btnC;
                case 'd':
                    return form.btnD;
                case 'e':
                    return form.btnE;
                case 'f':
                    return form.btnF;
                case 'g':
                    return form.btnG;
                case 'h':
                    return form.btnH;
                case 'i':
                    return form.btnI;
                case 'j':
                    return form.btnJ;
                case 'k':
                    return form.btnK;
                case 'l':
                    return form.btnL;
                case 'm':
                    return form.btnM;
                case 'n':
                    return form.btnN;
                case 'o':
                    return form.btnO;
                case 'p':
                    return form.btnP;
                case 'q':
                    return form.btnQ;
                case 'r':
                    return form.btnR;
                case 's':
                    return form.btnS;
                case 't':
                    return form.btnT;
                case 'u':
                    return form.btnU;
                case 'v':
                    return form.btnV;
                case 'w':
                    return form.btnW;
                case 'x':
                    return form.btnX;
                case 'y':
                    return form.btnY;
                case 'z':
                    return form.btnZ;
                case '0':
                    return form.btnNoZero;
                case '1':
                    return form.btnNoOne;
                case '2':
                    return form.btnNoTwo;
                case '3':
                    return form.btnNoThree;
                case '4':
                    return form.btnNoFour;
                case '5':
                    return form.btnNoFive;
                case '6':
                    return form.btnNoSix;
                case '7':
                    return form.btnNoSeven;
                case '8':
                    return form.btnNoEight;
                case '9':
                    return form.btnNoNine;
                case '-':
                    return form.btnMinus;
                case '=':
                    return form.btnPluse;
                case ' ':
                     return form.btnSpace;
                case '\b':
                    return form.btnBackSpace;
                case '\'':
                    return form.btndDoubleQuotation;
                case ';':
                    return form.btnColon;
                case '[':
                    return form.btnLeftCurlyBrace;
                case ']':
                    return form.btnRightCurlyBrace;
                case '\\':
                    return form.btnVerticalBar;
                case '/':
                    return form.btnQuestionMark;
                case ',':
                    return form.btnLessThan;
                case '.':
                    return form.btnGraterThan;
            }
            return form.btnEmpty;
        }
        private void AssignButton()
        {
            CuurBtn.FillColor = KeyboardHoverColor;
            PrevBtn.FillColor = KeyboardNormalColor;
        }

        private void CheckButton()
        {
            if (CuurBtn == null)
            {
                //I put an empty button in Form so i can handle that
                PrevBtn = form.btnEmpty;
            }
            else
            {
                PrevBtn = CuurBtn;
            }
        }
        public void HoverTheButton(object sender, KeyPressEventArgs e)
        {
            CheckButton();
            CuurBtn = DetermineButton(sender, e);
            AssignButton();
        }

        public void ButtonNormalColor(object sender, KeyEventArgs e)
        {
            CheckButton();
            CuurBtn = DetermineOFFButton(sender, e);
            AssignButton();
        }
    }
}
