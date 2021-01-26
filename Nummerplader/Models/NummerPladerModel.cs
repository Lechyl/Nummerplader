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
        public int Own_weight { get; set; }
        public int Total_weight { get; set; }
        public int Axels { get; set; }
        public string Pulling_axels { get; set; }
        public int Seats { get; set; }
        public bool Coupling { get; set; }
        public int Doors { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Variant { get; set; }
        public string Model_type { get; set; }
        public int Model_year { get; set; }
        public string Color { get; set; }
        public string Chassis_type { get; set; }
        public int Engine_cylinders { get; set; }
        public string Engine_volume { get; set; }
        public string Engine_power { get; set; }
        public string Fuel_type { get; set; }
        public string Registration_zipcode { get; set; }
    }
}
