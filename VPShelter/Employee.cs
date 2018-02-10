using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public abstract class Employee
    {

        //fields
        
        //properties
        public int EmpID { get; set; }

        //contructors

        //methods
        public abstract bool ClockIn();

        public abstract bool ShowId();






    }
}
