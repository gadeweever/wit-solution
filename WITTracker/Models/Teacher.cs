using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WITTracker.Models
{
    public class Teacher
    {
        public int ID { get; set; }
        public String FirstName { get; set;}
        public String LastName { get; set; }
        public int SubjectID { get; set; }
        public int BuildingID { get; set; }
        public string Email {get;set;}

        public virtual Subject PreferenceSubject {get;set; }

        
        public virtual ICollection<Student> StudentsTeaching { get; set; }
        public virtual Building Location { get; set; }
    }
}