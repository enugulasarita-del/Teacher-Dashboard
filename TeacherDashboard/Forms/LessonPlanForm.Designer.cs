namespace TeacherDashboard.Forms
{
    partial class LessonPlanForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvPlans = new System.Windows.Forms.DataGridView();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTopic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colObjective = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTopic = new System.Windows.Forms.Label();
            this.txtTopic = new System.Windows.Forms.TextBox();
            this.lblObjective = new System.Windows.Forms.Label();
            this.txtObjective = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlans)).BeginInit();
            this.SuspendLayout();

            // panelTop
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(173, 22, 37);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Size = new System.Drawing.Size(900, 60);

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Text = "✍️ Lesson Planner";

            // dgvPlans
            this.dgvPlans.Location = new System.Drawing.Point(25, 80);
            this.dgvPlans.Size = new System.Drawing.Size(850, 300);
            this.dgvPlans.AllowUserToAddRows = false;
            this.dgvPlans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlans.BackgroundColor = System.Drawing.Color.White;
            this.dgvPlans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.colDate, this.colTopic, this.colObjective, this.colDuration });

            // Inputs
            this.lblTopic.Text = "Topic:"; this.lblTopic.Location = new System.Drawing.Point(25, 400); this.lblTopic.AutoSize = true;
            this.txtTopic.Location = new System.Drawing.Point(25, 420); this.txtTopic.Size = new System.Drawing.Size(250, 25);

            this.lblObjective.Text = "Objective:"; this.lblObjective.Location = new System.Drawing.Point(300, 400); this.lblObjective.AutoSize = true;
            this.txtObjective.Location = new System.Drawing.Point(300, 420); this.txtObjective.Size = new System.Drawing.Size(400, 25);

            this.btnAdd.Text = "Add Plan"; this.btnAdd.Location = new System.Drawing.Point(720, 415); this.btnAdd.Size = new System.Drawing.Size(120, 35);
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(40, 167, 69); this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // Form
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtObjective);
            this.Controls.Add(this.lblObjective);
            this.Controls.Add(this.txtTopic);
            this.Controls.Add(this.lblTopic);
            this.Controls.Add(this.dgvPlans);
            this.Controls.Add(this.panelTop);
            this.Name = "LessonPlanForm";
            this.Text = "Lesson Planner";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvPlans;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTopic;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObjective;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDuration;
        private System.Windows.Forms.Label lblTopic;
        private System.Windows.Forms.TextBox txtTopic;
        private System.Windows.Forms.Label lblObjective;
        private System.Windows.Forms.TextBox txtObjective;
        private System.Windows.Forms.Button btnAdd;
    }
}
