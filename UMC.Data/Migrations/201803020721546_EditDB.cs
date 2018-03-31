namespace UMC.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditDB : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Introduces", "Name", c => c.String(nullable: false, maxLength: 500));
            AlterColumn("dbo.Introduces", "Content", c => c.String(nullable: false));
            AlterColumn("dbo.News", "Name", c => c.String(nullable: false, maxLength: 500));
            AlterColumn("dbo.Recruiments", "Name", c => c.String(nullable: false, maxLength: 500));
            AlterColumn("dbo.Recruiments", "Required", c => c.String(nullable: false, maxLength: 3000));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Recruiments", "Required", c => c.String(maxLength: 3000));
            AlterColumn("dbo.Recruiments", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.News", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Introduces", "Content", c => c.String(nullable: false, maxLength: 4000));
            AlterColumn("dbo.Introduces", "Name", c => c.String(nullable: false));
        }
    }
}
