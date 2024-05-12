using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        ScriptureStorage library = new ScriptureStorage();

        library.AddScripture(new Reference("Alma", 49,17), "And now behold it came to pass, that when the Lamanites had found that Lehi commanded the city they were again disappointed, for they feared Lehi exceedingly; nevertheless their chief captains had sworn with an oath to attack the city; therefore, they brought up their armies.");
        library.AddScripture(new Reference("3 Nephi", 9,5), "And behold, that great city Moronihah have I covered with earth, and the inhabitants thereof, to hide their iniquities and their abominations from before my face, that the blood of the prophets and the saints shall not come any more unto me against them.");
        library.AddScripture(new Reference("Alma", 50,8), "The Lord is my shepherd, I shall not want.");
        library.AddScripture(new Reference("Isaiah", 40, 31), "But those who hope in the Lord will renew their strength.");
        library.AddScripture(new Reference("Matthew", 11, 28), "Come to me, all you who are weary and burdened, and I will give you rest.");
        library.AddScripture(new Reference("Philippians", 4, 13), "I can do all things through Christ who strengthens me.");
        library.AddScripture(new Reference("John", 3,5,0), "Except a man be born of water, and of the Spirit, he cannot enter into the kingdom of God;Jesus answered, Verily, verily, I say unto thee, Except a man be born of water and of the Spirit, he cannot enter into the kingdom of God.");
        

        while (true)
        {
            Console.Clear();
            Scripture scripture = library.SelectRandomScripture();

            if (scripture != null)
            {
                bool memorized = false;

                while (!scripture.IsCompletelyHidden())
                {
                    Console.Clear();
                    Console.WriteLine(scripture.RenderScripture());

                    Console.Write("Press Enter to hide a word or type 'quit' to exit: ");
                    string input = Console.ReadLine();

                    if (input.ToLower() == "quit")
                        return;

                    scripture.HideRandom();

                    if (scripture.IsCompletelyHidden())
                    {
                        memorized = true;
                        break;
                    }
                }

                if (memorized)
                {
                    Console.Clear();
                    Console.WriteLine("You've memorized the entire scripture!");
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("The scripture library is empty. Add scriptures or load them from files.");
                Console.WriteLine("Press Enter to exit.");
                Console.ReadLine();
                return;
            }
        }
    }
}