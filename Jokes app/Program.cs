using System;
using System.Collections.Generic;

namespace JokeTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> jokes = new List<string>
            {
                "Why did the scarecrow win an award? Because he was outstanding in his field!",
                "Parallel lines have so much in common. It's a shame they'll never meet.",
                "Did you hear about the mathematician who’s afraid of negative numbers? He’ll stop at nothing to avoid them.",
                "I used to play piano by ear, but now I use my hands.",
                "Why don't scientists trust atoms? Because they make up everything!",
                "How do you organize a space party? You 'planet'!",
                "What do you call a bear with no teeth? A gummy bear.",
                "Why did the bicycle fall over? Because it was two-tired!",
                "I told my wife she was drawing her eyebrows too high. She looked surprised.",
                "Why don't skeletons fight each other? They don't have the guts.",
                "Why don't oysters donate to charity? Because they are shellfish.",
                "What do you get when you cross a snowman with a vampire? Frostbite.",
                "I'm on a seafood diet. I see food, and I eat it.",
                "Why did the tomato turn red? Because it saw the salad dressing!",
                "Why did the golfer bring two pairs of pants? In case he got a hole in one.",
                "How do you make a tissue dance? You put a little boogie in it!",
                "Why did the scarecrow become a successful politician? Because he was outstanding in his field.",
                "What do you call a bear that's stuck in the rain? A drizzly bear.",
                "Why don't scientists trust atoms? Because they make up everything!",
                "What did the big flower say to the little flower? 'Hi, bud!'",
                "Parallel lines have so much in common. It's a shame they'll never meet.",
                "Why don't skeletons fight each other? They don't have the guts.",
                "How does a penguin build its house? Igloos it together!",
                "I used to play piano by ear, but now I use my hands.",
                "Why can't you give Elsa from 'Frozen' a balloon? Because she will let it go!",
                "Why don't seagulls fly over the bay? Because then they'd be called bagels!",
                "What do you call a snowman with a six-pack? An abdominal snowman!",
                "How do you organize a space party? You 'planet'!",
                "What did one wall say to the other wall? I'll meet you at the corner!",
                "Why did the bicycle fall over? Because it was two-tired!"
            };

            Random random = new Random();
            bool continueTellingJokes = true;

            while (continueTellingJokes)
            {
                int randomIndex = random.Next(jokes.Count);
                string randomJoke = jokes[randomIndex];

                Console.WriteLine("Here's a joke for you:");
                Console.WriteLine(randomJoke);

                Console.Write("\nDo you want to hear another joke? (Y/N): ");
                string response = Console.ReadLine().ToUpper();

                if (response != "Y")
                {
                    continueTellingJokes = false;
                }
            }

            Console.WriteLine("Thanks for enjoying the jokes! Goodbye.");
        }
    }
}
