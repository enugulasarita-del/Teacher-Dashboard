
namespace TeacherDashboard.Forms
{
    partial class ResourceLibraryForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) { if (disposing && (components != null)) { components.Dispose(); } base.Dispose(disposing); }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvResources = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResources)).BeginInit();
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
            this.lblTitle.Text = "📚 Resource Library";

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

            // dgvResources
            this.dgvResources.Location = new System.Drawing.Point(25, 90);
            this.dgvResources.Size = new System.Drawing.Size(950, 450);
            this.dgvResources.AllowUserToAddRows = false;
            this.dgvResources.AllowUserToDeleteRows = false;
            this.dgvResources.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResources.BackgroundColor = System.Drawing.Color.White;
            this.dgvResources.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvResources.ColumnHeadersHeight = 40;
            this.dgvResources.EnableHeadersVisualStyles = false;
            this.dgvResources.RowHeadersVisible = false;
            this.dgvResources.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(173, 22, 37);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvResources.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResources.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.colName, this.colType, this.colSize, this.colDate });

            this.colName.HeaderText = "File Name"; this.colName.FillWeight = 150F;
            this.colType.HeaderText = "Type"; this.colType.FillWeight = 50F;
            this.colSize.HeaderText = "Size"; this.colSize.FillWeight = 50F;
            this.colDate.HeaderText = "Uploaded"; this.colDate.FillWeight = 80F;

            // Buttons
            this.btnUpload.Text = "Upload File"; this.btnUpload.Location = new System.Drawing.Point(25, 560); this.btnUpload.Size = new System.Drawing.Size(150, 40);
            this.btnUpload.BackColor = System.Drawing.Color.FromArgb(40, 167, 69); this.btnUpload.ForeColor = System.Drawing.Color.White; this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);

            this.btnDelete.Text = "Delete File"; this.btnDelete.Location = new System.Drawing.Point(200, 560); this.btnDelete.Size = new System.Drawing.Size(150, 40);
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(220, 53, 69); this.btnDelete.ForeColor = System.Drawing.Color.White; this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 680);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.dgvResources);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panelTop);
            this.Name = "ResourceLibraryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resource Library";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResources)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvResources;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnDelete;
    }
}
