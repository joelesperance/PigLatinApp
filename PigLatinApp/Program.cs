Console.WriteLine($@"
██████╗░██╗░██████╗░  ██╗░░░░░░█████╗░████████╗██╗███╗░░██╗
██╔══██╗██║██╔════╝░  ██║░░░░░██╔══██╗╚══██╔══╝██║████╗░██║
██████╔╝██║██║░░██╗░  ██║░░░░░███████║░░░██║░░░██║██╔██╗██║
██╔═══╝░██║██║░░╚██╗  ██║░░░░░██╔══██║░░░██║░░░██║██║╚████║
██║░░░░░██║╚██████╔╝  ███████╗██║░░██║░░░██║░░░██║██║░╚███║
╚═╝░░░░░╚═╝░╚═════╝░  ╚══════╝╚═╝░░╚═╝░░░╚═╝░░░╚═╝╚═╝░░╚══╝

████████╗██████╗░░█████╗░███╗░░██╗░██████╗██╗░░░░░░█████╗░████████╗░█████╗░██████╗░
╚══██╔══╝██╔══██╗██╔══██╗████╗░██║██╔════╝██║░░░░░██╔══██╗╚══██╔══╝██╔══██╗██╔══██╗
░░░██║░░░██████╔╝███████║██╔██╗██║╚█████╗░██║░░░░░███████║░░░██║░░░██║░░██║██████╔╝
░░░██║░░░██╔══██╗██╔══██║██║╚████║░╚═══██╗██║░░░░░██╔══██║░░░██║░░░██║░░██║██╔══██╗
░░░██║░░░██║░░██║██║░░██║██║░╚███║██████╔╝███████╗██║░░██║░░░██║░░░╚█████╔╝██║░░██║
░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░╚══════╝╚═╝░░╚═╝░░░╚═╝░░░░╚════╝░╚═╝░░╚═╝");

string phrase = GetPhrase();

string[] phraseArray = phrase.Split(' ');

foreach (string word in phraseArray)
{
    char firstLetter = word[0];
    string truncatedWord = word.Substring(1);

    if (word[0] == 'a' || word[0] == 'e' || word[0] == 'i' || word[0] == 'o' || word[0] == 'u')
    {
        string pigLatin = word + "way";
        Console.Write(pigLatin.ToLower() + " ");
    }
    else if (word.Length > 1)
    {
        string pigLatin = $"{truncatedWord}{firstLetter}ay ";
        Console.Write(pigLatin.ToLower());
    }
    else
    {
        Console.Write(word.ToLower() + " ");
    }
}

Console.WriteLine("\n\n\n");

static string GetPhrase()
{
    Console.WriteLine("\nEnter a phrase to be translated to Pig-Latin:\n");
    string phrase = Console.ReadLine();
    Console.WriteLine("\n");
    return phrase;
}