namespace LibrarianDashboard.Models
{
    public class ActivityLog
    {
        public string Message { get; set; }
        public string Time { get; set; }
        public string Type { get; set; } // "Issue", "Return", "Add", "Edit"
        
        public string IconData 
        {
             get 
             {
                 if(Type == "Issue") return "M19,13H5V11H19V13Z";
                 if(Type == "Return") return "M9,16.2L4.8,12l-1.4,1.4L9,19 21,7l-1.4-1.4L9,16.2z";
                 if(Type == "Add") return "M19,13h-6v6h-2v-6H5v-2h6V5h2v6h6V13z";
                 if(Type == "Delete") return "M6,19c0,1.1,0.9,2,2,2h8c1.1,0,2-0.9,2-2V7H6V19z M19,4h-3.5l-1-1h-5l-1,1H5v2h14V4z";
                 return "M11,7h2v2h-2V7z M11,11h2v6h-2V11z";
             }
        }
        
        public string IconColor 
        {
             get 
             {
                 if(Type == "Issue") return "#EA580C"; // Orange
                 if(Type == "Return") return "#10B981"; // Green
                 if(Type == "Add") return "#B91C1C"; // VSIT Red
                 if(Type == "Delete") return "#EF4444"; // Light Red
                 return "#9E9E9E"; 
             }
        }
    }
}
