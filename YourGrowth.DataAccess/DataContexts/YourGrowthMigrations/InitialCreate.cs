namespace YourGrowth.DataAccess.DataContexts.YourGrowthMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TypeOfExercise",
                c => new
                    {
                        TypeOfExerciseId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.TypeOfExerciseId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TypeOfExercise");
        }
    }
}
