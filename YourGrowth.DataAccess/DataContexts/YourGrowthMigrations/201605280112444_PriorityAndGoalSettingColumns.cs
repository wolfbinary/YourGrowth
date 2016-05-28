namespace YourGrowth.DataAccess.DataContexts.YourGrowthMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PriorityAndGoalSettingColumns : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ExerciseWorked", "NumberOfTimes", c => c.Int(nullable: false));
            AddColumn("dbo.RoutineExercise", "Priority", c => c.Int(nullable: false));
            AddColumn("dbo.RoutineExercise", "NumberOfTimes", c => c.Int(nullable: false));
            AddColumn("dbo.RoutineExercise", "GoalReps", c => c.Int(nullable: false));
            AddColumn("dbo.RoutineExercise", "GoalSets", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.RoutineExercise", "GoalSets");
            DropColumn("dbo.RoutineExercise", "GoalReps");
            DropColumn("dbo.RoutineExercise", "NumberOfTimes");
            DropColumn("dbo.RoutineExercise", "Priority");
            DropColumn("dbo.ExerciseWorked", "NumberOfTimes");
        }
    }
}
