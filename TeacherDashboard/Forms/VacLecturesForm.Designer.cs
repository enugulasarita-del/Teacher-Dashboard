namespace TeacherDashboard.Forms
{
    partial class VacLecturesForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) { if (disposing && (components != null)) { components.Dispose(); } base.Dispose(disposing); }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvVac = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFaculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVenue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLink = new System.Windows.Forms.DataGridViewLinkColumn();
            this.lblLectureTitle = new System.Windows.Forms.Label();
            this.txtLectureTitle = new System.Windows.Forms.TextBox();
            this.lblFaculty = new System.Windows.Forms.Label();
            this.txtFaculty = new System.Windows.Forms.TextBox();
            this.lblLectureDate = new System.Windows.Forms.Label();
            this.dtpLectureDate = new System.Windows.Forms.DateTimePicker();
            this.lblLectureTime = new System.Windows.Forms.Label();
            this.txtLectureTime = new System.Windows.Forms.TextBox();
            this.lblVenue = new System.Windows.Forms.Label();
            this.txtVenue = new System.Windows.Forms.TextBox();
            this.lblLectureLink = new System.Windows.Forms.Label();
            this.txtLectureLink = new System.Windows.Forms.TextBox();
            this.btnAddLecture = new System.Windows.Forms.Button();
            this.btnEditLecture = new System.Windows.Forms.Button();
            this.btnDeleteLecture = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVac)).BeginInit();
            this.SuspendLayout();
            
            // panelTop
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(173, 22, 37);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1000, 70);
            this.panelTop.TabIndex = 0;
            
            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "🎥 VAC Lectures";
            
            // btnClose
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(173, 22, 37);
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(850, 620);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 40);
            this.btnClose.Text = "✕ Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // dgvVac
            this.dgvVac.AllowUserToAddRows = false;
            this.dgvVac.AllowUserToDeleteRows = false;
            this.dgvVac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVac.BackgroundColor = System.Drawing.Color.White;
            this.dgvVac.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(173, 22, 37);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvVac.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVac.ColumnHeadersHeight = 40;
            this.dgvVac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId, this.colTitle, this.colDate, this.colTime, this.colFaculty, this.colVenue, this.colLink});
            this.dgvVac.EnableHeadersVisualStyles = false;
            this.dgvVac.Location = new System.Drawing.Point(25, 90);
            this.dgvVac.Name = "dgvVac";
            this.dgvVac.ReadOnly = true;
            this.dgvVac.RowHeadersVisible = false;
            this.dgvVac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVac.Size = new System.Drawing.Size(950, 300); // Expanded size
            this.dgvVac.SelectionChanged += new System.EventHandler(this.dgvVac_SelectionChanged);
            this.dgvVac.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVac_CellContentClick);

            // Columns
            this.colId.HeaderText = "ID"; this.colId.FillWeight = 40F;
            this.colTitle.HeaderText = "Title"; this.colTitle.FillWeight = 120F;
            this.colDate.HeaderText = "Date"; this.colDate.FillWeight = 80F;
            this.colTime.HeaderText = "Time"; this.colTime.FillWeight = 60F;
            this.colFaculty.HeaderText = "Faculty"; this.colFaculty.FillWeight = 100F;
            this.colVenue.HeaderText = "Venue"; this.colVenue.FillWeight = 80F;
            this.colLink.HeaderText = "Link"; this.colLink.FillWeight = 80F;

            // Inputs Row 1 (Title, Faculty)
            this.lblLectureTitle.Text = "Lecture Title:"; this.lblLectureTitle.Location = new System.Drawing.Point(25, 410); this.lblLectureTitle.AutoSize = true; this.lblLectureTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtLectureTitle.Location = new System.Drawing.Point(130, 407); this.txtLectureTitle.Size = new System.Drawing.Size(250, 25);
            
            this.lblFaculty.Text = "Faculty:"; this.lblFaculty.Location = new System.Drawing.Point(450, 410); this.lblFaculty.AutoSize = true; this.lblFaculty.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtFaculty.Location = new System.Drawing.Point(520, 407); this.txtFaculty.Size = new System.Drawing.Size(250, 25);

            // Inputs Row 2 (Date, Time)
            this.lblLectureDate.Text = "Date:"; this.lblLectureDate.Location = new System.Drawing.Point(25, 450); this.lblLectureDate.AutoSize = true; this.lblLectureDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dtpLectureDate.Location = new System.Drawing.Point(130, 447); this.dtpLectureDate.Size = new System.Drawing.Size(250, 25);
            
            this.lblLectureTime.Text = "Time:"; this.lblLectureTime.Location = new System.Drawing.Point(450, 450); this.lblLectureTime.AutoSize = true; this.lblLectureTime.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtLectureTime.Location = new System.Drawing.Point(520, 447); this.txtLectureTime.Size = new System.Drawing.Size(250, 25);

            // Inputs Row 3 (Venue, Link)
            this.lblVenue.Text = "Venue:"; this.lblVenue.Location = new System.Drawing.Point(25, 490); this.lblVenue.AutoSize = true; this.lblVenue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtVenue.Location = new System.Drawing.Point(130, 487); this.txtVenue.Size = new System.Drawing.Size(250, 25);

            this.lblLectureLink.Text = "Link:"; this.lblLectureLink.Location = new System.Drawing.Point(450, 490); this.lblLectureLink.AutoSize = true; this.lblLectureLink.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtLectureLink.Location = new System.Drawing.Point(520, 487); this.txtLectureLink.Size = new System.Drawing.Size(250, 25);

            // Buttons
            this.btnAddLecture.Text = "Add Lecture"; this.btnAddLecture.Location = new System.Drawing.Point(130, 540); this.btnAddLecture.Size = new System.Drawing.Size(120, 35);
            this.btnAddLecture.BackColor = System.Drawing.Color.FromArgb(40, 167, 69); this.btnAddLecture.ForeColor = System.Drawing.Color.White; this.btnAddLecture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLecture.Click += new System.EventHandler(this.btnAddLecture_Click);

            this.btnEditLecture.Text = "Edit Lecture"; this.btnEditLecture.Location = new System.Drawing.Point(260, 540); this.btnEditLecture.Size = new System.Drawing.Size(120, 35);
            this.btnEditLecture.BackColor = System.Drawing.Color.FromArgb(0, 123, 255); this.btnEditLecture.ForeColor = System.Drawing.Color.White; this.btnEditLecture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditLecture.Click += new System.EventHandler(this.btnEditLecture_Click);

            this.btnDeleteLecture.Text = "Delete Lecture"; this.btnDeleteLecture.Location = new System.Drawing.Point(390, 540); this.btnDeleteLecture.Size = new System.Drawing.Size(120, 35);
            this.btnDeleteLecture.BackColor = System.Drawing.Color.FromArgb(220, 53, 69); this.btnDeleteLecture.ForeColor = System.Drawing.Color.White; this.btnDeleteLecture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteLecture.Click += new System.EventHandler(this.btnDeleteLecture_Click);

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 680);
            this.Controls.Add(this.btnDeleteLecture);
            this.Controls.Add(this.btnEditLecture);
            this.Controls.Add(this.btnAddLecture);
            this.Controls.Add(this.txtLectureLink); this.Controls.Add(this.lblLectureLink);
            this.Controls.Add(this.txtVenue); this.Controls.Add(this.lblVenue);
            this.Controls.Add(this.txtLectureTime); this.Controls.Add(this.lblLectureTime);
            this.Controls.Add(this.dtpLectureDate); this.Controls.Add(this.lblLectureDate);
            this.Controls.Add(this.txtFaculty); this.Controls.Add(this.lblFaculty);
            this.Controls.Add(this.txtLectureTitle); this.Controls.Add(this.lblLectureTitle);
            this.Controls.Add(this.dgvVac);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panelTop);
            this.Name = "VacLecturesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VAC Lectures";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvVac;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFaculty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVenue;
        private System.Windows.Forms.DataGridViewLinkColumn colLink;
        private System.Windows.Forms.Label lblLectureTitle;
        private System.Windows.Forms.TextBox txtLectureTitle;
        private System.Windows.Forms.Label lblFaculty;
        private System.Windows.Forms.TextBox txtFaculty;
        private System.Windows.Forms.Label lblLectureDate;
        private System.Windows.Forms.DateTimePicker dtpLectureDate;
        private System.Windows.Forms.Label lblLectureTime;
        private System.Windows.Forms.TextBox txtLectureTime;
        private System.Windows.Forms.Label lblVenue;
        private System.Windows.Forms.TextBox txtVenue;
        private System.Windows.Forms.Label lblLectureLink;
        private System.Windows.Forms.TextBox txtLectureLink;
        private System.Windows.Forms.Button btnAddLecture;
        private System.Windows.Forms.Button btnEditLecture;
        private System.Windows.Forms.Button btnDeleteLecture;
    }
}
