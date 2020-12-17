using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.Lab_3_Liskov_s_Substituion_Pinciple.BadExample
{
    public class BadAreaCalculator
    {
        public static double CalculateArea(BadRectangle badRectangle)
        {
            return badRectangle.Height * badRectangle.Width;

        }

        public static double CalculateAre(BadSquare badSquare)
        {

            //
            return badSquare.Height * badSquare * Withd;

        }
    }
}
