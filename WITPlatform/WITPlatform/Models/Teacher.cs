using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WITPlatform.DAL;

namespace WITPlatform.Models
{
    public class Teacher
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Subject1 {get; set; }
        public string Subject2 {get; set;}

        public virtual ICollection<Student> Students { get; set; }
    }
}