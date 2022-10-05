using System.Security.Cryptography.X509Certificates;

namespace ArraysAndLists
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> classGrades = new List<int>{ 989, 77, 66, 85, 91, 56, 33 };
            foreach(int number in classGrades)
            {
                Console.WriteLine(number);
            }
        }
    }
}