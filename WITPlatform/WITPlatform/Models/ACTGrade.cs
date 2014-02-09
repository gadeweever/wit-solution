using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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
    }
}