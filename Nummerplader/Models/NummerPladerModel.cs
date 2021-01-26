using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nummerplader.Models
{
    public class NummerPladerModel
    {
        public string Registration_number { get; set; }
        public string Status { get; set; }
        public DateTime Status_date { get; set; }
        public string Type { get; set; }
        public string Use { get; set; }
        public string First_registration { get; set; }
        public string Vin { get; set; }
        public string Own_weight { get; set; }
        public string Total_weight { get; set; }
        public string Axels { get; set; }
        public string Pulling_axels { get; set; }
        public string Seats { get; set; }
        public bool Coupling { get; set; }
        public string Doors { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Variant { get; set; }
        public string Model_type { get; set; }
        public string Model_year { get; set; }
        public string Color { get; set; }
        public string Chassis_type { get; set; }
        public string Engine_cylinders { get; set; }
        public string Engine_volume { get; set; }
        public string Engine_power { get; set; }
        public string Fuel_type { get; set; }
        public string Registration_zipcode { get; set; }
    }
}
