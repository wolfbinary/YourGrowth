namespace YourGrowth.DataAccess.DataContexts.YourGrowthMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddActiveFieldToTables : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ExerciseGroup", "Active", c => c.Boolean(nullable: false));
            AddColumn("dbo.ExerciseRoutine", "Active", c => c.Boolean(nullable: false));
            AddColumn("dbo.Exercise", "Active", c => c.Boolean(nullable: false));
            AddColumn("dbo.ExerciseWorked", "Active", c => c.Boolean(nullable: false));
            AddColumn("dbo.RoutineExercise", "Active", c => c.Boolean(nullable: false));
            AddColumn("dbo.RoutineWorked", "Active", c => c.Boolean(nullable: false));
            AddColumn("dbo.MuscleExercise", "Active", c => c.Boolean(nullable: false));
            AddColumn("dbo.Muscle", "Active", c => c.Boolean(nullable: false));
            AddColumn("dbo.TypeOfExercise", "Active", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TypeOfExercise", "Active");
            DropColumn("dbo.Muscle", "Active");
            DropColumn("dbo.MuscleExercise", "Active");
            DropColumn("dbo.RoutineWorked", "Active");
            DropColumn("dbo.RoutineExercise", "Active");
            DropColumn("dbo.ExerciseWorked", "Active");
            DropColumn("dbo.Exercise", "Active");
            DropColumn("dbo.ExerciseRoutine", "Active");
            DropColumn("dbo.ExerciseGroup", "Active");
        }
    }
}
