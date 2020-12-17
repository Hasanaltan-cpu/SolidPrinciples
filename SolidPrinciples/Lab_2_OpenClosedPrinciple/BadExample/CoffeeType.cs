using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.Lab_2_OpenClosedPrinciple.BadExample
{
    public enum  CoffeeType
    {
        Latte,Espresso,Machiato
    }
    public class BadCoffee
    {
        public double GetTotalPrice(double amount,CoffeeType coffeeType)
        {
            double totalPrice = 0;
            if (coffeeType==CoffeeType.Espresso)
            {
                totalPrice += amount * 4.50;

            }
            else if (coffeeType==CoffeeType.Latte)
            {
                totalPrice += amount * 4.50;

            }
            else if (coffeeType==CoffeeType.Machiato)
            {
                totalPrice += amount * 6.75;
            }
            return totalPrice;
        }
    }
}
