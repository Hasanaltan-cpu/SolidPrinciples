using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.Lab_3_Liskov_s_Substituion_Pinciple.BadExample
{
    public class BadSquare:BadRectangle
    {

        //
        int _height;
        int _widht;

        public override int Height { get =>_height
                ; set => _height = value; }

        public override int Width { get => _widht
                ; set => _widht = value; }
    }
}
