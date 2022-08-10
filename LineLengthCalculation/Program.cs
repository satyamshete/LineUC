namespace LineLengthCalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Line Length Calculator");

            ////UC1
            LineLengthCalculate lineLengthCalculate = new LineLengthCalculate();
            lineLengthCalculate.CalculateLength();
        }
    }
}