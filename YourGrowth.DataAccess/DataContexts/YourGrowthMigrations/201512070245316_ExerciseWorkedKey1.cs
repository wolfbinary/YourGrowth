namespace YourGrowth.DataAccess.DataContexts.YourGrowthMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ExerciseWorkedKey1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ExerciseWorked", "RoutineExerciseId", c => c.Long(nullable: false));
            CreateIndex("dbo.ExerciseWorked", "RoutineExerciseId");
            AddForeignKey("dbo.ExerciseWorked", "RoutineExerciseId", "dbo.RoutineExercise", "RoutineExerciseId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ExerciseWorked", "RoutineExerciseId", "dbo.RoutineExercise");
            DropIndex("dbo.ExerciseWorked", new[] { "RoutineExerciseId" });
            DropColumn("dbo.ExerciseWorked", "RoutineExerciseId");
        }
    }
}
