using SolidPrinciples.Lab_4_InterfaceSegregationPrinciple.BadExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.Lab_4_InterfaceSegregationPrinciple.BadExample.Concrete
{
    public class Dolphin : ISeaAnimal

        //Dolphin.cs is inherited by ISeaAnimal with this way Dolphin took Walking method it is wrongly approach.
    {
        public string Swim()
        {
           return " All Dolphin can swim";
        }

        public string  Walk()
        {
            return " All Dolphin can not walk";
        }
    }
}
