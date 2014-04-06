using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WITTracker.Models
{
    public class Update
    {

        public int ID { get; set; }
        public string Header { get; set; }
        public string Text { get; set; }
        public DateTime TimePosted { get; set; }
        public int TeacherID { get; set; }

        public virtual Teacher Author { get; set; }
    }
}