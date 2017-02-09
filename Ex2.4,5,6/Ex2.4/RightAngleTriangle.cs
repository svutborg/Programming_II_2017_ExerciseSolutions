using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2._4
{
    class RightAngleTriangle
    {
        /* private fields */
        private double legA;
        private double legB;
        private double hypotenuse;
        private double area;
        private double perimeter;
        
        /* Constructor */
        public RightAngleTriangle(double legA, double legB)
        {
            this.legA = legA; // Set private fields by the same name (without the 'this' it would not know that you ment the once beloning to the class)
            this.legB = legB;

            hypotenuse = Math.Sqrt(legA * legA + legB * legB); // Calculate the lenght og the hypotenuse based on the pythagorean theorem
            area = legA * legB / 2; // calculate the area of the triangle
            perimeter = legA + legB + hypotenuse; // sum up the sides of the triangle
        }

        /* Overwritten ToString() method */
        public override string ToString()
        {
            // return all parameters as a single string, with numbers limited to two decimals
            return $"LegA: {legA:0.00}\nLegB: {legB:0.00}\nHypotenuse: {hypotenuse:0.00}\nArea: {area:0.00}\nPerimeter: {perimeter:0.00}";
        }
    }
}
