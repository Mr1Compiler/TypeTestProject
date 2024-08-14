using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypeTest.Settings
{
    public partial class frmTime : Form
    {
        public frmTime()
        {
            InitializeComponent();
        }

        private void frmTime_Load(object sender, EventArgs e)
        {

            MainForm.MyColors.frmTimeColors(this);
        }
    }
}
