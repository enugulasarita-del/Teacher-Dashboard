namespace TeacherDashboard.Forms
{
    partial class NoticesForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvNotices = new System.Windows.Forms.DataGridView();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNoticeTitle = new System.Windows.Forms.Label();
            this.txtNoticeTitle = new System.Windows.Forms.TextBox();
            this.lblNoticeContent = new System.Windows.Forms.Label();
            this.txtNoticeContent = new System.Windows.Forms.TextBox();
            this.lblNoticeDate = new System.Windows.Forms.Label();
            this.dtpNoticeDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddNotice = new System.Windows.Forms.Button();
            this.btnEditNotice = new System.Windows.Forms.Button();
            this.btnDeleteNotice = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotices)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1000, 70);
            this.panelTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(130, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "📝 Notices";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(850, 620);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 40);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "✕ Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvNotices
            // 
            this.dgvNotices.AllowUserToAddRows = false;
            this.dgvNotices.AllowUserToDeleteRows = false;
            this.dgvNotices.AllowUserToResizeColumns = false;
            this.dgvNotices.AllowUserToResizeRows = false;
            this.dgvNotices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNotices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNotices.BackgroundColor = System.Drawing.Color.White;
            this.dgvNotices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNotices.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNotices.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNotices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNotices.ColumnHeadersHeight = 40;
            this.dgvNotices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDate,
            this.colTitle,
            this.colContent});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNotices.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNotices.EnableHeadersVisualStyles = false;
            this.dgvNotices.GridColor = System.Drawing.Color.LightGray;
            this.dgvNotices.Location = new System.Drawing.Point(25, 90);
            this.dgvNotices.MultiSelect = false;
            this.dgvNotices.Name = "dgvNotices";
            this.dgvNotices.ReadOnly = true;
            this.dgvNotices.RowHeadersVisible = false;
            this.dgvNotices.RowTemplate.Height = 35;
            this.dgvNotices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotices.Size = new System.Drawing.Size(950, 350);
            this.dgvNotices.TabIndex = 1;
            this.dgvNotices.SelectionChanged += new System.EventHandler(this.dgvNotices_SelectionChanged);
            // 
            // colDate
            // 
            this.colDate.FillWeight = 80F;
            this.colDate.HeaderText = "Date";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colTitle
            // 
            this.colTitle.FillWeight = 120F;
            this.colTitle.HeaderText = "Title";
            this.colTitle.Name = "colTitle";
            this.colTitle.ReadOnly = true;
            // 
            // colContent
            // 
            this.colContent.FillWeight = 200F;
            this.colContent.HeaderText = "Content";
            this.colContent.Name = "colContent";
            this.colContent.ReadOnly = true;
            // 
            // lblNoticeTitle
            // 
            this.lblNoticeTitle.AutoSize = true;
            this.lblNoticeTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoticeTitle.Location = new System.Drawing.Point(25, 460);
            this.lblNoticeTitle.Name = "lblNoticeTitle";
            this.lblNoticeTitle.Size = new System.Drawing.Size(87, 17);
            this.lblNoticeTitle.TabIndex = 2;
            this.lblNoticeTitle.Text = "Notice Title:";
            // 
            // txtNoticeTitle
            // 
            this.txtNoticeTitle.Location = new System.Drawing.Point(120, 457);
            this.txtNoticeTitle.Name = "txtNoticeTitle";
            this.txtNoticeTitle.Size = new System.Drawing.Size(300, 25);
            this.txtNoticeTitle.TabIndex = 3;
            // 
            // lblNoticeContent
            // 
            this.lblNoticeContent.AutoSize = true;
            this.lblNoticeContent.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoticeContent.Location = new System.Drawing.Point(25, 490);
            this.lblNoticeContent.Name = "lblNoticeContent";
            this.lblNoticeContent.Size = new System.Drawing.Size(102, 17);
            this.lblNoticeContent.TabIndex = 4;
            this.lblNoticeContent.Text = "Notice Content:";
            // 
            // txtNoticeContent
            // 
            this.txtNoticeContent.Location = new System.Drawing.Point(120, 490);
            this.txtNoticeContent.Multiline = true;
            this.txtNoticeContent.Name = "txtNoticeContent";
            this.txtNoticeContent.Size = new System.Drawing.Size(300, 80);
            this.txtNoticeContent.TabIndex = 5;
            // 
            // lblNoticeDate
            // 
            this.lblNoticeDate.AutoSize = true;
            this.lblNoticeDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoticeDate.Location = new System.Drawing.Point(450, 460);
            this.lblNoticeDate.Name = "lblNoticeDate";
            this.lblNoticeDate.Size = new System.Drawing.Size(85, 17);
            this.lblNoticeDate.TabIndex = 6;
            this.lblNoticeDate.Text = "Notice Date:";
            // 
            // dtpNoticeDate
            // 
            this.dtpNoticeDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNoticeDate.Location = new System.Drawing.Point(545, 457);
            this.dtpNoticeDate.Name = "dtpNoticeDate";
            this.dtpNoticeDate.Size = new System.Drawing.Size(150, 20);
            this.dtpNoticeDate.TabIndex = 7;
            // 
            // btnAddNotice
            // 
            this.btnAddNotice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnAddNotice.FlatAppearance.BorderSize = 0;
            this.btnAddNotice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNotice.ForeColor = System.Drawing.Color.White;
            this.btnAddNotice.Location = new System.Drawing.Point(453, 500);
            this.btnAddNotice.Name = "btnAddNotice";
            this.btnAddNotice.Size = new System.Drawing.Size(100, 30);
            this.btnAddNotice.TabIndex = 8;
            this.btnAddNotice.Text = "Add Notice";
            this.btnAddNotice.UseVisualStyleBackColor = false;
            this.btnAddNotice.Click += new System.EventHandler(this.btnAddNotice_Click);
            // 
            // btnEditNotice
            // 
            this.btnEditNotice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnEditNotice.FlatAppearance.BorderSize = 0;
            this.btnEditNotice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditNotice.ForeColor = System.Drawing.Color.White;
            this.btnEditNotice.Location = new System.Drawing.Point(563, 500);
            this.btnEditNotice.Name = "btnEditNotice";
            this.btnEditNotice.Size = new System.Drawing.Size(100, 30);
            this.btnEditNotice.TabIndex = 9;
            this.btnEditNotice.Text = "Edit Notice";
            this.btnEditNotice.UseVisualStyleBackColor = false;
            this.btnEditNotice.Click += new System.EventHandler(this.btnEditNotice_Click);
            // 
            // btnDeleteNotice
            // 
            this.btnDeleteNotice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnDeleteNotice.FlatAppearance.BorderSize = 0;
            this.btnDeleteNotice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteNotice.ForeColor = System.Drawing.Color.White;
            this.btnDeleteNotice.Location = new System.Drawing.Point(673, 500);
            this.btnDeleteNotice.Name = "btnDeleteNotice";
            this.btnDeleteNotice.Size = new System.Drawing.Size(100, 30);
            this.btnDeleteNotice.TabIndex = 10;
            this.btnDeleteNotice.Text = "Delete Notice";
            this.btnDeleteNotice.UseVisualStyleBackColor = false;
            this.btnDeleteNotice.Click += new System.EventHandler(this.btnDeleteNotice_Click);
            // 
            // NoticesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 680);
            this.Controls.Add(this.btnDeleteNotice);
            this.Controls.Add(this.btnEditNotice);
            this.Controls.Add(this.btnAddNotice);
            this.Controls.Add(this.dtpNoticeDate);
            this.Controls.Add(this.lblNoticeDate);
            this.Controls.Add(this.txtNoticeContent);
            this.Controls.Add(this.lblNoticeContent);
            this.Controls.Add(this.txtNoticeTitle);
            this.Controls.Add(this.lblNoticeTitle);
            this.Controls.Add(this.dgvNotices);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panelTop);
            this.Name = "NoticesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notices";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvNotices;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContent;
        private System.Windows.Forms.Label lblNoticeTitle;
        private System.Windows.Forms.TextBox txtNoticeTitle;
        private System.Windows.Forms.Label lblNoticeContent;
        private System.Windows.Forms.TextBox txtNoticeContent;
        private System.Windows.Forms.Label lblNoticeDate;
        private System.Windows.Forms.DateTimePicker dtpNoticeDate;
        private System.Windows.Forms.Button btnAddNotice;
        private System.Windows.Forms.Button btnEditNotice;
        private System.Windows.Forms.Button btnDeleteNotice;
    }
}
