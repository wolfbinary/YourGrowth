﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourGrowth.DataAccess.Models
{
    public class RoutineProgram
    {
        [Required]
        public int RoutineProgramId { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool Active { get; set; }
    }
}
