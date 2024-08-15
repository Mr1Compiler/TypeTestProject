using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypeTest.Custom_Paragraph
{
    public partial class frmCustomParagraph : Form
    {
        clsCustomParagraph MyCustom;
        public frmCustomParagraph()
        {
            InitializeComponent();
            MainForm.MyColors.frmCustomParagraph(this);
            MyCustom = new clsCustomParagraph(this);
        }

        private void frmCustomParagraph_Load(object sender, EventArgs e)
        {
            tbAddCustom.Focus();           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MyCustom.AddBtnPressed();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            MyCustom.CancelBtnPressed();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            tbAddCustom.Text = string.Empty;
        }

        private void tbAddCustom_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbAddCustom.Text) || string.IsNullOrWhiteSpace(tbAddCustom.Text))
            {
                btnNew.Visible = false;
            }
            else
                btnNew.Visible = true;

        }
    }
}
