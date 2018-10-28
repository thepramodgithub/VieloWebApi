namespace Vielo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class numberAvailbleInMovie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "NumberAvailable", c => c.Int(nullable: false));
            Sql("Update Movies SET NumberAvailable=NumberInStock");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "NumberAvailable");
        }
    }
}
