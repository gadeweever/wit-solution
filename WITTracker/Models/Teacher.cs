using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WITTracker.Models
{
    public class Teacher
    {
        public int ID { get; set; }

        [Display(Name = "First Name")]
        [DataType(DataType.Text)]
        public String FirstName { get; set;}

        [Display(Name = "Last Name")]
        [DataType(DataType.Text)]
        public String LastName { get; set; }
        public int SubjectID { get; set; }
        public int BuildingID { get; set; }
        public string Email {get;set;}

        public virtual Subject PreferenceSubject {get;set; }

        
        public virtual ICollection<Student> StudentsTeaching { get; set; }
        public virtual ICollection<Update> Updates { get; set; }
        public virtual Building Location { get; set; }
    }
}