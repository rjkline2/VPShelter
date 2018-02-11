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
        public string AdoptPet()
        {
            Console.WriteLine("the Pet is adopted");
        }
        public string FeedPets()
        {
            Console.WriteLine("Pets are Fed");
        }
        public string WaterPets()
        {
            Console.WriteLine("Pets are watered");
        }
        //clockin override?
        public override bool ClockIn()
        {
            throw new NotImplementedException();
        }

    }
}
