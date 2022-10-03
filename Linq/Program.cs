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
                              orderby number
                              select number;
            
            //Loop over and print the values
            foreach(int number in evenNumbers)
            {
                Console.WriteLine(number);
            }

                   

            string[] exoticCars = { "Ferrari", "Lamborghini", "Bugatti", "McLaren" };
            useLinqOnStringArray(exoticCars);

        }
               
        private static void useLinqOnStringArray(string[] inputArray)
        {
            var carWithG = from exoticCar in inputArray
                    where exoticCar.Contains("g")
                    select exoticCar;

            foreach (string car in carWithG)
            {
                Console.WriteLine(car);
            }
        }
    }
}