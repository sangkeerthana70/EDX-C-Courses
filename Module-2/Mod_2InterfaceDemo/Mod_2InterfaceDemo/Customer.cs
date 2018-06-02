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
        private int totalPoints;//private member variables

        public int TotalPoints//property
        {
            get { return totalPoints; }
        }


        public int AddPoints(decimal transactionValue)

        {
            int points = Decimal.ToInt32(transactionValue);
            totalPoints += points;
            return totalPoints;

           /* public void ResetPoints()
            {
                totalPoints = 0;
            }*/
        }

    }
}
