using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    class Cat
    {
        //STATES
        //fields
        private string name;

        //Properties
        public string Name
        {
            get { return this.name;  }
            set { this.name = value; }
        }


        //BEHAVIORS
        //Constructors
        public Cat()
        {
            //default constructor, takes not parameters in the parenthesis
        }

    }
}
