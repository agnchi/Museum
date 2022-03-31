using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museum
{
    class Cannon : Weapon
    {
        private string _ammunition, _model;
        public Cannon(string name, string historic_period, string country_of_origin, string predominant_material, double weight,string ammunition, string model) : base(name, historic_period, country_of_origin, predominant_material, weight)
        {
            _ammunition = ammunition;
            _model = model;
        }
        public string Ammunition
        { get { return _ammunition; } }
        public string Model
        { get { return _model; } }
    }
}
