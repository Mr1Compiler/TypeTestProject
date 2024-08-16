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
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using TypeTest.AboutMe;
using TypeTest.Colors;
using TypeTest.Custom_Paragraph;
using TypeTest.End_Screen;
using TypeTest.Keyboard;
using TypeTest.Paragraphs;
using TypeTest.Settings;
using TypeTest.Settings.Restart;
using TypeTest.Settings.Timer;
using TypeTest.Settings.View;

namespace TypeTest
{
    public partial class MainForm : Form
    {
        public static clsParagraphs MyParagraph;
        public static clsColors MyColors;
        public static clsKeyboard MyKeyboard;
        public static clsTimer MyTimer;
        public static clsRestart MyRestart;
        public static clsResults MyResults;
        public static clsView MyView;
        public frmView frmView;
        public frmTime frmTime;
        public frmAboutMe frmAboutMe;
        frmCustomParagraph frmCustomParagraph; 
        public static bool SameText = false;
        public static bool CustomTime = false;
        public bool isClose = true;
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
            MyView = new clsView();
        }
        public void InitializingForms()
        {
            frmView = new frmView(this);
            frmTime = new frmTime(this);
            frmCustomParagraph = new frmCustomParagraph();
            frmAboutMe = new frmAboutMe(this);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            InitialzingObjest();
            InitializingForms();
            this.KeyPreview = true;
        }
        public void CustomText(string CustomParagraph)
        {
            clsParagraphs.CustomText = true;
            clsParagraphs.CustomParagraph = CustomParagraph;
            MyParagraph = new clsParagraphs(this);
            MyTimer = new clsTimer(this);
            clsParagraphs.CustomText = false;  
        }
        public void CustomTimer(int CustomTimer)
        {
            lblTimer.Visible = false;
            CustomTime = true;
            clsTimer.CustomValue = CustomTimer;
            MyTimer = new clsTimer(this);
            clsTimer.isCustomValue = false;
            MyParagraph = new clsParagraphs(this); 
            SettingsPanel.Visible = false;
            isClose = true;
            
        }
        private void btnfrmSettings_Click(object sender, EventArgs e)
        {
            if(isClose)
            {
                SettingsPanel.Enabled= true;
                SettingsPanel.Visible = true;
                isClose = false;
            }
            else
            {
                SettingsPanel.Enabled = false;
                SettingsPanel.Visible = false;
                isClose = true;
            }
            
        }
        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Focus();
            MyParagraph.KeyPress(sender, e);
        }
        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            MyParagraph.KeyUp(sender, e);
        }
        private void btnTimeSettings_Click(object sender, EventArgs e)
        {
            
            frmTime.ShowDialog();
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
        private void pbAdd_Click(object sender, EventArgs e)
        {
            frmCustomParagraph.ShowDialog();
        }
        private void btnViewSettings_Click(object sender, EventArgs e)
        {
            frmView.ShowDialog();
        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {
            frmAboutMe.ShowDialog();
        }
    }
}
