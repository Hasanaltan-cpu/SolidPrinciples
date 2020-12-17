using SolidPrinciples.Lab_4_InterfaceSegregationPrinciple.GoodExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.Lab_4_InterfaceSegregationPrinciple.GoodExample.Concrete
{
    public class Dolphin : IWalknessSeaAnimal
    {
        public string Swim()
        {
            return "All Dolphin can walk" ;
        }
    }
}
