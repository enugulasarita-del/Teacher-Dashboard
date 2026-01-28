
namespace TeacherDashboard.Forms
{
    partial class AttendanceForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) { if (disposing && (components != null)) { components.Dispose(); } base.Dispose(disposing); }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblClass = new System.Windows.Forms.Label();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.dgvAttendance = new System.Windows.Forms.DataGridView();
            this.colRollNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblSummary = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
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
            this.lblTitle.Text = "✅ Daily Attendance";

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

            // Controls
            this.lblDate.Text = "Date:"; this.lblDate.Location = new System.Drawing.Point(25, 90); this.lblDate.AutoSize = true; this.lblDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dtpDate.Location = new System.Drawing.Point(80, 87); this.dtpDate.Size = new System.Drawing.Size(200, 25);

            this.lblClass.Text = "Class:"; this.lblClass.Location = new System.Drawing.Point(320, 90); this.lblClass.AutoSize = true; this.lblClass.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cmbClass.Location = new System.Drawing.Point(380, 87); this.cmbClass.Size = new System.Drawing.Size(200, 25);
            this.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClass.Items.AddRange(new object[] { "Physics 101", "Chemistry 202", "Math 301", "Biology 101" });

            this.btnLoad.Text = "Load Students"; this.btnLoad.Location = new System.Drawing.Point(620, 83); this.btnLoad.Size = new System.Drawing.Size(150, 30);
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(0, 123, 255); this.btnLoad.ForeColor = System.Drawing.Color.White; this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);

            // Grid
            this.dgvAttendance.Location = new System.Drawing.Point(25, 140);
            this.dgvAttendance.Size = new System.Drawing.Size(950, 400);
            this.dgvAttendance.AllowUserToAddRows = false;
            this.dgvAttendance.AllowUserToDeleteRows = false;
            this.dgvAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAttendance.BackgroundColor = System.Drawing.Color.White;
            this.dgvAttendance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAttendance.ColumnHeadersHeight = 40;
            this.dgvAttendance.EnableHeadersVisualStyles = false;
            this.dgvAttendance.RowHeadersVisible = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(173, 22, 37);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvAttendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAttendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.colRollNo, this.colName, this.colStatus });

            this.colRollNo.HeaderText = "Roll No"; this.colRollNo.FillWeight = 30F; this.colRollNo.ReadOnly = true;
            this.colName.HeaderText = "Student Name"; this.colName.FillWeight = 100F; this.colName.ReadOnly = true;
            this.colStatus.HeaderText = "Is Present?"; this.colStatus.FillWeight = 30F;

            // Summary
            this.lblSummary.Text = "Total Students: 0 | Present: 0 | Absent: 0";
            this.lblSummary.Location = new System.Drawing.Point(25, 560);
            this.lblSummary.AutoSize = true;
            this.lblSummary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);

            this.btnSave.Text = "Save Attendance"; this.btnSave.Location = new System.Drawing.Point(775, 560); this.btnSave.Size = new System.Drawing.Size(200, 40);
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(40, 167, 69); this.btnSave.ForeColor = System.Drawing.Color.White; this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 680);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblSummary);
            this.Controls.Add(this.dgvAttendance);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.cmbClass);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panelTop);
            this.Name = "AttendanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daily Attendance";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView dgvAttendance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRollNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colStatus;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.Button btnSave;
    }
}
