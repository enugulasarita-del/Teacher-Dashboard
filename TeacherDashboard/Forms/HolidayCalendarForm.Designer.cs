namespace TeacherDashboard.Forms
{
    partial class HolidayCalendarForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) { if (disposing && (components != null)) { components.Dispose(); } base.Dispose(disposing); }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvHolidays = new System.Windows.Forms.DataGridView();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoliday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblHoliday = new System.Windows.Forms.Label();
            this.txtHoliday = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHolidays)).BeginInit();
            this.SuspendLayout();

            // panelTop
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(173, 22, 37);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Size = new System.Drawing.Size(800, 60);

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Text = "📅 Holiday Calendar Management";

            // dgvHolidays
            this.dgvHolidays.Location = new System.Drawing.Point(25, 80);
            this.dgvHolidays.Size = new System.Drawing.Size(750, 250);
            this.dgvHolidays.AllowUserToAddRows = false;
            this.dgvHolidays.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHolidays.BackgroundColor = System.Drawing.Color.White;
            this.dgvHolidays.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(173, 22, 37);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvHolidays.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHolidays.EnableHeadersVisualStyles = false;
            this.dgvHolidays.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.colDate, this.colHoliday, this.colType });

            this.colDate.HeaderText = "Date";
            this.colHoliday.HeaderText = "Holiday Name";
            this.colType.HeaderText = "Type";

            // Inputs
            this.lblDate.Text = "Select Date:"; this.lblDate.Location = new System.Drawing.Point(25, 350); this.lblDate.AutoSize = true;
            this.dtpDate.Location = new System.Drawing.Point(25, 370); this.dtpDate.Size = new System.Drawing.Size(200, 25);

            this.lblHoliday.Text = "Holiday Name:"; this.lblHoliday.Location = new System.Drawing.Point(250, 350); this.lblHoliday.AutoSize = true;
            this.txtHoliday.Location = new System.Drawing.Point(250, 370); this.txtHoliday.Size = new System.Drawing.Size(300, 25);

            // btnAdd
            this.btnAdd.Text = "Add Holiday"; this.btnAdd.Location = new System.Drawing.Point(570, 365); this.btnAdd.Size = new System.Drawing.Size(120, 35);
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(40, 167, 69); this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtHoliday);
            this.Controls.Add(this.lblHoliday);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dgvHolidays);
            this.Controls.Add(this.panelTop);
            this.Name = "HolidayCalendarForm";
            this.Text = "Holiday Calendar";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHolidays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvHolidays;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoliday;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblHoliday;
        private System.Windows.Forms.TextBox txtHoliday;
        private System.Windows.Forms.Button btnAdd;
    }
}
