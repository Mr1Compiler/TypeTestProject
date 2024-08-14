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
using TypeTest.Results;

namespace TypeTest.Colors
{
    public class clsColors
    {
        private MainForm _Form;
        public struct stMainFormColors
        {
            public Color BackColor;
        }
        private stMainFormColors _MainFormColors;

        private struct stTextBoxColors
        {
            public Color BackColor;
            public Color TextColor;
            public Color TrueLetterColor;
            public Color WrongLetterColor;
            public Color SelectedLetterBackColor;
            public Color SelectionColor;
        }
        private stTextBoxColors _TextBoxColors;

        public struct stMenuPanelColors
        {
            public Color BackColor;
        }
        private stMenuPanelColors _MenuPanelColors;

        public struct stKeyboardColors
        {
            public Color BackColor;
            public Color TextColor;
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

        public struct stMenuStrip
        {
            public Color BackColor;
            public Color ForeColor;
        }
        public void GenerateColors(MainForm form)
        {
            //MainForm back color
            _MainFormColors.BackColor = Color.FromArgb(233, 236, 239);
            form.BackColor = _MainFormColors.BackColor;

            //Textbox colors
            _TextBoxColors.BackColor = Color.FromArgb(33, 37, 41); // TextBox back color
            form.tbText.BackColor = _TextBoxColors.BackColor;
            _TextBoxColors.TextColor = Color.White; // TextBox text color
            form.tbText.ForeColor = _TextBoxColors.TextColor;
            _TextBoxColors.TrueLetterColor = Color.Lime; //TextBox true letter color
            _TextBoxColors.WrongLetterColor = Color.Red; //Textbox wrong letter color
            _TextBoxColors.SelectedLetterBackColor = Color.White;
            _TextBoxColors.SelectionColor = Color.FromArgb(119, 141, 169);

            _MenuPanelColors.BackColor = Color.FromArgb(33, 37, 41);
            form.MenuPanel.BackColor = _MenuPanelColors.BackColor; //Menu Panel back color

            //Keyboard colors
            _KeyboardColors.BackColor = Color.FromArgb(33, 37, 41);//Color.FromArgb(27, 38, 59); //keyboard button back color
            _KeyboardColors.TextColor = Color.White; //Keyboard text color

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



            form.lblTimer.ForeColor = _TextBoxColors.BackColor;
            form.ProgressBar.ProgressColor = _TextBoxColors.BackColor;
            form.ProgressBar.ProgressColor2 = _TextBoxColors.BackColor;
        }

        public void ColoringTextBox(ref RichTextBox tb)
        {
            
            tb.BackColor = _TextBoxColors.BackColor;

            tb.ForeColor = _TextBoxColors.TextColor;
            
            tb.ForeColor = _TextBoxColors.TextColor;


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

                    button.FillColor = _KeyboardColors.BackColor;
                    button.ForeColor = _KeyboardColors.TextColor;
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
            KeyboardNormalColor = _KeyboardColors.BackColor;

            return KeyboardHoverColor;
        }

        public Color ColoringTrueLetter()
        {
            return _TextBoxColors.TrueLetterColor;
        }

        public Color ColoringWrongLetter()
        {
            return _TextBoxColors.WrongLetterColor;
        }

        public void frmResultColors(frmResults frmResult)
        {
            frmResult.BackColor = _MainFormColors.BackColor;
            frmResult.tbResult.BackColor = _TextBoxColors.BackColor;
            frmResult.lblWpm.ForeColor = _KeyboardColors.BackColor;
            frmResult.lblWpmResult.ForeColor = _KeyboardColors.BackColor;
            frmResult.lbltbResult.ForeColor = _KeyboardColors.BackColor;
            frmResult.lblAccuracy.ForeColor = _KeyboardColors.BackColor;
            frmResult.lblAccuracyPrec.ForeColor = _KeyboardColors.BackColor;
            frmResult.lblRightLettersPrec.ForeColor = _KeyboardColors.BackColor;
            frmResult.lblRightLetters.ForeColor = _KeyboardColors.BackColor;
            frmResult.lblWrongLettersPrec.ForeColor = _KeyboardColors.BackColor;
            frmResult.lblWrongLetters.ForeColor = _KeyboardColors.BackColor;
            frmResult.btnRestart.FillColor = _TextBoxColors.BackColor;
            frmResult.btnRestart.FillColor2 = _TextBoxColors.BackColor;
            frmResult.btnNext.FillColor = _TextBoxColors.BackColor;
            frmResult.btnNext.FillColor2 = _TextBoxColors.BackColor;
            frmResult.PBRightLetters.FillColor = _TextBoxColors.BackColor;
            frmResult.PBWrongLetters.FillColor = _TextBoxColors.BackColor;
            frmResult.PBAccuracy.FillColor = _TextBoxColors.BackColor;
        }
    }
}
