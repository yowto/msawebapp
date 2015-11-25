using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace msawebapp.Models
{
    public class Assignment
    {
        public int AssignmentID { get; set; }
        public string AssignmentName { get; set; }
        public int AssignmentPercent { get; set; }
        public DateTime DueDate { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }

        [JsonIgnore]
        public virtual ICollection<Course> Courses { get; set; }
    }
}