using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace Q400Calculator.Models
{
    public class Flaps5Takeoff
    {
        public int Id { get; set; }
        public int Weight { get; set; }
        public int Altitude { get; set; }
        public int OAT { get; set; }
        [Display(Name = "Vr Flaps 5")]
        public int Vr { get; set; }

        [Display(Name = "V2 Flaps 5")]
        public int V2 { get; set; }

        
    }
}
