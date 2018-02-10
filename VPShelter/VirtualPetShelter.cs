using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class VirtualPetShelter
    {
        //Fields 
        List<string> petList = new List<string>() { "Maurice", "Chauncey", "Lockheed" };
        List<string> empList = new List<string>() { "Fred", "Velma", "Nardo" };

        //Properties
        public List<string> PetList
        {
            get { return petList; }
            set { petList = value; }
        }
    }
}
