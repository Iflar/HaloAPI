namespace HaloAPI.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Factions", "YearActive", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Factions", "YearActive", c => c.Int(nullable: false));
        }
    }
}
