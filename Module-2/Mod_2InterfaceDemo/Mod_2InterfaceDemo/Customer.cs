using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_2InterfaceDemo
{
    //implement ILoyaltyCardHolder interface
    class Customer : ILoyaltyCardHolder
    {
        //implementation code
        private int totalPoints;

        public int TotalPoints
        {
            get { return totalPoints; }
        }
    }
}
