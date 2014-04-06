using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WITTracker.Models;


namespace WITTracker.DAL
{
    public class WITInit : System.Data.Entity.DropCreateDatabaseIfModelChanges<WITContext>
    {
        protected override void Seed(WITContext context)
        {
            var buildings = new List<Building>
            {
                new Building{Name = "Harper"},
                new Building{Name = "Mansueto"},
                new Building{Name = "Regenstein"},
                new Building{Name = "Cobb Hall"}
            };
            buildings.ForEach(b => context.Buildings.Add(b));
            context.SaveChanges();

            var rooms = new List<Room>
            {
                new Room{RoomNumber = "114", BuildingID = 1},
                new Room{RoomNumber = "168", BuildingID = 1},
                new Room{RoomNumber = "179", BuildingID = 1},
                new Room{RoomNumber = "A1", BuildingID = 2},
                new Room{RoomNumber = "A2", BuildingID = 2},
                new Room{RoomNumber = "B4", BuildingID = 3},
                new Room{RoomNumber = "368", BuildingID = 3},
                new Room{RoomNumber = "405", BuildingID = 3},
                new Room{RoomNumber = "538", BuildingID = 3},
            };
            rooms.ForEach(r => context.Rooms.Add(r));
            context.SaveChanges();

            var subjects = new List<Subject>
            {
                new Subject{Name = "Composite"},
                new Subject{Name = "English"},
                new Subject{Name = "Math"},
                new Subject{Name = "Writing"},
                new Subject{Name = "Reading"},
                new Subject{Name = "Science"}
            };
            subjects.ForEach(s => context.Subjects.Add(s));


        }
    }
}