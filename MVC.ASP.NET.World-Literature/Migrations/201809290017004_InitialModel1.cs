namespace MVC.ASP.NET.World_Literature.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Stores", newName: "Stories");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Stories", newName: "Stores");
        }
    }
}
