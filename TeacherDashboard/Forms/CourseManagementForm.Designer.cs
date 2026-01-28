namespace TeacherDashboard.Forms
{
    partial class CourseManagementForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) { if (disposing && (components != null)) { components.Dispose(); } base.Dispose(disposing); }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvCourses = new System.Windows.Forms.DataGridView();
            this.colCourseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCredits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInstructor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCourseID = new System.Windows.Forms.Label();
            this.txtCourseID = new System.Windows.Forms.TextBox();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.lblCredits = new System.Windows.Forms.Label();
            this.txtCredits = new System.Windows.Forms.TextBox();
            this.lblInstructor = new System.Windows.Forms.Label();
            this.txtInstructor = new System.Windows.Forms.TextBox();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnEditCourse = new System.Windows.Forms.Button();
            this.btnDeleteCourse = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
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
            this.lblTitle.Text = "📚 Course Management";

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

            // Search
            this.lblSearch.Text = "Search Course:"; this.lblSearch.Location = new System.Drawing.Point(25, 85); this.lblSearch.AutoSize = true; this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtSearch.Location = new System.Drawing.Point(135, 82); this.txtSearch.Size = new System.Drawing.Size(300, 25);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);

            // dgvCourses
            this.dgvCourses.Location = new System.Drawing.Point(25, 120);
            this.dgvCourses.Size = new System.Drawing.Size(950, 280);
            this.dgvCourses.AllowUserToAddRows = false;
            this.dgvCourses.AllowUserToDeleteRows = false;
            this.dgvCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCourses.BackgroundColor = System.Drawing.Color.White;
            this.dgvCourses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCourses.ReadOnly = true;
            this.dgvCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCourses.RowHeadersVisible = false;
            this.dgvCourses.ColumnHeadersHeight = 40;
            this.dgvCourses.EnableHeadersVisualStyles = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(173, 22, 37);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvCourses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.colCourseID, this.colCourseName, this.colDepartment, this.colCredits, this.colInstructor });
            this.dgvCourses.SelectionChanged += new System.EventHandler(this.dgvCourses_SelectionChanged);
            
            // Columns
            this.colCourseID.HeaderText = "Course ID"; this.colCourseID.FillWeight = 50F;
            this.colCourseName.HeaderText = "Course Name"; this.colCourseName.FillWeight = 150F;
            this.colDepartment.HeaderText = "Department"; this.colDepartment.FillWeight = 100F;
            this.colCredits.HeaderText = "Credits"; this.colCredits.FillWeight = 50F;
            this.colInstructor.HeaderText = "Instructor"; this.colInstructor.FillWeight = 100F;

            // Inputs Row 1
            this.lblCourseID.Text = "Course ID:"; this.lblCourseID.Location = new System.Drawing.Point(25, 420); this.lblCourseID.AutoSize = true; this.lblCourseID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtCourseID.Location = new System.Drawing.Point(135, 417); this.txtCourseID.Size = new System.Drawing.Size(250, 25);

            this.lblCourseName.Text = "Course Name:"; this.lblCourseName.Location = new System.Drawing.Point(450, 420); this.lblCourseName.AutoSize = true; this.lblCourseName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtCourseName.Location = new System.Drawing.Point(560, 417); this.txtCourseName.Size = new System.Drawing.Size(250, 25);

            // Inputs Row 2
            this.lblDepartment.Text = "Department:"; this.lblDepartment.Location = new System.Drawing.Point(25, 460); this.lblDepartment.AutoSize = true; this.lblDepartment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtDepartment.Location = new System.Drawing.Point(135, 457); this.txtDepartment.Size = new System.Drawing.Size(250, 25);

            this.lblCredits.Text = "Credits:"; this.lblCredits.Location = new System.Drawing.Point(450, 460); this.lblCredits.AutoSize = true; this.lblCredits.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtCredits.Location = new System.Drawing.Point(560, 457); this.txtCredits.Size = new System.Drawing.Size(100, 25);

            // Inputs Row 3
            this.lblInstructor.Text = "Instructor:"; this.lblInstructor.Location = new System.Drawing.Point(25, 500); this.lblInstructor.AutoSize = true; this.lblInstructor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtInstructor.Location = new System.Drawing.Point(135, 497); this.txtInstructor.Size = new System.Drawing.Size(250, 25);

            // Buttons
            this.btnAddCourse.Text = "Add Course"; this.btnAddCourse.Location = new System.Drawing.Point(135, 540); this.btnAddCourse.Size = new System.Drawing.Size(120, 35);
            this.btnAddCourse.BackColor = System.Drawing.Color.FromArgb(40, 167, 69); this.btnAddCourse.ForeColor = System.Drawing.Color.White; this.btnAddCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);

            this.btnEditCourse.Text = "Edit Course"; this.btnEditCourse.Location = new System.Drawing.Point(265, 540); this.btnEditCourse.Size = new System.Drawing.Size(120, 35);
            this.btnEditCourse.BackColor = System.Drawing.Color.FromArgb(0, 123, 255); this.btnEditCourse.ForeColor = System.Drawing.Color.White; this.btnEditCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCourse.Click += new System.EventHandler(this.btnEditCourse_Click);

            this.btnDeleteCourse.Text = "Delete Course"; this.btnDeleteCourse.Location = new System.Drawing.Point(395, 540); this.btnDeleteCourse.Size = new System.Drawing.Size(120, 35);
            this.btnDeleteCourse.BackColor = System.Drawing.Color.FromArgb(220, 53, 69); this.btnDeleteCourse.ForeColor = System.Drawing.Color.White; this.btnDeleteCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCourse.Click += new System.EventHandler(this.btnDeleteCourse_Click);

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 680);
            this.Controls.Add(this.btnDeleteCourse);
            this.Controls.Add(this.btnEditCourse);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.txtInstructor); this.Controls.Add(this.lblInstructor);
            this.Controls.Add(this.txtCredits); this.Controls.Add(this.lblCredits);
            this.Controls.Add(this.txtDepartment); this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.txtCourseName); this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.txtCourseID); this.Controls.Add(this.lblCourseID);
            this.Controls.Add(this.dgvCourses);
            this.Controls.Add(this.txtSearch); this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panelTop);
            this.Name = "CourseManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course Management";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvCourses;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCourseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCredits;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInstructor;
        private System.Windows.Forms.Label lblCourseID;
        private System.Windows.Forms.TextBox txtCourseID;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.TextBox txtCredits;
        private System.Windows.Forms.Label lblInstructor;
        private System.Windows.Forms.TextBox txtInstructor;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnEditCourse;
        private System.Windows.Forms.Button btnDeleteCourse;
    }
}
