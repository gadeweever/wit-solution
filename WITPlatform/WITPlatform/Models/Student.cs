using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WITPlatform.DAL;
using System.ComponentModel.DataAnnotations;

namespace WITPlatform.Models
{
    public class Student
    {

        public int ID { get; set; }

        [Display(Name = "Name")]
        [DataType(DataType.Text)]
        public string Name { get; set; }
        public int Grade { get; set; }
        
        [Display(Name  = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        public virtual ICollection<ACTGrade> ACTGrades { get; set; }

        
    }

}