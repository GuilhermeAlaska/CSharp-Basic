

class Program
{
    static void Main(string[] args)
    {
        // First string variable
        string firstSentence = "It is a truth universally acknowledged, that a single man in possession of a good fortune, must be in want of a wife.";
        // Second string variable
        string firstSpeech = "\"My dear Mr. Bennet,\" said his lady to him one day, \"have you heard that Netherfield Park is let at last?\"";

        // Print variable and newline
        Console.WriteLine(firstSentence);
        Console.WriteLine("\n");
        Console.WriteLine(firstSpeech);
        Console.WriteLine("\n");

        // Declare the variables
        string beginning = "Once upon a time,";
        string middle = "a frog called Tom";
        string end = ".. jumped from a cliff and died.";
        // Concatenate the string and the variables
        string story = beginning + " " + middle + "." + end;

        // Print the story to the console 
        Console.WriteLine(story);
        Console.WriteLine("\n");

        // Create password
        string password = "a92301j2add";

        // Get password length
        int passwordLength = password.Length;

        // Check if password uses symbol
        //Console.WriteLine(passwordLength);
        int passwordCheck = password.IndexOf("!");
        // Print results
        Console.WriteLine($"The user password is {password}. Its length is {passwordLength} and it receives a {passwordCheck} check.");



        // User Name
        string name = "Farhad Hesam Abbasi";

        // Get first letter
        int charPosition = name.IndexOf("F");
        char firstLetter = name[charPosition];

        // Get last name
        int lastNamePosition = name.IndexOf("Abbasi");
        string lastName = name.Substring(lastNamePosition);
        // Print results
        Console.WriteLine(lastName);













        Console.ReadKey();
    }
}

