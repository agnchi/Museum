using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museum
{
    class HumanRemains : ArcheologicalArtefact
    {
        string _sex;
        int _age;
        public HumanRemains(string name, string historic_period, string place_of_excavation, string condition, string sex, int age) : base(name, historic_period, place_of_excavation, condition)
        {
            _sex = sex;
            _age = age;
        }
        public string Sex
        { get { return _sex; } }
        public int Age
        { get { return _age; } }
    }
}
