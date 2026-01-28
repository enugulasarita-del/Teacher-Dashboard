using System;
using System.Drawing;
using System.Windows.Forms;

namespace TeacherDashboard.Forms
{
    public partial class QuizBuilderForm : Form
    {
        public QuizBuilderForm()
        {
            InitializeComponent();
            SetupQuizHub();
        }

        private void SetupQuizHub()
        {
            this.Text = "Quiz & Activity Builder";
            this.BackColor = Color.White;

            Panel header = new Panel { Dock = DockStyle.Top, Height = 80, BackColor = Color.FromArgb(255, 87, 34) };
            Label title = new Label { 
                Text = "💡 Quiz & Activity Builder", 
                ForeColor = Color.White, 
                Font = new Font("Segoe UI", 18, FontStyle.Bold), 
                Location = new Point(20, 20), 
                AutoSize = true 
            };
            header.Controls.Add(title);
            this.Controls.Add(header);

            Panel main = new Panel { Dock = DockStyle.Fill, Padding = new Padding(30) };
            
            Label lblInstr = new Label { Text = "Create Interactive Classroom Quizzes", Font = new Font("Segoe UI", 14, FontStyle.Bold), Location = new Point(20, 10), AutoSize = true };
            
            Button btnCreate = new Button { 
                Text = "➕ Create New Quiz", 
                Location = new Point(20, 60), 
                Size = new Size(200, 50), 
                FlatStyle = FlatStyle.Flat, 
                BackColor = Color.FromArgb(255, 87, 34), 
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 11, FontStyle.Bold)
            };
            btnCreate.FlatAppearance.BorderSize = 0;

            DataGridView dgvQuizzes = new DataGridView { 
                Location = new Point(20, 130), 
                Size = new Size(600, 250), 
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };
            dgvQuizzes.Columns.Add("Name", "Quiz Title");
            dgvQuizzes.Columns.Add("Class", "Class");
            dgvQuizzes.Columns.Add("Status", "Status");
            
            dgvQuizzes.Rows.Add("Unit 1: Algebra Quiz", "10-A", "PUBLISHED");
            dgvQuizzes.Rows.Add("World War II Facts", "9-C", "DRAFT");
            dgvQuizzes.Rows.Add("Chemical Bonding MCQ", "12-B", "ARCHIVED");

            main.Controls.Add(lblInstr);
            main.Controls.Add(btnCreate);
            main.Controls.Add(dgvQuizzes);
            this.Controls.Add(main);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Name = "QuizBuilderForm";
            this.ResumeLayout(false);
        }
    }
}
