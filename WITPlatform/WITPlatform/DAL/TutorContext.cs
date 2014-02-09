using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using WITPlatform.Models;

namespace WITPlatform.DAL
{
    public class TutorContext : DbContext
    {

        public TutorContext()
            : base("TutorContext")
        {
        }

        public DbSet<Student> Student { get; set; }
        public DbSet<ACTGrade> ACTGrade { get; set; }
        public DbSet<Teacher> Teacher { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        //}
    }

}