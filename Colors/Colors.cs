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
using Telerik.WinControls.Themes.ControlDefault;
using Telerik.WinControls.UI;
using TypeTest.Colors;

namespace TypeTest.Colors 
{
    public class clsColors 
    {
        private MainForm _Form;
        public clsColors(MainForm Form)
        {
            _Form = Form;
            //MainForm Colors
            _Form.BackColor = Color.FromArgb(139, 161, 189);

            //MenuPanel Colors
            _Form.MenuPanel.BackColor = Color.FromArgb(27, 38, 59);

            //ListBox colors
            _Form.listBox1.BackColor = Color.FromArgb(27, 38, 59);
            _Form.listBox1.ForeColor = Color.White;

            //TextBox Colors
            _Form.tbText.BackColor = Color.FromArgb(27, 38, 59);
            _Form.tbText.ForeColor = Color.White;

            //Keyboard Colors
            SetKeyboardColors(_Form.KeyboardPanel);
        }
        public void SetKeyboardColors(Guna2Panel KeyBoardPanel)
        {
            KeyBoardPanel.BackColor = _Form.BackColor;

            foreach (Control control in KeyBoardPanel.Controls)
            {
                if (control is Guna2Button button)
                {
                    button.FillColor = _Form.MenuPanel.BackColor;
                    button.ForeColor = Color.White;
                }
            }
        }

        public static Color SelectionColorOfLetter()
        {
            return Color.FromArgb(119, 141, 169);
        }
        
        public static Color SelectedLetterBackColor()
        {
            return Color.White;
        }
    }

}
