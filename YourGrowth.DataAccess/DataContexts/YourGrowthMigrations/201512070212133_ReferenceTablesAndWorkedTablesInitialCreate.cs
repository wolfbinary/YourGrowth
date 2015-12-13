namespace YourGrowth.DataAccess.DataContexts.YourGrowthMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReferenceTablesAndWorkedTablesInitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ExerciseGroup",
                c => new
                    {
                        ExerciseGroupId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.ExerciseGroupId);
            
            CreateTable(
                "dbo.ExerciseRoutine",
                c => new
                    {
                        ExerciseRoutineId = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.ExerciseRoutineId);
            
            CreateTable(
                "dbo.Exercise",
                c => new
                    {
                        ExerciseId = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.ExerciseId);
            
            CreateTable(
                "dbo.ExerciseWorked",
                c => new
                    {
                        ExerciseWorkedId = c.Long(nullable: false, identity: true),
                        RoutineWorkedId = c.Long(nullable: false),
                        NumberOfSets = c.Short(nullable: false),
                        skipped = c.Boolean(nullable: false),
                        Notes = c.String(maxLength: 2048),
                    })
                .PrimaryKey(t => t.ExerciseWorkedId);
            
            CreateTable(
                "dbo.MuscleExercise",
                c => new
                    {
                        MuscleExerciseId = c.Long(nullable: false, identity: true),
                        Exerciseid = c.Long(nullable: false),
                        MuscleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MuscleExerciseId);
            
            CreateTable(
                "dbo.Muscle",
                c => new
                    {
                        MuscleId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.MuscleId);
            
            CreateTable(
                "dbo.RoutineWorked",
                c => new
                    {
                        RoutineWorkedId = c.Long(nullable: false, identity: true),
                        WorkoutDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.RoutineWorkedId);
            
            AlterColumn("dbo.TypeOfExercise", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TypeOfExercise", "Name", c => c.String(nullable: false, maxLength: 50));
            DropTable("dbo.RoutineWorked");
            DropTable("dbo.Muscle");
            DropTable("dbo.MuscleExercise");
            DropTable("dbo.ExerciseWorked");
            DropTable("dbo.Exercise");
            DropTable("dbo.ExerciseRoutine");
            DropTable("dbo.ExerciseGroup");
        }
    }
}
