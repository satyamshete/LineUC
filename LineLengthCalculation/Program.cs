namespace LineLengthCalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Line Length Calculator");

            ////UC1
            //LineLengthCalculate lineLengthCalculate = new LineLengthCalculate();
            //lineLengthCalculate.CalculateLength();

            /////UC2
            //EqualityCheckcs equalityCheckcs = new EqualityCheckcs();
            //equalityCheckcs.CheckEquality();

            ////////UC3
            LineComparison lineComparison = new LineComparison();
            lineComparison.CompareLine();
        }
    }
}