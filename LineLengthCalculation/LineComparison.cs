using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineLengthCalculation
{
    internal class LineComparison
    {
        public void CompareLine()
        {
            Console.WriteLine("Compare two Line");
            int x1, y1, x2, y2, X1, Y1, X2, Y2;
            Console.WriteLine("Enter 4 end points of line1 ");
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
            Console.WriteLine("Length1= {0} and Length2= {1}", length1, length2);
            int comparison = length1.CompareTo(length2);

            if (comparison == 0)
            {
                Console.WriteLine("Lines are Equal", comparison);

            }
            else if (comparison > 0)
            {
                Console.WriteLine("Line1 is greater than Line2 ", comparison);

            }
            else
            {
                Console.WriteLine("Line2 is greater than Line1", comparison);
            }
        }
    }
}
