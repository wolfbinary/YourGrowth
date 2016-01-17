namespace YourGrowth.DataAccess.DataContexts.YourGrowthMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRoutineProgramTableAndRoutineProgramIdToExerciseRoutineTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RoutineProgram",
                c => new
                    {
                        RoutineProgramId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.RoutineProgramId);
            
            AddColumn("dbo.ExerciseRoutine", "RoutineProgramId", c => c.Int(nullable: false));
            CreateIndex("dbo.ExerciseRoutine", "RoutineProgramId");
            AddForeignKey("dbo.ExerciseRoutine", "RoutineProgramId", "dbo.RoutineProgram", "RoutineProgramId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ExerciseRoutine", "RoutineProgramId", "dbo.RoutineProgram");
            DropIndex("dbo.ExerciseRoutine", new[] { "RoutineProgramId" });
            DropColumn("dbo.ExerciseRoutine", "RoutineProgramId");
            DropTable("dbo.RoutineProgram");
        }
    }
}
