using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineLengthCalculation
{
    internal class EqualityCheckcs
    {
        public void CheckEquality()
        {
            Console.WriteLine("Enter 4 end points of line1 ");
            int x1, y1, x2, y2, X1, Y1, X2, Y2;
            // Console.WriteLine("Enter 4 end points of line1 ");
            x1 = int.Parse(Console.ReadLine());
            x2 = int.Parse(Console.ReadLine());
            y1 = int.Parse(Console.ReadLine());
            y2 = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter 4 end points of line2 ");

            X1 = int.Parse(Console.ReadLine());
            X2 = int.Parse(Console.ReadLine());
            Y1 = int.Parse(Console.ReadLine());
            Y2 = int.Parse(Console.ReadLine());


            float length1 = (float)Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

            float length2 = (float)Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2));
            Console.WriteLine("Equality is " + length1.Equals(length2));
        }
    }
}

