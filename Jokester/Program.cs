namespace Jokester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] questions = {
             "Q: Why did the cow have to stand up while watching TV? ",
             "Q: What do you call terrifying Cow dreams? ",
             "Q: What does a cow say in a traffic jam?",
            "Q: How does a cow know what day it is?",
            "Q: Why doesn't Sweden export its cattle?",
             "Q: Where do cows eat?",
             "Q: What was a cow's favorite subject in school?",
             "Q: Where do cows go on vacation?",
             "Q: What do you call the hair under a cow's nose?",
             "Q: What newspaper do cows read?",
             "Q: What kind of exercise do cows like?",
             "Q: What do you call a cow with a sunburn?",
             "Q: What do you call a cow that just gave birth?"
            };
            string[] answers = {
             "A: She didn't have a coooow-ch!",
             "A: Night moooos!",
             "A: Moooooo-ve!",
             "A: She looks at her cow-an-der!",
             "A: It wants to keep its \"Stockholm\"!",
             "A: In a Calf-e-teria!",
             "A: Cow-cul-us!",
             "A: To Ber-mooo-da!",
             "A: A mooooo stache!",
             "A: The Daily Moos!",
             "A: Cow-a-stenics!",
             "A: Roast beef!",
             "A: DeCALFenated!"
            };

            string userInput = "";
            do
            {
                Random random = new Random();
                int randomNumber = random.Next(0, questions.Length - 1);
                Console.WriteLine("Joke of the day! ");
                Console.WriteLine(questions[randomNumber]);
                Console.WriteLine(answers[randomNumber]);
                Console.WriteLine("Do you want another joke? (yes/no) ");
                userInput = Console.ReadLine();

            } while (userInput.ToLower() == "yes");
        }
    }
}