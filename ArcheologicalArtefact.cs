using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museum
{
    class ArcheologicalArtefact:Exhibit
    {
        string _place_of_excavation, _condition;

        public ArcheologicalArtefact(string name, string historic_period, string place_of_excavation, string condition) : base(name, historic_period)
        {
            _place_of_excavation = place_of_excavation;
            _condition = condition;
        }
        public string PlaceOfExcavation
        {
            get { return _place_of_excavation;}
        }
        public string Condition
        {
            get { return _condition;}
        }
        
    }
}
