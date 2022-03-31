using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museum
{
    class Sword : Weapon
    {
        private string _blade_type;
        public Sword(string name, string historic_period, string country_of_origin, string predominant_material, double weight, string blade_type) : base(name, historic_period, country_of_origin, predominant_material, weight)
        {
            _blade_type = blade_type;
        }
        public string BladeType
        { get { return _blade_type; } }
    }
  
}
