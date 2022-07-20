namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig21 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Writers", "WriterSurname", c => c.String(maxLength: 50));
            DropColumn("dbo.Writers", "WriterUsername");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Writers", "WriterUsername", c => c.String(maxLength: 50));
            DropColumn("dbo.Writers", "WriterSurname");
        }
    }
}
