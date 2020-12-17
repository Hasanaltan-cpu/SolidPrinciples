using SolidPrinciples.Lab_3_Liskov_s_Substituion_Pinciple.GoodExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.Lab_3_Liskov_s_Substituion_Pinciple.GoodExample.Concrete
{
   public  class Square:Shape
    {
        public double SquareArea()
        {
            return Edge * Edge;
        }
    }
}
