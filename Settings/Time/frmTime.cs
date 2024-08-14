using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using TypeTest.Settings.Timer;

namespace TypeTest.Settings
{
    public partial class frmTime : Form
    {
        private bool isCustomClicked = false;
        public int Value = 0;
        public frmTime()
        {
            InitializeComponent();
        }

        private void frmTime_Load(object sender, EventArgs e)
        {
            MainForm.MyColors.frmTimeColors(this);
            InitilizingComboBoxes();
        }

        public void InitilizingComboBoxes()
        {
            if (isCustomClicked == true)
                this.cbSelectTime.SelectedIndex = 3;

            else
                this.cbSelectTime.SelectedIndex = 0;



            this.cbSelectCustomNumber.SelectedIndex = 0;
            this.cbSelectCustomTime.SelectedIndex = 0;
        }

        private void cbSelectTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbSelectTime.SelectedIndex == 3)
            {
                gbCustomTime.Enabled = true;
                isCustomClicked = true;
            }
            
        }

        private void cbSelectCustomNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            if( cbSelectCustomNumber.SelectedIndex > 3 && cbSelectCustomTime.SelectedIndex == 1)
            {
                MessageBox.Show("Cannot enter more that 3 min!");
                InitilizingComboBoxes();
            }
        }

        private void cbSelectCustomTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if( cbSelectCustomTime.SelectedIndex == 1 && cbSelectCustomNumber.SelectedIndex > 3)
            {
                MessageBox.Show("Cannot enter more that 3 min!");
                InitilizingComboBoxes();
            }
        }

        private int TimeInSec()
        {
            
            if (isCustomClicked)
            {
                if (cbSelectCustomTime.SelectedIndex == 1)
                {
                    if (int.TryParse(cbSelectCustomNumber.SelectedItem.ToString(), out int Result))
                    {
                        return (Result * 60);
                    }
                }
                else
                {
                    if (int.TryParse(cbSelectCustomNumber.SelectedItem.ToString(), out int Result))
                    {
                        return Result;
                    }
                }
                return 0;
            }

            else
            {
                if(cbSelectTime.SelectedIndex == 0)
                {
                    return 15;
                }
                else if(cbSelectTime.SelectedIndex == 1)
                {
                    return 30;
                }
                else if (cbSelectTime.SelectedIndex == 2)
                {
                    return 60;
                }
                return 0;
            }
        }
        private void btnApplay_Click(object sender, EventArgs e)
        {
            Value = TimeInSec();
           
            MainForm.MyTimer.SetCustomValue(Value);          
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
