using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TypeTest.Paragraphs;
using TypeTest.Settings.Timer;
using TypeTest.Colors;
using System.Threading.Tasks;
using System.Windows.Forms;
using TypeTest.Keyboard;

namespace TypeTest.Settings.Restart
{
    public class clsRestart
    {

        MainForm form;

        public clsRestart(MainForm Form)
        {
            form = Form;
        }

        public void RestartAll()
        {
            form.tbText.Enabled = true;
            form.lblTimer.Visible = false;
            MainForm.MyParagraph = new clsParagraphs(form);
            MainForm.MyColors = new clsColors(form);
            MainForm.MyTimer = new clsTimer(form);
            MainForm.MyKeyboard = new clsKeyboard(form);            
        }
    }
}
