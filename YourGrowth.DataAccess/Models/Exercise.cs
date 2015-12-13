using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourGrowth.DataAccess.Models
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
    }
}
