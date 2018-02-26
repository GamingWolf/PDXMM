namespace PDXMM
{
    partial class MainWindow
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
            this.sidePanel = new System.Windows.Forms.Panel();
            this.eu4Btn = new System.Windows.Forms.Button();
            this.paradoxLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.ck2Btn = new System.Windows.Forms.Button();
            this.hoi4Btn = new System.Windows.Forms.Button();
            this.mmLabel = new System.Windows.Forms.Label();
            this.stellarisBtn = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.sidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.sidePanel.Controls.Add(this.eu4Btn);
            this.sidePanel.Controls.Add(this.paradoxLabel);
            this.sidePanel.Controls.Add(this.label1);
            this.sidePanel.Controls.Add(this.settingsBtn);
            this.sidePanel.Controls.Add(this.closeBtn);
            this.sidePanel.Controls.Add(this.ck2Btn);
            this.sidePanel.Controls.Add(this.hoi4Btn);
            this.sidePanel.Controls.Add(this.mmLabel);
            this.sidePanel.Controls.Add(this.stellarisBtn);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(232, 677);
            this.sidePanel.TabIndex = 0;
            // 
            // eu4Btn
            // 
            this.eu4Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.eu4Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.eu4Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eu4Btn.Font = new System.Drawing.Font("01 Digitall", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eu4Btn.ForeColor = System.Drawing.Color.White;
            this.eu4Btn.Location = new System.Drawing.Point(0, 368);
            this.eu4Btn.Name = "eu4Btn";
            this.eu4Btn.Size = new System.Drawing.Size(235, 54);
            this.eu4Btn.TabIndex = 9;
            this.eu4Btn.Text = "Europa Universalis IV";
            this.eu4Btn.UseVisualStyleBackColor = true;
            this.eu4Btn.Click += new System.EventHandler(this.eu4Btn_Click);
            // 
            // paradoxLabel
            // 
            this.paradoxLabel.Font = new System.Drawing.Font("01 Digitall", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paradoxLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.paradoxLabel.Location = new System.Drawing.Point(-3, 0);
            this.paradoxLabel.Name = "paradoxLabel";
            this.paradoxLabel.Size = new System.Drawing.Size(235, 42);
            this.paradoxLabel.TabIndex = 1;
            this.paradoxLabel.Text = "Paradox";
            this.paradoxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(148, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "v1.0";
            // 
            // settingsBtn
            // 
            this.settingsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.settingsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.settingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsBtn.Font = new System.Drawing.Font("01 Digitall", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsBtn.ForeColor = System.Drawing.Color.White;
            this.settingsBtn.Location = new System.Drawing.Point(0, 554);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(235, 54);
            this.settingsBtn.TabIndex = 7;
            this.settingsBtn.Text = "Settings";
            this.settingsBtn.UseVisualStyleBackColor = true;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.closeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("01 Digitall", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(0, 623);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(235, 54);
            this.closeBtn.TabIndex = 6;
            this.closeBtn.Text = "Exit";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // ck2Btn
            // 
            this.ck2Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.ck2Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.ck2Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ck2Btn.Font = new System.Drawing.Font("01 Digitall", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ck2Btn.ForeColor = System.Drawing.Color.White;
            this.ck2Btn.Location = new System.Drawing.Point(0, 296);
            this.ck2Btn.Name = "ck2Btn";
            this.ck2Btn.Size = new System.Drawing.Size(235, 54);
            this.ck2Btn.TabIndex = 5;
            this.ck2Btn.Text = "Crusader Kings II";
            this.ck2Btn.UseVisualStyleBackColor = true;
            this.ck2Btn.Click += new System.EventHandler(this.ck2Btn_Click);
            // 
            // hoi4Btn
            // 
            this.hoi4Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.hoi4Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.hoi4Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hoi4Btn.Font = new System.Drawing.Font("01 Digitall", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoi4Btn.ForeColor = System.Drawing.Color.White;
            this.hoi4Btn.Location = new System.Drawing.Point(0, 224);
            this.hoi4Btn.Name = "hoi4Btn";
            this.hoi4Btn.Size = new System.Drawing.Size(235, 54);
            this.hoi4Btn.TabIndex = 3;
            this.hoi4Btn.Text = "Hearts of Iron IV";
            this.hoi4Btn.UseVisualStyleBackColor = true;
            this.hoi4Btn.Click += new System.EventHandler(this.hoi4Btn_Click);
            // 
            // mmLabel
            // 
            this.mmLabel.AutoSize = true;
            this.mmLabel.Font = new System.Drawing.Font("Impact", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.mmLabel.Location = new System.Drawing.Point(46, 38);
            this.mmLabel.Name = "mmLabel";
            this.mmLabel.Size = new System.Drawing.Size(106, 21);
            this.mmLabel.TabIndex = 2;
            this.mmLabel.Text = "Mod Manager";
            // 
            // stellarisBtn
            // 
            this.stellarisBtn.BackColor = System.Drawing.Color.White;
            this.stellarisBtn.FlatAppearance.BorderSize = 0;
            this.stellarisBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.stellarisBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.stellarisBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stellarisBtn.Font = new System.Drawing.Font("01 Digitall", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stellarisBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.stellarisBtn.Location = new System.Drawing.Point(0, 152);
            this.stellarisBtn.Name = "stellarisBtn";
            this.stellarisBtn.Size = new System.Drawing.Size(235, 54);
            this.stellarisBtn.TabIndex = 0;
            this.stellarisBtn.Text = "Stellaris";
            this.stellarisBtn.UseVisualStyleBackColor = false;
            this.stellarisBtn.Click += new System.EventHandler(this.stellarisBtn_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MainPanel.Location = new System.Drawing.Point(232, 12);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(991, 665);
            this.MainPanel.TabIndex = 1;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1223, 677);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.sidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.Text = "PDXMM";
            this.sidePanel.ResumeLayout(false);
            this.sidePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button ck2Btn;
        private System.Windows.Forms.Button hoi4Btn;
        private System.Windows.Forms.Label mmLabel;
        private System.Windows.Forms.Label paradoxLabel;
        private System.Windows.Forms.Button stellarisBtn;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button eu4Btn;
    }
}

