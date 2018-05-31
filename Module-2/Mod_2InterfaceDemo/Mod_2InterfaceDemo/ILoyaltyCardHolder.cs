using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_2InterfaceDemo
{
    interface ILoyaltyCardHolder
    {
        int TotalPoints { get; }//read-only property
        int AddPoints(decimal trandsactionValue);//method
        void ResetPoints();//method

    }
}
