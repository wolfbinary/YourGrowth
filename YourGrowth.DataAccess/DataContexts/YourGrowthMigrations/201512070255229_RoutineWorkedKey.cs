namespace YourGrowth.DataAccess.DataContexts.YourGrowthMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RoutineWorkedKey : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RoutineWorked", "ExerciseRoutineId", c => c.Long(nullable: false));
            CreateIndex("dbo.RoutineWorked", "ExerciseRoutineId");
            AddForeignKey("dbo.RoutineWorked", "ExerciseRoutineId", "dbo.ExerciseRoutine", "ExerciseRoutineId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RoutineWorked", "ExerciseRoutineId", "dbo.ExerciseRoutine");
            DropIndex("dbo.RoutineWorked", new[] { "ExerciseRoutineId" });
            DropColumn("dbo.RoutineWorked", "ExerciseRoutineId");
        }
    }
}
