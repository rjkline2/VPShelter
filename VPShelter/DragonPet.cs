using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class DragonPet : VirtualPet
    {
        //Fields
        private string typeAnimal;
        private string petDiet;


        //Properties
        public string TypeAnimal
        {
            get { return this.typeAnimal; }
            set { this.typeAnimal = value; }
        }
        public string PetDiet
        {
            get { return this.petDiet; }
            set { this.petDiet = value; }
        }

        //Constructors
        //Methods

    }
}
