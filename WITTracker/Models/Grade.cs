using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WITTracker.Models
{
    public class Grade
    {
        public int ID { get; set; }
        public int SubjectID { get; set; }
        public int StudentID { get; set; }
        public int Score { get; set; }

        public virtual Subject GradeSubject { get; set; }
        public virtual Student Student { get; set; }

    }
}