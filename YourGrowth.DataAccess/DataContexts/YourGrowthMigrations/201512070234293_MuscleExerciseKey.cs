namespace YourGrowth.DataAccess.DataContexts.YourGrowthMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MuscleExerciseKey : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.MuscleExercise", "Exerciseid");
            CreateIndex("dbo.MuscleExercise", "MuscleId");
            AddForeignKey("dbo.MuscleExercise", "Exerciseid", "dbo.Exercise", "ExerciseId", cascadeDelete: true);
            AddForeignKey("dbo.MuscleExercise", "MuscleId", "dbo.Muscle", "MuscleId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MuscleExercise", "MuscleId", "dbo.Muscle");
            DropForeignKey("dbo.MuscleExercise", "Exerciseid", "dbo.Exercise");
            DropIndex("dbo.MuscleExercise", new[] { "MuscleId" });
            DropIndex("dbo.MuscleExercise", new[] { "Exerciseid" });
        }
    }
}
