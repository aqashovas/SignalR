namespace queue.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class jjh : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TableNoes", "User_Id", "dbo.Users");
            DropIndex("dbo.TableNoes", new[] { "User_Id" });
            DropPrimaryKey("dbo.Users");
            AlterColumn("dbo.TableNoes", "User_Id", c => c.Int());
            AlterColumn("dbo.Users", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Users", "Id");
            CreateIndex("dbo.TableNoes", "User_Id");
            AddForeignKey("dbo.TableNoes", "User_Id", "dbo.Users", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TableNoes", "User_Id", "dbo.Users");
            DropIndex("dbo.TableNoes", new[] { "User_Id" });
            DropPrimaryKey("dbo.Users");
            AlterColumn("dbo.Users", "Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.TableNoes", "User_Id", c => c.String(maxLength: 128));
            AddPrimaryKey("dbo.Users", "Id");
            CreateIndex("dbo.TableNoes", "User_Id");
            AddForeignKey("dbo.TableNoes", "User_Id", "dbo.Users", "Id");
        }
    }
}
