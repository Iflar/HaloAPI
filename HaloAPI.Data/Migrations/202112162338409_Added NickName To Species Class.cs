namespace HaloAPI.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedNickNameToSpeciesClass : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Species", "NickName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Species", "NickName");
        }
    }
}
