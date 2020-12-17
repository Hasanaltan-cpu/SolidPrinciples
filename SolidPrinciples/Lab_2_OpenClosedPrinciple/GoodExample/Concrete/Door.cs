﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.Lab_2_OpenClosedPrinciple.GoodExample.Concrete
{
    public class Door : GoodCar
    {
        public override double GetTotalPrice(double amount)
        {
            return amount*5.21;
        }
    }
}
