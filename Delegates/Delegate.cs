namespace Delegates
{
    internal class Delegate
    {
        //Declare a delegate the returns a boolean and takes a number
        //a delegate is actually a reference type, like a class, interface or record 
        public delegate bool NumberPredicate(int number);
        static void Main(string[] args)
        {
            int[] numbers = {1,2,3,4,5,6,7,8,9,10};

            //Assign the IsEven function to the variable of type Number Predicate
            //*Note that we can do this since the IsEven method has the same signature
            //and return type
            NumberPredicate evenPredicate = IsEven;

            //Call evenpredicate
            Console.WriteLine($"Calling Even Predicate: {evenPredicate(5)}");

            List<int> evenNumbers = FilterArray(numbers, evenPredicate);
            
            //Display the list
            DisplayList("Even Numbers",evenNumbers);

            List<int> oddNumbers = FilterArray(numbers, IsOdd);
            DisplayList("Odd Numbers", oddNumbers);

            List<int> numbersGreaterThan5 = FilterArray(numbers, IsOver5);
            DisplayList("Numbers > than 5", numbersGreaterThan5);

            
            
        }

        // function that will return true or false if the number is even or odd.
        private static bool IsEven(int number) => number % 2 == 0;

        private static bool IsOdd(int number) => number % 2 == 1;

        private static bool IsOver5(int number) => number > 5;

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
        private static void DisplayList(string description, List<int> list)
        {
            Console.Write(description);
            foreach(var number in list)
            {
                Console.Write($" {number} ");
            }
            Console.WriteLine();
        }
    }
}