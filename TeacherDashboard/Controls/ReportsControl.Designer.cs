
namespace TeacherDashboard.Controls
{
    partial class ReportsControl
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();

            this.lblHeader = new System.Windows.Forms.Label();
            this.chartGrades = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartAttendance = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlCharts = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRefresh = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.chartGrades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAttendance)).BeginInit();
            this.pnlCharts.SuspendLayout();
            this.SuspendLayout();

            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.lblHeader.Location = new System.Drawing.Point(20, 20);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(215, 30);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Reports & Analytics";

            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(650, 20);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(120, 30);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh Data";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // 
            // pnlCharts
            // 
            this.pnlCharts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCharts.AutoScroll = true;
            this.pnlCharts.Controls.Add(this.chartGrades);
            this.pnlCharts.Controls.Add(this.chartAttendance);
            this.pnlCharts.Location = new System.Drawing.Point(20, 70);
            this.pnlCharts.Name = "pnlCharts";
            this.pnlCharts.Size = new System.Drawing.Size(760, 510);
            this.pnlCharts.TabIndex = 2;

            // 
            // chartGrades
            // 
            chartArea1.Name = "ChartArea1";
            this.chartGrades.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            this.chartGrades.Legends.Add(legend1);
            this.chartGrades.Location = new System.Drawing.Point(3, 3);
            this.chartGrades.Name = "chartGrades";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "AvgGrade";
            this.chartGrades.Series.Add(series1);
            this.chartGrades.Size = new System.Drawing.Size(700, 300);
            this.chartGrades.TabIndex = 0;
            this.chartGrades.Text = "chartGrades";
            title1.Name = "Title1";
            title1.Text = "Average Grades by Course";
            title1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.chartGrades.Titles.Add(title1);

            // 
            // chartAttendance
            // 
            chartArea2.Name = "ChartArea1";
            this.chartAttendance.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Right;
            this.chartAttendance.Legends.Add(legend2);
            this.chartAttendance.Location = new System.Drawing.Point(3, 310);
            this.chartAttendance.Name = "chartAttendance";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Attendance";
            this.chartAttendance.Series.Add(series2);
            this.chartAttendance.Size = new System.Drawing.Size(700, 300);
            this.chartAttendance.TabIndex = 1;
            this.chartAttendance.Text = "chartAttendance";
            title2.Name = "Title1";
            title2.Text = "Overall Attendance Distribution";
            title2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.chartAttendance.Titles.Add(title2);

            // 
            // ReportsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlCharts);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblHeader);
            this.Name = "ReportsControl";
            this.Size = new System.Drawing.Size(800, 600);
            ((System.ComponentModel.ISupportInitialize)(this.chartGrades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAttendance)).EndInit();
            this.pnlCharts.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.FlowLayoutPanel pnlCharts;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGrades;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAttendance;
    }
}
