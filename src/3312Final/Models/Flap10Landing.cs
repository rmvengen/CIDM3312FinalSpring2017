﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace Q400Calculator.Models
{
    public class Flap10Landing
    {
        public int Id { get; set; }
        public int Weight { get; set; }

        [Display (Name = "V app Flaps 10")]
        public int Vapp { get; set; }

        [Display(Name = "V ref Flaps 10")]
        public int Vref { get; set; }

        [Display(Name = "V ga Flaps 10")]
        public int Vga { get; set; }

    }
}
