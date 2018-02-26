namespace PDXMM
{
    partial class ContentControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.nameLbl = new System.Windows.Forms.Label();
            this.dataGridDisp = new System.Windows.Forms.DataGridView();
            this.applyBtn = new System.Windows.Forms.Button();
            this.updateBar = new CircularProgressBar.CircularProgressBar();
            this.pasteBtn = new System.Windows.Forms.Button();
            this.copyBtn = new System.Windows.Forms.Button();
            this.presetBtn = new System.Windows.Forms.Button();
            this.Active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Origin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModName = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDisp)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("01 Digitall", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.Location = new System.Drawing.Point(3, 3);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(530, 52);
            this.nameLbl.TabIndex = 0;
            this.nameLbl.Text = "Europa Universalis IV";
            this.nameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridDisp
            // 
            this.dataGridDisp.AllowUserToAddRows = false;
            this.dataGridDisp.AllowUserToDeleteRows = false;
            this.dataGridDisp.AllowUserToOrderColumns = true;
            this.dataGridDisp.AllowUserToResizeColumns = false;
            this.dataGridDisp.AllowUserToResizeRows = false;
            this.dataGridDisp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridDisp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridDisp.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridDisp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridDisp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridDisp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridDisp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDisp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Active,
            this.Origin,
            this.ModName,
            this.ID});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridDisp.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridDisp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridDisp.GridColor = System.Drawing.Color.White;
            this.dataGridDisp.Location = new System.Drawing.Point(0, 55);
            this.dataGridDisp.Name = "dataGridDisp";
            this.dataGridDisp.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridDisp.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridDisp.RowHeadersVisible = false;
            this.dataGridDisp.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridDisp.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridDisp.Size = new System.Drawing.Size(991, 610);
            this.dataGridDisp.TabIndex = 1;
            this.dataGridDisp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDisp_CellContentClick);
            // 
            // applyBtn
            // 
            this.applyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.applyBtn.FlatAppearance.BorderSize = 0;
            this.applyBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.applyBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.applyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.applyBtn.Font = new System.Drawing.Font("01 Digitall", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyBtn.ForeColor = System.Drawing.Color.White;
            this.applyBtn.Location = new System.Drawing.Point(895, 3);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.applyBtn.Size = new System.Drawing.Size(90, 46);
            this.applyBtn.TabIndex = 4;
            this.applyBtn.Text = "APPLY";
            this.applyBtn.UseVisualStyleBackColor = false;
            // 
            // updateBar
            // 
            this.updateBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.updateBar.AnimationSpeed = 500;
            this.updateBar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateBar.Font = new System.Drawing.Font("01 Digitall", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.updateBar.InnerColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateBar.InnerMargin = 5;
            this.updateBar.InnerWidth = -5;
            this.updateBar.Location = new System.Drawing.Point(330, 200);
            this.updateBar.MarqueeAnimationSpeed = 2000;
            this.updateBar.Name = "updateBar";
            this.updateBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.updateBar.OuterMargin = -25;
            this.updateBar.OuterWidth = 24;
            this.updateBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.updateBar.ProgressWidth = 26;
            this.updateBar.SecondaryFont = new System.Drawing.Font("ROG Fonts v1.6", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBar.Size = new System.Drawing.Size(320, 320);
            this.updateBar.StartAngle = 270;
            this.updateBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.updateBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.updateBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.updateBar.SubscriptText = "";
            this.updateBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.updateBar.SuperscriptMargin = new System.Windows.Forms.Padding(-115, 0, 0, 1);
            this.updateBar.SuperscriptText = "";
            this.updateBar.TabIndex = 6;
            this.updateBar.Text = "144|195";
            this.updateBar.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.updateBar.Value = 68;
            // 
            // pasteBtn
            // 
            this.pasteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.pasteBtn.FlatAppearance.BorderSize = 0;
            this.pasteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pasteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pasteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pasteBtn.Font = new System.Drawing.Font("01 Digitall", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pasteBtn.ForeColor = System.Drawing.Color.White;
            this.pasteBtn.Location = new System.Drawing.Point(782, 3);
            this.pasteBtn.Name = "pasteBtn";
            this.pasteBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pasteBtn.Size = new System.Drawing.Size(90, 46);
            this.pasteBtn.TabIndex = 7;
            this.pasteBtn.Text = "PASTE";
            this.pasteBtn.UseVisualStyleBackColor = false;
            this.pasteBtn.Click += new System.EventHandler(this.pasteBtn_Click);
            // 
            // copyBtn
            // 
            this.copyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.copyBtn.FlatAppearance.BorderSize = 0;
            this.copyBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.copyBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.copyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyBtn.Font = new System.Drawing.Font("01 Digitall", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyBtn.ForeColor = System.Drawing.Color.White;
            this.copyBtn.Location = new System.Drawing.Point(669, 3);
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.copyBtn.Size = new System.Drawing.Size(90, 46);
            this.copyBtn.TabIndex = 8;
            this.copyBtn.Text = "COPY";
            this.copyBtn.UseVisualStyleBackColor = false;
            this.copyBtn.Click += new System.EventHandler(this.copyBtn_Click);
            // 
            // presetBtn
            // 
            this.presetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.presetBtn.FlatAppearance.BorderSize = 0;
            this.presetBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.presetBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.presetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.presetBtn.Font = new System.Drawing.Font("01 Digitall", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presetBtn.ForeColor = System.Drawing.Color.White;
            this.presetBtn.Location = new System.Drawing.Point(556, 3);
            this.presetBtn.Name = "presetBtn";
            this.presetBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.presetBtn.Size = new System.Drawing.Size(90, 46);
            this.presetBtn.TabIndex = 9;
            this.presetBtn.Text = "PRESETS";
            this.presetBtn.UseVisualStyleBackColor = false;
            // 
            // Active
            // 
            this.Active.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Active.FalseValue = "0";
            this.Active.HeaderText = "Active";
            this.Active.Name = "Active";
            this.Active.ReadOnly = true;
            this.Active.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Active.TrueValue = "1";
            this.Active.Width = 49;
            // 
            // Origin
            // 
            this.Origin.HeaderText = "Origin";
            this.Origin.Name = "Origin";
            this.Origin.ReadOnly = true;
            this.Origin.Visible = false;
            // 
            // ModName
            // 
            this.ModName.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ModName.FillWeight = 21.2766F;
            this.ModName.HeaderText = "Name";
            this.ModName.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ModName.Name = "ModName";
            this.ModName.ReadOnly = true;
            this.ModName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ModName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ModName.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID.FillWeight = 178.7234F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // ContentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.presetBtn);
            this.Controls.Add(this.copyBtn);
            this.Controls.Add(this.pasteBtn);
            this.Controls.Add(this.updateBar);
            this.Controls.Add(this.applyBtn);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.dataGridDisp);
            this.Name = "ContentControl";
            this.Size = new System.Drawing.Size(991, 665);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDisp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Button applyBtn;
        private CircularProgressBar.CircularProgressBar updateBar;
        private System.Windows.Forms.Button pasteBtn;
        private System.Windows.Forms.Button copyBtn;
        private System.Windows.Forms.Button presetBtn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Active;
        private System.Windows.Forms.DataGridViewTextBoxColumn Origin;
        private System.Windows.Forms.DataGridViewLinkColumn ModName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridView dataGridDisp;
    }
}
