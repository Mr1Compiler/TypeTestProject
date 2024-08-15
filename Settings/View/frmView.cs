using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypeTest.Settings.View
{
    public partial class frmView : Form
    {
        MainForm form;
        private bool SettingsChanced = false;
        public frmView(MainForm Form)
        {
            InitializeComponent();
            form = Form;
            MainForm.MyColors.frmView(this);
        }

        private void frmView_Load(object sender, EventArgs e)
        {
            MainForm.MyView.SavingCurrentSettings(this);
            SettingsChanced = false;
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!chbShowKeyboard.Checked == true)
            {
                form.KeyboardPanel.Visible = false;
              
            }
            else
            {
                form.KeyboardPanel.Visible = true;
              
            }
            SettingsChanced = true;
        }

        private void guna2CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (!chbShowTimer.Checked == true)
            {
                form.lblTimer.Visible = false;
                //View.isShowTimer = false;
            }
            else
            {
                form.lblTimer.Visible = true;
                //View.isShowTimer = true;
            }
            SettingsChanced = true;
        }

        private void guna2CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (!chbShowNextButton.Checked == true)
            {
                form.pbNextText.Visible = false;
               // View.isShowNextButton = false;
            }
            else
            {
                form.pbNextText.Visible = true;
             //   View.isShowNextButton = true;
            }
            SettingsChanced = true;
        }

        private void chbShowRestartButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!chbShowRestartButton.Checked == true)
            {
                form.pbRestart.Visible = false;
              //  View.isShowRestartButton = false;
            }
            else
            {
                form.pbRestart.Visible = true;
            //    View.isShowRestartButton = true;
            }
            SettingsChanced = true;
        }

        private void chbShowProgressBar_CheckedChanged(object sender, EventArgs e)
        {
            if (!chbShowProgressBar.Checked == true)
            {
                form.ProgressBar.Visible = false;
                //View.isShowProgressBar = false;
            }
            else
            {
                form.ProgressBar.Visible = true;
               // View.isShowProgressBar = true;
            }
            SettingsChanced = true;
        }

        private void btnApplay_Click(object sender, EventArgs e)
        {
            MainForm.MyView.isShowKeyboard = chbShowKeyboard.Checked;
            MainForm.MyView.isShowTimer = chbShowTimer.Checked;
            MainForm.MyView.isShowNextButton = chbShowNextButton.Checked;
            MainForm.MyView.isShowRestartButton = chbShowRestartButton.Checked;
            MainForm.MyView.isShowProgressBar = chbShowProgressBar.Checked;

            form.SettingsPanel.Visible = false;
            form.isClose = true;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (SettingsChanced)
            {
                if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    MainForm.MyView.AssignPrevValues(this);
                    this.Close();
                }
            }
            else
                this.Close();
        }
    }
}
