namespace Infraestructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "studentLastname", c => c.String(nullable: false));
            AddColumn("dbo.Students", "studentCodigo", c => c.String(nullable: false));
            AddColumn("dbo.Students", "fechaCreacion", c => c.DateTime(nullable: false));
            AddColumn("dbo.Students", "fechaModificacion", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "fechaModificacion");
            DropColumn("dbo.Students", "fechaCreacion");
            DropColumn("dbo.Students", "studentCodigo");
            DropColumn("dbo.Students", "studentLastname");
        }
    }
}
