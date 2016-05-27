using System.ComponentModel.DataAnnotations;

namespace YourGrowth.Common.Models
{
    public class Muscle
    {
        [Required]
        public int MuscleId { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool Active { get; set; }
    }
}
