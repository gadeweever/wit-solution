namespace WITTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Buildings",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RoomNumber = c.String(),
                        BuildingID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Buildings", t => t.BuildingID)
                .Index(t => t.BuildingID);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        SubjectID = c.Int(nullable: false),
                        BuildingID = c.Int(nullable: false),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Buildings", t => t.BuildingID, cascadeDelete: true)
                .ForeignKey("dbo.Subjects", t => t.SubjectID, cascadeDelete: true)
                .Index(t => t.SubjectID)
                .Index(t => t.BuildingID);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Grades",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SubjectID = c.Int(nullable: false),
                        StudentID = c.Int(nullable: false),
                        Score = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Subjects", t => t.SubjectID, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentID, cascadeDelete: true)
                .Index(t => t.SubjectID)
                .Index(t => t.StudentID);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        TeacherID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Teachers", t => t.TeacherID)
                .Index(t => t.TeacherID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teachers", "SubjectID", "dbo.Subjects");
            DropForeignKey("dbo.Students", "TeacherID", "dbo.Teachers");
            DropForeignKey("dbo.Grades", "StudentID", "dbo.Students");
            DropForeignKey("dbo.Grades", "SubjectID", "dbo.Subjects");
            DropForeignKey("dbo.Teachers", "BuildingID", "dbo.Buildings");
            DropForeignKey("dbo.Rooms", "BuildingID", "dbo.Buildings");
            DropIndex("dbo.Students", new[] { "TeacherID" });
            DropIndex("dbo.Grades", new[] { "StudentID" });
            DropIndex("dbo.Grades", new[] { "SubjectID" });
            DropIndex("dbo.Teachers", new[] { "BuildingID" });
            DropIndex("dbo.Teachers", new[] { "SubjectID" });
            DropIndex("dbo.Rooms", new[] { "BuildingID" });
            DropTable("dbo.Students");
            DropTable("dbo.Grades");
            DropTable("dbo.Subjects");
            DropTable("dbo.Teachers");
            DropTable("dbo.Rooms");
            DropTable("dbo.Buildings");
        }
    }
}
