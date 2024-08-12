using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TypeTest.End_Screen;

namespace TypeTest.Results
{
    public partial class frmResults : Form
    {
     //   clsResults MyResult;
        public frmResults()
        {
            InitializeComponent();
        }

        private void frmResults_Load(object sender, EventArgs e)
        {
            MainForm.MyColors.frmResultColors(this);
            //tbResult = MainForm.
           // MainForm.MyResults = new  clsResults(this);
        }
    }
}
