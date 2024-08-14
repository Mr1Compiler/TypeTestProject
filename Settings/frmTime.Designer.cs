namespace TypeTest.Settings
{
    partial class frmTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTime));
            this.cbSelectTime = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblSelect = new System.Windows.Forms.Label();
            this.btnApplay = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnCancel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.gbCustomTime = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cbSelectCustomNumber = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbSelectCustomTime = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gbCustomTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbSelectTime
            // 
            this.cbSelectTime.BackColor = System.Drawing.Color.Transparent;
            this.cbSelectTime.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSelectTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectTime.FocusedColor = System.Drawing.Color.Empty;
            this.cbSelectTime.FocusedState.Parent = this.cbSelectTime;
            this.cbSelectTime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbSelectTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSelectTime.FormattingEnabled = true;
            this.cbSelectTime.HoverState.Parent = this.cbSelectTime;
            this.cbSelectTime.ItemHeight = 30;
            this.cbSelectTime.Items.AddRange(new object[] {
            "15 Sec",
            "30 Sec",
            "1   Min",
            "Custom"});
            this.cbSelectTime.ItemsAppearance.Parent = this.cbSelectTime;
            this.cbSelectTime.Location = new System.Drawing.Point(205, 96);
            this.cbSelectTime.Name = "cbSelectTime";
            this.cbSelectTime.ShadowDecoration.Parent = this.cbSelectTime;
            this.cbSelectTime.Size = new System.Drawing.Size(195, 36);
            this.cbSelectTime.TabIndex = 0;
            // 
            // lblSelect
            // 
            this.lblSelect.Font = new System.Drawing.Font("FiraCode Nerd Font Propo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect.ForeColor = System.Drawing.Color.Black;
            this.lblSelect.Location = new System.Drawing.Point(40, 104);
            this.lblSelect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(158, 28);
            this.lblSelect.TabIndex = 6;
            this.lblSelect.Text = "Select Time";
            // 
            // btnApplay
            // 
            this.btnApplay.Animated = true;
            this.btnApplay.AutoRoundedCorners = true;
            this.btnApplay.BorderRadius = 23;
            this.btnApplay.CheckedState.Parent = this.btnApplay;
            this.btnApplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApplay.CustomImages.Parent = this.btnApplay;
            this.btnApplay.FillColor = System.Drawing.Color.Black;
            this.btnApplay.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnApplay.Font = new System.Drawing.Font("FiraCode Nerd Font Propo", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplay.ForeColor = System.Drawing.Color.White;
            this.btnApplay.HoverState.Parent = this.btnApplay;
            this.btnApplay.Location = new System.Drawing.Point(258, 470);
            this.btnApplay.Margin = new System.Windows.Forms.Padding(4);
            this.btnApplay.Name = "btnApplay";
            this.btnApplay.ShadowDecoration.Parent = this.btnApplay;
            this.btnApplay.Size = new System.Drawing.Size(145, 48);
            this.btnApplay.TabIndex = 21;
            this.btnApplay.Text = "Applay";
            // 
            // btnCancel
            // 
            this.btnCancel.Animated = true;
            this.btnCancel.AutoRoundedCorners = true;
            this.btnCancel.BorderRadius = 23;
            this.btnCancel.CheckedState.Parent = this.btnCancel;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.CustomImages.Parent = this.btnCancel;
            this.btnCancel.FillColor = System.Drawing.Color.Black;
            this.btnCancel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.Font = new System.Drawing.Font("FiraCode Nerd Font Propo", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.HoverState.Parent = this.btnCancel;
            this.btnCancel.Location = new System.Drawing.Point(105, 470);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(145, 48);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancel";
            // 
            // gbCustomTime
            // 
            this.gbCustomTime.Controls.Add(this.cbSelectCustomTime);
            this.gbCustomTime.Controls.Add(this.cbSelectCustomNumber);
            this.gbCustomTime.Font = new System.Drawing.Font("FiraCode Nerd Font Propo", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCustomTime.ForeColor = System.Drawing.Color.Black;
            this.gbCustomTime.Location = new System.Drawing.Point(85, 210);
            this.gbCustomTime.Name = "gbCustomTime";
            this.gbCustomTime.ShadowDecoration.Parent = this.gbCustomTime;
            this.gbCustomTime.Size = new System.Drawing.Size(331, 155);
            this.gbCustomTime.TabIndex = 25;
            this.gbCustomTime.Text = "Custom Time";
            // 
            // cbSelectCustomNumber
            // 
            this.cbSelectCustomNumber.BackColor = System.Drawing.Color.Transparent;
            this.cbSelectCustomNumber.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSelectCustomNumber.DropDownHeight = 100;
            this.cbSelectCustomNumber.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbSelectCustomNumber.FocusedColor = System.Drawing.Color.Empty;
            this.cbSelectCustomNumber.FocusedState.Parent = this.cbSelectCustomNumber;
            this.cbSelectCustomNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbSelectCustomNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSelectCustomNumber.FormattingEnabled = true;
            this.cbSelectCustomNumber.HoverState.Parent = this.cbSelectCustomNumber;
            this.cbSelectCustomNumber.IntegralHeight = false;
            this.cbSelectCustomNumber.ItemHeight = 30;
            this.cbSelectCustomNumber.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cbSelectCustomNumber.ItemsAppearance.Parent = this.cbSelectCustomNumber;
            this.cbSelectCustomNumber.Location = new System.Drawing.Point(48, 72);
            this.cbSelectCustomNumber.Name = "cbSelectCustomNumber";
            this.cbSelectCustomNumber.ShadowDecoration.Parent = this.cbSelectCustomNumber;
            this.cbSelectCustomNumber.Size = new System.Drawing.Size(106, 36);
            this.cbSelectCustomNumber.TabIndex = 26;
            // 
            // cbSelectCustomTime
            // 
            this.cbSelectCustomTime.BackColor = System.Drawing.Color.Transparent;
            this.cbSelectCustomTime.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSelectCustomTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectCustomTime.FocusedColor = System.Drawing.Color.Empty;
            this.cbSelectCustomTime.FocusedState.Parent = this.cbSelectCustomTime;
            this.cbSelectCustomTime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbSelectCustomTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSelectCustomTime.FormattingEnabled = true;
            this.cbSelectCustomTime.HoverState.Parent = this.cbSelectCustomTime;
            this.cbSelectCustomTime.ItemHeight = 30;
            this.cbSelectCustomTime.Items.AddRange(new object[] {
            "Sec",
            "Min"});
            this.cbSelectCustomTime.ItemsAppearance.Parent = this.cbSelectCustomTime;
            this.cbSelectCustomTime.Location = new System.Drawing.Point(173, 72);
            this.cbSelectCustomTime.Name = "cbSelectCustomTime";
            this.cbSelectCustomTime.ShadowDecoration.Parent = this.cbSelectCustomTime;
            this.cbSelectCustomTime.Size = new System.Drawing.Size(86, 36);
            this.cbSelectCustomTime.TabIndex = 27;
            // 
            // frmTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(497, 571);
            this.Controls.Add(this.gbCustomTime);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApplay);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.cbSelectTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTime";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Time Settings";
            this.Load += new System.EventHandler(this.frmTime_Load);
            this.gbCustomTime.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label lblSelect;
        public Guna.UI2.WinForms.Guna2GradientButton btnApplay;
        public Guna.UI2.WinForms.Guna2GradientButton btnCancel;
        public Guna.UI2.WinForms.Guna2GroupBox gbCustomTime;
        public Guna.UI2.WinForms.Guna2ComboBox cbSelectCustomNumber;
        public Guna.UI2.WinForms.Guna2ComboBox cbSelectTime;
        public Guna.UI2.WinForms.Guna2ComboBox cbSelectCustomTime;
    }
}