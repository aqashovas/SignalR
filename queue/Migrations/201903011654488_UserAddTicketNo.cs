namespace queue.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserAddTicketNo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TableNoes", "User_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.Users", "TableNoId", c => c.Int(nullable: false));
            CreateIndex("dbo.TableNoes", "User_Id");
            AddForeignKey("dbo.TableNoes", "User_Id", "dbo.Users", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TableNoes", "User_Id", "dbo.Users");
            DropIndex("dbo.TableNoes", new[] { "User_Id" });
            DropColumn("dbo.Users", "TableNoId");
            DropColumn("dbo.TableNoes", "User_Id");
        }
    }
}
