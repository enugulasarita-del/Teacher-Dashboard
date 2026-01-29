using System.Windows.Media;

namespace LibrarianDashboard.Models
{
    // Analytics & Stats Models
    
    public class FootfallDailyStat
    {
        public string Day { get; set; }
        public int Count { get; set; }
        public double Height { get; set; }
        public double Opacity { get; set; }
        public Brush BarColor { get; set; }
    }

    public class StudentRanking 
    {
        public int Rank { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
        public int VisitCount { get; set; }
        public string LastVisit { get; set; }
    }

    public class StudentClassification 
    {
        public string Category { get; set; }
        public int Count { get; set; }
        public double Percentage { get; set; }
        public string Description { get; set; }
    }

    public class DeptTopper
    {
        public string Department { get; set; }
        public string Name { get; set; }
        public int VisitCount { get; set; }
    }
}
