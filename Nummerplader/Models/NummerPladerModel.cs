using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Nummerplader.Models
{
    public class NummerPladerModel
    {
        [Display(Name = "Registration Number")]

        public string Registration_number { get; set; }
        public string Status { get; set; }

        [Display(Name = "Status Date")]

        public DateTime Status_date { get; set; }
        public string Type { get; set; }
        public string Use { get; set; }
        [Display(Name = "First Registration")]

        public string First_registration { get; set; }
        public string Vin { get; set; }
        [Display(Name = "Own Weight")]

        public string Own_weight { get; set; }
        [Display(Name = "Total Weight")]

        public string Total_weight { get; set; }
        public string Axels { get; set; }

        [Display(Name ="Pulling Axels")]
        public string Pulling_axels { get; set; }
        public string Seats { get; set; }
        public bool Coupling { get; set; }
        public string Doors { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Variant { get; set; }
        [Display(Name = "Model Type")]

        public string Model_type { get; set; }
        [Display(Name = "Model Year")]

        public string Model_year { get; set; }
        public string Color { get; set; }
        [Display(Name = "Chassis Type")]

        public string Chassis_type { get; set; }
        [Display(Name = "Engine Cylinders")]

        public string Engine_cylinders { get; set; }
        [Display(Name = "Engine Volume")]

        public string Engine_volume { get; set; }
        [Display(Name = "Engine Power")]

        public string Engine_power { get; set; }
        [Display(Name = "Fuel Type")]

        public string Fuel_type { get; set; }
        [Display(Name = "Registration Zipcode")]

        public string Registration_zipcode { get; set; }
    }
}
