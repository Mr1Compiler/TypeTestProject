using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TypeTest.Paragraphs;

namespace TypeTest.Custom_Paragraph
{
    public class clsCustomParagraph
    {
        frmCustomParagraph form;
        public clsCustomParagraph(frmCustomParagraph Form)
        {
            form = Form;
        }
        public void AddBtnPressed()
        {
            if (Validating())
            {
                MainForm.MyParagraph.AsiggnNewParagraph(form.tbAddCustom.Text.Trim()); 
                form.Close();
            }
        }
        public void CancelBtnPressed()
        {
            if(!string.IsNullOrEmpty(form.tbAddCustom.Text))
            {
                if(MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    form.tbAddCustom.Text = string.Empty;
                    form.Close();
                    
                }
            }
            else
                form.Close();
        }

        public bool Validating()
        {
            if (string.IsNullOrEmpty(form.tbAddCustom.Text) || string.IsNullOrWhiteSpace(form.tbAddCustom.Text))
            {
                form.tbAddCustom.Focus();
                MessageBox.Show("Can not enter empty paragraph!");
                return false;
            }
            else if (form.tbAddCustom.Text.Length > 700)
            {
                form.tbAddCustom.Focus();
                MessageBox.Show("Can not enter a paragraph with more than 700 letters");
                return false;
            }

            return true;
        }
    }
}
