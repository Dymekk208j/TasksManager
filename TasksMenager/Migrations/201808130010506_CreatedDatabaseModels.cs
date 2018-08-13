namespace TasksMenager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatedDatabaseModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        ProjectId = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Title = c.String(),
                        TimeBudgetAllocated = c.Single(nullable: false),
                        UsedTimeBudget = c.Single(nullable: false),
                        Deadline = c.DateTime(nullable: false),
                        SheduledDate = c.DateTime(nullable: false),
                        ResponseDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Description = c.String(),
                        State = c.Int(nullable: false),
                        AssignedTo_Id = c.String(maxLength: 128),
                        Company_CompanyId = c.Int(),
                    })
                .PrimaryKey(t => t.ProjectId)
                .ForeignKey("dbo.AspNetUsers", t => t.AssignedTo_Id)
                .ForeignKey("dbo.Companies", t => t.Company_CompanyId)
                .Index(t => t.AssignedTo_Id)
                .Index(t => t.Company_CompanyId);
            
            CreateTable(
                "dbo.RegisteredRealizations",
                c => new
                    {
                        RegisteredRealizationId = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        AmountOfHours = c.Single(nullable: false),
                        User_Id = c.String(maxLength: 128),
                        Project_ProjectId = c.Int(),
                    })
                .PrimaryKey(t => t.RegisteredRealizationId)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .ForeignKey("dbo.Projects", t => t.Project_ProjectId)
                .Index(t => t.User_Id)
                .Index(t => t.Project_ProjectId);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        CompanyId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Street = c.String(),
                        HouseNumber = c.String(),
                        FlatNumber = c.String(),
                        City = c.String(),
                    })
                .PrimaryKey(t => t.CompanyId);
            
            AddColumn("dbo.AspNetUsers", "Login", c => c.String());
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String());
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String());
            AddColumn("dbo.AspNetUsers", "Street", c => c.String());
            AddColumn("dbo.AspNetUsers", "HouseNumber", c => c.String());
            AddColumn("dbo.AspNetUsers", "FlatNumber", c => c.String());
            AddColumn("dbo.AspNetUsers", "PostCode", c => c.String());
            AddColumn("dbo.AspNetUsers", "PhoneNumberSecond", c => c.String());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RegisteredRealizations", "Project_ProjectId", "dbo.Projects");
            DropForeignKey("dbo.Projects", "Company_CompanyId", "dbo.Companies");
            DropForeignKey("dbo.RegisteredRealizations", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Projects", "AssignedTo_Id", "dbo.AspNetUsers");
            DropIndex("dbo.RegisteredRealizations", new[] { "Project_ProjectId" });
            DropIndex("dbo.RegisteredRealizations", new[] { "User_Id" });
            DropIndex("dbo.Projects", new[] { "Company_CompanyId" });
            DropIndex("dbo.Projects", new[] { "AssignedTo_Id" });
            DropColumn("dbo.AspNetUsers", "PhoneNumberSecond");
            DropColumn("dbo.AspNetUsers", "PostCode");
            DropColumn("dbo.AspNetUsers", "FlatNumber");
            DropColumn("dbo.AspNetUsers", "HouseNumber");
            DropColumn("dbo.AspNetUsers", "Street");
            DropColumn("dbo.AspNetUsers", "LastName");
            DropColumn("dbo.AspNetUsers", "FirstName");
            DropColumn("dbo.AspNetUsers", "Login");
            DropTable("dbo.Companies");
            DropTable("dbo.RegisteredRealizations");
            DropTable("dbo.Projects");
        }
    }
}
