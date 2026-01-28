
namespace TeacherDashboard.Forms
{
    partial class StudentPerformanceForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) { if (disposing && (components != null)) { components.Dispose(); } base.Dispose(disposing); }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvPerformance = new System.Windows.Forms.DataGridView();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRollNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblStudent = new System.Windows.Forms.Label();
            this.cmbStudent = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.btnAddNote = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerformance)).BeginInit();
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
            this.lblTitle.Text = "📊 Student Performance";

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

            // dgvPerformance
            this.dgvPerformance.Location = new System.Drawing.Point(25, 90);
            this.dgvPerformance.Size = new System.Drawing.Size(950, 300);
            this.dgvPerformance.AllowUserToAddRows = false;
            this.dgvPerformance.AllowUserToDeleteRows = false;
            this.dgvPerformance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPerformance.BackgroundColor = System.Drawing.Color.White;
            this.dgvPerformance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPerformance.ColumnHeadersHeight = 40;
            this.dgvPerformance.EnableHeadersVisualStyles = false;
            this.dgvPerformance.RowHeadersVisible = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(173, 22, 37);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvPerformance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPerformance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.colDate, this.colRollNo, this.colStudent, this.colCategory, this.colNote });

            this.colDate.HeaderText = "Date"; this.colDate.FillWeight = 50F;
            this.colRollNo.HeaderText = "Roll No"; this.colRollNo.FillWeight = 50F;
            this.colStudent.HeaderText = "Student Name"; this.colStudent.FillWeight = 80F;
            this.colCategory.HeaderText = "Category"; this.colCategory.FillWeight = 60F;
            this.colNote.HeaderText = "Note"; this.colNote.FillWeight = 150F;

            // Inputs Row 1
            this.lblDate.Text = "Date:"; this.lblDate.Location = new System.Drawing.Point(25, 420); this.lblDate.AutoSize = true; this.lblDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dtpDate.Location = new System.Drawing.Point(120, 417); this.dtpDate.Size = new System.Drawing.Size(250, 25);

            this.lblStudent.Text = "Student:"; this.lblStudent.Location = new System.Drawing.Point(450, 420); this.lblStudent.AutoSize = true; this.lblStudent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cmbStudent.Location = new System.Drawing.Point(540, 417); this.cmbStudent.Size = new System.Drawing.Size(250, 25);
            this.cmbStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // Inputs Row 2
            this.lblCategory.Text = "Category:"; this.lblCategory.Location = new System.Drawing.Point(25, 460); this.lblCategory.AutoSize = true; this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cmbCategory.Location = new System.Drawing.Point(120, 457); this.cmbCategory.Size = new System.Drawing.Size(250, 25);
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Items.AddRange(new object[] { "Behavior", "Participation", "Missing Homework", "Achievement" });

            this.lblNote.Text = "Note:"; this.lblNote.Location = new System.Drawing.Point(450, 460); this.lblNote.AutoSize = true; this.lblNote.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtNote.Location = new System.Drawing.Point(540, 457); this.txtNote.Size = new System.Drawing.Size(400, 25);

            // Buttons
            this.btnAddNote.Text = "Add Note"; this.btnAddNote.Location = new System.Drawing.Point(120, 520); this.btnAddNote.Size = new System.Drawing.Size(150, 35);
            this.btnAddNote.BackColor = System.Drawing.Color.FromArgb(40, 167, 69); this.btnAddNote.ForeColor = System.Drawing.Color.White; this.btnAddNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNote.Click += new System.EventHandler(this.btnAddNote_Click);

            this.btnExport.Text = "Export to CSV"; this.btnExport.Location = new System.Drawing.Point(300, 520); this.btnExport.Size = new System.Drawing.Size(150, 35);
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(0, 123, 255); this.btnExport.ForeColor = System.Drawing.Color.White; this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 680);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnAddNote);
            this.Controls.Add(this.txtNote); this.Controls.Add(this.lblNote);
            this.Controls.Add(this.cmbCategory); this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cmbStudent); this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.dtpDate); this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dgvPerformance);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panelTop);
            this.Name = "StudentPerformanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Performance";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerformance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvPerformance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRollNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNote;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.ComboBox cmbStudent;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Button btnAddNote;
        private System.Windows.Forms.Button btnExport;
    }
}
