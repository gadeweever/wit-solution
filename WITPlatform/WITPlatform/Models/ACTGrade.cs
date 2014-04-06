using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WITPlatform.DAL;

namespace WITPlatform.Models
{
    public class ACTGrade
    {
        public int ID { get; set; }
        public Grade EnglishGrade { get; set; }
        public Grade MathGrade { get; set; }
        public Grade ScienceGrade { get; set; }
        public Grade ReadingGrade { get; set; }
        public Grade WritingGrade { get; set; }
        public DateTime TestDate { get; set; }


        public List<Grade> GetGrades()
        {
            List<Grade> grades = new List<Grade>();

            grades.Add(this.EnglishGrade);
            grades.Add(this.MathGrade);
            grades.Add(this.ScienceGrade);
            grades.Add(this.ReadingGrade);
            grades.Add(this.WritingGrade);

            return grades;
        }
    }

   

}