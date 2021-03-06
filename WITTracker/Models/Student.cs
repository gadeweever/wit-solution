﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WITTracker.Models
{
    public class Student
    {

        public int ID { get; set; }
        [Display(Name = "First Name")]
        [DataType(DataType.Text)]
        public String FirstName { get; set; }

        [Display(Name = "Last Name")]
        [DataType(DataType.Text)]
        public String LastName { get; set; }
        public int TeacherID { get; set; }



        public virtual Teacher Teacher { get; set; }
        public virtual ICollection<Grade> Grades { get; set; }
    }
}