using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourGrowth.DataAccess.Models;

namespace YourGrowth.DataAccess.Contexts
{
    public class YourGrowthContext : DbContext
    {
        public YourGrowthContext() : base("YourGrowth")
        {

        }
        
        public DbSet<TypeOfExercise> TypesOfExercise { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<ExerciseGroup> ExerciseGroups { get; set; }
        public DbSet<ExerciseRoutine> ExerciseRoutines { get; set; }
        public DbSet<RoutineExercise> RoutineExercises { get; set; }
        public DbSet<Muscle> Muscles { get; set; }
        public DbSet<MuscleExercise> MuscleExercises { get; set; }
        public DbSet<ExerciseWorked> ExercisesWorked { get; set; }
        public DbSet<RoutineWorked> RoutinesWorked { get; set; }
        public DbSet<RoutineProgram> RoutinePrograms { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
