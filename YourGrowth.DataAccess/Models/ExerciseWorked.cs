using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourGrowth.DataAccess.Models
{
    public class ExerciseWorked
    {
        [Required]
        public long ExerciseWorkedId { get; set; }

        [Required]
        public long RoutineWorkedId { get; set; }
        public RoutineWorked RoutineWorked { get; set; }

        [Required]
        public long RoutineExerciseId { get; set; }
        public RoutineExercise RoutineExercise { get; set; }

        [Required]
        public Int16 NumberOfSets { get; set; }

        public bool skipped { get; set; }
        [StringLength(2048)]
        public string Notes { get; set; }

        //In seconds
        public int RestPeriod { get; set; }

        public bool Active { get; set; }
    }
}
