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
using Telerik.WinControls.UI;
using TypeTest.Colors;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace TypeTest.Keyboard
{
    public class clsKeyboard
    {
        private MainForm _Form;

        Guna2Button CuurBtn;
        Guna2Button PrevBtn;
        Color KeyboardHoverColor;
        Color KeyboardNormalColor;
        clsColors MyColors;
        public clsKeyboard(MainForm Form)
        {
            _Form = Form;
            MyColors = new clsColors(_Form);
            MyColors.HoverButtonColor(ref KeyboardHoverColor, ref KeyboardNormalColor);
        }

        private Guna2Button DetermineOFFButton(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case(char)Keys.A:
                    return _Form.btnA;
                case (char)Keys.B:
                    return _Form.btnB;
                case (char)Keys.C:
                    return _Form.btnC;
                case (char)Keys.D:
                    return _Form.btnD;
                case (char)Keys.E:
                    return _Form.btnE;
                case (char)Keys.F:
                    return _Form.btnF;
                case (char)Keys.G:
                    return _Form.btnG;
                case (char)Keys.H:
                    return _Form.btnH;
                case (char)Keys.I:
                    return _Form.btnI;
                case (char)Keys.J:
                    return _Form.btnJ;
                case (char)Keys.K:
                    return _Form.btnK;
                case (char)Keys.L:
                    return _Form.btnL;
                case (char)Keys.M:
                    return _Form.btnM;
                case (char)Keys.N:
                    return _Form.btnN;
                case (char)Keys.O:
                    return _Form.btnO;
                case (char)Keys.P:
                    return _Form.btnP;
                case (char)Keys.Q:
                    return _Form.btnQ;
                case (char)Keys.R:
                    return _Form.btnR;
                case (char)Keys.S:
                    return _Form.btnS;
                case (char)Keys.T:
                    return _Form.btnT;
                case (char)Keys.U:
                    return _Form.btnU;
                case (char)Keys.V:
                    return _Form.btnV;
                case (char)Keys.W:
                    return _Form.btnW;
                case (char)Keys.X:
                    return _Form.btnX;
                case (char)Keys.Y:
                    return _Form.btnY;
                case (char)Keys.Z:
                    return _Form.btnZ;
                case (char)Keys.D0:
                    return _Form.btnNoZero;
                case (char)Keys.D1:
                    return _Form.btnNoOne;
                case (char)Keys.D2:
                    return _Form.btnNoTwo;
                case (char)Keys.D3:
                    return _Form.btnNoThree;
                case (char)Keys.D4:
                    return _Form.btnNoFour;
                case (char)Keys.D5:
                    return _Form.btnNoFive;
                case (char)Keys.D6:
                    return _Form.btnNoSix;
                case (char)Keys.D7:
                    return _Form.btnNoSeven;
                case (char)Keys.D8:
                    return _Form.btnNoEight;
                case (char)Keys.D9:
                    return _Form.btnNoNine;
                case (char)Keys.OemMinus:
                    return _Form.btnMinus;
                case (char)Keys.Oemplus:
                    return _Form.btnPluse;
                case (char)Keys.Space:
                        return _Form.btnSpace;
                case (char)Keys.Back:
                    return _Form.btnBackSpace;
                case (char)Keys.ControlKey:
                    return _Form.btnControl;
                case (char)Keys.Menu:
                    return _Form.btnAlt1;
                case (char)Keys.Tab:
                    return _Form.btnTab;
                case (char)Keys.Enter:
                    return _Form.btnEnter;
                case (char)Keys.CapsLock:
                    return _Form.btnCapsLock;
                case (char)Keys.OemOpenBrackets:
                    return _Form.btnLeftCurlyBrace;
                case (char)Keys.OemCloseBrackets:
                    return _Form.btnRightCurlyBrace;
                case (char)Keys.OemSemicolon:
                    return _Form.btnColon;
                case (char)Keys.OemQuotes:
                    return _Form.btndDoubleQuotation;
                case (char)Keys.OemQuestion:
                    return _Form.btnQuestionMark;
                case (char)Keys.Oemcomma:
                    return _Form.btnLessThan;
                case (char)Keys.OemPeriod:
                    return _Form.btnGraterThan;
                case (char)Keys.Oem3:
                    return _Form.btnTilde;
                case (char)Keys.LWin:
                    return _Form.btnWin1;
                case (char)Keys.RWin:
                    return _Form.btnWin2;
                case (char)Keys.LControlKey:
                    return _Form.btnControl;
                case (char)Keys.RControlKey:
                    return _Form.btnControl2;
                case (char)Keys.ShiftKey: 
                        return _Form.btnShift;
                case (char)Keys.OemPipe:
                    return _Form.btnVerticalBar;

            }
            return _Form.btnEmpty;
        }

        private Guna2Button DetermineButton(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {          
                case 'a':
                    return _Form.btnA;
                case 'b':
                    return _Form.btnB;
                case 'c':
                    return _Form.btnC;
                case 'd':
                    return _Form.btnD;
                case 'e':
                    return _Form.btnE;
                case 'f':
                    return _Form.btnF;
                case 'g':
                    return _Form.btnG;
                case 'h':
                    return _Form.btnH;
                case 'i':
                    return _Form.btnI;
                case 'j':
                    return _Form.btnJ;
                case 'k':
                    return _Form.btnK;
                case 'l':
                    return _Form.btnL;
                case 'm':
                    return _Form.btnM;
                case 'n':
                    return _Form.btnN;
                case 'o':
                    return _Form.btnO;
                case 'p':
                    return _Form.btnP;
                case 'q':
                    return _Form.btnQ;
                case 'r':
                    return _Form.btnR;
                case 's':
                    return _Form.btnS;
                case 't':
                    return _Form.btnT;
                case 'u':
                    return _Form.btnU;
                case 'v':
                    return _Form.btnV;
                case 'w':
                    return _Form.btnW;
                case 'x':
                    return _Form.btnX;
                case 'y':
                    return _Form.btnY;
                case 'z':
                    return _Form.btnZ;
                case '0':
                    return _Form.btnNoZero;
                case '1':
                    return _Form.btnNoOne;
                case '2':
                    return _Form.btnNoTwo;
                case '3':
                    return _Form.btnNoThree;
                case '4':
                    return _Form.btnNoFour;
                case '5':
                    return _Form.btnNoFive;
                case '6':
                    return _Form.btnNoSix;
                case '7':
                    return _Form.btnNoSeven;
                case '8':
                    return _Form.btnNoEight;
                case '9':
                    return _Form.btnNoNine;
                case '-':
                    return _Form.btnMinus;
                case '=':
                    return _Form.btnPluse;
                case ' ':
                     return _Form.btnSpace;
                case '\b':
                    return _Form.btnBackSpace;
                case '\'':
                    return _Form.btndDoubleQuotation;
                case ';':
                    return _Form.btnColon;
                case '[':
                    return _Form.btnLeftCurlyBrace;
                case ']':
                    return _Form.btnRightCurlyBrace;
                case '\\':
                    return _Form.btnVerticalBar;
                case '/':
                    return _Form.btnQuestionMark;
                case ',':
                    return _Form.btnLessThan;
                case '.':
                    return _Form.btnGraterThan;
            }
            return _Form.btnEmpty;
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
                PrevBtn = _Form.btnEmpty;
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
