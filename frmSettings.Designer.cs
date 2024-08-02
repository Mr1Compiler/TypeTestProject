namespace TypeTest
{
    partial class frmSettings
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
            MaterialSkin.MaterialListBoxItem materialListBoxItem1 = new MaterialSkin.MaterialListBoxItem();
            MaterialSkin.MaterialListBoxItem materialListBoxItem2 = new MaterialSkin.MaterialListBoxItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lbTest = new MaterialSkin.Controls.MaterialListBox();
            this.SuspendLayout();
            // 
            // lbTest
            // 
            this.lbTest.BackColor = System.Drawing.Color.Gray;
            this.lbTest.BorderColor = System.Drawing.Color.LightGray;
            this.lbTest.Depth = 0;
            this.lbTest.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbTest.Font = new System.Drawing.Font("Cascadia Mono", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            materialListBoxItem1.SecondaryText = "";
            materialListBoxItem1.Tag = null;
            materialListBoxItem1.Text = "First";
            materialListBoxItem2.SecondaryText = "";
            materialListBoxItem2.Tag = null;
            materialListBoxItem2.Text = "Colors";
            this.lbTest.Items.Add(materialListBoxItem1);
            this.lbTest.Items.Add(materialListBoxItem2);
            this.lbTest.Location = new System.Drawing.Point(0, 0);
            this.lbTest.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbTest.Name = "lbTest";
            this.lbTest.SelectedIndex = -1;
            this.lbTest.SelectedItem = null;
            this.lbTest.Size = new System.Drawing.Size(280, 551);
            this.lbTest.TabIndex = 2;
            this.lbTest.SelectedIndexChanged += new MaterialSkin.Controls.MaterialListBox.SelectedIndexChangedEventHandler(this.lbTest_SelectedIndexChanged);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 551);
            this.Controls.Add(this.lbTest);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSettings";
            this.Text = "Settings";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private MaterialSkin.Controls.MaterialListBox lbTest;
    }
}