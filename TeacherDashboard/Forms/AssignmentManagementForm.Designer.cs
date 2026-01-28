
namespace TeacherDashboard.Forms
{
    partial class AssignmentManagementForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) { if (disposing && (components != null)) { components.Dispose(); } base.Dispose(disposing); }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvAssignments = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCourse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAssignTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblCourse = new System.Windows.Forms.Label();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignments)).BeginInit();
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
            this.lblTitle.Text = "📝 Assignment Management";

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

            // dgvAssignments
            this.dgvAssignments.Location = new System.Drawing.Point(25, 90);
            this.dgvAssignments.Size = new System.Drawing.Size(950, 300);
            this.dgvAssignments.AllowUserToAddRows = false;
            this.dgvAssignments.AllowUserToDeleteRows = false;
            this.dgvAssignments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAssignments.BackgroundColor = System.Drawing.Color.White;
            this.dgvAssignments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAssignments.ColumnHeadersHeight = 40;
            this.dgvAssignments.EnableHeadersVisualStyles = false;
            this.dgvAssignments.RowHeadersVisible = false;
            this.dgvAssignments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(173, 22, 37);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvAssignments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAssignments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.colId, this.colTitle, this.colCourse, this.colDueDate, this.colDescription });
            this.dgvAssignments.SelectionChanged += new System.EventHandler(this.dgvAssignments_SelectionChanged);

            this.colId.HeaderText = "ID"; this.colId.FillWeight = 40F;
            this.colTitle.HeaderText = "Assignment Title"; this.colTitle.FillWeight = 120F;
            this.colCourse.HeaderText = "Course"; this.colCourse.FillWeight = 100F;
            this.colDueDate.HeaderText = "Due Date"; this.colDueDate.FillWeight = 80F;
            this.colDescription.HeaderText = "Description"; this.colDescription.FillWeight = 150F;

            // Inputs Row 1
            this.lblAssignTitle.Text = "Title:"; this.lblAssignTitle.Location = new System.Drawing.Point(25, 420); this.lblAssignTitle.AutoSize = true; this.lblAssignTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtTitle.Location = new System.Drawing.Point(120, 417); this.txtTitle.Size = new System.Drawing.Size(250, 25);

            this.lblCourse.Text = "Course:"; this.lblCourse.Location = new System.Drawing.Point(450, 420); this.lblCourse.AutoSize = true; this.lblCourse.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cmbCourse.Location = new System.Drawing.Point(540, 417); this.cmbCourse.Size = new System.Drawing.Size(250, 25);
            this.cmbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // Inputs Row 2
            this.lblDueDate.Text = "Due Date:"; this.lblDueDate.Location = new System.Drawing.Point(25, 460); this.lblDueDate.AutoSize = true; this.lblDueDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dtpDueDate.Location = new System.Drawing.Point(120, 457); this.dtpDueDate.Size = new System.Drawing.Size(250, 25);

            this.lblDescription.Text = "Description:"; this.lblDescription.Location = new System.Drawing.Point(450, 460); this.lblDescription.AutoSize = true; this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtDescription.Location = new System.Drawing.Point(540, 457); this.txtDescription.Size = new System.Drawing.Size(250, 25);
            this.txtDescription.Multiline = true; this.txtDescription.Height = 50;

            // Buttons
            this.btnAdd.Text = "Add Assignment"; this.btnAdd.Location = new System.Drawing.Point(120, 540); this.btnAdd.Size = new System.Drawing.Size(120, 35);
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(40, 167, 69); this.btnAdd.ForeColor = System.Drawing.Color.White; this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnEdit.Text = "Edit Assignment"; this.btnEdit.Location = new System.Drawing.Point(250, 540); this.btnEdit.Size = new System.Drawing.Size(120, 35);
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(0, 123, 255); this.btnEdit.ForeColor = System.Drawing.Color.White; this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

            this.btnDelete.Text = "Delete"; this.btnDelete.Location = new System.Drawing.Point(380, 540); this.btnDelete.Size = new System.Drawing.Size(120, 35);
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(220, 53, 69); this.btnDelete.ForeColor = System.Drawing.Color.White; this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 680);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDescription); this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.dtpDueDate); this.Controls.Add(this.lblDueDate);
            this.Controls.Add(this.cmbCourse); this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.txtTitle); this.Controls.Add(this.lblAssignTitle);
            this.Controls.Add(this.dgvAssignments);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panelTop);
            this.Name = "AssignmentManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assignment Management";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvAssignments;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.Label lblAssignTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
    }
}
