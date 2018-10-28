namespace Vielo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatingMembershipTypeName1 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MemberShipTypes SET Name='Pay as You Go' where Id=1");
            Sql("UPDATE MemberShipTypes SET Name='Monthly' where Id=2");
            Sql("UPDATE MemberShipTypes SET Name='Quarterly' where Id=3");
            Sql("UPDATE MemberShipTypes SET Name='Annual' where Id=4");
        }
        
        public override void Down()
        {
        }
    }
}
