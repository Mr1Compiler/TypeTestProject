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
        public frmCustomParagraph()
        {
            InitializeComponent();
            MainForm.MyColors.frmCustomParagraph(this);
        }
        private void frmCustomParagraph_Load(object sender, EventArgs e)
        {
            tbAddCustom.Focus();           
        }
        public bool Validating()
        {
            if (string.IsNullOrEmpty(tbAddCustom.Text) || string.IsNullOrWhiteSpace(tbAddCustom.Text))
            {
               tbAddCustom.Focus();
                MessageBox.Show("Can not enter empty paragraph!");
                return false;
            }
            else if (tbAddCustom.Text.Length > 700)
            {
               tbAddCustom.Focus();
                MessageBox.Show("Can not enter a paragraph with more than 700 letters");
                return false;
            }

            return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Validating())
            {
                MainForm.MyParagraph.AsiggnNewParagraph(tbAddCustom.Text.Trim());
                this.Close();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbAddCustom.Text))
            {
                if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    tbAddCustom.Text = string.Empty;
                    this.Close();
                }
            }
            else
                this.Close();
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
