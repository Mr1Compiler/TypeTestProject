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
using TypeTest.Paragraphs;
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

            MainForm.MyResults = new clsResults(this);

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm.SameText = true;
            MainForm.MyRestart.RestartAll();
            MainForm.SameText = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm.MyParagraph.AnotherParagragh();
        }
    }
}
