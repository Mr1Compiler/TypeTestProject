using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypeTest.AboutMe
{
    public partial class frmAboutMe : Form
    {
        MainForm form;
        public frmAboutMe(MainForm Form)
        {
            InitializeComponent();
            form = Form;
            MainForm.MyColors.frmAboutMe(this);

            lblAboutMe.Text = "About Me:\r\n\r\nHello!\r\nMy name is Ayman, and I am a Computer Engineering student specializing in C# development. Below, you’ll find links to my social media accounts. Feel free to contact me at any time!";

            lblAboutProject.Text = "About the Project:\r\n\nThis is my first application developed in C#. While I have completed several smaller C# projects for practice, this is my initial foray into a more substantial application.\r\n\r\nThe app is a typing practice tool that allows users to choose random paragraphs to enhance their typing speed. Users can also add their own custom paragraphs by pressing the \"+\" icon located at the top. You can edit your selections and adjust the timer duration (up to three minutes) through the settings. Additionally, you have the option to enable or disable certain features via the \"View\" settings.\r\nWhile this application has room for improvement and could benefit from additional features, \nI aimed to keep it simple to focus on practicing WinForms and C#.\r\nThank you for taking the time to check it out!";
        }


        private void frmAboutMe_Load(object sender, EventArgs e)
        {
           
        }

        private void frmAboutMe_FormClosed(object sender, FormClosedEventArgs e)
        {
       
        }

        private void linkSourceCode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
