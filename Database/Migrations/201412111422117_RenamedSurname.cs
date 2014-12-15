namespace Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenamedSurname : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Families", new[] { "FamilyName" });
            AddColumn("dbo.Families", "Surname", c => c.String(nullable: false, maxLength: 100));
            CreateIndex("dbo.Families", "Surname");
            DropColumn("dbo.Families", "FamilyName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Families", "FamilyName", c => c.String(nullable: false, maxLength: 100));
            DropIndex("dbo.Families", new[] { "Surname" });
            DropColumn("dbo.Families", "Surname");
            CreateIndex("dbo.Families", "FamilyName");
        }
    }
}
