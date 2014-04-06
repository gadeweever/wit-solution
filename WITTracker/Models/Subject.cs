using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WITTracker.Models
{
    public class Subject
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Teacher> Teachers { get; set; }
        public virtual ICollection<Grade> SubjectGrades { get; set; }
    }
}