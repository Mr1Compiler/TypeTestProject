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

        public struct stSettingsPanel
        {
            public Color SettingsPanelBackground;
            public Color ButtonsBackColor1;
            public Color ButtonBackColor2;
            public Color ButtonTextColor;
        }
        private stSettingsPanel _SettingsPanelColors;

        public struct stHoverColors
        {
            public Color KeyboardHoverColor;
        }
        private stHoverColors _KeyboardHoverColors;

        public void GenerateColors(MainForm form)
        {
            //MainForm back color
            _MainFormColors.MainFormBackColor = Color.FromArgb(233, 236, 239);
            form.BackColor = _MainFormColors.MainFormBackColor;

            //Textbox colors
            _TextBoxColors.TextBoxBackColor = Color.FromArgb(33, 37, 41); // TextBox back color
            form.tbText.BackColor = _TextBoxColors.TextBoxBackColor;
            _TextBoxColors.TextBoxTextColor = Color.White; // TextBox text color
            form.tbText.ForeColor = _TextBoxColors.TextBoxTextColor;
            _TextBoxColors.TrueLetterColor = Color.Lime; //TextBox true letter color
            _TextBoxColors.WrongLetterColor = Color.Red; //Textbox wrong letter color
            _TextBoxColors.SelectedLetterBackColor = Color.White;
            _TextBoxColors.SelectionColor = Color.FromArgb(119, 141, 169);

            _MenuPanelColors.MenuPanelBackColor = Color.FromArgb(33, 37, 41);
            form.MenuPanel.BackColor = _MenuPanelColors.MenuPanelBackColor; //Menu Panel back color

            //Keyboard colors
            _KeyboardColors.KeyboardBackColor = Color.FromArgb(33, 37, 41);//Color.FromArgb(27, 38, 59); //keyboard button back color
            _KeyboardColors.KeyboardTextColor = Color.White; //Keyboard text color

            //Settings panel
            form.lblVersion.ForeColor = Color.FromArgb(233, 236, 239);
            _SettingsPanelColors.SettingsPanelBackground = Color.FromArgb(33, 37, 41);
            form.SettingsPanel.FillColor = _SettingsPanelColors.SettingsPanelBackground;
            form.SettingsPanel.FillColor2 = _SettingsPanelColors.SettingsPanelBackground;
            form.SettingsPanel.FillColor3 = _SettingsPanelColors.SettingsPanelBackground;
            form.SettingsPanel.FillColor4 = _SettingsPanelColors.SettingsPanelBackground;
            _SettingsPanelColors.ButtonsBackColor1 = Color.FromArgb(33, 37, 41);
            _SettingsPanelColors.ButtonBackColor2 = Color.FromArgb(233, 236, 239);
            SettingsButtonsColors(ref form.btnColorsSettings);
            SettingsButtonsColors(ref form.btnFontSettings);


            form.menuStrip1.BackColor = Color.FromArgb(33, 37, 41);
            form.menuStrip1.ForeColor = Color.FromArgb(233, 236, 239);

        }

        private void SettingsButtonsColors(ref Guna2GradientButton btn)
        {
            btn.FillColor = _SettingsPanelColors.ButtonsBackColor1;
            btn.FillColor = _SettingsPanelColors.ButtonBackColor2;
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
