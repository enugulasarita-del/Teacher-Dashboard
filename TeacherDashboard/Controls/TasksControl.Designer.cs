
namespace TeacherDashboard.Controls
{
    partial class TasksControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblHeader = new System.Windows.Forms.Label();
            this.panelInput = new System.Windows.Forms.Panel();
            this.txtTask = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.clbTasks = new System.Windows.Forms.CheckedListBox();
            this.btnRemove = new System.Windows.Forms.Button();

            this.panelInput.SuspendLayout();
            this.SuspendLayout();

            // lblHeader
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(173, 22, 37);
            this.lblHeader.Location = new System.Drawing.Point(20, 20);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(184, 30);
            this.lblHeader.Text = "My To-Do Tasks";

            // panelInput
            this.panelInput.Controls.Add(this.btnAdd);
            this.panelInput.Controls.Add(this.txtTask);
            this.panelInput.Location = new System.Drawing.Point(25, 70);
            this.panelInput.Size = new System.Drawing.Size(750, 50);
            
            // txtTask
            this.txtTask.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTask.Location = new System.Drawing.Point(0, 10);
            this.txtTask.Size = new System.Drawing.Size(600, 29);

            // btnAdd
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(173, 22, 37);
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(620, 8);
            this.btnAdd.Size = new System.Drawing.Size(100, 31);
            this.btnAdd.Text = "Add Task";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // clbTasks
            this.clbTasks.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.clbTasks.FormattingEnabled = true;
            this.clbTasks.Location = new System.Drawing.Point(25, 140);
            this.clbTasks.Size = new System.Drawing.Size(750, 350);
            this.clbTasks.CheckOnClick = true;

            // btnRemove
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.BackColor = System.Drawing.Color.Gray;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(575, 520);
            this.btnRemove.Size = new System.Drawing.Size(200, 35);
            this.btnRemove.Text = "Remove Completed Tasks";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);

            // TasksControl
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.clbTasks);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.lblHeader);
            this.Name = "TasksControl";
            this.Size = new System.Drawing.Size(800, 600);
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckedListBox clbTasks;
        private System.Windows.Forms.Button btnRemove;
    }
}
