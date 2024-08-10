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

using TypeTest.Colors;
using TypeTest.Keyboard;

namespace TypeTest.Colors 
{
    public class clsColors
    {
        private MainForm _Form;
        public struct stMainFormColors
        {
            public Color MainFormBackColor;
        }
        private stMainFormColors _MainFormColors;


        private struct stTextBoxColors
        {
            public Color TextBoxBackColor;
            public Color TextBoxTextColor;
            public Color TrueLetterColor;
            public Color WrongLetterColor;
            public Color SelectedLetterBackColor;
            public Color SelectionColor;
        }
        private stTextBoxColors _TextBoxColors;


        public struct stMenuPanelColors
        {
            public Color MenuPanelBackColor;
        }
        private stMenuPanelColors _MenuPanelColors;


        public struct stKeyboardColors
        {
            public Color KeyboardBackColor;
            public Color KeyboardTextColor;
        }
        private stKeyboardColors _KeyboardColors;

        public struct stListBoxColors
        {
            public Color ListBoxBackColor;
            public Color ListBoxTextColor;
        }
        private stListBoxColors _ListBoxColors;

        public struct stHoverColors
        {
            public Color KeyboardHoverColor;
        }
        private stHoverColors _KeyboardHoverColors;

        public void GenerateColors(MainForm form)
        {
            //MainForm back color
            _MainFormColors.MainFormBackColor = Color.FromArgb(139, 161, 189);
            form.BackColor = _MainFormColors.MainFormBackColor;

            //Textbox colors
            _TextBoxColors.TextBoxBackColor = Color.FromArgb(27, 38, 59); // TextBox back color
            form.tbText.BackColor = _TextBoxColors.TextBoxBackColor;
            _TextBoxColors.TextBoxTextColor = Color.White; // TextBox text color
            form.tbText.ForeColor = _TextBoxColors.TextBoxTextColor;
            _TextBoxColors.TrueLetterColor = Color.Lime; //TextBox true letter color
            _TextBoxColors.WrongLetterColor = Color.Red; //Textbox wrong letter color
            _TextBoxColors.SelectedLetterBackColor = Color.White;
            _TextBoxColors.SelectionColor = Color.FromArgb(119, 141, 169);

            _MenuPanelColors.MenuPanelBackColor = Color.FromArgb(27, 38, 59);
            form.MenuPanel.BackColor = _MenuPanelColors.MenuPanelBackColor; //Menu Panel back color

            //Keyboard colors
            _KeyboardColors.KeyboardBackColor = Color.FromArgb(27, 38, 59); //keyboard button back color
            _KeyboardColors.KeyboardTextColor = Color.White; //Keyboard text color


            //Listbox colors
            _ListBoxColors.ListBoxBackColor = Color.FromArgb(27, 38, 59); // listbox back color
            form.listBox1.BackColor = _ListBoxColors.ListBoxBackColor;
            _ListBoxColors.ListBoxTextColor = Color.White; // listbox text color
            form.listBox1.ForeColor = _ListBoxColors.ListBoxTextColor;

        }

        public clsColors(MainForm Form)
        {
            _Form = Form;
            GenerateColors(_Form);
            SetKeyboardColors();
        }
        public void SetKeyboardColors()
        {
            _Form.KeyboardPanel.BackColor = _Form.BackColor;

            foreach (Control control in _Form.KeyboardPanel.Controls)
            {
                if (control is Guna2Button button)
                {

                    button.FillColor = _KeyboardColors.KeyboardBackColor;
                    button.ForeColor = _KeyboardColors.KeyboardTextColor;
                }
            }
        }

        public Color SelectionColorOfLetter()
        {
            return _TextBoxColors.SelectionColor;
        }

        public Color SelectedLetterBackColor()
        {
            return _TextBoxColors.SelectedLetterBackColor;
        }

        public Color HoverButton()
        {
            return _KeyboardHoverColors.KeyboardHoverColor;
        }
        public Color HoverButtonColor(ref Color KeyboardHoverColor, ref Color KeyboardNormalColor)
        {

            KeyboardHoverColor = _KeyboardHoverColors.KeyboardHoverColor;
            KeyboardNormalColor = _KeyboardColors.KeyboardBackColor;

            return KeyboardHoverColor;
        }

        public Color ColoringTrueLetter()
        {
            return _TextBoxColors.TrueLetterColor;
        }

        public  Color ColoringWrongLetter()
        {
            return _TextBoxColors.WrongLetterColor;
        }
    }
}
