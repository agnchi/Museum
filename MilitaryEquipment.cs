using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museum
{
    class MilitaryEquipment:Exhibit
    {
        protected string _contry_of_origin, _predominant_material;

        public MilitaryEquipment(string name, string historic_period, string country_of_origin, string predominant_material): base(name, historic_period)
        {
            _contry_of_origin = country_of_origin;
            _predominant_material=predominant_material;
        }
        public string ContryOfOrigin
        {
            get { return _contry_of_origin; }
        }
        public string PredominantMaterial
        {
            get { return _predominant_material;}
        }
    }
}
