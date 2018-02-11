using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Manager : Employee
    {
        //fields
        //properties
        //empid? Salary?
        //constructors
        //methods
        //adopt a pet
        public void AdoptPet()
        {
            Console.WriteLine("the Pet is adopted");
        }
        public void FeedPets()
        {
            Console.WriteLine("Pets are Fed");
        }
        public void WaterPets()
        {
            Console.WriteLine("Pets are watered");
        }
        //clockin override?
        public override bool ClockIn()
        {
            return true;
        }

        public override bool ShowId()
        {
            return true;
        }
    }
}
