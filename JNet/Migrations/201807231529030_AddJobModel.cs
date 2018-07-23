namespace JNet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddJobModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Jobs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        CompanyId = c.Int(nullable: false),
                        PostDate = c.DateTime(nullable: false),
                        AppliedDate = c.DateTime(nullable: false),
                        Url = c.String(),
                        IsExpired = c.Boolean(nullable: false),
                        UserId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.CompanyId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.CompanyId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LocationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Locations", t => t.LocationId, cascadeDelete: true)
                .Index(t => t.LocationId);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        City = c.String(),
                        State = c.String(),
                        ZipCode = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Jobs", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Jobs", "CompanyId", "dbo.Companies");
            DropForeignKey("dbo.Companies", "LocationId", "dbo.Locations");
            DropIndex("dbo.Companies", new[] { "LocationId" });
            DropIndex("dbo.Jobs", new[] { "UserId" });
            DropIndex("dbo.Jobs", new[] { "CompanyId" });
            DropTable("dbo.Locations");
            DropTable("dbo.Companies");
            DropTable("dbo.Jobs");
        }
    }
}
