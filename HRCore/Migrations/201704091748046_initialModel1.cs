namespace HRCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialModel1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("public.Employees", "BirthDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("public.Employees", "BirthDate", c => c.DateTime(nullable: false));
        }
    }
}
