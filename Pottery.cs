using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museum
{
    class Pottery : ArcheologicalArtefact
    {
        string _medium, _culture; 
        public Pottery(string name, string historic_period, string place_of_excavation, string condition, string medium, string culture) : base(name, historic_period, place_of_excavation, condition)
        {
            _medium = medium;
            _culture = culture;
        }
        public string Medium
        { get { return _medium; } }
        public string Culture 
        { get { return _culture; } }
    }
}
