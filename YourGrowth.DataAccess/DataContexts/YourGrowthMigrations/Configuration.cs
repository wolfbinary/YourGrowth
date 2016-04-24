namespace YourGrowth.DataAccess.DataContexts.YourGrowthMigrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Common.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<YourGrowth.DataAccess.Contexts.YourGrowthContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"DataContexts\YourGrowthMigrations";
        }

        protected override void Seed(YourGrowth.DataAccess.Contexts.YourGrowthContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            //if(context.TypesOfExercise.Count == 0)
            //{

            //}
            context.Muscles.AddOrUpdate(m => m.Name,
                new Muscle()
                {
                    MuscleId = 1,
                    Name = "Chest",
                    Active = true
                },
                new Muscle()
                {
                    MuscleId = 2,
                    Name = "Bicep",
                    Active = true
                },
                new Muscle()
                {
                    MuscleId = 3,
                    Name = "Tricep",
                    Active = true
                },
                new Muscle()
                {
                    MuscleId = 4,
                    Name = "Shoulders",
                    Active = true
                },
                new Muscle()
                {
                    MuscleId = 5,
                    Name = "Back",
                    Active = true
                },
                new Muscle()
                {
                    MuscleId = 6,
                    Name = "Legs",
                    Active = true
                },
                new Muscle()
                {
                    MuscleId = 7,
                    Name = "Abs",
                    Active = true
                }
                );
        }
    }
}
