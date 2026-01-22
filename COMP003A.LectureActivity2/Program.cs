namespace COMP003A.LectureActivity2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number.");
            string first = Console.ReadLine();

            
            
            Console.WriteLine("Enter the second number.");
            string second = Console.ReadLine();


            var dfirst = double.Parse(first);
            var dsecond = double.Parse(second);

            var sum = dfirst + dsecond;
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine($"Sum41: {sum}.");

            var average = (dfirst + dsecond) / 2;
            Console.WriteLine("Avg: " + average);
            Console.WriteLine($"Average: {average}");

            bool greater = dfirst > dsecond;
            bool notEqual = dfirst != dsecond;
            Console.WriteLine(greater);
            Console.WriteLine(notEqual);
        }
    }
}
