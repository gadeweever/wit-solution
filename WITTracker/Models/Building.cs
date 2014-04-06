using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WITTracker.Models
{
    public class Building
    {
        public int ID { get; set; }

        [Display(Name = "Building Name")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        public virtual ICollection<Room> Rooms { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}