namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Let's query an Array to get all the numbers that are even
            int[] numbers = { 3, 4, 5, 18, 22, 11, 90, 45, 78, 12 };
            var evenNumbers = from number in numbers
                              where number % 2 == 0
                              select number;
            
            //Loop over and print the values
            foreach(int number in evenNumbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("\n");
            //print out the first number in collection
            Console.WriteLine(evenNumbers.First());
        }
    }
}