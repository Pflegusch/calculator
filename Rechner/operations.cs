using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechner
{
    public class Operations
    {

        private double gcd(double a, double b)
        {
            if (b == 0) {
                return a; 
            }
            return gcd(b, a % b);
        }

        private double lcm(double a, double b)
        {
            if (a > b)
            {
                return (a / gcd(a, b)) * b;       
            } else
            {
                return (b / gcd(a, b)) * a; 
            }
        }

        public double addition(double nenner1, double nenner2, double zähler1, double zähler2)
        {
            // (1/2) + (3/4) = (4/8) + (6/8)
            double dominator = lcm(nenner1, nenner2); //8
            double multiplyer1 = dominator / nenner1; //4
            double multiplyer2 = dominator / nenner2; //2

            double numerator = (zähler1 * multiplyer1) + (zähler2 * multiplyer2);
            return numerator / dominator;           
        }

        public double subtraction(double nenner1, double nenner2, double zähler1, double zähler2)
        {
            // (3/4) / (1/3) = (5/12)
            double dominator = lcm(nenner1, nenner2);
            double multiplyer1 = dominator / nenner1;
            double multiplyer2 = dominator / nenner2; 

            double numerator = (zähler1 * multiplyer1) - (zähler2 * multiplyer2);
            return numerator / dominator;
        }

        public double multiplication(double nenner1, double nenner2, double zähler1, double zähler2)
        {
            // (3/4) * (2/5) = (6/20)
            return (zähler1 * zähler2) / (nenner1 * nenner2);
        }

        public double division(double nenner1, double nenner2, double zähler1, double zähler2)
        {
            // (1/2) / (3/4) = (2/3) 
            return multiplication(nenner1, zähler2, zähler1, nenner2);
        }

    }
}
