using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_1
{
    public class Agent : Employee
    {
        private List<Appointment> apps;//manage appointments
        private List<Animal> animals;//manage animals

        public Agent(int eID, string n, DateTime st, double s)
           : base(eID, n, st, s)
        {

        }

        public void updateDecision(int animalID)
        {

        }

        public void deleteAnimal(Animal adoptedAnimal)
        {
            animals = new List<Animal>();
            animals.Remove(adoptedAnimal);
        }

        public void addAnimal(Animal newAnimal)
        {
            animals = new List<Animal>();
            animals.Add(newAnimal);
        }

    }
}
