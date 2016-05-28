using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourGrowth.Common.Models
{
    public class RoutineExercise
    {
        [Required]
        public long RoutineExerciseId { get; set; }
        [Required]
        public long ExerciseId { get; set; }
        public Exercise Exercise { get; set; }

        public int ExerciseGroupId { get; set; }
        public ExerciseGroup ExerciseGroup { get; set; }

        public bool Active { get; set; }

        public int Priority { get; set; }
        public int NumberOfTimes { get; set; }
        public int GoalReps { get; set; }
        public int GoalSets { get; set; }
    }
}
