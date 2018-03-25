namespace AssetManagement.Migrations.AccountScripts
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ResourcesTest : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Resources", "FacilityName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Resources", "FacilityName");
        }
    }
}
