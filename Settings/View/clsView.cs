using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeTest.Settings.View
{
    public class clsView
    {
        frmView view;

        private bool _isShowKeyboard = true;
        private bool _isShowTimer = true;
        private bool _isShowNextButton = true ;
        private bool _isShowRestartButton = true ;
        private bool _isShowProgressBar = true ;

        private bool PrevisShowKeyboard;
        private bool PrevisShowTimer;
        private bool PrevisShowNextButton;
        private bool PrevisShowRestartButton;
        private bool PrevisShowProgressBar;
        public bool isShowKeyboard
        {
            get => _isShowKeyboard;
            set => _isShowKeyboard = value;
        }

        public bool isShowTimer
        {
            get => _isShowTimer;
            set => _isShowTimer = value;
        }

        public bool isShowNextButton
        {
            get => _isShowNextButton;
            set => _isShowNextButton = value;
        }

        public bool isShowRestartButton
        {
            get => _isShowRestartButton;
            set => _isShowRestartButton = value;
        }

        public  bool isShowProgressBar
        {
            get => _isShowProgressBar;
            set => _isShowProgressBar = value;
        }

        public void SavingCurrentSettings(frmView View)
        {
            PrevisShowKeyboard = View.chbShowKeyboard.Checked;
            PrevisShowTimer = View.chbShowTimer.Checked;
            PrevisShowNextButton  = View.chbShowNextButton.Checked;
            PrevisShowRestartButton = View.chbShowRestartButton.Checked;
            PrevisShowProgressBar = View.chbShowProgressBar.Checked;

        }

        public void AssignPrevValues(frmView View)
        {
            View.chbShowKeyboard.Checked = PrevisShowKeyboard;
            View.chbShowTimer.Checked = PrevisShowTimer;
            View.chbShowNextButton.Checked = PrevisShowNextButton;
            View.chbShowRestartButton.Checked = PrevisShowRestartButton;
            View.chbShowProgressBar.Checked = PrevisShowProgressBar;
        }

    }
}
