namespace EntityCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameMusteriUnvanToMusteriSoyadInMusteriTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Musteris", "MusteriSoyad", c => c.String());
            DropColumn("dbo.Musteris", "MusteriSehir");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Musteris", "MusteriSehir", c => c.String());
            DropColumn("dbo.Musteris", "MusteriSoyad");
        }
    }
}
