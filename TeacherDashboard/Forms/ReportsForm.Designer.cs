namespace TeacherDashboard.Forms
{
    partial class ReportsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) { if (disposing && (components != null)) { components.Dispose(); } base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            
            this.pnlStudentCount = new System.Windows.Forms.Panel();
            this.lblStudentCountVal = new System.Windows.Forms.Label();
            this.lblStudentCountLbl = new System.Windows.Forms.Label();

            this.pnlAvgGrade = new System.Windows.Forms.Panel();
            this.lblAvgGradeVal = new System.Windows.Forms.Label();
            this.lblAvgGradeLbl = new System.Windows.Forms.Label();

            this.pnlAttendance = new System.Windows.Forms.Panel();
            this.lblAttendanceVal = new System.Windows.Forms.Label();
            this.lblAttendanceLbl = new System.Windows.Forms.Label();

            this.btnExport = new System.Windows.Forms.Button();
            
            this.panelTop.SuspendLayout();
            this.pnlStudentCount.SuspendLayout();
            this.pnlAvgGrade.SuspendLayout();
            this.pnlAttendance.SuspendLayout();
            this.SuspendLayout();

            // panelTop
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(173, 22, 37);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Size = new System.Drawing.Size(800, 70);
            this.panelTop.TabIndex = 0;

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 18);
            this.lblTitle.Text = "📈 Reports & Analytics";

            // btnClose
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(173, 22, 37);
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(650, 400);
            this.btnClose.Size = new System.Drawing.Size(120, 40);
            this.btnClose.Text = "✕ Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // Metric Panels
            // Student Count
            this.pnlStudentCount.BackColor = System.Drawing.Color.FromArgb(0, 123, 255);
            this.pnlStudentCount.Controls.Add(this.lblStudentCountVal);
            this.pnlStudentCount.Controls.Add(this.lblStudentCountLbl);
            this.pnlStudentCount.Location = new System.Drawing.Point(30, 90);
            this.pnlStudentCount.Size = new System.Drawing.Size(220, 120);

            this.lblStudentCountLbl.Text = "Total Students"; this.lblStudentCountLbl.ForeColor = System.Drawing.Color.White; this.lblStudentCountLbl.Location = new System.Drawing.Point(10, 10); this.lblStudentCountLbl.AutoSize = true; this.lblStudentCountLbl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStudentCountVal.Text = "124"; this.lblStudentCountVal.ForeColor = System.Drawing.Color.White; this.lblStudentCountVal.Location = new System.Drawing.Point(10, 40); this.lblStudentCountVal.AutoSize = true; this.lblStudentCountVal.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);

            // Avg Grade
            this.pnlAvgGrade.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.pnlAvgGrade.Controls.Add(this.lblAvgGradeVal);
            this.pnlAvgGrade.Controls.Add(this.lblAvgGradeLbl);
            this.pnlAvgGrade.Location = new System.Drawing.Point(280, 90);
            this.pnlAvgGrade.Size = new System.Drawing.Size(220, 120);
            
            this.lblAvgGradeLbl.Text = "Average Grade"; this.lblAvgGradeLbl.ForeColor = System.Drawing.Color.White; this.lblAvgGradeLbl.Location = new System.Drawing.Point(10, 10); this.lblAvgGradeLbl.AutoSize = true; this.lblAvgGradeLbl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAvgGradeVal.Text = "85%"; this.lblAvgGradeVal.ForeColor = System.Drawing.Color.White; this.lblAvgGradeVal.Location = new System.Drawing.Point(10, 40); this.lblAvgGradeVal.AutoSize = true; this.lblAvgGradeVal.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);

            // Attendance
            this.pnlAttendance.BackColor = System.Drawing.Color.FromArgb(255, 193, 7);
            this.pnlAttendance.Controls.Add(this.lblAttendanceVal);
            this.pnlAttendance.Controls.Add(this.lblAttendanceLbl);
            this.pnlAttendance.Location = new System.Drawing.Point(530, 90);
            this.pnlAttendance.Size = new System.Drawing.Size(220, 120);

            this.lblAttendanceLbl.Text = "Attendance Rate"; this.lblAttendanceLbl.ForeColor = System.Drawing.Color.Black; this.lblAttendanceLbl.Location = new System.Drawing.Point(10, 10); this.lblAttendanceLbl.AutoSize = true; this.lblAttendanceLbl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAttendanceVal.Text = "92%"; this.lblAttendanceVal.ForeColor = System.Drawing.Color.Black; this.lblAttendanceVal.Location = new System.Drawing.Point(10, 40); this.lblAttendanceVal.AutoSize = true; this.lblAttendanceVal.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);

            // btnExport
            this.btnExport.Text = "Generate Report PDF"; this.btnExport.Location = new System.Drawing.Point(30, 250); this.btnExport.Size = new System.Drawing.Size(200, 40);
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(173, 22, 37); this.btnExport.ForeColor = System.Drawing.Color.White; this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.pnlAttendance);
            this.Controls.Add(this.pnlAvgGrade);
            this.Controls.Add(this.pnlStudentCount);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panelTop);
            this.Name = "ReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analytics Dashboard";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.pnlStudentCount.ResumeLayout(false); this.pnlStudentCount.PerformLayout();
            this.pnlAvgGrade.ResumeLayout(false); this.pnlAvgGrade.PerformLayout();
            this.pnlAttendance.ResumeLayout(false); this.pnlAttendance.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        
        private System.Windows.Forms.Panel pnlStudentCount;
        private System.Windows.Forms.Label lblStudentCountVal;
        private System.Windows.Forms.Label lblStudentCountLbl;

        private System.Windows.Forms.Panel pnlAvgGrade;
        private System.Windows.Forms.Label lblAvgGradeVal;
        private System.Windows.Forms.Label lblAvgGradeLbl;

        private System.Windows.Forms.Panel pnlAttendance;
        private System.Windows.Forms.Label lblAttendanceVal;
        private System.Windows.Forms.Label lblAttendanceLbl;

        private System.Windows.Forms.Button btnExport;
    }
}
