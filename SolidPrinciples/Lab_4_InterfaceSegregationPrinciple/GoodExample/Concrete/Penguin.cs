using SolidPrinciples.Lab_4_InterfaceSegregationPrinciple.GoodExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.Lab_4_InterfaceSegregationPrinciple.GoodExample.Concrete
{
    public class Penguin : ISwimSeaAnimal,IWalkSeaAnimal
    {
        public string Swim()
        {
            return "All penguin swim";
        }

        public string Walk()
        {
            return "All penguin walk";
        }
    }
}
