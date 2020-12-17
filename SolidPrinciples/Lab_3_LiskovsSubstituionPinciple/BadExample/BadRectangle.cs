using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.Lab_3_Liskov_s_Substituion_Pinciple.BadExample
{

    //This is parent class
   public  class BadRectangle
    {

        //on the bad example,parent class is BadRectangle class and members of BadRactengle assigned virtual
        public virtual int Height { get; set; }
        public virtual int Width { get; set; }
    }
}
