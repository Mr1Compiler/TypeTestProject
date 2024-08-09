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
using Telerik.WinControls.UI;
using TypeTest.Colors;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace TypeTest.Keyboard
{
    public class clsKeyboard
    {
        private MainForm _Form;

        Guna2Button CuurBtn = null;
        Guna2Button PrevBtn = null;
        Color KeyboardHoverColor;
        Color KeyboardNormalColor;
        clsColors MyColors;
        public clsKeyboard(MainForm Form)
        {
            _Form = Form;
            MyColors = new clsColors(_Form);
            MyColors.HoverButtonColor(ref KeyboardHoverColor, ref KeyboardNormalColor);
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
            }
            return new Guna2Button();
        }
        public void TurnTheKeyboard(object sender, KeyPressEventArgs e)
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



            CuurBtn = DetermineButton(sender, e);

            CuurBtn.FillColor = KeyboardHoverColor;
            PrevBtn.FillColor = KeyboardNormalColor;
        }
    }
}
