using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WITTracker.Models
{
    public class Subject
    {
        public int ID { get; set; }

        [Display(Name = "Subject Name")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        public virtual ICollection<Teacher> Teachers { get; set; }
        public virtual ICollection<Grade> SubjectGrades { get; set; }
    }
}