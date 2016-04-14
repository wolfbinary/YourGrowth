using System;
using System.ComponentModel.DataAnnotations;

namespace YourGrowth.Common.Models
{
    public class Exercise
    {
        [Required]
        public long ExerciseId { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public UInt16 GoalReps { get; set; }
        public UInt16 GoalSets { get; set; }

        public bool Active { get; set; }
    }
}
