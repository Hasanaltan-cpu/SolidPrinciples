using SolidPrinciples.Lab_4_InterfaceSegregationPrinciple.BadExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.Lab_4_InterfaceSegregationPrinciple.BadExample.Concrete
{
    public class Penguin : ISeaAnimal
    {
        public string Swim()
        {
            return "All Penguin can swim";
        }

        public string Walk()
        {
            return "All Penguin can walk" ;
        }
    }
}
