using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using Telerik.WinControls.UI;

namespace TypeTest
{
    public partial class frmSettings : Form
    {
        public enum enSettings { TextBox = 0, Fonts = 1, Colors = 2 };
        public enSettings Settings = enSettings.TextBox;


        public frmSettings()
        {
            InitializeComponent();
        }
        private void frmSettings_Load(object sender, EventArgs e)
        {
            listbox.SelectedIndex = 0;
            Settings = enSettings.TextBox;
        }

        //private void DisableAllInsteadOne(Panel panel)
        //{
        //    TextboxPanel.Visible = false;
        //    FontPanel.Visible= false;
        //    ColorsPanel.Visible = false;

        //    panel.Visible = true;
        // }

        //private bool ShowPanel(int Index)
        //{


        //    //switch ((enSettings)Index)
        //    //{
        //    //    case enSettings.TextBox:
        //    //        DisableAllInsteadOne(TextboxPanel);
        //    //        return true;

        //    //    case enSettings.Fonts:
        //    //        DisableAllInsteadOne(FontPanel);
        //    //        return true;

        //    //    case enSettings.Colors:
        //    //        DisableAllInsteadOne(ColorsPanel);
        //    //        ColorsPanel.Visible = true;
        //    //        return true;


        //    //}

        //    return false;

        //}
        bool isitvisiable = false;
        private void listbox_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
        {
            //ShowPanel(Convert.ToInt32(selectedItem.SecondaryText));

            //TextboxPanel.Visible= false;
            //ColorsPanel.Visible= true;
            //ColorsPanel.Show();



            //if (listbox.SelectedIndex == 0)
            //{
            //    panel1.Visible = true;
            //    panel22.Visible = false;
            //    panel33.Visible = false;
            //}

            //else if (listbox.SelectedIndex == 1)
            //{
            //    panel22.Visible = true;
            //    panel1.Visible = false;
            //    panel33.Visible = false;
            //}
            //else if (listbox.SelectedIndex == 2)
            //{
            //    panel33.Visible = true;
            //    panel22.Visible = false;
            //    panel1.Visible = false;

                //}
                //if (isitvisiable == false)
                //{
                //    panel1.Visible = true;
                //    panel2.Visible = true;

                //    isitvisiable = true;
                //}

                //else if (isitvisiable == true)
                //{
                //    panel1.Visible = false;
                //    panel2.Visible = false;
                //    isitvisiable = false;
                //}
        }
    }
}
