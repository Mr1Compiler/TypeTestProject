namespace TypeTest.Results
{
    partial class frmResults
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResults));
            this.lblWpm = new System.Windows.Forms.Label();
            this.lblWpmResult = new System.Windows.Forms.Label();
            this.lblAccuracy = new System.Windows.Forms.Label();
            this.PBAccuracy = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.lblRightLetters = new System.Windows.Forms.Label();
            this.lblWrongLetters = new System.Windows.Forms.Label();
            this.PBWrongLetters = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.PBRightLetters = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.lblAccuracyPrec = new System.Windows.Forms.Label();
            this.lblRightLettersPrec = new System.Windows.Forms.Label();
            this.lblWrongLettersPrec = new System.Windows.Forms.Label();
            this.btnRestart = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnNext = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lbltbResult = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblWpm
            // 
            this.lblWpm.Font = new System.Drawing.Font("FiraCode Nerd Font Propo", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWpm.Location = new System.Drawing.Point(251, 30);
            this.lblWpm.Name = "lblWpm";
            this.lblWpm.Size = new System.Drawing.Size(55, 25);
            this.lblWpm.TabIndex = 0;
            this.lblWpm.Text = "WPM";
            // 
            // lblWpmResult
            // 
            this.lblWpmResult.Font = new System.Drawing.Font("FiraCode Nerd Font Propo", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWpmResult.Location = new System.Drawing.Point(312, 30);
            this.lblWpmResult.Name = "lblWpmResult";
            this.lblWpmResult.Size = new System.Drawing.Size(55, 25);
            this.lblWpmResult.TabIndex = 1;
            this.lblWpmResult.Text = "0";
            // 
            // lblAccuracy
            // 
            this.lblAccuracy.Font = new System.Drawing.Font("FiraCode Nerd Font Propo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccuracy.Location = new System.Drawing.Point(8, 266);
            this.lblAccuracy.Name = "lblAccuracy";
            this.lblAccuracy.Size = new System.Drawing.Size(122, 25);
            this.lblAccuracy.TabIndex = 2;
            this.lblAccuracy.Text = "Accuracy";
            // 
            // PBAccuracy
            // 
            this.PBAccuracy.BorderRadius = 10;
            this.PBAccuracy.BorderThickness = 2;
            this.PBAccuracy.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.PBAccuracy.Location = new System.Drawing.Point(161, 266);
            this.PBAccuracy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PBAccuracy.Name = "PBAccuracy";
            this.PBAccuracy.ShadowDecoration.Parent = this.PBAccuracy;
            this.PBAccuracy.Size = new System.Drawing.Size(413, 25);
            this.PBAccuracy.TabIndex = 6;
            this.PBAccuracy.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // lblRightLetters
            // 
            this.lblRightLetters.Font = new System.Drawing.Font("FiraCode Nerd Font Propo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRightLetters.Location = new System.Drawing.Point(8, 305);
            this.lblRightLetters.Name = "lblRightLetters";
            this.lblRightLetters.Size = new System.Drawing.Size(147, 25);
            this.lblRightLetters.TabIndex = 9;
            this.lblRightLetters.Text = "Right Letters";
            // 
            // lblWrongLetters
            // 
            this.lblWrongLetters.Font = new System.Drawing.Font("FiraCode Nerd Font Propo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrongLetters.Location = new System.Drawing.Point(8, 344);
            this.lblWrongLetters.Name = "lblWrongLetters";
            this.lblWrongLetters.Size = new System.Drawing.Size(147, 25);
            this.lblWrongLetters.TabIndex = 10;
            this.lblWrongLetters.Text = "Wrong Letters";
            // 
            // PBWrongLetters
            // 
            this.PBWrongLetters.BorderRadius = 10;
            this.PBWrongLetters.BorderThickness = 2;
            this.PBWrongLetters.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.PBWrongLetters.Location = new System.Drawing.Point(161, 344);
            this.PBWrongLetters.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PBWrongLetters.Name = "PBWrongLetters";
            this.PBWrongLetters.ShadowDecoration.Parent = this.PBWrongLetters;
            this.PBWrongLetters.Size = new System.Drawing.Size(413, 25);
            this.PBWrongLetters.TabIndex = 12;
            this.PBWrongLetters.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // PBRightLetters
            // 
            this.PBRightLetters.BorderRadius = 10;
            this.PBRightLetters.BorderThickness = 2;
            this.PBRightLetters.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.PBRightLetters.Location = new System.Drawing.Point(161, 305);
            this.PBRightLetters.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PBRightLetters.Name = "PBRightLetters";
            this.PBRightLetters.ShadowDecoration.Parent = this.PBRightLetters;
            this.PBRightLetters.Size = new System.Drawing.Size(413, 25);
            this.PBRightLetters.TabIndex = 13;
            this.PBRightLetters.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // lblAccuracyPrec
            // 
            this.lblAccuracyPrec.Font = new System.Drawing.Font("FiraCode Nerd Font Propo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccuracyPrec.Location = new System.Drawing.Point(580, 266);
            this.lblAccuracyPrec.Name = "lblAccuracyPrec";
            this.lblAccuracyPrec.Size = new System.Drawing.Size(70, 25);
            this.lblAccuracyPrec.TabIndex = 14;
            this.lblAccuracyPrec.Text = "0%";
            // 
            // lblRightLettersPrec
            // 
            this.lblRightLettersPrec.Font = new System.Drawing.Font("FiraCode Nerd Font Propo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRightLettersPrec.Location = new System.Drawing.Point(580, 305);
            this.lblRightLettersPrec.Name = "lblRightLettersPrec";
            this.lblRightLettersPrec.Size = new System.Drawing.Size(70, 25);
            this.lblRightLettersPrec.TabIndex = 15;
            this.lblRightLettersPrec.Text = "0%";
            // 
            // lblWrongLettersPrec
            // 
            this.lblWrongLettersPrec.Font = new System.Drawing.Font("FiraCode Nerd Font Propo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrongLettersPrec.Location = new System.Drawing.Point(580, 344);
            this.lblWrongLettersPrec.Name = "lblWrongLettersPrec";
            this.lblWrongLettersPrec.Size = new System.Drawing.Size(70, 25);
            this.lblWrongLettersPrec.TabIndex = 16;
            this.lblWrongLettersPrec.Text = "0%";
            // 
            // btnRestart
            // 
            this.btnRestart.Animated = true;
            this.btnRestart.AutoRoundedCorners = true;
            this.btnRestart.BorderRadius = 18;
            this.btnRestart.CheckedState.Parent = this.btnRestart;
            this.btnRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestart.CustomImages.Parent = this.btnRestart;
            this.btnRestart.FillColor = System.Drawing.Color.Black;
            this.btnRestart.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRestart.Font = new System.Drawing.Font("FiraCode Nerd Font Propo", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.Color.White;
            this.btnRestart.HoverState.Parent = this.btnRestart;
            this.btnRestart.Location = new System.Drawing.Point(171, 416);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.ShadowDecoration.Parent = this.btnRestart;
            this.btnRestart.Size = new System.Drawing.Size(124, 39);
            this.btnRestart.TabIndex = 17;
            this.btnRestart.Text = "Restart";
            // 
            // btnNext
            // 
            this.btnNext.Animated = true;
            this.btnNext.AutoRoundedCorners = true;
            this.btnNext.BorderRadius = 18;
            this.btnNext.CheckedState.Parent = this.btnNext;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.CustomImages.Parent = this.btnNext;
            this.btnNext.FillColor = System.Drawing.Color.Black;
            this.btnNext.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNext.Font = new System.Drawing.Font("FiraCode Nerd Font Propo", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.HoverState.Parent = this.btnNext;
            this.btnNext.Location = new System.Drawing.Point(332, 416);
            this.btnNext.Name = "btnNext";
            this.btnNext.ShadowDecoration.Parent = this.btnNext;
            this.btnNext.Size = new System.Drawing.Size(124, 39);
            this.btnNext.TabIndex = 18;
            this.btnNext.Text = "Next";
            // 
            // lbltbResult
            // 
            this.lbltbResult.Font = new System.Drawing.Font("FiraCode Nerd Font Propo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltbResult.Location = new System.Drawing.Point(36, 77);
            this.lbltbResult.Name = "lbltbResult";
            this.lbltbResult.Size = new System.Drawing.Size(122, 25);
            this.lbltbResult.TabIndex = 20;
            this.lbltbResult.Text = "Result:";
            // 
            // tbResult
            // 
            this.tbResult.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbResult.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.tbResult.Font = new System.Drawing.Font("FiraCode Nerd Font Propo", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbResult.ForeColor = System.Drawing.Color.Black;
            this.tbResult.HideSelection = false;
            this.tbResult.Location = new System.Drawing.Point(40, 103);
            this.tbResult.Margin = new System.Windows.Forms.Padding(9, 16, 0, 0);
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.tbResult.ShortcutsEnabled = false;
            this.tbResult.ShowSelectionMargin = true;
            this.tbResult.Size = new System.Drawing.Size(534, 126);
            this.tbResult.TabIndex = 21;
            this.tbResult.Text = "";
            this.tbResult.UseWaitCursor = true;
            // 
            // frmResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 484);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.lbltbResult);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblWrongLettersPrec);
            this.Controls.Add(this.lblRightLettersPrec);
            this.Controls.Add(this.lblAccuracyPrec);
            this.Controls.Add(this.PBRightLetters);
            this.Controls.Add(this.PBWrongLetters);
            this.Controls.Add(this.lblWrongLetters);
            this.Controls.Add(this.lblRightLetters);
            this.Controls.Add(this.PBAccuracy);
            this.Controls.Add(this.lblAccuracy);
            this.Controls.Add(this.lblWpmResult);
            this.Controls.Add(this.lblWpm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmResults";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Results";
            this.Load += new System.EventHandler(this.frmResults_Load);
            this.ResumeLayout(false);

        }

        #endregion
        public Guna.UI2.WinForms.Guna2ProgressBar PBAccuracy;
        public Guna.UI2.WinForms.Guna2ProgressBar PBWrongLetters;
        public Guna.UI2.WinForms.Guna2ProgressBar PBRightLetters;
        public System.Windows.Forms.RichTextBox tbResult;
        public System.Windows.Forms.Label lblWpm;
        public System.Windows.Forms.Label lblWpmResult;
        public System.Windows.Forms.Label lblAccuracyPrec;
        public System.Windows.Forms.Label lblRightLettersPrec;
        public System.Windows.Forms.Label lblWrongLettersPrec;
        public Guna.UI2.WinForms.Guna2GradientButton btnRestart;
        public Guna.UI2.WinForms.Guna2GradientButton btnNext;
        public System.Windows.Forms.Label lbltbResult;
        public System.Windows.Forms.Label lblAccuracy;
        public System.Windows.Forms.Label lblRightLetters;
        public System.Windows.Forms.Label lblWrongLetters;
    }
}