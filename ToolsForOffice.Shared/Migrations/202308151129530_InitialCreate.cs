namespace ToolsForOffice.Shared.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DailyTasks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        TotalAmount = c.Int(),
                        CustomValue1 = c.Int(),
                        CustomValue2 = c.Int(),
                        CustomValue3 = c.Int(),
                        CustomValue4 = c.Int(),
                        Completed = c.Boolean(nullable: false),
                        StartTime = c.DateTime(),
                        TaskType = c.String(maxLength: 2147483647),
                        Priority = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(maxLength: 2147483647),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DailyTasks", "UserId", "dbo.Users");
            DropIndex("dbo.DailyTasks", new[] { "UserId" });
            DropTable("dbo.Users");
            DropTable("dbo.DailyTasks");
        }
    }
}
