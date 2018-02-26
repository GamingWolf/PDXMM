namespace PDXMM
{
    partial class MissingModControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.missingDataGrid = new System.Windows.Forms.DataGridView();
            this.MissingMods = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doneBtn = new System.Windows.Forms.Button();
            this.updateBar = new CircularProgressBar.CircularProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.missingDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(985, 77);
            this.label1.TabIndex = 0;
            this.label1.Text = "You are missing mods!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(985, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Please download them below and try again!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // missingDataGrid
            // 
            this.missingDataGrid.AllowUserToAddRows = false;
            this.missingDataGrid.AllowUserToDeleteRows = false;
            this.missingDataGrid.AllowUserToResizeColumns = false;
            this.missingDataGrid.AllowUserToResizeRows = false;
            this.missingDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.missingDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.missingDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.missingDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.missingDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.missingDataGrid.ColumnHeadersVisible = false;
            this.missingDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MissingMods,
            this.ID});
            this.missingDataGrid.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.missingDataGrid.Location = new System.Drawing.Point(0, 103);
            this.missingDataGrid.Name = "missingDataGrid";
            this.missingDataGrid.ReadOnly = true;
            this.missingDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.missingDataGrid.RowHeadersVisible = false;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.missingDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.missingDataGrid.Size = new System.Drawing.Size(991, 507);
            this.missingDataGrid.TabIndex = 2;
            this.missingDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.missingDataGrid_CellContentClick);
            // 
            // MissingMods
            // 
            this.MissingMods.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.MissingMods.HeaderText = "MissingMods";
            this.MissingMods.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.MissingMods.Name = "MissingMods";
            this.MissingMods.ReadOnly = true;
            this.MissingMods.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MissingMods.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.MissingMods.Text = "";
            this.MissingMods.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.MissingMods.Width = 991;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // doneBtn
            // 
            this.doneBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.doneBtn.FlatAppearance.BorderSize = 0;
            this.doneBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.doneBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.doneBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doneBtn.Font = new System.Drawing.Font("01 Digitall", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneBtn.ForeColor = System.Drawing.Color.White;
            this.doneBtn.Location = new System.Drawing.Point(450, 616);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.doneBtn.Size = new System.Drawing.Size(90, 46);
            this.doneBtn.TabIndex = 5;
            this.doneBtn.Text = "DONE";
            this.doneBtn.UseVisualStyleBackColor = false;
            this.doneBtn.Visible = false;
            this.doneBtn.Click += new System.EventHandler(this.doneBtn_Click);
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
            this.updateBar.Location = new System.Drawing.Point(335, 145);
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
            this.updateBar.TabIndex = 7;
            this.updateBar.Text = "144|195";
            this.updateBar.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            // 
            // MissingModControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.updateBar);
            this.Controls.Add(this.doneBtn);
            this.Controls.Add(this.missingDataGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MissingModControl";
            this.Size = new System.Drawing.Size(991, 665);
            ((System.ComponentModel.ISupportInitialize)(this.missingDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView missingDataGrid;
        private System.Windows.Forms.DataGridViewLinkColumn MissingMods;
        private System.Windows.Forms.Button doneBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private CircularProgressBar.CircularProgressBar updateBar;
    }
}
