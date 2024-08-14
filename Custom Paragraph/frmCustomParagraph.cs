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
        }

        private void frmCustomParagraph_Load(object sender, EventArgs e)
        {
            this.tbAddCustom.Focus();
            MyCustom = new clsCustomParagraph(this);
            tbAddCustom.Cursor = Cursors.IBeam;
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MyCustom.AddBtnPressed();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            MyCustom.CancelBtnPressed();
        }
    
       
    }
}
