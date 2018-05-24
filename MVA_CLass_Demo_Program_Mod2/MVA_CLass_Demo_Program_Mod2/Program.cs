using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVA_CLass_Demo_Program_Mod2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Anon Class
            // C# deals with inferring the data type for our properties in the anonymous classes based on the values that we have
            //put in.
            for our properties in the anonymous classes based on the values that we have
            put in.

                        var anon = new { Name = "Jerrry", Age = 29 };
            Console.WriteLine(anon.Name + " " + anon.Age);

            #endregion
        }
    }
}
