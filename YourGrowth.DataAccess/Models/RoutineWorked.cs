using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourGrowth.DataAccess.Models
{
    public class RoutineWorked
    {
        [Required]
        public long RoutineWorkedId { get; set; }

        [Required]
        public long ExerciseRoutineId { get; set; }
        public ExerciseRoutine ExerciseRoutine { get; set; }

        [Required]
        public DateTime WorkoutDate { get; set; }

        public bool Active { get; set; }
    }
}
