using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineLengthCalculation
{
    internal class LineLengthCalculate
    {
        public void CalculateLength()
        {
            Console.WriteLine("Calculate length");
            int x1, y1, x2, y2;
            Console.WriteLine("Enter 4 end points of line ");
            x1 = int.Parse(Console.ReadLine());
            x2 = int.Parse(Console.ReadLine());
            y1 = int.Parse(Console.ReadLine());
            y2 = int.Parse(Console.ReadLine());


            float length = (float)Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

            Console.WriteLine("Length of line is= " + length);
        }
    }
}
