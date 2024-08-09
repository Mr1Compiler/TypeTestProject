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
        public static stMainFormColors _MainFormColors;


        public struct stTextBoxColors
        {
            public Color TextBoxBackColor;
            public Color TextBoxTextColor;
            public Color TrueLetterColor;
            public Color WrongLetterColor;
            public Color SelectedLetterBackColor;
            public Color SelectionColor;
        }
        public static stTextBoxColors TextBoxColors;


        public struct stMenuPanelColors
        {
            public Color MenuPanelBackColor;
        }
        public static stMenuPanelColors MenuPanelColors;


        public struct stKeyboardColors
        {
            public Color KeyboardBackColor;
            public Color KeyboardTextColor;
        }
        public static stKeyboardColors KeyboardColors;

        public struct stListBoxColors
        {
            public Color ListBoxBackColor;
            public Color ListBoxTextColor;
        }
        public static stListBoxColors ListBoxColors;

        public struct stHoverColors
        {
            public Color KeyboardHoverColor;
        }
        public static stHoverColors KeyboardHoverColors;

        public void GenerateColors(MainForm form)
        {
            //MainForm back color
            _MainFormColors.MainFormBackColor = Color.FromArgb(139, 161, 189);
            form.BackColor = _MainFormColors.MainFormBackColor;

            //Textbox colors
            TextBoxColors.TextBoxBackColor = Color.FromArgb(27, 38, 59); // TextBox back color
            form.tbText.BackColor = TextBoxColors.TextBoxBackColor;
            TextBoxColors.TextBoxTextColor = Color.White; // TextBox text color
            form.tbText.ForeColor = TextBoxColors.TextBoxTextColor;
            TextBoxColors.TrueLetterColor = Color.Lime; //TextBox true letter color
            TextBoxColors.WrongLetterColor = Color.Red; //Textbox wrong letter color
            TextBoxColors.SelectedLetterBackColor = Color.White;
            TextBoxColors.SelectionColor = Color.FromArgb(119, 141, 169);

            MenuPanelColors.MenuPanelBackColor = Color.FromArgb(27, 38, 59);
            form.MenuPanel.BackColor = MenuPanelColors.MenuPanelBackColor; //Menu Panel back color

            //Keyboard colors
            KeyboardColors.KeyboardBackColor = Color.FromArgb(27, 38, 59); //keyboard button back color
            KeyboardColors.KeyboardTextColor = Color.White; //Keyboard text color


            //Listbox colors
            ListBoxColors.ListBoxBackColor = Color.FromArgb(27, 38, 59); // listbox back color
            form.listBox1.BackColor = ListBoxColors.ListBoxBackColor;
            ListBoxColors.ListBoxTextColor = Color.White; // listbox text color
            form.listBox1.ForeColor = ListBoxColors.ListBoxTextColor;

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

                    button.FillColor = KeyboardColors.KeyboardBackColor;
                    button.ForeColor = KeyboardColors.KeyboardTextColor;
                }
            }
        }

        public  Color SelectionColorOfLetter()
        {
            return TextBoxColors.SelectionColor;
        }

        public  Color SelectedLetterBackColor()
        {
            return TextBoxColors.SelectedLetterBackColor;
        }

        public static Color HoverButtonColor(ref Color KeyboardHoverColor, ref Color KeyboardNormalColor)
        {

            KeyboardHoverColor = KeyboardHoverColors.KeyboardHoverColor;
            KeyboardNormalColor = KeyboardColors.KeyboardBackColor;

            return KeyboardHoverColor;
        }

        public Color ColoringTrueLetter()
        {
            return TextBoxColors.TrueLetterColor;
        }

        public  Color ColoringWrongLetter()
        {
            return TextBoxColors.WrongLetterColor;
        }
    }
}
