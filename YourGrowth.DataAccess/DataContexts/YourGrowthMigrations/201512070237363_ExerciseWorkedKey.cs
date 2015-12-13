namespace YourGrowth.DataAccess.DataContexts.YourGrowthMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ExerciseWorkedKey : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.ExerciseWorked", "RoutineWorkedId");
            AddForeignKey("dbo.ExerciseWorked", "RoutineWorkedId", "dbo.RoutineWorked", "RoutineWorkedId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ExerciseWorked", "RoutineWorkedId", "dbo.RoutineWorked");
            DropIndex("dbo.ExerciseWorked", new[] { "RoutineWorkedId" });
        }
    }
}
