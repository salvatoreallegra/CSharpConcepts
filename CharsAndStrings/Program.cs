namespace CharsAndStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            playWithCharacters();
            playWithStrings();
            
        }

        static void playWithCharacters()
        {
            //Let's try some static char methods
            char aCharacter = 'a';
            //is it a digit?  True or False
            Console.WriteLine(Char.IsDigit(aCharacter));

            char aCharacter9 = '9';
            //is it a digit?  True or False
            Console.WriteLine(Char.IsDigit(aCharacter9));

            //let's see if we can assign a unicode value to a char, should be capital 'A'
            char unicodeChar = '\u0041';
            Console.WriteLine(unicodeChar);

            //Print out the next unicode char using the increment operator
            //Prints out Capital Y, it works!  
            char xChar = 'X';
            Console.WriteLine(++xChar);

        }
        static void playWithStrings()
        {
            char charInString;
            string aString = "Some rando string";
            //get the 3rd character in a string
            charInString = aString[2];
            Console.WriteLine(charInString);
        }
    }
}