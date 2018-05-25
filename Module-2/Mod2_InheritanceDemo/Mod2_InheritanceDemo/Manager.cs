using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_InheritanceDemo
{
    //we will inherit the base class employee into this Manager sub-class
    class Manager : Employee
    {
        //adding new string values in member variables specific to this Manager class.
        private string department;
        //encapsulate the department variable.
        public string Department { get => department; set => department = value; }
    }
}
