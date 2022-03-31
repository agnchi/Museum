using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museum
{
    class Uniform : MilitaryEquipment
    {
        private string _color, _rank, _sex; 
        public Uniform(string name, string historic_period, string country_of_origin, string predominant_material, string color, string rank, string sex) : base(name, historic_period, country_of_origin, predominant_material)
        {
            _color = color;
            _rank = rank;
            _sex = sex;
        }
        public string Color
        { get { return _color; } }
        public string Rank
        { get { return _rank; }}   
        public string Sex 
        { get { return _sex; }}
    }
}
