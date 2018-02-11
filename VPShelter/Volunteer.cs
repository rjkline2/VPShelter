using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Volunteer : Employee
    {
        //fields
        //Empid?
        //hr avail?
        //properties
        public int VolAvail { get; set; }

        //constructors

        //methods
        //overide, feed pets, water pets
        public override bool ClockIn()
        {
            return true;
        }
       public void FeedPets()
        {
            Console.WriteLine("Pets are Fed");
        }

        public override bool ShowId()
        {
            return true;
        }

        public void WaterPets()
        {
            Console.WriteLine("Pets are watered");
        }
    }
}
