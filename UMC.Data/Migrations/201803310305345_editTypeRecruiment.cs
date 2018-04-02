namespace UMC.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editTypeRecruiment : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Recruiments", "RecruimentType", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Recruiments", "RecruimentType");
        }
    }
}
