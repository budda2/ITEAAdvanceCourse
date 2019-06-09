namespace DB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Children", "OtherNickname", c => c.String());
            AddColumn("dbo.Persons", "OtherNickname", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Persons", "OtherNickname");
            DropColumn("dbo.Children", "OtherNickname");
        }
    }
}
