namespace YourGrowth.DataAccess.DataContexts.YourGrowthMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RoutineExerciseKey : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RoutineExercise",
                c => new
                    {
                        RoutineExerciseId = c.Long(nullable: false, identity: true),
                        ExerciseId = c.Long(nullable: false),
                        ExerciseGroupId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RoutineExerciseId)
                .ForeignKey("dbo.Exercise", t => t.ExerciseId, cascadeDelete: true)
                .ForeignKey("dbo.ExerciseGroup", t => t.ExerciseGroupId, cascadeDelete: true)
                .Index(t => t.ExerciseId)
                .Index(t => t.ExerciseGroupId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RoutineExercise", "ExerciseGroupId", "dbo.ExerciseGroup");
            DropForeignKey("dbo.RoutineExercise", "ExerciseId", "dbo.Exercise");
            DropIndex("dbo.RoutineExercise", new[] { "ExerciseGroupId" });
            DropIndex("dbo.RoutineExercise", new[] { "ExerciseId" });
            DropTable("dbo.RoutineExercise");
        }
    }
}
