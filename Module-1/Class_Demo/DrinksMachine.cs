using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Demo
{
    class DrinksMachine
    {
        //another constructor to assign member variables when we create a new Drinks machine object
        public DrinksMachine(string loc, string make, string model)
        {
            this.Location = loc;
            this.Make = make;
            this.Model = model;
        }
        //the following statements declare private member variables
        private string _location;
        private string _make;
        private string _model;

        //the following statements are public access  methods
        public string Location { get => _location; set => _location = value; }
        public string Make { get => _make; set => _make = value; }
        public string Model { get => _model; set => _model = value; }


        //the following statements declare public methods
        public void MakeCappuccino()
        {
            Console.WriteLine("Cappuccino is made");
        }
        public void MakeEspresso()
        {
            // Method logic goes here.
        }


    }
}
