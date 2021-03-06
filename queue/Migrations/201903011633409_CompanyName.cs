namespace queue.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CompanyName : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Companies", "Name", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Companies", "Name", c => c.Int(nullable: false));
        }
    }
}
