namespace WITTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Updates",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Header = c.String(),
                        Text = c.String(),
                        TimePosted = c.DateTime(nullable: false),
                        TeacherID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Teachers", t => t.TeacherID)
                .Index(t => t.TeacherID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Updates", "TeacherID", "dbo.Teachers");
            DropIndex("dbo.Updates", new[] { "TeacherID" });
            DropTable("dbo.Updates");
        }
    }
}
