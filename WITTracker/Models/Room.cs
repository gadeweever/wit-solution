using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WITTracker.Models
{
    public class Room
    {
        public int ID { get; set; }

        [Display(Name = "Room Number")]
        [DataType(DataType.Text)]
        public string RoomNumber { get; set; }

        [Display(Name = "Building Name")]
        [DataType(DataType.Text)]
        public int BuildingID { get; set; }

        public virtual Building RoomLocation { get; set; }

    }
}