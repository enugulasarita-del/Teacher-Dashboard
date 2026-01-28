namespace TeacherDashboard.Forms
{
    partial class SyllabusTrackerForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) { if (disposing && (components != null)) { components.Dispose(); } base.Dispose(disposing); }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvSyllabus = new System.Windows.Forms.DataGridView();
            this.colCourse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCourse = new System.Windows.Forms.Label();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.lblModule = new System.Windows.Forms.Label();
            this.txtModule = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSyllabus)).BeginInit();
            this.SuspendLayout();

            // panelTop
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(173, 22, 37);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Size = new System.Drawing.Size(1000, 60);

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Text = "📖 Syllabus Tracker";

            // dgvSyllabus
            this.dgvSyllabus.Location = new System.Drawing.Point(25, 80);
            this.dgvSyllabus.Size = new System.Drawing.Size(950, 300);
            this.dgvSyllabus.AllowUserToAddRows = false;
            this.dgvSyllabus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSyllabus.BackgroundColor = System.Drawing.Color.White;
            this.dgvSyllabus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSyllabus.ColumnHeadersHeight = 35;
            this.dgvSyllabus.EnableHeadersVisualStyles = false;
            this.dgvSyllabus.RowHeadersVisible = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(173, 22, 37);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvSyllabus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSyllabus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.colCourse, this.colModule, this.colStatus, this.colStart, this.colEnd });

            this.colCourse.HeaderText = "Course";
            this.colModule.HeaderText = "Module / Chapter";
            this.colStatus.HeaderText = "Status";
            this.colStart.HeaderText = "Start Date";
            this.colEnd.HeaderText = "End Date";

            // Inputs
            this.lblCourse.Text = "Course:"; this.lblCourse.Location = new System.Drawing.Point(25, 410); this.lblCourse.AutoSize = true;
            this.cmbCourse.Location = new System.Drawing.Point(25, 430); this.cmbCourse.Size = new System.Drawing.Size(200, 25);
            this.cmbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.lblModule.Text = "Module/Chapter:"; this.lblModule.Location = new System.Drawing.Point(250, 410); this.lblModule.AutoSize = true;
            this.txtModule.Location = new System.Drawing.Point(250, 430); this.txtModule.Size = new System.Drawing.Size(250, 25);

            this.lblStatus.Text = "Status:"; this.lblStatus.Location = new System.Drawing.Point(520, 410); this.lblStatus.AutoSize = true;
            this.cmbStatus.Location = new System.Drawing.Point(520, 430); this.cmbStatus.Size = new System.Drawing.Size(150, 25);
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Items.AddRange(new object[] { "Pending", "In Progress", "Completed" });

            // Buttons
            this.btnAdd.Text = "Add Module"; this.btnAdd.Location = new System.Drawing.Point(25, 480); this.btnAdd.Size = new System.Drawing.Size(120, 35);
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(40, 167, 69); this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnUpdate.Text = "Update Status"; this.btnUpdate.Location = new System.Drawing.Point(160, 480); this.btnUpdate.Size = new System.Drawing.Size(120, 35);
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(0, 123, 255); this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            this.btnDelete.Text = "Delete"; this.btnDelete.Location = new System.Drawing.Point(295, 480); this.btnDelete.Size = new System.Drawing.Size(120, 35);
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(220, 53, 69); this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtModule);
            this.Controls.Add(this.lblModule);
            this.Controls.Add(this.cmbCourse);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.dgvSyllabus);
            this.Controls.Add(this.panelTop);
            this.Name = "SyllabusTrackerForm";
            this.Text = "Syllabus Tracker";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSyllabus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvSyllabus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModule;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEnd;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.Label lblModule;
        private System.Windows.Forms.TextBox txtModule;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}
