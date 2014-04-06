using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WITTracker.Models
{
    public class Room
    {
        public int ID { get; set; }
        public string RoomNumber { get; set; }
        public int BuildingID { get; set; }
        public int SubjectID { get; set; }

        public virtual Building RoomLocation { get; set; }
        public virtual Subject RoomSubject { get; set; }
    }
}