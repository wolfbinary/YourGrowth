namespace YourGrowth.DataAccess.DataContexts.YourGrowthMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ExerciseWorkedRestPeriod : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ExerciseWorked", "RestPeriod", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ExerciseWorked", "RestPeriod");
        }
    }
}
