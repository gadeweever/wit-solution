using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WITTracker.Models
{
    public class Student
    {

        public int ID { get; set; }
        public String FirstName { get; set; }
        public String LstName { get; set; }

        public virtual ICollection<Teacher> Teachers { get; set; }
        public virtual ICollection<Grade> Grades { get; set; }
    }
}