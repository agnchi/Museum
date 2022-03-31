using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museum
{
    class Weapon : MilitaryEquipment
    {
        private double _weight; 
        public Weapon(string name, string historic_period, string country_of_origin, string predominant_material,double weight) : base(name, historic_period, country_of_origin, predominant_material)
        {
            _weight = weight;
        }
        public double WeaponWeight
        { get { return _weight; } }
    }
}
