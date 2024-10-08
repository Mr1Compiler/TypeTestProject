﻿using Guna.UI2.HtmlRenderer.Adapters;
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
using TypeTest.AboutMe;
using TypeTest.Colors;
using TypeTest.Custom_Paragraph;
using TypeTest.Keyboard;
using TypeTest.Results;
using TypeTest.Settings;
using TypeTest.Settings.View;

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



            form.ProgressBar.FillColor = _TextBoxColors.BackColor;

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

        public void SetNewKeyboardBackColor(Color NewBackColor)
        {
            _KeyboardColors.BackColor = NewBackColor;
            SetKeyboardColors();
            MainForm.MyColors = new clsColors(_Form);
        }

        public void SetNewKeyboardTextColor(Color NewTextColor)
        {
            _KeyboardColors.TextColor = NewTextColor;
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
            return _MainFormColors.BackColor;
        }
        public Color HoverButtonColor(ref Color KeyboardHoverColor, ref Color KeyboardNormalColor)
        {

            KeyboardHoverColor = _MainFormColors.BackColor;//_KeyboardHoverColors.KeyboardHoverColor;
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

        public void ColoringButton(ref Guna2GradientButton btn)
        {
            btn.FillColor = _TextBoxColors.BackColor;
            btn.FillColor2 = _TextBoxColors.BackColor;
        }

        public void ColoringGroupBox(ref Guna2GroupBox GB)
        {
            GB.BackColor = _TextBoxColors.BackColor;
            GB.ForeColor = _TextBoxColors.TextColor;
            GB.BorderColor = _TextBoxColors.BackColor;
            GB.CustomBorderColor = _TextBoxColors.BackColor;
            GB.FillColor = _MainFormColors.BackColor;
        }
        public void frmTimeColors(frmTime frmTime)
        {
            frmTime.BackColor = _MainFormColors.BackColor;
            frmTime.cbSelectTime.BackColor = _TextBoxColors.BackColor;
            frmTime.cbSelectTime.FillColor = _TextBoxColors.BackColor;
            frmTime.cbSelectTime.ForeColor = _TextBoxColors.TextColor;
            frmTime.cbSelectTime.BorderColor = _TextBoxColors.BackColor;

            ColoringGroupBox(ref frmTime.gbCustomTime);

            frmTime.cbSelectCustomTime.BackColor = _TextBoxColors.BackColor;
            frmTime.cbSelectCustomTime.FillColor = _TextBoxColors.BackColor;
            frmTime.cbSelectCustomTime.ForeColor = _TextBoxColors.TextColor;
            frmTime.cbSelectCustomTime.BorderColor = _TextBoxColors.BackColor;

            frmTime.cbSelectCustomNumber.BackColor = _TextBoxColors.BackColor;
            frmTime.cbSelectCustomNumber.FillColor = _TextBoxColors.BackColor;
            frmTime.cbSelectCustomNumber.ForeColor = _TextBoxColors.TextColor;
            frmTime.cbSelectCustomNumber.BorderColor = _TextBoxColors.BackColor;


            ColoringButton(ref frmTime.btnCancel);
            ColoringButton(ref frmTime.btnApplay);
        }

        public void frmCustomParagraph(frmCustomParagraph frmCustomParagraph)
        {
            ColoringTextBox(ref frmCustomParagraph.tbAddCustom);
            ColoringButton(ref frmCustomParagraph.btnCancel);
            ColoringButton(ref frmCustomParagraph.btnNew);
            ColoringButton(ref frmCustomParagraph.btnAdd);
        }

        public void frmView(frmView frmView)
        {
            frmView.BackColor = _MainFormColors.BackColor;

            ColoringButton(ref frmView.btnApplay);
            ColoringButton(ref frmView.btnCancel);

            frmView.chbShowKeyboard.CheckMarkColor = _TextBoxColors.BackColor;
            frmView.chbShowKeyboard.ForeColor = _TextBoxColors.BackColor;

            frmView.chbShowNextButton.CheckMarkColor = _TextBoxColors.BackColor;
            frmView.chbShowNextButton.ForeColor = _TextBoxColors.BackColor;

            frmView.chbShowProgressBar.CheckMarkColor = _TextBoxColors.BackColor;
            frmView.chbShowProgressBar.ForeColor = _TextBoxColors.BackColor;

            frmView.chbShowRestartButton.CheckMarkColor = _TextBoxColors.BackColor;
            frmView.chbShowRestartButton.ForeColor = _TextBoxColors.BackColor;

            frmView.chbShowProgressBar.CheckMarkColor = _TextBoxColors.BackColor;
            frmView.chbShowProgressBar.ForeColor = _TextBoxColors.BackColor;

            frmView.chbShowTimer.CheckMarkColor = _TextBoxColors.BackColor;
            frmView.chbShowTimer.ForeColor = _TextBoxColors.BackColor;
            
        }

        public void frmAboutMe(frmAboutMe frmAboutMe)
        {
            frmAboutMe.BackColor = _MainFormColors.BackColor;

            frmAboutMe.lblAboutMe.BackColor = Color.FromArgb(33, 37, 41);
            frmAboutMe.lblAboutMe.ForeColor = Color.White;
            frmAboutMe.lblAboutProject.BackColor = Color.FromArgb(33, 37, 41);
            frmAboutMe.lblAboutProject.ForeColor = Color.White;
            frmAboutMe.lblSourceCode.BackColor = Color.FromArgb(33, 37, 41);
            frmAboutMe.lblSourceCode.ForeColor = Color.White;
            frmAboutMe.lblGithub.BackColor = Color.FromArgb(33, 37, 41);
            frmAboutMe.lblGithub.ForeColor = Color.White;

            frmAboutMe.pbReddit.BackColor = Color.FromArgb(33, 37, 41);
            frmAboutMe.pbYoutube.BackColor = Color.FromArgb(33, 37, 41);
            frmAboutMe.pbInsta.BackColor = Color.FromArgb(33, 37, 41);

            frmAboutMe.SocialPanel.FillColor = Color.FromArgb(33, 37, 41);
            frmAboutMe.SocialPanel.FillColor2 = Color.FromArgb(33, 37, 41);
            frmAboutMe.SocialPanel.FillColor3 = Color.FromArgb(33, 37, 41);
            frmAboutMe.SocialPanel.FillColor4 = Color.FromArgb(33, 37, 41);

            frmAboutMe.AboutMePanel.FillColor = Color.FromArgb(33, 37, 41);
            frmAboutMe.AboutMePanel.FillColor2 = Color.FromArgb(33, 37, 41);
            frmAboutMe.AboutMePanel.FillColor3 = Color.FromArgb(33, 37, 41);
            frmAboutMe.AboutMePanel.FillColor4 = Color.FromArgb(33, 37, 41);

            frmAboutMe.AboutProjectPanel.FillColor = Color.FromArgb(33, 37, 41);
            frmAboutMe.AboutProjectPanel.FillColor2 = Color.FromArgb(33, 37, 41);
            frmAboutMe.AboutProjectPanel.FillColor3 = Color.FromArgb(33, 37, 41);
            frmAboutMe.AboutProjectPanel.FillColor4 = Color.FromArgb(33, 37, 41);

            frmAboutMe.linkSourceCode.BackColor = Color.FromArgb(33, 37, 41);
            frmAboutMe.linkSourceCode.LinkColor = Color.White;

            frmAboutMe.linkGithub.BackColor = Color.FromArgb(33, 37, 41);
            frmAboutMe.linkGithub.LinkColor = Color.White;
        }

    }
}
