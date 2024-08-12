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
using TypeTest.Paragraphs;
using TypeTest.Settings;
using TypeTest.Settings.Restart;
using TypeTest.Settings.Timer;

namespace TypeTest
{
    public partial class MainForm : Form
    {
        public static clsParagraphs MyParagraph;
        public static clsColors MyColors;
        public static clsKeyboard MyKeyboard;
        public static clsTimer MyTimer;
        public static clsRestart MyRestart;
        public static bool SameText = false;

        public MainForm()
        {
            InitializeComponent();
        }
        public void InitialzingObjest()
        {
            MyColors = new clsColors(this);
            MyParagraph = new clsParagraphs(this);
            MyKeyboard = new clsKeyboard(this);
            MyTimer = new clsTimer(this);
            MyRestart = new clsRestart(this);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            InitialzingObjest();
            this.KeyPreview = true;
          //  tbText.Focus();
        }

        public bool Close = true;
        private void btnfrmSettings_Click(object sender, EventArgs e)
        {
            
            if(Close)
            {
                SettingsPanel.Visible = true;
                Close = false;
            }
            else
            {
                SettingsPanel.Visible=false;
                Close = true;
            }

        }
        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            MyParagraph.KeyPress(sender, e);
        }
        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
           MyParagraph.KeyUp(sender, e);
        }

        private void btnTimeSettings_Click(object sender, EventArgs e)
        {
            frmTime frmTimeSettings = new frmTime();
            frmTimeSettings.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MyTimer.TimerTick();
        }

        private void pbRestart_Click(object sender, EventArgs e)
        {
            SameText = true;
            MyRestart.RestartAll();
            SameText = false;
        }

        private void pbNextText_Click(object sender, EventArgs e)
        {
            MyParagraph.AnotherParagragh();
        }
    }
}
