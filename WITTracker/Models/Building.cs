using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WITTracker.Models
{
    public class Building
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Room> Rooms { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}