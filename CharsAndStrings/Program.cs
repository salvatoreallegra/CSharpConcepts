namespace CharsAndStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            playWithCharacters();
            playWithStrings();

            //Let's see if we can build the string "F-35" out of the characters in a string
            string f35String = "axdi-95x34598fF36";
            bool isF35ComboPossible = containsF35(f35String);
            Console.WriteLine("Is an F-35 Possible? " + isF35ComboPossible);
            
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
        static bool containsF35(string f35String)
        {
            //Need to check if there is an F, a -, a 3 and a 5 in the string.
            //lets pseudocode it without code first
            /* Input case "7yk" will return false, you can't build an F-35 out of that string
             * Loop through stromg and Check first char, second char and 3rd char against an F - 3 5
             * use select case to set boolean value F satisfied, - satisfied etc....
             * use if statement to check if all boolean values are true
             * return true or false accordingly
             * loop through the string parameter
             */
            bool containsF = false;
            bool containsHyphen = false;
            bool contains3 = false;
            bool contains5 = false;

            foreach(char c in f35String)
            {
                switch (c)
                {
                    case 'F':
                        containsF = true;
                        break;
                    case '-':
                        containsHyphen = true;
                        break;
                    case '3':
                        contains3 = true;
                        break;
                    case '5':
                        contains5 = true;
                        break;
                }
            }
            if(containsF == true && containsHyphen == true && contains3 == true && contains5 == true)
                return true;
            else
                return false;
        }
    }
}