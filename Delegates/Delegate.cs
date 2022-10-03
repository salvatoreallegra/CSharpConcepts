namespace Delegates
{
    internal class Delegate
    {
        //Declare a delegate the returns a boolean and takes a number
        //
        public delegate bool NumberPredicate(int number);
        static void Main(string[] args)
        {
            int[] numbers = {1,2,3,4,5,6,7,8,9,10};

            NumberPredicate evenPredicate = isEven;

            //Call evenpredicate
            Console.WriteLine($"Calling Even Predicate: {evenPredicate(5)}");
            List<int> evenNumbers = FilterArray(numbers, evenPredicate);
            
            //Display the list
            foreach(int number in evenNumbers)
            {
                Console.Write($"{ number } ");
            }
            
        }

        // function that will return true or false if the number is even or odd.
        private static bool isEven(int number) => number % 2 == 0;

        //Filter a an array with the evenPredicate above
        private static List<int> FilterArray(int[] intArray, NumberPredicate predicate)
        {
            var result = new List<int>();
            foreach(int number in intArray)
            {
                if (predicate(number))
                {
                    result.Add(number);
                }

            }
            return result; 
        }
    }
}