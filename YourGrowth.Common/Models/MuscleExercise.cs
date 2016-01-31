using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourGrowth.Common.Models
{
    public class MuscleExercise
    {
        [Required]
        public long MuscleExerciseId { get; set; }
        [Required]
        public long Exerciseid { get; set; }
        public Exercise Exercise { get; set; }

        [Required]
        public int MuscleId { get; set; }
        public Muscle Muscle { get; set; }

        public bool Active { get; set; }
    }
}
