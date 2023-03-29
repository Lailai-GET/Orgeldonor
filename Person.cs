using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orgeldonor
{
    internal class Person
    {
        private string _name;
        private Kidney[] _kidneys;

        public Person(string name, bool kidney1IsGood, bool kidney2IsGood)
        {
            _name = name;
            _kidneys = new Kidney[2];
            _kidneys[0] = new Kidney(kidney1IsGood);
            _kidneys[1] = new Kidney(kidney2IsGood);
        }

        public void RemoveKidney()
        {
            if (_kidneys[1].IsGood()) _kidneys[1].ChangeStatus();
        }

        public void AddKidney()
        {
            if (!_kidneys[1].IsGood()) _kidneys[1].ChangeStatus();
        }

        public string Name()
        {
            return _name;
        }

        
        public int WorkingKidneys()
        {
            int functionalKidneys = 0;
            foreach (var kidney in _kidneys)
            {
                if (kidney.IsGood())
                {
                    functionalKidneys++;
                }
            }

            return functionalKidneys;
        }

    }
}
