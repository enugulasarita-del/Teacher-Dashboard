namespace TeacherDashboard.Forms
{
    partial class GradingSystemForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) { if (disposing && (components != null)) { components.Dispose(); } base.Dispose(disposing); }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvGrades = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRollNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCourse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblStudent = new System.Windows.Forms.Label();
            this.cmbStudent = new System.Windows.Forms.ComboBox();
            this.lblCourse = new System.Windows.Forms.Label();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.lblAssignment = new System.Windows.Forms.Label();
            this.cmbAssignment = new System.Windows.Forms.ComboBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.btnAddGrade = new System.Windows.Forms.Button();
            this.btnEditGrade = new System.Windows.Forms.Button();
            this.btnDeleteGrade = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).BeginInit();
            this.SuspendLayout();

            // panelTop
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(173, 22, 37);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Size = new System.Drawing.Size(1000, 70);
            this.panelTop.TabIndex = 0;

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 18);
            this.lblTitle.Text = "🎓 Grading System";

            // btnClose
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(173, 22, 37);
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(850, 620);
            this.btnClose.Size = new System.Drawing.Size(120, 40);
            this.btnClose.Text = "✕ Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // dgvGrades
            this.dgvGrades.Location = new System.Drawing.Point(25, 90);
            this.dgvGrades.Size = new System.Drawing.Size(950, 300);
            this.dgvGrades.AllowUserToAddRows = false;
            this.dgvGrades.AllowUserToDeleteRows = false;
            this.dgvGrades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGrades.BackgroundColor = System.Drawing.Color.White;
            this.dgvGrades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGrades.ColumnHeadersHeight = 40;
            this.dgvGrades.EnableHeadersVisualStyles = false;
            this.dgvGrades.RowHeadersVisible = false;
            this.dgvGrades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(173, 22, 37);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvGrades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGrades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.colId, this.colRollNo, this.colStudent, this.colCourse, this.colAssignment, this.colGrade });
            this.dgvGrades.SelectionChanged += new System.EventHandler(this.dgvGrades_SelectionChanged);

            this.colId.HeaderText = "ID"; this.colId.FillWeight = 40F;
            this.colRollNo.HeaderText = "Roll No"; this.colRollNo.FillWeight = 60F;
            this.colStudent.HeaderText = "Student Name"; this.colStudent.FillWeight = 120F;
            this.colCourse.HeaderText = "Course"; this.colCourse.FillWeight = 100F;
            this.colAssignment.HeaderText = "Assignment"; this.colAssignment.FillWeight = 100F;
            this.colGrade.HeaderText = "Grade"; this.colGrade.FillWeight = 50F;

            // Inputs Row 1
            this.lblStudent.Text = "Student:"; this.lblStudent.Location = new System.Drawing.Point(25, 420); this.lblStudent.AutoSize = true; this.lblStudent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cmbStudent.Location = new System.Drawing.Point(120, 417); this.cmbStudent.Size = new System.Drawing.Size(250, 25);
            this.cmbStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.lblCourse.Text = "Course:"; this.lblCourse.Location = new System.Drawing.Point(450, 420); this.lblCourse.AutoSize = true; this.lblCourse.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cmbCourse.Location = new System.Drawing.Point(540, 417); this.cmbCourse.Size = new System.Drawing.Size(250, 25);
            this.cmbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // Inputs Row 2
            this.lblAssignment.Text = "Assignment:"; this.lblAssignment.Location = new System.Drawing.Point(25, 460); this.lblAssignment.AutoSize = true; this.lblAssignment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cmbAssignment.Location = new System.Drawing.Point(120, 457); this.cmbAssignment.Size = new System.Drawing.Size(250, 25);
            this.cmbAssignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.lblGrade.Text = "Grade:"; this.lblGrade.Location = new System.Drawing.Point(450, 460); this.lblGrade.AutoSize = true; this.lblGrade.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtGrade.Location = new System.Drawing.Point(540, 457); this.txtGrade.Size = new System.Drawing.Size(100, 25);

            // Buttons
            this.btnAddGrade.Text = "Add Grade"; this.btnAddGrade.Location = new System.Drawing.Point(120, 520); this.btnAddGrade.Size = new System.Drawing.Size(120, 35);
            this.btnAddGrade.BackColor = System.Drawing.Color.FromArgb(40, 167, 69); this.btnAddGrade.ForeColor = System.Drawing.Color.White; this.btnAddGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddGrade.Click += new System.EventHandler(this.btnAddGrade_Click);

            this.btnEditGrade.Text = "Edit Grade"; this.btnEditGrade.Location = new System.Drawing.Point(250, 520); this.btnEditGrade.Size = new System.Drawing.Size(120, 35);
            this.btnEditGrade.BackColor = System.Drawing.Color.FromArgb(0, 123, 255); this.btnEditGrade.ForeColor = System.Drawing.Color.White; this.btnEditGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditGrade.Click += new System.EventHandler(this.btnEditGrade_Click);

            this.btnDeleteGrade.Text = "Delete Grade"; this.btnDeleteGrade.Location = new System.Drawing.Point(380, 520); this.btnDeleteGrade.Size = new System.Drawing.Size(120, 35);
            this.btnDeleteGrade.BackColor = System.Drawing.Color.FromArgb(220, 53, 69); this.btnDeleteGrade.ForeColor = System.Drawing.Color.White; this.btnDeleteGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteGrade.Click += new System.EventHandler(this.btnDeleteGrade_Click);

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 680);
            this.Controls.Add(this.btnDeleteGrade);
            this.Controls.Add(this.btnEditGrade);
            this.Controls.Add(this.btnAddGrade);
            this.Controls.Add(this.txtGrade); this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.cmbAssignment); this.Controls.Add(this.lblAssignment);
            this.Controls.Add(this.cmbCourse); this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.cmbStudent); this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.dgvGrades);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panelTop);
            this.Name = "GradingSystemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grading System";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvGrades;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRollNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGrade;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.ComboBox cmbStudent;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.Label lblAssignment;
        private System.Windows.Forms.ComboBox cmbAssignment;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Button btnAddGrade;
        private System.Windows.Forms.Button btnEditGrade;
        private System.Windows.Forms.Button btnDeleteGrade;
    }
}
