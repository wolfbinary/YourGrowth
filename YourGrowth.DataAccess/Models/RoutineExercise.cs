﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourGrowth.DataAccess.Models
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
    }
}
