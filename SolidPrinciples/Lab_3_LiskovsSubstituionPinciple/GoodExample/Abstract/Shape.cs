using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.Lab_3_Liskov_s_Substituion_Pinciple.GoodExample.Abstract
{
    public abstract class Shape
    {
        //For this principle ,avoid of parent class aim failure,

        public int Id { get; set; }
        public int Edge { get; set; }

    }
}
