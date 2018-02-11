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
            Console.WriteLine("You are clocked in..");
        }
       public string FeedPets()
        {
            Console.WriteLine("Pets are Fed");
        }
        public string WaterPets()
        {
            Console.WriteLine("Pets are watered");
        }
    }
}
