using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace msawebapp.Models
{
    public class Test
    {
        public int TestID { get; set; }
        public int TestPercent { get; set; }
        public DateTime DueDate { get; set; }

        [JsonIgnore]
        public virtual ICollection<Course> Courses { get; set; }
    }
}