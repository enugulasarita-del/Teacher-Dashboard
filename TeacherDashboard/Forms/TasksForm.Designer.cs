namespace TeacherDashboard.Forms
{
    partial class TasksForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) { if (disposing && (components != null)) { components.Dispose(); } base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtTask = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.clbTasks = new System.Windows.Forms.CheckedListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblHint = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
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
            this.lblTitle.Text = "📋 My Tasks";

            // btnClose
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(173, 22, 37);
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(650, 500);
            this.btnClose.Size = new System.Drawing.Size(120, 40);
            this.btnClose.Text = "✕ Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // txtTask
            this.txtTask.Location = new System.Drawing.Point(25, 90);
            this.txtTask.Size = new System.Drawing.Size(550, 30);
            this.txtTask.Font = new System.Drawing.Font("Segoe UI", 12F);
            
            // btnAdd
            this.btnAdd.Text = "Add Task"; this.btnAdd.Location = new System.Drawing.Point(600, 88); this.btnAdd.Size = new System.Drawing.Size(150, 35);
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(40, 167, 69); this.btnAdd.ForeColor = System.Drawing.Color.White; this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // clbTasks
            this.clbTasks.Location = new System.Drawing.Point(25, 140);
            this.clbTasks.Size = new System.Drawing.Size(725, 300);
            this.clbTasks.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.clbTasks.CheckOnClick = true;

            // btnRemove
            this.btnRemove.Text = "Remove Selected"; this.btnRemove.Location = new System.Drawing.Point(25, 450); this.btnRemove.Size = new System.Drawing.Size(200, 35);
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(220, 53, 69); this.btnRemove.ForeColor = System.Drawing.Color.White; this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);

            // lblHint
            this.lblHint.Text = "Tip: Check items to mark as done, then click 'Remove Selected' to clear them.";
            this.lblHint.Location = new System.Drawing.Point(240, 460);
            this.lblHint.AutoSize = true;
            this.lblHint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblHint.ForeColor = System.Drawing.Color.Gray;

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 560);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.clbTasks);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTask);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panelTop);
            this.Name = "TasksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Tasks";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckedListBox clbTasks;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblHint;
    }
}
