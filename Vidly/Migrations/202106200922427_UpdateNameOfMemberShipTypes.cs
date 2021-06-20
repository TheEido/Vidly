namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateNameOfMemberShipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MemberShipTypes SET Name = 'Pay As You Go' WHERE Id = 1");
            Sql("UPDATE MemberShipTypes SET Name = 'Monthly' WHERE Id = 2");
            Sql("UPDATE MemberShipTypes SET Name = 'Quarter Year' WHERE Id = 3");
            Sql("UPDATE MemberShipTypes SET Name = 'Yearly' WHERE Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
