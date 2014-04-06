using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using WITTracker.Models;

namespace WITTracker.DAL
{
    public class WITContext : DbContext
    {


        public WITContext() : base("WITContext")
        {

        }

        public DbSet<Building> Buildings { get; set; }
        public DbSet<Student>Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Grade> Grades { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Room>()
                .HasRequired(r => r.RoomLocation)
                .WithMany(b => b.Rooms)
                //.HasForeignKey(r => r.BuildingID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .HasRequired(s => s.Teacher)
                .WithMany(t => t.StudentsTeaching)
                .WillCascadeOnDelete(false);

            base.OnModelCreating(modelBuilder);
        }

    }
}