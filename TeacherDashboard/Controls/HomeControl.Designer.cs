
namespace TeacherDashboard.Controls
{
    partial class HomeControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlHomeContent = new System.Windows.Forms.Panel();
            this.lblNewNotices = new System.Windows.Forms.Label();
            this.lblTotalAssignments = new System.Windows.Forms.Label();
            this.lblTotalCourses = new System.Windows.Forms.Label();
            this.lblPendingTasks = new System.Windows.Forms.Label();
            this.lblUpcomingClass = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlHomeContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHomeContent
            // 
            this.pnlHomeContent.AutoScroll = true;
            this.pnlHomeContent.Controls.Add(this.lblNewNotices);
            this.pnlHomeContent.Controls.Add(this.lblTotalAssignments);
            this.pnlHomeContent.Controls.Add(this.lblTotalCourses);
            this.pnlHomeContent.Controls.Add(this.lblPendingTasks);
            this.pnlHomeContent.Controls.Add(this.lblUpcomingClass);
            this.pnlHomeContent.Controls.Add(this.lblWelcome);
            this.pnlHomeContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHomeContent.Location = new System.Drawing.Point(0, 0);
            this.pnlHomeContent.Name = "pnlHomeContent";
            this.pnlHomeContent.Size = new System.Drawing.Size(800, 600);
            this.pnlHomeContent.TabIndex = 0;
            // 
            // lblNewNotices
            // 
            this.lblNewNotices.AutoSize = true;
            this.lblNewNotices.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewNotices.Location = new System.Drawing.Point(50, 300);
            this.lblNewNotices.Name = "lblNewNotices";
            this.lblNewNotices.Size = new System.Drawing.Size(200, 25);
            this.lblNewNotices.TabIndex = 5;
            this.lblNewNotices.Text = "New Notices: 0 Unread";
            // 
            // lblTotalAssignments
            // 
            this.lblTotalAssignments.AutoSize = true;
            this.lblTotalAssignments.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAssignments.Location = new System.Drawing.Point(50, 260);
            this.lblTotalAssignments.Name = "lblTotalAssignments";
            this.lblTotalAssignments.Size = new System.Drawing.Size(225, 25);
            this.lblTotalAssignments.TabIndex = 4;
            this.lblTotalAssignments.Text = "Total Assignments: 125";
            // 
            // lblTotalCourses
            // 
            this.lblTotalCourses.AutoSize = true;
            this.lblTotalCourses.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCourses.Location = new System.Drawing.Point(50, 220);
            this.lblTotalCourses.Name = "lblTotalCourses";
            this.lblTotalCourses.Size = new System.Drawing.Size(185, 25);
            this.lblTotalCourses.TabIndex = 3;
            this.lblTotalCourses.Text = "Total Courses: 50";
            // 
            // lblPendingTasks
            // 
            this.lblPendingTasks.AutoSize = true;
            this.lblPendingTasks.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingTasks.Location = new System.Drawing.Point(50, 180);
            this.lblPendingTasks.Name = "lblPendingTasks";
            this.lblPendingTasks.Size = new System.Drawing.Size(359, 25);
            this.lblPendingTasks.TabIndex = 2;
            this.lblPendingTasks.Text = "Pending Tasks: 3 assignments to grade, 1";
            // 
            // lblUpcomingClass
            // 
            this.lblUpcomingClass.AutoSize = true;
            this.lblUpcomingClass.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpcomingClass.Location = new System.Drawing.Point(50, 140);
            this.lblUpcomingClass.Name = "lblUpcomingClass";
            this.lblUpcomingClass.Size = new System.Drawing.Size(434, 25);
            this.lblUpcomingClass.TabIndex = 1;
            this.lblUpcomingClass.Text = "Upcoming Class: Physics (10-B) - Room 102 @ 10:00 AM";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.lblWelcome.Location = new System.Drawing.Point(20, 20);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(232, 37);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome Back!";
            // 
            // HomeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlHomeContent);
            this.Name = "HomeControl";
            this.Size = new System.Drawing.Size(800, 600);
            this.pnlHomeContent.ResumeLayout(false);
            this.pnlHomeContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHomeContent;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblUpcomingClass;
        private System.Windows.Forms.Label lblPendingTasks;
        private System.Windows.Forms.Label lblTotalCourses;
        private System.Windows.Forms.Label lblTotalAssignments;
        private System.Windows.Forms.Label lblNewNotices;
    }
}
