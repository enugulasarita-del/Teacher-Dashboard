namespace TeacherDashboard.Controls
{
    partial class VacLecturesControl
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
            this.lblHeader = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvVac)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(22)))), ((int)(((byte)(37))))); // Updated ForeColor
            this.lblHeader.Location = new System.Drawing.Point(20, 20);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(263, 30);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "VAC Lectures Schedule";
            // 
            // dgvVac
            // 
            this.dgvVac.AllowUserToAddRows = false;
            this.dgvVac.AllowUserToDeleteRows = false;
            this.dgvVac.AllowUserToResizeColumns = false;
            this.dgvVac.AllowUserToResizeRows = false;
            this.dgvVac.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVac.BackgroundColor = System.Drawing.Color.White;
            this.dgvVac.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVac.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvVac.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(22)))), ((int)(((byte)(37))))); // Updated BackColor
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVac.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVac.ColumnHeadersHeight = 40;
            this.dgvVac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colTitle,
            this.colDate,
            this.colTime,
            this.colFaculty,
            this.colVenue,
            this.colLink});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVac.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVac.EnableHeadersVisualStyles = false;
            this.dgvVac.GridColor = System.Drawing.Color.LightGray;
            this.dgvVac.Location = new System.Drawing.Point(25, 70);
            this.dgvVac.MultiSelect = false;
            this.dgvVac.Name = "dgvVac";
            this.dgvVac.ReadOnly = true;
            this.dgvVac.RowHeadersVisible = false;
            this.dgvVac.RowTemplate.Height = 35;
            this.dgvVac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVac.Size = new System.Drawing.Size(750, 250);
            this.dgvVac.TabIndex = 1;
            this.dgvVac.SelectionChanged += new System.EventHandler(this.dgvVac_SelectionChanged);
            this.dgvVac.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVac_CellContentClick);
            // 
            // colId
            // 
            this.colId.FillWeight = 40F;
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colTitle
            // 
            this.colTitle.FillWeight = 120F;
            this.colTitle.HeaderText = "Title";
            this.colTitle.Name = "colTitle";
            this.colTitle.ReadOnly = true;
            // 
            // colDate
            // 
            this.colDate.FillWeight = 80F;
            this.colDate.HeaderText = "Date";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colTime
            // 
            this.colTime.FillWeight = 60F;
            this.colTime.HeaderText = "Time";
            this.colTime.Name = "colTime";
            this.colTime.ReadOnly = true;
            // 
            // colFaculty
            // 
            this.colFaculty.FillWeight = 100F;
            this.colFaculty.HeaderText = "Faculty";
            this.colFaculty.Name = "colFaculty";
            this.colFaculty.ReadOnly = true;
            // 
            // colVenue
            // 
            this.colVenue.FillWeight = 80F;
            this.colVenue.HeaderText = "Venue";
            this.colVenue.Name = "colVenue";
            this.colVenue.ReadOnly = true;
            // 
            // colLink
            // 
            this.colLink.FillWeight = 80F;
            this.colLink.HeaderText = "Link";
            this.colLink.Name = "colLink";
            this.colLink.ReadOnly = true;
            this.colLink.Text = "View Link";
            this.colLink.UseColumnTextForLinkValue = true;
            // 
            // lblLectureTitle
            // 
            this.lblLectureTitle.AutoSize = true;
            this.lblLectureTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLectureTitle.Location = new System.Drawing.Point(25, 340);
            this.lblLectureTitle.Name = "lblLectureTitle";
            this.lblLectureTitle.Size = new System.Drawing.Size(91, 17);
            this.lblLectureTitle.TabIndex = 2;
            this.lblLectureTitle.Text = "Lecture Title:";
            // 
            // txtLectureTitle
            // 
            this.txtLectureTitle.Location = new System.Drawing.Point(120, 337);
            this.txtLectureTitle.Name = "txtLectureTitle";
            this.txtLectureTitle.Size = new System.Drawing.Size(200, 20);
            this.txtLectureTitle.TabIndex = 3;
            // 
            // lblFaculty
            // 
            this.lblFaculty.AutoSize = true;
            this.lblFaculty.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaculty.Location = new System.Drawing.Point(350, 340);
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Size = new System.Drawing.Size(57, 17);
            this.lblFaculty.TabIndex = 4;
            this.lblFaculty.Text = "Faculty:";
            // 
            // txtFaculty
            // 
            this.txtFaculty.Location = new System.Drawing.Point(410, 337);
            this.txtFaculty.Name = "txtFaculty";
            this.txtFaculty.Size = new System.Drawing.Size(200, 20);
            this.txtFaculty.TabIndex = 5;
            // 
            // lblLectureDate
            // 
            this.lblLectureDate.AutoSize = true;
            this.lblLectureDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLectureDate.Location = new System.Drawing.Point(25, 370);
            this.lblLectureDate.Name = "lblLectureDate";
            this.lblLectureDate.Size = new System.Drawing.Size(90, 17);
            this.lblLectureDate.TabIndex = 6;
            this.lblLectureDate.Text = "Lecture Date:";
            // 
            // dtpLectureDate
            // 
            this.dtpLectureDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLectureDate.Location = new System.Drawing.Point(120, 367);
            this.dtpLectureDate.Name = "dtpLectureDate";
            this.dtpLectureDate.Size = new System.Drawing.Size(200, 20);
            this.dtpLectureDate.TabIndex = 7;
            // 
            // lblLectureTime
            // 
            this.lblLectureTime.AutoSize = true;
            this.lblLectureTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLectureTime.Location = new System.Drawing.Point(350, 370);
            this.lblLectureTime.Name = "lblLectureTime";
            this.lblLectureTime.Size = new System.Drawing.Size(92, 17);
            this.lblLectureTime.TabIndex = 8;
            this.lblLectureTime.Text = "Lecture Time:";
            // 
            // txtLectureTime
            // 
            this.txtLectureTime.Location = new System.Drawing.Point(410, 367);
            this.txtLectureTime.Name = "txtLectureTime";
            this.txtLectureTime.Size = new System.Drawing.Size(200, 20);
            this.txtLectureTime.TabIndex = 9;
            // 
            // lblVenue
            // 
            this.lblVenue.AutoSize = true;
            this.lblVenue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenue.Location = new System.Drawing.Point(25, 400);
            this.lblVenue.Name = "lblVenue";
            this.lblVenue.Size = new System.Drawing.Size(50, 17);
            this.lblVenue.TabIndex = 10;
            this.lblVenue.Text = "Venue:";
            // 
            // txtVenue
            // 
            this.txtVenue.Location = new System.Drawing.Point(120, 397);
            this.txtVenue.Name = "txtVenue";
            this.txtVenue.Size = new System.Drawing.Size(200, 20);
            this.txtVenue.TabIndex = 11;
            // 
            // lblLectureLink
            // 
            this.lblLectureLink.AutoSize = true;
            this.lblLectureLink.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLectureLink.Location = new System.Drawing.Point(350, 400);
            this.lblLectureLink.Name = "lblLectureLink";
            this.lblLectureLink.Size = new System.Drawing.Size(84, 17);
            this.lblLectureLink.TabIndex = 12;
            this.lblLectureLink.Text = "Lecture Link:";
            // 
            // txtLectureLink
            // 
            this.txtLectureLink.Location = new System.Drawing.Point(410, 397);
            this.txtLectureLink.Name = "txtLectureLink";
            this.txtLectureLink.Size = new System.Drawing.Size(200, 20);
            this.txtLectureLink.TabIndex = 13;
            // 
            // btnAddLecture
            // 
            this.btnAddLecture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.btnAddLecture.FlatAppearance.BorderSize = 0;
            this.btnAddLecture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLecture.ForeColor = System.Drawing.Color.White;
            this.btnAddLecture.Location = new System.Drawing.Point(25, 440);
            this.btnAddLecture.Name = "btnAddLecture";
            this.btnAddLecture.Size = new System.Drawing.Size(120, 30);
            this.btnAddLecture.TabIndex = 14;
            this.btnAddLecture.Text = "Add Lecture";
            this.btnAddLecture.UseVisualStyleBackColor = false;
            this.btnAddLecture.Click += new System.EventHandler(this.btnAddLecture_Click);
            // 
            // btnEditLecture
            // 
            this.btnEditLecture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.btnEditLecture.FlatAppearance.BorderSize = 0;
            this.btnEditLecture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditLecture.ForeColor = System.Drawing.Color.White;
            this.btnEditLecture.Location = new System.Drawing.Point(155, 440);
            this.btnEditLecture.Name = "btnEditLecture";
            this.btnEditLecture.Size = new System.Drawing.Size(120, 30);
            this.btnEditLecture.TabIndex = 15;
            this.btnEditLecture.Text = "Edit Lecture";
            this.btnEditLecture.UseVisualStyleBackColor = false;
            this.btnEditLecture.Click += new System.EventHandler(this.btnEditLecture_Click);
            // 
            // btnDeleteLecture
            // 
            this.btnDeleteLecture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.btnDeleteLecture.FlatAppearance.BorderSize = 0;
            this.btnDeleteLecture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteLecture.ForeColor = System.Drawing.Color.White;
            this.btnDeleteLecture.Location = new System.Drawing.Point(285, 440);
            this.btnDeleteLecture.Name = "btnDeleteLecture";
            this.btnDeleteLecture.Size = new System.Drawing.Size(120, 30);
            this.btnDeleteLecture.TabIndex = 16;
            this.btnDeleteLecture.Text = "Delete Lecture";
            this.btnDeleteLecture.UseVisualStyleBackColor = false;
            this.btnDeleteLecture.Click += new System.EventHandler(this.btnDeleteLecture_Click);
            // 
            // VacLecturesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnDeleteLecture);
            this.Controls.Add(this.btnEditLecture);
            this.Controls.Add(this.btnAddLecture);
            this.Controls.Add(this.txtLectureLink);
            this.Controls.Add(this.lblLectureLink);
            this.Controls.Add(this.txtVenue);
            this.Controls.Add(this.lblVenue);
            this.Controls.Add(this.txtLectureTime);
            this.Controls.Add(this.lblLectureTime);
            this.Controls.Add(this.dtpLectureDate);
            this.Controls.Add(this.lblLectureDate);
            this.Controls.Add(this.txtFaculty);
            this.Controls.Add(this.lblFaculty);
            this.Controls.Add(this.txtLectureTitle);
            this.Controls.Add(this.lblLectureTitle);
            this.Controls.Add(this.dgvVac);
            this.Controls.Add(this.lblHeader);
            this.Name = "VacLecturesControl";
            this.Size = new System.Drawing.Size(800, 600);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblHeader;
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
