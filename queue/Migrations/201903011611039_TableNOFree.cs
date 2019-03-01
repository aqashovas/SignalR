namespace queue.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TableNOFree : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TableNoes", "IsFree", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TableNoes", "IsFree");
        }
    }
}
