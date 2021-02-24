﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions.Models
{
    [Table("Colors")]
    public class Color
    {
        public int Id { get; set; }

        [Required]
        public string ColorName { get; set; }
        [Required]
        [Range(0,255)]
        public int Red { get; set; }
        [Required]
        [Range(0, 255)]
        public int Green { get; set; }
        [Required]
        [Range(0, 255)]
        public int Blue { get; set; }

    }
}
