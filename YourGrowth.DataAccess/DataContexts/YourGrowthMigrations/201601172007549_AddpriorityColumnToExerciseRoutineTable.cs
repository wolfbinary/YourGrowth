namespace YourGrowth.DataAccess.DataContexts.YourGrowthMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddpriorityColumnToExerciseRoutineTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ExerciseRoutine", "Priority", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ExerciseRoutine", "Priority");
        }
    }
}
