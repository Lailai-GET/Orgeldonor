using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orgeldonor
{
    internal class OperationRoom
    {
        private Person[] _patients;

        public OperationRoom()
        {
            _patients = new Person[2];
            _patients[0] = new Person("Bernt", false, false);
            _patients[1] = new Person("Kåre", true, true);
        }

        public void PreformOperation()
        {
            ListPeopleAndKidneyStatus();
            Console.WriteLine("Gjennomfører operasjonen");
            _patients[1].RemoveKidney();
            _patients[0].AddKidney();
            ListPeopleAndKidneyStatus();
        }

        private void ListPeopleAndKidneyStatus()
        {
            foreach (Person person in _patients)
            {
                Console.WriteLine($"{person.Name()} har {person.WorkingKidneys()} brukbare nyrer.");
            }
        }
    }
}
