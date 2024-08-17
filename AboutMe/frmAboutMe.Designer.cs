namespace TypeTest.AboutMe
{
    partial class frmAboutMe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAboutMe));
            this.linkSourceCode = new System.Windows.Forms.LinkLabel();
            this.lblAboutMe = new System.Windows.Forms.Label();
            this.lblAboutProject = new System.Windows.Forms.Label();
            this.pbYoutube = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pbInsta = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.SocialPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.lblGithub = new System.Windows.Forms.Label();
            this.linkGithub = new System.Windows.Forms.LinkLabel();
            this.lblSourceCode = new System.Windows.Forms.Label();
            this.AboutProjectPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.AboutMePanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.pbReddit = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbYoutube)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInsta)).BeginInit();
            this.SocialPanel.SuspendLayout();
            this.AboutProjectPanel.SuspendLayout();
            this.AboutMePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbReddit)).BeginInit();
            this.SuspendLayout();
            // 
            // linkSourceCode
            // 
            this.linkSourceCode.Font = new System.Drawing.Font("FiraCode Nerd Font Propo", 9.75F, System.Drawing.FontStyle.Bold);
            this.linkSourceCode.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkSourceCode.Location = new System.Drawing.Point(138, 11);
            this.linkSourceCode.Name = "linkSourceCode";
            this.linkSourceCode.Size = new System.Drawing.Size(109, 19);
            this.linkSourceCode.TabIndex = 0;
            this.linkSourceCode.TabStop = true;
            this.linkSourceCode.Text = "Click Here";
            this.linkSourceCode.VisitedLinkColor = System.Drawing.Color.Fuchsia;
            this.linkSourceCode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSourceCode_LinkClicked);
            // 
            // lblAboutMe
            // 
            this.lblAboutMe.BackColor = System.Drawing.Color.Lime;
            this.lblAboutMe.Font = new System.Drawing.Font("FiraCode Nerd Font Propo", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAboutMe.ForeColor = System.Drawing.Color.Black;
            this.lblAboutMe.Location = new System.Drawing.Point(9, 10);
            this.lblAboutMe.Name = "lblAboutMe";
            this.lblAboutMe.Size = new System.Drawing.Size(711, 116);
            this.lblAboutMe.TabIndex = 6;
            this.lblAboutMe.Text = "asfdasdfasdfsadf";
            // 
            // lblAboutProject
            // 
            this.lblAboutProject.BackColor = System.Drawing.Color.Blue;
            this.lblAboutProject.Font = new System.Drawing.Font("FiraCode Nerd Font Propo", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAboutProject.ForeColor = System.Drawing.Color.Black;
            this.lblAboutProject.Location = new System.Drawing.Point(6, 10);
            this.lblAboutProject.Name = "lblAboutProject";
            this.lblAboutProject.Size = new System.Drawing.Size(714, 223);
            this.lblAboutProject.TabIndex = 7;
            this.lblAboutProject.Text = "asdfasdfasfd";
            // 
            // pbYoutube
            // 
            this.pbYoutube.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbYoutube.Image = ((System.Drawing.Image)(resources.GetObject("pbYoutube.Image")));
            this.pbYoutube.Location = new System.Drawing.Point(112, 77);
            this.pbYoutube.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbYoutube.Name = "pbYoutube";
            this.pbYoutube.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbYoutube.ShadowDecoration.Parent = this.pbYoutube;
            this.pbYoutube.Size = new System.Drawing.Size(48, 33);
            this.pbYoutube.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbYoutube.TabIndex = 10;
            this.pbYoutube.TabStop = false;
            this.pbYoutube.Click += new System.EventHandler(this.pbYoutube_Click);
            // 
            // pbInsta
            // 
            this.pbInsta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbInsta.Image = ((System.Drawing.Image)(resources.GetObject("pbInsta.Image")));
            this.pbInsta.Location = new System.Drawing.Point(167, 77);
            this.pbInsta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbInsta.Name = "pbInsta";
            this.pbInsta.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbInsta.ShadowDecoration.Parent = this.pbInsta;
            this.pbInsta.Size = new System.Drawing.Size(48, 33);
            this.pbInsta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbInsta.TabIndex = 12;
            this.pbInsta.TabStop = false;
            this.pbInsta.Click += new System.EventHandler(this.pbInsta_Click);
            // 
            // SocialPanel
            // 
            this.SocialPanel.BorderRadius = 5;
            this.SocialPanel.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.SocialPanel.Controls.Add(this.pbReddit);
            this.SocialPanel.Controls.Add(this.lblGithub);
            this.SocialPanel.Controls.Add(this.linkGithub);
            this.SocialPanel.Controls.Add(this.lblSourceCode);
            this.SocialPanel.Controls.Add(this.pbInsta);
            this.SocialPanel.Controls.Add(this.linkSourceCode);
            this.SocialPanel.Controls.Add(this.pbYoutube);
            this.SocialPanel.Location = new System.Drawing.Point(222, 415);
            this.SocialPanel.Name = "SocialPanel";
            this.SocialPanel.ShadowDecoration.Parent = this.SocialPanel;
            this.SocialPanel.Size = new System.Drawing.Size(267, 121);
            this.SocialPanel.TabIndex = 14;
            // 
            // lblGithub
            // 
            this.lblGithub.BackColor = System.Drawing.Color.White;
            this.lblGithub.Font = new System.Drawing.Font("FiraCode Nerd Font Propo", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGithub.ForeColor = System.Drawing.Color.Black;
            this.lblGithub.Location = new System.Drawing.Point(12, 45);
            this.lblGithub.Name = "lblGithub";
            this.lblGithub.Size = new System.Drawing.Size(77, 19);
            this.lblGithub.TabIndex = 17;
            this.lblGithub.Text = "Github :";
            // 
            // linkGithub
            // 
            this.linkGithub.Font = new System.Drawing.Font("FiraCode Nerd Font Propo", 9.75F, System.Drawing.FontStyle.Bold);
            this.linkGithub.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkGithub.Location = new System.Drawing.Point(95, 45);
            this.linkGithub.Name = "linkGithub";
            this.linkGithub.Size = new System.Drawing.Size(112, 19);
            this.linkGithub.TabIndex = 16;
            this.linkGithub.TabStop = true;
            this.linkGithub.Text = "Click Here";
            this.linkGithub.VisitedLinkColor = System.Drawing.Color.Fuchsia;
            this.linkGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGithub_LinkClicked);
            // 
            // lblSourceCode
            // 
            this.lblSourceCode.BackColor = System.Drawing.Color.White;
            this.lblSourceCode.Font = new System.Drawing.Font("FiraCode Nerd Font Propo", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSourceCode.ForeColor = System.Drawing.Color.Black;
            this.lblSourceCode.Location = new System.Drawing.Point(12, 11);
            this.lblSourceCode.Name = "lblSourceCode";
            this.lblSourceCode.Size = new System.Drawing.Size(120, 19);
            this.lblSourceCode.TabIndex = 15;
            this.lblSourceCode.Text = "Source Code :";
            // 
            // AboutProjectPanel
            // 
            this.AboutProjectPanel.BorderRadius = 5;
            this.AboutProjectPanel.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.AboutProjectPanel.Controls.Add(this.lblAboutProject);
            this.AboutProjectPanel.Location = new System.Drawing.Point(12, 165);
            this.AboutProjectPanel.Name = "AboutProjectPanel";
            this.AboutProjectPanel.ShadowDecoration.Parent = this.AboutProjectPanel;
            this.AboutProjectPanel.Size = new System.Drawing.Size(723, 244);
            this.AboutProjectPanel.TabIndex = 19;
            // 
            // AboutMePanel
            // 
            this.AboutMePanel.BorderRadius = 5;
            this.AboutMePanel.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.AboutMePanel.Controls.Add(this.lblAboutMe);
            this.AboutMePanel.Location = new System.Drawing.Point(12, 27);
            this.AboutMePanel.Name = "AboutMePanel";
            this.AboutMePanel.ShadowDecoration.Parent = this.AboutMePanel;
            this.AboutMePanel.Size = new System.Drawing.Size(723, 132);
            this.AboutMePanel.TabIndex = 20;
            // 
            // pbReddit
            // 
            this.pbReddit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbReddit.Image = ((System.Drawing.Image)(resources.GetObject("pbReddit.Image")));
            this.pbReddit.Location = new System.Drawing.Point(57, 77);
            this.pbReddit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbReddit.Name = "pbReddit";
            this.pbReddit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbReddit.ShadowDecoration.Parent = this.pbReddit;
            this.pbReddit.Size = new System.Drawing.Size(48, 33);
            this.pbReddit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbReddit.TabIndex = 18;
            this.pbReddit.TabStop = false;
            this.pbReddit.Click += new System.EventHandler(this.pbReddit_Click);
            // 
            // frmAboutMe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 543);
            this.Controls.Add(this.AboutMePanel);
            this.Controls.Add(this.AboutProjectPanel);
            this.Controls.Add(this.SocialPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAboutMe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About Me";
            ((System.ComponentModel.ISupportInitialize)(this.pbYoutube)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInsta)).EndInit();
            this.SocialPanel.ResumeLayout(false);
            this.AboutProjectPanel.ResumeLayout(false);
            this.AboutMePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbReddit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label lblAboutMe;
        public System.Windows.Forms.Label lblAboutProject;
        public System.Windows.Forms.Label lblSourceCode;
        public System.Windows.Forms.LinkLabel linkSourceCode;
        public Guna.UI2.WinForms.Guna2CustomGradientPanel SocialPanel;
        public Guna.UI2.WinForms.Guna2CirclePictureBox pbYoutube;
        public Guna.UI2.WinForms.Guna2CirclePictureBox pbInsta;
        public System.Windows.Forms.Label lblGithub;
        public System.Windows.Forms.LinkLabel linkGithub;
        public Guna.UI2.WinForms.Guna2CustomGradientPanel AboutProjectPanel;
        public Guna.UI2.WinForms.Guna2CustomGradientPanel AboutMePanel;
        public Guna.UI2.WinForms.Guna2CirclePictureBox pbReddit;
    }
}